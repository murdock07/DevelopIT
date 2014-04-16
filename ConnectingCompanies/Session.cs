using Adatkezelő;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies
{
    public class Session
    {
        Timer timer;
        public Timer Timer { get { return timer; } }
        User currentUser;
        public User CurrentUser { get { return currentUser; } }
        int ticks;

        public Session(User cu)
        {
            this.currentUser = cu;
            ticks = 0;
            timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += timer_Tick;

            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (ticks < timer.Interval * 30)
            {
                timer.Stop();
                //TODO: kiléptetés
                //jelzés hogy lejártunk
                //kiléptetés indítása
            }
            else
            {
                ticks++;
            }
        }
    }
}
