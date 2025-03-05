namespace Ejercicio1Final.Formularios
{
    partial class Normal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Normal));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Normal_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnChi = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnVolver.Location = new System.Drawing.Point(90, 413);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(293, 29);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGenerar.Location = new System.Drawing.Point(90, 288);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(293, 30);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Media";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Varianza";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(133, 80);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(132, 22);
            this.txtMedia.TabIndex = 1;
            this.txtMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedia_KeyPress);
            // 
            // txtVarianza
            // 
            this.txtVarianza.Location = new System.Drawing.Point(133, 122);
            this.txtVarianza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.Size = new System.Drawing.Size(132, 22);
            this.txtVarianza.TabIndex = 2;
            this.txtVarianza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVarianza_KeyPress);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Valor,
            this.Normal_});
            this.grilla.Location = new System.Drawing.Point(459, 38);
            this.grilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 51;
            this.grilla.Size = new System.Drawing.Size(569, 404);
            this.grilla.TabIndex = 10;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.Width = 125;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "RND";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.Width = 125;
            // 
            // Normal_
            // 
            this.Normal_.HeaderText = "Normal";
            this.Normal_.MinimumWidth = 6;
            this.Normal_.Name = "Normal_";
            this.Normal_.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Distribución Normal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 165);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 22);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnChi
            // 
            this.btnChi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnChi.Location = new System.Drawing.Point(90, 363);
            this.btnChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChi.Name = "btnChi";
            this.btnChi.Size = new System.Drawing.Size(293, 29);
            this.btnChi.TabIndex = 6;
            this.btnChi.Text = "Pruebas de bondad";
            this.btnChi.UseVisualStyleBackColor = true;
            this.btnChi.Click += new System.EventHandler(this.btnChi_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGrafico.Location = new System.Drawing.Point(90, 326);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(293, 29);
            this.btnGrafico.TabIndex = 5;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMedia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtVarianza);
            this.panel1.Location = new System.Drawing.Point(55, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 225);
            this.panel1.TabIndex = 14;
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1077, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChi);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Normal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnChi;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Normal_;
        private System.Windows.Forms.Panel panel1;
    }
}