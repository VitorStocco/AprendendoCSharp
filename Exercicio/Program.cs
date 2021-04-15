using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciocios
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            // ------------------------------------------------

            float pontoFlutuante = 3.14f;
            Console.WriteLine(pontoFlutuante);

            double salario2 = 1270.50;
            int valor3 = (int)salario2;
            Console.WriteLine(valor3);

            double valor4 = 0.2;
            double valor5 = 0.1;
            double total4 = valor4 + valor5;

            Console.WriteLine(total4);


            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);

            // teste do GIT


            Console.ReadLine();
        }
    }
}
