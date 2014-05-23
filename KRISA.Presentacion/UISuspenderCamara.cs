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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSuspender_Click(object sender, EventArgs e)
        {
            GestorCamara camara = new GestorCamara();
            //camara.Suspender();
        }
    }
}
