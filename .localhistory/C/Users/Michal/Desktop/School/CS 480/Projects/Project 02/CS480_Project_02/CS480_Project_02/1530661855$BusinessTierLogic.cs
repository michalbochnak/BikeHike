using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessTier
{
  public class Business
  {
    private string _DBFile;
    private DataAccessTier.Data dataTier;

    ///
    /// <summary>
    /// Constructs a new instance of the business tier.  The format
    /// of the filename should be either |DataDirectory|\filename.mdf,
    /// or a complete Windows pathname.
    /// </summary>
    /// <param name="DatabaseFilename">Name of database file</param>
    /// 
    public Business(string dbFilename)
    {
      _DBFile = dbFilename;
      dataTier = new DataAccessTier.Data(dbFilename);
    }

    ///
    /// <summary>
    ///  Opens and closes a connection to the database, e.g. to
    ///  startup the server and make sure all is well.
    /// </summary>
    /// <returns>true if successful, false if not</returns>
    /// 
    public bool TestConnection()
    {
      return dataTier.TestConnection();
    }

    ///
    /// <summary>
    /// Returns all customers, ordered by name.
    /// </summary>
    /// <returns>Read-only list of Customer objects</returns>
    ///  
    public IReadOnlyList<Customer> GetCustomers()
    {
      List<Customer> customers = new List<Customer>();

      try
      {
        //DataAccessTier.Data dat = new DataAccessTier.Data(_DBFile);
        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
          SELECT *
          FROM Customer
          ORDER BY LastName ASC,
          FirstName ASC;
          "
          ));

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
        throw new ApplicationException(string.Format
          ("Error in Business.GetCustomers(): '{0}'", e.Message));
      }

      return customers;
    }


    public IReadOnlyList<Bike> GetBikes()
    {
      List<Bike> bikes = new List<Bike>();

      try
      {
        //DataAccessTier.Data dat = new DataAccessTier.Data(_DBFile);
        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
          SELECT BID, BikeYear, Rented, BikeDescription, HourlyPrice
          FROM Bike
          INNER JOIN BikeType ON Bike.TID = BikeType.TID
          ORDER BY BID ASC;
          "
          ));

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

      return bikes;
    }


    public bool GetCustRentStatus(string cid)
    {
      Object result = dataTier.ExecuteScalarQuery(string.Format(@"
        SELECT COUNT(*)
        FROM Rental
        WHERE CID = {0}
        AND ActDuration IS NULL;
      ", cid));    

      if (Convert.ToInt32(result) > 0)
        return true;
      else
        return false;
    }

    public bool GetBikeRentStatus(int bid)
    {
      Object result = dataTier.ExecuteScalarQuery(string.Format(@"
        SELECT Rented
        FROM Bike
        WHERE BID = {0};
      ", bid));

      if (Convert.ToInt32(result) == 1)
        return true;
      else
        return false;
    }

    public IReadOnlyList<Bike> GetBikesToRent()
    {
      List<Bike> bikes = new List<Bike>();

      try
      {
        //DataAccessTier.Data dat = new DataAccessTier.Data(_DBFile);
        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
          SELECT BID, BikeYear, Rented, BikeDescription, HourlyPrice
          FROM Bike
          INNER JOIN BikeType ON Bike.TID = BikeType.TID
          WHERE Rented = 0
          ORDER BY BikeDescription ASC,
          BikeYear DESC,
          BID ASC;
          "
          ));

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

      return bikes;
    }


    public int RentBikes(List<int> selectedBikes, int cid, decimal expDur)
    {
      try
      {
        // add rental table entry
        dataTier.ExecuteActionQuery(string.Format(@"
        INSERT INTO Rental (CID, StartTime, ExpDuration, NumBikes)
        VALUES ({0}, GETDATE(), {1}, {2});
      ", cid, expDur, selectedBikes.Count));

        int rid = GetLastRentalId();

        // update bike table and add rental details
        foreach (int bid in selectedBikes)
        {
          dataTier.ExecuteActionQuery(string.Format(@"
          INSERT INTO RentalDetail(RID, BID)
          VALUES ({0}, {1});
        ", rid, bid));

          dataTier.ExecuteActionQuery(string.Format(@"
          UPDATE Bike
          SET Rented = 1
          WHERE BID = {0};
        ", bid));
        }

        return rid;
      }
      catch (Exception exc)
      {
        MessageBox.Show("Error in RentBikes(): " + exc.Message);
      }

      return -1;
    }


    public int GetLastRentalId()
    {
      return Convert.ToInt32(dataTier.ExecuteScalarQuery(string.Format(@"
        SELECT TOP 1 RID
        FROM Rental
        ORDER BY RID DESC;
      ")));
    }


    public string GetExpectedReturnTime(int bid)
    {
      try
      {
        DataSet ds = dataTier.ExecuteNonScalarQuery(string.Format(@"
        SELECT StartTime, ExpDuration
        FROM Rental
        INNER JOIN RentalDetail ON Rental.RID = RentalDetail.RID
        INNER JOIN Bike ON RentalDetail.BID = Bike.BID
        WHERE Bike.BID = {0};
        ", bid));

        DataRow dr = ds.Tables["TABLE"].Rows[0];
        DateTime startTime = Convert.ToDateTime(dr["StartTime"]);

        return startTime.AddHours(Convert.ToDouble(dr["ExpDuration"])).ToString();
      }
      catch (Exception exc)
      {
        MessageBox.Show("Error in GetExpectedReturnTime(): " + exc.Message);
        return null;
      }

    }

  }
}
