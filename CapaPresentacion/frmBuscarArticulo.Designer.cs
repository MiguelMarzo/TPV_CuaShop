﻿namespace CapaPresentacion
{
    partial class frmBuscarArticulo
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.chbLocalizacion = new System.Windows.Forms.CheckBox();
            this.chbIVA = new System.Windows.Forms.CheckBox();
            this.chbNumVenta = new System.Windows.Forms.CheckBox();
            this.chbNumPedido = new System.Windows.Forms.CheckBox();
            this.chbNumRecogida = new System.Windows.Forms.CheckBox();
            this.chbSubFamilia = new System.Windows.Forms.CheckBox();
            this.chbFamilia = new System.Windows.Forms.CheckBox();
            this.chbDescripcion = new System.Windows.Forms.CheckBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtEstante = new System.Windows.Forms.TextBox();
            this.txtEstanteria = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbIVA = new System.Windows.Forms.ComboBox();
            this.cmbSubFamilia = new System.Windows.Forms.ComboBox();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumRecogida = new System.Windows.Forms.TextBox();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.txtNumVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(386, 12);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(699, 572);
            this.dgvArticulos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.txtNumVenta);
            this.pnlControls.Controls.Add(this.txtNumPedido);
            this.pnlControls.Controls.Add(this.txtNumRecogida);
            this.pnlControls.Controls.Add(this.btnBuscar);
            this.pnlControls.Controls.Add(this.btnCancelar);
            this.pnlControls.Controls.Add(this.btnVolver);
            this.pnlControls.Controls.Add(this.chbLocalizacion);
            this.pnlControls.Controls.Add(this.chbIVA);
            this.pnlControls.Controls.Add(this.chbNumVenta);
            this.pnlControls.Controls.Add(this.chbNumPedido);
            this.pnlControls.Controls.Add(this.chbNumRecogida);
            this.pnlControls.Controls.Add(this.chbSubFamilia);
            this.pnlControls.Controls.Add(this.chbFamilia);
            this.pnlControls.Controls.Add(this.chbDescripcion);
            this.pnlControls.Controls.Add(this.txtAltura);
            this.pnlControls.Controls.Add(this.txtEstante);
            this.pnlControls.Controls.Add(this.txtEstanteria);
            this.pnlControls.Controls.Add(this.label12);
            this.pnlControls.Controls.Add(this.label11);
            this.pnlControls.Controls.Add(this.label10);
            this.pnlControls.Controls.Add(this.cmbIVA);
            this.pnlControls.Controls.Add(this.cmbSubFamilia);
            this.pnlControls.Controls.Add(this.cmbFamilia);
            this.pnlControls.Controls.Add(this.txtDescripcion);
            this.pnlControls.Controls.Add(this.label9);
            this.pnlControls.Controls.Add(this.label8);
            this.pnlControls.Controls.Add(this.label7);
            this.pnlControls.Controls.Add(this.label6);
            this.pnlControls.Controls.Add(this.label4);
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Location = new System.Drawing.Point(12, 12);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(368, 572);
            this.pnlControls.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(290, 505);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 60);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 505);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(6, 505);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 60);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // chbLocalizacion
            // 
            this.chbLocalizacion.AutoSize = true;
            this.chbLocalizacion.Location = new System.Drawing.Point(75, 434);
            this.chbLocalizacion.Name = "chbLocalizacion";
            this.chbLocalizacion.Size = new System.Drawing.Size(15, 14);
            this.chbLocalizacion.TabIndex = 32;
            this.chbLocalizacion.UseVisualStyleBackColor = true;
            this.chbLocalizacion.CheckedChanged += new System.EventHandler(this.chbLocalizacion_CheckedChanged);
            // 
            // chbIVA
            // 
            this.chbIVA.AutoSize = true;
            this.chbIVA.Location = new System.Drawing.Point(33, 359);
            this.chbIVA.Name = "chbIVA";
            this.chbIVA.Size = new System.Drawing.Size(15, 14);
            this.chbIVA.TabIndex = 31;
            this.chbIVA.UseVisualStyleBackColor = true;
            this.chbIVA.CheckedChanged += new System.EventHandler(this.chbIVA_CheckedChanged);
            // 
            // chbNumVenta
            // 
            this.chbNumVenta.AutoSize = true;
            this.chbNumVenta.Location = new System.Drawing.Point(84, 298);
            this.chbNumVenta.Name = "chbNumVenta";
            this.chbNumVenta.Size = new System.Drawing.Size(15, 14);
            this.chbNumVenta.TabIndex = 29;
            this.chbNumVenta.UseVisualStyleBackColor = true;
            this.chbNumVenta.CheckedChanged += new System.EventHandler(this.chbNumVenta_CheckedChanged);
            // 
            // chbNumPedido
            // 
            this.chbNumPedido.AutoSize = true;
            this.chbNumPedido.Location = new System.Drawing.Point(89, 239);
            this.chbNumPedido.Name = "chbNumPedido";
            this.chbNumPedido.Size = new System.Drawing.Size(15, 14);
            this.chbNumPedido.TabIndex = 28;
            this.chbNumPedido.UseVisualStyleBackColor = true;
            this.chbNumPedido.CheckedChanged += new System.EventHandler(this.chbNumPedido_CheckedChanged);
            // 
            // chbNumRecogida
            // 
            this.chbNumRecogida.AutoSize = true;
            this.chbNumRecogida.Location = new System.Drawing.Point(102, 177);
            this.chbNumRecogida.Name = "chbNumRecogida";
            this.chbNumRecogida.Size = new System.Drawing.Size(15, 14);
            this.chbNumRecogida.TabIndex = 27;
            this.chbNumRecogida.UseVisualStyleBackColor = true;
            this.chbNumRecogida.CheckedChanged += new System.EventHandler(this.chbNumRecogida_CheckedChanged);
            // 
            // chbSubFamilia
            // 
            this.chbSubFamilia.AutoSize = true;
            this.chbSubFamilia.Location = new System.Drawing.Point(64, 115);
            this.chbSubFamilia.Name = "chbSubFamilia";
            this.chbSubFamilia.Size = new System.Drawing.Size(15, 14);
            this.chbSubFamilia.TabIndex = 26;
            this.chbSubFamilia.UseVisualStyleBackColor = true;
            this.chbSubFamilia.CheckedChanged += new System.EventHandler(this.chbSubFamilia_CheckedChanged);
            // 
            // chbFamilia
            // 
            this.chbFamilia.AutoSize = true;
            this.chbFamilia.Location = new System.Drawing.Point(48, 55);
            this.chbFamilia.Name = "chbFamilia";
            this.chbFamilia.Size = new System.Drawing.Size(15, 14);
            this.chbFamilia.TabIndex = 25;
            this.chbFamilia.UseVisualStyleBackColor = true;
            this.chbFamilia.CheckedChanged += new System.EventHandler(this.chbFamilia_CheckedChanged);
            // 
            // chbDescripcion
            // 
            this.chbDescripcion.AutoSize = true;
            this.chbDescripcion.Location = new System.Drawing.Point(72, 3);
            this.chbDescripcion.Name = "chbDescripcion";
            this.chbDescripcion.Size = new System.Drawing.Size(15, 14);
            this.chbDescripcion.TabIndex = 24;
            this.chbDescripcion.UseVisualStyleBackColor = true;
            this.chbDescripcion.CheckedChanged += new System.EventHandler(this.chbDescripcion_CheckedChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(288, 479);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(77, 20);
            this.txtAltura.TabIndex = 23;
            // 
            // txtEstante
            // 
            this.txtEstante.Location = new System.Drawing.Point(144, 479);
            this.txtEstante.Name = "txtEstante";
            this.txtEstante.Size = new System.Drawing.Size(77, 20);
            this.txtEstante.TabIndex = 22;
            // 
            // txtEstanteria
            // 
            this.txtEstanteria.Location = new System.Drawing.Point(6, 479);
            this.txtEstanteria.Name = "txtEstanteria";
            this.txtEstanteria.Size = new System.Drawing.Size(77, 20);
            this.txtEstanteria.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(308, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Altura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Estante";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estantería";
            // 
            // cmbIVA
            // 
            this.cmbIVA.FormattingEnabled = true;
            this.cmbIVA.Location = new System.Drawing.Point(6, 379);
            this.cmbIVA.Name = "cmbIVA";
            this.cmbIVA.Size = new System.Drawing.Size(118, 21);
            this.cmbIVA.TabIndex = 17;
            // 
            // cmbSubFamilia
            // 
            this.cmbSubFamilia.FormattingEnabled = true;
            this.cmbSubFamilia.Location = new System.Drawing.Point(6, 132);
            this.cmbSubFamilia.Name = "cmbSubFamilia";
            this.cmbSubFamilia.Size = new System.Drawing.Size(121, 21);
            this.cmbSubFamilia.TabIndex = 13;
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(6, 72);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(121, 21);
            this.cmbFamilia.TabIndex = 12;
            this.cmbFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFamilia_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(4, 19);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Subfamilia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Familia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Localización";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Recogida";
            // 
            // txtNumRecogida
            // 
            this.txtNumRecogida.Location = new System.Drawing.Point(6, 194);
            this.txtNumRecogida.Name = "txtNumRecogida";
            this.txtNumRecogida.Size = new System.Drawing.Size(100, 20);
            this.txtNumRecogida.TabIndex = 34;
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(6, 256);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(100, 20);
            this.txtNumPedido.TabIndex = 35;
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.Location = new System.Drawing.Point(6, 315);
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.Size = new System.Drawing.Size(100, 20);
            this.txtNumVenta.TabIndex = 36;
            // 
            // frmBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 595);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBuscarArticulo";
            this.Text = "Buscar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBuscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.CheckBox chbLocalizacion;
        private System.Windows.Forms.CheckBox chbIVA;
        private System.Windows.Forms.CheckBox chbNumVenta;
        private System.Windows.Forms.CheckBox chbNumPedido;
        private System.Windows.Forms.CheckBox chbNumRecogida;
        private System.Windows.Forms.CheckBox chbSubFamilia;
        private System.Windows.Forms.CheckBox chbFamilia;
        private System.Windows.Forms.CheckBox chbDescripcion;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtEstante;
        private System.Windows.Forms.TextBox txtEstanteria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbIVA;
        private System.Windows.Forms.ComboBox cmbSubFamilia;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNumVenta;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.TextBox txtNumRecogida;
    }
}