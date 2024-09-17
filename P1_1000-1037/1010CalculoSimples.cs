using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1010CalculoSimples {
        static void Main() {
            //Declarando as variáveis:
            int Peca1, Peca2, NumPeca1, NumPeca2;
            double ValorUnitP1, ValorUnitP2;
            double ValorFinal;

            //Lendo os valores das variáveis:
            string[] entradaPeca1 = Console.ReadLine().Split(' ');
            Peca1 = int.Parse(entradaPeca1[0]);
            NumPeca1 = int.Parse(entradaPeca1[1]);
            ValorUnitP1 = double.Parse(entradaPeca1[2]);

            string[] entradaPeca2 = Console.ReadLine().Split(' ');
            Peca2 = int.Parse(entradaPeca2[0]);
            NumPeca2 = int.Parse(entradaPeca2[1]);
            ValorUnitP2 = double.Parse(entradaPeca2[2]);

            //Calculando o valor final a ser pago:
            ValorFinal = (NumPeca1 * ValorUnitP1) + (NumPeca2 * ValorUnitP2);

            //Saida:
            Console.WriteLine($"VALOR A PAGAR: R$ {ValorFinal:F2}");

        }
    }
}
