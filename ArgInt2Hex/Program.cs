using System;

namespace ArgInt2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            //"for" to run through the Array args
            for (int i=0;i<=args.Length;i++){
            //for each element the "If" will verify if there is a number or not
            //if there is a number, it will print it and convert it to Hex   
                if(int.TryParse(args[i],out int n1)){
                    Console.WriteLine("Inteiro: "+n1);
                    Console.WriteLine("Numero em Hexadecimal: "+n1.ToString("X"));
                }
            //if its not a number it will say so    
                else {
                    Console.WriteLine("Não é um numero!");

                }
            }
        }
    }
}
