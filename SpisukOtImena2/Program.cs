using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisukOtImena2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            List<string> names = Console.ReadLine().Split(',').ToList();
            //names.Reverse();
            foreach (string n in names)
            {
                string[] nameAndSurname = n.Trim().Split(' ');//trim-vrushta nov niz v koito vsichki vodeshti sreshtaniq na posocheni znaci ot tekushtiq niz sa premahnati
                Console.WriteLine($"{nameAndSurname[1]} {nameAndSurname[0]}");
            }
        }
    }
}
