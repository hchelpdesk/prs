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
using System.Globalization;

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
            if (String.IsNullOrEmpty(login_usernameltxtbox.Text) || String.IsNullOrEmpty(login_wachtwoordtxtbox.Text))
            {
                MessageBox.Show("Vul een Gebruikersnaam en Wachtwoord in om in te loggen.", "PRS - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
            #region logindb
            string connectionString = "server=localhost; Port=3307; Uid=root; Password=usbw; Database=test;";
            MySqlConnection conn = null;
            MySqlDataReader rdr = null;
            // Verbinding opzetten naar de mysql database en de login tabel raadplegen.
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                string login_username = login_usernameltxtbox.Text;
                string login_password = login_wachtwoordtxtbox.Text;

                string stm = "SELECT login_username, login_password FROM login WHERE login_username =\"" + login_username + "\" AND login_password =\"" +login_wachtwoordtxtbox.Text+"\"";
                MessageBox.Show(stm);
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    // kijken of wat er is ingevoerd in de textboxes gelijk is aan wat er in onze DB bekend is. 
                    var username = rdr.GetString(0);
                    var password = rdr.GetString(1);
                    if (login_usernameltxtbox.Text != username || login_wachtwoordtxtbox.Text != password)
                    {
                        MessageBox.Show("Ingevoerd gegevens komen niet overeen. Probeer het opnieuw.");
                    }
                    else
                    {

                        /* Inloggegevens opslaan voor max 12 uur, daarna gebruiker uitloggen.
                        DateTime logintime = DateTime.Now;
                        DateTime loginexpire = logintime.AddHours(12);
                        MessageBox.Show(logintime.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));
                        MessageBox.Show(loginexpire.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));
                        */
                        // De ingevoerde gegevens komen overeen met wat er in de DB staat. 
                        // Opslaan in settings file
                        Properties.Settings.Default.loginusername = username;
                        Properties.Settings.Default.loginpassword = password;
                        Properties.Settings.Default.Save(); // Applicatie moet helemaal afgesloten zijn voordat het opgeslagen wordt. 
                        MessageBox.Show("You have been sucessfully logged in", "PRS - Login ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
                    }


                    //MessageBox.Show(rdr.GetString(0));
                    //MessageBox.Show(rdr.GetString(1));
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
            #endregion


        }
    }
}
