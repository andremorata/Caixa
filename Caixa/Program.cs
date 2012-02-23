﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caixa
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

            Classes.Movimentos.DB = new DB.CaixaDBEntities();
            
            Application.Run(new frmMain());            
        }
    }
}
