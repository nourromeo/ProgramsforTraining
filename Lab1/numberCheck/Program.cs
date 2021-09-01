using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
          
                Console.Write($"write a number: ");
                number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine($"The number {number} is negative ");
                }
                else if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive ");
                }
                else
                {
                    Console.WriteLine($"The number is {number}");
                }


            Console.Read();

        }
    }
}
