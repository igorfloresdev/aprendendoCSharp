using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // Rendimento de 0.5% (0.005) ao mês

        int mes = 1;
        while(mes <= 12) 
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("Mes " + mes + " você tem R$ " + investimento);
            mes++;

        }

        Console.WriteLine("Digite enter para finalizar o programa...");
        Console.ReadLine();
    }
}

