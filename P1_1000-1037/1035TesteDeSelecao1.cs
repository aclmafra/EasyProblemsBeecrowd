using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.P1_1000_1037 {
    internal class _1035TesteDeSelecao1 {
        static void Main() {
            //Declarando variáveis:
            int A, B, C, D;

            //Lendo as variáveis:
            string[] valores = Console.ReadLine().Split(' ');

            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);
            D = int.Parse(valores[3]);

            //Resolução/Saída
            if (B > C && D > A && (C + D) > (A + B) &&
            C >= 0 && D >= 0 && (A % 2 == 0)) {
                Console.WriteLine("Valores aceitos");
            } else {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
