using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public partial class Program
    {
        //Console.WriteLine(numberOfItems("'|**|*|*'", new List<int> { 1, 1 }, new List<int> { 5, 6 }));
        //Console.WriteLine(numberOfItems("'*|*|'", new List<int> { 1 }, new List<int> { 3 }));
        public static List<int> numberOfItems(string s, List<int> startIndices, List<int> endIndices)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < startIndices.Count(); i++)
            {
                string si = s.Substring(startIndices[i], endIndices[i]);
                if (si.Count(x => x == '|') > 1)
                {
                    var splites = si.Split('|');
                    int countP = splites.Count();
                    int complete = splites.Take(countP - 1).SelectMany(x => x).Count(x => x == '*');
                    res.Add(complete);
                }
            }
            return res;
        }
    }
}
