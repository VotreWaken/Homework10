using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SixthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World Privit Svit";
            GivenWord(s);
        }

        static Action<string> GivenWord = (string word) =>
        {

            var words = word.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Enter Word To Find");
            string keyWord = Console.ReadLine();
            // Use LINQ to get the unique words.
            if (words.Contains(keyWord))
            {
                Console.WriteLine($"Text Contain Word: {keyWord}");
            }
            else
            {
                Console.WriteLine($"Text does not Contain Word: {keyWord}");
            }
        };
    }
}
