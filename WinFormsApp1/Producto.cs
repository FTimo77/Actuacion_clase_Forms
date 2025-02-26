using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Producto
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int resultado { get; set; }
        public bool sumar { get; set; }
        public bool restar { get; set; }

        public int calcular()
        {
            if (sumar)
            {
                resultado = num1 + num2;
            }
            else if (restar)
            {
                resultado = num1 - num2;
            }
            return resultado;
        }
    }
}
