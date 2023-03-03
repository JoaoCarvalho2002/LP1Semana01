using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {   
            //exercicio 6
            
            double xx=0.12345;
            int ii=18;
            //print xx(real number with 2 decimals,percentage with 1 decimal)
            Console.WriteLine(xx.ToString("f2"));
            Console.WriteLine(xx.ToString("p1"));
            //print ii(hexadecimal,coin)
            Console.WriteLine(ii.ToString("X"));
            Console.WriteLine(ii.ToString("C"));


            //exercicio 4
            Console.WriteLine("Exercice 4");
            //string variables
            string string1="qwerty";
            string string2="@";
            string string3="asdfg";
            string string4="@";
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
            Console.WriteLine(string4);

            //exercicio 5
            Console.WriteLine("Exercice 5");
            
            //common variables to the exercice
            int x=2;
            int y=3;

            //concatenation
            Console.WriteLine("Letra: a e numero: "+2);

            //interpolate
            //x+y
            Console.WriteLine("valor de x é:"+x);
            Console.WriteLine("valor de y é:"+y);
            Console.WriteLine("Soma: "+(x+y));

            //string.format()
            string A="A";
            string B="B";
            string s =String.Format("Primeiras duas letras do alfabeto: {0} , {1}",A,B);
            Console.WriteLine(s);
            
            //Console.writeline()
            Console.WriteLine(@"x={0} e y={1}",x,y);





        }
    }
}
