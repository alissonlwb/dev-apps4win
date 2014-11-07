using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {      
            
            // ler valor do teclado e escrever na tela seu antecessor 
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            //numero--;
            Console.WriteLine("O numero é: " + --numero);
            //Console.ReadKey();
            
        }
    }
}
