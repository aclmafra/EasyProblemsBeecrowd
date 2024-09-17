using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1011Esfera {
        static void Main() {
            //Declarando variáveis
            double volume, raio, pi;
            pi = 3.14159;

            //Lendo o valor de raio:
            raio = double.Parse(Console.ReadLine());

            //Volume da esfera:
            volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

            //Saida:
            Console.WriteLine($"VOLUME = {volume:F3}");
        }
    }
}
