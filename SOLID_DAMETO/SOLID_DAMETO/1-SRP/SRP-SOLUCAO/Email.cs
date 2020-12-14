using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DAMETO._1_SRP.SRP_SOLUCAO
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}
