/* 6. Desenvolva um programa que leia o nome e as três notas de um aluno. Calcule a média das
notas e exiba se o aluno foi aprovado (média ≥ 7), em recuperação (5 ≤ média < 7) ou
reprovado (média < 5). */

// Solicita o nome do aluno.
Console.Write("Digite o nome do Aluno: ");
string nome = Console.ReadLine();  // Lê o nome do aluno como uma string.

// Solicita a primeira nota do aluno.
Console.Write("Digite sua primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());  // Lê a nota como um número decimal (double).

// Solicita a segunda nota do aluno.
Console.Write("Digite sua segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());  // Lê a segunda nota como um número decimal.

// Solicita a terceira nota do aluno.
Console.Write("Digite sua terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());  // Lê a terceira nota como um número decimal.

// Calcula a média das três notas.
double media = (nota1 + nota2 + nota3) / 3;

// Verifica a média do aluno para determinar a sua situação (aprovado, recuperação ou reprovado).
if (media > 7)
{
    // Se a média for maior que 7, o aluno é aprovado.
    Console.WriteLine($"Parabéns o aluno {nome} foi aprovado com a média de {media:F2}!!");  // Exibe mensagem de aprovação com a média formatada para 2 casas decimais.
}
else if (media < 5)
{
    // Se a média for menor que 5, o aluno é reprovado.
    Console.WriteLine($"Aluno {nome} foi reprovado com a média de {media:F2}.");  // Exibe mensagem de reprovação com a média formatada.
}
else
{
    // Se a média estiver entre 5 e 7, o aluno está em recuperação.
    Console.WriteLine($"O aluno {nome} ficou em recuperação com a média de {media:F2}.");  // Exibe mensagem de recuperação com a média formatada.
}

