using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DAMETO._1_SRP.SRP_SOLUCAO
{
    public class Cpf
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}
