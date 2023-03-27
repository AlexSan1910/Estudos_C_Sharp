using System;
using System.Globalization;

namespace Course{
    class Produto{

        private string _nome; // agora por padrão, quando definirmos atributos private devemos sempre definir com um underline e 
                             // com letra minuscula, assim como mostra nos exemplos 
        private double _preco;
        private int _quantidade; // acamos de alterar esse argumento ou atributo como, privado ou privativo, sendo assim não podemos 

        // Sobrecargas de Construtores

        public Produto(){
        }

        public Produto(string Nome, double Preco, int Quantidade) { 
            _nome = Nome;                       // Quando relacionamos a palavra this a uma variavel, significa que na verdade essa variavel
            _preco = Preco;                     // é o atributo dessa classe e não a variavel local criada normalmente.
           _quantidade = Quantidade;
        }

        public string GetNome(){ // função criada para buscar uma entrada que virá do usuario. continuação no arquivo Program
            return _nome;
        }

        
        // é bacana de definirmos metodos para adicionar ou alterar um nome, pois nesse metodo, podemos definir algumas
        // logicas nesse metodo, como por exemplo, irei definir que se o valor que o usuario digitar for nullo, ou menor que 
        // 2 caracter não aceitar e simplesmente não definir o valor digitado pelo o usuario para dentro desse atributo.
        public void SetNome(string nome){ // criando uma função para agora alterarmos o valor do atributo nome, essa função ou metodo, é recebida
                                          // como void, justamente porque esse metodo não irá retornar nada como saida ele irá simplesmente apenas
                                          //  alterar o valor do nome. continuação no arquivo Program.

            if (_nome != null && _nome.Length > 1){
                _nome = nome;     
            }
        }        

        public double GetPreco(){
            return _preco;
        }      

        public int GetQuantidade(){ // para definirmos que os valores dos atributos sejam apenas adicionados e não alterados, basta
            return _quantidade;     // definirmos esses metodos com o Get, pois nesse caso ele irá apenas buscar algo do atributo
        }                           // mas não alterar nada.

        public double ValorTotalEmEstoque(){
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade){
            _quantidade -= quantidade;
        }

        public override string ToString(){
            return _nome + " , $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + _quantidade + " unicades, total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}