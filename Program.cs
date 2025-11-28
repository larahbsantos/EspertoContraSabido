﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Esperto Contra Sabido ---\n");

        int total = LerQuantidade();

        int picaPau = 0;
        int raposinha = 0;

        int passo = 1;

        while (total > 0)
        {
            // ---- Pica-pau ----
            if (total > 0)
            {
                picaPau++;
                total--;
                Console.Write($"{picaPau} para você. ");
            }

            // ---- Raposinha ----
            int count = 0;

            while (total > 0 && count < passo)
            {
                count++;
                raposinha++;
                total--;

                Console.Write(count);

                if (count < passo && total > 0)
                    Console.Write(", ");
            }

            if (count > 0)
                Console.WriteLine(" para mim.");

            passo++;
        }

        Console.WriteLine();
        Console.WriteLine($"Pica-pau recebeu {picaPau} alimento(s).");
        Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");
    }

    static int LerQuantidade()
    {
        while (true)
        {
            Console.Write("Quantos alimentos serão distribuídos?: ");

            if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
            {
                Console.WriteLine();
                return valor;
            }

            Console.WriteLine("Valor inválido! Digite um número inteiro maior que zero.\n");
        }
    }
}
