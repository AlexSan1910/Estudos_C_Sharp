using System.Globalization;
using System;

namespace Course
{
    class Program{
        static void Main(string[] args){
            // devemos utilizar essa condição sempre quando identificarmos a quantidade de loop's o programa deve fazer,
            // caso não sabemos a quantidade de repetições (lop's) devemos sempre utilizamos a confição while.

            System.Console.Write("Quantos numeros inteiros você vai digitar? ");
            int qtdNumberUser = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);


            int soma = 0;
            for(int i = 1; i <= qtdNumberUser; i++){ // basicamente eu preciso definir um numero de inicio, então eu criei uma variavel
                                                     // na hora chamada "i" e defini o valor de numero 1, após isso eu defini uma condição
                                                     // ou seja, essa condição é que ela deve repetir essa função enquanto o i for menor ou
                                                     // igual ao numero que o usuario nos passou, e na ultima etapa, nós definimos que a 
                                                     // variavel i receberá sempre um mais uma unidade até que se repita o tanto que foi 
                                                     // predefinido.

            Console.Write("Valor #{0}: ", i); // printando na tela do usuario o valor de numero 1, 2 e 3 conforme foi a quantidade que o usuario pediu
            int valor = int.Parse(Console.ReadLine());// capturando a informação que o usuario vai digitar e adicionando na variavel valor
            soma = soma + valor; // adicionando em forma de soma as variaveis que o usuario digitou, na variavel soma.
            }

            Console.WriteLine("Soma = " + soma);// ess print só será executado após a quantidade necessaria de repetições da função acima, 
                                                // e nesse caso vai printar o valor somado de todos os numeros digitados pelo usuario.

        }
    }
}