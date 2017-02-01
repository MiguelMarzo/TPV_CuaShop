namespace CapaPresentacion
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tlpCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 498);
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
            this.tlpBotones.Location = new System.Drawing.Point(3, 3);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(381, 118);
            this.tlpBotones.TabIndex = 0;
            // 
            // btnAnadirCarrito
            // 
            this.btnAnadirCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnadirCarrito.Location = new System.Drawing.Point(3, 3);
            this.btnAnadirCarrito.Name = "btnAnadirCarrito";
            this.btnAnadirCarrito.Size = new System.Drawing.Size(120, 112);
            this.btnAnadirCarrito.TabIndex = 0;
            this.btnAnadirCarrito.Text = "Añadir al carrito";
            this.btnAnadirCarrito.UseVisualStyleBackColor = true;
            // 
            // btnSacarTicket
            // 
            this.btnSacarTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSacarTicket.Location = new System.Drawing.Point(129, 3);
            this.btnSacarTicket.Name = "btnSacarTicket";
            this.btnSacarTicket.Size = new System.Drawing.Size(120, 112);
            this.btnSacarTicket.TabIndex = 1;
            this.btnSacarTicket.Text = "Sacar ticket";
            this.btnSacarTicket.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarCompra.Location = new System.Drawing.Point(255, 3);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(123, 112);
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
            this.tlpFamilias.Location = new System.Drawing.Point(3, 127);
            this.tlpFamilias.Name = "tlpFamilias";
            this.tlpFamilias.RowCount = 2;
            this.tlpFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFamilias.Size = new System.Drawing.Size(381, 143);
            this.tlpFamilias.TabIndex = 1;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(3, 276);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(381, 219);
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
            this.tlpCarrito.Location = new System.Drawing.Point(390, 3);
            this.tlpCarrito.Name = "tlpCarrito";
            this.tlpCarrito.RowCount = 1;
            this.tlpCarrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCarrito.Size = new System.Drawing.Size(381, 118);
            this.tlpCarrito.TabIndex = 3;
            // 
            // ptbCarrito
            // 
            this.ptbCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbCarrito.Location = new System.Drawing.Point(3, 3);
            this.ptbCarrito.Name = "ptbCarrito";
            this.ptbCarrito.Size = new System.Drawing.Size(89, 112);
            this.ptbCarrito.TabIndex = 0;
            this.ptbCarrito.TabStop = false;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(98, 3);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(280, 112);
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
            this.tlpSubFamilias.Location = new System.Drawing.Point(390, 276);
            this.tlpSubFamilias.Name = "tlpSubFamilias";
            this.tlpSubFamilias.RowCount = 3;
            this.tlpSubFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSubFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSubFamilias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSubFamilias.Size = new System.Drawing.Size(381, 219);
            this.tlpSubFamilias.TabIndex = 4;
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPrueba";
            this.Text = "frmPrueba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tlpCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
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
    }
}