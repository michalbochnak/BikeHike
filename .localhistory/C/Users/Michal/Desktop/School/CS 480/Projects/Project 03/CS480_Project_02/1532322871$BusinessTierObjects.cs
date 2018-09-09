using System;
using System.Collections.Generic;
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
  // Represents the customer entity
  // 
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


  //
  // Represents the bike entity
  // 
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


  //
  // RentalCart
  //
  public class RentalCart
  {
    public int cid { get; set; }
    public double expectedDuration { get; set; }
    public List<int> bikesToRent { get; set; }

    public RentalCart()
    {
      cid = -1;
      expectedDuration = -1;
      bikesToRent = new List<int>();
    }

    public RentalCart (int _cid, double _expectedDuration, 
      List<int> _bikesToRent)
    {
      cid = _cid;
      expectedDuration = _expectedDuration;

      if (_bikesToRent == null)
        bikesToRent = new List<int>();
      else
        bikesToRent = _bikesToRent;
    }

    public void Add(int id)
    {
      bikesToRent.Add(id);
    }

    public void Clear()
    {
      bikesToRent.Clear();
    }

    public void Display()
    {
      string msg = "CID: " + cid + "\nexpDur: " + expectedDuration + "\nbikes: ";


      MessageBox.Show(msg);
    }

  } // RentalCart class


} // BusinessTire namespace
