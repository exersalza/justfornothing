using System;

namespace LearnCSharp.Chapter1
{
    internal class Program
    {
        public static void VarAndConst(string[] args)
        {
            byte number = 2; // you can use byte, int,... but you can also use var, then it applies automatically 
            int count = 10;
            float totalPrice = 20.95f; // for floats or decimals use f or m at the end of the number
            char character = 'a'; // character are in ' and not " for just like strings
            string firstName = "Mosh";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            
            // -- //

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // example of an formatted string
            
            // -- //
            
            const float Pi = 3.14f; // float as const, const values can't be changed in runtime
        }
    }
}