using ConnectingCompanies.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies
{
    public partial class UserInterfaceForm : Form
    {
        public UserInterfaceForm()
        {
            InitializeComponent();
        }

        private void buttonCreateNewEvent_Click(object sender, EventArgs e)
        {
            AddEventDialogForm AEDF = new AddEventDialogForm();
            AEDF.Show();
        }

        private void buttonModifyEvent_Click(object sender, EventArgs e)
        {
            ModifyEventDialogForm MEDF = new ModifyEventDialogForm();
            MEDF.Show();
        }

        private void buttonNewMail_Click(object sender, EventArgs e)
        {
            NewMailForm NMF = new NewMailForm();
            NMF.Show();
        }

        private void buttonNewOffer_Click(object sender, EventArgs e)
        {
            NewOfferForm NOF = new NewOfferForm();
            //NOF.Show();
        }
    }
}
