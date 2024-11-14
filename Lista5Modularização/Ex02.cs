using System;
public class Exercicio2
{
    public static void Rodar()
    {
        double[] NotasAlunos = new double[10];

        VetNotas(NotasAlunos);

        CalculoNotas(NotasAlunos);

    }

    public static void VetNotas(double[] NotasAlunos)
    {
        Console.WriteLine("Digite as Notas dos alunos");

        for (int i = 0; i < NotasAlunos.Length; i++)
        {
            NotasAlunos[i] = double.Parse(Console.ReadLine());
        }
    }

    public static void CalculoNotas(double[] NotasAlunos)
    {
        double Notas = 0, Media = 0;
        int NotasAcimaDaMedia = 0;

        for (int i = 0; i < NotasAlunos.Length; i++)
        {
            Notas += NotasAlunos[i];
        }

        Media = Notas / NotasAlunos.Length;

        for (int i = 0; i < NotasAlunos.Length; i++)
        {
            if (NotasAlunos[i] < Media)
            {
                NotasAcimaDaMedia++;
            }
        }

        Console.WriteLine("A média dos alunos é de: " + Media);
        Console.WriteLine("Alunos acima da média: " + NotasAcimaDaMedia);
    }
}
