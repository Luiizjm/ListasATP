using System;

class Program
{
    private static void Main(string[] args)
    {
        menu();
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Exercicio1.Executar();
                break;
            default:
                break;
        }
    }





    public static void menu()
    {
        Console.WriteLine("Escolha o número do exercicio de 1 a 10!");
        Console.WriteLine("1 - Exercicio 1.");
        Console.WriteLine("2 - Exercicio 2.");
        Console.WriteLine("3 - Exercicio 3.");
        Console.WriteLine("4 - Exercicio 4.");
        Console.WriteLine("5 - Exercicio 5.");
        Console.WriteLine("6 - Exercicio 6.");
        Console.WriteLine("7 - Exercicio 7.");
        Console.WriteLine("8 - Exercicio 8.");
        Console.WriteLine("9 - Exercicio 9.");
        Console.WriteLine("10 - Exercicio 10.");
        Console.WriteLine("11- Sair.");
    }
}
