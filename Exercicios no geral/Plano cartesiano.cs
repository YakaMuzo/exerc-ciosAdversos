using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Digite dois valores:");
        string[] valores = Console.ReadLine().Split(' ');
        double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

        if ( x == 0.0 && y == 0.0 ){
            System.Console.WriteLine("Origem");
        }
        else if (x == 0.0){
            System.Console.WriteLine("Eixo Y");
        }
        else if (y == 0.0){
            System.Console.WriteLine("Eixo X");
        }
        else if (x > 0.0 && y > 0.0){
            System.Console.WriteLine("Q1");
        }
        else if (x < 0.0 && y < 0.0){
            System.Console.WriteLine("Q3");
        }
        else if (x < 0.0 && y > 0.0){
            System.Console.WriteLine("Q2");
        }
        else{
            System.Console.WriteLine("Q4");
        }

    }

}
