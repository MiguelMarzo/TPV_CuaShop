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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnAnadirCarrito = new System.Windows.Forms.Button();
            this.btnSacarTicket = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.pnlFamilias = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSubFamilias = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.pnlFamilias.SuspendLayout();
            this.pnlSubFamilias.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(9, 355);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(774, 245);
            this.dgvProductos.TabIndex = 0;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(832, 12);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(379, 196);
            this.dgvCarrito.TabIndex = 1;
            // 
            // btnAnadirCarrito
            // 
            this.btnAnadirCarrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnadirCarrito.Location = new System.Drawing.Point(12, 12);
            this.btnAnadirCarrito.Name = "btnAnadirCarrito";
            this.btnAnadirCarrito.Size = new System.Drawing.Size(217, 113);
            this.btnAnadirCarrito.TabIndex = 2;
            this.btnAnadirCarrito.Text = "Añadir al carrito";
            this.btnAnadirCarrito.UseVisualStyleBackColor = true;
            // 
            // btnSacarTicket
            // 
            this.btnSacarTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacarTicket.Location = new System.Drawing.Point(235, 12);
            this.btnSacarTicket.Name = "btnSacarTicket";
            this.btnSacarTicket.Size = new System.Drawing.Size(217, 113);
            this.btnSacarTicket.TabIndex = 3;
            this.btnSacarTicket.Text = "Sacar ticket";
            this.btnSacarTicket.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarCompra.Location = new System.Drawing.Point(458, 12);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(217, 113);
            this.btnCancelarCompra.TabIndex = 4;
            this.btnCancelarCompra.Text = "Cancelar compra";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbCarrito.Location = new System.Drawing.Point(750, 12);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(77, 71);
            this.pcbCarrito.TabIndex = 5;
            this.pcbCarrito.TabStop = false;
            // 
            // pnlFamilias
            // 
            this.pnlFamilias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFamilias.Controls.Add(this.label1);
            this.pnlFamilias.Location = new System.Drawing.Point(9, 131);
            this.pnlFamilias.Name = "pnlFamilias";
            this.pnlFamilias.Size = new System.Drawing.Size(774, 218);
            this.pnlFamilias.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Familias";
            // 
            // pnlSubFamilias
            // 
            this.pnlSubFamilias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSubFamilias.Controls.Add(this.label2);
            this.pnlSubFamilias.Location = new System.Drawing.Point(832, 214);
            this.pnlSubFamilias.Name = "pnlSubFamilias";
            this.pnlSubFamilias.Size = new System.Drawing.Size(380, 386);
            this.pnlSubFamilias.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SubFamilias";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 612);
            this.Controls.Add(this.pnlSubFamilias);
            this.Controls.Add(this.pnlFamilias);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.btnSacarTicket);
            this.Controls.Add(this.btnAnadirCarrito);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.pnlFamilias.ResumeLayout(false);
            this.pnlFamilias.PerformLayout();
            this.pnlSubFamilias.ResumeLayout(false);
            this.pnlSubFamilias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnAnadirCarrito;
        private System.Windows.Forms.Button btnSacarTicket;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Panel pnlFamilias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSubFamilias;
        private System.Windows.Forms.Label label2;
    }
}