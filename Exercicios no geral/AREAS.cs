using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Preencha este formulário:");
        string[] valores = (Console.ReadLine().Split(' '));
        double valorA = double.Parse(valores[0],CultureInfo.InvariantCulture);
        double valorB = double.Parse(valores[1],CultureInfo.InvariantCulture);
        double valorC = double.Parse(valores[2],CultureInfo.InvariantCulture);

        double triangulo = (valorA*valorC / 2);
        double circulo = 3.14159 * (valorC*valorC);
        double trapezio = ((valorA+valorB)/2)*valorC;
        double quadrado = valorB*valorB;
        double retangulo = valorA*valorB;

        System.Console.WriteLine("TRIANGULO: "+triangulo.ToString("F3",CultureInfo.InvariantCulture));
        System.Console.WriteLine("CIRCULO: "+circulo.ToString("F3",CultureInfo.InvariantCulture));
        System.Console.WriteLine("TRAPEZIO: "+trapezio.ToString("F3",CultureInfo.InvariantCulture));
        System.Console.WriteLine("QUADRADO: "+quadrado.ToString("F3",CultureInfo.InvariantCulture));
        System.Console.WriteLine("RETANGULO: "+retangulo.ToString("F3", CultureInfo.InvariantCulture));
        
    }

}