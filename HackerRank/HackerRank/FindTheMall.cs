using System;
namespace HackerRank
{
    public partial class Program
    {
        static int FindTheMall(int n, int m, int x1, int y1, int x2, int y2)
        {
            bool directionX = true;
            bool directionY = true;
            int countStart = 0;

            int stepX = 0;
            int stepY = 0;

            int stepXO = x1;
            int stepYO = y1;

            int steps = 0;

            while (true)
            {
                stepX = x1;
                stepY = y1;

                if (directionX)
                    x1++;
                else
                    x2--;

                if (directionY)
                    y1++;
                else
                    y2--;

                steps++;

                if (x1 == x2 && y1 == y2)
                    break;

                if (x1 == stepXO && y1 == stepYO)
                {
                    countStart++;
                    if (countStart == 2)
                        return -1;

                }

                if (x1 == n || x1 < 0)
                {
                    directionX = !directionX;
                    x1 = stepX;
                    y1 = stepY;
                }
                if (y1 == m || y1 < 0)
                {
                    directionY = !directionY;
                    x1 = stepX;
                    y1 = stepY;
                }
            }

            return steps;
        }
    }
}