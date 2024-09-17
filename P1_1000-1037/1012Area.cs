using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1012Area {
        static void Main() {
            double A, B, C;
            double pi = 3.14159;
            double AreaTriangulo, AreaCirculo, AreaTrapezio, AreaQuadrado, AreaRetangulo;

            //Lendo os valores:
            string[] Dimensoes = Console.ReadLine().Split(' ');
            A = double.Parse(Dimensoes[0]);
            B = double.Parse(Dimensoes[1]);
            C = double.Parse(Dimensoes[2]);

            //a área do triângulo retângulo que tem A por base e C por altura.
            AreaTriangulo = (A * C) / 2;

            // a área do círculo de raio C. (pi = 3.14159)
            AreaCirculo = pi * Math.Pow(C, 2);

            //a área do trapézio que tem A e B por bases e C por altura.
            AreaTrapezio = ((A + B) * C) / 2;

            //a área do quadrado que tem lado B.
            AreaQuadrado = Math.Pow(B, 2);

            //a área do retângulo que tem lados A e B.
            AreaRetangulo = A * B;

            //Saida
            Console.WriteLine($"TRIANGULO: {AreaTriangulo:F3}");
            Console.WriteLine($"CIRCULO: {AreaCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {AreaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {AreaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {AreaRetangulo:F3}");
        }
    }
}
