/*
10 - A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o
salário e número de filhos de cada habitante. A prefeitura deseja saber:
b) média do salário da população;
c) média do número de filhos;
d) percentual de pessoas com salário até R$1500,00.
O final da leitura de dados se dará com a entrada de um salário negativo. */

using System;

class Program
{
    public static void Main()
    {
        double salario;
        double somaSalario = 0; // Acumulador para a soma dos salários
        double somaNumeroDeFilhos = 0; // Acumulador para a soma do número de filhos
        int count1500 = 0; // Contador para pessoas com salário até 1500
        int count = 0; // Contador total de pessoas

        // Loop que continua até que um salário negativo seja inserido
        do
        {
            Console.Write("Digite o salário (valor negativo para encerrar): ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 0) break; // Sai do loop se o salário for negativo

            Console.Write("Digite o número de filhos: ");
            int numeroDeFilhos = int.Parse(Console.ReadLine());

            somaSalario += salario; // Adiciona o salário à soma total
            somaNumeroDeFilhos += numeroDeFilhos; // Adiciona o número de filhos à soma total

            if (salario <= 1500) count1500++; // Incrementa se o salário for até 1500

            count++; // Incrementa o total de pessoas

        } while (salario >= 0);

        // Verifica se houve pelo menos uma entrada válida
        if (count > 0)
        {
            double mediaSalario = somaSalario / count; // Calcula a média salarial
            double mediaFilhos = somaNumeroDeFilhos / count; // Calcula a média de filhos
            double porcentagem1500 = ((double)count1500 / count) * 100; // Calcula o percentual

            // Exibe os resultados das estatísticas
            Console.WriteLine("\nMédia do salário da população: {0:F2}", mediaSalario);
            Console.WriteLine("Média do número de filhos da população: {0:F2}", mediaFilhos);
            Console.WriteLine("Percentual de pessoas com salário até R$1500: {0:F2}%", porcentagem1500);
        }
        else
        {
            Console.WriteLine("Nenhum dado válido foi inserido."); // Mensagem caso nenhum dado válido seja inserido
        }
    }
}