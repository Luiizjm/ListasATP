using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio3  // Define a classe 'Exercicio3'.
{
    // Método principal que inicia o programa.
    public static void Executar()
    {
        // Solicita ao usuário a quantidade de triângulos a serem analisados.
        Console.WriteLine("Digite a quantidade de triângulos: ");
        int quant_triangulos = int.Parse(Console.ReadLine());  // Lê e converte o valor digitado para um inteiro.

        // Chama o método 'triangulos', passando a quantidade de triângulos como parâmetro.
        triangulos(quant_triangulos);
    }

    // Método que verifica o tipo de cada triângulo com base nas medidas dos lados.
    static void triangulos(int quant_triangulos)
    {
        // Laço para coletar dados e determinar o tipo de triângulo para cada entrada.
        for (int i = 0; i < quant_triangulos; i++)
        {
            // Solicita ao usuário as medidas dos três lados do triângulo.
            Console.WriteLine("Digite os comprimentos dos 3 lados do triângulo: ");
            Console.Write("X: ");
            double X = double.Parse(Console.ReadLine());  // Lê o valor de X como string e converte para double.
            Console.Write("Y: ");
            double Y = double.Parse(Console.ReadLine());  // Lê o valor de Y como string e converte para double.
            Console.Write("Z: ");
            double Z = double.Parse(Console.ReadLine());  // Lê o valor de Z como string e converte para double.

            // Verifica o tipo de triângulo com base nos comprimentos dos lados.
            if (X == Y && X == Z)  // Verifica se todos os lados são iguais.
            {
                Console.WriteLine("Triângulo Equilátero!");  // Exibe que o triângulo é equilátero.
            }
            else if (X == Y || X == Z || Z == Y)  // Verifica se dois lados são iguais.
            {
                Console.WriteLine("Triângulo Isósceles!");  // Exibe que o triângulo é isósceles.
            }
            else  // Caso nenhum lado seja igual.
            {
                Console.WriteLine("Triângulo Escaleno!");  // Exibe que o triângulo é escaleno.
            }
        }
    }
}
