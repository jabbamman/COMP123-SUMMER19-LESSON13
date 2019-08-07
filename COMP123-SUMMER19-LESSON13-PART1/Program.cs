﻿using COMP123_SUMMER19_LESSON13_PART1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_SUMMER19_LESSON13_PART1
{
    public static class Program
    {
        public static StartForm startForm;
        public static MasterForm masterForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            masterForm = new MasterForm();
            Application.Run(startForm);
        }

       
    }
}
