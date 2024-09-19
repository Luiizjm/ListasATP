/* 8. Crie um programa que leia a quantidade de horas trabalhadas e o valor do salário por hora
de um funcionário. Calcule o salário bruto e, considerando as faixas de desconto (8% até R$
900,00; 9% de R$ 900,01 a R$ 1500,00; 10% de R$ 1500,01 a R$ 2500,00; 11% acima de
R$ 2500,00), exiba o salário líquido do funcionário. */

// Solicita a quantidade de horas trabalhadas ao usuário.
Console.Write("Digite as horas trabalhadas: ");
int horas_trabalhadas = int.Parse(Console.ReadLine());  // Lê e converte as horas trabalhadas para inteiro.

// Solicita o valor do salário por hora ao usuário.
Console.Write("Digite o salário por hora do funcionário: ");
double salario_por_hora = double.Parse(Console.ReadLine());  // Lê e converte o salário por hora para double.

// Calcula o salário bruto com base nas horas trabalhadas em um mês (30 dias).
double salario_bruto = (double) horas_trabalhadas * salario_por_hora * 30;  // Salário bruto = horas trabalhadas * salário por hora * 30 dias.

// Inicializa a variável para o salário líquido.
double salario_liquido = 0;

// Aplica o desconto conforme a faixa salarial e calcula o salário líquido.
if (salario_bruto <= 900)  
{
    // Se o salário bruto for até R$ 900,00, aplica 8% de desconto.
    salario_liquido = salario_bruto - (salario_bruto * 0.08);
    Console.WriteLine($"O Salário Líquido do funcionário é de R${salario_liquido:F2}");  // Exibe o salário líquido formatado com 2 casas decimais.
}
else if (salario_bruto <= 1500)  
{
    // Se o salário bruto estiver entre R$ 900,01 e R$ 1500,00, aplica 9% de desconto.
    salario_liquido = salario_bruto - (salario_bruto * 0.09);
    Console.WriteLine($"O Salário Líquido do funcionário é de R${salario_liquido:F2}");
}
else if (salario_bruto <= 2500)  
{
    // Se o salário bruto estiver entre R$ 1500,01 e R$ 2500,00, aplica 10% de desconto.
    salario_liquido = salario_bruto - (salario_bruto * 0.1);
    Console.WriteLine($"O Salário Líquido do funcionário é de R${salario_liquido:F2}");
}
else  
{
    // Se o salário bruto for superior a R$ 2500,00, aplica 11% de desconto.
    salario_liquido = salario_bruto - (salario_bruto * 0.11);
    Console.WriteLine($"O Salário Líquido do funcionário é de R${salario_liquido:F2}");
}