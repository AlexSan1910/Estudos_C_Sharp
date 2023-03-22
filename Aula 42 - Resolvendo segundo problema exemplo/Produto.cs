using System;
using System.Globalization;

namespace Course{
    class Produto{ // classe tipo produtos
        public string Nome;// Atributo publico para acesso em outros arquivos, tipo string, com letra maiuscu=la.
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){ // metodo public para acessos a outros arquivos, tipo double, com letra maiuscula.
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){ // essa função ou metodo será void, justamente porque ele irá fazer a alteração de uma variavel já existente, ou seja ela não irá retornar nada, ou seja, ela é uma fução ou metodo vazio.
                                                       // é extremamente importante que quando formos adicionar uma variavel relacionada entre os parenteses, que ela seja com letra minuscual.
            Quantidade = Quantidade + quantidade;
        }

         public void RemoverProdutos(int quantidade){ // essa função ou metodo será void, justamente porque ele irá fazer a alteração de uma variavel já existente, ou seja ela não irá retornar nada, ou seja, ela é uma fução ou metodo vazio.
                                                       // é extremamente importante que quando formos adicionar uma variavel relacionada entre os parenteses, que ela seja com letra minuscual.
            Quantidade = Quantidade - quantidade;
        }



        public override string ToString(){// operação publica, Override significa que essa operação veio de outra classe, é do tipo string e o nome da função ToString
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); // transformando as o conteudo dessas variaveis em string, assim sempre quando chamarmos essas vairaveis dentro de um WriteLine, o conteudo delas irão aparecer em string.
        }

        

    }
}