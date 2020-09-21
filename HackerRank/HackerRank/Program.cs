using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
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

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();

        Console.WriteLine(result);
    }
}
