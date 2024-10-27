using System;

public class Exercicio3
{
    public static void Executar()
    {
        Console.WriteLine("Digite a quantidade de triângulos: ");
        int quant_triangulos = int.Parse(Console.ReadLine());

        triangulos(quant_triangulos);
    }

    static void triangulos(int quant_triangulos)
    {
        for (int i = 0; i < quant_triangulos; i++)
        {
            Console.WriteLine("Digite os comprimentos dos 3 lados do triangulo: ");
            Console.Write("X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Z: ");
            double Z = double.Parse(Console.ReadLine());

            if (X == Y && X == Z && Z == Y)
            {
                Console.WriteLine("Triângulo Equilátero!");
            }
            else if (X == Y || X == Z || Z == Y)
            {
                Console.WriteLine("Triângulo Isósceles!");
            }
            else
            {
                Console.WriteLine("Triângulo Qualquer");
            }
            
        }
    }
}