using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Digite a senha:");

        int senha = int.Parse(Console.ReadLine());
        while (senha != 2002)
        {
            System.Console.WriteLine("Senha Inválida");
            senha = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Acesso permitido");

    }

}
