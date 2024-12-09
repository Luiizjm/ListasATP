using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio7  // Define a classe 'Exercicio7'.
{
    // Método principal que inicia o programa.
    public static void Executar()
    {
        int contagem_aluno = 0;  // Inicializa a contagem de alunos.
        double notas_totais = 0;  // Inicializa a soma das notas.

        // Solicita ao usuário que digite a quantidade de alunos.
        Console.WriteLine("Digite a quantidade de alunos: ");
        int n = int.Parse(Console.ReadLine());  // Lê e converte a entrada para um inteiro.

        // Laço que itera pela quantidade de alunos.
        for (int i = 0; i < n; i++)
        {
            // Solicita a nota de cada aluno.
            Console.WriteLine("Digite a nota do aluno:");
            double nota_aluno = double.Parse(Console.ReadLine());  // Lê e converte a nota para um número decimal.
            notas_totais += nota_aluno;  // Adiciona a nota à soma total.
            contagem_aluno++;  // Incrementa a contagem de alunos.
        }

        // Chama o método 'CalcularMedia' para calcular a média das notas.
        double media = CalcularMedia(notas_totais, contagem_aluno);

        // Verifica se a média é maior ou igual a 6.0 para determinar a aprovação ou reprovação.
        if (media >= 6.0)
        {
            Console.WriteLine($"{media:F2} = Aprovado!");  // Exibe a média e que o aluno foi aprovado.
        }
        else 
        {
            Console.WriteLine($"{media:F2} = !");  // Exibe a média e que o aluno foi reprovado.
        }
    }

    // Método que calcula a média das notas.
    static double CalcularMedia(double notas_totais, double contagem_aluno) 
    {
        return notas_totais / contagem_aluno;  // Retorna a média das notas.
    }
}
