using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando os conceitos de Orientação a Objetos Implemente um sistema que guarde nome e 2 notas de 
            //3 alunos, este programa deverá fazer o cálculo da média desses 3 alunos e imprimir na tela o nome do aluno 
            //que obter a maior média, seguindo o formato: "O aluno 'nomedoaluno'  obteve a maior média, sendo ela: 'mediaDoAluno'
            Aluno alisson = new Aluno("Alisson", 8, 9);
            Aluno wilter = new Aluno("Wilter", 4, 5);
            Aluno allan = new Aluno("Allan", 10, 10);

            double[] medias = {
                alisson.calcMedia(), 
                wilter.calcMedia(),
                allan.calcMedia()
            };   

            double maior = 0;

            for (int i = 0; i < 3; i++)
            {
                if (medias[i] > maior) maior = medias[i];
                else maior = maior;
            }

            if (maior == medias[0]) alisson.maiorMedia();
            else if (maior == medias[1]) wilter.maiorMedia();
            else if (maior == medias[2]) allan.maiorMedia();
        }

        class Aluno
        {
            //atributos: nome n1 e n2
            public string nome;
            public double n1, n2;
            
            //construtor com 3 argumentos
            public Aluno(string _nome, double _n1, double _n2)
            {
                nome = _nome;
                n1 = _n1;
                n2 = _n2;
            }
            // construtor vazio
            public Aluno()
            {
                
            }

            //metodo para calcular média
            public double calcMedia()
            {
                return (n1 + n2) / 2;
            }

            //metodo para printar aluno com maior media
            //texto para ser printado>>> O aluno 'nomedoaluno'  obteve a maior média, sendo ela: 'mediaDoAluno'
            public void maiorMedia()
            {
                Console.WriteLine("O aluno " + nome + " obteve a maior media, sendo ela: " + calcMedia());
            }
        }

    }
}
