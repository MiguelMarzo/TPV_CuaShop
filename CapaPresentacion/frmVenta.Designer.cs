using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmVenta
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnadirCarrito = new System.Windows.Forms.Button();
            this.btnSacarTicket = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.tlpFamilias = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tlpCarrito = new System.Windows.Forms.TableLayoutPanel();
            this.ptbCarrito = new System.Windows.Forms.PictureBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.tlpSubFamilias = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnFamilia1 = new System.Windows.Forms.Button();
            this.btnFamilia2 = new System.Windows.Forms.Button();
            this.btnFamilia3 = new System.Windows.Forms.Button();
            this.btnFamilia4 = new System.Windows.Forms.Button();
            this.btnFamilia5 = new System.Windows.Forms.Button();
            this.btnFamilia6 = new System.Windows.Forms.Button();
            this.btnFamilia7 = new System.Windows.Forms.Button();
            this.btnFamilia8 = new System.Windows.Forms.Button();
            this.btnFamilia9 = new System.Windows.Forms.Button();
            this.btnFamilia10 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.tlpFamilias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tlpCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpBotones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpFamilias, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvProductos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tlpCarrito, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpSubFamilias, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 613);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.btnAnadirCarrito, 0, 0);
            this.tlpBotones.Controls.Add(this.btnSacarTicket, 1, 0);
            this.tlpBotones.Controls.Add(this.btnCancelarCompra, 2, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(4, 4);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(508, 145);
            this.tlpBotones.TabIndex = 0;
            // 
            // btnAnadirCarrito
            // 
            this.btnAnadirCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnadirCarrito.Location = new System.Drawing.Point(4, 4);
            this.btnAnadirCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadirCarrito.Name = "btnAnadirCarrito";
            this.btnAnadirCarrito.Size = new System.Drawing.Size(161, 137);
            this.btnAnadirCarrito.TabIndex = 0;
            this.btnAnadirCarrito.Text = "Añadir al carrito";
            this.btnAnadirCarrito.UseVisualStyleBackColor = true;
            this.btnAnadirCarrito.Click += new System.EventHandler(this.btnAnadirCarrito_Click);
            // 
            // btnSacarTicket
            // 
            this.btnSacarTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSacarTicket.Location = new System.Drawing.Point(173, 4);
            this.btnSacarTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacarTicket.Name = "btnSacarTicket";
            this.btnSacarTicket.Size = new System.Drawing.Size(161, 137);
            this.btnSacarTicket.TabIndex = 1;
            this.btnSacarTicket.Text = "Sacar ticket";
            this.btnSacarTicket.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarCompra.Location = new System.Drawing.Point(342, 4);
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(162, 137);
            this.btnCancelarCompra.TabIndex = 2;
            this.btnCancelarCompra.Text = "Cancelar compra";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            // 
            // tlpFamilias
            // 
            this.tlpFamilias.ColumnCount = 5;
            this.tlpFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFamilias.Controls.Add(this.btnFamilia10, 4, 1);
            this.tlpFamilias.Controls.Add(this.btnFamilia9, 3, 1);
            this.tlpFamilias.Controls.Add(this.btnFamilia8, 2, 1);
            this.tlpFamilias.Controls.Add(this.btnFamilia7, 1, 1);
            this.tlpFamilias.Controls.Add(this.btnFamilia6, 0, 1);
            this.tlpFamilias.Controls.Add(this.btnFamilia5, 4, 0);
            this.tlpFamilias.Controls.Add(this.btnFamilia4, 3, 0);
            this.tlpFamilias.Controls.Add(this.btnFamilia3, 2, 0);
            this.tlpFamilias.Controls.Add(this.btnFamilia2, 1, 0);
            this.tlpFamilias.Controls.Add(this.btnFamilia1, 0, 0);
            this.tlpFamilias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFamilias.Location = new System.Drawing.Point(4, 157);
            this.tlpFamilias.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFamilias.Name = "tlpFamilias";
            this.tlpFamilias.RowCount = 2;
            this.tlpFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFamilias.Size = new System.Drawing.Size(508, 175);
            this.tlpFamilias.TabIndex = 1;
            this.tlpFamilias.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpFamilias_Paint);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(4, 340);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(508, 269);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // tlpCarrito
            // 
            this.tlpCarrito.ColumnCount = 2;
            this.tlpCarrito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCarrito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpCarrito.Controls.Add(this.ptbCarrito, 0, 0);
            this.tlpCarrito.Controls.Add(this.dgvCarrito, 1, 0);
            this.tlpCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCarrito.Location = new System.Drawing.Point(520, 4);
            this.tlpCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.tlpCarrito.Name = "tlpCarrito";
            this.tlpCarrito.RowCount = 1;
            this.tlpCarrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCarrito.Size = new System.Drawing.Size(508, 145);
            this.tlpCarrito.TabIndex = 3;
            // 
            // ptbCarrito
            // 
            this.ptbCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbCarrito.Location = new System.Drawing.Point(4, 4);
            this.ptbCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.ptbCarrito.Name = "ptbCarrito";
            this.ptbCarrito.Size = new System.Drawing.Size(119, 137);
            this.ptbCarrito.TabIndex = 0;
            this.ptbCarrito.TabStop = false;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(131, 4);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(373, 137);
            this.dgvCarrito.TabIndex = 1;
            // 
            // tlpSubFamilias
            // 
            this.tlpSubFamilias.ColumnCount = 4;
            this.tlpSubFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSubFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSubFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSubFamilias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSubFamilias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSubFamilias.Location = new System.Drawing.Point(520, 340);
            this.tlpSubFamilias.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSubFamilias.Name = "tlpSubFamilias";
            this.tlpSubFamilias.RowCount = 3;
            this.tlpSubFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSubFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSubFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSubFamilias.Size = new System.Drawing.Size(508, 269);
            this.tlpSubFamilias.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAtras, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(519, 155);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 179);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnAtras
            // 
            this.btnAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(3, 2);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(249, 175);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Volver";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnFamilia1
            // 
            this.btnFamilia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia1.Location = new System.Drawing.Point(3, 3);
            this.btnFamilia1.Name = "btnFamilia1";
            this.btnFamilia1.Size = new System.Drawing.Size(95, 81);
            this.btnFamilia1.TabIndex = 0;
            this.btnFamilia1.Text = "familia1";
            this.btnFamilia1.UseVisualStyleBackColor = true;
            // 
            // btnFamilia2
            // 
            this.btnFamilia2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia2.Location = new System.Drawing.Point(104, 3);
            this.btnFamilia2.Name = "btnFamilia2";
            this.btnFamilia2.Size = new System.Drawing.Size(95, 81);
            this.btnFamilia2.TabIndex = 1;
            this.btnFamilia2.Text = "familia2";
            this.btnFamilia2.UseVisualStyleBackColor = true;
            // 
            // btnFamilia3
            // 
            this.btnFamilia3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia3.Location = new System.Drawing.Point(205, 3);
            this.btnFamilia3.Name = "btnFamilia3";
            this.btnFamilia3.Size = new System.Drawing.Size(95, 81);
            this.btnFamilia3.TabIndex = 2;
            this.btnFamilia3.Text = "familia3";
            this.btnFamilia3.UseVisualStyleBackColor = true;
            // 
            // btnFamilia4
            // 
            this.btnFamilia4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia4.Location = new System.Drawing.Point(306, 3);
            this.btnFamilia4.Name = "btnFamilia4";
            this.btnFamilia4.Size = new System.Drawing.Size(95, 81);
            this.btnFamilia4.TabIndex = 3;
            this.btnFamilia4.Text = "familia4";
            this.btnFamilia4.UseVisualStyleBackColor = true;
            // 
            // btnFamilia5
            // 
            this.btnFamilia5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia5.Location = new System.Drawing.Point(407, 3);
            this.btnFamilia5.Name = "btnFamilia5";
            this.btnFamilia5.Size = new System.Drawing.Size(98, 81);
            this.btnFamilia5.TabIndex = 4;
            this.btnFamilia5.Text = "familia5";
            this.btnFamilia5.UseVisualStyleBackColor = true;
            // 
            // btnFamilia6
            // 
            this.btnFamilia6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia6.Location = new System.Drawing.Point(3, 90);
            this.btnFamilia6.Name = "btnFamilia6";
            this.btnFamilia6.Size = new System.Drawing.Size(95, 82);
            this.btnFamilia6.TabIndex = 5;
            this.btnFamilia6.Text = "familia6";
            this.btnFamilia6.UseVisualStyleBackColor = true;
            // 
            // btnFamilia7
            // 
            this.btnFamilia7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia7.Location = new System.Drawing.Point(104, 90);
            this.btnFamilia7.Name = "btnFamilia7";
            this.btnFamilia7.Size = new System.Drawing.Size(95, 82);
            this.btnFamilia7.TabIndex = 6;
            this.btnFamilia7.Text = "familia7";
            this.btnFamilia7.UseVisualStyleBackColor = true;
            // 
            // btnFamilia8
            // 
            this.btnFamilia8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia8.Location = new System.Drawing.Point(205, 90);
            this.btnFamilia8.Name = "btnFamilia8";
            this.btnFamilia8.Size = new System.Drawing.Size(95, 82);
            this.btnFamilia8.TabIndex = 7;
            this.btnFamilia8.Text = "familia8";
            this.btnFamilia8.UseVisualStyleBackColor = true;
            // 
            // btnFamilia9
            // 
            this.btnFamilia9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia9.Location = new System.Drawing.Point(306, 90);
            this.btnFamilia9.Name = "btnFamilia9";
            this.btnFamilia9.Size = new System.Drawing.Size(95, 82);
            this.btnFamilia9.TabIndex = 8;
            this.btnFamilia9.Text = "familia9";
            this.btnFamilia9.UseVisualStyleBackColor = true;
            // 
            // btnFamilia10
            // 
            this.btnFamilia10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFamilia10.Location = new System.Drawing.Point(407, 90);
            this.btnFamilia10.Name = "btnFamilia10";
            this.btnFamilia10.Size = new System.Drawing.Size(98, 82);
            this.btnFamilia10.TabIndex = 9;
            this.btnFamilia10.Text = "familia10";
            this.btnFamilia10.UseVisualStyleBackColor = true;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVenta";
            this.Text = "frmPrueba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.tlpFamilias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tlpCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnAnadirCarrito;
        private System.Windows.Forms.Button btnSacarTicket;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.TableLayoutPanel tlpFamilias;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TableLayoutPanel tlpCarrito;
        private System.Windows.Forms.PictureBox ptbCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.TableLayoutPanel tlpSubFamilias;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnFamilia10;
        private System.Windows.Forms.Button btnFamilia9;
        private System.Windows.Forms.Button btnFamilia8;
        private System.Windows.Forms.Button btnFamilia7;
        private System.Windows.Forms.Button btnFamilia6;
        private System.Windows.Forms.Button btnFamilia5;
        private System.Windows.Forms.Button btnFamilia4;
        private System.Windows.Forms.Button btnFamilia3;
        private System.Windows.Forms.Button btnFamilia2;
        private System.Windows.Forms.Button btnFamilia1;
    }
}