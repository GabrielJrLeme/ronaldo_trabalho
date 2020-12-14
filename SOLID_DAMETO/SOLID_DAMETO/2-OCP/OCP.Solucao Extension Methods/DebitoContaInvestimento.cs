﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DAMETO._2_OCP.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta investimento.
            return debitoConta.FormatarTransacao();
        }
    }
}
