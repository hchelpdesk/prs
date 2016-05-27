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
    public partial class verlof : Form
    {
        public verlof()
        {
            InitializeComponent();
        }

        private void verlof_Load(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            DateTime dt1 = dt.AddDays(-1);
            verlof_datum.MinDate = dt1;

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
                            verlof_medewerkercmbbox.Items.Add(voorenachternaam);
                        }
                    }
                }
            }
        }

        private void verlof_aanvragenBTN_Click(object sender, EventArgs e)
        {
            // Er word op aanvragen gedrukt. Eerst kijken of er een geldige invoer is
            if (verlof_medewerkercmbbox.SelectedIndex == -1 || verlof_txtbox_tijd.Text == "" || verlof_omschrijving_richtxtbx.Text =="")
            {
                MessageBox.Show("Vul alle velden in om de aanvraag te kunnen doen.", "Verlof Aanvragen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var dt = DateTime.Now;
                DateTime dt1 = dt.AddDays(-1);
                if (verlof_datum.Value.Date < dt1)
                {

                    MessageBox.Show("Datum kan niet in het verleden liggen", "Verlof Aanvragen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void verlof_annulerenBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verlof_medewerkercmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            verlof_gegevens.Show();
            verlof_gegevens.Enabled = true;
        }
    }
}
