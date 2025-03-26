using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете текст:");
            string input = Console.ReadLine().ToLower();
            string[] dumi = input.Split(' ');
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (string word in dumi)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words[word] = 1;
                }
            }
            Console.WriteLine("Честота на думите: ");
            foreach (var pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            Console.ReadKey();
        }
    }
}
