﻿namespace CapaPresentacion
{
    partial class frmAccionesEmpleado
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
            this.btnRecogida = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecogida
            // 
            this.btnRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecogida.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecogida.Location = new System.Drawing.Point(118, 97);
            this.btnRecogida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecogida.Name = "btnRecogida";
            this.btnRecogida.Size = new System.Drawing.Size(203, 121);
            this.btnRecogida.TabIndex = 0;
            this.btnRecogida.Text = "Recogida";
            this.btnRecogida.UseVisualStyleBackColor = true;
            this.btnRecogida.Click += new System.EventHandler(this.btnRecogida_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistro.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(388, 97);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(203, 121);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVenta.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(118, 265);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(203, 121);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDevolucion.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.Location = new System.Drawing.Point(388, 265);
            this.btnDevolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(203, 121);
            this.btnDevolucion.TabIndex = 3;
            this.btnDevolucion.Text = "Devolución";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(9, 10);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(130, 56);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAccionesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 394);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnRecogida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAccionesEmpleado";
            this.Text = "CuaShop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccionesEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecogida;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnVolver;
    }
}

