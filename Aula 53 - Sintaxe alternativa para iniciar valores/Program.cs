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

            Produto p = new Produto(nome, preco); 

            Produto p2 = new Produto(){ Nome = "TV", Preco = 500, Quantidade = 10 }; // existe a possibilidade de instanciar o objeto produto
            // ou seja, instanciando o objeto e depois ja definimos os valores dos seus parametros, assim como doi definido aqui acima
            // sendo assim eiste a possibilidade de fazermos isso mesmo que os construtores não existam, obvio que para maior organização
            // seria importante fazer a declaração dos construtores para depois definirmos os valores aqui caso necessario.

            // é muito importante que se por acaso tiver algum construtor com apenas dois argumentos, ai nesse caso só conseguiremos utilizar
            // dessa sintaxe alternativa com apenas os dois argumentso que foi definido no construtor, se não teriamos que abrir um construtor
            // vazio para utilziar todos os argumentos conforme desejarmos .

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