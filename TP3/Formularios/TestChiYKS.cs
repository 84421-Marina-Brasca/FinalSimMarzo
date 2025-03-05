using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_proyecto.Formularios
{
    public partial class TestChiYKS : Form
    {
        bool band_Ok = false;
        decimal[] listaLocal;
        int distribucionLocal;
        // 0 = normal , 1 = uniforme
        decimal[] minMaxLocal = new decimal[2];
        decimal parametro;

        public TestChiYKS(decimal[] lista, int distribucion, decimal[] minMax, decimal parametroI)
        {
            InitializeComponent();
            dgvSerie.Rows.Clear();
            distribucionLocal = distribucion;
            minMaxLocal = minMax;
            listaLocal = new decimal[lista.Length];
            parametro = parametroI;
            for (int i = 0; i < lista.Length; i++)
            {
                listaLocal[i] = lista[i];
                dgvSerie.Rows.Add(listaLocal[i]);

            }
            //????

        }

        private void validarIngreso()
        {
            if (!rb5.Checked && !rb10.Checked && !rb15.Checked && !rb20.Checked)
            {
                MessageBox.Show("Debe Seleccionar un Intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (band_Ok == false)
            {
                band_Ok = true;
            }

        }

        private int cantidadIntervalos()
        {
            int num;

            if (rb5.Checked)
                num = 5;
            else if (rb10.Checked)
                num = 10;
            else if (rb15.Checked)
                num = 15;
            else
                num = 20;
            
            txt_gradoslibertad.Text = calcularGradosDeLibertad(num).ToString();

            return num;
        }

        public int calcularGradosDeLibertad(int nroIntervalos)
        {
            if (distribucionLocal == 0)
                return nroIntervalos - 3;
            
            return nroIntervalos - 1;
        }

        public decimal[] generarIntervalos(out decimal[] marcasDeClase, out decimal[] desde, out decimal[] hasta, out decimal tamañoIntervalo)
        {
            int num = cantidadIntervalos();
            marcasDeClase = new decimal[num];
            desde = new decimal[num];
            hasta = new decimal[num];
            decimal[] intervalos = new decimal[num];

            tamañoIntervalo = (minMaxLocal[1] - minMaxLocal[0]) / ((decimal)num);

            decimal intervaloMax = minMaxLocal[0] + tamañoIntervalo;
            decimal intervaloMin = minMaxLocal[0];

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < listaLocal.Length; j++)
                {
                    //if ((i == 0 && listaLocal[j] < intervaloMax ) || ( i == 0 && listaLocal[j] == minMaxLocal[1]))
                    //    intervalos[i] += 1;
                    /*else*/ if (listaLocal[j] < intervaloMax && listaLocal[j] >= intervaloMin)
                        intervalos[i] += 1;
                }

                marcasDeClase[i] = (intervaloMax + intervaloMin) / 2;
                desde[i] = intervaloMin;
                hasta[i] = intervaloMax;

                intervaloMin = intervaloMax;
                intervaloMax += tamañoIntervalo;
            }
            
            return intervalos;
        }


        private decimal[] calcularFe(int numeroIntervalos, decimal[] x, decimal anchoIntervalo)
        {
            decimal[] fe = new decimal[numeroIntervalos];
            int n = listaLocal.Length;

            if (distribucionLocal == 0)
            {
                decimal suma = 0;
                for (int j = 0; j < n; j++)
                    suma += listaLocal[j];

                decimal media = suma/n;

                for (int i = 0; i < numeroIntervalos; i++)
                {
                    double e = ((-0.5) * Math.Pow((double)((x[i] - media) / parametro),2));
                    fe[i] = (decimal)Math.Exp(e) / (parametro * (decimal)Math.Sqrt(2 * Math.PI)) * anchoIntervalo * n;
                }

                return fe;
            }
            else if (distribucionLocal == 1)
            {
                decimal valor = (1 / (minMaxLocal[1] - minMaxLocal[0])) * anchoIntervalo * n;
                decimal feT = Math.Round(valor, 4);
                for (int i = 0; i < numeroIntervalos; i++)
                    fe[i] = feT;

                return fe;
            }

            for (int i = 0; i < numeroIntervalos; i++)
            {
                decimal valor = parametro * (decimal)Math.Exp(-(double)(parametro * x[i])) * anchoIntervalo * n;
                fe[i] = Math.Round(valor, 4);
            }

            return fe;
        }

        private void ajustarIntervalos(decimal[] fe, decimal[] fo, decimal[] desde, decimal[] hasta, out decimal[] feResultado, out decimal[] foResultado, out decimal[] desdeResultado, out decimal[] hastaResultado)
        {
            List<decimal> feIntermedio = new List<decimal>();
            List<decimal> foIntermedio = new List<decimal>();
            List<decimal> desdeIntermedio = new List<decimal>();
            List<decimal> hastaIntermedio = new List<decimal>();

            feIntermedio.AddRange(fe);
            foIntermedio.AddRange(fo);
            desdeIntermedio.AddRange(desde);
            hastaIntermedio.AddRange(hasta);

            int contador = 0;
            while (contador <= feIntermedio.Count / 2)
            {
                while (feIntermedio[contador] < 5 && feIntermedio.Count > 1)
                {
                    feIntermedio[contador] += feIntermedio[contador + 1];
                    foIntermedio[contador] += foIntermedio[contador + 1];
                    hastaIntermedio[contador] = hastaIntermedio[contador + 1];

                    feIntermedio.RemoveAt(contador + 1);
                    foIntermedio.RemoveAt(contador + 1);
                    hastaIntermedio.RemoveAt(contador + 1);
                    desdeIntermedio.RemoveAt(contador + 1);
                }

                while (feIntermedio[feIntermedio.Count - (contador + 1)] < 5 && feIntermedio.Count > 1)
                {
                    feIntermedio[feIntermedio.Count - (contador + 1)] += feIntermedio[feIntermedio.Count - (contador + 2)];
                    foIntermedio[foIntermedio.Count - (contador + 1)] += foIntermedio[foIntermedio.Count - (contador + 2)];
                    desdeIntermedio[feIntermedio.Count - (contador + 1)] = desdeIntermedio[feIntermedio.Count - (contador + 2)];

                    feIntermedio.RemoveAt(feIntermedio.Count - (contador + 2));
                    foIntermedio.RemoveAt(foIntermedio.Count - (contador + 2));
                    desdeIntermedio.RemoveAt(desdeIntermedio.Count - (contador + 2));
                    hastaIntermedio.RemoveAt(hastaIntermedio.Count - (contador + 2));
                }

                contador += 1;
            }

            feResultado = feIntermedio.ToArray();
            foResultado = foIntermedio.ToArray();
            desdeResultado = desdeIntermedio.ToArray();
            hastaResultado = hastaIntermedio.ToArray();
        }


        private void CargarFrecuenciasKS(decimal[] fo, decimal[] fe, decimal[] desde, decimal[] hasta)
        {
            var n = fo.Sum();
            decimal PoAc = 0;
            decimal PeAc = 0;
            decimal MaxKS = -1;


            decimal sumC = 0;
            for (int i = 0; i < fo.Length; i++)
            {
                var Po = fo[i] / n;
                PoAc += Po;
                var Pe = fe[i] / n;
                PeAc += Pe;

                var KS = Math.Abs(PoAc - PeAc);
                if (KS > MaxKS)
                    MaxKS = KS;

                dgvKS.Rows.Add(Math.Round(desde[i], 4), Math.Round(hasta[i], 4), Math.Round(fo[i], 4), Math.Round(fe[i], 4), Math.Round(Po, 4), Math.Round(PoAc, 4), Math.Round(Pe, 4), Math.Round(PeAc, 4), Math.Round(KS, 4), Math.Round(MaxKS,4));
            }
        }

        private void CargarFrecuenciasChi(decimal[] fo, decimal[] fe, decimal[] desde, decimal[] hasta)
        {
            decimal sumC = 0;
            for (int i = 0; i < fo.Length; i++)
            {
                decimal c = (decimal)Math.Pow((double)(fe[i]-fo[i]), 2) / fe[i];
                sumC += c;
                dgvChi.Rows.Add(Math.Round(desde[i], 4), Math.Round(hasta[i], 4), Math.Round(fo[i], 4), Math.Round(fe[i], 4), Math.Round(c, 4), Math.Round(sumC, 4));
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            validarIngreso();
            dgvChi.Rows.Clear();
            dgvKS.Rows.Clear();

            var n = 0;

            if (band_Ok)
            {
                decimal[] intervalos = generarIntervalos(out decimal[] marcasDeClase, out decimal[] desde, out decimal[] hasta, out decimal anchoIntervalo);
                decimal[] fe = calcularFe(intervalos.Length, marcasDeClase, anchoIntervalo);

                CargarFrecuenciasKS(intervalos, fe, desde, hasta);

                dgvKS.Visible = true;
                ajustarIntervalos(fe,intervalos, desde, hasta, out decimal[] feRe, out decimal[] foRe, out decimal[] desdeRe, out decimal[] hastaRe);

                CargarFrecuenciasChi(foRe, feRe, desdeRe, hastaRe);
                int nroFila = dgvChi.RowCount;
                var ValorAcumulado = dgvChi.Rows[nroFila - 2].Cells[5].Value.ToString();
                var MaxKS = dgvKS.Rows[nroFila - 2].Cells[9].Value.ToString();

                txt_calculado_Chi.Text = ValorAcumulado;
                txt_calculado_KS.Text = MaxKS;

                n = (int) intervalos.Sum();
            }

            validarHipotesis(n);
        }

        private void validarHipotesis(int n)
        {
            var result = new StringBuilder();

            double calculado = Convert.ToDouble(txt_calculado_Chi.Text);
            double chiTab = Math.Round(ChiSquared.InvCDF(int.Parse(txt_gradoslibertad.Text), 0.95), 4);

            result.Append(calculado >= chiTab
                ? $"El valor chi tabulado es de {chiTab} y es MENOR al calculado por lo tanto se RECHAZA la hipotesis"
                : $"El valor chi tabulado es de {chiTab} y es MAYOR al calculado por lo tanto se ACEPTA la hipotesis");

            result.Append("\n").Append("\n");

            var KStab = Math.Round(1.36 / Math.Sqrt(n), 4);
            result.Append(KStab < Convert.ToDouble(txt_calculado_KS.Text)
                ? $"El valor KS tabulado es de {KStab} y es MENOR al calculado por lo tanto se RECHAZA la hipotesis"
                : $"El valor KS tabulado es de {KStab} y es MAYOR al calculado por lo tanto se ACEPTA la hipotesis");

            MessageBox.Show(result.ToString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // los métodos "KeyPress" sirven solo para que el usuario no ingrese letras o simbolos
        private void txt_gradoslibertad_KeyPress(object sender, KeyPressEventArgs e)
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
