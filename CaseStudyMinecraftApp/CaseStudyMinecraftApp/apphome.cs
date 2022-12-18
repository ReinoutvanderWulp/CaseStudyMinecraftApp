using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace CaseStudyMinecraftApp
{
    public partial class apphome : Form
    {
        public apphome()
        {
            InitializeComponent();
        }

        private void titletextlable_Click(object sender, EventArgs e)
        {

        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string text = listbox.GetItemText(listbox.SelectedItem);
                DialogResult result = MessageBox.Show("U heeft gekozen voor de categorie: " + text, "bevestigingsbericht", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) {
                    string connectionstring = "Data Source=database.db";
                    SQLiteConnection connection = new SQLiteConnection(connectionstring);
                    connection.Open();
                    string sql = "SELECT * FROM Categorie WHERE categorieNaam = @text";
                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    command.Parameters.AddWithValue("@text", text);
                    SQLiteDataReader reader = command.ExecuteReader();
                    string dataresult = "";
                    if (reader.HasRows)
                    {
                        while (reader.Read()) {
                            dataresult += "\rid: " + reader["id"];
                            dataresult += "\rCategorienaam: " + reader["categorieNaam"];
                            dataresult += "\rNaam: " + reader["naam"];
                            dataresult += "\rType: " + reader["type"];
                            dataresult += "\rBiotoop: " + reader["biotoop"];
                            dataresult += "\rExplosieweerstand: " + reader["explosieWeerstand"];
                            dataresult += "\rLichtgevend: " + reader["lichtgevend"];
                            dataresult += "\rDoorzichtig: " + reader["doorzichtig"];
                            dataresult += "\rStapelbaar: " + reader["stapelbaar"];
                            dataresult += "\rBrandbaar: " + reader["brandbaar"];
                            dataresult += "\rZwaartekracht: " + reader["zwaartekracht"];
                            dataresult += "\rOmschrijving: " + reader["omschrijving"];
                        }
                    }
                    MessageBox.Show(dataresult);
                    connection.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Weet u zeker dat u de app wil verlaten?", "bevestigingsbericht", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) {
                Application.Exit();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void verwijderenlabel_Click(object sender, EventArgs e)
        {

        }

        private void toevoegenbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void idlabel_Click(object sender, EventArgs e)
        {

        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void voegtoebutton_Click(object sender, EventArgs e)
        {
            try {
                string id = idlabel.Text;
                string categorienaam = categorienaamlabel.Text;
                string naam = naamlabel.Text;
                string type = typelabel.Text;
                string biotoop = biotooplabel.Text;
                string omschrijving = omschrijvinglabel.Text;
                string connectionstring = "Data Source: database.db;Provider=System.Data.SQLite";
                database db = new database(connectionstring);
                dynamic command = db.Single("INSERT INTO Categorie VALUES(@id, @categorienaam, @naam, @type, @biotoop, @omschrijving)");
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@categorienaam", categorienaam);
                command.Parameters.AddWithValue("@naam", naam);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@biotoop", biotoop);
                command.Parameters.AddWithValue("@omschrijving", omschrijving);
                MessageBox.Show("De waarden werden succesvol toegevoegd", "Bevestigingsbericht", MessageBoxButtons.OKCancel);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
