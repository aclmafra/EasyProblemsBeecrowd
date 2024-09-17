using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1016Distancia {
        static void Main() {
            //Declarando as variáveis:
            int CarroX = 60;
            int CarroY = 90;
            double DifVelocidade = CarroY - CarroX;
            double Tempo;
            int DistanciaKm;

            //Lendo a distância.
            DistanciaKm = int.Parse(Console.ReadLine());

            //Calculo
            Tempo = (double) (DistanciaKm / DifVelocidade) * 60;

            //Saida
            Console.WriteLine($"{Tempo} minutos");
        }
    }
}
