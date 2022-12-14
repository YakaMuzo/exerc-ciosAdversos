using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Digite as coordenadas:");

        string[] cooordenadas = Console.ReadLine().Split(' ');
        double x = double.Parse(cooordenadas[0]);
        double y = double.Parse(cooordenadas[1]);
        while (x != 0.0 && y != 0.0){

            if (x > 0.0 && y > 0.0){
                System.Console.WriteLine("primeiro");
            }
            else if (x < 0.0 && y < 0.0){
                System.Console.WriteLine("terceiro");
            }
            else if (x > 0.0 && y < 0.0){
                System.Console.WriteLine("quarto");
            }
            else{
                System.Console.WriteLine("segundo");
            }
            cooordenadas = Console.ReadLine().Split(' ');
            x = double.Parse(cooordenadas[0]);
            y = double.Parse(cooordenadas[1]);
        }

        System.Console.WriteLine();
    
    }

}
