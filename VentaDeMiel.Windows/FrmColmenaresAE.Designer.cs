namespace VentaDeMiel.Windows
{
    partial class FrmColmenaresAE
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
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.textBoxColmenar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxCantidadColmena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxEstadoColmena = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxInsumo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ciudad:";
            // 
            // ComboBoxCiudad
            // 
            this.ComboBoxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCiudad.FormattingEnabled = true;
            this.ComboBoxCiudad.Location = new System.Drawing.Point(226, 128);
            this.ComboBoxCiudad.Name = "ComboBoxCiudad";
            this.ComboBoxCiudad.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxCiudad.TabIndex = 33;
            // 
            // textBoxColmenar
            // 
            this.textBoxColmenar.Location = new System.Drawing.Point(140, 36);
            this.textBoxColmenar.Name = "textBoxColmenar";
            this.textBoxColmenar.Size = new System.Drawing.Size(433, 26);
            this.textBoxColmenar.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(438, 274);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 63);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 274);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 63);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Colmenar:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxCantidadColmena
            // 
            this.textBoxCantidadColmena.Location = new System.Drawing.Point(226, 78);
            this.textBoxCantidadColmena.Name = "textBoxCantidadColmena";
            this.textBoxCantidadColmena.Size = new System.Drawing.Size(347, 26);
            this.textBoxCantidadColmena.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cantidad de colmenas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Estado de Colmenas:";
            // 
            // ComboBoxEstadoColmena
            // 
            this.ComboBoxEstadoColmena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEstadoColmena.FormattingEnabled = true;
            this.ComboBoxEstadoColmena.Location = new System.Drawing.Point(226, 227);
            this.ComboBoxEstadoColmena.Name = "ComboBoxEstadoColmena";
            this.ComboBoxEstadoColmena.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxEstadoColmena.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Insumo:";
            // 
            // ComboBoxInsumo
            // 
            this.ComboBoxInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxInsumo.FormattingEnabled = true;
            this.ComboBoxInsumo.Location = new System.Drawing.Point(226, 180);
            this.ComboBoxInsumo.Name = "ComboBoxInsumo";
            this.ComboBoxInsumo.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxInsumo.TabIndex = 39;
            // 
            // FrmColmenaresAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 350);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxInsumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBoxEstadoColmena);
            this.Controls.Add(this.textBoxCantidadColmena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxCiudad);
            this.Controls.Add(this.textBoxColmenar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "FrmColmenaresAE";
            this.Text = "Colmenar";
            this.Load += new System.EventHandler(this.FrmColmenaresAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxCiudad;
        private System.Windows.Forms.TextBox textBoxColmenar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxCantidadColmena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxEstadoColmena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxInsumo;
    }
}