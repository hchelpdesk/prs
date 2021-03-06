﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PersoneelsRegistratieSysteem.Urenregistratie
{
    public partial class toevoegen : Form
    {
        private Bitmap bitmap;
        public toevoegen()
        {
            InitializeComponent();
        }

        private void toevoegen_Load(object sender, EventArgs e)
        {

            #region medewerker_combobox
            // Werknemers ophalen uit de DB en in combobox weergeven.
            var connectionString = "server=127.0.0.1;Port=3307; uid=root; pwd=usbw; database=test; ";


            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM medewerkers";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var voorenachternaam = reader.GetString("basisinfo_roepnaam") + " " + reader.GetString("basisinfo_achternaam");
                            urenreg_cmbboxemployees.Items.Add(voorenachternaam);
                        }
                    }
                }

            }
            // Einde werknemers in combobox plaatsen.
            #endregion
            urenregistratie_datum_combobx.Visible = false;
            urenregistratie_dag_combobx.Visible = false;
            urenregistratie_begintijd_combobx.Visible = false;
            urenregistratie_eindtijd_combobox.Visible = false;

        }
        private void urenreg_cmbboxemployees_SelectedIndexChanged(object sender, EventArgs e)
        {

            gewerkteuren_combobox.Visible = true;
            urenregistratie_datum_combobx.Visible = true;
            urenregistratie_datum_lbl.Visible = true;
            #region aantaldgn_maand
            // Uitzoeken welk jaartal het is
            // Uitzoeken welke maand het is.
            // uitzoeken welke dag het is. 
            DateTime now = DateTime.Now;
            int currentmonth = now.Month;
            int currentYear = now.Year;
            int currentday = now.Day;
            //MessageBox.Show(currentday.ToString());


            // Kijken hoeveel dagen er in de Huidige maand zitten. 
            int DaysinCurrMonth = DateTime.DaysInMonth(currentYear, currentmonth);
            //MessageBox.Show(DaysinCurrMonth.ToString());

            // Uitzoeken welke dag het is vandaag. 
            DateTime currentDay = new DateTime(currentYear, currentmonth, currentday);
            //MessageBox.Show(currentday.ToString());


            /*Combobox vullen met de datums
             *  int daysincurrentmonth - Geeft aantal dagen (als int) van de maand waarin we zitten.
             *  
             */
            int daysincurrentmonth = DateTime.DaysInMonth(currentYear, currentmonth);
            for (int i = 1; i <= daysincurrentmonth; i++)
            {
                // string currentdate -  Geeft de datum (in nederlandse notatie bijv.: 11-5-2016 weer)
                //urenregistratie_datum_combobx - Combobox waarin alle nummerieke datums komen te staan.
                DateTime checkday = new DateTime(currentYear, currentmonth, i);
                //MessageBox.Show(checkday.DayOfWeek.ToString());

                if (checkday.DayOfWeek != DayOfWeek.Saturday && checkday.DayOfWeek != DayOfWeek.Sunday)
                {
                    string currentdate = i + "-" + currentmonth + "-" + currentYear;
                    urenregistratie_datum_combobx.Items.Add(currentdate); // datum in 01-01-1970 notatie

                    // Naam van Engels omzetten naar Nederlands en toevoegen aan combobox
                    var englishname = checkday.DayOfWeek.ToString();
                    var dutch = new System.Globalization.CultureInfo("nl-NL");
                    //var dutchname = dutch.DateTimeFormat.GetDayName();

                    //urenregistratie_dag_combobx.Items.Add(englishname);
                }
            }
            #endregion
        }

        private void urenregistratie_datum_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            urenregistratie_dag_combobx.Visible = true;
            urenregistratie_dag_lbl.Visible = true;
        }

        private void urenregistratie_dag_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            urenregistratie_begintijd_combobx.Items.Clear();
            urenregistratie_begintijd_lbl.Visible = true;
            urenregistratie_begintijd_combobx.Visible = true;
            DateTime time = DateTime.Today;

            for (DateTime _time = time.AddHours(8); _time < time.AddHours(18); _time = _time.AddMinutes(15)) //from 16h to 18h hours
            {
                urenregistratie_begintijd_combobx.Items.Add(_time.ToShortTimeString());
            }
        }

        private void urenregistratie_begintijd_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            urenregistratie_eindtijd_combobox.Items.Clear();
            urenregistratie_eindtijd_combobox.Visible = true;
            urenregistratie_eindtijd_lbl.Visible = true;
            DateTime time = DateTime.Today;
            for (DateTime _time = time.AddHours(8); _time < time.AddHours(18); _time = _time.AddMinutes(15)) //from 16h to 18h hours
            {
                urenregistratie_eindtijd_combobox.Items.Add(_time.ToShortTimeString());
            }
        }

        private void urenregistratie_add_btn_Click(object sender, EventArgs e)
        {

            // kijken of er een datum, dag, begintijd en eindtijd is gekozen
            if (urenregistratie_datum_combobx.SelectedIndex == -1 || urenregistratie_dag_combobx.SelectedIndex == -1 || urenregistratie_begintijd_combobx.SelectedIndex == -1 || urenregistratie_eindtijd_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Je moet de gevraagde gegevens invullen !");
            }
            if (urenregistratie_begintijd_combobx.SelectedItem.ToString() == urenregistratie_eindtijd_combobox.SelectedItem.ToString())
            {
                MessageBox.Show("Begin en Eind tijd kunnen niet gelijk zijn. ");
            }
            else
            {
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Dag";
                dataGridView1.Columns[1].Name = "Datum";
                dataGridView1.Columns[2].Name = "Start";
                dataGridView1.Columns[3].Name = "Eind";
                dataGridView1.Columns[4].Name = "Medewerker";

                
                string[] row = new string[] { urenregistratie_dag_combobx.SelectedItem.ToString(), urenregistratie_datum_combobx.SelectedItem.ToString(), urenregistratie_begintijd_combobx.SelectedItem.ToString(), urenregistratie_eindtijd_combobox.SelectedItem.ToString(), urenreg_cmbboxemployees.SelectedItem.ToString() };
                dataGridView1.Rows.Add(row);

                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                urenregistratie_datum_combobx.Items.Remove(urenregistratie_datum_combobx.SelectedItem);
                //urenregistratie_dag_combobx.Items.Remove(urenregistratie_dag_combobx.SelectedItem);

                gewerkte_uren_combobox.Visible = true;
                // Uren per dag uitrekenen en dat voor alle dagen die ingevuld zijn. 
                // Vervolgens de gewerkte uren * aantal dagen = totaalgewerkteurenweek
              


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void urenregistratie_eindtijd_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            urenregistratie_add_btn.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string MyConnectionString = "Server=127.0.0.1; Port=3307; Database=test; Uid=root; Pwd=usbw";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = connection.CreateCommand();
                    if (row.IsNewRow) continue;
                    cmd.Parameters.AddWithValue("@Datum", row.Cells["Datum"].Value);
                    cmd.Parameters.AddWithValue("@Dag", row.Cells["Dag"].Value);
                    cmd.Parameters.AddWithValue("@Start", row.Cells["Start"].Value);
                    cmd.Parameters.AddWithValue("@Eind", row.Cells["Eind"].Value);
                    cmd.Parameters.AddWithValue("@Medewerker", row.Cells["Medewerker"].Value);

                    cmd.CommandText = "INSERT INTO urenregistratie(datum, dag, begintijd, eindtijd, medewerker)VALUES(@dag, @datum, @Start, @Eind, @Medewerker)";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Je uren zijn verwerkt.");
            dataGridView1.Rows.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void urenregistratie_eindtijd_combobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            urenregistratie_add_btn.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter;
            for (counter = 0; counter < (dataGridView1.Rows.Count); counter++) // Kijken hoeveel rijen er zijn.
            {
                if (dataGridView1.Rows[counter].Cells["Start"].Value != null && dataGridView1.Rows[counter].Cells["Eind"] != null) // Als begin en eindtijd niet leeg zijn.
                {
                    for (counter = 0; counter < (dataGridView1.Rows.Count); counter++)
                    {
                        // Als beide niet leeg zijn, wil ik begin tijd weten en eindtijd en het aantal uur verschil tussen de 2
                        // dataGridView1.Rows[counter]
                        
                        var starttijd = dataGridView1.Rows[counter].Cells["start"].Value.ToString();
                        var eindtijd = dataGridView1.Rows[counter].Cells["eind"].Value.ToString();
                        TimeSpan duration = DateTime.Parse(eindtijd).Subtract(DateTime.Parse(starttijd));

                        MessageBox.Show(duration.ToString());

                        urengewerktlbl.Text += duration.ToString();
                     


                    }


                }
            }
        }
    }
}

