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


namespace PersoneelsRegistratieSysteem.Login
{
    public partial class login : Form
    {
        public login()
        {
            
            /*
            * PRS - Login
            * 
            * De gebruiker heeft een gebruikersnaam en wachtwoord ontvangen.
            * Wanneer de gebruiker deze invult gaat er gekeken worden of deze kloppen met wat er in het systeem staat
            * 
            * Als de gegevens kloppen, slaan we de gebruikersnaam en het wachtwoord op in de settings van de applicatie.
            * 
            * 
            */
            InitializeComponent();
        }

        private void login_inloggenbtn_Click(object sender, EventArgs e)
        {
            /* Als er op de knop inloggen gedrukt wordt controleren we de gegevens. 
            */
            #region checkfield
            // Kijken of er geen lege velden aangetroffen zijn.
            if(String.IsNullOrEmpty(login_usernameltxtbox.Text) || String.IsNullOrEmpty(login_wachtwoordtxtbox.Text))
            {
                MessageBox.Show("Vul een gebruikersnaam en wachtwoord invullen om in te loggen.", "PRS - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
            #region logindb
            // Verbinding opzetten naar de mysql database en de login tabel raadplegen.
            string connectionString = "server=localhost; Port=3307; Uid=root; Password=usbw; Database=test;";
            MySqlConnection conn = null;
            string username = login_usernameltxtbox.Text;
            string password = login_wachtwoordtxtbox.Text;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT login_username, login_password FROM login WHERE login_username @=" + login_usernameltxtbox.Text +  " AND login_password @=" + login_wachtwoordtxtbox.Text  +"";
                MessageBox.Show(query);
            }catch (MySqlException ex)
            {
                MessageBox.Show("Error: ", ex.ToString());
            }
            if(conn != null)
            {
                conn.Close();
            }
            #endregion


        }
    }
}
