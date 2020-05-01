using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new[] { 1, 6, 8, 3, 6, 12, 1, 2, 4, 2, 7, 9, 12, 3, 1, 6, 7, 10, 11, 28 };
            var numList = num.ToList();

            //split list into chunks of 5
            var splitArray = SplitList(numList, 5);
            //callculate sum of the smaller lists
            var listSum = splitArray.Select(l => l.Sum()).ToList();
            for(int i = 0; i<splitArray.Count; i++)
            {
                Console.WriteLine($"{ string.Join(",", splitArray[i])} = {listSum[i]}");
            }

            var dictionary = new Dictionary<List<int>, int>();
            for (int i = 0; i < splitArray.Count; i++)
            {
                dictionary.Add(splitArray[i], listSum[i]);
            }
            listSum.Sort();
        }

        public static List<List<int>> SplitList(List<int> list, int size)
        {
            var splitlist = new List<List<int>>();
            for (int i = 0; i < list.Count; i += size)
                splitlist.Add(list.GetRange(i, Math.Min(size, list.Count - i))); // split the list into smaller chunks
            return splitlist;
        }


    }
}
