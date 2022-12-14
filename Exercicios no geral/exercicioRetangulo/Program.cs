using System;
using System.Globalization;

namespace Name {
    class Program {
        static void Main(string[] args) {

        Retangulo x;

        x = new Retangulo();

        System.Console.WriteLine("Entre com a largura e altura do retângulo:");
        x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double area = x.Area();
        double perimetro = x.Perimetro();
        double diagonal = x.Diagonal(); 

        System.Console.WriteLine("Area = "+area.ToString("F2",CultureInfo.InvariantCulture));
        System.Console.WriteLine("Perimetro = "+perimetro.ToString("F2",CultureInfo.InvariantCulture));
        System.Console.WriteLine("Diagonal = "+diagonal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}