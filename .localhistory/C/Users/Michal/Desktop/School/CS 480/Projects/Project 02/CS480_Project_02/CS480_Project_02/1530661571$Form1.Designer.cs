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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      BikesForRentButton = new System.Windows.Forms.Button();
      AllBikesButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BikesForRentButton
      // 
      BikesForRentButton.CausesValidation = false;
      BikesForRentButton.Location = new System.Drawing.Point(319, 12);
      BikesForRentButton.Name = "BikesForRentButton";
      BikesForRentButton.Size = new System.Drawing.Size(175, 30);
      BikesForRentButton.TabIndex = 10;
      BikesForRentButton.Text = "Bikes For Rent";
      BikesForRentButton.UseVisualStyleBackColor = true;
      BikesForRentButton.Click += new System.EventHandler(this.BikesForRentButton_Click);
      // 
      // AllBikesButton
      // 
      AllBikesButton.CausesValidation = false;
      AllBikesButton.Location = new System.Drawing.Point(516, 12);
      AllBikesButton.Name = "AllBikesButton";
      AllBikesButton.Size = new System.Drawing.Size(175, 30);
      AllBikesButton.TabIndex = 12;
      AllBikesButton.Text = "All Bikes";
      AllBikesButton.UseVisualStyleBackColor = true;
      AllBikesButton.Click += new System.EventHandler(this.AllBikesButton_Click);
      // 
      // LoadCustomersButton
      // 
      this.LoadCustomersButton.Location = new System.Drawing.Point(64, 12);
      this.LoadCustomersButton.Name = "LoadCustomersButton";
      this.LoadCustomersButton.Size = new System.Drawing.Size(175, 30);
      this.LoadCustomersButton.TabIndex = 1;
      this.LoadCustomersButton.Text = "Load Customers";
      this.LoadCustomersButton.UseVisualStyleBackColor = true;
      this.LoadCustomersButton.Click += new System.EventHandler(this.LoadCustomersButton_Click);
      // 
      // CIDTextBox
      // 
      this.CIDTextBox.Location = new System.Drawing.Point(105, 345);
      this.CIDTextBox.Name = "CIDTextBox";
      this.CIDTextBox.Size = new System.Drawing.Size(134, 20);
      this.CIDTextBox.TabIndex = 2;
      // 
      // EmailTextBox
      // 
      this.EmailTextBox.Location = new System.Drawing.Point(105, 372);
      this.EmailTextBox.Name = "EmailTextBox";
      this.EmailTextBox.Size = new System.Drawing.Size(134, 20);
      this.EmailTextBox.TabIndex = 3;
      // 
      // RentingTextBox
      // 
      this.RentingTextBox.Location = new System.Drawing.Point(105, 399);
      this.RentingTextBox.Name = "RentingTextBox";
      this.RentingTextBox.Size = new System.Drawing.Size(134, 20);
      this.RentingTextBox.TabIndex = 4;
      // 
      // CIDLabel
      // 
      this.CIDLabel.AutoSize = true;
      this.CIDLabel.Location = new System.Drawing.Point(74, 348);
      this.CIDLabel.Name = "CIDLabel";
      this.CIDLabel.Size = new System.Drawing.Size(25, 13);
      this.CIDLabel.TabIndex = 5;
      this.CIDLabel.Text = "CID";
      // 
      // EmailLabel
      // 
      this.EmailLabel.AutoSize = true;
      this.EmailLabel.Location = new System.Drawing.Point(64, 374);
      this.EmailLabel.Name = "EmailLabel";
      this.EmailLabel.Size = new System.Drawing.Size(35, 13);
      this.EmailLabel.TabIndex = 6;
      this.EmailLabel.Text = "E-mail";
      // 
      // RentingLabel
      // 
      this.RentingLabel.AutoSize = true;
      this.RentingLabel.Location = new System.Drawing.Point(55, 402);
      this.RentingLabel.Name = "RentingLabel";
      this.RentingLabel.Size = new System.Drawing.Size(44, 13);
      this.RentingLabel.TabIndex = 7;
      this.RentingLabel.Text = "Renting";
      // 
      // AllCustomersListBox
      // 
      this.AllCustomersListBox.FormattingEnabled = true;
      this.AllCustomersListBox.Location = new System.Drawing.Point(15, 48);
      this.AllCustomersListBox.Name = "AllCustomersListBox";
      this.AllCustomersListBox.Size = new System.Drawing.Size(224, 290);
      this.AllCustomersListBox.TabIndex = 9;
      this.AllCustomersListBox.SelectedIndexChanged += new System.EventHandler(this.AllCustomersListBox_SelectedIndexChanged);
      // 
      // BikesForRentListBox
      // 
      this.BikesForRentListBox.FormattingEnabled = true;
      this.BikesForRentListBox.Location = new System.Drawing.Point(319, 48);
      this.BikesForRentListBox.Name = "BikesForRentListBox";
      this.BikesForRentListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.BikesForRentListBox.Size = new System.Drawing.Size(175, 290);
      this.BikesForRentListBox.TabIndex = 11;
      // 
      // AllBikesListBox
      // 
      this.AllBikesListBox.FormattingEnabled = true;
      this.AllBikesListBox.Location = new System.Drawing.Point(516, 48);
      this.AllBikesListBox.Name = "AllBikesListBox";
      this.AllBikesListBox.Size = new System.Drawing.Size(175, 290);
      this.AllBikesListBox.TabIndex = 13;
      this.AllBikesListBox.SelectedIndexChanged += new System.EventHandler(this.AllBikesListBox_SelectedIndexChanged);
      // 
      // YearTextBox
      // 
      this.YearTextBox.Location = new System.Drawing.Point(565, 345);
      this.YearTextBox.Name = "YearTextBox";
      this.YearTextBox.Size = new System.Drawing.Size(126, 20);
      this.YearTextBox.TabIndex = 14;
      // 
      // TypeTextBox
      // 
      this.TypeTextBox.Location = new System.Drawing.Point(565, 372);
      this.TypeTextBox.Name = "TypeTextBox";
      this.TypeTextBox.Size = new System.Drawing.Size(126, 20);
      this.TypeTextBox.TabIndex = 15;
      // 
      // PriceTextBox
      // 
      this.PriceTextBox.Location = new System.Drawing.Point(565, 399);
      this.PriceTextBox.Name = "PriceTextBox";
      this.PriceTextBox.Size = new System.Drawing.Size(126, 20);
      this.PriceTextBox.TabIndex = 16;
      // 
      // RentedTextBox
      // 
      this.RentedTextBox.Location = new System.Drawing.Point(565, 425);
      this.RentedTextBox.Name = "RentedTextBox";
      this.RentedTextBox.Size = new System.Drawing.Size(126, 20);
      this.RentedTextBox.TabIndex = 17;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(530, 348);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 18;
      this.label1.Text = "Year";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(528, 375);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 13);
      this.label2.TabIndex = 19;
      this.label2.Text = "Type";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(528, 402);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 20;
      this.label3.Text = "Price";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(517, 428);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(42, 13);
      this.label4.TabIndex = 21;
      this.label4.Text = "Rented";
      // 
      // ExpectedReturnTextBox
      // 
      this.ExpectedReturnTextBox.Location = new System.Drawing.Point(565, 451);
      this.ExpectedReturnTextBox.Name = "ExpectedReturnTextBox";
      this.ExpectedReturnTextBox.Size = new System.Drawing.Size(126, 20);
      this.ExpectedReturnTextBox.TabIndex = 22;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(472, 454);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(87, 13);
      this.label5.TabIndex = 23;
      this.label5.Text = "Expected Return";
      // 
      // RentButton
      // 
      this.RentButton.Location = new System.Drawing.Point(319, 368);
      this.RentButton.Name = "RentButton";
      this.RentButton.Size = new System.Drawing.Size(175, 24);
      this.RentButton.TabIndex = 25;
      this.RentButton.Text = "Rent";
      this.RentButton.UseVisualStyleBackColor = true;
      this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
      // 
      // ExpDurationTextBox
      // 
      this.ExpDurationTextBox.Location = new System.Drawing.Point(368, 345);
      this.ExpDurationTextBox.Name = "ExpDurationTextBox";
      this.ExpDurationTextBox.Size = new System.Drawing.Size(126, 20);
      this.ExpDurationTextBox.TabIndex = 26;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(316, 348);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(47, 13);
      this.label6.TabIndex = 27;
      this.label6.Text = "Duration";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(105, 428);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(134, 20);
      this.textBox1.TabIndex = 28;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(105, 454);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(134, 20);
      this.textBox2.TabIndex = 29;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(55, 432);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(42, 13);
      this.label7.TabIndex = 30;
      this.label7.Text = "# bikes";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(12, 457);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(87, 13);
      this.label8.TabIndex = 31;
      this.label8.Text = "Expected Return";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(860, 627);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
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
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
  }
}

