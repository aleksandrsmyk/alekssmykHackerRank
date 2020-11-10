using System;
namespace HackerRank
{
    public partial class Program
    {
        static void FizzBuzz(int n)
        {
            if (n <= 0)
                Console.WriteLine("NONE");

            const string csFizz = "Fizz";
            const string csBuzz = "Buzz";
            const string csFizzBuzz = "FizzBuzz";

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                        Console.WriteLine(csFizzBuzz);
                    else
                        Console.WriteLine(csFizz);
                }
                else if (i % 5 == 0)
                    Console.WriteLine(csBuzz);
                else
                    Console.WriteLine(i);
            }
        }
    }
}