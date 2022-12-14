using System;
using System.Globalization;

namespace Name {
    class URI {
        static void Main(string[] args) {

            Triangulo x,y;

            y = new Triangulo();
            x = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Entre com as medidas do triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            System.Console.WriteLine("Área de X= "+areaX.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Área de Y= "+areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                System.Console.WriteLine("Maior área: X");
            }
            else
            {
                System.Console.WriteLine("Maior área: Y");
            }
        }
    }
}