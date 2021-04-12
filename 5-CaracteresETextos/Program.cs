using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(" Excutando o Projeto 5 - Caracteres e Textos!");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Curos de Tecnologia " + 2020;
            string cursoProgramacao = 
@"- .NET
- Java
- JavaScrip";
            Console.WriteLine(titulo);
            Console.WriteLine(cursoProgramacao);



            Console.ReadLine();
        }
    }
}
