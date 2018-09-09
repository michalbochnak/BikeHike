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

    public Business(string dbFilename)
    {
      _DBFile = dbFilename;
      dataTier = new DataAccessTier.Data(dbFilename);
    }
  }
}
