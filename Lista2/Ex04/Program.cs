using System;

class Program
{
    static void Main()
    {

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade <= 12)
        {
            Console.WriteLine($"Você é criança!");
        }
        else if (idade <= 17)
        {
            Console.WriteLine($"Você é Adolescente!");
        }
        else if (idade <= 64)
        {
            Console.WriteLine($"Você é Adulto!");
        }
        else
        {
            Console.WriteLine($"Você é Idoso!");
        }
    }
}