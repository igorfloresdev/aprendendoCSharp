using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Escopo de variaveis");

        int idadeJoao = 16;
        int quantidadePessoas = 0;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "João está acomponhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {

            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");

        }

        Console.WriteLine("Digite enter para finalizar o programa...");
        Console.ReadLine();
    }
}

