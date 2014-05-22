using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KRISA.Modelo.ModuloCamara;

namespace KRISA.Presentacion
{
    public partial class UCSeleccionarCamara : UserControl
    {
        public Camara CamaraSeleccionada { set; get; } 
        
        public UCSeleccionarCamara()
        {
            InitializeComponent();
        }

    }
}
