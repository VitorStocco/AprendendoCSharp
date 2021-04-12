using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4 - Conversões e outro tipos numericos!");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; //Casting
            Console.WriteLine(salarioEmInteiro);

            //int é 32 bits
            //long é 64 bits aceita numero maiores.
            long idade;
            idade = 130000000000;

            //short é 16 bits
            short quantidadeProduto;
            quantidadeProduto = 15000;

            float altura = 1.80f;

            Console.ReadLine();
        }
    }
}
