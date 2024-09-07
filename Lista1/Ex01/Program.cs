/*  1- Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas notas,
onsiderando peso 2 para a primeira nota e peso 3 para a segunda nota. */

// Declaração das variáveis para armazenar as notas, pesos e a média ponderada
int nota1, nota2, peso1 = 2, peso2 = 3;
double mediaponderada;

// Solicita ao usuário que insira a primeira nota e armazena o valor na variável 'nota1'
// A função int.Parse() é usada para converter a string de entrada em um inteiro
Console.Write("Digite a primeira Nota: ");
nota1 = int.Parse(Console.ReadLine());

// Solicita ao usuário que insira a segunda nota e armazena o valor na variável 'nota2'
Console.Write("Digite a segunda Nota: ");
nota2 = int.Parse(Console.ReadLine());

// Calcula a média ponderada das duas notas
// Multiplica cada nota pelo seu respectivo peso e depois divide pela soma dos pesos
mediaponderada = (double)(nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

// Exibe a média ponderada formatada com duas casas decimais
// O formato ":F02" é usado para garantir a exibição de duas casas decimais
Console.Write($"A Média das notas é: {mediaponderada:F02}");