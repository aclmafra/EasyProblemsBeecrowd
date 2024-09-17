using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1015DistanciaEntreDoisPontos {
        static void Main() {

            //Declarando as variáveis 
            double x1, x2;
            double y1, y2;
            double resultado;

            //Recebendo os dados:
            string[] Numrs1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(Numrs1[0]);
            y1 = double.Parse(Numrs1[1]);

            string[] Numrs2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(Numrs2[0]);
            y2 = double.Parse(Numrs2[1]);

            //Calculo
            resultado = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

            //Saida
            Console.WriteLine($"{resultado:f4}");
        }
    }
}
