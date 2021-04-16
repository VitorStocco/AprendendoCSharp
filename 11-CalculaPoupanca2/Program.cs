using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando p Projeto 11 - Calcula Poupança! 2");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //valorInvestido = valorInvestido + valorInvestido  * 0.0036;
                //valroInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Mes " + contadorMes +" o valor será R$" + valorInvestido);
            }



            Console.ReadLine();
        }
    }
}
