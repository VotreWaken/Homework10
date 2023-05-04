using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RainbowRGB("pink"));
            Console.WriteLine(RainbowRGB("red"));
            Console.WriteLine(RainbowRGB("orange"));
            Console.WriteLine(RainbowRGB("yellow"));
            Console.WriteLine(RainbowRGB("green"));
            Console.WriteLine(RainbowRGB("blue"));
            Console.WriteLine(RainbowRGB("indigo"));
            Console.WriteLine(RainbowRGB("violet"));
        }
        static Func<string, (int, int, int)> RainbowRGB = (color) =>
        {
            switch (color.ToLower())
            {
                case "red":
                    return (255, 0, 0);
                case "orange":
                    return (255, 165, 0);
                case "yellow":
                    return (255, 255, 0);
                case "green":
                    return (0, 128, 0);
                case "blue":
                    return (0, 0, 255);
                case "indigo":
                    return (75, 0, 130);
                case "violet":
                    return (238, 130, 238);
                default:
                    Console.WriteLine($"ERROR: нет в радуге: {color.ToLower()}");
                    return (000, 000, 000);
            }
        };
    }
}
