using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadeando For");

        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine();

            for(int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
        }
        //*
        //**
        //***
        //****
        //*****

        Console.WriteLine("Digite enter para finalizar o programa...");
        Console.ReadLine();
    }
}


