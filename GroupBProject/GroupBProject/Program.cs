﻿using GroupBProject.Forms;
using System;
using System.Windows.Forms;

namespace GroupBProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new MainLogin());
        }
    }
}