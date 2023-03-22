using  System;

namespace Course{
    class Program{
        static void Main(string[] args){

            System.Console.WriteLine("Porfavor digite 3 numeros");
            int numberOne = 1;
            int numberTwo = 2;
            int numberThree = 3;

            double resultado = Maior(numberOne, numberTwo, numberThree); // basicamente estou chamando a função que criamos e estou definindo o resultado dela para
                                                                         // para dentro de uma variavel chamada resultado, sendo assim basta eu ppassar os parametros 
                                                                         // que essa função necessita para funcionar, e ela irá gerar um resultado, que neste caso,  
                                                                         // foi o resultado que programamos para que ele gerasse com os parametros que quisessemos

            System.Console.WriteLine("O numero maior é: " + resultado); // Estou printando o valor da variavel resultado que foi definido a partir da função que 
                                                                        // criamos na tela do usuario.
        }

        static int Maior(int a, int b, int c){     // é necessario que como paremetro de entrada da função nós definimos quais são os tipos dos valores que iremos receber

                    // estamos nada mais e nada menos que criando uma nova função, dentro dessa classe chamada Program.. pois para que criemos uma função
                    // é necessario que ela esteja dentro de uma classe.. outra coisa importantissima, é que essa função para funcionar dentro de uma 
                    // outra função, ou nesse caso dentro da função principal, é imprescindivel que ela seja Estatica tambem. esse motivo será explicado mais pra frente.

            int numberMax;

            if (a > b && a > b){
                numberMax = a;           // note que nos lugares onde ficaria as variaveis eu estou relacionando
            }                            // os parametros que no inicio da função nos definimos.
            else if(b > c){
                numberMax = b;
            }
            else{
                numberMax = c;
            }
            return numberMax; // esse comando basicamente é o comando responsavel por retornar la na outra função principal o resultado dessa
                              // condição toda com os determiando resultados.
        }
    }
}