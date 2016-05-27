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
            this.mysql_56ckckbox = new System.Windows.Forms.CheckBox();
            this.mysql_55ckckbox = new System.Windows.Forms.CheckBox();
            this.mssql2016_chckbox = new System.Windows.Forms.CheckBox();
            this.mysql_51ckckbox = new System.Windows.Forms.CheckBox();
            this.mssql2014_chckbox = new System.Windows.Forms.CheckBox();
            this.mssql2012_chckbox = new System.Windows.Forms.CheckBox();
            this.databasesettings_connectiontypgrpbox = new System.Windows.Forms.GroupBox();
            this.wancheckbox = new System.Windows.Forms.CheckBox();
            this.lancheckbox = new System.Windows.Forms.CheckBox();
            this.databasesettings_dbdetailsgrpbox = new System.Windows.Forms.GroupBox();
            this.db_porttxtbox = new System.Windows.Forms.TextBox();
            this.db_portlbl = new System.Windows.Forms.Label();
            this.db_passwordtxtbox = new System.Windows.Forms.TextBox();
            this.db_lbl = new System.Windows.Forms.Label();
            this.db_dbnametxtbox = new System.Windows.Forms.TextBox();
            this.dbpasswordlbl = new System.Windows.Forms.Label();
            this.db_usernametxtbox = new System.Windows.Forms.TextBox();
            this.dbusernamelbl = new System.Windows.Forms.Label();
            this.db_settings_savebtn = new System.Windows.Forms.Button();
            this.db_settingscancelbtn = new System.Windows.Forms.Button();
            this.databasesettings_dbprovidergrpbox.SuspendLayout();
            this.databasesettings_connectiontypgrpbox.SuspendLayout();
            this.databasesettings_dbdetailsgrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // databasesettings_dbprovidergrpbox
            // 
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.mysql_56ckckbox);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.mysql_55ckckbox);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.mssql2016_chckbox);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.mysql_51ckckbox);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.mssql2014_chckbox);
            this.databasesettings_dbprovidergrpbox.Controls.Add(this.mssql2012_chckbox);
            this.databasesettings_dbprovidergrpbox.Location = new System.Drawing.Point(13, 13);
            this.databasesettings_dbprovidergrpbox.Name = "databasesettings_dbprovidergrpbox";
            this.databasesettings_dbprovidergrpbox.Size = new System.Drawing.Size(195, 100);
            this.databasesettings_dbprovidergrpbox.TabIndex = 0;
            this.databasesettings_dbprovidergrpbox.TabStop = false;
            this.databasesettings_dbprovidergrpbox.Text = "Select your Database provider";
            // 
            // mysql_56ckckbox
            // 
            this.mysql_56ckckbox.AutoSize = true;
            this.mysql_56ckckbox.Location = new System.Drawing.Point(106, 66);
            this.mysql_56ckckbox.Name = "mysql_56ckckbox";
            this.mysql_56ckckbox.Size = new System.Drawing.Size(79, 17);
            this.mysql_56ckckbox.TabIndex = 5;
            this.mysql_56ckckbox.Text = "MySQL 5.6";
            this.mysql_56ckckbox.UseVisualStyleBackColor = true;
            // 
            // mysql_55ckckbox
            // 
            this.mysql_55ckckbox.AutoSize = true;
            this.mysql_55ckckbox.Location = new System.Drawing.Point(106, 43);
            this.mysql_55ckckbox.Name = "mysql_55ckckbox";
            this.mysql_55ckckbox.Size = new System.Drawing.Size(79, 17);
            this.mysql_55ckckbox.TabIndex = 4;
            this.mysql_55ckckbox.Text = "MySQL 5.5";
            this.mysql_55ckckbox.UseVisualStyleBackColor = true;
            // 
            // mssql2016_chckbox
            // 
            this.mssql2016_chckbox.AutoSize = true;
            this.mssql2016_chckbox.Location = new System.Drawing.Point(7, 67);
            this.mssql2016_chckbox.Name = "mssql2016_chckbox";
            this.mssql2016_chckbox.Size = new System.Drawing.Size(93, 17);
            this.mssql2016_chckbox.TabIndex = 3;
            this.mssql2016_chckbox.Text = "MS SQL 2016";
            this.mssql2016_chckbox.UseVisualStyleBackColor = true;
            // 
            // mysql_51ckckbox
            // 
            this.mysql_51ckckbox.AutoSize = true;
            this.mysql_51ckckbox.Location = new System.Drawing.Point(106, 20);
            this.mysql_51ckckbox.Name = "mysql_51ckckbox";
            this.mysql_51ckckbox.Size = new System.Drawing.Size(79, 17);
            this.mysql_51ckckbox.TabIndex = 2;
            this.mysql_51ckckbox.Text = "MySQL 5.1";
            this.mysql_51ckckbox.UseVisualStyleBackColor = true;
            // 
            // mssql2014_chckbox
            // 
            this.mssql2014_chckbox.AutoSize = true;
            this.mssql2014_chckbox.Location = new System.Drawing.Point(7, 44);
            this.mssql2014_chckbox.Name = "mssql2014_chckbox";
            this.mssql2014_chckbox.Size = new System.Drawing.Size(93, 17);
            this.mssql2014_chckbox.TabIndex = 1;
            this.mssql2014_chckbox.Text = "MS SQL 2014";
            this.mssql2014_chckbox.UseVisualStyleBackColor = true;
            // 
            // mssql2012_chckbox
            // 
            this.mssql2012_chckbox.AutoSize = true;
            this.mssql2012_chckbox.Location = new System.Drawing.Point(7, 20);
            this.mssql2012_chckbox.Name = "mssql2012_chckbox";
            this.mssql2012_chckbox.Size = new System.Drawing.Size(93, 17);
            this.mssql2012_chckbox.TabIndex = 0;
            this.mssql2012_chckbox.Text = "MS SQL 2012";
            this.mssql2012_chckbox.UseVisualStyleBackColor = true;
            // 
            // databasesettings_connectiontypgrpbox
            // 
            this.databasesettings_connectiontypgrpbox.Controls.Add(this.wancheckbox);
            this.databasesettings_connectiontypgrpbox.Controls.Add(this.lancheckbox);
            this.databasesettings_connectiontypgrpbox.Location = new System.Drawing.Point(13, 119);
            this.databasesettings_connectiontypgrpbox.Name = "databasesettings_connectiontypgrpbox";
            this.databasesettings_connectiontypgrpbox.Size = new System.Drawing.Size(195, 71);
            this.databasesettings_connectiontypgrpbox.TabIndex = 1;
            this.databasesettings_connectiontypgrpbox.TabStop = false;
            this.databasesettings_connectiontypgrpbox.Text = "Connection Type";
            // 
            // wancheckbox
            // 
            this.wancheckbox.AutoSize = true;
            this.wancheckbox.Location = new System.Drawing.Point(7, 43);
            this.wancheckbox.Name = "wancheckbox";
            this.wancheckbox.Size = new System.Drawing.Size(154, 17);
            this.wancheckbox.TabIndex = 1;
            this.wancheckbox.Text = "Wide Area Network (WAN)";
            this.wancheckbox.UseVisualStyleBackColor = true;
            // 
            // lancheckbox
            // 
            this.lancheckbox.AutoSize = true;
            this.lancheckbox.Location = new System.Drawing.Point(7, 20);
            this.lancheckbox.Name = "lancheckbox";
            this.lancheckbox.Size = new System.Drawing.Size(150, 17);
            this.lancheckbox.TabIndex = 0;
            this.lancheckbox.Text = "Local Area Network (LAN)";
            this.lancheckbox.UseVisualStyleBackColor = true;
            // 
            // databasesettings_dbdetailsgrpbox
            // 
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_porttxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_portlbl);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_passwordtxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_lbl);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_dbnametxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.dbpasswordlbl);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.db_usernametxtbox);
            this.databasesettings_dbdetailsgrpbox.Controls.Add(this.dbusernamelbl);
            this.databasesettings_dbdetailsgrpbox.Location = new System.Drawing.Point(12, 196);
            this.databasesettings_dbdetailsgrpbox.Name = "databasesettings_dbdetailsgrpbox";
            this.databasesettings_dbdetailsgrpbox.Size = new System.Drawing.Size(196, 185);
            this.databasesettings_dbdetailsgrpbox.TabIndex = 2;
            this.databasesettings_dbdetailsgrpbox.TabStop = false;
            this.databasesettings_dbdetailsgrpbox.Text = "Database Details";
            // 
            // db_porttxtbox
            // 
            this.db_porttxtbox.Location = new System.Drawing.Point(10, 153);
            this.db_porttxtbox.Name = "db_porttxtbox";
            this.db_porttxtbox.Size = new System.Drawing.Size(105, 20);
            this.db_porttxtbox.TabIndex = 7;
            // 
            // db_portlbl
            // 
            this.db_portlbl.AutoSize = true;
            this.db_portlbl.Location = new System.Drawing.Point(7, 137);
            this.db_portlbl.Name = "db_portlbl";
            this.db_portlbl.Size = new System.Drawing.Size(26, 13);
            this.db_portlbl.TabIndex = 6;
            this.db_portlbl.Text = "Port";
            // 
            // db_passwordtxtbox
            // 
            this.db_passwordtxtbox.Location = new System.Drawing.Point(9, 75);
            this.db_passwordtxtbox.Name = "db_passwordtxtbox";
            this.db_passwordtxtbox.Size = new System.Drawing.Size(105, 20);
            this.db_passwordtxtbox.TabIndex = 5;
            // 
            // db_lbl
            // 
            this.db_lbl.AutoSize = true;
            this.db_lbl.Location = new System.Drawing.Point(7, 98);
            this.db_lbl.Name = "db_lbl";
            this.db_lbl.Size = new System.Drawing.Size(53, 13);
            this.db_lbl.TabIndex = 4;
            this.db_lbl.Text = "Database";
            // 
            // db_dbnametxtbox
            // 
            this.db_dbnametxtbox.Location = new System.Drawing.Point(9, 114);
            this.db_dbnametxtbox.Name = "db_dbnametxtbox";
            this.db_dbnametxtbox.Size = new System.Drawing.Size(105, 20);
            this.db_dbnametxtbox.TabIndex = 3;
            // 
            // dbpasswordlbl
            // 
            this.dbpasswordlbl.AutoSize = true;
            this.dbpasswordlbl.Location = new System.Drawing.Point(7, 59);
            this.dbpasswordlbl.Name = "dbpasswordlbl";
            this.dbpasswordlbl.Size = new System.Drawing.Size(53, 13);
            this.dbpasswordlbl.TabIndex = 2;
            this.dbpasswordlbl.Text = "Password";
            // 
            // db_usernametxtbox
            // 
            this.db_usernametxtbox.Location = new System.Drawing.Point(10, 36);
            this.db_usernametxtbox.Name = "db_usernametxtbox";
            this.db_usernametxtbox.Size = new System.Drawing.Size(105, 20);
            this.db_usernametxtbox.TabIndex = 1;
            // 
            // dbusernamelbl
            // 
            this.dbusernamelbl.AutoSize = true;
            this.dbusernamelbl.Location = new System.Drawing.Point(7, 20);
            this.dbusernamelbl.Name = "dbusernamelbl";
            this.dbusernamelbl.Size = new System.Drawing.Size(55, 13);
            this.dbusernamelbl.TabIndex = 0;
            this.dbusernamelbl.Text = "Username";
            // 
            // db_settings_savebtn
            // 
            this.db_settings_savebtn.Location = new System.Drawing.Point(116, 393);
            this.db_settings_savebtn.Name = "db_settings_savebtn";
            this.db_settings_savebtn.Size = new System.Drawing.Size(92, 23);
            this.db_settings_savebtn.TabIndex = 3;
            this.db_settings_savebtn.Text = "Save Settings";
            this.db_settings_savebtn.UseVisualStyleBackColor = true;
            // 
            // db_settingscancelbtn
            // 
            this.db_settingscancelbtn.Location = new System.Drawing.Point(12, 393);
            this.db_settingscancelbtn.Name = "db_settingscancelbtn";
            this.db_settingscancelbtn.Size = new System.Drawing.Size(75, 23);
            this.db_settingscancelbtn.TabIndex = 4;
            this.db_settingscancelbtn.Text = "Cancel";
            this.db_settingscancelbtn.UseVisualStyleBackColor = true;
            this.db_settingscancelbtn.Click += new System.EventHandler(this.db_settingscancelbtn_Click);
            // 
            // database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 428);
            this.Controls.Add(this.db_settingscancelbtn);
            this.Controls.Add(this.db_settings_savebtn);
            this.Controls.Add(this.databasesettings_dbdetailsgrpbox);
            this.Controls.Add(this.databasesettings_connectiontypgrpbox);
            this.Controls.Add(this.databasesettings_dbprovidergrpbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Settings";
            this.databasesettings_dbprovidergrpbox.ResumeLayout(false);
            this.databasesettings_dbprovidergrpbox.PerformLayout();
            this.databasesettings_connectiontypgrpbox.ResumeLayout(false);
            this.databasesettings_connectiontypgrpbox.PerformLayout();
            this.databasesettings_dbdetailsgrpbox.ResumeLayout(false);
            this.databasesettings_dbdetailsgrpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox databasesettings_dbprovidergrpbox;
        private System.Windows.Forms.CheckBox mysql_56ckckbox;
        private System.Windows.Forms.CheckBox mysql_55ckckbox;
        private System.Windows.Forms.CheckBox mssql2016_chckbox;
        private System.Windows.Forms.CheckBox mysql_51ckckbox;
        private System.Windows.Forms.CheckBox mssql2014_chckbox;
        private System.Windows.Forms.CheckBox mssql2012_chckbox;
        private System.Windows.Forms.GroupBox databasesettings_connectiontypgrpbox;
        private System.Windows.Forms.CheckBox wancheckbox;
        private System.Windows.Forms.CheckBox lancheckbox;
        private System.Windows.Forms.GroupBox databasesettings_dbdetailsgrpbox;
        private System.Windows.Forms.TextBox db_porttxtbox;
        private System.Windows.Forms.Label db_portlbl;
        private System.Windows.Forms.TextBox db_passwordtxtbox;
        private System.Windows.Forms.Label db_lbl;
        private System.Windows.Forms.TextBox db_dbnametxtbox;
        private System.Windows.Forms.Label dbpasswordlbl;
        private System.Windows.Forms.TextBox db_usernametxtbox;
        private System.Windows.Forms.Label dbusernamelbl;
        private System.Windows.Forms.Button db_settings_savebtn;
        private System.Windows.Forms.Button db_settingscancelbtn;
    }
}