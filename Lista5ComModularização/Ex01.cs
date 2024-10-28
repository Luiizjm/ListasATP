using System;
    public class Exercicio1
    {
        public static void Rodar()
        {
            int[] vetor = new int[15];
            int resultado = 0;
            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                resultado = IdentificadorPares(i);
                

            }


        }

        public static int IdentificadorPares()
        {

            int a = 1;


            return a;
        }
    }
