using System;  // Importa o namespace System, necessário para usar a classe Console.

public class Exercicio5  // Define a classe Exercicio5.
{
    // Método principal que chama os métodos para sortear números e realizar a adivinhação.
    public static void Rodar()
    {
        // Sorteia 5 números aleatórios e armazena em um vetor.
        int[] NumerosSorteados = SortearNumeros();

        // Exibe os números sorteados (para fins de teste).
        Console.WriteLine($"Números sorteados (apenas para testes): {NumerosSorteados[0]}, {NumerosSorteados[1]}, {NumerosSorteados[2]}, {NumerosSorteados[3]}, {NumerosSorteados[4]}");

        // Chama o método Adivinhe para o usuário tentar adivinhar os números sorteados.
        Adivinhe(NumerosSorteados);
    }

    // Método para sortear 5 números aleatórios entre 10 e 30 (inclusive).
    static int[] SortearNumeros()
    {
        Random random = new Random();  // Cria um objeto Random para gerar números aleatórios.
        int[] numeros = new int[5];  // Cria um vetor para armazenar os números sorteados.

        // Laço para preencher o vetor com números sorteados entre 10 e 30.
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(10, 31);  // Sorteia um número entre 10 (inclusivo) e 31 (exclusivo).
        }

        return numeros;  // Retorna o vetor com os números sorteados.
    }

    // Método para permitir que o usuário tente adivinhar os números sorteados.
    static void Adivinhe(int[] NumerosSorteados)
    {
        while (true)  // Inicia um loop que continuará até que o usuário acerte.
        {
            Console.Write("Tente adivinhar um número entre 10 e 30: ");
            int res;

            // Tenta converter a entrada do usuário para um número inteiro.
            if (int.TryParse(Console.ReadLine(), out res))
            {
                bool acertou = false;  // Flag para verificar se o usuário acertou.

                // Laço para verificar se o número inserido está no vetor de números sorteados.
                foreach (int numero in NumerosSorteados)
                {
                    if (numero == res)
                    {
                        acertou = true;  // Se acertar, a flag é marcada como true.
                        break;  // Encerra o loop, pois não é necessário continuar verificando.
                    }
                }

                // Se acertou, exibe uma mensagem de sucesso e sai do loop.
                if (acertou)
                {
                    Console.WriteLine($"Parabéns! Você acertou: {res}");
                    break;  // Encerra o loop principal.
                }
                else
                {
                    Console.WriteLine("Errou! Tente novamente:");  // Se errou, solicita uma nova tentativa.
                }
            }
            else
            {
                // Caso o usuário insira algo que não seja um número válido, exibe uma mensagem de erro.
                Console.WriteLine("Por favor, insira um número válido entre 10 e 30.");
            }
        }
    }
}
