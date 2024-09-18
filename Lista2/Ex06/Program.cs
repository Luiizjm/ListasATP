/* 6. Desenvolva um programa que leia o nome e as três notas de um aluno. Calcule a média das
notas e exiba se o aluno foi aprovado (média ≥ 7), em recuperação (5 ≤ média < 7) ou
reprovado (média < 5). */

Console.Write("Digite o nome do Aluno: ");
string nome = Console.ReadLine();

Console.Write("Digite sua primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite sua segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite sua terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

if (media > 7) Console.WriteLine($"Parabéns o aluno {nome} foi aprovado com a média de {media:F2}!!");
else if (media < 5) Console.WriteLine($"Aluno {nome} foi reprovado com a média de {media:F2}.");
else Console.WriteLine($"O aluno {nome} ficou em recuperação com a média de {media:F2}.");
