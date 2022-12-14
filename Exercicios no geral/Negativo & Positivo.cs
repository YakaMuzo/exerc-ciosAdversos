using System; 

class URI {

    static void Main(string[] args) { 
        System.Console.WriteLine("Insira um número inteiro:");
        int numero = int.Parse(Console.ReadLine());
        if (numero < 0) {
            System.Console.WriteLine("NEGATIVO");
        }       
        else{
            System.Console.WriteLine("POSITIVO");
        }


    }

}