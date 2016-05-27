using MySql.Data.MySqlClient;
using PersoneelsRegistratieSysteem.Login;
using PersoneelsRegistratieSysteem.Personeel;
using PersoneelsRegistratieSysteem.Urenregistratie;
using PersoneelsRegistratieSysteem.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersoneelsRegistratieSysteem
{
    public partial class mainForm : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlDataAdapter mySqlDataAdapter;

        public mainForm()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login newMDIChild = new login();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        private void medewerkerToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personeel_overzicht newMDIChild = new personeel_overzicht();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            Focus();
        }

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personeel_toevoegen newMDIChild = new personeel_toevoegen();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void invoerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toevoegen newMDIChild = new toevoegen();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void verlofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verlof newMDIChild = new verlof();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void databaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database newMDIChild = new database();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
