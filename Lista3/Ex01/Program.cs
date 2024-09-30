/* 1. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são
múltiplos de três e que se encontram no conjunto dos números de 1 até 500. */

using System;

class Program {
    
    public static void Main() {

        int soma = 0;  // Variável para armazenar a soma dos números que atendem às condições.

        // Laço 'for' que percorre os números ímpares de 1 até 500. 
        // O incremento de 2 (i+=2) garante que apenas números ímpares sejam considerados.
        for(int i = 1; i <= 500; i+=2) {

            // Verifica se o número atual é múltiplo de 3. Se for, ele será somado à variável 'soma'.
            if (i % 3 == 0) {
                soma += i;  // Soma o número ímpar múltiplo de 3 à variável 'soma'.
            }
        }

        // Exibe o valor total da soma.
        Console.WriteLine(soma);
    }
}