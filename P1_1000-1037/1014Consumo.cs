using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1014Consumo {
        static void Main() {
            //Declarando variáveis:
            int KmPercorrida;
            double TotalCombGasto, resultado;

            KmPercorrida = int.Parse(Console.ReadLine());
            TotalCombGasto = double.Parse(Console.ReadLine());

            //Calculo
            resultado = KmPercorrida / TotalCombGasto;

            //Saida
            Console.WriteLine($"{resultado:f3} km/l");
        }
    }
}
