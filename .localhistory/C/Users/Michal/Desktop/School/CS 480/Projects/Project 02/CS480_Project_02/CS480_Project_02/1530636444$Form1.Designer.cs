﻿namespace BikeHike
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.LoadCustomersButton = new System.Windows.Forms.Button();
      this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
      this.CustomerEmailTextBox = new System.Windows.Forms.TextBox();
      this.RentingTextBox = new System.Windows.Forms.TextBox();
      this.CIDLabel = new System.Windows.Forms.Label();
      this.EmailLabel = new System.Windows.Forms.Label();
      this.RentingLabel = new System.Windows.Forms.Label();
      this.CustomersListBox = new System.Windows.Forms.ListBox();
      this.AllCustomersListBox = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // LoadCustomersButton
      // 
      this.LoadCustomersButton.Location = new System.Drawing.Point(13, 12);
      this.LoadCustomersButton.Name = "LoadCustomersButton";
      this.LoadCustomersButton.Size = new System.Drawing.Size(175, 30);
      this.LoadCustomersButton.TabIndex = 1;
      this.LoadCustomersButton.Text = "Load Customers";
      this.LoadCustomersButton.UseVisualStyleBackColor = true;
      this.LoadCustomersButton.Click += new System.EventHandler(this.LoadCustomersButton_Click);
      // 
      // CustomerIdTextBox
      // 
      this.CustomerIdTextBox.Location = new System.Drawing.Point(62, 370);
      this.CustomerIdTextBox.Name = "CustomerIdTextBox";
      this.CustomerIdTextBox.Size = new System.Drawing.Size(126, 20);
      this.CustomerIdTextBox.TabIndex = 2;
      // 
      // CustomerEmailTextBox
      // 
      this.CustomerEmailTextBox.Location = new System.Drawing.Point(62, 397);
      this.CustomerEmailTextBox.Name = "CustomerEmailTextBox";
      this.CustomerEmailTextBox.Size = new System.Drawing.Size(126, 20);
      this.CustomerEmailTextBox.TabIndex = 3;
      // 
      // RentingTextBox
      // 
      this.RentingTextBox.Location = new System.Drawing.Point(62, 424);
      this.RentingTextBox.Name = "RentingTextBox";
      this.RentingTextBox.Size = new System.Drawing.Size(126, 20);
      this.RentingTextBox.TabIndex = 4;
      // 
      // CIDLabel
      // 
      this.CIDLabel.AutoSize = true;
      this.CIDLabel.Location = new System.Drawing.Point(31, 373);
      this.CIDLabel.Name = "CIDLabel";
      this.CIDLabel.Size = new System.Drawing.Size(25, 13);
      this.CIDLabel.TabIndex = 5;
      this.CIDLabel.Text = "CID";
      // 
      // EmailLabel
      // 
      this.EmailLabel.AutoSize = true;
      this.EmailLabel.Location = new System.Drawing.Point(21, 400);
      this.EmailLabel.Name = "EmailLabel";
      this.EmailLabel.Size = new System.Drawing.Size(35, 13);
      this.EmailLabel.TabIndex = 6;
      this.EmailLabel.Text = "E-mail";
      // 
      // RentingLabel
      // 
      this.RentingLabel.AutoSize = true;
      this.RentingLabel.Location = new System.Drawing.Point(12, 427);
      this.RentingLabel.Name = "RentingLabel";
      this.RentingLabel.Size = new System.Drawing.Size(44, 13);
      this.RentingLabel.TabIndex = 7;
      this.RentingLabel.Text = "Renting";
      // 
      // CustomersListBox
      // 
      this.CustomersListBox.FormattingEnabled = true;
      this.CustomersListBox.Location = new System.Drawing.Point(15, 49);
      this.CustomersListBox.Name = "CustomersListBox";
      this.CustomersListBox.Size = new System.Drawing.Size(173, 303);
      this.CustomersListBox.TabIndex = 8;
      this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged_1);
      // 
      // AllCustomersListBox
      // 
      this.AllCustomersListBox.FormattingEnabled = true;
      this.AllCustomersListBox.Location = new System.Drawing.Point(221, 49);
      this.AllCustomersListBox.Name = "AllCustomersListBox";
      this.AllCustomersListBox.Size = new System.Drawing.Size(120, 95);
      this.AllCustomersListBox.TabIndex = 9;
      this.AllCustomersListBox.SelectedIndexChanged += new System.EventHandler(this.AllCustomersListBox_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 464);
      this.Controls.Add(this.AllCustomersListBox);
      this.Controls.Add(this.CustomersListBox);
      this.Controls.Add(this.RentingLabel);
      this.Controls.Add(this.EmailLabel);
      this.Controls.Add(this.CIDLabel);
      this.Controls.Add(this.RentingTextBox);
      this.Controls.Add(this.CustomerEmailTextBox);
      this.Controls.Add(this.CustomerIdTextBox);
      this.Controls.Add(this.LoadCustomersButton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button LoadCustomersButton;
    private System.Windows.Forms.TextBox CustomerIdTextBox;
    private System.Windows.Forms.TextBox CustomerEmailTextBox;
    private System.Windows.Forms.TextBox RentingTextBox;
    private System.Windows.Forms.Label CIDLabel;
    private System.Windows.Forms.Label EmailLabel;
    private System.Windows.Forms.Label RentingLabel;
    private System.Windows.Forms.ListBox AllCustomersListBox;
    private System.Windows.Forms.ListBox CustomersListBox;
  }
}

