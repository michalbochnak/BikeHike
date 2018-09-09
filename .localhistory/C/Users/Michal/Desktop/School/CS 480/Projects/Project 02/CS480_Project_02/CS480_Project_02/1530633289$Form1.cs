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
    public Form1()
    {
      InitializeComponent();
    }

    private void LoadCustomersButton_Click(object sender, EventArgs e)
    {
      // clear customers list


      // clear other data


      try
      {

      }
      catch (Exception exc)
      {
        MessageBox.Show(string.Format(
          "Error in LoadCustomersButton_Click(): '{0}'.", exc.Message));
      }
    }
  }
}
