using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLogoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12 - Calcula Investimento Logo Prazo");

            double valorInvestido = 1000;
            double fatorRendimeto = 1.0036;

            for(int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimeto;
                }
                    fatorRendimeto += 0.0010;
                // Console.WriteLine("Ano" + contadorMes + "Rendimento R$" + valorInvestido);
            }

            Console.WriteLine("Rendimento no final de 5 anos R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
