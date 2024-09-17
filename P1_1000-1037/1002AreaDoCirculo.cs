using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1002 {

        static void Main() {
            //A fórmula para calcular a área de uma circunferência é:
            //area = π . raio2. Considerando para este problema que π = 3.14159.

            double area, n, raio;
            n = 3.14159;

            //Lendo o valor de entrada e convertendo string para double
            raio = Double.Parse(Console.ReadLine());

            //Calculando a area
            area = n * Math.Pow(raio, 2);

            //Formatando a saida
            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}
