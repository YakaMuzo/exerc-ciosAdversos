using System;
using System.Globalization;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
        Funcionario f = new Funcionario();

            System.Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            System.Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            System.Console.WriteLine("Funcionário: "+f);

            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            double asl = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f.AumentarSalario(asl);
            System.Console.WriteLine("Dados atualizados: "+f);
        }
    }
}