using System;
using System.Globalization;

namespace Name {
    class URI {
        static void Main(string[] args) {
            Dados x, y;

            x = new Dados();
            y = new Dados();

            System.Console.WriteLine("Dados do primeiro funcionário:");
            System.Console.Write("Nome: ");
            x.A = Console.ReadLine();
            System.Console.Write("Salário: ");
            x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            System.Console.WriteLine("Dados do segundo funcionário:");
            System.Console.Write("Nome: ");
            y.A = Console.ReadLine();
            System.Console.Write("Salário: ");
            y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (x.B + y.B) / 2;

            System.Console.WriteLine("Salário médio = "+media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}