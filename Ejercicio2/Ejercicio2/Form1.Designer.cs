namespace Ejercicio2
{
    partial class Form1
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
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblPrimerLugar = new System.Windows.Forms.Label();
            this.lblSegundoLugar = new System.Windows.Forms.Label();
            this.lblTercerLugar = new System.Windows.Forms.Label();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(25, 38);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 0;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblPrimerLugar
            // 
            this.lblPrimerLugar.AutoSize = true;
            this.lblPrimerLugar.Location = new System.Drawing.Point(24, 75);
            this.lblPrimerLugar.Name = "lblPrimerLugar";
            this.lblPrimerLugar.Size = new System.Drawing.Size(66, 13);
            this.lblPrimerLugar.TabIndex = 1;
            this.lblPrimerLugar.Text = "Primer Lugar";
            // 
            // lblSegundoLugar
            // 
            this.lblSegundoLugar.AutoSize = true;
            this.lblSegundoLugar.Location = new System.Drawing.Point(23, 117);
            this.lblSegundoLugar.Name = "lblSegundoLugar";
            this.lblSegundoLugar.Size = new System.Drawing.Size(80, 13);
            this.lblSegundoLugar.TabIndex = 2;
            this.lblSegundoLugar.Text = "Segundo Lugar";
            // 
            // lblTercerLugar
            // 
            this.lblTercerLugar.AutoSize = true;
            this.lblTercerLugar.Location = new System.Drawing.Point(22, 158);
            this.lblTercerLugar.Name = "lblTercerLugar";
            this.lblTercerLugar.Size = new System.Drawing.Size(68, 13);
            this.lblTercerLugar.TabIndex = 3;
            this.lblTercerLugar.Text = "Tercer Lugar";
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.Location = new System.Drawing.Point(176, 44);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(169, 34);
            this.btnAgregarNota.TabIndex = 4;
            this.btnAgregarNota.Text = "Agregar Nota";
            this.btnAgregarNota.UseVisualStyleBackColor = true;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // btnMostrarResultados
            // 
            this.btnMostrarResultados.Location = new System.Drawing.Point(185, 105);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(148, 37);
            this.btnMostrarResultados.TabIndex = 5;
            this.btnMostrarResultados.Text = "Mostrar Resultados";
            this.btnMostrarResultados.UseVisualStyleBackColor = true;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(370, 58);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 350);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btnMostrarResultados);
            this.Controls.Add(this.btnAgregarNota);
            this.Controls.Add(this.lblTercerLugar);
            this.Controls.Add(this.lblSegundoLugar);
            this.Controls.Add(this.lblPrimerLugar);
            this.Controls.Add(this.lblPromedio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblPrimerLugar;
        private System.Windows.Forms.Label lblSegundoLugar;
        private System.Windows.Forms.Label lblTercerLugar;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.Button btnMostrarResultados;
        private System.Windows.Forms.TextBox txtNota;
    }
}

