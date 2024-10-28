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
                   //Exercicio2.Rodar();
                    break;
                
            }




        }
    }
}