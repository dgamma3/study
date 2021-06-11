using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximize_the_Value
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static List<int> arr(int[] argslist)
        {
            var args = argslist.ToList();
            var findMin = args.Min();
            args.Remove(findMin);
            int findSecondMin = args.Min();
            args.Remove(findSecondMin);
            args.Sort();
            var orderedList = new List<int>();
            orderedList.Add(args[0]);
            orderedList.Add(args[1]);
            orderedList.Add(findMin);
            orderedList.Add(args[2]);
            orderedList.Add(findSecondMin);
            
            Console.WriteLine("Hello World!");

            return orderedList;
        }
        
    }
}