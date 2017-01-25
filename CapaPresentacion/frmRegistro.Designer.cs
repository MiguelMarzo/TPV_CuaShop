namespace CapaPresentacion
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.txtNumeroRecogida = new System.Windows.Forms.TextBox();
            this.lblNumeroRecogida = new System.Windows.Forms.Label();
            this.txtTallaPesoLitros = new System.Windows.Forms.TextBox();
            this.lblTallaPesoLitros = new System.Windows.Forms.Label();
            this.txtFechaCaducidad = new System.Windows.Forms.TextBox();
            this.lblFechaCaducidad = new System.Windows.Forms.Label();
            this.cmbNumeroEmpleado = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(289, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(627, 43);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO DE UN NUEVO ARTICULO";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(966, 72);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(88, 29);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(966, 24);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(167, 29);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Nº Empleado:";
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticulo.Location = new System.Drawing.Point(54, 196);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(228, 27);
            this.lblCodArticulo.TabIndex = 3;
            this.lblCodArticulo.Text = "Código de artículo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(54, 282);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(155, 27);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:\r\n";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodArticulo.Location = new System.Drawing.Point(329, 201);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(183, 22);
            this.txtCodArticulo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Location = new System.Drawing.Point(329, 287);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(280, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 100);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(54, 436);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(121, 27);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(329, 436);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(69, 24);
            this.cmbCantidad.TabIndex = 8;
            // 
            // txtNumeroRecogida
            // 
            this.txtNumeroRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroRecogida.Location = new System.Drawing.Point(935, 196);
            this.txtNumeroRecogida.Name = "txtNumeroRecogida";
            this.txtNumeroRecogida.Size = new System.Drawing.Size(183, 22);
            this.txtNumeroRecogida.TabIndex = 10;
            // 
            // lblNumeroRecogida
            // 
            this.lblNumeroRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroRecogida.AutoSize = true;
            this.lblNumeroRecogida.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRecogida.Location = new System.Drawing.Point(660, 191);
            this.lblNumeroRecogida.Name = "lblNumeroRecogida";
            this.lblNumeroRecogida.Size = new System.Drawing.Size(256, 27);
            this.lblNumeroRecogida.TabIndex = 9;
            this.lblNumeroRecogida.Text = "Número de Recogida:";
            // 
            // txtTallaPesoLitros
            // 
            this.txtTallaPesoLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTallaPesoLitros.Location = new System.Drawing.Point(935, 287);
            this.txtTallaPesoLitros.Name = "txtTallaPesoLitros";
            this.txtTallaPesoLitros.Size = new System.Drawing.Size(183, 22);
            this.txtTallaPesoLitros.TabIndex = 12;
            // 
            // lblTallaPesoLitros
            // 
            this.lblTallaPesoLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTallaPesoLitros.AutoSize = true;
            this.lblTallaPesoLitros.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallaPesoLitros.Location = new System.Drawing.Point(660, 282);
            this.lblTallaPesoLitros.Name = "lblTallaPesoLitros";
            this.lblTallaPesoLitros.Size = new System.Drawing.Size(222, 27);
            this.lblTallaPesoLitros.TabIndex = 11;
            this.lblTallaPesoLitros.Text = "Talla, peso o litros:";
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaCaducidad.Location = new System.Drawing.Point(935, 436);
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.Size = new System.Drawing.Size(183, 22);
            this.txtFechaCaducidad.TabIndex = 14;
            // 
            // lblFechaCaducidad
            // 
            this.lblFechaCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaCaducidad.AutoSize = true;
            this.lblFechaCaducidad.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaducidad.Location = new System.Drawing.Point(660, 431);
            this.lblFechaCaducidad.Name = "lblFechaCaducidad";
            this.lblFechaCaducidad.Size = new System.Drawing.Size(245, 27);
            this.lblFechaCaducidad.TabIndex = 13;
            this.lblFechaCaducidad.Text = "Fecha de caducidad:";
            // 
            // cmbNumeroEmpleado
            // 
            this.cmbNumeroEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNumeroEmpleado.FormattingEnabled = true;
            this.cmbNumeroEmpleado.Location = new System.Drawing.Point(1157, 25);
            this.cmbNumeroEmpleado.Name = "cmbNumeroEmpleado";
            this.cmbNumeroEmpleado.Size = new System.Drawing.Size(106, 24);
            this.cmbNumeroEmpleado.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(59, 24);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(143, 86);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnRecogida_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 646);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cmbNumeroEmpleado);
            this.Controls.Add(this.txtFechaCaducidad);
            this.Controls.Add(this.lblFechaCaducidad);
            this.Controls.Add(this.txtTallaPesoLitros);
            this.Controls.Add(this.lblTallaPesoLitros);
            this.Controls.Add(this.txtNumeroRecogida);
            this.Controls.Add(this.lblNumeroRecogida);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodArticulo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodArticulo);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.TextBox txtNumeroRecogida;
        private System.Windows.Forms.Label lblNumeroRecogida;
        private System.Windows.Forms.TextBox txtTallaPesoLitros;
        private System.Windows.Forms.Label lblTallaPesoLitros;
        private System.Windows.Forms.TextBox txtFechaCaducidad;
        private System.Windows.Forms.Label lblFechaCaducidad;
        private System.Windows.Forms.ComboBox cmbNumeroEmpleado;
        private System.Windows.Forms.Button btnVolver;
    }
}