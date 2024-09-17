using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1021NotasEMoedas {
        static void Main() {

            // Declarando as variáveis:
            double valorMonetario;

            int nota100 = 0, nota50 = 0, nota20 = 0,
                nota10 = 0, nota5 = 0, nota2 = 0;

            int moeda1 = 0, moeda0_50 = 0, moeda0_25 = 0,
                moeda0_10 = 0, moeda0_05 = 0, moeda0_01 = 0;

            // Lendo o valor da variável valorMonetario:
            while (true) {
                string entrada = Console.ReadLine();

                // Verificando se a entrada não é nula e é válida
                if (!string.IsNullOrEmpty(entrada) 
                    && double.TryParse(entrada, out valorMonetario)) {
                    if (valorMonetario >= 0 && valorMonetario <= 1000000.00) {
                        break; // Se o valor estiver no intervalo, sai do loop
                    }
                }
            }

            // Convertendo o valor para centavos
            int valorCentavos = (int)Math.Round(valorMonetario * 100);

            // Cálculo:
            while (valorCentavos != 0) {
                if (valorCentavos >= 10000) {
                    nota100++;
                    valorCentavos -= 10000;
                } else if (valorCentavos >= 5000) {
                    nota50++;
                    valorCentavos -= 5000;
                } else if (valorCentavos >= 2000) {
                    nota20++;
                    valorCentavos -= 2000;
                } else if (valorCentavos >= 1000) {
                    nota10++;
                    valorCentavos -= 1000;
                } else if (valorCentavos >= 500) {
                    nota5++;
                    valorCentavos -= 500;
                } else if (valorCentavos >= 200) {
                    nota2++;
                    valorCentavos -= 200;
                } else if (valorCentavos >= 100) {
                    moeda1++;
                    valorCentavos -= 100;
                } else if (valorCentavos >= 50) {
                    moeda0_50++;
                    valorCentavos -= 50;
                } else if (valorCentavos >= 25) {
                    moeda0_25++;
                    valorCentavos -= 25;
                } else if (valorCentavos >= 10) {
                    moeda0_10++;
                    valorCentavos -= 10;
                } else if (valorCentavos >= 5) {
                    moeda0_05++;
                    valorCentavos -= 5;
                } else {
                    moeda0_01++;
                    valorCentavos -= 1;
                }
            }

            // Saída
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moeda0_50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moeda0_25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moeda0_10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moeda0_05} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moeda0_01} moeda(s) de R$ 0.01");
        }
    }
}

//Neste exercicio em específico eu precisei fazer algumas mudanças
//diferentes na minha resolução "original". No caso, precisei mudar
//o formato de leitura do console, pois o valor só poderia estar
//dentro dessa faixa: N (0 ≤ N ≤ 1000000.00). Sendo N o número do
//valorMonetario, que é lido no console. Além disso, após a leitura,
//também precisei transformar o valor em centavos. Para isso eu
//converti o valor lido para centavos (multiplicando por 100 e
//arredondando com Math.Round()).E por que isso? Bem, porque o sistema
//de ponto flutuante pode não ser 100% preciso, resultando, neste caso,
//em valores que podem não chegar exatamente a zero.