using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Insira quatros números:");
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);
        int d = int.Parse(valores[3]);
        int diferenca = a*b - c*d;
        System.Console.WriteLine("Diferença = "+diferenca);

    }

}