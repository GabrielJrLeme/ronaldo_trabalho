using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DAMETO._3_LSP.LSP.MinhaSolucao
{
    public class FigGeometrica
    {

        public FigGeometrica(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Largura { get; set; }

        public double Altura { get; set; }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimetro()
        {
            return 0;
        }

    }
}
