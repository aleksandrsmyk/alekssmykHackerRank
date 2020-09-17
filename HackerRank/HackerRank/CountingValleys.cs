using System;
namespace HackerRank
{
    public partial class Program
    {
        public static int countingValleys(int steps, string path)
        {
            int seaLevel = 0;
            int countOfValues = 0;
            bool isStillInValue = false;
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    seaLevel++;
                    if (isStillInValue && seaLevel == 0)
                    {
                        isStillInValue = false;
                        countOfValues++;
                    }
                }
                else
                {
                    if (seaLevel == 0)
                    {
                        isStillInValue = true;
                    }
                    seaLevel--;
                }
            }
            return countOfValues;
        }
    }
}
