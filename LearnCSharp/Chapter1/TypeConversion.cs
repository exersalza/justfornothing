using System;

namespace LearnCSharp.Chapter1
{
    internal class Conversion
    {
        public static void TypeConversion(string[] args)
        {
            byte b = 1;
            int i = b; // here comes no data lose
            
            int a = 1;
            byte c = (byte)a; // here comes to an data lose, you can force it with casting (byte), but when you go over 255 your int is not shown correctly
            
            // -- //

            var number = "123";
            int num = Convert.ToInt32(number);  // here you need to convert the given string to an int, you can't cast it
            
            // -- //
            
            try // here you have an TryCatch block, its similar to pythons try and catch
            {
                var Number = "1234";
                byte Num = Convert.ToByte(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}