using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_proyecto.Clases
{
    class NumerosAleatorios
    {
        public string nombre;
        public int[] numeros;
        public int[] valores;

        public NumerosAleatorios(string nombre, int[] numeros, int[] valores)
        {
            this.nombre = nombre;
            this.numeros = numeros;
            this.valores = valores;
        }
    }
}
