using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
           
           //Exercicio 1
           //writes the arguments recieve one by one
            for (int i = 0; i < args.Length; i++) 
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
