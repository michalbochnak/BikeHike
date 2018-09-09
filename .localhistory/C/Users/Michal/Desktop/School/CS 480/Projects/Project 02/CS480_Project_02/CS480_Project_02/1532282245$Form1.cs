﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//
// BikeHike
//
namespace BikeHike
{
  public partial class Form1 : Form
  {
    private const string dbName = "BikeHike.mdf";
    private BusinessTier.Business business = new BusinessTier.Business(dbName);
    private IReadOnlyList<BusinessTier.Customer> customers;
    private IReadOnlyList<BusinessTier.Bike> bikes;


    //
    // Form1:
    //
    public Form1()
    {
      InitializeComponent();
    }


    //
    // LoadCustomersButton_Click():
    //
    private void LoadCustomersButton_Click(object sender, EventArgs e)
    {
      // clear customers list and fields
      this.AllCustomersListBox.Items.Clear();
      ClearCustomerUiFields();

      // get customers from Db
      customers = business.GetCustomers();

      try
      {
        // populate on the list
        foreach (BusinessTier.Customer cust in customers)
          this.AllCustomersListBox.Items.Add(cust.ToString());
      }
      catch (Exception exc)
      {
        MessageBox.Show(string.Format(
          "Error in LoadCustomersButton_Click(): '{0}'.", exc.Message));
      }
    }

    //
    // ClearCustomerUiFields():
    //
    private void ClearCustomerUiFields()
    {
      CIDTextBox.Text = "";
      EmailTextBox.Text = "";
      RentingTextBox.Text = "";
      NumBikesTextBox.Text = "";
      ExpReturnTextBox.Text = "";
    }


    //
    // AllCustomersListBox_SelectedIndexChanged():
    //
    // Populate details about the customer when selected.
    //
    private void AllCustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = this.AllCustomersListBox.SelectedIndex;
      // sometimes this event fires, but nothing is selected...
      if (index < 0)   // so return now in this case:
        return;
      
      string cid = customers.ElementAt(index).CID.ToString();
      CIDTextBox.Text = cid;
      EmailTextBox.Text = customers.ElementAt(index).email;

      if (business.GetCustRentStatus(cid) == true)
      {
        RentingTextBox.Text = "Yes";
        NumBikesTextBox.Text = business.GetNumRentedBikes(Convert.ToInt32(cid));
        ExpReturnTextBox.Text = business.GetExpectedReturnTimeCust(Convert.ToInt32(cid));
      }
      else
      {
        RentingTextBox.Text = "No";
        NumBikesTextBox.Text = "-";
        ExpReturnTextBox.Text = "-";
      }
    }


    //
    // BikesForRentButton_Click():
    //
    private void BikesForRentButton_Click(object sender, EventArgs e)
    {
      BuildBikesForRentList();
    }


