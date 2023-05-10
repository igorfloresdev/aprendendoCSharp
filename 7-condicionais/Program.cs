using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 0;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

        }

        Console.WriteLine("Digite enter para finalizar o programa...");
        Console.ReadLine();
    }
}

