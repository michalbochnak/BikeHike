using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//
// BusinessTier:
//
namespace BusinessTier
{
  //
  // Business:
  //
  public class Business
  {
    private string _DBFile;
    private DataAccessTier.Data dataTier;

    //
    // Business():
    //
    public Business(string dbFilename)
    {
      _DBFile = dbFilename;
      dataTier = new DataAccessTier.Data(dbFilename);
    }

    //
    // TestConnection():
    //
    public bool TestConnection()
    {
      return dataTier.TestConnection();
    }


    //
    // GetCustomers():
    //
    // Returns all the customers from Db as a read only list.
    //
    public IReadOnlyList<Customer> GetCustomers()
    {
      List<Customer> customers = new List<Customer>();

      try
      {
        dataTier.openConnection();

        // query
        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
        SELECT *
        FROM Customer WITH(INDEX(CustomerLastName_Index))
        ORDER BY LastName ASC,
        FirstName ASC;
        " ));

        // build list
        foreach (DataRow row in ds.Tables["TABLE"].Rows)
        {
          customers.Add(
            new Customer(
              Convert.ToInt32(row["CID"].ToString()),
              row["FirstName"].ToString(),
              row["LastName"].ToString(),
              row["Email"].ToString()
              )
            );
        }
      }
      catch (Exception e)
      {
        MessageBox.Show("GetCustomers(): " + e.Message);
        throw new ApplicationException(string.Format
          ("Error in Business.GetCustomers(): '{0}'", e.Message));
      }
      finally
      {
        dataTier.closeConnection();
      }

      return customers;
    }


    //
    // GetBikes():
    //
    // Returns all the bikes from Db as a read only list.
    //
    public IReadOnlyList<Bike> GetBikes()
    {
      List<Bike> bikes = new List<Bike>();

      try
      {
        dataTier.openConnection();
        // query
        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
          SELECT BID, BikeYear, Rented, BikeDescription, HourlyPrice
          FROM Bike WITH(INDEX(BikeTID_Index))
          INNER JOIN BikeType ON Bike.TID = BikeType.TID
          ORDER BY BID ASC;
          "
          ));

        // build a list
        foreach (DataRow row in ds.Tables["TABLE"].Rows)
        {
          bikes.Add(
            new Bike(
              Convert.ToInt32(row["BID"].ToString()),
              Convert.ToInt32(row["BikeYear"].ToString()),
              row["BikeDescription"].ToString(),
              Convert.ToDecimal(row["HourlyPrice"].ToString()),
              Convert.ToBoolean(row["Rented"].ToString())
            )
          );
        }
      }
      catch (Exception e)
      {
        throw new ApplicationException(string.Format
          ("Error in Business.GetCustomers(): '{0}'", e.Message));
      }
      finally
      {
        dataTier.closeConnection();
      }

