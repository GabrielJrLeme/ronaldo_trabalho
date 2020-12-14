using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DAMETO._3_LSP.LSP.MinhaSolucao
{
    public class Triangulo : FigGeometrica
    {
        public Triangulo(int altura, int largura) : base(altura, largura)
        {
        }

        public override double Area()
        {
            return (Altura * Largura) * 2;
        }

        public override double Perimetro()
        {
            return ((Altura * 2) + Largura);
        }
    }
}
