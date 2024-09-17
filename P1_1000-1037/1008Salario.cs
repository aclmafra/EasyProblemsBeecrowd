using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1008Salario {
        static void Main() {

            //Declarando múltiplas variáveis:
            int NumeroF, HrsTrab;
            double ValorHr, Salario;

            //Lendo número do funcionário e horas trabalhadas:
            Console.WriteLine("Digite o número do funcionário e suas horas trabalhadas:");
            NumeroF = int.Parse(Console.ReadLine());
            HrsTrab = int.Parse(Console.ReadLine());
            
            //Lendo a hora de trabalho do respectivo funcionário:
            Console.WriteLine("Digite o valor da hora de trabalho:");
            ValorHr = double.Parse(Console.ReadLine());

            //Definindo seu salario:
            Salario = HrsTrab * ValorHr;

            //Resultado do número do funcionario e seu respectivo salario:
            Console.WriteLine($"NUMBER = {NumeroF}");
            Console.WriteLine($"SALARY = U$ {Salario}");
        }
    }
}
