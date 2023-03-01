using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksimalnaPoredicaEdnakviChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxCt = 0;
            int maxN = 0;
            int ct = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    ct++;
                }
                else
                {
                    ct = 1;
                }
                if (ct > maxCt)
                {
                    maxCt = ct;
                    maxN = numbers[i];
                }
            }
            for (int i = 0; i < maxCt; i++)
            {
                Console.Write(maxN);
            }
            Console.WriteLine();
        }
    }
}
