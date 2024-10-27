using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio5  // Define a classe 'Exercicio5'.
{
    // Método principal que inicia o programa.
    public static void Executar()
    {
        int num = 0;  // Inicializa a variável num que armazenará o número lido.
        bool res;     // Inicializa a variável res que armazenará o resultado da verificação.

        // Solicita ao usuário que digite quantos números deseja ler.
        Console.WriteLine("Quantos números quer ler? ");
        int N = int.Parse(Console.ReadLine());  // Lê e converte a quantidade de números a serem lidos.

        // Loop para ler N números.
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite um número: ");  // Solicita ao usuário que digite um número.
            num = int.Parse(Console.ReadLine());  // Lê e converte o número digitado para um inteiro.
            res = leitor(num);  // Chama o método 'leitor' para verificar se o número é positivo.
            Console.WriteLine($"{num} = {res}");  // Exibe o número e o resultado da verificação.
        }
    }

    // Método que verifica se o número é positivo.
    static bool leitor(int N) 
    {
        // Se N for maior que zero, retorna true, indicando que é positivo.
        if (N > 0)
        {
            return true;
        }
        else
        {
            return false;  // Caso contrário, retorna false.
        }
    }
}
