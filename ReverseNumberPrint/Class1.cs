using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseNumberPrint
{
    internal class Class1
    {
        public static void reverse()
        {
            Console.WriteLine("Enter a number:");
            int number= int.Parse(Console.ReadLine());
            int result = 0;

            while (number > 0)
            {
                int rem = number % 10;
                result = result * 10 + rem;
                number =number/ 10;
            }
            Console.WriteLine("Reverse Number Is: {0}",result);
            Console.ReadLine();
        }
    }
}
