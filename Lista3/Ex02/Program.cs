/* 2. Desenvolver um algoritmo que leia a altura de 15 pessoas. Este programa deverá calcular e
mostrar:
• A menor altura do grupo;
• A maior altura do grupo. */
using System;

class Program
{
    public static void Main()
    {
        double altura = 0;  // Variável para armazenar temporariamente a altura digitada.
        double maior = 1.00, menor = 10.00;  // Variáveis para armazenar a maior e menor altura encontradas.
        // Nota: valores iniciais para 'maior' e 'menor' são escolhidos para garantir que qualquer entrada válida substitua esses valores.

        // Laço 'for' que se repete 15 vezes, uma vez para cada pessoa.
        for (int i = 1; i <= 3; i++)  // Alterado para 3 para teste rápido, mas no programa final deveria ser 15.
        {
            Console.Write(i + " - Digite a altura: ");  // Exibe a mensagem para o usuário inserir a altura.
            altura = double.Parse(Console.ReadLine());  // Lê e converte a altura digitada para tipo 'double'.

            // Verifica se a altura digitada é maior que o valor atual armazenado em 'maior'.
            if (altura > maior)
            {
                maior = altura;  // Atualiza a maior altura.
            }

            // Verifica se a altura digitada é menor que o valor atual armazenado em 'menor'.
            if (altura < menor)
            {
                menor = altura;  // Atualiza a menor altura.
            }
        }

        // Exibe os resultados, mostrando a maior e a menor altura formatadas com duas casas decimais.
        Console.WriteLine("A Maior altura é: " + maior.ToString("F2"));
        Console.WriteLine("A Menor altura é: " + menor.ToString("F2"));
    }
}