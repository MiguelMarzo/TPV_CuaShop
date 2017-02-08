namespace CapaPresentacion
{
    partial class frmRecogida
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbNumeroEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEntregador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroArticulosEntregados = new System.Windows.Forms.TextBox();
            this.lblNumeroRecogida = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(44, 23);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(220, 70);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbNumeroEmpleado
            // 
            this.cmbNumeroEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNumeroEmpleado.FormattingEnabled = true;
            this.cmbNumeroEmpleado.Location = new System.Drawing.Point(884, 43);
            this.cmbNumeroEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNumeroEmpleado.Name = "cmbNumeroEmpleado";
            this.cmbNumeroEmpleado.Size = new System.Drawing.Size(80, 24);
            this.cmbNumeroEmpleado.TabIndex = 20;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(740, 43);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(167, 29);
            this.lblEmpleado.TabIndex = 19;
            this.lblEmpleado.Text = "Nº Empleado:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(740, 81);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(88, 29);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(304, 43);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(471, 43);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "RECOGIDA DE ARTICULOS";
            // 
            // pct1
            // 
            this.pct1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pct1.Location = new System.Drawing.Point(44, 112);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(220, 205);
            this.pct1.TabIndex = 22;
            this.pct1.TabStop = false;
            // 
            // pct2
            // 
            this.pct2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pct2.Location = new System.Drawing.Point(740, 112);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(220, 205);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct2.TabIndex = 23;
            this.pct2.TabStop = false;
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticulo.Location = new System.Drawing.Point(300, 112);
            this.lblCodArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(251, 27);
            this.lblCodArticulo.TabIndex = 24;
            this.lblCodArticulo.Text = "Numero de recogida:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Entregador:";
            // 
            // cmbEntregador
            // 
            this.cmbEntregador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEntregador.FormattingEnabled = true;
            this.cmbEntregador.Location = new System.Drawing.Point(443, 207);
            this.cmbEntregador.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEntregador.Name = "cmbEntregador";
            this.cmbEntregador.Size = new System.Drawing.Size(199, 24);
            this.cmbEntregador.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cuantos artículos se entregan:";
            // 
            // txtNumeroArticulosEntregados
            // 
            this.txtNumeroArticulosEntregados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroArticulosEntregados.Location = new System.Drawing.Point(584, 298);
            this.txtNumeroArticulosEntregados.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroArticulosEntregados.Name = "txtNumeroArticulosEntregados";
            this.txtNumeroArticulosEntregados.Size = new System.Drawing.Size(119, 22);
            this.txtNumeroArticulosEntregados.TabIndex = 28;
            // 
            // lblNumeroRecogida
            // 
            this.lblNumeroRecogida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroRecogida.AutoSize = true;
            this.lblNumeroRecogida.Location = new System.Drawing.Point(505, 120);
            this.lblNumeroRecogida.Name = "lblNumeroRecogida";
            this.lblNumeroRecogida.Size = new System.Drawing.Size(0, 17);
            this.lblNumeroRecogida.TabIndex = 29;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(304, 354);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(399, 70);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmRecogida
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(985, 482);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroRecogida);
            this.Controls.Add(this.txtNumeroArticulosEntregados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEntregador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodArticulo);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cmbNumeroEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecogida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRecogida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRecogida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbNumeroEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEntregador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroArticulosEntregados;
        private System.Windows.Forms.Label lblNumeroRecogida;
        private System.Windows.Forms.Button btnAceptar;
    }
}