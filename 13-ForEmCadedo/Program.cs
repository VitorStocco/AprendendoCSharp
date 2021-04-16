using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForEmCadedo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 13 - For em Cadeado !");

            for(int contadorLinha = 0; contadorLinha <10; contadorLinha++)
            {
                for( int contadorColuna = 0; contadorColuna <10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                    break;
                }
                Console.WriteLine();
            }

            // forma diferente fazer o desenho

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");
                   // se o for tiver uma instrução nao precisa {}
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
