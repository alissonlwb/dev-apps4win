using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine("valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;

            Console.WriteLine("valor de a: " + a + "\nvalor de b: " + b);


        }
    }
}
