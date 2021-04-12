using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicioanis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");
            int idade = 16;
            //int quantidadePessoas = 2;
            //bool acampanhado = quantidadePessoas >= 2;

            bool acampanhado = true;

            /*
             *  || comparativo E
             *  && comparativo OU
             *  == comparativo IGUAL
             *  
             */

            if (idade >= 18 && acampanhado == true)
            {
                Console.WriteLine("Pode Entar!!!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!!!");
            }
            Console.ReadLine();
        }
    }
}
