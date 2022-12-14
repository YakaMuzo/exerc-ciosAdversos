using System; 

class URI {

    static void Main(string[] args) { 
        System.Console.WriteLine("Insira dois números inteiros:");
        string[] valores = Console.ReadLine().Split(' ');
        int numero1 = int.Parse(valores[0]);
        int numero2 = int.Parse(valores[1]);

        if (numero1 % numero2 == 0 || numero2 % numero1 == 0) {
            System.Console.WriteLine("Estes números são multiplos");
        }       
        else{
            System.Console.WriteLine("Estes números não são multiplos");
        }


    }

}