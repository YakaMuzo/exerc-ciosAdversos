using System; 
using System.Globalization;
class URI {

    static void Main(string[] args) { 

        double π = 3.14159;

        System.Console.WriteLine("Insira um número para ser o raio:");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double formula = π*(raio*raio);
        System.Console.WriteLine("A sua área é: "+formula.ToString("F4", CultureInfo.InvariantCulture));

    }

}