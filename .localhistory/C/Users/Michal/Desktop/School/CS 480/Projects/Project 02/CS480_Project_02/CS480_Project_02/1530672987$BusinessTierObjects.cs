using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
// BusinessTier:
//
namespace BusinessTier
{
  public class Customer
  {
    public int CID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }

    public Customer(int id, string first, string last, string e_mail)
    {
      CID = id;
      firstName = first;
      lastName = last;
      email = e_mail;
    }

    public override string ToString()
    {
      return string.Format("{0}, {1}", lastName, firstName);
    }

  } // Customer class


  public class Bike
  {
    public int BID { get; set; }
    public int year { get; set; }
    public string description { get; set; }
    public decimal hourlyPrice { get; set; }
    public bool rented { get; set; }

    public Bike(int _id, int _year, string _description, decimal _hourlyPrice, bool _rented)
    {
      BID = _id;
      year = _year;
      description = _description;
      hourlyPrice = _hourlyPrice;
      rented = _rented;
    }

  } // Bike class


} // BusinessTire namespace
