using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            

           Produto p = new Produto("TV", 1000, 10);

           Console.WriteLine(p.Nome); // Repare agora que não é necessario instancia a classe inteira, e sim apenas chama-la pelo seu nome. 
           Console.WriteLine(p.Preco);
           Console.WriteLine(p.Quantidade);

        }
    }
}