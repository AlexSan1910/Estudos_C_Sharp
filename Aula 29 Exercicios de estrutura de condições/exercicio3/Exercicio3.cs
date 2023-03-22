//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
//Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
// ordem crescente ou decrescente.

namespace Course{
    class Program{
        static void Main(string[] args){
            
            int numberOne = 24;
            int numberTwo = 6;

            if(numberOne % numberTwo == 0 || numberTwo % numberOne == 0){
                Console.WriteLine("São Multiplos");
            }else{
                Console.WriteLine("Não São Multiplos");
            }

        }
    }
}
