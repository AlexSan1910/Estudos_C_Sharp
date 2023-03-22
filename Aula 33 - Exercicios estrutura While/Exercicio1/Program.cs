// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

using System;
using System.Globalization;

namespace Course
{
    class Program{
        static void Main(string[] args){
            
            System.Console.Write("Digite a senha por favor: ");
            int senha = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            while (senha != 2002){
                Console.WriteLine("Senha Invalida!");
                Console.Write("Digite Novamente a Senha por favor: ");
                senha = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}