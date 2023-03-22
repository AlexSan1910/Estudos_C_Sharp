// Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). em seguida:

// * Mostrar os dados do produtos (nome, preço, quantidade no estoque, valor total no estoque).
// * Realizar uma entrada no estoque e mostrar novamente os dados do produtos.
// * Realizar uma saida no estoque e mostrar novamente os dados do produto.

// Para resolver esse problema você deve criar uma classe 

using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();// pulando linha
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();// pulando linha
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());// guardei a informação de quantas unidades será adicionada

            Console.WriteLine();
            p.AdicionarProdutos(qte);// após a criação da função eu relacionei o valor da variavel qtd na função ou metodo AdicionarProdutos.
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();// pulando linha
            Console.Write("Digite o numero de produtos a ser Removido do estoque: ");
            qte = int.Parse(Console.ReadLine());// guardei a informação de quantas unidades será retirada do estoque. Não é preciso declarar uma nova variavel pois basta utilizarmos a mesma variavel para guardar essa informação e depois relacionar ela na função Remover produtos.

            Console.WriteLine();
            p.RemoverProdutos(qte);// após a criação da função eu relacionei o valor da variavel qtd na função ou metodo AdicionarProdutos.
            Console.WriteLine("Dados Atualizados: " + p);


        }
    }
}