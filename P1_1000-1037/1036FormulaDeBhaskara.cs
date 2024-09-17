using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.P1_1000_1037 {
    internal class _1036FormulaDeBhaskara {
        static void Main() {
            //Declarando as variáveis:
            double A, B, C, delta, R1, R2;

            //Lendo as variáveis:
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0]);
            B = double.Parse(valores[1]);
            C = double.Parse(valores[2]);

            //Calculo
            delta = Math.Pow(B, 2) - ((4 * A) * C);
            R1 = (-Math.Abs(B) + Math.Sqrt(delta)) / (2 * A);
            R2 = (-Math.Abs(B) - Math.Sqrt(delta)) / (2 * A);

            if (A != 0 && delta >= 0) {
                Console.WriteLine($"R1 = {R1:f5}");
                Console.WriteLine($"R2 = {R2:f5}");
            } else {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
