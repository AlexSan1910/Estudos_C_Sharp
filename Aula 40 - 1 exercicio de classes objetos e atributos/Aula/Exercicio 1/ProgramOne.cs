// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

// Resultados a serem obtidos.

//Dados da primeira pessoa:
//Nome: Maria
//Idade: 17
//Dados da segunda pessoa:
//Nome: Joao
//Idade: 16
//Pessoa mais velha: Maria
using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){

            Pessoas peopleOne; // Definindo variaveis com o tipo Pessoas
            Pessoas peopleTwo; // Definindo variaveis com o tipo Pessoas

            peopleOne = new Pessoas(); // instanciando essa variavel que é um tipo de uma classe.
            peopleTwo = new Pessoas(); // instanciando essa variavel que é um tipo de uma classe.

            Console.Write("Por favor digite o seu nome da primeira pessoa: ");
            peopleOne.Nome = Console.ReadLine();
            Console.Write("Por favor digite a idade da primeira pessoa: ");
            peopleOne.idade = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            Console.Write("Por favor digite o nome da segunda pessoa: ");
            peopleTwo.Nome = Console.ReadLine();
            Console.Write("Digite o nome da segunda pessoa: ");
            peopleTwo.idade =  int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            if (peopleOne.idade > peopleTwo.idade){
                Console.WriteLine("A " + peopleOne.Nome + " é a mais velha");
            }else{
                Console.WriteLine("A " + peopleTwo.Nome + " é a mais velha");
            }


        }
    }
}