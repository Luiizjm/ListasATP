/* 
4- O código de César é uma das mais simples e conhecidas técnicas de criptografia. 
Implemente um programa que faça uso desse Código de César (3 posições), entre com uma string e retorne a string codificada.
*/

using System;

namespace Ex04
{
    internal class Program
    {
        static void Main()
        {
            // Ler a string de entrada
            Console.WriteLine("Digite a string a ser codificada:");
            string entrada = Console.ReadLine();

            // Definir o número de posições de deslocamento (Código de César)
            int deslocamento = 3;

            // Codificar a string e armazenar o resultado
            string resultado = "";

            // Iterar sobre cada caractere da string
            foreach (char c in entrada)
            {
                // Se for uma letra minúscula
                if (c >= 'a' && c <= 'z')
                {
                    // Deslocar a letra dentro do alfabeto
                    char novaLetra = (char)(c + deslocamento);

                    // Se a letra ultrapassar 'z', voltar para 'a'
                    if (novaLetra > 'z')
                    {
                        novaLetra = (char)(c - (26 - deslocamento));
                    }

                    // Adicionar a letra codificada à string resultado
                    resultado += novaLetra;
                }
                // Se for uma letra maiúscula
                else if (c >= 'A' && c <= 'Z')
                {
                    // Deslocar a letra dentro do alfabeto
                    char novaLetra = (char)(c + deslocamento);

                    // Se a letra ultrapassar 'Z', voltar para 'A'
                    if (novaLetra > 'Z')
                    {
                        novaLetra = (char)(c - (26 - deslocamento));
                    }

                    // Adicionar a letra codificada à string resultado
                    resultado += novaLetra;
                }
                else
                {
                    // Caracteres não alfabéticos são adicionados sem alterações
                    resultado += c;
                }
            }

            // Exibir o resultado
            Console.WriteLine($"Nova string: {resultado}");
        }
    }
}