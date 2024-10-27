using System;

public class Exercicio2
{
    public static void Executar()
    {
        Console.WriteLine("Digite a quantidade de pessoas: ");
        int n = int.Parse(Console.ReadLine());

        dados(n);
    }
    static void dados(int n)
    {
        int contagem_salarios = 0;
        double total_salarios = 0, media = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Qual o seu salário?");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos filhos você tem?");
            int filhos = int.Parse(Console.ReadLine());

            contagem_salarios++;
            total_salarios += salario;
        }

        media = total_salarios / contagem_salarios;
        Console.WriteLine("A média de salários da população é de R$" + media.ToString("F2"));
    }
}
