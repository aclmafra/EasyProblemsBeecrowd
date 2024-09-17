using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1007Diferenca {
        static void Main() {
            //Declaração de múltiplas variáveis
            int A, B, C, D, DIFERENCA;

            //Lendo os valores
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            //Definindo a diferença:
            DIFERENCA = (A * B - C * D);

            //Resultado da diferença:
            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
        }
    }
}
