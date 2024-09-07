/* 2- Faça um programa que receba o preço de um produto, calcule e mostre o novo preço, sabendo-
se que este sofreu um desconto de 10%. */

// Declaração das variáveis para armazenar o preço original, o valor do desconto e o preço final
double preco, desconto, precofinal;

// Solicita ao usuário que insira o preço do produto
// O método double.Parse() é utilizado para converter a string de entrada em um valor do tipo double
Console.Write("Digite o Preço: ");
preco = double.Parse(Console.ReadLine());

// Calcula o valor do desconto de 10% sobre o preço original
// Multiplica o preço por 0.1 para obter 10% do valor
desconto = preco * 0.1;

// Calcula o preço final subtraindo o valor do desconto do preço original
precofinal = preco - desconto;

// Exibe o valor do desconto aplicado
Console.WriteLine($"Seu desconto é de R$ {desconto}.");

// Exibe o preço final após a aplicação do desconto
Console.Write($"Seu preço final é R$ {precofinal}.");