﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KRISA.Presentacion
{
    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {   // COMENTARIO PARA PROBAR COMMIT
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UIAgregarCamara());
            Application.Run(new UISuspenderCamara());
        }
    }
}
