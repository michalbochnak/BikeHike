﻿namespace CS480_Project_02
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
      this.listView1 = new System.Windows.Forms.ListView();
      this.LoadCustomersButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(13, 13);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(237, 328);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // LoadCustomersButton
      // 
      this.LoadCustomersButton.Location = new System.Drawing.Point(13, 348);
      this.LoadCustomersButton.Name = "LoadCustomersButton";
      this.LoadCustomersButton.Size = new System.Drawing.Size(237, 31);
      this.LoadCustomersButton.TabIndex = 1;
      this.LoadCustomersButton.Text = "Load Customers";
      this.LoadCustomersButton.UseVisualStyleBackColor = true;
      this.LoadCustomersButton.Click += new System.EventHandler(this.LoadCustomersButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.LoadCustomersButton);
      this.Controls.Add(this.listView1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button LoadCustomersButton;
  }
}

