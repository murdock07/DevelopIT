using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/*Comment by Huszi*/
        /*Comment by Huszi from VS*/
        //Viktor 04.12 15:32
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
