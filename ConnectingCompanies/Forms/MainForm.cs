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
    public partial class MainForm : Form
    {
        /// <summary>
        /// 3 belépési azonosító eset a kipróbáláshoz:
        /// - admin
        /// - random név
        /// - vendég gomb megnyomása
        /// </summary>
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //User név alapján kiszedjük db-ből a user-t és azt adjuk át
            string user = textBoxUserName.Text;
            SetStartupScreenByUserType(user);
        }

        private void buttonGuestLogin_Click(object sender, EventArgs e)
        {
            //Itt mi csinálunk vendég user-t és azt kapja meg
            SetStartupScreenByUserType("guest");
        }

        //Normális esetben user-t fogad
        private void SetStartupScreenByUserType(string user)
        {
            UserInterfaceForm UIF = new UserInterfaceForm();

            var c = UIF.Controls.Find("tabControlUserInterface", true).ToList();
            TabControl tc = (TabControl)c[0];
            Console.WriteLine(tc);
            List<TabPage> tabPages = new List<TabPage>();
            foreach (TabPage page in tc.TabPages)
            {
                tabPages.Add(page);
            }
            Console.WriteLine(tabPages);

            //user type alapján jogosultság belövés
            if (user.Equals("admin"))
            {
                tc.TabPages.Remove(tabPages[0]);    //profil
                tc.TabPages.Remove(tabPages[1]);    //csoport
                tc.TabPages.Remove(tabPages[2]);    //naptár
                //tc.TabPages.Remove(tabPages[3]);  //kereső
                //tc.TabPages.Remove(tabPages[4]);    //admin
            }
            else if (user.Equals("guest"))
            {
                tc.TabPages.Remove(tabPages[0]);    //profil
                tc.TabPages.Remove(tabPages[1]);    //csoport
                tc.TabPages.Remove(tabPages[2]);    //naptár
                //tc.TabPages.Remove(tabPages[3]);  //kereső
                tc.TabPages.Remove(tabPages[4]);    //admin
            }
            else
            {
                //tc.TabPages.Remove(tabPages[0]);    //profil
                //tc.TabPages.Remove(tabPages[1]);    //csoport
                //tc.TabPages.Remove(tabPages[2]);    //naptár
                //tc.TabPages.Remove(tabPages[3]);  //kereső
                tc.TabPages.Remove(tabPages[4]);    //admin
            }
            UIF.Show();
        }
    }
}
