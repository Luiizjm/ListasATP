/* 7. screva um programa que receba a temperatura em graus Celsius e a converta para
Fahrenheit. Se a temperatura estiver abaixo de 0°C, exiba uma mensagem informando que
está "Muito frio"; se estiver entre 0°C e 30°C, informe "Clima agradável"; e se for maior
que 30°C, informe "Muito quente". */

Console.Write("Digite a temperatura em Celsius: ");
int celsius = int.Parse(Console.ReadLine());

int fh = 0;
fh = (celsius * 9 / 5) + 32;

Console.WriteLine($"A conversão de {celsius}° Celsius para Fahrenheit é de {fh}°.");

if (celsius < 0) Console.WriteLine("Muito Frio!");
else if (celsius < 30) Console.WriteLine("Clima Agradável!");
else Console.WriteLine("Muito Quente!");





