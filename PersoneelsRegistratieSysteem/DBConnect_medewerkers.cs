using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace PersoneelsRegistratieSysteem
{
    public class DBConnect_medewerkers
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect_medewerkers()
        {
            Initialize();
        }
        private void Initialize()
        {
            // Initialize Values
            server = "dennis.vanginkel.eu";
            database = "dennisvang_prs";
            uid = "dennisvang_dennis";
            password = "dennisg#22";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        // Open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to the server. Contact the Administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, Please try again");
                        break;
                }
                return false;
            }
        }
        // Close Connection
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
        // Insert statement
        public void Insert()
        {
            string query = "INSERT INTO medewerkers (basisinfo_aanhef, basisinfo_initialen, basisinfo_voornamen, basisinfo_achternaam, basisinfo_roepnaam, contactinfomedewerker_straat, contactinfomedewerker_toevoeing, contactinfomedewerker_postcode, contactinfomedewerker_plaats, contactinfomedewerker_land, contactinfomedewerker_telefoonprive, contactinfomedewerker_telefoonwerk, contactinfomedewerker_mobiel, contactinfomedewerker_primairemailadres, partnerfamilie_voornamen, parnerfamilier_voorvoegsel, partnerfamilie_achternaam, medewerkergegevens_medewerkerid, medewerkergegevens_aanvangdienstverband, medewerkergegevens_contractduur, medewerkergegevens_functie, overig_geslacht, overig_burgelijkestand, overig_geboortedatum, overig_bsnnummer, overig_nationaliteit ) VALUES('John Smith', '33')";

            // Open connection
            if(this.OpenConnection() == true)
            {
                // Create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // execute command
                cmd.ExecuteNonQuery();

                // Close Connection
                this.CloseConnection();
            }
        }
        // Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name = 'John Smith'";

            // Open connection
            if(this.OpenConnection() == true)
            {
                // Create mysql command
                MySqlCommand cmd = new MySqlCommand();
                // Assign Query using commandText
                cmd.CommandText = query;
                // assign the connection, using connection
                cmd.Connection = connection;

                // Execute query
                cmd.ExecuteNonQuery();

                // Close connection
                this.CloseConnection();
            }
        }
        // Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";
            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        // Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM medewerkers";

            // Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();
            list[10] = new List<string>();
            list[11] = new List<string>();
            list[12] = new List<string>();
            list[13] = new List<string>();
            list[14] = new List<string>();
            list[15] = new List<string>();
            list[16] = new List<string>();
            list[17] = new List<string>();
            list[18] = new List<string>();
            list[19] = new List<string>();
            list[20] = new List<string>();
            list[21] = new List<string>();
            list[22] = new List<string>();
            list[23] = new List<string>();
            list[24] = new List<string>();
            list[25] = new List<string>();
            list[26] = new List<string>();
            list[27] = new List<string>();

            // Open connection
            if (this.OpenConnection() == true)
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // create data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // Read the data and store them in the list
                while(dataReader.Read())
                {
                    list[0].Add(dataReader["ID"] + "");
                    list[1].Add(dataReader["basisinfo_aanhef"] + "");
                    list[2].Add(dataReader["basisinfo_initialen"] + "");
                    list[3].Add(dataReader["basisinfo_voornamen"] + "");
                    list[4].Add(dataReader["basisinfo_achternaam"] + "");
                    list[5].Add(dataReader["basisinfo_roepnaam"] + "");
                    list[6].Add(dataReader["contactinfomedewerker_straat"] + "");
                    list[7].Add(dataReader["contactinfomedewerker_toevoeging"] + "");
                    list[8].Add(dataReader["contactinfomedewerker_postcode"] + "");
                    list[9].Add(dataReader["contactinfomedewerker_plaats"] + "");
                    list[10].Add(dataReader["contactinfomedewerker_land"] + "");
                    list[11].Add(dataReader["contactinfomedewerker_telefoonprive"] + "");
                    list[12].Add(dataReader["contactinfomedewerker_telefoonwerk"] + "");
                    list[13].Add(dataReader["contactinfomedewerker_mobiel"] + "");
                    list[14].Add(dataReader["contactinfomedewerker_primairemailadres"] + "");
                    list[15].Add(dataReader["partnerfamilie_voornamen"] + "");
                    list[16].Add(dataReader["partnerfamilie_voorvoegsel"] + "");
                    list[17].Add(dataReader["partnerfamilie_achternaam"] + "");
                    list[18].Add(dataReader["medewerkergegevens_medewerkerid"] + "");
                    list[19].Add(dataReader["medewerkergegevens_aanvangdienstverband"] + "");
                    list[20].Add(dataReader["medewerkergegevens_contractduur"] + "");
                    list[21].Add(dataReader["medewerkergegevens_functie"] + "");
                    list[22].Add(dataReader["overig_geslacht"] + "");
                    list[23].Add(dataReader["overig_burgelijkestand"] + "");
                    list[24].Add(dataReader["overig_geboortedatum"] + "");
                    list[25].Add(dataReader["overig_bsnnummer"] + "");
                    list[26].Add(dataReader["overig_nationaliteit"] + "");
                    
                    
                }
                // close Data Reader
                dataReader.Close();

                // close connection
                this.CloseConnection();

                // return list to be displayed
                return list;
            }else
            {
                return list;
            }
        }
        //Count statement
        public int Count()
        {
            string query = "SELECT * FROM tableinfo";
            int Count = -1;

            //open the connection
            if(this.OpenConnection() == true)
            {
                // Create mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                // Close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
        // Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }
        // Restore
        public void Restor()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }

    }
}
