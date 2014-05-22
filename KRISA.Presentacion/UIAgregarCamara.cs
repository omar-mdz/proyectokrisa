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
        public UIAgregarCamara()
        {
            InitializeComponent();
        }

        public void Agregar()
        {
            // Crear un objecto camara
            Camara camara = new Camara();
            camara.Nombre = txtNombre.Text;
            camara.Dispositivo = comboDispositivo.Text;

            // Llamar al gestor de camara para agregar esa camara
            GestorCamara gestorCamara = new GestorCamara();
            gestorCamara.Agregar(camara);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

       

    }
}
