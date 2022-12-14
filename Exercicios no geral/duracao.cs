using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Preencha este formulário:");
        string[] valores = (Console.ReadLine().Split(' '));
        int valorA = int.Parse(valores[0], CultureInfo.InvariantCulture);
        int valorB = int.Parse(valores[1], CultureInfo.InvariantCulture);

        int duracao;
        if (valorA < valorB){
            duracao = valorB - valorA;
        }
        else{
            duracao = 24 - valorA + valorB;
        }

        System.Console.WriteLine("O JOGO DUROU "+duracao+" HORA(S)");

    }

}