using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

  }
}
