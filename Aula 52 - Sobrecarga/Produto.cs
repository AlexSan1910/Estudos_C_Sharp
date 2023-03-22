using System;
using System.Globalization;

namespace Course{
    class Produto{

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(){ // definindo um construtor padrão, sendo assim é possivel declararmos um construtor como antigamente tambem
                          // sem problema algum. Ou Seja, podemos definir um construtor la no programa principal, os três parametro
                          // de entrada, só com os dois primeiros parametros de entrada, e sem nenhum parametro de entrada.

        }

        public Produto(string nome, double preco, int quantidade) { 
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // é possivel atribuir zero para um atributo numerico se caso não quisermos definir um parametro de entrada nele
            // conforme fizemos, que neste caso definimos parametros de entrada obrigadtoria para os argumentos nome e preco, mas não para 
            // quantidade.

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