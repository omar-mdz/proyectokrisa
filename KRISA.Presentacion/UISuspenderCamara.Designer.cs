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
            this.ucSeleccionarCamara2 = new KRISA.Presentacion.UCSeleccionarCamara();
            this.ucSeleccionarCamara1 = new KRISA.Presentacion.UCSeleccionarCamara();
            this.SuspendLayout();
            // 
            // cmdSuspender
            // 
            this.cmdSuspender.Location = new System.Drawing.Point(151, 56);
            this.cmdSuspender.Name = "cmdSuspender";
            this.cmdSuspender.Size = new System.Drawing.Size(75, 23);
            this.cmdSuspender.TabIndex = 1;
            this.cmdSuspender.Text = "Suspender";
            this.cmdSuspender.UseVisualStyleBackColor = true;
            this.cmdSuspender.Click += new System.EventHandler(this.cmdSuspender_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(232, 56);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ucSeleccionarCamara2
            // 
            this.ucSeleccionarCamara2.CamaraSeleccionada = null;
            this.ucSeleccionarCamara2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSeleccionarCamara2.Location = new System.Drawing.Point(8, 12);
            this.ucSeleccionarCamara2.Name = "ucSeleccionarCamara2";
            this.ucSeleccionarCamara2.Size = new System.Drawing.Size(299, 38);
            this.ucSeleccionarCamara2.TabIndex = 3;
            // 
            // ucSeleccionarCamara1
            // 
            this.ucSeleccionarCamara1.CamaraSeleccionada = null;
            this.ucSeleccionarCamara1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSeleccionarCamara1.Location = new System.Drawing.Point(8, 12);
            this.ucSeleccionarCamara1.Name = "ucSeleccionarCamara1";
            this.ucSeleccionarCamara1.Size = new System.Drawing.Size(299, 38);
            this.ucSeleccionarCamara1.TabIndex = 0;
            // 
            // UISuspenderCamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 88);
            this.Controls.Add(this.ucSeleccionarCamara2);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSuspender);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UISuspenderCamara";
            this.Text = "Suspender Cámara";
            this.ResumeLayout(false);

        }

        #endregion

        private UCSeleccionarCamara ucSeleccionarCamara1;
        private System.Windows.Forms.Button cmdSuspender;
        private System.Windows.Forms.Button cmdCancelar;
        private UCSeleccionarCamara ucSeleccionarCamara2;
    }
}