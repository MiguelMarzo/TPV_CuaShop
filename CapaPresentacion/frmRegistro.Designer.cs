﻿namespace CapaPresentacion
{
    partial class frmRegistro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.txtNumeroRecogida = new System.Windows.Forms.TextBox();
            this.lblNumeroRecogida = new System.Windows.Forms.Label();
            this.txtTallaPesoLitros = new System.Windows.Forms.TextBox();
            this.lblTallaPesoLitros = new System.Windows.Forms.Label();
            this.cmbNumeroEmpleado = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtFechaCaducidad = new System.Windows.Forms.TextBox();
            this.lblFechaCaducidad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(250, 31);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(517, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO DE UN NUEVO ARTICULO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(832, 68);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 23);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(772, 31);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(134, 23);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Nº Empleado:";
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticulo.Location = new System.Drawing.Point(82, 149);
            this.lblCodArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(183, 21);
            this.lblCodArticulo.TabIndex = 3;
            this.lblCodArticulo.Text = "Código de artículo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(137, 242);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(124, 21);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:\r\n";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodArticulo.Location = new System.Drawing.Point(286, 153);
            this.txtCodArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(209, 20);
            this.txtCodArticulo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Location = new System.Drawing.Point(284, 242);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(211, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(284, 368);
            this.cmbCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(53, 21);
            this.cmbCantidad.TabIndex = 8;
            // 
            // txtNumeroRecogida
            // 
            this.txtNumeroRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroRecogida.Location = new System.Drawing.Point(759, 153);
            this.txtNumeroRecogida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroRecogida.Name = "txtNumeroRecogida";
            this.txtNumeroRecogida.Size = new System.Drawing.Size(150, 20);
            this.txtNumeroRecogida.TabIndex = 10;
            // 
            // lblNumeroRecogida
            // 
            this.lblNumeroRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroRecogida.AutoSize = true;
            this.lblNumeroRecogida.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRecogida.Location = new System.Drawing.Point(544, 149);
            this.lblNumeroRecogida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroRecogida.Name = "lblNumeroRecogida";
            this.lblNumeroRecogida.Size = new System.Drawing.Size(203, 21);
            this.lblNumeroRecogida.TabIndex = 9;
            this.lblNumeroRecogida.Text = "Número de Recogida:";
            // 
            // txtTallaPesoLitros
            // 
            this.txtTallaPesoLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTallaPesoLitros.Location = new System.Drawing.Point(759, 262);
            this.txtTallaPesoLitros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTallaPesoLitros.Name = "txtTallaPesoLitros";
            this.txtTallaPesoLitros.Size = new System.Drawing.Size(150, 20);
            this.txtTallaPesoLitros.TabIndex = 12;
            // 
            // lblTallaPesoLitros
            // 
            this.lblTallaPesoLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTallaPesoLitros.AutoSize = true;
            this.lblTallaPesoLitros.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallaPesoLitros.Location = new System.Drawing.Point(569, 258);
            this.lblTallaPesoLitros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTallaPesoLitros.Name = "lblTallaPesoLitros";
            this.lblTallaPesoLitros.Size = new System.Drawing.Size(180, 21);
            this.lblTallaPesoLitros.TabIndex = 11;
            this.lblTallaPesoLitros.Text = "Talla, peso o litros:";
            // 
            // cmbNumeroEmpleado
            // 
            this.cmbNumeroEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNumeroEmpleado.FormattingEnabled = true;
            this.cmbNumeroEmpleado.Location = new System.Drawing.Point(926, 31);
            this.cmbNumeroEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNumeroEmpleado.Name = "cmbNumeroEmpleado";
            this.cmbNumeroEmpleado.Size = new System.Drawing.Size(80, 21);
            this.cmbNumeroEmpleado.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(66, 16);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(137, 61);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnRecogida_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(163, 368);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 21);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaCaducidad.Location = new System.Drawing.Point(759, 372);
            this.txtFechaCaducidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.Size = new System.Drawing.Size(150, 20);
            this.txtFechaCaducidad.TabIndex = 14;
            // 
            // lblFechaCaducidad
            // 
            this.lblFechaCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaCaducidad.AutoSize = true;
            this.lblFechaCaducidad.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaducidad.Location = new System.Drawing.Point(552, 368);
            this.lblFechaCaducidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaCaducidad.Name = "lblFechaCaducidad";
            this.lblFechaCaducidad.Size = new System.Drawing.Size(194, 21);
            this.lblFechaCaducidad.TabIndex = 13;
            this.lblFechaCaducidad.Text = "Fecha de caducidad:";
            this.lblFechaCaducidad.Click += new System.EventHandler(this.lblFechaCaducidad_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(274, 446);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(482, 61);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1015, 524);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFechaCaducidad);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cmbNumeroEmpleado);
            this.Controls.Add(this.txtTallaPesoLitros);
            this.Controls.Add(this.lblFechaCaducidad);
            this.Controls.Add(this.txtNumeroRecogida);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeroRecogida);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.lblTallaPesoLitros);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodArticulo);
            this.Controls.Add(this.txtCodArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.TextBox txtNumeroRecogida;
        private System.Windows.Forms.Label lblNumeroRecogida;
        private System.Windows.Forms.TextBox txtTallaPesoLitros;
        private System.Windows.Forms.Label lblTallaPesoLitros;
        private System.Windows.Forms.ComboBox cmbNumeroEmpleado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtFechaCaducidad;
        private System.Windows.Forms.Label lblFechaCaducidad;
        private System.Windows.Forms.Button btnAceptar;
    }
}