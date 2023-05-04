using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("Elements of Array Multiple by 7 : " + MultipleOfSeven(Arr));
        }

        static Func<int[], int> MultipleOfSeven = (int[] a) =>
        {
            int count = 0;
            foreach (int item in a)
                if (item % 7 == 0)
                {
                    Console.WriteLine($"{item}");
                    count++;
                }
            return count;
        };
    }
}
