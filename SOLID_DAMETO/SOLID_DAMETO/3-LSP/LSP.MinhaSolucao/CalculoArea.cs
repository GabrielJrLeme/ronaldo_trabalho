using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DAMETO._3_LSP.LSP.MinhaSolucao
{
    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(FigGeometrica quadrado)
        {
            Console.Clear();
            Console.WriteLine("Area" + quadrado.Area());
            Console.WriteLine("Perímetro" + quadrado.Perimetro());
            Console.ReadKey();
        }

        public static void CalcularQudrado()
        {
            var quadrado = new Quadrado(40, 40);

            ObterAreaParalelogramo(quadrado);
        }

        public static void CalcularTrangulo()
        {
            var triangulo = new Triangulo(25, 15);

            ObterAreaParalelogramo(triangulo);
        }

    }
}
