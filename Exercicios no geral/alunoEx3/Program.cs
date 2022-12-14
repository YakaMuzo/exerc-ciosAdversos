using System;
using System.Globalization;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno n = new Aluno();

            System.Console.Write("Nome do Aluno: ");
            n.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno: ");
            n.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("NOTA FINAL: " + n.NotaFinal().ToString("f2", CultureInfo.InvariantCulture));
            if (n.Aprovado()) {
                System.Console.WriteLine("APROVADO");
            }
            else {
                System.Console.WriteLine("REPROVADO");
                System.Console.WriteLine("FALTARAM " + n.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}
