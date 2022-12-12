using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                MessageBox.Show("U heeft gekozen voor de categorie: " + text + ". \r" + "Klik op 'OK' om de gegevens in de door u geselecteerde categorie te raadplegen!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Weet u zeker dat u de app wil verlaten?");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
