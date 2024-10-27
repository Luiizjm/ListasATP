using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio8  // Define a classe 'Exercicio8'.
{
    // Método principal que inicia o programa.
    public static void Executar()
    {
        // Solicita ao usuário que digite um número para verificar se é primo.
        Console.WriteLine("Digite um número e descubra se ele é primo! ");
        int n = int.Parse(Console.ReadLine());  // Lê e converte a entrada para um inteiro.

        // Chama o método 'primo' e armazena o resultado em 'res'.
        bool res = primo(n);

        // Verifica o resultado e exibe se o número é primo ou não.
        if (res == true)
        {
            Console.WriteLine($"O número {n} é Primo!");  // Se for primo, exibe a mensagem.
        }
        else
        {
            Console.WriteLine($"O número {n} Não é Primo!");  // Se não for primo, exibe a mensagem.
        }
    }

    // Método que verifica se um número é primo.
    static bool primo(int n)
    {
        // Se o número for menor ou igual a 1, não é primo.
        if (n <= 1)
        {
            return false;  // Retorna falso para números não primos.
        }
        else
        {
            // Loop para verificar divisores de 2 até a raiz quadrada de n.
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                // Se n é divisível por i, não é primo.
                if (n % i == 0)
                {
                    return false;  // Retorna falso se encontrar um divisor.
                }
            }
        }

        return true;  // Retorna verdadeiro se n não tiver divisores além de 1 e ele mesmo.
    }
}
