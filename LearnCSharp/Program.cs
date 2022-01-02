using System;
using System.Collections.Generic;

namespace LearnCSharp
{
    public enum Shipping
    {
        Fast, 
        Normal,
        Slow
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Hour);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToShortTimeString());
        }
    }
}