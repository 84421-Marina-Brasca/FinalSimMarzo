using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3_proyecto.Formularios;

namespace TP3_proyecto.Formularios
{
    public partial class Uniforme : Form
    {
        decimal[] lista;
        decimal[] minMax = new decimal[2];

        readonly string filePath = "./uniforme.txt"; // ME LO GUARDA EN ./bin/Debug/uniforme.txt

        public Uniforme()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!verificarEntradas())
                return;
            
            double nroRandom;
            var rand = new Random();
            int cantidad = int.Parse(txtCantidad.Text);
            lista = new decimal[cantidad]; //Crea una lista con la cantidad de nros que se van a generar

            grilla.Rows.Clear();
            var writer = new StreamWriter(filePath);

            try
            {
                for (int i = 0; i < cantidad; i++)
                {
                    int limiteA = int.Parse(txtLimiteA.Text);
                    int limiteB = int.Parse(txtLimiteB.Text);
                    nroRandom = Math.Round(rand.NextDouble(), 4); // Genera un numero random que se utilizara para generar una distribucion uniforme
                    decimal x = (decimal)(limiteA + nroRandom * (limiteB - limiteA)); // Genera un numero aleatorio con distribucion uniforme usando la formula 𝑋 = 𝐴 + 𝑅𝑁𝐷(𝐵 − 𝐴)
                    x = decimal.Round(x, 4);

                    lista[i] = x;

                    var outputNumber = x.ToString();
                    if (i != 0)
                        outputNumber = string.Concat(",", outputNumber);

                    grilla.Rows.Add(i + 1, nroRandom, x); // Agrega una fila a la grilla con los valores de la iteracion, RND y el valor de la ditribusion uniforme
                    
                    writer.Write(outputNumber);
                }
            }
            finally
            {
                writer.Close();
            }
        }

        private bool verificarEntradas()
        {
            if (!decimal.TryParse(txtLimiteA.Text, out decimal resultado1))
            {
                MessageBox.Show("Ingrese correctamente el Limite A");
                return false;
            }

            if (!decimal.TryParse(txtLimiteB.Text, out decimal resultado2))
            {
                MessageBox.Show("Ingrese correctamente el Limite B");
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int resultado3) || resultado3 <= 0)
            {
                MessageBox.Show("Ingrese correctamente la cantidad de variables aleatorias");
                return false;
            }

            int A = int.Parse(txtLimiteA.Text);
            int B = int.Parse(txtLimiteB.Text);

            if (A >= B)
            {
                MessageBox.Show("El valor de A tiene que ser menor y distinto al valor de B");
                return false;
            }

            if (A == 0 && B == 1)
            {
                MessageBox.Show("Los valores A y B no pueden ser 0 y 1 respectivamente");
                return false;
            }
            // se obtiene de los valores generados el minimos y maximos que se usaran para Chi
            minMax[0] = A;
            minMax[1] = B;
            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            Grafico grafico = new Grafico(lista);
            grafico.Show();
        }

        private void btnChi_Click(object sender, EventArgs e)
        {
            TestChiYKS test = new TestChiYKS(lista, 1, minMax, 0);
            test.Show();
        }

        // los métodos "KeyPress" sirven solo para que el usuario no ingrese letras o simbolos
        private void txtLimiteA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar decimales
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLimiteB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar decimales
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar decimales
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


    }
}
