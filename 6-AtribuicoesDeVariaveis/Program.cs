using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 6 - Atribuiçoes de Variáveis");

        int idade = 30;
        int idadeFulano = idade;

        Console.WriteLine(idadeFulano);

        idade = 25;


        Console.WriteLine("Digite enter para finalizar o programa...");
        Console.ReadLine();
    }
}
