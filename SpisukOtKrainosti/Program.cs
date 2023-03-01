using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisukOtKrainosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int minEl = numbers[0];
            int maxEl = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < minEl)
                {
                    minEl = numbers[i];
                }

                if (numbers[i] > maxEl)
                {
                    maxEl = numbers[i];
                }
            }
            List<int> result = new List<int>();
            foreach (var n in numbers)
            {
                if (n == minEl || n == maxEl)
                {
                    result.Add(n);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

