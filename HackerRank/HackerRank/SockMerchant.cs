using System;
using System.Linq;

namespace HackerRank
{
    public partial class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            var groupedList = ar.ToList().GroupBy(x => x);
            int result = 0;
            foreach (var item in groupedList)
                result += item.Count() / 2;

            return result;
        }
    }
}