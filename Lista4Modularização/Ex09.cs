using System;  // Importa o namespace System, que contém classes essenciais como Console.

public class Exercicio9  // Define a classe 'Exercicio9'.
{
    // Método principal que inicia o programa.
    public static void Executar()
    {
        // Solicita ao usuário a hora de início do jogo.
        Console.Write("Digite a hora de início do jogo: ");
        int horaInicio = int.Parse(Console.ReadLine());  // Lê e converte a entrada para um inteiro.
        
        // Solicita ao usuário o minuto de início do jogo.
        Console.Write("Digite o minuto de início do jogo: ");
        int minutoInicio = int.Parse(Console.ReadLine());  // Lê e converte a entrada para um inteiro.

        // Solicita ao usuário a hora de término do jogo.
        Console.Write("Digite a hora de término do jogo: ");
        int horaFim = int.Parse(Console.ReadLine());  // Lê e converte a entrada para um inteiro.
        
        // Solicita ao usuário o minuto de término do jogo.
        Console.Write("Digite o minuto de término do jogo: ");
        int minutoFim = int.Parse(Console.ReadLine());  // Lê e converte a entrada para um inteiro.

        // Variáveis para armazenar a duração
        int duracaoHoras;  // Para armazenar a quantidade de horas da duração.
        int duracaoMinutos;  // Para armazenar a quantidade de minutos da duração.

        // Chamando o método e passando variáveis de saída para calcular a duração do jogo.
        CalcularDuracaoJogo(horaInicio, minutoInicio, horaFim, minutoFim, out duracaoHoras, out duracaoMinutos);

        // Exibe a duração do jogo formatada em horas e minutos.
        Console.WriteLine($"A duração do jogo é de {duracaoHoras} horas e {duracaoMinutos} minutos.");
    }

    // Método que calcula a duração do jogo.
    static void CalcularDuracaoJogo(int horaInicio, int minutoInicio, int horaFim, int minutoFim, out int duracaoHoras, out int duracaoMinutos)
    {
        // Calcula a hora total de início e término em minutos.
        int inicioTotalMinutos = horaInicio * 60 + minutoInicio;  // Converte a hora de início em minutos.
        int fimTotalMinutos = horaFim * 60 + minutoFim;  // Converte a hora de término em minutos.

        // Se o jogo terminou no dia seguinte, ajusta o tempo final para incluir o próximo dia.
        if (fimTotalMinutos < inicioTotalMinutos)
        {
            fimTotalMinutos += 24 * 60; // Adiciona 24 horas em minutos para considerar a passagem do dia.
        }

        // Calcula a duração total em minutos.
        int duracaoTotalMinutos = fimTotalMinutos - inicioTotalMinutos;

        // Converte a duração total em horas e minutos.
        duracaoHoras = duracaoTotalMinutos / 60;  // Divide por 60 para obter as horas.
        duracaoMinutos = duracaoTotalMinutos % 60;  // Usa o operador módulo para obter os minutos restantes.
    }
}
