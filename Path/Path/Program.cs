using System;
using System.IO;
using BibliotecaExemplo;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //{
            //    Exemplo ex = new Exemplo();
            //    string path = @"c:\temp\myfolder\file1.txt";
            //    ex.ImprimaAlgumaCoisa(path);
            //}

            try
            {
                Console.WriteLine("LEU A MEMÓRIA");

                //AQUI DEU ERRO
                //throw new Exception();
                
            }
            catch (Exception ex)
            {

                Console.Write("DEU ERRO");
            }
            finally
            {
                Console.WriteLine("LIMPOU A MEMÓRIA");
            }

        }
    }
}