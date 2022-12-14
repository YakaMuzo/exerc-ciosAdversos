using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Preencha este formulário:");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.WriteLine("Number = "+numero);
        double salary = hora * valor;
        System.Console.WriteLine("Salary = U$ "+salary.ToString("F2", CultureInfo.InvariantCulture));

    }

}