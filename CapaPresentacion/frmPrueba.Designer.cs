﻿namespace CapaPresentacion
{
    partial class frmPrueba
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotones.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 613);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnAnadirCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnadirCarrito.Name = "btnAnadirCarrito";
            this.btnAnadirCarrito.Size = new System.Drawing.Size(161, 137);
            this.btnAnadirCarrito.TabIndex = 0;
            this.btnAnadirCarrito.Text = "Añadir al carrito";
            this.btnAnadirCarrito.UseVisualStyleBackColor = true;
            // 
            // btnSacarTicket
            // 
            this.btnSacarTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSacarTicket.Location = new System.Drawing.Point(173, 4);
            this.btnSacarTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tlpFamilias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFamilias.Location = new System.Drawing.Point(4, 157);
            this.tlpFamilias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpFamilias.Name = "tlpFamilias";
            this.tlpFamilias.RowCount = 2;
            this.tlpFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFamilias.Size = new System.Drawing.Size(508, 175);
            this.tlpFamilias.TabIndex = 1;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(4, 340);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(508, 269);
            this.dgvProductos.TabIndex = 2;
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
            this.tlpCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ptbCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tlpSubFamilias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(519, 156);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 177);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnAtras
            // 
            this.btnAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(3, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(249, 171);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Volver";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrueba";
            this.Text = "frmPrueba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tlpCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}