      return bikes;
    }


    //
    // GetCustRentStatus():
    //
    // Returns true if customer have ongoing rental,
    // false if not.
    //
    public bool GetCustRentStatus(string cid)
    {
      bool rentStatus = false;

      try
      {
        dataTier.openConnection();

        Object result = dataTier.ExecuteScalarQuery(string.Format(@"
          SELECT COUNT(*)
          FROM Rental
          WHERE CID = {0}
          AND ActDuration IS NULL;
        ", cid));    

        if (Convert.ToInt32(result) > 0)
          rentStatus = true;
        else
          rentStatus = false;
      }
      catch (Exception exc)
      {
        MessageBox.Show("GetCustRentStatus(): " + exc.Message);
      }
      finally
      {
        dataTier.closeConnection();
      }

      return rentStatus;
    }


    //
    // GetBikeRentStatus():
    //
    // Returns true if bike is currently rented,
    // false if not.
    //
    public bool GetBikeRentStatus(int bid)
    {
      bool rentStatus = false;

      try
      {
        dataTier.openConnection();

        Object result = dataTier.ExecuteScalarQuery(string.Format(@"
        SELECT Rented
        FROM Bike
        WHERE BID = {0};
        ", bid));

        if (Convert.ToInt32(result) == 1)
          rentStatus = true;
        else
          rentStatus = false;

      }
      catch (Exception exc)
      {
        MessageBox.Show("GetBikeRentStatus(): " + exc.Message);
      }
      finally
      {
        dataTier.closeConnection();
      }

      return rentStatus;
    }


    //
    // GetBikesToRent():
    //
    // Returns bikes that are available to rent.
    //
    public IReadOnlyList<Bike> GetBikesToRent()
    {
      List<Bike> bikes = new List<Bike>();

      try
      {
        dataTier.openConnection();

        // query
        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
          SELECT BID, BikeYear, Rented, BikeDescription, HourlyPrice
          FROM Bike WITH(INDEX(BikeTID_Index))
          INNER JOIN BikeType ON Bike.TID = BikeType.TID
          WHERE Rented = 0
          ORDER BY BikeDescription ASC,
          BikeYear DESC,
          BID ASC;
          "
          ));

        // build a list
        foreach (DataRow row in ds.Tables["TABLE"].Rows)
        {
          bikes.Add(
            new Bike(
              Convert.ToInt32(row["BID"].ToString()),
              Convert.ToInt32(row["BikeYear"].ToString()),
              row["BikeDescription"].ToString(),
              Convert.ToDecimal(row["HourlyPrice"].ToString()),
              Convert.ToBoolean(row["Rented"].ToString())
            )
          );
        }
      }
      catch (Exception e)
      {
        MessageBox.Show("GetBikesToRent(): " + e.Message);
        throw new ApplicationException(string.Format
          ("Error in Business.GetCustomers(): '{0}'", e.Message));
      }
      finally
      {
        dataTier.closeConnection();
      }

      return bikes;
    }


    //
    // RentBikes():
    //
    // Handles nessesary Db updates for the rental.
    //
    public int RentBikes(List<int> selectedBikes, int cid, decimal expDur)
    {
      int rid = -1;
      SqlTransaction tx = null;
      int retries = 0;

      while (retries < 3)
      {
        try
        {
          dataTier.openConnection();
          tx = dataTier.GetDbConnection().BeginTransaction(IsolationLevel.Serializable);
          dataTier.setCmdTransaction(tx);

          // add rental table entry
          int rowsModified = dataTier.ExecuteActionQuery(string.Format(@"
            INSERT INTO Rental (CID, StartTime, ExpDuration, NumBikes)
            VALUES ({0}, GETDATE(), {1}, {2});
            ", cid, expDur, selectedBikes.Count));

          // insert failed
          if (rowsModified != 1)
          {
            HandleInsertFailure(tx);
            return -1;
          }

          rid = GetLastRentalId(false);

          if (rid == -1)
          {
            tx.Rollback();
            dataTier.closeConnection();
            MessageBox.Show("RentBikes(): Retrieving RID failed");
            return -1;
          }

          // update bike table and add rental details
          foreach (int bid in selectedBikes)
          {
            rowsModified = dataTier.ExecuteActionQuery(string.Format(@"
              INSERT INTO RentalDetail(RID, BID)
              VALUES ({0}, {1});
              ", rid, bid));

            if (rowsModified != 1)
            {
              HandleInsertFailure(tx);
              return -1;
            }

            rowsModified = dataTier.ExecuteActionQuery(string.Format(@"
              UPDATE Bike
              SET Rented = 1
              WHERE BID = {0};
              ", bid));

            if (rowsModified != 1)
            {
              tx.Rollback();
              dataTier.closeConnection();
              MessageBox.Show("RentBikes(): UPDATE failed");
              return -1;
            }
          }

          tx.Commit();
          retries = 4;
        }
        catch (SqlException exc)
        {
          if (exc.Number == 1205)
            retries++;
        }
        catch (Exception exc)
        {
          MessageBox.Show("Error in RentBikes(): " + exc.Message);
        }
        finally
        {
          dataTier.closeConnection();
        }
      }

      return rid;
    }


    //
    // HandleInsertFailure():
    //
    private void HandleInsertFailure(SqlTransaction tx)
    {
      tx.Rollback();
      dataTier.closeConnection();
      MessageBox.Show("RentBikes(): INSERT failed");
    }


    //
    // GetBikesToReturn():
    //
    // Returns a list with bike IDs that are rented under the provided customer ID
    //
    public List<int> GetBikesToReturn(int cid)
    {
      List<int> bikesIds = new List<int>();
      SqlTransaction tx = null;
      int retries = 0;

      while (retries < 3)
      {
        try
        {
          dataTier.openConnection();
          tx = dataTier.GetDbConnection().BeginTransaction(IsolationLevel.Serializable);
          dataTier.setCmdTransaction(tx);

          // get rental ID
          object result = dataTier.ExecuteScalarQuery(string.Format(@"
            SELECT RID
            FROM Rental
            WHERE CID = {0}
            AND ActDuration IS NULL;
            ", cid));

          if (result == null)
          {
            tx.Rollback();
            dataTier.closeConnection();
            MessageBox.Show("GetBikesToReturn(): SELECT failed");
            return bikesIds;
          }

          int rid = Convert.ToInt32(result);

          // get bike IDs
          DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
            SELECT BID
            FROM RentalDetail
            WHERE RID = {0};
            ", rid));

          if (ds.Tables.Count == 0)
          {
            HandleSelectFailure(tx, "GetBikesToReturn()");
            return bikesIds;
          }

          // build list
          foreach (DataRow row in ds.Tables["TABLE"].Rows)
            bikesIds.Add(Convert.ToInt32(row["bid"]));
        }
        catch (Exception exc)
        {
          MessageBox.Show("GetBikesToReturn(): " + exc.Message);
        }
        finally
        {
          dataTier.closeConnection();
        }
      }

      return bikesIds;
    }


    //
    // HandleSelectFailure():
    //
    private void HandleSelectFailure(SqlTransaction tx, string caller)
    {
      tx.Rollback();
      dataTier.closeConnection();
      MessageBox.Show(string.Format(@"HandleSelectFailure() called from {0}: 
        SELECT failed", caller));
    }

    //
    // GetLastRentalId():
    //
    public int GetLastRentalId(bool shouldOpenAndCloseConnection)
    {
      int id = -1;

      try
      {
        if (shouldOpenAndCloseConnection)
          dataTier.openConnection();

        id = Convert.ToInt32(dataTier.ExecuteScalarQuery(string.Format(@"
          SELECT TOP 1 RID
          FROM Rental
          ORDER BY RID DESC;
          ")));
      }
      catch (Exception exc)
      {
        MessageBox.Show("GetLastRentalId(): " + exc.Message);
      }
      finally
      {
        if (shouldOpenAndCloseConnection)
          dataTier.closeConnection();
      }

      return id;
    }


    //
    // GetExpectedReturnTimeBike():
    //
    // Calculates the expected return time for the given bike based on the expected 
    // rent duration provided by customer
    //
    public string GetExpectedReturnTimeBike(int bid)
    {
      string time = null;

      try
      {
        dataTier.openConnection();

        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
        SELECT StartTime, ExpDuration
        FROM Rental
        INNER JOIN RentalDetail ON Rental.RID = RentalDetail.RID
        INNER JOIN Bike ON RentalDetail.BID = Bike.BID
        WHERE Bike.BID = {0}
        AND ActDuration IS NULL;
        ", bid));

        // calculate and return the expected return time
        DataRow dr = ds.Tables["TABLE"].Rows[0];
        DateTime startTime = Convert.ToDateTime(dr["StartTime"]);

        time = startTime.AddHours(Convert.ToDouble(dr["ExpDuration"])).ToString();
      }
      catch (Exception exc)
      {
        MessageBox.Show("Error in GetExpectedReturnTimeBike(): " + exc.Message);
        time = null;
      }
      finally
      {
        dataTier.closeConnection();
      }

      return time;
    }


    //
    // GetExpectedReturnTimeCust():
    //
    // Calculates the expected return time for the given customer based on the expected 
    // rent duration provided by customer
    //
    public string GetExpectedReturnTimeCust(int cid)
    {
      string time = null;

      try
      {
        dataTier.openConnection();

        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
        SELECT StartTime, ExpDuration
        FROM Rental
        WHERE CID = {0}
        AND ActDuration IS NULL;
        ", cid));

        // calculate and return the expected return time
        DataRow dr = ds.Tables["TABLE"].Rows[0];
        DateTime startTime = Convert.ToDateTime(dr["StartTime"]);

        time = startTime.AddHours(Convert.ToDouble(dr["ExpDuration"])).ToString();
      }
      catch (Exception exc)
      {
        MessageBox.Show("Error in GetExpectedReturnTimeCust(): " + exc.Message);
        time = null;
      }
      finally
      {
        dataTier.closeConnection();
      }

      return time;
    }


    //
    // GetNumRentedBikes():
    //
    // Get number of bikes rented by the given customer
    //
    public string GetNumRentedBikes(int cid)
    {
      string num = null;

      try
      {
        dataTier.openConnection();

        object result = dataTier.ExecuteScalarQuery(string.Format(@"
        SELECT numBikes
        FROM Rental
        WHERE CID = {0};
        ", cid));

        num = result.ToString();
      }
      catch (Exception exc)
      {
        MessageBox.Show("Error in GetExpectedReturnTime(): " + exc.Message);
        num = null;
      }
      finally
      {
        dataTier.closeConnection();
      }

      return num;
    }


    //
    // ReturnBikes():
    //
    // Handles nessesary updates in Db that are related to returning a bike
    //
    public double ReturnBikes(int cid)
    {
      double price = -1;

      try
      {
        dataTier.openConnection();

        // retrieve Rental ID and start time
        DataSet ds_1 = dataTier.ExecuteNonScalarQuery(string.Format(@"
          SELECT RID, StartTime
          FROM Rental
          WHERE CID = {0}
          AND ActDuration IS NULL;
        ", cid));

        string rid = ds_1.Tables["TABLE"].Rows[0]["RID"].ToString();
        DateTime startTime = Convert.ToDateTime(ds_1.Tables["TABLE"].Rows[0]["StartTime"]);

        //retrieve bikes IDs that were rented
        DataSet ds_2 = dataTier.ExecuteNonScalarQuery(string.Format(@"
          SELECT BID
          FROM RentalDetail
          WHERE RID = {0};
        ", rid));

        // update bike statuses as not rented
        dataTier.ExecuteActionQuery(string.Format(@"
          UPDATE Bike
          SET Rented = 0
          FROM Bike 
            INNER JOIN RentalDetail ON RentalDetail.BID = Bike.BID
          WHERE RID = {0};
        ", rid));

        // calculate duration of rental
        double duration = (DateTime.Now - startTime).TotalHours;

        // calculate totalPrice
        string totalPrice = (Convert.ToDouble(dataTier.ExecuteScalarQuery(string.Format(@"
          SELECT SUM(HourlyPrice) AS total
          FROM RentalDetail
          INNER JOIN Bike WITH(INDEX(BikeTID_Index)) ON RentalDetail.BID = Bike.BID
          INNER JOIN BikeType ON Bike.TID = BikeType.TID
          WHERE RentalDetail.RID = {0};
        ", rid))) * duration).ToString();

        // update rental table
        dataTier.ExecuteActionQuery(string.Format(@"
          UPDATE Rental
          SET ActDuration = {0}, TotalPrice = {1}
          WHERE RID = {2};
        ", duration, totalPrice, rid));

        price =  Math.Round(Convert.ToDouble(totalPrice), 2);
      }
      catch (Exception exc)
      {
        MessageBox.Show("Error in GetExpectedReturnTime(): " + exc.Message);
        price = -1;
      }
      finally
      {
        dataTier.closeConnection();
      }

      return price;
    }


    //
    // resetDatabase():
    //
    public void ResetDatabase()
    {
      try
      {
        dataTier.openConnection();

        dataTier.ExecuteActionQuery(@"
          DELETE FROM RentalDetail; 

          DELETE FROM Rental;

          UPDATE Bike
          SET Rented = 0;    
      ");
      }
      catch (Exception exc)
      {
        MessageBox.Show("resetDatabase(): " + exc.Message);
      }
      finally
      {
        dataTier.closeConnection();
      }
    }

  } // Business class

} // BusinessTier namespace
