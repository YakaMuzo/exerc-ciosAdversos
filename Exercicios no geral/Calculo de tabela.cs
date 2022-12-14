using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        System.Console.WriteLine("Preencha este formulário:");

        double cachorroQuente, salada, bacon, torrada, refrigerante, valorA, valorB, resultado;
        cachorroQuente = 4.00;
        salada = 4.50;
        bacon = 5.00;
        torrada = 2.00;
        refrigerante = 1.50;

        string[] valores = (Console.ReadLine().Split(' '));
        valorA = double.Parse(valores[0]);
        valorB = double.Parse(valores[1]);

        if (valorA == 1){
        resultado = cachorroQuente * valorB;
        }
        else if (valorA == 2){
            resultado = salada * valorB;
        }
        else if (valorA == 3){
            resultado = bacon * valorB;
        }
        else if (valorA == 4){
            resultado = torrada * valorB;
        }
        else {
            resultado = refrigerante * valorB;
        }

        System.Console.WriteLine("Total: R$ "+resultado.ToString("F2", CultureInfo.InvariantCulture));

    }

}