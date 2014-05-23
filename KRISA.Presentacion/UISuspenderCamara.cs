using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KRISA.Modelo.ModuloCamara;

namespace KRISA.Presentacion
{
    public partial class UISuspenderCamara : Form
    {
        public UISuspenderCamara()
        {
            InitializeComponent();
        }

        private void UISuspenderCamara_Load(object sender, EventArgs e)
        {

        }

        private void cmdSuspender_Click_1(object sender, EventArgs e)
        {
            try
            {
                GestorCamara gc = new GestorCamara();
                Camara camaraSuspendida = gc.Buscar(ucSeleccionarCamara1.nombreCamara);
                MessageBox.Show(ucSeleccionarCamara1.nombreCamara);
                //gc.Suspender(camaraSuspendida);
                //MessageBox.Show("Cámara [" + ucSeleccionarCamara1.nombreCamara + "] suspendida.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
