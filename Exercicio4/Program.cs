using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
         {
             for (int contador = 0; contador <= 10; contador++)
             {
                 Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                 Console.WriteLine();
             }
            Console.WriteLine();
        }
         Console.ReadLine();

        /*

        for (int linha = 0; linha < 10; linha++)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                if (coluna > linha)
                {
                    break;
                }
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();  */
    }
}