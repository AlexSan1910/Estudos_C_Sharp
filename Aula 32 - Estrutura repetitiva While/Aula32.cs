using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){

            Console.Write("DIGITE UM NUMERO: ");
            double x = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture); // se eu declarar esssa variavel dentro da função while, ela não existira fora... 
                                                                                                 // logo a primeira linha do while que é a linha com a condição envolvendo a variavel 
            while(x > 0.0){                                                                      // "x" não irá funcionar.. pois o programa ainda não tinha declarado a variavel sendo 
                                                                                                 // assim é como se ela não existisse ainda.
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3",CultureInfo.InvariantCulture));

                Console.Write("Digite novamente um outro numero: ");
                x = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture); // o ideal é declarar a variavel sempre fora da função pois se caso necessitar dela pra 
                                                                                              // fora da função é como se ela não existisse lá fora e sim apenas aqui dentro.
            }

            Console.WriteLine("Execeção finalizada!"); // a fução While irá funcionar em forma de loop sempre quando a condição for verdadeira
                                                       // quando a condição não for mais verdadeira, apartir dai, o codigo irá executar da 
                                                       // esquerda para a direita, de cima para baixo o que está depois da condição se caso 
                                                       // houver algo a mais.   
        }
    }
}
