using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Digite um valor:");
        double intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (intervalo < 0 || intervalo > 100){
            System.Console.WriteLine("Fora de intervalo");
        }
        else if (intervalo <= 25){
            System.Console.WriteLine("Intervalo (0,25)");
        }
        else if (intervalo <= 50){
            System.Console.WriteLine("Intervalo (25,50)");
        }
        else if (intervalo <= 75){
            System.Console.WriteLine("Intervalo (50,75)");
        }
        else {
            System.Console.WriteLine("Intervalo (75,100)");
        }


    }

}
