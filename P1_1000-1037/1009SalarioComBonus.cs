using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1009SalarioComBonus {
        static void Main() {
            //Declarando as variáveis:
            string NomeVendedor;
            double SalarioFixo, TVendas, SalarioFinal;

            //Lendo os valores das variáveis:
            Console.WriteLine("Digite o nome do vendedor:");
            NomeVendedor = Console.ReadLine();

            Console.WriteLine("Digite o salário fixo do vendedor:");
            SalarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas do vendedor (em dinheiro):");
            TVendas = double.Parse(Console.ReadLine());

            //Salario Final, com o salário fixo + 15% das vendas:
            SalarioFinal = SalarioFixo + (15 * TVendas) / 100;

            //Exibindo o total que o funcionário irá receber:
            Console.WriteLine($"TOTAL = R$ {SalarioFinal.ToString("F2")}");
        }
    }
}
