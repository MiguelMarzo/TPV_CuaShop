namespace CapaPresentacion
{
    partial class frmDevolucion
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNumeroEmpleado = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblFechaR = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVendedorR = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblFechaVentaR = new System.Windows.Forms.Label();
            this.lblCodigoR = new System.Windows.Forms.Label();
            this.btnTicket = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblVenta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(1028, 41);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(165, 27);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Nº Empleado:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(373, 71);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(496, 40);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "DEVOLUCIÓN DE ARTICULOS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1028, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha:";
            // 
            // cmbNumeroEmpleado
            // 
            this.cmbNumeroEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNumeroEmpleado.FormattingEnabled = true;
            this.cmbNumeroEmpleado.Location = new System.Drawing.Point(1212, 44);
            this.cmbNumeroEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNumeroEmpleado.Name = "cmbNumeroEmpleado";
            this.cmbNumeroEmpleado.Size = new System.Drawing.Size(185, 24);
            this.cmbNumeroEmpleado.TabIndex = 12;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.Location = new System.Drawing.Point(49, 44);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(175, 97);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblFechaR
            // 
            this.lblFechaR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaR.AutoSize = true;
            this.lblFechaR.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaR.Location = new System.Drawing.Point(1127, 116);
            this.lblFechaR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(79, 27);
            this.lblFechaR.TabIndex = 14;
            this.lblFechaR.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblVendedorR);
            this.groupBox1.Controls.Add(this.lblVendedor);
            this.groupBox1.Controls.Add(this.lblFechaVentaR);
            this.groupBox1.Controls.Add(this.lblCodigoR);
            this.groupBox1.Controls.Add(this.btnTicket);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFechaVenta);
            this.groupBox1.Controls.Add(this.lblVenta);
            this.groupBox1.Location = new System.Drawing.Point(49, 204);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1380, 566);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblVendedorR
            // 
            this.lblVendedorR.AutoSize = true;
            this.lblVendedorR.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorR.Location = new System.Drawing.Point(1105, 26);
            this.lblVendedorR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedorR.Name = "lblVendedorR";
            this.lblVendedorR.Size = new System.Drawing.Size(125, 27);
            this.lblVendedorR.TabIndex = 25;
            this.lblVendedorR.Text = "Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(957, 26);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(132, 27);
            this.lblVendedor.TabIndex = 24;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblFechaVentaR
            // 
            this.lblFechaVentaR.AutoSize = true;
            this.lblFechaVentaR.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVentaR.Location = new System.Drawing.Point(707, 26);
            this.lblFechaVentaR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVentaR.Name = "lblFechaVentaR";
            this.lblFechaVentaR.Size = new System.Drawing.Size(156, 27);
            this.lblFechaVentaR.TabIndex = 23;
            this.lblFechaVentaR.Text = "Fecha_Venta";
            // 
            // lblCodigoR
            // 
            this.lblCodigoR.AutoSize = true;
            this.lblCodigoR.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoR.Location = new System.Drawing.Point(276, 26);
            this.lblCodigoR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoR.Name = "lblCodigoR";
            this.lblCodigoR.Size = new System.Drawing.Size(178, 27);
            this.lblCodigoR.TabIndex = 22;
            this.lblCodigoR.Text = "Codigo_Barras";
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(1132, 204);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(217, 258);
            this.btnTicket.TabIndex = 21;
            this.btnTicket.Text = "TICKET";
            this.btnTicket.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 362);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Artículos:";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(533, 26);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(157, 27);
            this.lblFechaVenta.TabIndex = 18;
            this.lblFechaVenta.Text = "Fecha Venta:";
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.Location = new System.Drawing.Point(40, 26);
            this.lblVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(214, 27);
            this.lblVenta.TabIndex = 17;
            this.lblVenta.Text = "Código de Barras:";
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 785);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFechaR);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmbNumeroEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDevolucion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDevolucion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNumeroEmpleado;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblFechaR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVendedorR;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblFechaVentaR;
        private System.Windows.Forms.Label lblCodigoR;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblVenta;
    }
}