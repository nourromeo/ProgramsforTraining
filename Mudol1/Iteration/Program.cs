using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int answer = rand.Next(1, 1000);
            int guess = 0;



            while (guess != answer)
            {
                Console.Write($"Guess a number: ");

                guess = int.Parse(Console.ReadLine());

                if (guess < answer)
                {
                    Console.WriteLine($"Worng! Your guess is too small. guess again! ");
                }
                else
                {
                    Console.WriteLine($"Worng! Your guess is too big. guess again! ");
                }
            }
            Console.WriteLine($"Correct! the right answer is {answer} ");

        }
    }
}
