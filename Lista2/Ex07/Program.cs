/* 7. screva um programa que receba a temperatura em graus Celsius e a converta para
Fahrenheit. Se a temperatura estiver abaixo de 0°C, exiba uma mensagem informando que
está "Muito frio"; se estiver entre 0°C e 30°C, informe "Clima agradável"; e se for maior
que 30°C, informe "Muito quente". */

// Solicita a temperatura em graus Celsius ao usuário.
Console.Write("Digite a temperatura em Celsius: ");
int celsius = int.Parse(Console.ReadLine());  // Lê a temperatura fornecida e a converte para um número inteiro.

int fh = 0;  // Inicializa a variável 'fh' para armazenar a temperatura convertida para Fahrenheit.

// Converte a temperatura de Celsius para Fahrenheit usando a fórmula: F = (C * 9 / 5) + 32.
fh = (celsius * 9 / 5) + 32;

// Exibe a conversão da temperatura de Celsius para Fahrenheit.
Console.WriteLine($"A conversão de {celsius}° Celsius para Fahrenheit é de {fh}°.");

// Verifica o intervalo da temperatura em Celsius e exibe a mensagem correspondente.
if (celsius < 0)
{  // Se a temperatura for menor que 0°C.
    Console.WriteLine("Muito Frio!");  // Informa que está muito frio.
}
else if (celsius < 30)
{  // Se a temperatura estiver entre 0°C e 30°C.
    Console.WriteLine("Clima Agradável!");  // Informa que o clima está agradável.
}
else
{ // Se a temperatura for maior que 30°C.
    Console.WriteLine("Muito Quente!");  // Informa que está muito quente.
}
