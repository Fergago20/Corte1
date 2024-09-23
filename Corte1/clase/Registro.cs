using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.clase
{
    internal class Registro
    {
        Registro[] persona = new Registro[30];

        public static explicit operator Registro(Persona v)
        {
            throw new NotImplementedException();
        }
    }
}
