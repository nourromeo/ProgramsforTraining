using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heltal
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 0;

            while(heltal < 31)
            {
                if (heltal % 2 == 0)
                {
                    Console.Write($" {heltal} ");
                }
                heltal++;
            }

            Console.ReadLine();
        }
    }
}
