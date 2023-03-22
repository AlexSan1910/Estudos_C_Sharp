// See https://aka.ms/new-console-template for more information

namespace exemplo{
    class Program{
        static void Main(string[] args){

            bool c1 = 2 > 3 || 4 != 5; // uma variavel do tipo bool, que irá simplesmente retornar se essa informação é verdadeira ou falsa... é importante ressaltar que a pontuação de exclamação significa negação 
            bool c2 = !(2 > 3) && 4 != 5; // uma variavel do tipo bool, que irá simplesmente retornar se essa informação é verdadeira ou falsa

            Console.WriteLine(c1); //printando informações da variavel c1
            Console.WriteLine(c2);// printando informações da variavel c2
            Console.WriteLine("----------------------------"); // pequeno espaço

            bool c3 = 10 < 5; // uma variavel do tipo booleana que irá retornar se essa informação é verdadeira ou falsa
            bool c4 = c1 || c2 && c3; // a precedencia do "&& and" é maior que a precedencia do "|| ou" ou seja, isso significa que primeiro será executado o calculo do c2 && c3 e depois o resultado desses dois com o || c1.

        }
    }
}
