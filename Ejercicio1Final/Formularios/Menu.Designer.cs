namespace Ejercicio1Final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bUniforme = new System.Windows.Forms.Button();
            this.bNormal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bUniforme
            // 
            this.bUniforme.Location = new System.Drawing.Point(159, 217);
            this.bUniforme.Name = "bUniforme";
            this.bUniforme.Size = new System.Drawing.Size(328, 38);
            this.bUniforme.TabIndex = 1;
            this.bUniforme.Text = "Uniforme";
            this.bUniforme.UseVisualStyleBackColor = true;
            this.bUniforme.Click += new System.EventHandler(this.bUniforme_Click);
            // 
            // bNormal
            // 
            this.bNormal.Location = new System.Drawing.Point(159, 261);
            this.bNormal.Name = "bNormal";
            this.bNormal.Size = new System.Drawing.Size(328, 38);
            this.bNormal.TabIndex = 4;
            this.bNormal.Text = "Normal";
            this.bNormal.UseVisualStyleBackColor = true;
            this.bNormal.Click += new System.EventHandler(this.bNormal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elija una distribución para la generación de numeros aleatorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "DISTRIBUCIONES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Evaluar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(678, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNormal);
            this.Controls.Add(this.bUniforme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bUniforme;
        private System.Windows.Forms.Button bNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

