using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {

            int peso;
            double altura;
            
            Console.WriteLine("Digite seu peso: ");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua altura (em metros): ");
            altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / altura * altura;

            if (imc < 17)
                Console.WriteLine("vc ta o mais mago possivel, mta punheta!! (mt abaixo do peso)");

            else if ((imc >= 17) && (imc <= 18.49))
                Console.WriteLine("(abaixo do peso)");

            else if ((imc >= 18.5) && (imc <= 24.99))
                Console.WriteLine("(peso normal)");

            else if ((imc >= 25) && (imc <= 29.99))
                Console.WriteLine("(acima do peso)");

            else if ((imc >= 30) && (imc <= 34.99))
                Console.WriteLine("(obesidade I)");

            else if ((imc >= 35) && (imc <= 39.99))
                Console.WriteLine("(obesidade II severa)");

            else if (imc > 40)
                Console.WriteLine("vc ta o mais gordo possivel, quase um Allan Cleysson (obesidade III morbida)");

        }

    }
}

