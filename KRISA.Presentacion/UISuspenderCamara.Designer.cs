namespace KRISA.Presentacion
{
    partial class UISuspenderCamara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdSuspender = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.ucSeleccionarCamara1 = new KRISA.Presentacion.UCSeleccionarCamara();
            this.SuspendLayout();
            // 
            // cmdSuspender
            // 
            this.cmdSuspender.Location = new System.Drawing.Point(212, 81);
            this.cmdSuspender.Name = "cmdSuspender";
            this.cmdSuspender.Size = new System.Drawing.Size(75, 23);
            this.cmdSuspender.TabIndex = 1;
            this.cmdSuspender.Text = "Suspender";
            this.cmdSuspender.UseVisualStyleBackColor = true;
            this.cmdSuspender.Click += new System.EventHandler(this.cmdSuspender_Click_1);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(293, 81);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // ucSeleccionarCamara1
            // 
            this.ucSeleccionarCamara1.CamaraSeleccionada = null;
            this.ucSeleccionarCamara1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSeleccionarCamara1.Location = new System.Drawing.Point(12, 12);
            this.ucSeleccionarCamara1.Name = "ucSeleccionarCamara1";
            this.ucSeleccionarCamara1.Size = new System.Drawing.Size(356, 38);
            this.ucSeleccionarCamara1.TabIndex = 0;
            //this.ucSeleccionarCamara1.Load += new System.EventHandler(this.ucSeleccionarCamara1_Load);
            // 
            // UISuspenderCamara
            // 
            this.ClientSize = new System.Drawing.Size(393, 116);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSuspender);
            this.Controls.Add(this.ucSeleccionarCamara1);
            this.Name = "UISuspenderCamara";
            this.ResumeLayout(false);

        }

        #endregion

        private UCSeleccionarCamara ucSeleccionarCamara1;
        private System.Windows.Forms.Button cmdSuspender;
        private System.Windows.Forms.Button cmdCancelar;
    }
}