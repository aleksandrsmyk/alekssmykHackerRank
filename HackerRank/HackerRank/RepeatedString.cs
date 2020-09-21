using System;
using System.Linq;

namespace HackerRank
{
    public partial class Programm
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {

            if (n == 0)
                return 0;

            int countAinString = s.Count(x => x == 'a');
            Console.WriteLine($"countAinString={countAinString}");

            if (countAinString == 0)
                return 0;

            int sLength = s.Length;
            if (sLength == 1)
                return n;


            long countOfCompleteStrings = n / sLength;
            Console.WriteLine($"countOfCompleteStrings={countOfCompleteStrings}");

            long countOfInCompleteChars = n % sLength;
            Console.WriteLine($"countOfInCompleteChars={countOfInCompleteChars}");

            int countOfIncompleteCharsOfA = s.Take((int)countOfInCompleteChars).Count(x => x == 'a');
            Console.WriteLine($"countOfIncompleteCharsOfA={countOfIncompleteCharsOfA}");

            return countOfCompleteStrings * countAinString + countOfIncompleteCharsOfA;
        }

    }
}