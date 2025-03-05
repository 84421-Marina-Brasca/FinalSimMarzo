
namespace TP3_proyecto.Formularios
{
    partial class PruebasTXT
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
            this.button1 = new System.Windows.Forms.Button();
            this.graficar = new System.Windows.Forms.Button();
            this.probarNormal = new System.Windows.Forms.Button();
            this.probarUniforme = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Normal_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graficar
            // 
            this.graficar.Location = new System.Drawing.Point(23, 105);
            this.graficar.Name = "graficar";
            this.graficar.Size = new System.Drawing.Size(224, 38);
            this.graficar.TabIndex = 8;
            this.graficar.Text = "Grafico";
            this.graficar.UseVisualStyleBackColor = true;
            this.graficar.Click += new System.EventHandler(this.graficar_Click);
            // 
            // probarNormal
            // 
            this.probarNormal.Location = new System.Drawing.Point(23, 176);
            this.probarNormal.Name = "probarNormal";
            this.probarNormal.Size = new System.Drawing.Size(224, 38);
            this.probarNormal.TabIndex = 9;
            this.probarNormal.Text = "Probar como Normal";
            this.probarNormal.UseVisualStyleBackColor = true;
            this.probarNormal.Click += new System.EventHandler(this.probarNormal_Click);
            // 
            // probarUniforme
            // 
            this.probarUniforme.Location = new System.Drawing.Point(23, 247);
            this.probarUniforme.Name = "probarUniforme";
            this.probarUniforme.Size = new System.Drawing.Size(224, 38);
            this.probarUniforme.TabIndex = 10;
            this.probarUniforme.Text = "Probar como Uniforme";
            this.probarUniforme.UseVisualStyleBackColor = true;
            this.probarUniforme.Click += new System.EventHandler(this.probarUniforme_Click);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Normal_});
            this.grilla.Location = new System.Drawing.Point(290, 34);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 51;
            this.grilla.Size = new System.Drawing.Size(303, 251);
            this.grilla.TabIndex = 11;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.Width = 125;
            // 
            // Normal_
            // 
            this.Normal_.HeaderText = "Normal";
            this.Normal_.MinimumWidth = 6;
            this.Normal_.Name = "Normal_";
            this.Normal_.Width = 125;
            // 
            // PruebasTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 318);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.probarUniforme);
            this.Controls.Add(this.probarNormal);
            this.Controls.Add(this.graficar);
            this.Controls.Add(this.button1);
            this.Name = "PruebasTXT";
            this.Text = "PruebasTXT";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button graficar;
        private System.Windows.Forms.Button probarNormal;
        private System.Windows.Forms.Button probarUniforme;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Normal_;
    }
}