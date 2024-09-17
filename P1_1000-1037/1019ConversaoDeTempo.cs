using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1019ConversaoDeTempo {
        static void Main() {
            //Declarando as variáveis:
            int tempoDuracao;
            int horas = 0;
            int minutos = 0;
            int segundos = 0;

            //Lendo o valor de tempoDuracao:
            tempoDuracao = int.Parse(Console.ReadLine());

            //Calculo:
            while (tempoDuracao != 0) {
                if (tempoDuracao >= 3600) {
                    horas++;
                    tempoDuracao -= 3600;
                } else if (tempoDuracao >= 60) {
                    minutos++;
                    tempoDuracao -= 60;
                } else {
                    segundos += tempoDuracao;
                    tempoDuracao = 0;
                }
            }

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
