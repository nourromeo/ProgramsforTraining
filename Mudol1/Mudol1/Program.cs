using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your first number: ");
            double firstNmuber = double.Parse(Console.ReadLine());

            Console.Write("Your second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("enter m: ");
            string m = Console.ReadLine();

            if (m == "+") { Console.WriteLine(firstNmuber + secondNumber); }
            if (m == "-") { Console.WriteLine(firstNmuber - secondNumber); }
            if (m == "*") { Console.WriteLine(firstNmuber * secondNumber); }
            if (m == "/") { Console.WriteLine(firstNmuber / secondNumber); }

        }
    }
}

