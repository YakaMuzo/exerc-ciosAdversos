using System;
using System.Globalization;

namespace Name {
    class URI {
        static void Main(string[] args) {
            Nomes x, y;

            x = new Nomes();
            y = new Nomes();

            System.Console.WriteLine("Dados da Primeira pessoa:");
            System.Console.Write("Nome: ");
            x.A = Console.ReadLine();
            System.Console.Write("Idade: ");
            x.B = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da Segunda pessoa:");
            System.Console.Write("Nome: ");
            y.A = Console.ReadLine();
            System.Console.Write("Idade: ");
            y.B = int.Parse(Console.ReadLine());

            if (x.B > y.B)
            {
                System.Console.WriteLine("Pessoa mais velha: "+x.A);
            }
            else{
                System.Console.WriteLine("Pessoa mais velha: "+y.A);
            }

        }
    }
}