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

        private void UCSeleccionarCamara_Load(object sender, EventArgs e)
        {
            ObtenerCamaras();
        }

        private void ObtenerCamaras()
        {
            GestorCamara gestorCamara = new GestorCamara();
            String[] nombreCamaras = gestorCamara.ObtenerCamaras();
            if (nombreCamaras != null)
            {
                comboCamaras.Items.Clear();
                foreach (String device in nombreCamaras)
                {
                    comboCamaras.Items.Add(device);
                }
            }

        }

    }
}
