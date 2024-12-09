using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio6  // Define a classe 'Exercicio6'.
{
    // Método principal que inicia o programa.
    public static void Executar()
    {
        // Solicita ao usuário que digite o salário.
        Console.Write("Digite o salário: R$ ");
        double entrada_salario = double.Parse(Console.ReadLine());  // Lê e converte o salário digitado para um número decimal (double).

        // Solicita ao usuário que digite o valor do reajuste em porcentagem.
        Console.Write("Digite valor do reajuste (em porcentagem): ");
        double porcentagem = double.Parse(Console.ReadLine());  // Lê e converte a porcentagem digitada para um número decimal.

        porcentagem = porcentagem / 100;  // Converte a porcentagem para um valor decimal.

        // Chama o método 'ajuste' para calcular o novo salário.
        ajuste(entrada_salario, porcentagem);
    }

    // Método que calcula o reajuste do salário.
    static void ajuste(double entrada_salario, double porcentagem)
    {
        // Calcula o valor do reajuste.
        double reajuste = entrada_salario * porcentagem;
        
        // Calcula o salário final após o reajuste.
        double salario_final = entrada_salario + reajuste;

        // Exibe o salário final formatado com duas casas decimais.
        Console.WriteLine($"O Valor final do salário é de R${salario_final.ToString("F2")}");
    }
}
