///////////////Faça um programa que leia o nome e idade de 10 pessoas e calcule a quantidade de pessoas com idade >= 18 anos
// See https://aka.ms/new-console-template for more information
using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Teste1();
        Teste0();
    }
    public static void Teste0()
    {

        string Nome;                                                          //Variavel que vai receber os nomes dos Alunos
        int Idade, Cont = 1, mIdade = 0;                                      //Variavel de Inteiros que vai cada uma tera uma responsabildade Idade armazena idade dos alunos Cont ira contar em qual ciclo estamos e tambem informar qual o numero do aluno em que estamos mIdade ira armazenar o numero de alunos maiores de idade
        while (Cont <= 10)                                                    //onde esta sendo definido a quantidade de repetições
        {
            Console.WriteLine("Informe o nome do " + Cont + "º aluno: ");         //imprime no console a pergunta "qual o nome do 1º aluno"
            Nome = Console.ReadLine();                                        //vai armazenar em uma variavel os valores informados no console
            Console.WriteLine("Informe a Idade " + Cont + "º aluno: ");           //realiza o mesmo processo porem com a idade
            Idade = int.Parse(Console.ReadLine());                            //aqui e realizada uma conversão do que for informado no console para um numero inteiro ao inves de uma String
            Cont++;                                                           //variavel utilizada para fins de incremento no codigo para encerrar o While
            if (Idade >= 18)                                                  // if que simplismente contabiliza o numero de alunos com +18 anos que foram informados
                mIdade++;
        }

        Console.WriteLine("Dos 10 nomes informados apenas {0} e/são maiores de idade", mIdade);// retorna quantos alunos maiores de idade foram informados no codigo...

    }

    public static void Teste1()
    {
        string Sexo, Nome;
        int M = 0, F = 0, Cont = 1;

        while (Cont <= 10)
        {
            Console.WriteLine("Informe o Nome : ");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe o Sexo M para masculino e F para feminino : ");
            Sexo = Console.ReadLine();
            if (Sexo == "M")
            {
                M++;
            }
            else
            {
                F++;
            }
            Cont++;
        }
        Console.WriteLine("Foram Informados {0} Homens e {1} Mulheres", M, F);
    }
}


