using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("\nPositive Elements of Array: " + PositiveCount(Arr));
        }
        static Func<int[], int> PositiveCount = (int[] a) =>
        {
            int count = 0;
            foreach (int item in a)
                if (item >= 0)
                {
                    Console.Write($"{item}" + " ");
                    count++;
                }
            return count;
        };
    }
}
