using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.clase
{
    internal class Operacion
    {
        public DateTime Nacimiento { get; set; }
        public int Calcular(DateTime nacimiento)
        {
            int edad;
            edad= DateTime.Now.Year - nacimiento.Year;
            return edad;
        }
        public string Medir (int edad)
        {
            if(edad < 18 && edad >=0)
            {
                return "Es menor de edad";
            }else if(edad >= 18 && edad <= 120)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Rango no admitido";
            }
        }
    }
}