    //
    // BuildBikesForRentList():
    //
    private void BuildBikesForRentList()
    {
      // clear customers list
      this.BikesForRentListBox.Items.Clear();

      // get bikes from Db
      IReadOnlyList<BusinessTier.Bike> bikesToRent = business.GetBikesToRent();

      try
      {
        string type = "none";
        
        // populate list with entries from Db
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


    //
    // AllBikesButton_Click():
    //
    private void AllBikesButton_Click(object sender, EventArgs e)
    {
      this.AllBikesListBox.Items.Clear();
      ClearBikeUiFields();

      // get bikes from Db
      bikes = business.GetBikes();

      try
      {
        // populate UI list
        foreach (BusinessTier.Bike bike in bikes)
          this.AllBikesListBox.Items.Add(bike.BID);
      }
      catch (Exception exc)
      {
        MessageBox.Show(string.Format(
          "Error in BikesForRentButton_Click(): '{0}'.", exc.Message));
      }
    }


    //
    // ClearBikeUiFields():
    //
    private void ClearBikeUiFields()
    {
      YearTextBox.Text = "";
      TypeTextBox.Text = "";
      PriceTextBox.Text = "";
      RentedTextBox.Text = "";
      ExpectedReturnTextBox.Text = "";
    }


    //
    // AllBikesListBox_SelectedIndexChanged():
    // 
    // Populate details about the selected bike.
    //
    private void AllBikesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = this.AllBikesListBox.SelectedIndex;
      // sometimes this event fires, but nothing is selected...
      if (index < 0)   // so return now in this case:
        return;

      YearTextBox.Text = bikes.ElementAt(index).year.ToString();
      TypeTextBox.Text = bikes.ElementAt(index).description;
      PriceTextBox.Text = "$" + Math.Round(bikes.ElementAt(index).hourlyPrice, 2);

      bool rented = business.GetBikeRentStatus(bikes.ElementAt(index).BID);
      RentedTextBox.Text = rented == true ? "Yes" : "No";
      ExpectedReturnTextBox.Text = rented == true
        ? business.GetExpectedReturnTimeBike(bikes.ElementAt(index).BID)
        : "Available Now";
    }


    //
    // RentButton_Click():
    //
    private void RentButton_Click(object sender, EventArgs e)
    {
      // build list from selected bikes
      List<int> selectedBikes = new List<int>();
      foreach (Object obj in BikesForRentListBox.SelectedItems)
      {
        string item = obj as String;
        if (item[0] == ' ')
          selectedBikes.Add(Convert.ToInt32(item));
      }

      // make sure all needed data is provided
      int index = AllCustomersListBox.SelectedIndex;
      if (index == -1)
        MessageBox.Show("Select a customer.");
      else if (selectedBikes.Count == 0)
        MessageBox.Show("Select at least one bike.");
      else if (business.GetCustRentStatus(customers.ElementAt(index).CID.ToString()) == true)
        MessageBox.Show("Customer is already renting.");
      else if (ExpDurationTextBox.Text == "")
        MessageBox.Show("Enter duration.");
      // proceed to rent bikes and update UI fields that will be affected by change
      else
      {
        MessageBox.Show("Rental ID: " + business.RentBikes(selectedBikes, customers.ElementAt(index).CID, 
          Convert.ToDecimal(ExpDurationTextBox.Text)).ToString());
        RentingTextBox.Text = "Yes";
        NumBikesTextBox.Text = selectedBikes.Count.ToString();
        ExpReturnTextBox.Text = business.GetExpectedReturnTimeCust(customers.ElementAt(index).CID);
        int selectedBike = Convert.ToInt32(AllBikesListBox.SelectedItem);
        // selected bike was rented, update UI
        if (selectedBikes.Contains(selectedBike))
        {
          RentedTextBox.Text = "Yes";
          ExpectedReturnTextBox.Text = business.GetExpectedReturnTimeBike(selectedBike).ToString();
        }
        // refresh bikes available to rent
        BuildBikesForRentList();
      }
    }


    //
    // ReturnButton_Click():
    //
    private void ReturnButton_Click(object sender, EventArgs e)
    {
      // make sure customer is selected and that rental under that customer exists
      int index = AllCustomersListBox.SelectedIndex;
      if (index == -1)
        MessageBox.Show("Select a customer.");
      else if (business.GetCustRentStatus(customers.ElementAt(index).CID.ToString()) == false)
        MessageBox.Show("This customer is not renting currently.");
      // proceed with return
      else
      {
        // grab bikes IDs to return, so the UI fields about the bike can be updated
        // if it was selected
        List<int> bikesToReturn = business.GetBikesToReturn(customers.ElementAt(index).CID);
        if (bikesToReturn.Contains(Convert.ToInt32(AllBikesListBox.SelectedItem)))
        {
          RentedTextBox.Text = "No";
          ExpectedReturnTextBox.Text = "Available Now";
        }

        // return and display total price
        MessageBox.Show("Total price: $" + business.ReturnBikes(customers.ElementAt(index).CID));
        // update UI
        RentingTextBox.Text = "No";
        NumBikesTextBox.Text = "-";
        ExpReturnTextBox.Text = "-";
        // refresh available to rent bikes
        BuildBikesForRentList();
      }
    }


    //
    //
    //
    private void resetDatabaseButton_Click(object sender, EventArgs e)
    {
      
    }
  } // Form class

} // BikeHike namespace
