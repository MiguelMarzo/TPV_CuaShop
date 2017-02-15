namespace CapaPresentacion
{
    partial class frmInicio
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
            this.btnAccionesEmpleado = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(107, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(467, 117);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CuaShop";
            // 
            // btnAccionesEmpleado
            // 
            this.btnAccionesEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccionesEmpleado.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccionesEmpleado.Location = new System.Drawing.Point(184, 138);
            this.btnAccionesEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccionesEmpleado.Name = "btnAccionesEmpleado";
            this.btnAccionesEmpleado.Size = new System.Drawing.Size(255, 54);
            this.btnAccionesEmpleado.TabIndex = 1;
            this.btnAccionesEmpleado.Text = "AccionesEmpleado";
            this.btnAccionesEmpleado.UseVisualStyleBackColor = true;
            this.btnAccionesEmpleado.Click += new System.EventHandler(this.btnAccionesEmpleado_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmin.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(184, 281);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(255, 54);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administración";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarArticulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArticulo.Location = new System.Drawing.Point(184, 210);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(255, 54);
            this.btnBuscarArticulo.TabIndex = 3;
            this.btnBuscarArticulo.Text = "Buscar Articulo";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(571, 10);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 78);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "LogOut";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 397);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAccionesEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInicio";
            this.Text = "CuaShop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAccionesEmpleado;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnSalir;
    }
}