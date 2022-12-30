using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gelişmiş_Anket_Sistemi
{
    static class Program
    {
        /// <summary>
        ///
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
