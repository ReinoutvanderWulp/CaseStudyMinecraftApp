using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                DialogResult result = MessageBox.Show("U heeft gekozen voor de categorie: " + text, "confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) {
                    string connection = "Data Source=database.db";
                    database db = new database(connection);
                    dynamic query = db.Single("select * from Categorie where categorieNaam = '" + text + "'");
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
                DialogResult result = MessageBox.Show("Weet u zeker dat u de app wil verlaten?", "confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) {
                Application.Exit();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
