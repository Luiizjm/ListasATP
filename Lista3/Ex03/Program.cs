﻿/* 3. O número 3025 tem a seguinte propriedade: 30 + 25 = 55 e 55 x 55 = 3025.
Faça um algoritmo que calcule e imprima quais os números entre 1000 e 9999 também
possuem esta mesma propriedade. */ 
using System;

class Program
{
    public static void Main()
    {
        int p1, p2;

        for (int i = 1000; i < 9999; i++) {
            p1 = i / 100;
            p2 = i % 100;

            if ((p1 + p2) * (p1 + p2) == i) {
                Console.WriteLine(i);
            }
        }

    }
}