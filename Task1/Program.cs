using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for how many decimals to display - Limit is 14");
            int value = System.Convert.ToInt32(Console.ReadLine());
            value = value >14 ? 14 : value;
            const double pi = System.Math.PI;
            Output(value, pi);

        }
        static void Output(int value, double pi ) 
        {
            Console.WriteLine(pi.ToString("F" + value));
        }
    }
}
