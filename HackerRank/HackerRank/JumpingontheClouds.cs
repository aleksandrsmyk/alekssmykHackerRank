using System;
namespace HackerRank
{
    public partial class Programm
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int countOfSteps = 0;
            int nextStep1 = 0;
            int nextStep2 = 0;
            int length = c.Length;
            for (int i = 0; i < length;)
            {
                nextStep2 = i + 2;
                nextStep1 = i + 1;

                Console.WriteLine($"{nextStep1},{nextStep2},{i}");

                if (nextStep1 >= length)
                    return countOfSteps;

                if (nextStep2 < length && c[nextStep2] == 0)
                {
                    i = nextStep2;
                    countOfSteps++;
                    continue;
                }

                if (c[nextStep1] == 0)
                {
                    i = nextStep1;
                    countOfSteps++;
                    continue;
                }
                i++;
            }
            return countOfSteps;
        }
    }
}
