using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;

        int salarioInteiro;

        salarioInteiro = (int)salario;

        Console.WriteLine(salarioInteiro);

        //O long é um tipo de variável de 64 bits
        long x = 200000000000000;

        Console.WriteLine(x);

        short y = 15000;

        Console.WriteLine(y);

        float altura = 1.62f;

        Console.WriteLine(altura);

        Console.WriteLine("Digite enter para finalizar o programa...");
        Console.ReadLine();
    }
}
