using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;
            Console.Write("Enter your start number: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter your end number: ");
            end = int.Parse(Console.ReadLine());
            for (; start <= end; start++)
            {
                if (start == 6)
                {
                    Console.WriteLine(start);
                }
                else if (start == 28)
                {
                    Console.WriteLine(start);
                }
                else if (start == 496)
                {
                    Console.WriteLine(start);
                }
                else if (start == 8128)
                {
                    Console.WriteLine(start);
                }
            }
            Console.ReadKey();
        }
    }
}
