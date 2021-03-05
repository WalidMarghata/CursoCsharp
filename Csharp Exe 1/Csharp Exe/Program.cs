using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            Console.WriteLine("Informe o seu nome: ");

            Nome = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(string.Format("Meu nome é: {0}", Nome));

            Console.ReadKey();
        }
    }
}