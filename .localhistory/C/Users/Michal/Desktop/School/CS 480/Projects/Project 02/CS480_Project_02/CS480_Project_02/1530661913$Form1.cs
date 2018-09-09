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

      if (business.GetCustRentStatus(cid) == true)
      {
        RentingTextBox.Text = "Yes";
        NumBikesTextBox.Text = business.GetNumRentedBikes();
        ExpectedReturnTextBox.Text = business.GetExpectedReturnTimeCust();
      }
      else
      {
        RentingTextBox.Text = "No";
        NumBikesTextBox.Text = "-";
        ExpectedReturnTextBox.Text = "-";
      }
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

          this.BikesForRentListBox.Items.Add(string.Format(" {0}", bike.BID));
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

      bool rented = business.GetBikeRentStatus(bikes.ElementAt(index).BID);
      RentedTextBox.Text = rented == true ? "Yes" : "No";
      ExpectedReturnTextBox.Text = rented == true
        ? business.GetExpectedReturnTimeBike(bikes.ElementAt(index).BID)
        : "Available now";
    }

    //private string GetExpectedReturnTime()
    //{
    //  return business.GetExpectedReturnTime();
    //}

    private void RentButton_Click(object sender, EventArgs e)
    {
      List<int> selectedBikes = new List<int>();
      foreach (Object obj in BikesForRentListBox.SelectedItems)
      {
        string item = obj as String;
        if (item[0] == ' ')
          selectedBikes.Add(Convert.ToInt32(item));
      }

      int index = AllCustomersListBox.SelectedIndex;

      if (index == -1)
        MessageBox.Show("Select a customer.");
      else if (selectedBikes.Count == 0)
        MessageBox.Show("Select at least one bike.");
      else if (business.GetCustRentStatus(customers.ElementAt(index).CID.ToString()) == true)
        MessageBox.Show("Customer is already renting.");
      else if (ExpDurationTextBox.Text == "")
        MessageBox.Show("Enter duration.");
      else
      {
        MessageBox.Show("Rental ID: " + business.RentBikes(selectedBikes, customers.ElementAt(index).CID, 
          Convert.ToDecimal(ExpDurationTextBox.Text)).ToString());
      }
    }
  } // Form class

} // BikeHike namespace
