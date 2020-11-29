﻿namespace VentaDeMiel.Windows
{
    partial class FrmVentasAE
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
            this.components = new System.ComponentModel.Container();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.CmnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnTipoEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxTipoEnvase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmnProducto,
            this.CmnTipoEnvase,
            this.CmnCantidad,
            this.CmnPrecioUnitario});
            this.DatosDataGridView.Location = new System.Drawing.Point(451, 14);
            this.DatosDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersVisible = false;
            this.DatosDataGridView.RowHeadersWidth = 62;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(653, 429);
            this.DatosDataGridView.TabIndex = 16;
            // 
            // CmnProducto
            // 
            this.CmnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnProducto.HeaderText = "Producto";
            this.CmnProducto.MinimumWidth = 8;
            this.CmnProducto.Name = "CmnProducto";
            this.CmnProducto.ReadOnly = true;
            // 
            // CmnTipoEnvase
            // 
            this.CmnTipoEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnTipoEnvase.HeaderText = "Tipo De Envase";
            this.CmnTipoEnvase.MinimumWidth = 8;
            this.CmnTipoEnvase.Name = "CmnTipoEnvase";
            this.CmnTipoEnvase.ReadOnly = true;
            // 
            // CmnCantidad
            // 
            this.CmnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnCantidad.HeaderText = "Cantidad";
            this.CmnCantidad.MinimumWidth = 8;
            this.CmnCantidad.Name = "CmnCantidad";
            this.CmnCantidad.ReadOnly = true;
            // 
            // CmnPrecioUnitario
            // 
            this.CmnPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CmnPrecioUnitario.HeaderText = "Precio Unitario";
            this.CmnPrecioUnitario.MinimumWidth = 8;
            this.CmnPrecioUnitario.Name = "CmnPrecioUnitario";
            this.CmnPrecioUnitario.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 405);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 63);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(12, 311);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(135, 63);
            this.btnVender.TabIndex = 61;
            this.btnVender.Text = "Vender";
            this.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(880, 458);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(224, 26);
            this.textBoxTotal.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Total:";
            // 
            // ComboBoxCliente
            // 
            this.ComboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCliente.FormattingEnabled = true;
            this.ComboBoxCliente.Location = new System.Drawing.Point(12, 37);
            this.ComboBoxCliente.Name = "ComboBoxCliente";
            this.ComboBoxCliente.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxCliente.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(212, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 466);
            this.panel1.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Producto";
            // 
            // ComboBoxProducto
            // 
            this.ComboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProducto.FormattingEnabled = true;
            this.ComboBoxProducto.Location = new System.Drawing.Point(239, 37);
            this.ComboBoxProducto.Name = "ComboBoxProducto";
            this.ComboBoxProducto.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxProducto.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(239, 207);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(186, 26);
            this.textBoxCantidad.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Tipo De Envase";
            // 
            // ComboBoxTipoEnvase
            // 
            this.ComboBoxTipoEnvase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTipoEnvase.FormattingEnabled = true;
            this.ComboBoxTipoEnvase.Location = new System.Drawing.Point(239, 123);
            this.ComboBoxTipoEnvase.Name = "ComboBoxTipoEnvase";
            this.ComboBoxTipoEnvase.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxTipoEnvase.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Precio Unitario";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(239, 295);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(186, 26);
            this.textBoxPrecio.TabIndex = 89;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(265, 380);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 63);
            this.btnAgregar.TabIndex = 91;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmVentasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 496);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxTipoEnvase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.DatosDataGridView);
            this.Name = "FrmVentasAE";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FrmVentasAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnTipoEnvase;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmnPrecioUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxTipoEnvase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}