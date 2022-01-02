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
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);


            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine(duration);
            
            // Properties
            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(timeSpan.TotalMinutes);
            
            // Add
            Console.WriteLine("Add " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Sub " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));
            
            // ToString
            Console.WriteLine("ToString " + timeSpan.ToString());
            
            // Parse
            Console.WriteLine("Parse " + TimeSpan.Parse("01:02:03"));
            
        }
    }
}