using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.P1_1000_1037 {
    internal class _1037Intervalo {
        static void Main() {

            //Declarando as variáveis:
            double valor;

            //Lendo a variável valor:
            valor = double.Parse(Console.ReadLine());

            //Saida:
            if (valor >= 0.0 && valor <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            } else if (valor > 25.0 && valor <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            } else if (valor > 50.0 && valor <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            } else if (valor > 75.0 && valor <= 100.0) {
                Console.WriteLine("Intervalo (75,100]");
            } else {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
