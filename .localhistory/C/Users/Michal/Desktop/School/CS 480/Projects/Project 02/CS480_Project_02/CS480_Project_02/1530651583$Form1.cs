using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeHike
{
  public partial class Form1 : Form
  {
    private const string dbName = "BikeHike.mdf";
    private BusinessTier.Business business = new BusinessTier.Business(dbName);
    private IReadOnlyList<BusinessTier.Customer> customers;
    private IReadOnlyList<BusinessTier.Bike> bikes;


    public Form1()
    {
      InitializeComponent();
    }

    private void LoadCustomersButton_Click(object sender, EventArgs e)
    {
      // clear customers list
      this.AllCustomersListBox.Items.Clear();

      //
      // clear other data
      //

      customers = business.GetCustomers();

      try
      {
        foreach (BusinessTier.Customer cust in customers)
        {
          this.AllCustomersListBox.Items.Add(cust.ToString());
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(string.Format(
          "Error in LoadCustomersButton_Click(): '{0}'.", exc.Message));
      }
    }

    private void AllCustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
    {

      int index = this.AllCustomersListBox.SelectedIndex;
      // sometimes this event fires, but nothing is selected...
      if (index < 0)   // so return now in this case:
        return;

      //
      // clear fields
      //

      string cid = customers.ElementAt(index).CID.ToString();

      CIDTextBox.Text = cid;
      EmailTextBox.Text = customers.ElementAt(index).email;
      RentingTextBox.Text = (business.GetRentStatus(cid) == true) ? "Yes" : "No";
    }

    private void BikesForRentButton_Click(object sender, EventArgs e)
    {
      // clear customers list
      this.BikesForRentListBox.Items.Clear();

      //
      // clear other data
      //

      IReadOnlyList<BusinessTier.Bike> bikesToRent = business.GetBikesToRent();

      try
      {
        string type = "none";

        foreach (BusinessTier.Bike bike in bikesToRent)
        {
          // add bike type if new type encoutered
          if (bike.description != type)
          {
            type = bike.description;
            this.BikesForRentListBox.Items.Add(bike.description);
          }
          this.BikesForRentListBox.Items.Add(bike.ToString());
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(string.Format(
          "Error in LoadCustomersButton_Click(): '{0}'.", exc.Message));
      }
    }

    private void AllBikesButton_Click(object sender, EventArgs e)
    {
      this.AllBikesListBox.Items.Clear();
      bikes = business.GetBikes();

      try
      {
        foreach (BusinessTier.Bike bike in bikes)
        {
          this.AllBikesListBox.Items.Add(bike.BID);
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(string.Format(
          "Error in BikesForRentButton_Click(): '{0}'.", exc.Message));
      }
    }

    private void AllBikesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = this.AllBikesListBox.SelectedIndex;
      // sometimes this event fires, but nothing is selected...
      if (index < 0)   // so return now in this case:
        return;

      YearTextBox.Text = bikes.ElementAt(index).year.ToString();
      TypeTextBox.Text = bikes.ElementAt(index).description;
      PriceTextBox.Text = bikes.ElementAt(index).hourlyPrice.ToString();
      RentedTextBox.Text = bikes.ElementAt(index).rented == true ? "Yes" : "No";
      ExpectedReturnTextBox.Text = bikes.ElementAt(index).rented == true ? GetExpectedReturnTime() : "Available now";
    }

    private string GetExpectedReturnTime()
    {
      return "time";
    }

  } // Form class

} // BikeHike namespace
