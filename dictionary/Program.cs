using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                { 101, "Ivan Petrov" },
                { 102, "Ana Georgieva" },
                { 103, "Pavel Qnakiev" }
            };
            Console.Write("Въведете номер на студент: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                if (students.TryGetValue(studentId, out string name))
                {
                    Console.WriteLine("Студент: " + name);
                }
                else
                {
                    Console.WriteLine("Няма студент с такъв номер");
                }
            }
            else
            {
                Console.WriteLine("Невалиден вход");
            }
            Console.ReadKey();
        }
    }
}
