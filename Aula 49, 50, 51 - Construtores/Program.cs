using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            
            //  Produto p = new Produto(); quando instanciamos esse objeto dessa maneira,
            // ele está de forma automatica definindo como zero os atributos de numero, e o atributo de string está definiindo como nulo.

            // porem não faz muito sentido um objeto ser instanciado e por exemplo um produto que é o objeto que está sendo instanciado não ter
            // nome e nem numeros indicando o seu estado.. sendo assim o construtor vem justamente para isso, para definirmos que o programador
            // tenha que definir obrigatoriamente as informações do produto.


            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine(); // definindo o primeiro argumento do atributo nome
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // definindo o primeiro argumento do atributo preco
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());// definindo o primeiro argumento do atributo quantidade

            Produto p = new Produto(nome, preco, quantidade); // agora essa instanciação irá apontar um erro se estiver vazia como antes, 
            // pois ela está obrigando a nós, definirmos por padrão os argumentos dos atributos. e assim como comentado acima. 
            // os argumentos desses atributos está sendo definido em nome, preco, quantidade

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