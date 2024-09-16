using System;

class Program {
    static void Main() {

        Console.WriteLine("Digite um ano e descubra se é Bissexto: ");
        int ano = int.Parse(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)) {
            Console.WriteLine($"O Ano {ano} é Bissexto.");
        }
        else {
            Console.WriteLine($"O Ano {ano} não é Bissexto.");
        }

    }
}