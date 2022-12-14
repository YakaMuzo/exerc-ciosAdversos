using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Digite as coordenadas:");

        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        int valor = int.Parse(Console.ReadLine());

        while (valor != 4){

            if (valor == 1){
                alcool = alcool + 1;
            }
            else if (valor == 2){
                gasolina = gasolina + 1;
            }
            else if (valor == 3){
                diesel = diesel + 1;
            }

            valor = int.Parse(Console.ReadLine());
        }

        System.Console.WriteLine("MUITO OBRIGADO");
        System.Console.WriteLine("Alcool: "+alcool);
        System.Console.WriteLine("Gasolina: "+alcool);
        System.Console.WriteLine("Diesel: "+diesel);

    }

}
