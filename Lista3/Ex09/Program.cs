/*
9 - Em uma eleição presidencial existem quatro candidatos. Os votos são informados através
de códigos. Os dados utilizados para a contagem dos votos obedecem à seguinte
codificação:
1,2,3,4 = voto para os respectivos candidatos;
5 = voto nulo;
6 = voto em branco;
Elabore um algoritmo que leia o código do candidato em um voto. Calcule e escreva:
- total de votos para cada candidato;
- total de votos nulos;
- total de votos em branco.
Como finalizador do conjunto de votos, tem-se o valor 0. */


using System;

class Program
{
    public static void Main()
    {
        // Exibe as opções de voto
        Console.WriteLine("0- Encerrar contagem");
        Console.WriteLine("1- Diniz");
        Console.WriteLine("2- Michael");
        Console.WriteLine("3- Verônica");
        Console.WriteLine("4- Sérgio");
        Console.WriteLine("5- nulo");
        Console.WriteLine("6- em branco");

        // Variáveis para contar os votos de cada candidato e votos especiais
        int votoDiniz = 0, votoMichael = 0, votoVeronica = 0, votoSergio = 0, votoNulo = 0, votoEmBranco = 0;
        int voto;

        // Loop que continua até que o voto 0 seja inserido
        do
        {
            Console.Write("Digite seu voto: ");
            voto = int.Parse(Console.ReadLine());

            // Incrementa o contador correspondente ao voto
            if (voto == 1)
                votoDiniz++;
            else if (voto == 2)
                votoMichael++;
            else if (voto == 3)
                votoVeronica++;
            else if (voto == 4)
                votoSergio++;
            else if (voto == 5)
                votoNulo++;
            else if (voto == 6)
                votoEmBranco++;
            else if (voto <= 7)
                Console.WriteLine("Numero não consta no banco de dados para votação!!!");

        } while (voto != 0);

        Console.Clear(); // Limpa a tela após a contagem

        // Exibe o total de votos para cada categoria
        Console.WriteLine($"Votos em Diniz: {votoDiniz}");
        Console.WriteLine($"Votos em Michael: {votoMichael}");
        Console.WriteLine($"Votos em Verônica: {votoVeronica}");
        Console.WriteLine($"Votos em Sergio: {votoSergio}");
        Console.WriteLine($"Votos nulos: {votoNulo}");
        Console.WriteLine($"Votos em branco: {votoEmBranco}");

    }
}