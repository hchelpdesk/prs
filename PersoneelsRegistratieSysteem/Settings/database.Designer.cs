namespace PersoneelsRegistratieSysteem.Settings
{
    partial class database
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
            this.databasesettings_dbprovidergrpbox = new System.Windows.Forms.GroupBox();
            this.dbsettings_mysql56 = new System.Windows.Forms.RadioButton();
            this.dbsettings_mysql55 = new System.Windows.Forms.RadioButton();
            this.dbsettings_mysql51 = new System.Windows.Forms.RadioButton();
            this.dbsettings_mssql2016 = new System.Windows.Forms.RadioButton();
            this.dbsettings_mssql2014 = new System.Windows.Forms.RadioButton();
            this.dbsettings_mssql2012 = new System.Windows.Forms.RadioButton();
            this.databasesettings_dbdetailsgrpbox = new System.Windows.Forms.GroupBox();
            this.db_porttxtbox = new System.Windows.Forms.TextBox();
            this.db_hostnameiptxtbox = new System.Windows.Forms.TextBox();
            this.db_portlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.db_passwordtxtbox = new System.Windows.Forms.TextBox();
            this.db_lbl = new System.Windows.Forms.Label();
            this.db_dbnametxtbox = new System.Windows.Forms.TextBox();
            this.dbpasswordlbl = new System.Windows.Forms.Label();
            this.db_usernametxtbox = new System.Windows.Forms.TextBox();
            this.dbusernamelbl = new System.Windows.Forms.Label();
            this.db_settings_savebtn = new System.Windows.Forms.Button();
            this.db_settingscancelbtn = new System.Windows.Forms.Button();
            this.databasesettings_dbprovidergrpbox.SuspendLayout();
            this.databasesettings_dbdetailsgrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // databasesettings_dbprovidergrpbox
            // 
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.dbsettings_mysql56);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.dbsettings_mysql55);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.dbsettings_mysql51);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.dbsettings_mssql2016);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.dbsettings_mssql2014);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.dbsettings_mssql2012);
            this.databasesettings_dbprovidergrpbox.Location = new System.Drawing.Point(12, 12);
            this.databasesettings_dbprovidergrpbox.Name = "databasesettings_dbprovidergrpbox";
            this.databasesettings_dbprovidergrpbox.Size = new System.Drawing.Size(196, 88);
            this.databasesettings_dbprovidergrpbox.TabIndex = 0;
            this.databasesettings_dbprovidergrpbox.TabStop = false;
            this.databasesettings_dbprovidergrpbox.Text = "Select your Database provider";
            // 
            // dbsettings_mysql56
            // 
            this.dbsettings_mysql56.AutoSize = true;
            this.dbsettings_mysql56.Location = new System.Drawing.Point(104, 65);
            this.dbsettings_mysql56.Name = "dbsettings_mysql56";
            this.dbsettings_mysql56.Size = new System.Drawing.Size(78, 17);
            this.dbsettings_mysql56.TabIndex = 6;
            this.dbsettings_mysql56.TabStop = true;
            this.dbsettings_mysql56.Text = "MySQL 5.6";
            this.dbsettings_mysql56.UseVisualStyleBackColor = true;
            this.dbsettings_mysql56.CheckedChanged += new System.EventHandler(this.dbsettings_mysql56_CheckedChanged);
            // 
            // dbsettings_mysql55
            // 
            this.dbsettings_mysql55.AutoSize = true;
            this.dbsettings_mysql55.Location = new System.Drawing.Point(104, 42);
            this.dbsettings_mysql55.Name = "dbsettings_mysql55";
            this.dbsettings_mysql55.Size = new System.Drawing.Size(78, 17);
            this.dbsettings_mysql55.TabIndex = 5;
            this.dbsettings_mysql55.TabStop = true;
            this.dbsettings_mysql55.Text = "MySQL 5.5";
            this.dbsettings_mysql55.UseVisualStyleBackColor = true;
            this.dbsettings_mysql55.CheckedChanged += new System.EventHandler(this.dbsettings_mysql55_CheckedChanged);
            // 
            // dbsettings_mysql51
            // 
            this.dbsettings_mysql51.AutoSize = true;
            this.dbsettings_mysql51.Location = new System.Drawing.Point(104, 19);
            this.dbsettings_mysql51.Name = "dbsettings_mysql51";
            this.dbsettings_mysql51.Size = new System.Drawing.Size(78, 17);
            this.dbsettings_mysql51.TabIndex = 4;
            this.dbsettings_mysql51.TabStop = true;
            this.dbsettings_mysql51.Text = "MySQL 5.1";
            this.dbsettings_mysql51.UseVisualStyleBackColor = true;
            this.dbsettings_mysql51.CheckedChanged += new System.EventHandler(this.dbsettings_mysql51_CheckedChanged);
            // 
            // dbsettings_mssql2016
            // 
            this.dbsettings_mssql2016.AutoSize = true;
            this.dbsettings_mssql2016.Location = new System.Drawing.Point(6, 65);
            this.dbsettings_mssql2016.Name = "dbsettings_mssql2016";
            this.dbsettings_mssql2016.Size = new System.Drawing.Size(92, 17);
            this.dbsettings_mssql2016.TabIndex = 3;
            this.dbsettings_mssql2016.TabStop = true;
            this.dbsettings_mssql2016.Text = "MS SQL 2016";
            this.dbsettings_mssql2016.UseVisualStyleBackColor = true;
            this.dbsettings_mssql2016.CheckedChanged += new System.EventHandler(this.dbsettings_mssql2016_CheckedChanged);
            // 
            // dbsettings_mssql2014
            // 
            this.dbsettings_mssql2014.AutoSize = true;
            this.dbsettings_mssql2014.Location = new System.Drawing.Point(6, 42);
            this.dbsettings_mssql2014.Name = "dbsettings_mssql2014";
            this.dbsettings_mssql2014.Size = new System.Drawing.Size(92, 17);
            this.dbsettings_mssql2014.TabIndex = 2;
            this.dbsettings_mssql2014.TabStop = true;
            this.dbsettings_mssql2014.Text = "MS SQL 2014";
            this.dbsettings_mssql2014.UseVisualStyleBackColor = true;
            this.dbsettings_mssql2014.CheckedChanged += new System.EventHandler(this.dbsettings_mssql2014_CheckedChanged);
            // 
            // dbsettings_mssql2012
            // 
            this.dbsettings_mssql2012.AutoSize = true;
            this.dbsettings_mssql2012.Location = new System.Drawing.Point(6, 19);
            this.dbsettings_mssql2012.Name = "dbsettings_mssql2012";
            this.dbsettings_mssql2012.Size = new System.Drawing.Size(92, 17);
            this.dbsettings_mssql2012.TabIndex = 1;
            this.dbsettings_mssql2012.TabStop = true;
            this.dbsettings_mssql2012.Text = "MS SQL 2012";
            this.dbsettings_mssql2012.UseVisualStyleBackColor = true;
            this.dbsettings_mssql2012.CheckedChanged += new System.EventHandler(this.dbsettings_mssql2012_CheckedChanged);
            // 
            // databasesettings_dbdetailsgrpbox
            // 
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_porttxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_hostnameiptxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_portlbl);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.label1);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_passwordtxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_lbl);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_dbnametxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.dbpasswordlbl);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_usernametxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.dbusernamelbl);
            this.databasesettings_dbdetailsgrpbox.Location = new System.Drawing.Point(12, 106);
            this.databasesettings_dbdetailsgrpbox.Name = "databasesettings_dbdetailsgrpbox";
            this.databasesettings_dbdetailsgrpbox.Size = new System.Drawing.Size(195, 224);
            this.databasesettings_dbdetailsgrpbox.TabIndex = 2;
            this.databasesettings_dbdetailsgrpbox.TabStop = false;
            this.databasesettings_dbdetailsgrpbox.Text = "Database Details";
            this.databasesettings_dbdetailsgrpbox.Visible = false;
            // 
            // db_porttxtbox
            // 
            this.db_porttxtbox.Location = new System.Drawing.Point(6, 77);
            this.db_porttxtbox.Name = "db_porttxtbox";
            this.db_porttxtbox.Size = new System.Drawing.Size(179, 20);
            this.db_porttxtbox.TabIndex = 9;
            // 
            // db_hostnameiptxtbox
            // 
            this.db_hostnameiptxtbox.Location = new System.Drawing.Point(6, 38);
            this.db_hostnameiptxtbox.Name = "db_hostnameiptxtbox";
            this.db_hostnameiptxtbox.Size = new System.Drawing.Size(179, 20);
            this.db_hostnameiptxtbox.TabIndex = 8;
            // 
            // db_portlbl
            // 
            this.db_portlbl.AutoSize = true;
            this.db_portlbl.Location = new System.Drawing.Point(6, 61);
            this.db_portlbl.Name = "db_portlbl";
            this.db_portlbl.Size = new System.Drawing.Size(26, 13);
            this.db_portlbl.TabIndex = 10;
            this.db_portlbl.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "HOSTNAME / IP Address:";
            // 
            // db_passwordtxtbox
            // 
            this.db_passwordtxtbox.Location = new System.Drawing.Point(8, 155);
            this.db_passwordtxtbox.Name = "db_passwordtxtbox";
            this.db_passwordtxtbox.PasswordChar = '*';
            this.db_passwordtxtbox.Size = new System.Drawing.Size(177, 20);
            this.db_passwordtxtbox.TabIndex = 11;
            this.db_passwordtxtbox.UseSystemPasswordChar = true;
            // 
            // db_lbl
            // 
            this.db_lbl.AutoSize = true;
            this.db_lbl.Location = new System.Drawing.Point(6, 178);
            this.db_lbl.Name = "db_lbl";
            this.db_lbl.Size = new System.Drawing.Size(53, 13);
            this.db_lbl.TabIndex = 4;
            this.db_lbl.Text = "Database";
            // 
            // db_dbnametxtbox
            // 
            this.db_dbnametxtbox.Location = new System.Drawing.Point(8, 194);
            this.db_dbnametxtbox.Name = "db_dbnametxtbox";
            this.db_dbnametxtbox.Size = new System.Drawing.Size(177, 20);
            this.db_dbnametxtbox.TabIndex = 12;
            // 
            // dbpasswordlbl
            // 
            this.dbpasswordlbl.AutoSize = true;
            this.dbpasswordlbl.Location = new System.Drawing.Point(6, 139);
            this.dbpasswordlbl.Name = "dbpasswordlbl";
            this.dbpasswordlbl.Size = new System.Drawing.Size(53, 13);
            this.dbpasswordlbl.TabIndex = 2;
            this.dbpasswordlbl.Text = "Password";
            // 
            // db_usernametxtbox
            // 
            this.db_usernametxtbox.Location = new System.Drawing.Point(6, 116);
            this.db_usernametxtbox.Name = "db_usernametxtbox";
            this.db_usernametxtbox.Size = new System.Drawing.Size(177, 20);
            this.db_usernametxtbox.TabIndex = 10;
            // 
            // dbusernamelbl
            // 
            this.dbusernamelbl.AutoSize = true;
            this.dbusernamelbl.Location = new System.Drawing.Point(6, 100);
            this.dbusernamelbl.Name = "dbusernamelbl";
            this.dbusernamelbl.Size = new System.Drawing.Size(55, 13);
            this.dbusernamelbl.TabIndex = 0;
            this.dbusernamelbl.Text = "Username";
            // 
            // db_settings_savebtn
            // 
            this.db_settings_savebtn.Location = new System.Drawing.Point(116, 336);
            this.db_settings_savebtn.Name = "db_settings_savebtn";
            this.db_settings_savebtn.Size = new System.Drawing.Size(92, 23);
            this.db_settings_savebtn.TabIndex = 0;
            this.db_settings_savebtn.Text = "Save Settings";
            this.db_settings_savebtn.UseVisualStyleBackColor = true;
            this.db_settings_savebtn.Click += new System.EventHandler(this.db_settings_savebtn_Click);
            // 
            // db_settingscancelbtn
            // 
            this.db_settingscancelbtn.Location = new System.Drawing.Point(12, 336);
            this.db_settingscancelbtn.Name = "db_settingscancelbtn";
            this.db_settingscancelbtn.Size = new System.Drawing.Size(75, 23);
            this.db_settingscancelbtn.TabIndex = 13;
            this.db_settingscancelbtn.Text = "Cancel";
            this.db_settingscancelbtn.UseVisualStyleBackColor = true;
            this.db_settingscancelbtn.Click += new System.EventHandler(this.db_settingscancelbtn_Click);
            // 
            // database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 369);
            this.Controls.Add(this.db_settingscancelbtn);
            this.Controls.Add(this.db_settings_savebtn);
            this.Controls.Add(this.databasesettings_dbdetailsgrpbox);
            this.Controls.Add(this.databasesettings_dbprovidergrpbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Settings";
            this.Load += new System.EventHandler(this.database_Load);
            this.databasesettings_dbprovidergrpbox.ResumeLayout(false);
            this.databasesettings_dbprovidergrpbox.PerformLayout();
            this.databasesettings_dbdetailsgrpbox.ResumeLayout(false);
            this.databasesettings_dbdetailsgrpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox databasesettings_dbprovidergrpbox;
        private System.Windows.Forms.GroupBox databasesettings_dbdetailsgrpbox;
        private System.Windows.Forms.TextBox db_passwordtxtbox;
        private System.Windows.Forms.Label db_lbl;
        private System.Windows.Forms.TextBox db_dbnametxtbox;
        private System.Windows.Forms.Label dbpasswordlbl;
        private System.Windows.Forms.TextBox db_usernametxtbox;
        private System.Windows.Forms.Label dbusernamelbl;
        private System.Windows.Forms.Button db_settings_savebtn;
        private System.Windows.Forms.Button db_settingscancelbtn;
        private System.Windows.Forms.TextBox db_porttxtbox;
        private System.Windows.Forms.TextBox db_hostnameiptxtbox;
        private System.Windows.Forms.Label db_portlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dbsettings_mysql56;
        private System.Windows.Forms.RadioButton dbsettings_mysql55;
        private System.Windows.Forms.RadioButton dbsettings_mysql51;
        private System.Windows.Forms.RadioButton dbsettings_mssql2016;
        private System.Windows.Forms.RadioButton dbsettings_mssql2014;
        private System.Windows.Forms.RadioButton dbsettings_mssql2012;
    }
}