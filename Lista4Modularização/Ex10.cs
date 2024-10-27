using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio10  // Define a classe 'Exercicio10'.
{
    // Método principal que inicia o programa.
    public static void Executar()
    {
        // Solicita ao usuário a nota do aluno.
        Console.WriteLine("Digite a nota do aluno: ");
        double media = double.Parse(Console.ReadLine());  // Lê e converte a entrada para um número decimal (double).

        // Chama o método CalcularMedia e armazena o resultado em 'res'.
        double res = CalcularMedia(media);
        Console.WriteLine(res);  // Exibe o resultado da média (mesmo valor lido).

        // Classifica a média em categorias.
        if (res < 4.9)  // Se a média for menor que 4.9, é D.
        {
            Console.WriteLine("Sua nota é média D !");
        }
        else if (res < 6.9)  // Se a média for menor que 6.9 e maior ou igual a 4.9, é C.
        {
            Console.WriteLine("Sua nota é média C !");
        }
        else if (res < 8.9)  // Se a média for menor que 8.9 e maior ou igual a 6.9, é B.
        {
            Console.WriteLine("Sua nota é média B !");
        }
        else  // Se a média for maior ou igual a 8.9, é A.
        {
            Console.WriteLine("Sua nota é média A !");
        }
    }

    // Método que calcula a média.
    static double CalcularMedia(double media)
    {
        return media /= 1;  // Retorna o valor da média. A divisão por 1 não altera o valor.
    }
}
