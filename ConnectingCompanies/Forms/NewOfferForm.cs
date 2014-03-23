using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies.Forms
{
    public partial class NewOfferForm : Form
    {
        public NewOfferForm()
        {
            InitializeComponent();
        }

        private void buttonSendOffer_Click(object sender, EventArgs e)
        {
            //adatok csomagolása
            //visszajelzés
            MessageBox.Show("Elküldve");
            //bezárás
            this.Close();
        }

        private void buttonCloseOffer_Click(object sender, EventArgs e)
        {
            //Figyelmeztetés
            MessageBox.Show("Biztosan bezárja?", "Figyelmeztetés", MessageBoxButtons.YesNo);
            //Bezárás
            this.Close();
        }
    }
}
