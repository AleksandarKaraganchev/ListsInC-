using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNaOburnatiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Reverse();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentN = numbers[i];
                int reversed = 0;
                while (currentN > 0)
                {
                    reversed = reversed * 10 + currentN % 10;
                    currentN /= 10;
                }
                sum += reversed;
            }
            Console.WriteLine(sum);
        }
    }
}
