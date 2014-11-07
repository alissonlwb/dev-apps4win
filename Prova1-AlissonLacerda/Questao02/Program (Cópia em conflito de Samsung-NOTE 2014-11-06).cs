using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    class Program
    {
        static int a, b;
        static void Main(string[] args)
        {
            //LER DOIS NUMEROS DO USUÁRIO E TROCAR O VALOR DAS VARIAVEIS
            a = lerDoUsuario();
            b = lerDoUsuario();

            imprimeValores(a, b);

            trocaValores();

            imprimeValores(a, b);

            Console.ReadKey(); 
        }

        private static void imprimeValores(int a, int b)
        {
            //FAZER COM QUE APAREÇA NA TELA:
            // Valor de A = ___  e Valor de B = ___
            Console.WriteLine("Valor de A = {0}  e Valor de B = {1}", a, b);
        }


        private static int lerDoUsuario()
        {
            //implemente a leitura
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void trocaValores()
        {
            int c = 0;
            c = a;
            a = b;
            b = c;
        }

    }
}
