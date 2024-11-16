using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio2  // Define a classe 'Exercicio2'.
{
    // Método principal que chama os outros métodos para executar o cálculo e exibição de resultados.
    public static void Rodar()
    {
        // Cria um array para armazenar as notas dos alunos. O tamanho do array é 10.
        double[] NotasAlunos = new double[10];

        // Chama o método VetNotas para preencher o array com as notas dos alunos.
        VetNotas(NotasAlunos);

        // Chama o método CalculoNotas para calcular e exibir a média e a quantidade de alunos acima da média.
        CalculoNotas(NotasAlunos);
    }

    // Método para preencher o array 'NotasAlunos' com as notas fornecidas pelo usuário.
    public static void VetNotas(double[] NotasAlunos)
    {
        Console.WriteLine("Digite as Notas dos alunos");

        // Laço que percorre o array e solicita que o usuário digite a nota de cada aluno.
        for (int i = 0; i < NotasAlunos.Length; i++)
        {
            NotasAlunos[i] = double.Parse(Console.ReadLine());  // Lê a entrada do usuário e armazena no array.
        }
    }

    // Método para calcular a média das notas e contar quantos alunos estão acima da média.
    public static void CalculoNotas(double[] NotasAlunos)
    {
        double Notas = 0, Media = 0;  // Inicializa variáveis para somar as notas e calcular a média.
        int NotasAcimaDaMedia = 0;  // Inicializa contador para alunos acima da média.

        // Laço que percorre o array de notas e soma todas as notas.
        for (int i = 0; i < NotasAlunos.Length; i++)
        {
            Notas += NotasAlunos[i];  // Soma as notas dos alunos.
        }

        // Calcula a média dividindo a soma das notas pelo número de alunos.
        Media = Notas / NotasAlunos.Length;

        // Laço que percorre o array de notas e conta quantos alunos têm notas acima da média.
        for (int i = 0; i < NotasAlunos.Length; i++)
        {
            if (NotasAlunos[i] < Media)  // Verifica se a nota do aluno é abaixo da média.
            {
                NotasAcimaDaMedia++;  // Incrementa o contador de alunos acima da média.
            }
        }

        // Exibe a média dos alunos e o número de alunos acima da média.
        Console.WriteLine("A média dos alunos é de: " + Media);
        Console.WriteLine("Alunos acima da média: " + NotasAcimaDaMedia);
    }
}
