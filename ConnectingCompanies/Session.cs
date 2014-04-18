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

        bool sessionTimeOut;
        public bool SessionTimeOut
        {
            get { return sessionTimeOut; }
        }

        private int min;
        public int Min
        {
            get { return min; }
        }
        private int sec;
        public int Sec
        {
            get { return sec; }
        }

        public Session(User cu)
        {
            this.currentUser = cu;
            sessionTimeOut = false;
            ticks = 0;
            timer = new Timer();
            timer.Interval = 1000; //1mp egy tick
            timer.Tick += timer_Tick;

            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (ticks == 1800)
            {
                timer.Stop();
                sessionTimeOut = true;
            }
            else
            {
                ticks++;
                this.min = ticks / 60;
                this.sec = ticks - min * 60;
                this.min = 29 - min;
                this.sec = (sec == 0) ? 0 : 60 - sec;
            }
        }
        public void ResetSession()
        {
            this.timer.Stop();
            ticks = 0;
            this.timer.Start();
        }

    }
}
