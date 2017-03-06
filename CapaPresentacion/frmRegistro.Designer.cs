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
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNumeroRecogida = new System.Windows.Forms.Label();
            this.txtTallaPesoLitros = new System.Windows.Forms.TextBox();
            this.lblTallaPesoLitros = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblOjo = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbRecogida = new System.Windows.Forms.ComboBox();
            this.cmbFamiliaStock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubFamiliaStock = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstanteria = new System.Windows.Forms.TextBox();
            this.lblEstanteria = new System.Windows.Forms.Label();
            this.lblEstante = new System.Windows.Forms.Label();
            this.txtEstante = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSubFamilia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.grpAñadirStock = new System.Windows.Forms.GroupBox();
            this.btnAñadirStock = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpAñadirStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(342, 53);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(411, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO DE UN ARTICULO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(815, 53);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 23);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticulo.Location = new System.Drawing.Point(27, 34);
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
            this.lblDescripcion.Location = new System.Drawing.Point(325, 69);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(124, 21);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:\r\n";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodArticulo.Location = new System.Drawing.Point(233, 34);
            this.txtCodArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(213, 20);
            this.txtCodArticulo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Location = new System.Drawing.Point(288, 107);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(211, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblNumeroRecogida
            // 
            this.lblNumeroRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroRecogida.AutoSize = true;
            this.lblNumeroRecogida.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRecogida.Location = new System.Drawing.Point(29, 222);
            this.lblNumeroRecogida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroRecogida.Name = "lblNumeroRecogida";
            this.lblNumeroRecogida.Size = new System.Drawing.Size(203, 21);
            this.lblNumeroRecogida.TabIndex = 9;
            this.lblNumeroRecogida.Text = "Número de Recogida:";
            // 
            // txtTallaPesoLitros
            // 
            this.txtTallaPesoLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTallaPesoLitros.Location = new System.Drawing.Point(236, 254);
            this.txtTallaPesoLitros.Margin = new System.Windows.Forms.Padding(2);
            this.txtTallaPesoLitros.Name = "txtTallaPesoLitros";
            this.txtTallaPesoLitros.Size = new System.Drawing.Size(193, 20);
            this.txtTallaPesoLitros.TabIndex = 12;
            // 
            // lblTallaPesoLitros
            // 
            this.lblTallaPesoLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTallaPesoLitros.AutoSize = true;
            this.lblTallaPesoLitros.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallaPesoLitros.Location = new System.Drawing.Point(52, 252);
            this.lblTallaPesoLitros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTallaPesoLitros.Name = "lblTallaPesoLitros";
            this.lblTallaPesoLitros.Size = new System.Drawing.Size(180, 21);
            this.lblTallaPesoLitros.TabIndex = 11;
            this.lblTallaPesoLitros.Text = "Talla, peso o litros:";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(100, 38);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(137, 61);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(29, 187);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 21);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(17, 359);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(482, 61);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(134, 189);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(79, 20);
            this.txtCantidad.TabIndex = 18;
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPedido.Location = new System.Drawing.Point(134, 143);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(79, 20);
            this.txtPedido.TabIndex = 20;
            // 
            // lblPedido
            // 
            this.lblPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(46, 143);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(79, 21);
            this.lblPedido.TabIndex = 19;
            this.lblPedido.Text = "Pedido:";
            // 
            // lblOjo
            // 
            this.lblOjo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOjo.AutoSize = true;
            this.lblOjo.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOjo.Location = new System.Drawing.Point(47, 164);
            this.lblOjo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOjo.Name = "lblOjo";
            this.lblOjo.Size = new System.Drawing.Size(67, 14);
            this.lblOjo.TabIndex = 21;
            this.lblOjo.Text = "(Opcional)";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Location = new System.Drawing.Point(137, 320);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 20);
            this.txtPrecio.TabIndex = 23;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(51, 319);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 21);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio:";
            // 
            // cmbRecogida
            // 
            this.cmbRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRecogida.FormattingEnabled = true;
            this.cmbRecogida.Location = new System.Drawing.Point(236, 224);
            this.cmbRecogida.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRecogida.Name = "cmbRecogida";
            this.cmbRecogida.Size = new System.Drawing.Size(125, 21);
            this.cmbRecogida.TabIndex = 26;
            // 
            // cmbFamiliaStock
            // 
            this.cmbFamiliaStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFamiliaStock.FormattingEnabled = true;
            this.cmbFamiliaStock.Location = new System.Drawing.Point(241, 19);
            this.cmbFamiliaStock.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFamiliaStock.Name = "cmbFamiliaStock";
            this.cmbFamiliaStock.Size = new System.Drawing.Size(98, 21);
            this.cmbFamiliaStock.TabIndex = 28;
            this.cmbFamiliaStock.SelectedIndexChanged += new System.EventHandler(this.cmbFamiliaStock_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Familia:";
            // 
            // cmbSubFamiliaStock
            // 
            this.cmbSubFamiliaStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSubFamiliaStock.FormattingEnabled = true;
            this.cmbSubFamiliaStock.Location = new System.Drawing.Point(240, 60);
            this.cmbSubFamiliaStock.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSubFamiliaStock.Name = "cmbSubFamiliaStock";
            this.cmbSubFamiliaStock.Size = new System.Drawing.Size(98, 21);
            this.cmbSubFamiliaStock.TabIndex = 30;
            this.cmbSubFamiliaStock.SelectedIndexChanged += new System.EventHandler(this.cmbSubFamiliaStock_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "SubFamilia:";
            // 
            // txtEstanteria
            // 
            this.txtEstanteria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstanteria.Location = new System.Drawing.Point(137, 290);
            this.txtEstanteria.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstanteria.Name = "txtEstanteria";
            this.txtEstanteria.Size = new System.Drawing.Size(125, 20);
            this.txtEstanteria.TabIndex = 32;
            // 
            // lblEstanteria
            // 
            this.lblEstanteria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstanteria.AutoSize = true;
            this.lblEstanteria.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstanteria.Location = new System.Drawing.Point(28, 288);
            this.lblEstanteria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstanteria.Name = "lblEstanteria";
            this.lblEstanteria.Size = new System.Drawing.Size(105, 21);
            this.lblEstanteria.TabIndex = 33;
            this.lblEstanteria.Text = "Estanteria:";
            // 
            // lblEstante
            // 
            this.lblEstante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstante.AutoSize = true;
            this.lblEstante.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstante.Location = new System.Drawing.Point(266, 286);
            this.lblEstante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(81, 21);
            this.lblEstante.TabIndex = 34;
            this.lblEstante.Text = "Estante:";
            // 
            // txtEstante
            // 
            this.txtEstante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstante.Location = new System.Drawing.Point(346, 288);
            this.txtEstante.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstante.Name = "txtEstante";
            this.txtEstante.Size = new System.Drawing.Size(125, 20);
            this.txtEstante.TabIndex = 35;
            // 
            // txtAltura
            // 
            this.txtAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAltura.Location = new System.Drawing.Point(346, 321);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(125, 20);
            this.txtAltura.TabIndex = 37;
            // 
            // lblAltura
            // 
            this.lblAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(277, 321);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(70, 21);
            this.lblAltura.TabIndex = 36;
            this.lblAltura.Text = "Altura:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(815, 85);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(113, 23);
            this.lblEmpleado.TabIndex = 38;
            this.lblEmpleado.Text = "Empleado: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.cmbSubFamilia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFamilia);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCodArticulo);
            this.groupBox1.Controls.Add(this.txtCodArticulo);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblAltura);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtEstante);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblEstante);
            this.groupBox1.Controls.Add(this.lblTallaPesoLitros);
            this.groupBox1.Controls.Add(this.lblEstanteria);
            this.groupBox1.Controls.Add(this.lblNumeroRecogida);
            this.groupBox1.Controls.Add(this.txtEstanteria);
            this.groupBox1.Controls.Add(this.txtTallaPesoLitros);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblPedido);
            this.groupBox1.Controls.Add(this.txtPedido);
            this.groupBox1.Controls.Add(this.lblOjo);
            this.groupBox1.Controls.Add(this.cmbRecogida);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Location = new System.Drawing.Point(551, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 445);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir Nuevo Articulo";
            // 
            // cmbSubFamilia
            // 
            this.cmbSubFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSubFamilia.FormattingEnabled = true;
            this.cmbSubFamilia.Location = new System.Drawing.Point(134, 109);
            this.cmbSubFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSubFamilia.Name = "cmbSubFamilia";
            this.cmbSubFamilia.Size = new System.Drawing.Size(98, 21);
            this.cmbSubFamilia.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "SubFamilia:";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(134, 69);
            this.cmbFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(98, 21);
            this.cmbFamilia.TabIndex = 39;
            this.cmbFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFamilia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Familia:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(14, 104);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(418, 201);
            this.dgvProductos.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cantidad:";
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidadStock.Location = new System.Drawing.Point(262, 324);
            this.txtCantidadStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(79, 20);
            this.txtCantidadStock.TabIndex = 42;
            // 
            // grpAñadirStock
            // 
            this.grpAñadirStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAñadirStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAñadirStock.Controls.Add(this.btnAñadirStock);
            this.grpAñadirStock.Controls.Add(this.dgvProductos);
            this.grpAñadirStock.Controls.Add(this.label3);
            this.grpAñadirStock.Controls.Add(this.label1);
            this.grpAñadirStock.Controls.Add(this.txtCantidadStock);
            this.grpAñadirStock.Controls.Add(this.cmbFamiliaStock);
            this.grpAñadirStock.Controls.Add(this.label2);
            this.grpAñadirStock.Controls.Add(this.cmbSubFamiliaStock);
            this.grpAñadirStock.Location = new System.Drawing.Point(38, 111);
            this.grpAñadirStock.Name = "grpAñadirStock";
            this.grpAñadirStock.Size = new System.Drawing.Size(507, 445);
            this.grpAñadirStock.TabIndex = 43;
            this.grpAñadirStock.TabStop = false;
            this.grpAñadirStock.Text = "Añadir producto ya existente";
            // 
            // btnAñadirStock
            // 
            this.btnAñadirStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAñadirStock.BackgroundImage = global::CapaPresentacion.Properties.Resources.añadir;
            this.btnAñadirStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadirStock.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirStock.Location = new System.Drawing.Point(5, 359);
            this.btnAñadirStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirStock.Name = "btnAñadirStock";
            this.btnAñadirStock.Size = new System.Drawing.Size(482, 61);
            this.btnAñadirStock.TabIndex = 43;
            this.btnAñadirStock.UseVisualStyleBackColor = true;
            this.btnAñadirStock.Click += new System.EventHandler(this.btnAñadirStock_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1082, 568);
            this.Controls.Add(this.grpAñadirStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpAñadirStock.ResumeLayout(false);
            this.grpAñadirStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNumeroRecogida;
        private System.Windows.Forms.TextBox txtTallaPesoLitros;
        private System.Windows.Forms.Label lblTallaPesoLitros;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblOjo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbRecogida;
        private System.Windows.Forms.ComboBox cmbFamiliaStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubFamiliaStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstanteria;
        private System.Windows.Forms.Label lblEstanteria;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.TextBox txtEstante;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSubFamilia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.GroupBox grpAñadirStock;
        private System.Windows.Forms.Button btnAñadirStock;
    }
}