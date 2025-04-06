using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числа, разделени с интервал:");
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }
            Console.Write("Въведете цел: ");
            int target = int.Parse(Console.ReadLine());
            int[] result = TwoSum(nums, target);
            if (result != null)
            {
                Console.WriteLine($"Индекси: {result[0]} {result[1]}, числа: {nums[result[0]]} {nums[result[1]]}");
            }
            else
            {
                Console.WriteLine("Няма такива числа.");
            }
            Console.ReadKey();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int a = target - nums[i];
                if (dictionary.ContainsKey(a))
                {
                    int[] result = new int[2];
                    result[0] = dictionary[a];
                    result[1] = i;
                    return result;
                }
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = i;
                }
            }
            return null;
        }
        public static int[] TwoSum2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
