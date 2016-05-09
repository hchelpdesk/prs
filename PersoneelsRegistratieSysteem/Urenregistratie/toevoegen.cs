using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersoneelsRegistratieSysteem.Urenregistratie
{
    public partial class toevoegen : Form
    {
        public toevoegen()
        {
            InitializeComponent();
        }

        private void toevoegen_Load(object sender, EventArgs e)
        {
            #region medewerker_combobox
            // Werknemers ophalen uit de DB en in combobox weergeven.
            var connectionString = "Server=dennis.vanginkel.eu;Database=dennisvang_prs;Uid=dennisvang_denn;Pwd=dennisg#22;";
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



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void urenreg_cmbboxemployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region aantaldgn_maand
            // Uitzoeken welk jaartal het is
            // Uitzoeken welke maand het is.
            // uitzoeken welke dag het is. 
            DateTime now = DateTime.Now;
            int currentmonth = now.Month;
            int currentYear = now.Year;
            int currentday = now.Day;

            // Kijken hoeveel dagen er in de Huidige maand zitten. 
            int DaysinCurrMonth = DateTime.DaysInMonth(currentYear, currentmonth);
            //MessageBox.Show(DaysinCurrMonth.ToString());

            // Uitzoeken welke dag het is vandaag. 
            DateTime currentDay = new DateTime(currentYear, currentmonth, currentday);
            MessageBox.Show(currentday.ToString());


            /* Combobox vullen met de datums
             * 
             * i = 1 
             * daysincurrentmonth = 31
             * currentday.tostring() = 9
             * 8,7,6,5,4,3,2,1 hoeven NIET in de combobox gezet te worden.
             * 
             */
           
            for (int i = 1; i != currentday; )
            {
                int daysincurrentmonth = DateTime.DaysInMonth(currentYear, currentmonth);
                for (int ie = currentday; ie <= daysincurrentmonth; ie++)
                {
                    //string test1 = ie + "-" + currentmonth + "-" + currentYear;
                    comboBox1.Items.Add(ie);
                }

            }

            #endregion
        }
    }
}
