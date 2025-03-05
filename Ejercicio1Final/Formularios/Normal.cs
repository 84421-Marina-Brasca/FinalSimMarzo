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
using Ejercicio1Final.Formularios;


namespace Ejercicio1Final.Formularios
{
    public partial class Normal : Form
    {
        decimal[] lista;
        decimal[] minMax = new decimal[2];
        double desviacion;

        readonly string filePath = "./normal.txt"; // ME LO GUARDA EN ./bin/Debug/normal.txt

        public Normal()
        {
            InitializeComponent();
        }

        private bool verificarEntradas()
        {
            if (!double.TryParse(txtMedia.Text, out double resultado1))
            {
                MessageBox.Show("Ingrese correctamente el parametro Cantidad");
                return false;
            }

            if (!double.TryParse(txtVarianza.Text, out double resultado2) || resultado2 <= 0)
            {
                MessageBox.Show("Ingrese correctamente el parametro Varianza");
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int resultado3) || resultado3 <= 0)
            {
                MessageBox.Show("Ingrese correctamente la cantidad de variables aleatorias");
                return false;
            }
            return true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (verificarEntradas())
            {
                Random random = new Random();
                int cantidad = int.Parse(txtCantidad.Text);
                double media = double.Parse(txtMedia.Text);
                desviacion = (double)decimal.Parse(Math.Sqrt(double.Parse(txtVarianza.Text)).ToString());
                lista = new decimal[cantidad];

                grilla.Rows.Clear();
                var writer = new StreamWriter(filePath);

                //Box-Muller

                // se generan los primeros dos random para Box-Muller
                double random1 = random.NextDouble();
                double random2 = random.NextDouble();
                string outputNumber = "";

                try
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (i % 2 == 0)
                        {
                            string n1s = (Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2) * desviacion + media).ToString(); //Genera un nuemero con distribucion normal usando la 1ra formula de box-muller
                            decimal n1 = decimal.Round(decimal.Parse(n1s), 4);
                            lista[i] = n1; //Inserta el numero generado de la distribucionen la lista

                            // se obtiene los valores minimos y maximos generados para Chi
                            if (i == 0)
                            {
                                minMax[0] = n1;
                                minMax[1] = n1;
                            }
                            else
                            {
                                if (n1 < minMax[0]) minMax[0] = n1;
                                if (n1 > minMax[1]) minMax[1] = n1;
                            }

                            grilla.Rows.Add(i + 1, Math.Round(random1, 4) + "  -  " + Math.Round(random2, 4), n1);

                            outputNumber = n1.ToString();
                            if (i != 0)
                                outputNumber = string.Concat(",", n1);
                        }
                        else
                        {
                            string n2s = (Math.Sqrt(-2 * Math.Log(random1)) * Math.Sin(2 * Math.PI * random2) * desviacion + media).ToString(); //Genera otro nuemero con distribucion normal usando la 2da formula de box-muller
                            decimal n2 = decimal.Round(decimal.Parse(n2s), 4);
                            lista[i] = n2; //Inserta el numero generado de la distribucionen en la lista

                            // se obtiene los valores minimos y maximos generados para Chi
                            if (i == 0)
                            {
                                minMax[0] = n2;
                                minMax[1] = n2;
                            }
                            else
                            {
                                if (n2 < minMax[0]) minMax[0] = n2;
                                if (n2 > minMax[1]) minMax[1] = n2;
                            }

                            grilla.Rows.Add(i + 1, Math.Round(random1, 4) + "  -  " + Math.Round(random2, 4), n2);

                            outputNumber = n2.ToString();
                            if (i != 0)
                                outputNumber = string.Concat(",", n2);
                        }

                        // Genera los siguientes dos numeros rnd que se usaran para la distribucion normal con box-muller
                        random1 = random.NextDouble();
                        random2 = random.NextDouble();

                        writer.Write(outputNumber);
                    }
                }
                finally
                {
                    writer.Close();
                }
            }
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
            TestChiYKS test = new TestChiYKS(lista, 0, minMax, (decimal) desviacion);
            test.Show();
        }


        // los métodos "KeyPress" sirven solo para que el usuario no ingrese letras o simbolos
        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVarianza_KeyPress(object sender, KeyPressEventArgs e)
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
