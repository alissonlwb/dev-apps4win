using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao ensinador de Matemática!");
            //PERGUNTA NUMERO 1
            Console.WriteLine("Quanto é 5 + 5 ? ");
            int resposta = Convert.ToInt32(Console.ReadLine());


            if (resposta != 10)
                Console.WriteLine("RESPOSTA ERRADA, O RESULTADO É 10!");
            else
                Console.WriteLine("PARABÉNS, RESPOSTA CERTA!");

            //PERGUNTA NUMERO 2
            Console.WriteLine("Quanto é 10 + 5 ? ");
            int resposta2 = Convert.ToInt32(Console.ReadLine());


            if (resposta2 != 15)
                Console.WriteLine("RESPOSTA ERRADA, O RESULTADO É 15!");
            else
                Console.WriteLine("PARABÉNS, RESPOSTA CERTA!");

            Console.ReadKey(); //DESNECESSARIO

        }
    }
}
