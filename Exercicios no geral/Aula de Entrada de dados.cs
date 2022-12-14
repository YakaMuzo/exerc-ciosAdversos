using System;
using System.Globalization;

namespace Helloworld
{
    class Yakamuzo
    {

    static void Main(string[] args) { 

        System.Console.WriteLine("Entre com seu nome completo:");
        string nome = Console.ReadLine();
        System.Console.WriteLine("Quantos quartos tem na sua casa?");
        int idade = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Entre com o preço de um produto:");
        double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        System.Console.WriteLine("Entre seu ultimo nome, idade e altura (Mesma linha)");
        string[] vet = Console.ReadLine().Split(' ');
        string Cor = vet [0];
        int idade2 = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

        System.Console.WriteLine(nome);
        System.Console.WriteLine(idade);
        System.Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
        System.Console.WriteLine(Cor);
        System.Console.WriteLine(idade2);
        System.Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}

