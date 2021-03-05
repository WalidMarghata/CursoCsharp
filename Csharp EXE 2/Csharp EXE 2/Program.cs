using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            string Frase = "Agora eu sou um bom desenvolvedor.";

            Console.WriteLine(p.Alterar(Frase));

            Console.ReadKey();
        }

        private string Alterar(string Frase)
        {
            if (Frase.Trim().Length > 0)
            {
                int Total = Frase.Length;
                int Count = 0;

                var StringBuilder = new StringBuilder(Frase);

                while (Count < Total)
                {
                    if (StringBuilder[Count] == 'o')
                    {
                        StringBuilder[Count] = '&';
                    }
                    Count++;
                }

                Frase = StringBuilder.ToString();

                return Frase;
            }
            else
            {
                return null;
            }
        }
    }
}