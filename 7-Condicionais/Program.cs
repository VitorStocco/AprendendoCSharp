using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais!");
            int idade = 16;
            int quantidadePessoas = 1;


            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade!!!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Menor de idade!!!, Mas esta acompanhado!!!");
                }
                else
                {
                    Console.WriteLine("Menor de idade, Esta Sozinho!!!");
                }

            }
            Console.ReadLine();
        }
    }
}
