namespace VentaDeMiel.Windows
{
    partial class FrmVentas
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
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.CmnVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CerrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnVenta,
            this.CmnCliente,
            this.CmnFecha,
            this.CmnTotal});
            this.DatosDataGridView.Location = new System.Drawing.Point(75, 14);
            this.DatosDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersVisible = false;
            this.DatosDataGridView.RowHeadersWidth = 62;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(953, 598);
            this.DatosDataGridView.TabIndex = 15;
            // 
            // CmnVenta
            // 
            this.CmnVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnVenta.HeaderText = "Numero Venta";
            this.CmnVenta.MinimumWidth = 8;
            this.CmnVenta.Name = "CmnVenta";
            this.CmnVenta.ReadOnly = true;
            // 
            // CmnCliente
            // 
            this.CmnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnCliente.HeaderText = "Cliente";
            this.CmnCliente.MinimumWidth = 8;
            this.CmnCliente.Name = "CmnCliente";
            this.CmnCliente.ReadOnly = true;
            // 
            // CmnFecha
            // 
            this.CmnFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnFecha.HeaderText = "Fecha";
            this.CmnFecha.MinimumWidth = 8;
            this.CmnFecha.Name = "CmnFecha";
            this.CmnFecha.ReadOnly = true;
            // 
            // CmnTotal
            // 
            this.CmnTotal.HeaderText = "Total";
            this.CmnTotal.MinimumWidth = 8;
            this.CmnTotal.Name = "CmnTotal";
            this.CmnTotal.ReadOnly = true;
            this.CmnTotal.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.toolStripSeparator1,
            this.CerrarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(71, 626);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(64, 29);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(64, 29);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(64, 6);
            // 
            // CerrarToolStripButton
            // 
            this.CerrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CerrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CerrarToolStripButton.Name = "CerrarToolStripButton";
            this.CerrarToolStripButton.Size = new System.Drawing.Size(64, 29);
            this.CerrarToolStripButton.Text = "Cerrar";
            this.CerrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrarToolStripButton.Click += new System.EventHandler(this.CerrarToolStripButton_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 626);
            this.ControlBox = false;
            this.Controls.Add(this.DatosDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CerrarToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnTotal;
    }
}