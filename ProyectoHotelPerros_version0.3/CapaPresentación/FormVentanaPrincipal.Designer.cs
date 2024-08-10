namespace CapaPresentación
{
    partial class FormVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.buttonHotel = new System.Windows.Forms.Button();
            this.buttonGuarderìa = new System.Windows.Forms.Button();
            this.buttonReservar = new System.Windows.Forms.Button();
            this.buttonRegistros = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 0;
            // 
            // buttonHotel
            // 
            this.buttonHotel.Location = new System.Drawing.Point(139, 76);
            this.buttonHotel.Name = "buttonHotel";
            this.buttonHotel.Size = new System.Drawing.Size(72, 89);
            this.buttonHotel.TabIndex = 1;
            this.buttonHotel.Text = "Hotel";
            this.buttonHotel.UseVisualStyleBackColor = true;
            this.buttonHotel.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGuarderìa
            // 
            this.buttonGuarderìa.Location = new System.Drawing.Point(244, 76);
            this.buttonGuarderìa.Name = "buttonGuarderìa";
            this.buttonGuarderìa.Size = new System.Drawing.Size(72, 89);
            this.buttonGuarderìa.TabIndex = 2;
            this.buttonGuarderìa.Text = "Guardería";
            this.buttonGuarderìa.UseVisualStyleBackColor = true;
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(345, 76);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Size = new System.Drawing.Size(72, 89);
            this.buttonReservar.TabIndex = 3;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.UseVisualStyleBackColor = true;
            // 
            // buttonRegistros
            // 
            this.buttonRegistros.Location = new System.Drawing.Point(449, 76);
            this.buttonRegistros.Name = "buttonRegistros";
            this.buttonRegistros.Size = new System.Drawing.Size(72, 89);
            this.buttonRegistros.TabIndex = 4;
            this.buttonRegistros.Text = "Registros de clientes";
            this.buttonRegistros.UseVisualStyleBackColor = true;
            this.buttonRegistros.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(139, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 89);
            this.button5.TabIndex = 5;
            this.button5.Text = "Otros Servicios";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(244, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 89);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 434);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonRegistros);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.buttonGuarderìa);
            this.Controls.Add(this.buttonHotel);
            this.Controls.Add(this.label);
            this.Name = "FormVentanaPrincipal";
            this.Text = "HOTEL DE MASCOTAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonHotel;
        private System.Windows.Forms.Button buttonGuarderìa;
        private System.Windows.Forms.Button buttonReservar;
        private System.Windows.Forms.Button buttonRegistros;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

