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


    public bool GetRentStatus(string cid)
    {
      Object result = dataTier.ExecuteScalarQuery(string.Format(@"
        SELECT COUNT(*)
        FROM Rental
        WHERE CID = {0}
        AND ActDuration = NULL;
      ", cid));

      if (Convert.ToInt32(result) != 0)
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


    public void RentBikes(List<int> selectedBikes, int cid)
    {
      foreach (int i in selectedBikes)
      {
        MessageBox.Show("-" + i + "-");
      }
    }

  }
}
