using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Preencha este formulário 1:");
        string[] pecas1 = (Console.ReadLine().Split(' '));
        int codig1 = int.Parse(pecas1[0]);
        int numero1 = int.Parse(pecas1[1]);
        double valor1 = double.Parse(pecas1[2],CultureInfo.InvariantCulture);
        System.Console.WriteLine("Preencha este formulário 1:");
        string[] pecas2 = (Console.ReadLine().Split(' '));
        int codigo2 = int.Parse(pecas2[0]);
        int numero2 = int.Parse(pecas2[1]);
        double valor2 = double.Parse(pecas2[2],CultureInfo.InvariantCulture);


        double pagamento = (numero1*valor1) + (numero2*valor2);
        System.Console.WriteLine("VALOR A PAGAR: R$ "+pagamento.ToString("F2",CultureInfo.InvariantCulture));

    }

}