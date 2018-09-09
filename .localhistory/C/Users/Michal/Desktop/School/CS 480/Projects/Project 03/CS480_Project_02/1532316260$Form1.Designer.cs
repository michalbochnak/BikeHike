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
      System.Windows.Forms.Button LoadAllButton;
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
      this.YearTextBox = new System.Windows.Forms.TextBox();
      this.TypeTextBox = new System.Windows.Forms.TextBox();
      this.PriceTextBox = new System.Windows.Forms.TextBox();
      this.RentedTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.ExpectedReturnTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.RentButton = new System.Windows.Forms.Button();
      this.ExpDurationTextBox = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.NumBikesTextBox = new System.Windows.Forms.TextBox();
      this.ExpReturnTextBox = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.ReturnButton = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.resetDatabaseButton = new System.Windows.Forms.Button();
      BikesForRentButton = new System.Windows.Forms.Button();
      AllBikesButton = new System.Windows.Forms.Button();
      LoadAllButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BikesForRentButton
      // 
      BikesForRentButton.BackColor = System.Drawing.Color.YellowGreen;
      BikesForRentButton.CausesValidation = false;
      BikesForRentButton.Location = new System.Drawing.Point(319, 65);
      BikesForRentButton.Name = "BikesForRentButton";
      BikesForRentButton.Size = new System.Drawing.Size(270, 30);
      BikesForRentButton.TabIndex = 10;
      BikesForRentButton.Text = "Bikes For Rent";
      BikesForRentButton.UseVisualStyleBackColor = false;
      BikesForRentButton.Click += new System.EventHandler(this.BikesForRentButton_Click);
      // 
      // AllBikesButton
      // 
      AllBikesButton.BackColor = System.Drawing.Color.YellowGreen;
      AllBikesButton.CausesValidation = false;
      AllBikesButton.Location = new System.Drawing.Point(611, 65);
      AllBikesButton.Name = "AllBikesButton";
      AllBikesButton.Size = new System.Drawing.Size(270, 30);
      AllBikesButton.TabIndex = 12;
      AllBikesButton.Text = "All Bikes";
      AllBikesButton.UseVisualStyleBackColor = false;
      AllBikesButton.Click += new System.EventHandler(this.AllBikesButton_Click);
      // 
      // LoadCustomersButton
      // 
      this.LoadCustomersButton.BackColor = System.Drawing.Color.YellowGreen;
      this.LoadCustomersButton.Location = new System.Drawing.Point(26, 65);
      this.LoadCustomersButton.Name = "LoadCustomersButton";
      this.LoadCustomersButton.Size = new System.Drawing.Size(270, 30);
      this.LoadCustomersButton.TabIndex = 1;
      this.LoadCustomersButton.Text = "Load Customers";
      this.LoadCustomersButton.UseVisualStyleBackColor = false;
      this.LoadCustomersButton.Click += new System.EventHandler(this.LoadCustomersButton_Click);
      // 
      // CIDTextBox
      // 
      this.CIDTextBox.Location = new System.Drawing.Point(142, 397);
      this.CIDTextBox.Name = "CIDTextBox";
      this.CIDTextBox.Size = new System.Drawing.Size(154, 23);
      this.CIDTextBox.TabIndex = 2;
      // 
      // EmailTextBox
      // 
      this.EmailTextBox.Location = new System.Drawing.Point(142, 424);
      this.EmailTextBox.Name = "EmailTextBox";
      this.EmailTextBox.Size = new System.Drawing.Size(154, 23);
      this.EmailTextBox.TabIndex = 3;
      // 
      // RentingTextBox
      // 
      this.RentingTextBox.Location = new System.Drawing.Point(142, 451);
      this.RentingTextBox.Name = "RentingTextBox";
      this.RentingTextBox.Size = new System.Drawing.Size(154, 23);
      this.RentingTextBox.TabIndex = 4;
      // 
      // CIDLabel
      // 
      this.CIDLabel.AutoSize = true;
      this.CIDLabel.Location = new System.Drawing.Point(102, 400);
      this.CIDLabel.Name = "CIDLabel";
      this.CIDLabel.Size = new System.Drawing.Size(30, 17);
      this.CIDLabel.TabIndex = 5;
      this.CIDLabel.Text = "CID";
      // 
      // EmailLabel
      // 
      this.EmailLabel.AutoSize = true;
      this.EmailLabel.Location = new System.Drawing.Point(88, 426);
      this.EmailLabel.Name = "EmailLabel";
      this.EmailLabel.Size = new System.Drawing.Size(47, 17);
      this.EmailLabel.TabIndex = 6;
      this.EmailLabel.Text = "E-mail";
      // 
      // RentingLabel
      // 
      this.RentingLabel.AutoSize = true;
      this.RentingLabel.Location = new System.Drawing.Point(79, 454);
      this.RentingLabel.Name = "RentingLabel";
      this.RentingLabel.Size = new System.Drawing.Size(57, 17);
      this.RentingLabel.TabIndex = 7;
      this.RentingLabel.Text = "Renting";
      // 
      // AllCustomersListBox
      // 
      this.AllCustomersListBox.FormattingEnabled = true;
      this.AllCustomersListBox.ItemHeight = 17;
      this.AllCustomersListBox.Location = new System.Drawing.Point(26, 101);
      this.AllCustomersListBox.Name = "AllCustomersListBox";
      this.AllCustomersListBox.Size = new System.Drawing.Size(270, 276);
      this.AllCustomersListBox.TabIndex = 9;
      this.AllCustomersListBox.SelectedIndexChanged += new System.EventHandler(this.AllCustomersListBox_SelectedIndexChanged);
      // 
      // BikesForRentListBox
      // 
      this.BikesForRentListBox.FormattingEnabled = true;
      this.BikesForRentListBox.ItemHeight = 17;
      this.BikesForRentListBox.Location = new System.Drawing.Point(319, 101);
      this.BikesForRentListBox.Name = "BikesForRentListBox";
      this.BikesForRentListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.BikesForRentListBox.Size = new System.Drawing.Size(270, 276);
      this.BikesForRentListBox.TabIndex = 11;
      // 
      // AllBikesListBox
      // 
      this.AllBikesListBox.FormattingEnabled = true;
      this.AllBikesListBox.ItemHeight = 17;
      this.AllBikesListBox.Location = new System.Drawing.Point(611, 101);
      this.AllBikesListBox.Name = "AllBikesListBox";
      this.AllBikesListBox.Size = new System.Drawing.Size(270, 276);
      this.AllBikesListBox.TabIndex = 13;
      this.AllBikesListBox.SelectedIndexChanged += new System.EventHandler(this.AllBikesListBox_SelectedIndexChanged);
      // 
      // YearTextBox
      // 
      this.YearTextBox.Location = new System.Drawing.Point(727, 394);
      this.YearTextBox.Name = "YearTextBox";
      this.YearTextBox.Size = new System.Drawing.Size(154, 23);
      this.YearTextBox.TabIndex = 14;
      // 
      // TypeTextBox
      // 
      this.TypeTextBox.Location = new System.Drawing.Point(727, 421);
      this.TypeTextBox.Name = "TypeTextBox";
      this.TypeTextBox.Size = new System.Drawing.Size(154, 23);
      this.TypeTextBox.TabIndex = 15;
      // 
      // PriceTextBox
      // 
      this.PriceTextBox.Location = new System.Drawing.Point(727, 448);
      this.PriceTextBox.Name = "PriceTextBox";
      this.PriceTextBox.Size = new System.Drawing.Size(154, 23);
      this.PriceTextBox.TabIndex = 16;
      // 
      // RentedTextBox
      // 
      this.RentedTextBox.Location = new System.Drawing.Point(727, 474);
      this.RentedTextBox.Name = "RentedTextBox";
      this.RentedTextBox.Size = new System.Drawing.Size(154, 23);
      this.RentedTextBox.TabIndex = 17;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(680, 397);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 17);
      this.label1.TabIndex = 18;
      this.label1.Text = "Year";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(678, 424);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 17);
      this.label2.TabIndex = 19;
      this.label2.Text = "Type";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(678, 451);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 17);
      this.label3.TabIndex = 20;
      this.label3.Text = "Price";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(667, 477);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(54, 17);
      this.label4.TabIndex = 21;
      this.label4.Text = "Rented";
      // 
      // ExpectedReturnTextBox
      // 
      this.ExpectedReturnTextBox.Location = new System.Drawing.Point(727, 500);
      this.ExpectedReturnTextBox.Name = "ExpectedReturnTextBox";
      this.ExpectedReturnTextBox.Size = new System.Drawing.Size(154, 23);
      this.ExpectedReturnTextBox.TabIndex = 22;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(608, 506);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(113, 17);
      this.label5.TabIndex = 23;
      this.label5.Text = "Expected Return";
      // 
      // RentButton
      // 
      this.RentButton.BackColor = System.Drawing.Color.YellowGreen;
      this.RentButton.Location = new System.Drawing.Point(319, 425);
      this.RentButton.Name = "RentButton";
      this.RentButton.Size = new System.Drawing.Size(270, 30);
      this.RentButton.TabIndex = 25;
      this.RentButton.Text = "Rent Bikes";
      this.RentButton.UseVisualStyleBackColor = false;
      this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
      // 
      // ExpDurationTextBox
      // 
      this.ExpDurationTextBox.Location = new System.Drawing.Point(384, 398);
      this.ExpDurationTextBox.Name = "ExpDurationTextBox";
      this.ExpDurationTextBox.Size = new System.Drawing.Size(205, 23);
      this.ExpDurationTextBox.TabIndex = 26;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(316, 401);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(62, 17);
      this.label6.TabIndex = 27;
      this.label6.Text = "Duration";
      // 
      // NumBikesTextBox
      // 
      this.NumBikesTextBox.Location = new System.Drawing.Point(142, 480);
      this.NumBikesTextBox.Name = "NumBikesTextBox";
      this.NumBikesTextBox.Size = new System.Drawing.Size(154, 23);
      this.NumBikesTextBox.TabIndex = 28;
      // 
      // ExpReturnTextBox
      // 
      this.ExpReturnTextBox.Location = new System.Drawing.Point(142, 506);
      this.ExpReturnTextBox.Name = "ExpReturnTextBox";
      this.ExpReturnTextBox.Size = new System.Drawing.Size(154, 23);
      this.ExpReturnTextBox.TabIndex = 29;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(79, 484);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(53, 17);
      this.label7.TabIndex = 30;
      this.label7.Text = "# bikes";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(19, 509);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(113, 17);
      this.label8.TabIndex = 31;
      this.label8.Text = "Expected Return";
      // 
      // ReturnButton
      // 
      this.ReturnButton.BackColor = System.Drawing.Color.YellowGreen;
      this.ReturnButton.Location = new System.Drawing.Point(319, 500);
      this.ReturnButton.Name = "ReturnButton";
      this.ReturnButton.Size = new System.Drawing.Size(270, 30);
      this.ReturnButton.TabIndex = 32;
      this.ReturnButton.Text = "Return Bikes";
      this.ReturnButton.UseVisualStyleBackColor = false;
      this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.ForeColor = System.Drawing.Color.GreenYellow;
      this.label9.Location = new System.Drawing.Point(329, 554);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(228, 20);
      this.label9.TabIndex = 33;
      this.label9.Text = "Michal Bochnak, mbochn2";
      // 
      // resetDatabaseButton
      // 
      this.resetDatabaseButton.BackColor = System.Drawing.Color.Gray;
      this.resetDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resetDatabaseButton.ForeColor = System.Drawing.Color.GreenYellow;
      this.resetDatabaseButton.Location = new System.Drawing.Point(22, 544);
      this.resetDatabaseButton.Name = "resetDatabaseButton";
      this.resetDatabaseButton.Size = new System.Drawing.Size(121, 30);
      this.resetDatabaseButton.TabIndex = 34;
      this.resetDatabaseButton.Text = "Reset database";
      this.resetDatabaseButton.UseVisualStyleBackColor = false;
      this.resetDatabaseButton.Click += new System.EventHandler(this.resetDatabaseButton_Click);
      // 
      // LoadAllButton
      // 
      LoadAllButton.BackColor = System.Drawing.Color.YellowGreen;
      LoadAllButton.CausesValidation = false;
      LoadAllButton.Location = new System.Drawing.Point(26, 29);
      LoadAllButton.Name = "LoadAllButton";
      LoadAllButton.Size = new System.Drawing.Size(855, 30);
      LoadAllButton.TabIndex = 35;
      LoadAllButton.Text = "Load All";
      LoadAllButton.UseVisualStyleBackColor = false;
      LoadAllButton.Click += new System.EventHandler(this.LoadAllButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkGray;
      this.ClientSize = new System.Drawing.Size(914, 603);
      this.Controls.Add(LoadAllButton);
      this.Controls.Add(this.resetDatabaseButton);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.ReturnButton);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.ExpReturnTextBox);
      this.Controls.Add(this.NumBikesTextBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.ExpDurationTextBox);
      this.Controls.Add(this.RentButton);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.ExpectedReturnTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.RentedTextBox);
      this.Controls.Add(this.PriceTextBox);
      this.Controls.Add(this.TypeTextBox);
      this.Controls.Add(this.YearTextBox);
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
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
    private System.Windows.Forms.TextBox YearTextBox;
    private System.Windows.Forms.TextBox TypeTextBox;
    private System.Windows.Forms.TextBox PriceTextBox;
    private System.Windows.Forms.TextBox RentedTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox ExpectedReturnTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button RentButton;
    private System.Windows.Forms.TextBox ExpDurationTextBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox NumBikesTextBox;
    private System.Windows.Forms.TextBox ExpReturnTextBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button ReturnButton;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button resetDatabaseButton;
  }
}

