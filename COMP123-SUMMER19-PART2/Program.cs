using COMP123_SUMMER19_PART2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_SUMMER19_PART2
{
    public static class Program
    {
        public static ParentForm parentForm;
        public static MyMDI myMDI;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //parentForm = new ParentForm();
            myMDI = new MyMDI();
            Application.Run(myMDI);
        }
    }
}
