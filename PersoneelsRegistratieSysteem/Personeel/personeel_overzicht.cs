using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PersoneelsRegistratieSysteem.Personeel
{
    public partial class personeel_overzicht : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlDataAdapter mySqlDataAdapter;
        public personeel_overzicht()
        {
            InitializeComponent();

        }

        private void personeel_overzicht_Load(object sender, EventArgs e)
        {

            server = "dennis.vanginkel.eu";
            database = "dennisvang_prs";
            uid = "dennisvang_denn";
            password = "dennisg#22";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from medewerkers", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS, "medewerkers");

                dataGridView1.AutoGenerateColumns = false;

                //Set Columns Count
                dataGridView1.ColumnCount = 7;

                //Add Columns
                dataGridView1.Columns[0].Name = "ID"; // name
                dataGridView1.Columns[0].HeaderText = "ID"; // header text
                dataGridView1.Columns[0].DataPropertyName = "ID"; // field name

                dataGridView1.Columns[1].Name = "voornamen"; // name
                dataGridView1.Columns[1].HeaderText = "Voornamen"; // header text
                dataGridView1.Columns[1].DataPropertyName = "basisinfo_voornamen"; // field name

                dataGridView1.Columns[2].Name = "achternaam"; // name
                dataGridView1.Columns[2].HeaderText = "Achternaam"; // header text
                dataGridView1.Columns[2].DataPropertyName = "basisinfo_achternaam"; // field name

                dataGridView1.Columns[3].Name = "roepnaam"; // name
                dataGridView1.Columns[3].HeaderText = "Roepnaam"; // header text
                dataGridView1.Columns[3].DataPropertyName = "basisinfo_roepnaam"; // field name

                dataGridView1.Columns[4].Name = "telefoonprive";
                dataGridView1.Columns[4].HeaderText = "Telefoon Privé"; // header text
                dataGridView1.Columns[4].DataPropertyName = "contactinfomedewerker_telefoonprive"; // field name

                dataGridView1.Columns[5].Name = "emailadres";
                dataGridView1.Columns[5].HeaderText = "Emailadres"; // header text
                dataGridView1.Columns[5].DataPropertyName = "contactinfomedewerker_primairemailadres"; // field name

                dataGridView1.Columns[6].Name = "functie";
                dataGridView1.Columns[6].HeaderText = "Functie"; // header text
                dataGridView1.Columns[6].DataPropertyName = "medewerkergegevens_functie"; // field name

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "medewerkers";
                //close connection
                this.CloseConnection();
            }
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
        
    }
}

