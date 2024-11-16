using System;

public class Exercicio6
{
    public static void Rodar()
    {
        // Inicializa o vetor para armazenar as temperaturas de 31 dias (outubro)
        double[] temperaturas = new double[31];

        // Preenche o vetor com as temperaturas (simulando com valores aleatórios entre 15 e 40 graus Celsius)
        Random random = new Random();
        for (int i = 0; i < temperaturas.Length; i++)
        {
            temperaturas[i] = random.NextDouble() * (40 - 15) + 15; // Temperaturas entre 15 e 40°C
        }

        // Exibe as temperaturas geradas para cada dia do mês de outubro
        Console.WriteLine("Temperaturas de outubro:");
        foreach (var temp in temperaturas)
        {
            Console.WriteLine(temp.ToString("F2") + "°C");
        }

        // Calcula e exibe os resultados
        double menorTemperatura = EncontrarMenorTemperatura(temperaturas);
        double maiorTemperatura = EncontrarMaiorTemperatura(temperaturas);
        double temperaturaMedia = CalcularMediaTemperaturas(temperaturas);
        int diasAbaixoMedia = ContarDiasAbaixoMedia(temperaturas, temperaturaMedia);

        Console.WriteLine($"\nResultados:");
        Console.WriteLine($"a) Menor temperatura: {menorTemperatura:F2}°C");
        Console.WriteLine($"   Maior temperatura: {maiorTemperatura:F2}°C");
        Console.WriteLine($"b) Temperatura média: {temperaturaMedia:F2}°C");
        Console.WriteLine($"c) Dias com temperatura abaixo da média: {diasAbaixoMedia}");
    }

    // Encontra a menor temperatura do vetor de temperaturas
    static double EncontrarMenorTemperatura(double[] temperaturas)
    {
        double menor = temperaturas[0];  // Assume que o primeiro valor é o menor
        foreach (var temp in temperaturas)
        {
            if (temp < menor)  // Se algum valor for menor, atualiza o valor de menor
            {
                menor = temp;
            }
        }
        return menor;  // Retorna a menor temperatura encontrada
    }

    // Encontra a maior temperatura do vetor de temperaturas
    static double EncontrarMaiorTemperatura(double[] temperaturas)
    {
        double maior = temperaturas[0];  // Assume que o primeiro valor é o maior
        foreach (var temp in temperaturas)
        {
            if (temp > maior)  // Se algum valor for maior, atualiza o valor de maior
            {
                maior = temp;
            }
        }
        return maior;  // Retorna a maior temperatura encontrada
    }

    // Calcula a média das temperaturas
    static double CalcularMediaTemperaturas(double[] temperaturas)
    {
        double soma = 0;  // Inicializa a soma das temperaturas
        foreach (var temp in temperaturas)
        {
            soma += temp;  // Soma todas as temperaturas
        }
        return soma / temperaturas.Length;  // Retorna a média das temperaturas
    }

    // Conta os dias com temperatura abaixo da média
    static int ContarDiasAbaixoMedia(double[] temperaturas, double media)
    {
        int contador = 0;  // Inicializa o contador de dias abaixo da média
        foreach (var temp in temperaturas)
        {
            if (temp < media)  // Se a temperatura for abaixo da média, incrementa o contador
            {
                contador++;
            }
        }
        return contador;  // Retorna o número de dias abaixo da média
    }
}
