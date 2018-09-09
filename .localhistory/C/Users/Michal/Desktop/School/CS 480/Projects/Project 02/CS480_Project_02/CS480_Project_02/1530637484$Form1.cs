﻿using System;
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
    private BusinessTier.Business business;
    private IReadOnlyList<BusinessTier.Customer> customers;

    public Form1()
    {
      InitializeComponent();
    }

    private void LoadCustomersButton_Click(object sender, EventArgs e)
    {
      // clear customers list


      // clear other data
      business = new BusinessTier.Business(dbName);
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
      // sometimes this event fires, but nothing is selected...
      if (this.AllCustomersListBox.SelectedIndex < 0)   // so return now in this case:
        return;

      //
      // clear fields
      //

      string cid = customers.ElementAt
        (this.AllCustomersListBox.SelectedIndex).CID.ToString();

      CIDTextBox.Text = cid;
      EmailTextBox.Text = customers.ElementAt
        (this.AllCustomersListBox.SelectedIndex).email;
      RentingTextBox = business.GetRentStatus(cid);


    }
  } // Form class

} // BikeHike namespace
