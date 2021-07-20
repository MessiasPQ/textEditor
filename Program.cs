﻿using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1- Abrir / 2- Criar novo arquivo / 0- Sair");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {

        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo. (ESC para sair)");
            Console.WriteLine("------------------------------------------");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(texto);
        }
    }
}
