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
            this.lblNumeroRecogida = new System.Windows.Forms.Label();
            this.txtTallaPesoLitros = new System.Windows.Forms.TextBox();
            this.lblTallaPesoLitros = new System.Windows.Forms.Label();
            this.cmbNumeroEmpleado = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaCaducidad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblOjo = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.calFechaCaducidad = new System.Windows.Forms.MonthCalendar();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.cmbRecogida = new System.Windows.Forms.ComboBox();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubFamilia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(333, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(627, 43);
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
            this.lblFecha.Location = new System.Drawing.Point(1109, 84);
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
            this.lblEmpleado.Location = new System.Drawing.Point(1029, 38);
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
            this.lblCodArticulo.Location = new System.Drawing.Point(91, 178);
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
            this.lblDescripcion.Location = new System.Drawing.Point(164, 233);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(155, 27);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:\r\n";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodArticulo.Location = new System.Drawing.Point(371, 183);
            this.txtCodArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(283, 22);
            this.txtCodArticulo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Location = new System.Drawing.Point(371, 233);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(280, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 22);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblNumeroRecogida
            // 
            this.lblNumeroRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroRecogida.AutoSize = true;
            this.lblNumeroRecogida.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRecogida.Location = new System.Drawing.Point(725, 183);
            this.lblNumeroRecogida.Name = "lblNumeroRecogida";
            this.lblNumeroRecogida.Size = new System.Drawing.Size(256, 27);
            this.lblNumeroRecogida.TabIndex = 9;
            this.lblNumeroRecogida.Text = "Número de Recogida:";
            // 
            // txtTallaPesoLitros
            // 
            this.txtTallaPesoLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTallaPesoLitros.Location = new System.Drawing.Point(1004, 249);
            this.txtTallaPesoLitros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTallaPesoLitros.Name = "txtTallaPesoLitros";
            this.txtTallaPesoLitros.Size = new System.Drawing.Size(220, 22);
            this.txtTallaPesoLitros.TabIndex = 12;
            // 
            // lblTallaPesoLitros
            // 
            this.lblTallaPesoLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTallaPesoLitros.AutoSize = true;
            this.lblTallaPesoLitros.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallaPesoLitros.Location = new System.Drawing.Point(751, 244);
            this.lblTallaPesoLitros.Name = "lblTallaPesoLitros";
            this.lblTallaPesoLitros.Size = new System.Drawing.Size(222, 27);
            this.lblTallaPesoLitros.TabIndex = 11;
            this.lblTallaPesoLitros.Text = "Talla, peso o litros:";
            // 
            // cmbNumeroEmpleado
            // 
            this.cmbNumeroEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNumeroEmpleado.FormattingEnabled = true;
            this.cmbNumeroEmpleado.Location = new System.Drawing.Point(1235, 38);
            this.cmbNumeroEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNumeroEmpleado.Name = "cmbNumeroEmpleado";
            this.cmbNumeroEmpleado.Size = new System.Drawing.Size(105, 24);
            this.cmbNumeroEmpleado.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(88, 20);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(183, 75);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(200, 388);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(121, 27);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFechaCaducidad
            // 
            this.lblFechaCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaCaducidad.AutoSize = true;
            this.lblFechaCaducidad.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaducidad.Location = new System.Drawing.Point(747, 350);
            this.lblFechaCaducidad.Name = "lblFechaCaducidad";
            this.lblFechaCaducidad.Size = new System.Drawing.Size(245, 27);
            this.lblFechaCaducidad.TabIndex = 13;
            this.lblFechaCaducidad.Text = "Fecha de caducidad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(365, 549);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(643, 75);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(374, 392);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(104, 22);
            this.txtCantidad.TabIndex = 18;
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPedido.Location = new System.Drawing.Point(371, 450);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(104, 22);
            this.txtPedido.TabIndex = 20;
            // 
            // lblPedido
            // 
            this.lblPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(221, 446);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(98, 27);
            this.lblPedido.TabIndex = 19;
            this.lblPedido.Text = "Pedido:";
            // 
            // lblOjo
            // 
            this.lblOjo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOjo.AutoSize = true;
            this.lblOjo.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOjo.Location = new System.Drawing.Point(223, 476);
            this.lblOjo.Name = "lblOjo";
            this.lblOjo.Size = new System.Drawing.Size(85, 17);
            this.lblOjo.TabIndex = 21;
            this.lblOjo.Text = "(Opcional)";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Location = new System.Drawing.Point(657, 450);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(199, 22);
            this.txtPrecio.TabIndex = 23;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(560, 446);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(91, 27);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio:";
            // 
            // calFechaCaducidad
            // 
            this.calFechaCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calFechaCaducidad.Location = new System.Drawing.Point(1004, 313);
            this.calFechaCaducidad.Name = "calFechaCaducidad";
            this.calFechaCaducidad.TabIndex = 24;
            // 
            // chkFecha
            // 
            this.chkFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(752, 326);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(144, 21);
            this.chkFecha.TabIndex = 25;
            this.chkFecha.Text = "Activar/Descativar";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // cmbRecogida
            // 
            this.cmbRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRecogida.FormattingEnabled = true;
            this.cmbRecogida.Location = new System.Drawing.Point(1004, 188);
            this.cmbRecogida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRecogida.Name = "cmbRecogida";
            this.cmbRecogida.Size = new System.Drawing.Size(129, 24);
            this.cmbRecogida.TabIndex = 26;
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(374, 289);
            this.cmbFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(129, 24);
            this.cmbFamilia.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Familia:";
            // 
            // cmbSubFamilia
            // 
            this.cmbSubFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSubFamilia.FormattingEnabled = true;
            this.cmbSubFamilia.Location = new System.Drawing.Point(374, 334);
            this.cmbSubFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubFamilia.Name = "cmbSubFamilia";
            this.cmbSubFamilia.Size = new System.Drawing.Size(129, 24);
            this.cmbSubFamilia.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "SubFamilia:";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1353, 645);
            this.Controls.Add(this.cmbSubFamilia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRecogida);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.calFechaCaducidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblOjo);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cmbNumeroEmpleado);
            this.Controls.Add(this.txtTallaPesoLitros);
            this.Controls.Add(this.lblFechaCaducidad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeroRecogida);
            this.Controls.Add(this.lblTallaPesoLitros);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodArticulo);
            this.Controls.Add(this.txtCodArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblNumeroRecogida;
        private System.Windows.Forms.TextBox txtTallaPesoLitros;
        private System.Windows.Forms.Label lblTallaPesoLitros;
        private System.Windows.Forms.ComboBox cmbNumeroEmpleado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaCaducidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblOjo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.MonthCalendar calFechaCaducidad;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.ComboBox cmbRecogida;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubFamilia;
        private System.Windows.Forms.Label label2;
    }
}