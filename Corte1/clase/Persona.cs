using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.clase
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apelido { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Ciudad {  get; set; }

        public Persona (string nombre, string apelido, DateTime nacimiento, string ciudad)
        {
            Nombre = nombre;
            Apelido = apelido;
            Nacimiento = nacimiento;
            Ciudad = ciudad;
        }
    }
}
