using PersoneelsRegistratieSysteem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PersoneelsRegistratieSysteem.Settings
{
    public partial class database : Form
    {
        public database()
        {
            InitializeComponent();
        }

        private void db_settingscancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void db_settings_savebtn_Click(object sender, EventArgs e)
        {
            // Er wordt op de Save knop gedrukt. Kijken of er geen lege opties e.d. zijn
            #region DatabaseproviderCHCK
            // Kijken of er een radio button geselecteerd is 
            if (dbsettings_mssql2012.Checked == false && dbsettings_mssql2014.Checked == false && dbsettings_mssql2016.Checked == false && dbsettings_mysql51.Checked == false && dbsettings_mysql55.Checked == false && dbsettings_mysql56.Checked == false)
            {
                // Er is geen keuze gemaakt. Een foutmelding weergeven in de vorm van een MessageBox
                MessageBox.Show("You need to pick a provider in order to complete configuration", "Database Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dbsettings_mssql2012.Checked == true)
            {
                // MS SQL 2012 is gekozen als provider. 
                // Connection string aanmaken voor MS SQL xxxx
                // En de invoer uit het form opslaan in application settings.

            }
            else if (dbsettings_mssql2014.Checked == true)
            {
                // MS SQL 2014 is gekozen als provider. 
                // Connection string aanmaken voor MS SQL xxxx
                // En de invoer uit het form opslaan in application settings.

            }
            else if (dbsettings_mssql2016.Checked == true)
            {
                // MS SQL 2016 is gekozen als provider. 
                // Connection string aanmaken voor MS SQL xxxx
                // En de invoer uit het form opslaan in application settings.
            }
            #endregion
            #region databasedetailsCHCK
            if (db_hostnameiptxtbox.Text == "" || db_porttxtbox.Text == "" || db_usernametxtbox.Text == "" || db_passwordtxtbox.Text == "" || db_dbnametxtbox.Text == "")
            {
                MessageBox.Show("You have to fill in all fields.", "Database Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            /* Alle checks zijn gedaan. Nu gaan we de opgegevens informatie verwerken   
             * 
             * - Alle gegevens wegschrijven in app settings
             * - Connection string aanmaken afhankelijk van Database provider
            */

            // Informatie wegschrijven naar App Settings
            Properties.Settings.Default.dbsettings_hostnameip = db_hostnameiptxtbox.Text;
            Properties.Settings.Default.dbsettings_port = db_porttxtbox.Text;
            Properties.Settings.Default.dbsettings_username = db_usernametxtbox.Text;
            Properties.Settings.Default.dbsettings_password = db_passwordtxtbox.Text;
            Properties.Settings.Default.dbsettings_database = db_dbnametxtbox.Text;
            Properties.Settings.Default.Save();
            if (dbsettings_mssql2012.Checked == true || dbsettings_mssql2014.Checked == true || dbsettings_mssql2016.Checked == true)
            {
                // Connectionstring voor MS SQL Server maken en wegschrijven.
                string mssqlconn = "server="+Properties.Settings.Default.dbsettings_hostnameip +","+Properties.Settings.Default.dbsettings_port+ ";Database="+ Properties.Settings.Default.dbsettings_database +";User Id="+ Properties.Settings.Default.dbsettings_username +";Password=" + Properties.Settings.Default.dbsettings_password+";";
                //MessageBox.Show(conn);
                Properties.Settings.Default.MSSQLconnectionstring = mssqlconn;
                Properties.Settings.Default.Save();
            }
            else if(dbsettings_mysql51.Checked == true || dbsettings_mysql55.Checked == true || dbsettings_mysql56.Checked ==true)
            {
                // Connection string voor MySQL maken en wegschrijven.
                string mysqlconn = "Server=" + Properties.Settings.Default.dbsettings_hostnameip + ";Port=" + Properties.Settings.Default.dbsettings_port + ";Database=" + Properties.Settings.Default.dbsettings_database + ";Ui=" + Properties.Settings.Default.dbsettings_username + ";Pwd=" + Properties.Settings.Default.dbsettings_password + ";";
                MessageBox.Show(mysqlconn);
                Properties.Settings.Default.MYSQLconnectionstring = mysqlconn;
                Properties.Settings.Default.Save();
            }
            MessageBox.Show("Settings have been Saved.", "Database Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        private void database_Load(object sender, EventArgs e)
        {
            db_hostnameiptxtbox.Text = Properties.Settings.Default.dbsettings_hostnameip;
            db_porttxtbox.Text = Properties.Settings.Default.dbsettings_port;
            db_usernametxtbox.Text = Properties.Settings.Default.dbsettings_username;
            db_passwordtxtbox.Text = Properties.Settings.Default.dbsettings_password;
            db_dbnametxtbox.Text = Properties.Settings.Default.dbsettings_database;
        }

        private void dbsettings_mssql2012_CheckedChanged(object sender, EventArgs e)
        {
            databasesettings_dbdetailsgrpbox.Visible = true;
        }

        private void dbsettings_mssql2014_CheckedChanged(object sender, EventArgs e)
        {
            databasesettings_dbdetailsgrpbox.Visible = true;
        }

        private void dbsettings_mssql2016_CheckedChanged(object sender, EventArgs e)
        {
            databasesettings_dbdetailsgrpbox.Visible = true;
        }

        private void dbsettings_mysql51_CheckedChanged(object sender, EventArgs e)
        {
            databasesettings_dbdetailsgrpbox.Visible = true;
        }

        private void dbsettings_mysql55_CheckedChanged(object sender, EventArgs e)
        {
            databasesettings_dbdetailsgrpbox.Visible = true;
        }

        private void dbsettings_mysql56_CheckedChanged(object sender, EventArgs e)
        {
            databasesettings_dbdetailsgrpbox.Visible = true;
        }
    }
}

