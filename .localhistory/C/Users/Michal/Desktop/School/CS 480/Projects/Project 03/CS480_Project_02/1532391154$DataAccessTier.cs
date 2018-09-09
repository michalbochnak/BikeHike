//
// Data Access Tier: uses ADO.NET to execute SQL against an underlying
// SQL Server database.
//

using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.ExceptionServices;

namespace DataAccessTier
{

  public class Data
  {
    //
    // Fields:
    //
    private string _DBFile;
    private string _DBConnectionInfo;
    private SqlCommand cmd;
    private SqlConnection db;

    //
    // constructor:
    //
    public Data(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;
      _DBConnectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\{0};Integrated Security=True;",
        DatabaseFilename);
      cmd = new SqlCommand();
      db = new SqlConnection(_DBConnectionInfo);
    }

    //
    // GetDatabaseName():
    //
    public string GetDatabaseName()
    {
      return _DBFile;
    }

    //
    // TestConnection:  returns true if the database can be successfully opened and closed,
    // false if not.
    //
    public bool TestConnection()
    {
      bool  state = false;

      try
      {
        db.Open();

        state = (db.State == ConnectionState.Open);
      }
      catch
      {
        // ignore and just report false
      }
      finally
      {
        db.Close();
      }

      return state;
    }

    //
    // ExecuteScalarQuery:  executes a scalar Select query, returning the single result 
    // as an object.  
    //
    // Example:  Select CID From Customers Where Name='Jane Doe';
    //
    public object ExecuteScalarQuery(string sql)
    {
      //SqlConnection db = null;

      try
      {
        //db = new SqlConnection(_DBConnectionInfo);
        //db.Open();

        cmd.CommandText = sql;

        object result = cmd.ExecuteScalar();

        return result;
      }
      catch(Exception ex)
      {
        //
        // something failed, so rethrow the exception so caller knows:
        //
        ExceptionDispatchInfo.Capture(ex).Throw();  // rethrow while preserving stack
        throw;  // avoid compiler warnings
      }
      finally
      {
        //
        // close connection:
        //
        //if (db != null && db.State != ConnectionState.Closed)
        //  db.Close();
      }
    }

    // 
    // ExecuteNonScalarQuery:  executes a Select query that generates a temporary table,
    // returning this table in the form of a Dataset.
    //
    public DataSet ExecuteNonScalarQuery(string sql)
    {
      //SqlConnection db = null;

      try
      {
        //db = new SqlConnection(_DBConnectionInfo);
        //db.Open();

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        cmd.CommandText = sql;
        adapter.Fill(ds);

        //db.Close();

        return ds;
      }
      catch (Exception ex)
      {
        //
        // something failed, so rethrow the exception so caller knows:
        //
        ExceptionDispatchInfo.Capture(ex).Throw();  // rethrow while preserving stack
        throw;  // avoid compiler warnings
      }
      finally
      {
        //
        // close connection:
        //
        //if (db != null && db.State != ConnectionState.Closed)
        //  db.Close();
      }
    }

    //
    // ExecutionActionQuery:  executes an Insert, Update or Delete query, and returns
    // the number of records modified.
    //
    public int ExecuteActionQuery(string sql)
    {
      //SqlConnection db = null;

      try
      {
        //db = new SqlConnection(_DBConnectionInfo);
        //db.Open();

        cmd.CommandText = sql;

        int rowsModified = cmd.ExecuteNonQuery();

        return rowsModified;
      }
      catch (Exception ex)
      {
        //
        // something failed, so rethrow the exception so caller knows:
        //
        ExceptionDispatchInfo.Capture(ex).Throw();  // rethrow while preserving stack
        throw;  // avoid compiler warnings
      }
      finally
      {
        //
        // close connection:
        //
        //if (db != null && db.State != ConnectionState.Closed)
        //  db.Close();
      }
    }


    //
    // openConnection():
    //
    public void openConnection()
    {
      if (db != null && db.State != ConnectionState.Open)
      {
        db.Open();
        cmd.Connection = db;
      }
    }


    //
    // closeConnection():
    //
    public void CloseConnection()
    {
      if (db != null && db.State != ConnectionState.Closed)
        db.Close();
    }


    //
    // SetCmdTransaction():
    //
    public void setCmdTransaction(SqlTransaction tx)
    {
      cmd.Transaction = tx;
    }


    //
    // GetDbConnection():
    //
    public SqlConnection GetDbConnection()
    {
      return db;
    }


  }//class

}//namespace
