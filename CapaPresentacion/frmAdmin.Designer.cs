namespace CapaPresentacion
{
    partial class frmAdmin
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
            this.grpAñadirEmpleado = new System.Windows.Forms.GroupBox();
            this.pctBoxFotoEmpleado = new System.Windows.Forms.PictureBox();
            this.txtRutaFoto = new System.Windows.Forms.TextBox();
            this.btnAñadirFoto = new System.Windows.Forms.Button();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.adminTableAdapter1 = new CapaDatos.dsCuaShopTableAdapters.AdminTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarTodosLosEmpleados = new System.Windows.Forms.Button();
            this.grpAñadirEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFotoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(251, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(489, 61);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ADMINISTRACIÓN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAñadirEmpleado
            // 
            this.grpAñadirEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAñadirEmpleado.Controls.Add(this.pctBoxFotoEmpleado);
            this.grpAñadirEmpleado.Controls.Add(this.txtRutaFoto);
            this.grpAñadirEmpleado.Controls.Add(this.btnAñadirFoto);
            this.grpAñadirEmpleado.Controls.Add(this.lblNombreArticulo);
            this.grpAñadirEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.grpAñadirEmpleado.Controls.Add(this.btnAñadir);
            this.grpAñadirEmpleado.Location = new System.Drawing.Point(31, 99);
            this.grpAñadirEmpleado.Name = "grpAñadirEmpleado";
            this.grpAñadirEmpleado.Size = new System.Drawing.Size(568, 249);
            this.grpAñadirEmpleado.TabIndex = 2;
            this.grpAñadirEmpleado.TabStop = false;
            this.grpAñadirEmpleado.Text = "Añadir Empleado";
            // 
            // pctBoxFotoEmpleado
            // 
            this.pctBoxFotoEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBoxFotoEmpleado.Location = new System.Drawing.Point(339, 27);
            this.pctBoxFotoEmpleado.Name = "pctBoxFotoEmpleado";
            this.pctBoxFotoEmpleado.Size = new System.Drawing.Size(199, 198);
            this.pctBoxFotoEmpleado.TabIndex = 6;
            this.pctBoxFotoEmpleado.TabStop = false;
            // 
            // txtRutaFoto
            // 
            this.txtRutaFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRutaFoto.Location = new System.Drawing.Point(168, 101);
            this.txtRutaFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRutaFoto.Name = "txtRutaFoto";
            this.txtRutaFoto.Size = new System.Drawing.Size(157, 22);
            this.txtRutaFoto.TabIndex = 9;
            // 
            // btnAñadirFoto
            // 
            this.btnAñadirFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAñadirFoto.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirFoto.Location = new System.Drawing.Point(51, 90);
            this.btnAñadirFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirFoto.Name = "btnAñadirFoto";
            this.btnAñadirFoto.Size = new System.Drawing.Size(111, 44);
            this.btnAñadirFoto.TabIndex = 8;
            this.btnAñadirFoto.Text = "Añadir Foto";
            this.btnAñadirFoto.UseVisualStyleBackColor = true;
            this.btnAñadirFoto.Click += new System.EventHandler(this.btnAñadirFoto_Click);
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.Location = new System.Drawing.Point(17, 27);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(111, 27);
            this.lblNombreArticulo.TabIndex = 6;
            this.lblNombreArticulo.Text = "Nombre:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(134, 32);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(191, 22);
            this.txtNombreEmpleado.TabIndex = 7;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAñadir.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(51, 168);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(274, 56);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(851, 23);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(167, 96);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarTodosLosEmpleados
            // 
            this.btnEliminarTodosLosEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarTodosLosEmpleados.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodosLosEmpleados.Location = new System.Drawing.Point(31, 353);
            this.btnEliminarTodosLosEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTodosLosEmpleados.Name = "btnEliminarTodosLosEmpleados";
            this.btnEliminarTodosLosEmpleados.Size = new System.Drawing.Size(460, 56);
            this.btnEliminarTodosLosEmpleados.TabIndex = 6;
            this.btnEliminarTodosLosEmpleados.Text = "Borrar todos los empleados";
            this.btnEliminarTodosLosEmpleados.UseVisualStyleBackColor = true;
            this.btnEliminarTodosLosEmpleados.Click += new System.EventHandler(this.btnEliminarTodosLosEmpleados_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 586);
            this.Controls.Add(this.btnEliminarTodosLosEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpAñadirEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpAñadirEmpleado.ResumeLayout(false);
            this.grpAñadirEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFotoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpAñadirEmpleado;
        private System.Windows.Forms.Button btnAñadir;
        private CapaDatos.dsCuaShopTableAdapters.AdminTableAdapter adminTableAdapter1;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtRutaFoto;
        private System.Windows.Forms.Button btnAñadirFoto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pctBoxFotoEmpleado;
        private System.Windows.Forms.Button btnEliminarTodosLosEmpleados;
    }
}