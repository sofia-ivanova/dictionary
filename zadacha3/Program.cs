using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> employees = new SortedDictionary<int, string>();
            while (true)
            {
                Console.Write("Въведете ID и име (или 'show' за показване, 'exit' за изход): ");
                string input = Console.ReadLine();
                if (input == "show")
                {
                    foreach (var emp in employees)
                    {
                        Console.WriteLine($"{emp.Key}: {emp.Value}");
                    }
                    continue;
                }
                if (input == "exit") 
                    break;
                string[] parts = input.Split(' ');
                if (parts.Length == 2 && int.TryParse(parts[0], out int id))
                {
                    employees[id] = parts[1];
                    Console.WriteLine("Добавен!");
                }
                else
                {
                    Console.WriteLine("Грешен формат!");
                }
            }
            Console.ReadKey();
        }
    }
}
