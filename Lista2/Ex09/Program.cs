/* 9. Desenvolva um programa que peça ao usuário para entrar com um número de 1 a 7 e exiba
o dia da semana correspondente (1 para domingo, 2 para segunda-feira, etc.). Caso o número
não esteja nesse intervalo, exiba "Número inválido". */

// Solicita ao usuário que insira um número de 1 a 7, representando os dias da semana.
Console.Write("Digite um número da semana de 1 a 7: ");
int dia = int.Parse(Console.ReadLine());  // Lê e converte o número inserido pelo usuário para inteiro.

// Verifica se o número está fora do intervalo permitido (1 a 7).
if (dia < 1 || dia > 7)
{
    // Se o número for menor que 1 ou maior que 7, exibe a mensagem de número inválido.
    Console.Write("Número inválido.");
}
else
{
    // Se o número estiver dentro do intervalo (1 a 7), utiliza a estrutura switch para identificar o dia correspondente.
    switch (dia)
    {
        case 1:
            Console.WriteLine("Dia 1 = Domingo.");  // Se o número for 1, exibe "Domingo".
            break;
        case 2:
            Console.WriteLine("Dia 2 = Segunda-Feira.");  // Se o número for 2, exibe "Segunda-Feira".
            break;
        case 3:
            Console.WriteLine("Dia 3 = Terça-Feira.");  // Se o número for 3, exibe "Terça-Feira".
            break;
        case 4:
            Console.WriteLine("Dia 4 = Quarta-Feira.");  // Se o número for 4, exibe "Quarta-Feira".
            break;
        case 5:
            Console.WriteLine("Dia 5 = Quinta-Feira.");  // Se o número for 5, exibe "Quinta-Feira".
            break;
        case 6:
            Console.WriteLine("Dia 6 = Sexta-Feira.");  // Se o número for 6, exibe "Sexta-Feira".
            break;
        case 7:
            Console.WriteLine("Dia 7 = Sábado.");  // Se o número for 7, exibe "Sábado".
            break;
    }
}