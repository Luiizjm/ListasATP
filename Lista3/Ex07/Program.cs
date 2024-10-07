/*
7 - Escrever um algoritmo que leia uma quantidade desconhecida de números e conte quantos
deles estão nos seguintes intervalos: [0-25], [26-50], [51-75] e [76-100]. A entrada de
dados deve terminar quando for lido um número negativo. */


using System;

class Program
{
    public static void Main()
    {
        int num = 0, zeroAVintecinco = 0, vinteseisACinquenta = 0, cinquentaEUmASetentaEcinco = 0, setentaESeisACem = 0;

        // Loop que continua até que um número negativo seja inserido
        do
        {
            Console.Write("Digite o numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > -1 && num < 26) // Verifica se está entre 0 e 25
                zeroAVintecinco++;

            if (num > 25 && num < 51) // Verifica se está entre 26 e 50
                vinteseisACinquenta++;

            if (num > 50 && num < 76) // Verifica se está entre 51 e 75
                cinquentaEUmASetentaEcinco++;

            if (num > 75 && num < 101) // Verifica se está entre 76 e 100
                setentaESeisACem++;
        } while (num > -1);

        // Exibe a contagem de números em cada intervalo
        Console.WriteLine($"Numero de: \n0 a 25 - {zeroAVintecinco}\n26 a 50 - {vinteseisACinquenta}\n51 a 75 - {cinquentaEUmASetentaEcinco}\n76 a 100 - {setentaESeisACem}");
    }
}