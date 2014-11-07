using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region primeiro exemplo
            //escrever um app em c# que mostra numeros impares entre 1 e 100

            for (int i = 1; i <= 100; i += 2)
            {
                if (i % 2 == 0) continue;
                else Console.WriteLine("Os numeros sao {0}", i);

            }

            int a = 1;
            while (a <= 100) {
                if (a % 2 == 0) continue;
                else Console.WriteLine("Os numeros sao " + a);

                a += 2;
            }
            #endregion

            #region segundo exemplo

            //peça 5 numeros e mostre a media entre eles
            double num = 0, m;

            for (int i = 0; i < 5; i++)
            {
                num = Convert.ToDouble(Console.ReadLine());
                m = num;// corrigir a logica
            } 

            Console.WriteLine("Media é: " + num/5);

            #endregion
        }
    }
}
