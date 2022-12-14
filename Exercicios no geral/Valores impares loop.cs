using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("Insira o X:");
        int x = int.Parse(Console.ReadLine());
        System.Console.WriteLine();
        System.Console.WriteLine("Saída:");


        for (int i = 1; i <= x; i++){
            if (i % 2 == 1){
                System.Console.WriteLine(i);
            }
        }





    }

}
