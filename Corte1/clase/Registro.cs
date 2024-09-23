using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.clase
{
    internal class Registro
    {
        Persona[] per = new Persona[30];
        public int indice =0;
        public void AgregarPer(Persona persona)
        {
            per[indice] = persona;
            indice++;
        }

        public Persona[] ObtenerPersonas()
        {
            Persona[] PersonasReg = new Persona[indice];
            for (int i = 0; i < indice; i++)
            {
                PersonasReg[i] = per[i];
            }
            return PersonasReg;
        }
    }
}
