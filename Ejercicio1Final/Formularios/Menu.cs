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

namespace Ejercicio1Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bUniforme_Click(object sender, EventArgs e)
        {
            Uniforme uniforme = new Uniforme();
            uniforme.Show();
        }

        private void bNormal_Click(object sender, EventArgs e)
        {
            Normal normal = new Normal();
            normal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PruebasTXT pruebasTXT = new PruebasTXT();
            pruebasTXT.Show();
            
        }
    }
}
