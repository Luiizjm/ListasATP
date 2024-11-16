using System;

namespace Lista5
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Escolha os exercicios de 1 a 10: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Exercicio1.Rodar();
                    break;
                case 2:
                    Exercicio2.Rodar();
                    break;
                case 3:
                    Exercicio3.Rodar();
                    break;
                case 4:
                    Exercicio4.Rodar();
                    break;
                case 5:
                    Exercicio5.Rodar();
                    break;
                case 6:
                    Exercicio6.Rodar();
                    break;
                case 7:
                    Exercicio7.Rodar();
                    break;
                case 8:
                    Exercicio8.Rodar();
                    break;
                case 9:
                    Exercicio9.Rodar();
                    break;
                case 10:
                    Exercicio10.Rodar();
                    break;
                default:
                    break;
            }
        }
    }
}