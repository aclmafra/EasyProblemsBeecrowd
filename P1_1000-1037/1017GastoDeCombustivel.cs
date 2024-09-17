using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1017GastoDeCombustivel {
        static void Main() {
            //Declarando as variáveis:
            int KmCarro = 12;
            int TempoGasto, Vm, DistanciaPercorrida;
            double Litros;

            //Lendo TempoGasto e Vm:
            TempoGasto = int.Parse(Console.ReadLine());
            Vm = int.Parse(Console.ReadLine());

            //Calculo
            DistanciaPercorrida = Vm * TempoGasto;
            Litros = (double) DistanciaPercorrida / 12;//12 se refere a km do veículo da atvdd por litro.

            //Saida
            Console.WriteLine($"{Litros:f3}");
        }
    }
}
