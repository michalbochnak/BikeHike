namespace BikeHike
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
      System.Windows.Forms.Button BikesForRentButton;
      System.Windows.Forms.Button AllBikesButton;
      this.LoadCustomersButton = new System.Windows.Forms.Button();
      this.CIDTextBox = new System.Windows.Forms.TextBox();
      this.EmailTextBox = new System.Windows.Forms.TextBox();
      this.RentingTextBox = new System.Windows.Forms.TextBox();
      this.CIDLabel = new System.Windows.Forms.Label();
      this.EmailLabel = new System.Windows.Forms.Label();
      this.RentingLabel = new System.Windows.Forms.Label();
      this.AllCustomersListBox = new System.Windows.Forms.ListBox();
      this.BikesForRentListBox = new System.Windows.Forms.ListBox();
      this.AllBikesListBox = new System.Windows.Forms.ListBox();
      BikesForRentButton = new System.Windows.Forms.Button();
      AllBikesButton = new System.Windows.Forms.Button();
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
      // CIDTextBox
      // 
      this.CIDTextBox.Location = new System.Drawing.Point(62, 345);
      this.CIDTextBox.Name = "CIDTextBox";
      this.CIDTextBox.Size = new System.Drawing.Size(126, 20);
      this.CIDTextBox.TabIndex = 2;
      // 
      // EmailTextBox
      // 
      this.EmailTextBox.Location = new System.Drawing.Point(62, 372);
      this.EmailTextBox.Name = "EmailTextBox";
      this.EmailTextBox.Size = new System.Drawing.Size(126, 20);
      this.EmailTextBox.TabIndex = 3;
      // 
      // RentingTextBox
      // 
      this.RentingTextBox.Location = new System.Drawing.Point(62, 399);
      this.RentingTextBox.Name = "RentingTextBox";
      this.RentingTextBox.Size = new System.Drawing.Size(126, 20);
      this.RentingTextBox.TabIndex = 4;
      // 
      // CIDLabel
      // 
      this.CIDLabel.AutoSize = true;
      this.CIDLabel.Location = new System.Drawing.Point(31, 348);
      this.CIDLabel.Name = "CIDLabel";
      this.CIDLabel.Size = new System.Drawing.Size(25, 13);
      this.CIDLabel.TabIndex = 5;
      this.CIDLabel.Text = "CID";
      // 
      // EmailLabel
      // 
      this.EmailLabel.AutoSize = true;
      this.EmailLabel.Location = new System.Drawing.Point(21, 375);
      this.EmailLabel.Name = "EmailLabel";
      this.EmailLabel.Size = new System.Drawing.Size(35, 13);
      this.EmailLabel.TabIndex = 6;
      this.EmailLabel.Text = "E-mail";
      // 
      // RentingLabel
      // 
      this.RentingLabel.AutoSize = true;
      this.RentingLabel.Location = new System.Drawing.Point(12, 402);
      this.RentingLabel.Name = "RentingLabel";
      this.RentingLabel.Size = new System.Drawing.Size(44, 13);
      this.RentingLabel.TabIndex = 7;
      this.RentingLabel.Text = "Renting";
      // 
      // AllCustomersListBox
      // 
      this.AllCustomersListBox.FormattingEnabled = true;
      this.AllCustomersListBox.Location = new System.Drawing.Point(13, 48);
      this.AllCustomersListBox.Name = "AllCustomersListBox";
      this.AllCustomersListBox.Size = new System.Drawing.Size(175, 290);
      this.AllCustomersListBox.TabIndex = 9;
      this.AllCustomersListBox.SelectedIndexChanged += new System.EventHandler(this.AllCustomersListBox_SelectedIndexChanged);
      // 
      // BikesForRentButton
      // 
      BikesForRentButton.CausesValidation = false;
      BikesForRentButton.Location = new System.Drawing.Point(207, 12);
      BikesForRentButton.Name = "BikesForRentButton";
      BikesForRentButton.Size = new System.Drawing.Size(175, 30);
      BikesForRentButton.TabIndex = 10;
      BikesForRentButton.Text = "Bikes For Rent";
      BikesForRentButton.UseVisualStyleBackColor = true;
      BikesForRentButton.Click += new System.EventHandler(this.BikesForRentButton_Click);
      // 
      // BikesForRentListBox
      // 
      this.BikesForRentListBox.FormattingEnabled = true;
      this.BikesForRentListBox.Location = new System.Drawing.Point(207, 48);
      this.BikesForRentListBox.Name = "BikesForRentListBox";
      this.BikesForRentListBox.Size = new System.Drawing.Size(175, 290);
      this.BikesForRentListBox.TabIndex = 11;
      // 
      // AllBikesButton
      // 
      AllBikesButton.CausesValidation = false;
      AllBikesButton.Location = new System.Drawing.Point(404, 12);
      AllBikesButton.Name = "AllBikesButton";
      AllBikesButton.Size = new System.Drawing.Size(175, 30);
      AllBikesButton.TabIndex = 12;
      AllBikesButton.Text = "All Bikes";
      AllBikesButton.UseVisualStyleBackColor = true;
      AllBikesButton.Click += new System.EventHandler(this.AllBikesButton_Click);
      // 
      // AllBikesListBox
      // 
      this.AllBikesListBox.FormattingEnabled = true;
      this.AllBikesListBox.Location = new System.Drawing.Point(404, 48);
      this.AllBikesListBox.Name = "AllBikesListBox";
      this.AllBikesListBox.Size = new System.Drawing.Size(175, 290);
      this.AllBikesListBox.TabIndex = 13;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 464);
      this.Controls.Add(this.AllBikesListBox);
      this.Controls.Add(AllBikesButton);
      this.Controls.Add(this.BikesForRentListBox);
      this.Controls.Add(BikesForRentButton);
      this.Controls.Add(this.AllCustomersListBox);
      this.Controls.Add(this.RentingLabel);
      this.Controls.Add(this.EmailLabel);
      this.Controls.Add(this.CIDLabel);
      this.Controls.Add(this.RentingTextBox);
      this.Controls.Add(this.EmailTextBox);
      this.Controls.Add(this.CIDTextBox);
      this.Controls.Add(this.LoadCustomersButton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button LoadCustomersButton;
    private System.Windows.Forms.TextBox CIDTextBox;
    private System.Windows.Forms.TextBox EmailTextBox;
    private System.Windows.Forms.TextBox RentingTextBox;
    private System.Windows.Forms.Label CIDLabel;
    private System.Windows.Forms.Label EmailLabel;
    private System.Windows.Forms.Label RentingLabel;
    private System.Windows.Forms.ListBox AllCustomersListBox;
    private System.Windows.Forms.ListBox BikesForRentListBox;
    private System.Windows.Forms.ListBox AllBikesListBox;
  }
}

