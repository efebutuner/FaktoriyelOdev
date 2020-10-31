using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen faktöryelini hesaplamak istediğiniz sayıyı giriniz: ");
            string faktoryel = Console.ReadLine();
            int fakto = int.Parse(faktoryel);
            if (fakto > 0)
            {
                long faktoryelsonuc = 1;
                for (int i = fakto; i >= 1; i--)
                {
                    faktoryelsonuc *= i;
                }
                Console.WriteLine(faktoryelsonuc);
            }
            else if (fakto == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("Negatif sayıların faktöryeli yoktur.");
            }
            Console.ReadLine();
        }
    }
}
