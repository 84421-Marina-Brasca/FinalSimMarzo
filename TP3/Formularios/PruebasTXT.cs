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

namespace TP3_proyecto.Formularios
{
    public partial class PruebasTXT : Form
    {
        decimal[] lista;

        public PruebasTXT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                openFileDialog.Title = "Seleccionar archivo TXT";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Leer el contenido del archivo
                        string contenido = File.ReadAllText(openFileDialog.FileName);
                        lista = contenido.Split(',').Select(n => decimal.Parse(n)).ToArray();
                        rellenarLista();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                    }
                }
            }
        }
        private void rellenarLista() //Carga la grilla con los valores de la lista y su repectivo indice (oreden de generacion)
        {
            int longitud = lista.Length;
            for (int i = 0; i < longitud; i++)
            {
                grilla.Rows.Add(i + 1, lista[i]);
            }
        }

        private void graficar_Click(object sender, EventArgs e)
        {
            Grafico grafico = new Grafico(lista);
            grafico.Show();
        }

        private void probarNormal_Click(object sender, EventArgs e)
        {
            ConseguirVariablesNormal(out decimal[] minMax, out decimal desviacion);
            TestChiYKS test = new TestChiYKS(lista, 0, minMax, desviacion);
            test.Show();
        }

        void ConseguirVariablesNormal(out decimal[] minMax, out decimal desviacion)
        {
            minMax = new decimal[2];
            decimal acu = 0;

            foreach (var n in lista)
            {
                if (n < minMax[0])
                    minMax[0] = n;

                if (n > minMax[1])
                    minMax[1] = n;

                acu += n;
            }

            decimal media = acu / lista.Length;
            decimal acuDifMedia = 0;

            foreach (var n in lista)
                acuDifMedia += (decimal) Math.Pow((double)(n-media), 2);

            desviacion = (decimal)Math.Pow((double)(1/(lista.Length-1) * acuDifMedia), 1/2);
        }

        private void probarUniforme_Click(object sender, EventArgs e)
        {
            ConseguirVariablesUniforme(out decimal[] minMax);
            TestChiYKS test = new TestChiYKS(lista, 1, minMax, 0);
            test.Show();
        }

        void ConseguirVariablesUniforme(out decimal[] minMax)
        {
            minMax = new decimal[2] { int.MaxValue, int.MinValue };
            foreach(var n in lista)
            {
                if (n < minMax[0])
                    minMax[0] = n;

                if (n > minMax[1])
                    minMax[1] = n;
            }
        }
    }
}
