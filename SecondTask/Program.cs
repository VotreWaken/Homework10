using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack pack = new Backpack("Red", "Hello", "Leather", 100, 20);
            Console.WriteLine($"{pack}");
            pack.ItemAdded += (item) => Console.WriteLine($"Add Object: {item}");
            pack.AddItem("Book", 500, 1);
            Console.WriteLine($"{pack}");
        }

        class Backpack
        {
            private string color { get; set; }
            private string firm { get; set; }
            private string cloth { get; set; }
            private int weight { get; set; }
            private int volume { get; set; }
            private Dictionary<string, int>
                content = new Dictionary<string, int>();

            public event Action<string> ItemAdded;

            public Backpack()
            {
                color = "";
                firm = "";
                cloth = "";
                weight = 0;
                volume = 0;
            }

            public Backpack(string colorValue, string firmValue, string clothValue, int weightValue, int volumeValue)
            {
                color = colorValue;
                firm = firmValue;
                cloth = clothValue;
                weight = weightValue;
                volume = volumeValue;
            }

            public void AddItem(string itemName, int itemWeight, int itemVolume)
            {
                if (content.Count >= volume)
                {
                    throw new Exception("Error: is Already Full!");
                }
                if (itemVolume > volume - content.Count)
                {
                    throw new Exception("Error: Not Enough Space");
                }
                content.Add(itemName, itemWeight);
                ItemAdded?.Invoke(itemName);
            }

            public string GetContent()
            {
                StringBuilder str = new StringBuilder();
                Console.WriteLine("Contents:");
                foreach (var iter in content)
                {
                    str.AppendLine($"{iter.Key}: {iter.Value}");
                }
                return str.ToString();
            }

            public override string ToString()
            {
                return
                $"\nColor: {color}" +
                $"\nBrand: {firm} " +
                $"\nCloth: {cloth}" +
                $"\nWeight: {weight}" +
                $"\nVolume: {volume}" +
                $"\nContents: {GetContent()}";
            }
        }
    }
}
