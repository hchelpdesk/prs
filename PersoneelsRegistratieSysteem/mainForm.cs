using MySql.Data.MySqlClient;
using PersoneelsRegistratieSysteem.Login;
using PersoneelsRegistratieSysteem.Personeel;
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
            //VarribleKeeper.MySQLConnectionString = your connection string
            //info being your table name
            MySqlConnection mysqlCon = new

            MySqlConnection("Server=dennis.vanginkel.eu;Database=dennisvang_prs;Uid=dennisvang_denn;Pwd=dennisg#22;");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from verlof";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            verlofdvg.DataSource = bSource;
        }

        private void medewerkerToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personeel_overzicht newMDIChild = new personeel_overzicht();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personeel_toevoegen newMDIChild = new personeel_toevoegen();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
