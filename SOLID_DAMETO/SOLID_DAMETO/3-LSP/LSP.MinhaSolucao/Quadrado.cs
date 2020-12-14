using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DAMETO._3_LSP.LSP.MinhaSolucao
{
    public class Quadrado : FigGeometrica
    {

        public Quadrado(int altura, int largura) : base(altura, largura)
        {
        }


        public override double Area()
        {
            return Altura * Largura;
        }

        public override double Perimetro()
        {
            return ((Altura * 2) * (Largura * 2));
        }
    }

}
