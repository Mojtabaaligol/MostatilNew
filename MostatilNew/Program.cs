using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostatilNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tool ra vared konid :");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("arz ra vared konid :");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(b*a);
            Console.WriteLine((b + a)*2);

            Console.ReadKey();
        }
    }
}
