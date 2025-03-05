using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Final.Formularios
{
    public partial class Grafico : Form
    {
        decimal[] listaLocal;

        public Grafico(decimal[] lista)
        {
            InitializeComponent();
            listaLocal = lista;
            rellenarLista();
            graficoValores.Series[0].Label = "Valores";
        }

        private void rellenarLista() //Carga la grilla con los valores de la lista y su repectivo indice (oreden de generacion)
        {
            int longitud = listaLocal.Length;
            for (int i = 0; i < longitud; i++)
            {
                grilla.Rows.Add(i + 1, listaLocal[i]);
            }
        }

        private int cantidadIntervalos() // seleccion de los intervalor por el combo-box
        {
            int num;

            if (rb5.Checked)
            {
                num = 5;
            }
            else if (rb10.Checked)
            {
                num = 10;
            }
            else if (rb15.Checked)
            {
                num = 15;
            }
            else
            {
                num = 20;
            }

            return num;
        }

        private bool verificarSeleccion()
        {
            if (rb5.Checked || rb10.Checked || rb15.Checked || rb20.Checked)
            {
                return true;
            }
            else return false;
        }

        private int[] asignarIntervalos(decimal[] minMax, int cantIntervalos) // recorre la lista local y cuenta la aparición de los nuemros en los intervalos desde hasta
        {
            int[] posiciones = new int[cantIntervalos];
            //DESCOMENTARIZAR en caso el -1
            decimal intervalo = (minMax[1] - minMax[0]) / (cantIntervalos); //Calcula la separacion que habra entre cada intervalo
            //decimal intervalo = (minMax[1] - minMax[0]) / (cantIntervalos -1); //Calcula la distancia que habra entre cada intervalo (desde - hasta)
            decimal intervaloMax = minMax[0] + intervalo; 
            decimal intervaloMin = minMax[0];
            for (int i = 0; i < cantIntervalos; i++)
            {
                for (int j = 0; j < listaLocal.Length; j++)
                {
                    if (listaLocal[j] < intervaloMax && listaLocal[j] >= intervaloMin)
                    {
                        posiciones[i] += 1; 
                    }
                }
                intervaloMin = intervaloMax;
                intervaloMax = intervaloMax + intervalo; 
            }
            return posiciones;
        }

        private decimal[] buscarMinMax() // busca los vaclores minimo y maximo respectivamente de la lista local
        {
            decimal min = listaLocal[0];
            decimal max = listaLocal[0];
            decimal[] resultados = new decimal[2];

            for (int i = 0; i < listaLocal.Length; i++)
            {
                if (listaLocal[i] > max)
                {
                    max = listaLocal[i];
                }
                if (listaLocal[i] < min)
                {
                    min = listaLocal[i];
                }
            }

            resultados[0] = min;
            resultados[1] = max;
            return resultados;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (verificarSeleccion())
            {
                graficoValores.Series.Clear(); // limpia el grafico
                graficoValores.Series.Add("Valores"); 
                decimal[] minMax = buscarMinMax(); // llama a la funcion para buscarl los vlores minimos y maximo de la lista local
                int cantIntervalos = cantidadIntervalos(); // devuelve el valor del combo que se a seleccionado
                decimal intervalo = (minMax[1] - minMax[0]) / (cantIntervalos - 1); //distncia entre intervalos
                int[] valores = asignarIntervalos(minMax, cantIntervalos); // Devuelve la aparicion de los valores de la lista en los intervalos (desde - hasta) que se muetran en la leyenda del grafico

                for (int i = 0; i < cantIntervalos; i++)
                {
                    decimal min = decimal.Round(minMax[0] + (i * intervalo), 4); // valor minimo de la lista local
                    decimal max = decimal.Round(minMax[0] + ((i + 1) * intervalo), 4); // calor max de la lista local
                    string nombreIntervalo = (i + 1).ToString() + ": " + (min).ToString() + "-" + (max).ToString();
                    graficoValores.Series.Add(nombreIntervalo); //Crea los valores de la leyenda del grafico
                    graficoValores.Series[0].Points.AddXY((double) (i+1), (double)valores[i]); //Asigna los valores del eje x (Intervalos) e y (apricion de los numeros en los intervalos) al grafico 
                }

            }

        }
    }
}
