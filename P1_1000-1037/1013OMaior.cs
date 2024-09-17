using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1013OMaior {
        static void Main() {
            //Declarando as variáveis:
            int A, B, C, MaiorAB, MaiorABC;

            string[] Numeros = Console.ReadLine().Split(' ');
            A = int.Parse(Numeros[0]);
            B = int.Parse(Numeros[1]);
            C = int.Parse(Numeros[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;

            MaiorABC = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine($"{MaiorABC} eh o maior");
        }
    }
}
