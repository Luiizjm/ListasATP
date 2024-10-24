using System;

public class Exercicio1
{
    public static void Executar()
    {
        int a, n;  // Declara as variáveis 'a' (base) e 'n' (expoente).

        // Solicita ao usuário a base (valor que será elevado).
        Console.Write("Digite a base: ");
        a = int.Parse(Console.ReadLine());  // Lê a base como string e converte para inteiro.

        // Solicita ao usuário o expoente (valor pelo qual a base será elevada).
        Console.Write("Digite o seu expoente: ");
        n = int.Parse(Console.ReadLine());  // Lê o expoente como string e converte para inteiro.

        // Chama a função 'potencia', passando a base e o expoente, e armazena o resultado na variável 'res'.
        int res = potencia(a, n);

        // Exibe o resultado da potência para o usuário.
        Console.WriteLine($"O resultado de {a} elevado a {n} é igual a {res}!");
    }

    // Função que calcula a potência de 'a' elevado a 'n' usando multiplicação sucessiva.
    static int potencia(int a, int n)
    {
        int r = 1;  // Variável 'r' começa com valor 1, pois será o acumulador do resultado da potência.

        // Laço 'for' que multiplica a base 'a' por si mesma 'n' vezes.
        for (int i = 1; i <= n; i++)
        {
            r = r * a;  // A cada iteração, 'r' é multiplicado pela base 'a' (acumulando o valor da potência).
        }

        // Retorna o resultado final da potência.
        return r;
    }
}

