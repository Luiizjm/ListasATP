using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio2  // Define a classe 'Exercicio2'.
{
    // Método público que será executado quando o programa iniciar.
    public static void Executar()
    {
        // Solicita ao usuário o número de pessoas.
        Console.WriteLine("Digite a quantidade de pessoas: ");
        int n = int.Parse(Console.ReadLine());  // Lê e converte o valor digitado para um número inteiro.

        // Chama o método 'dados', passando o número de pessoas como parâmetro.
        dados(n);
    }

    // Método 'dados' que calcula a média dos salários da população.
    static void dados(int n)
    {
        int contagem_salarios = 0;  // Variável para contar o número de salários informados.
        double total_salarios = 0, media = 0;  // 'total_salarios' acumula o valor total dos salários e 'media' armazena o valor médio.

        // Laço que repete o processo de entrada de dados 'n' vezes (para cada pessoa).
        for (int i = 0; i < n; i++)
        {
            // Solicita e lê o salário da pessoa.
            Console.WriteLine("Qual o seu salário?");
            double salario = double.Parse(Console.ReadLine());  // Lê o salário como string e converte para double.

            // Solicita e lê o número de filhos da pessoa.
            Console.WriteLine("Quantos filhos você tem?");
            int filhos = int.Parse(Console.ReadLine());  // Lê o número de filhos e converte para inteiro.

            // Incrementa o contador de salários e adiciona o salário ao total.
            contagem_salarios++;
            total_salarios += salario;
        }

        // Calcula a média dos salários.
        media = total_salarios / contagem_salarios;
        
        // Exibe a média de salários formatada com duas casas decimais.
        Console.WriteLine("A média de salários da população é de R$" + media.ToString("F2"));
    }
}
