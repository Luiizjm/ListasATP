/* 10. Construa um algoritmo que calcule o peso ideal de uma pessoa. Dados de entrada: altura e
sexo. Fórmulas para cálculo do peso:
peso ideal de homem = (72,7 x altura) - 58
peso ideal da mulher = (62,1 x altura) - 44,7 */

// Solicita ao usuário que informe seu sexo, sendo 'H' para homem ou 'M' para mulher.
Console.Write("Qual seu sexo? \n H - Homem. \n M - Mulher. \n = ");
char sexo = char.Parse(Console.ReadLine().ToUpper());  // Lê o caractere de entrada e converte para o tipo 'char'.

// Solicita ao usuário que informe sua altura.
Console.Write("Digite sua Altura: ");
double altura = double.Parse(Console.ReadLine());  // Lê a altura fornecida pelo usuário e a converte para o tipo 'double'.

// Inicializa a variável 'peso_ideal', que será calculada com base na altura e no sexo.
double peso_ideal = 0;

// Utiliza a estrutura 'switch' para calcular o peso ideal com base no sexo informado.
switch (sexo)
{
    case 'H':
        // Fórmula para calcular o peso ideal de um homem: (72,7 x altura) - 58.
        peso_ideal = (72.7 * altura) - 58;
        Console.WriteLine($"O Peso ideal para Homens é: {peso_ideal:F2}");  // Exibe o peso ideal formatado com 2 casas decimais.
        break;
    case 'M':
        // Fórmula para calcular o peso ideal de uma mulher: (62,1 x altura) - 44,7.
        peso_ideal = (62.1 * altura) - 44.7;
        Console.WriteLine($"O Peso ideal para Mulheres é: {peso_ideal:F2}");  // Exibe o peso ideal formatado com 2 casas decimais.
        break;
    default:
        Console.WriteLine("Sexo inválido. Por favor, insira 'H' ou 'M'.");
        break;
}





