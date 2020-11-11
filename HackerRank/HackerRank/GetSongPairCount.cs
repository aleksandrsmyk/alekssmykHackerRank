using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public partial class Program
    {
        //Console.WriteLine(getSongPairCount(new List<int>() { 148, 397, 434, 801, 866, 293, 914, 516, 139, 610, 927 }));
        //Console.WriteLine(getSongPairCount(new List<int>() { 60, 60, 60 }));
        //Console.WriteLine(getSongPairCount(new List<int>() { 10,50,90,30 }));
        public static long getSongPairCount(List<int> songs)
        {
            long count = 0;
            int totalCount = songs.Count();
            IDictionary<int, int> cache = new Dictionary<int, int>();
            int key = 0;
            for (int i = 0; i < totalCount; i++)
            {
                key = songs[i] % 60;
                int remainder = (60 - key) % 60;
                if (cache.ContainsKey(remainder))
                    count += cache[remainder];
                if (cache.ContainsKey(key))
                    cache[key]++;
                else
                    cache.Add(key, 1);
            }

            return count;
        }
    }
}
