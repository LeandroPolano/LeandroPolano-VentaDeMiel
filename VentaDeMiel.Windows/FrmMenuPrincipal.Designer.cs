namespace VentaDeClase.ReportLayer
{
    partial class FrmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProblemasDeColmenas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsbMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsbTiposDeProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.capacidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsbColmenas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsbProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProblemasDeColmenas,
            this.TsbMarca,
            this.tipoToolStripMenuItem,
            this.TsbTiposDeProductos,
            this.capacidadToolStripMenuItem,
            this.TsbColmenas,
            this.TsbProvincias,
            this.ciudadesToolStripMenuItem,
            this.toolStripSeparator1});
            this.archivosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // ProblemasDeColmenas
            // 
            this.ProblemasDeColmenas.Name = "ProblemasDeColmenas";
            this.ProblemasDeColmenas.Size = new System.Drawing.Size(274, 36);
            this.ProblemasDeColmenas.Text = "Colmenas";
            this.ProblemasDeColmenas.Click += new System.EventHandler(this.Colmenas_Click);
            // 
            // TsbMarca
            // 
            this.TsbMarca.Name = "TsbMarca";
            this.TsbMarca.Size = new System.Drawing.Size(274, 36);
            this.TsbMarca.Text = "Marcas";
            this.TsbMarca.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.tipoToolStripMenuItem.Text = "TiposDocumentos";
            this.tipoToolStripMenuItem.Click += new System.EventHandler(this.tipoToolStripMenuItem_Click);
            // 
            // TsbTiposDeProductos
            // 
            this.TsbTiposDeProductos.Name = "TsbTiposDeProductos";
            this.TsbTiposDeProductos.Size = new System.Drawing.Size(274, 36);
            this.TsbTiposDeProductos.Text = "TiposDeProductos";
            this.TsbTiposDeProductos.Click += new System.EventHandler(this.TsbTiposDeProductos_Click);
            // 
            // capacidadToolStripMenuItem
            // 
            this.capacidadToolStripMenuItem.Name = "capacidadToolStripMenuItem";
            this.capacidadToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.capacidadToolStripMenuItem.Text = "Capacidades";
            this.capacidadToolStripMenuItem.Click += new System.EventHandler(this.capacidadToolStripMenuItem_Click);
            // 
            // TsbColmenas
            // 
            this.TsbColmenas.Name = "TsbColmenas";
            this.TsbColmenas.Size = new System.Drawing.Size(274, 36);
            this.TsbColmenas.Text = "Paises";
            this.TsbColmenas.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // TsbProvincias
            // 
            this.TsbProvincias.Name = "TsbProvincias";
            this.TsbProvincias.Size = new System.Drawing.Size(274, 36);
            this.TsbProvincias.Text = "Provincias";
            this.TsbProvincias.Click += new System.EventHandler(this.TsbProvincias_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(66, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.ciudadesToolStripMenuItem.Text = "Ciudades";
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProblemasDeColmenas;
        private System.Windows.Forms.ToolStripMenuItem TsbMarca;
        private System.Windows.Forms.ToolStripMenuItem TsbTiposDeProductos;
        private System.Windows.Forms.ToolStripMenuItem TsbColmenas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsbProvincias;
        private System.Windows.Forms.ToolStripMenuItem capacidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
    }
}