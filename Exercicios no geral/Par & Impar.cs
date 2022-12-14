using System; 

class URI {

    static void Main(string[] args) { 
        System.Console.WriteLine("Insira um número inteiro:");
        int numero = int.Parse(Console.ReadLine());
        if (numero % 2 == 0) {
            System.Console.WriteLine("Este número é par!");
        }       
        else{
            System.Console.WriteLine("Este número é impar");
        }


    }

}