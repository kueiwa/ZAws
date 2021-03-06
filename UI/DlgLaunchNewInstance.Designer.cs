﻿namespace ZAws.Console
{
    partial class DlgLaunchNewInstance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgLaunchNewInstance));
            this.textBoxInstanceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInstanceType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKeyPair = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSecGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAmi = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonRemoveAppFomList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxGitAppType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxGitAppDefaultServerApp = new System.Windows.Forms.CheckBox();
            this.checkBoxGitAppDnsRecord = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGitAppUrl = new System.Windows.Forms.TextBox();
            this.textBoxGitApp = new System.Windows.Forms.TextBox();
            this.textBoxGitAppLocation = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxStrtupScript = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInstanceName
            // 
            this.textBoxInstanceName.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxInstanceName.Location = new System.Drawing.Point(69, 12);
            this.textBoxInstanceName.Name = "textBoxInstanceName";
            this.textBoxInstanceName.Size = new System.Drawing.Size(162, 20);
            this.textBoxInstanceName.TabIndex = 1;
            this.textBoxInstanceName.Text = "ZawsInstance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // comboBoxInstanceType
            // 
            this.comboBoxInstanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstanceType.FormattingEnabled = true;
            this.comboBoxInstanceType.Items.AddRange(new object[] {
            "t1.micro",
            "m1.small",
            "c1.medium",
            "m1.medium",
            "m1.large",
            "m1.xlarge",
            "m2.xlarge",
            "m2.2xlarge",
            "m2.4xlarge",
            "c1.xlarge"});
            this.comboBoxInstanceType.Location = new System.Drawing.Point(69, 39);
            this.comboBoxInstanceType.Name = "comboBoxInstanceType";
            this.comboBoxInstanceType.Size = new System.Drawing.Size(162, 21);
            this.comboBoxInstanceType.TabIndex = 3;
            this.comboBoxInstanceType.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstanceType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // comboBoxKeyPair
            // 
            this.comboBoxKeyPair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyPair.FormattingEnabled = true;
            this.comboBoxKeyPair.Location = new System.Drawing.Point(302, 12);
            this.comboBoxKeyPair.Name = "comboBoxKeyPair";
            this.comboBoxKeyPair.Size = new System.Drawing.Size(162, 21);
            this.comboBoxKeyPair.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Keypair";
            // 
            // comboBoxSecGroup
            // 
            this.comboBoxSecGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecGroup.FormattingEnabled = true;
            this.comboBoxSecGroup.Location = new System.Drawing.Point(302, 39);
            this.comboBoxSecGroup.Name = "comboBoxSecGroup";
            this.comboBoxSecGroup.Size = new System.Drawing.Size(162, 21);
            this.comboBoxSecGroup.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sec. group";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Items.AddRange(new object[] {
            "US East",
            "US West (Oregon)",
            "US West (N.California)",
            "EU West",
            "Asia Pacific (Singapure)",
            "Asia Pacific (Tokyo)",
            "South America"});
            this.comboBoxRegion.Location = new System.Drawing.Point(69, 66);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(162, 21);
            this.comboBoxRegion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Region";
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(489, 10);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(75, 23);
            this.buttonLaunch.TabIndex = 13;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(489, 36);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "AMI";
            // 
            // comboBoxAmi
            // 
            this.comboBoxAmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmi.FormattingEnabled = true;
            this.comboBoxAmi.Location = new System.Drawing.Point(302, 66);
            this.comboBoxAmi.Name = "comboBoxAmi";
            this.comboBoxAmi.Size = new System.Drawing.Size(162, 21);
            this.comboBoxAmi.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonRemoveAppFomList);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.comboBoxGitAppType);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.checkBoxGitAppDefaultServerApp);
            this.tabPage3.Controls.Add(this.checkBoxGitAppDnsRecord);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBoxGitAppUrl);
            this.tabPage3.Controls.Add(this.textBoxGitApp);
            this.tabPage3.Controls.Add(this.textBoxGitAppLocation);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(544, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Startup with app from a git repo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveAppFomList
            // 
            this.buttonRemoveAppFomList.Location = new System.Drawing.Point(350, 105);
            this.buttonRemoveAppFomList.Name = "buttonRemoveAppFomList";
            this.buttonRemoveAppFomList.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAppFomList.TabIndex = 19;
            this.buttonRemoveAppFomList.Text = "Remove";
            this.buttonRemoveAppFomList.UseVisualStyleBackColor = true;
            this.buttonRemoveAppFomList.Click += new System.EventHandler(this.buttonRemoveAppFomList_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(266, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add app.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(51, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(493, 96);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Application repo";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Application URL";
            this.columnHeader2.Width = 223;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // comboBoxGitAppType
            // 
            this.comboBoxGitAppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGitAppType.FormattingEnabled = true;
            this.comboBoxGitAppType.Items.AddRange(new object[] {
            "Rails application",
            "Generic application"});
            this.comboBoxGitAppType.Location = new System.Drawing.Point(139, 107);
            this.comboBoxGitAppType.Name = "comboBoxGitAppType";
            this.comboBoxGitAppType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGitAppType.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(542, 130);
            this.label11.TabIndex = 16;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // checkBoxGitAppDefaultServerApp
            // 
            this.checkBoxGitAppDefaultServerApp.AutoSize = true;
            this.checkBoxGitAppDefaultServerApp.Location = new System.Drawing.Point(364, 84);
            this.checkBoxGitAppDefaultServerApp.Name = "checkBoxGitAppDefaultServerApp";
            this.checkBoxGitAppDefaultServerApp.Size = new System.Drawing.Size(164, 17);
            this.checkBoxGitAppDefaultServerApp.TabIndex = 10;
            this.checkBoxGitAppDefaultServerApp.Text = "Default application on server.";
            this.checkBoxGitAppDefaultServerApp.UseVisualStyleBackColor = true;
            // 
            // checkBoxGitAppDnsRecord
            // 
            this.checkBoxGitAppDnsRecord.AutoSize = true;
            this.checkBoxGitAppDnsRecord.Checked = true;
            this.checkBoxGitAppDnsRecord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGitAppDnsRecord.Location = new System.Drawing.Point(139, 84);
            this.checkBoxGitAppDnsRecord.Name = "checkBoxGitAppDnsRecord";
            this.checkBoxGitAppDnsRecord.Size = new System.Drawing.Size(219, 17);
            this.checkBoxGitAppDnsRecord.TabIndex = 9;
            this.checkBoxGitAppDnsRecord.Text = "Check/create DNS record and Elastic IP";
            this.checkBoxGitAppDnsRecord.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Application type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Application URL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "App. location";
            // 
            // textBoxGitAppUrl
            // 
            this.textBoxGitAppUrl.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxGitAppUrl.Location = new System.Drawing.Point(139, 58);
            this.textBoxGitAppUrl.Name = "textBoxGitAppUrl";
            this.textBoxGitAppUrl.Size = new System.Drawing.Size(405, 20);
            this.textBoxGitAppUrl.TabIndex = 8;
            this.textBoxGitAppUrl.Text = "b1.zwr.fi";
            this.textBoxGitAppUrl.TextChanged += new System.EventHandler(this.textBoxGitAppUrl_TextChanged);
            // 
            // textBoxGitApp
            // 
            this.textBoxGitApp.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxGitApp.Location = new System.Drawing.Point(139, 32);
            this.textBoxGitApp.Name = "textBoxGitApp";
            this.textBoxGitApp.Size = new System.Drawing.Size(405, 20);
            this.textBoxGitApp.TabIndex = 6;
            this.textBoxGitApp.Text = "b1";
            this.textBoxGitApp.TextChanged += new System.EventHandler(this.textBoxGitApp_TextChanged);
            // 
            // textBoxGitAppLocation
            // 
            this.textBoxGitAppLocation.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxGitAppLocation.Location = new System.Drawing.Point(139, 6);
            this.textBoxGitAppLocation.Name = "textBoxGitAppLocation";
            this.textBoxGitAppLocation.Size = new System.Drawing.Size(405, 20);
            this.textBoxGitAppLocation.TabIndex = 1;
            this.textBoxGitAppLocation.Text = "git@github.com:zmilojko/b1.git";
            this.textBoxGitAppLocation.TextChanged += new System.EventHandler(this.textBoxGitAppLocation_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBoxStrtupScript);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Startup script";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load from file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxStrtupScript
            // 
            this.textBoxStrtupScript.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxStrtupScript.Location = new System.Drawing.Point(6, 6);
            this.textBoxStrtupScript.Multiline = true;
            this.textBoxStrtupScript.Name = "textBoxStrtupScript";
            this.textBoxStrtupScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxStrtupScript.Size = new System.Drawing.Size(538, 390);
            this.textBoxStrtupScript.TabIndex = 0;
            this.textBoxStrtupScript.Text = "#!/bin/bash -ex\r\necho \'Startup script was not defined. Nothing executed.\'\r\n";
            this.textBoxStrtupScript.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 457);
            this.tabControl1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Max price";
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.Location = new System.Drawing.Point(69, 93);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(198, 21);
            this.comboBoxPrice.TabIndex = 15;
            // 
            // DlgLaunchNewInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(576, 588);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.comboBoxAmi);
            this.Controls.Add(this.comboBoxSecGroup);
            this.Controls.Add(this.comboBoxKeyPair);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.comboBoxInstanceType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInstanceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgLaunchNewInstance";
            this.Text = "Launch new EC2 instance";
            this.Load += new System.EventHandler(this.DlgLaunchNewInstance_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInstanceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInstanceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKeyPair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSecGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAmi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxStrtupScript;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGitAppUrl;
        private System.Windows.Forms.TextBox textBoxGitApp;
        private System.Windows.Forms.TextBox textBoxGitAppLocation;
        private System.Windows.Forms.ComboBox comboBoxGitAppType;
        private System.Windows.Forms.CheckBox checkBoxGitAppDefaultServerApp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox checkBoxGitAppDnsRecord;
        private System.Windows.Forms.Button buttonRemoveAppFomList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPrice;
    }
}