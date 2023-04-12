using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine("======MENU======");
            Console.WriteLine("1 exercicio ");
            Console.WriteLine("2 exercicio ");
            Console.WriteLine("3 exercicio ");
            Console.WriteLine("4 exercicio ");
            Console.WriteLine("5 exercicio ");
            Console.WriteLine("6 exercicio ");
            Console.WriteLine("7 exercicio ");
            Console.WriteLine("================");

            numero = int.Parse(Console.ReadLine());


            switch (numero)
            {
                case 1:

                    int num;

                    Console.WriteLine("digite um numero: ");
                    num = int.Parse(Console.ReadLine());

                    for (int i = 1; i < num; i++)
                        Console.WriteLine("valor de i" + i);

                    Console.ReadKey();
                    break;

                case 2:

                    int numerO;

                    Console.WriteLine("digite um numero: ");
                    numerO = int.Parse(Console.ReadLine());

                    for (int i = 2; i <= numerO; i += 2)
                        Console.WriteLine("valor de i" + i);


                    Console.ReadKey();
                    break;

                case 3:

                    int Num;

                    Console.WriteLine("digite um numero inteiro: ");
                    Num = int.Parse(Console.ReadLine());

                    for (int i = 1000; i > Num; i -= 2)
                        Console.WriteLine("valor de i" + i);

                    Console.ReadKey();
                    break;

                case 4:

                    int NUMERO, soma = 0;

                    for (int i = 0; soma <= 200; i++)
                    {
                        Console.WriteLine("Digite um numero: ");
                        NUMERO = int.Parse(Console.ReadLine());

                        if (NUMERO > 0)
                            soma = soma + NUMERO;

                    }

                    Console.ReadKey();
                    break;


                case 6:

                    int N, menor, maior;

                    Console.WriteLine("digite um numero: ");
                    N = int.Parse(Console.ReadLine());

                    menor = N;
                    maior = N;

                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine("digite um numero: ");
                        N = int.Parse(Console.ReadLine());

                        if (N < menor)
                            menor = N;

                        else if (N > maior)
                            maior = N;

                    }

                    Console.WriteLine("o maior numero digitado é: " + menor);

                    Console.WriteLine("o menor numero digitado é: " + maior);

                    Console.ReadKey();
                    break;


                case 7:

                    int somapar = 0, NUM = -1, somaimpar = 0;

                    for (; NUM != 0;)
                    {
                        Console.WriteLine("entre com um numero: ");
                        NUM = int.Parse(Console.ReadLine());

                        if (NUM % 2 == 0)
                            somapar = somapar + NUM;

                        else
                            somaimpar += NUM;
                    }

                    Console.ReadKey();
                    break;



            }
        }
    }
}
