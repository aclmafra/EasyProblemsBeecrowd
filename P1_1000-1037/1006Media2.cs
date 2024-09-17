using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1006Media2 {
        static void Main() {
            // Leitura das notas
            double A = LerNota("A");
            double B = LerNota("B");
            double C = LerNota("C");

            // Cálculo da média ponderada
            double MEDIA = ((A*2) + (B*3) + (C*5)) /10;

            // Impressão da média formatada
            Console.WriteLine($"MEDIA = {MEDIA:F1}");
        }

        static double LerNota(string notaNome) {
            double nota;
            bool notaValida;
            do {
                Console.WriteLine($"Digite a nota {notaNome} (entre 0 até 10.0):");
                notaValida = double.TryParse(Console.ReadLine(), out nota);

                if (!notaValida || nota < 0.0 || nota > 10.0) {
                    Console.WriteLine("Valor inválido, insira um número entre 0 a 10.");
                    notaValida = false;
                }

            } while (!notaValida);

            return nota;
        }

        
    }
}
