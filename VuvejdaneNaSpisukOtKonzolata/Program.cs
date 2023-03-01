using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuvejdaneNaSpisukOtKonzolata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Въведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи число: ");
                int item = int.Parse(Console.ReadLine());
                numbers.Add(item);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
        }
    }
}
