using System;
using System.Globalization;

namespace Course{
    class Produto{

        public string Nome;
        public double Preco;
        public int Quantidade;

        // contrutor geralmente é colocado sempre após os atributos.

        // Para criarmos um construtor é bem simples, basta apenas definirmos como publico assim como o esperado pois ele necessita de estar
        // acessando por outro arquivo, iremos chamar o nome dessa classe onde esta esses atributos que nesse caso é "Produtos", e definir  
        // um nome pra cada um dos dados que iremos receber dentro desse contrutor, é imprescindivel que esse nome seja inicando em minusculo,
        //  com os seus respectivos tipos.. depois basta declararmos cada um dos nomes dos dados para cada um dos atributos, assim como está
        // sendo feito.
        public Produto(string nome, double preco, int quantidade) { 
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade){
            Quantidade -= quantidade;
        }

        public override string ToString(){
            return Nome + " , $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + Quantidade + " unicades, total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}