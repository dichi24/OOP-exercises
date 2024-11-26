
using System;
using Test;

namespace Test
{


    public class IntFunctions
    {

        public void Add()
        {
            Console.WriteLine("Skriv et tal: \n ");
            string input1 = Console.ReadLine();
            int a = int.Parse(input1);

            Console.WriteLine("Skriv et nyt tal: \n ");

            string input2 = Console.ReadLine();
            int b = int.Parse(input2);

            int x = a + b;

            Console.WriteLine($"\n{a} + {b} = {x}");
            Console.WriteLine($"Dit nye tal er {x}");

        }
        public void Multiply()
        {
            Console.WriteLine("Skriv et tal: \n");
            string input1 = Console.ReadLine();
            int a = int.Parse(input1);

            Console.WriteLine("Skriv et nyt tal: \n");
            string input2 = Console.ReadLine();
            int b = int.Parse(input2);

            int x = a * b;

            Console.WriteLine($"\n {a} * {b} = {x}");
            Console.WriteLine($"Dit ny tal er {x}");
        }
    }
	
}