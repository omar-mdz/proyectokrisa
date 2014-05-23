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
    public partial class UIAgregarCamara : Form
    {
        GestorCamara gestorCamara;
        public UIAgregarCamara()
        {
            InitializeComponent();
            gestorCamara = new GestorCamara();
        }

        public void Agregar()
        {
            // Crear un objecto camara
            Camara camara = new Camara();
            camara.Nombre = txtNombre.Text;
            camara.Dispositivo = comboDispositivo.Text;

            // Llamar al gestor de camara para agregar esa camara
           
            gestorCamara.Agregar(camara);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerCamaras()
        {
            comboDispositivo.DataSource = gestorCamara.ObtenerCamaras();
        }
       

    }
}
