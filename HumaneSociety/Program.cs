﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumaneSociety.CustomerUser;
using HumaneSociety.EmployeeInterface;

namespace HumaneSociety
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeMainMenu());
            Application.Run(new CustomerMainMenu());
        }
    }
}
