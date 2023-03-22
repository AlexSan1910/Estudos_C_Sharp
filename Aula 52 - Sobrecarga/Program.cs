using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine(); // definindo o primeiro argumento do atributo nome
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // definindo o primeiro argumento do atributo preco
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());// definindo o primeiro argumento do atributo quantidade

            Produto p = new Produto(nome, preco); // podemos definir um construtor apenas de dois argumentos conforme foi declarado la na
            // classe Produto
            
            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);


        }
    }
}