using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1018Cedulas {
        static void Main() {
            //Declarando variáveis:
            int valorLido;
            int contador100 = 0;
            int contador50 = 0;
            int contador20 = 0;
            int contador10 = 0;
            int contador5 = 0;
            int contador2 = 0;
            int contador1 = 0;

            //Lendo o valor:
            valorLido = int.Parse(Console.ReadLine());

            //Imprimindo o valor:
            Console.WriteLine(valorLido);

            //Calculo:

            while(valorLido != 0) {
                if(valorLido >= 100) {
                    contador100++;
                    valorLido -= 100;
                } else if(valorLido >= 50) {
                    contador50++;
                    valorLido -= 50;
                } else if(valorLido >= 20) {
                    contador20++;
                    valorLido -= 20;
                }else if(valorLido >= 10) {
                    contador10++;
                    valorLido -= 10;
                }else if(valorLido >= 5) {
                    contador5++;
                    valorLido -= 5;
                }else if(valorLido >= 2) {
                    contador2++;
                    valorLido -= 2;
                }else if(valorLido >= 1) {
                    contador1++;
                    valorLido -= 1;
                }
            }
            //Saida

            Console.WriteLine($"{contador100} nota(s) de R$ 100,00");
            Console.WriteLine($"{contador50} nota(s) de R$ 50,00");
            Console.WriteLine($"{contador20} nota(s) de R$ 20,00");
            Console.WriteLine($"{contador10} nota(s) de R$ 10,00");
            Console.WriteLine($"{contador5} nota(s) de R$ 5,00");
            Console.WriteLine($"{contador2} nota(s) de R$ 2,00");
            Console.WriteLine($"{contador1} nota(s) de R$ 1,00");
        }
    }
}
