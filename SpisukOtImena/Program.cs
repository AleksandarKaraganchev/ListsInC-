using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisukOtImena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<string> names = Console.ReadLine().Split(' ').ToList();
            names.Reverse();
            Console.WriteLine(string.Join("; ",names));
        }
    }
}
