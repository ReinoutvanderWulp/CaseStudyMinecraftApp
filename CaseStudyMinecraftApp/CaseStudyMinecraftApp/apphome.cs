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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void verwijderenlabel_Click(object sender, EventArgs e)
        {

        }

        private void toevoegenbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Aanmaken
                Form form = new Form();
                Button buttonOK = new Button();
                Button buttonCancel = new Button();
                Label textlabel = new Label();
                Label labelid = new Label();
                TextBox textBoxid = new TextBox();
                Label labelcategorieNaam = new Label();
                TextBox textBoxcategorieNaam = new TextBox();
                Label labelnaam = new Label();
                TextBox textboxnaam = new TextBox();
                Label labeltype = new Label();
                TextBox textboxtype = new TextBox();
                Label labelbiotoop = new Label();
                TextBox textboxbiotoop = new TextBox();
                Label labelexplosieweerstand = new Label();
                TextBox textboxexplosieweerstand = new TextBox();
                Label labellichtgevend = new Label();
                TextBox textboxlichtgevend = new TextBox();
                Label labeldoorzichtig = new Label();
                TextBox textboxdoorzichtig = new TextBox();
                Label labelstapelbaar = new Label();
                TextBox textboxstapelbaar = new TextBox();
                Label labelbrandbaar = new Label();
                TextBox textboxbrandbaar = new TextBox();
                Label labelzwaartekracht = new Label();
                TextBox textboxzwaartekracht = new TextBox();
                Label labelomschrijving = new Label();
                TextBox textboxomschrijving = new TextBox();
                //Tekst labels
                textlabel.Text = "Geef de waarden in:";
                labelid.Text = "ID:";
                labelcategorieNaam.Text = "CategorieNaam:";
                labelnaam.Text = "Naam:";
                labeltype.Text = "Type:";
                labelbiotoop.Text = "Biotoop:";
                labelexplosieweerstand.Text = "Explosieweerstand:";
                labellichtgevend.Text = "Lichtgevend:";
                labeldoorzichtig.Text = "Doorzichtig:";
                labelstapelbaar.Text = "Stapelbaar:";
                labelbrandbaar.Text = "Brandbaar:";
                labelzwaartekracht.Text = "Zwaartekracht:";
                labelomschrijving.Text = "Omschrijving:";
                //Configureren knoppen
                buttonOK.DialogResult = DialogResult.OK;
                buttonCancel.DialogResult = DialogResult.Cancel;
                buttonOK.Text = "OK";
                buttonCancel.Text = "Cancel";
                //Configureren form
                form.AcceptButton = buttonOK;
                form.CancelButton = buttonCancel;
                form.Text = "Confirmation";
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Controls.AddRange(new Control[] {textlabel, labelid, textBoxid, });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Aanmaken
                Form form = new Form();
                Button buttonOK = new Button();
                Button buttonCancel = new Button();
                Label textlabel = new Label();
                Label labelid = new Label();
                TextBox textBoxid = new TextBox();
                //Tekst Labels
                textlabel.Text = "Geef in welke waarde verwijderd word:";
                labelid.Text = "ID:";
                //Configureren knoppen
                buttonOK.DialogResult = DialogResult.OK;
                buttonCancel.DialogResult = DialogResult.Cancel;
                buttonOK.Text = "OK";
                buttonCancel.Text = "Cancel";
                //Configureren form
                form.AcceptButton = buttonOK;
                form.CancelButton = buttonCancel;
                form.Text = "Confirmation";
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
