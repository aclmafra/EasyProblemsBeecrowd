using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1020IdadeEmDias {
        static void Main() {
            //Declarando as variáveis:
            int idade;
            int anos = 0;
            int meses = 0;
            int dias = 0;

            //Lendo o valor da variável idade:
            idade = int.Parse(Console.ReadLine());

            //Cálculo:
            while (idade != 0) {
                if(idade >= 365) {
                    anos++;
                    idade -= 365;
                }else if (idade >= 30) {
                    meses++;
                    idade -= 30;
                }else {
                    dias += idade;
                    idade = 0;
                }
            }
            
            Console.WriteLine($"{anos} ano (s)");
            Console.WriteLine($"{meses} mes (es)");
            Console.WriteLine($"{dias} dia (s)");
        }
    }
}
