using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { -1, -1, 2, 3, 4, 5, 6, -7, 8, 9, 10, 11, 12, -13, 14 };
            UniqueNegative(Arr);
        }
        static Action<int[]> UniqueNegative = (int[] arr) =>
        {
            Console.Write("All Unique Negative Numbers in Array:");
            System.Collections.ArrayList unique = new System.Collections.ArrayList();
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (unique.IndexOf(arr[i]) == -1 && arr[i] < 0)
                {
                    result++;
                    unique.Add(arr[i]);
                }
            }
            for (int i = 0; i < unique.Count; i++)
            {
                Console.Write(unique[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine();
        };
    }
}
