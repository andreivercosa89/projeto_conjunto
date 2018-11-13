using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto_conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";

            HashSet<string> lista = new HashSet<string>();


            do
            {
                Console.Write("Informe o nome a ser add: ");
                lista.Add(Console.ReadLine().Trim().ToUpper());

                Console.Write("Digite sair ou der enter para continuar : ");
                texto = Console.ReadLine();



            } while (texto != "sair");

            

            foreach (var l in lista) { Console.Write(" " + l); }
        }
    }
}
