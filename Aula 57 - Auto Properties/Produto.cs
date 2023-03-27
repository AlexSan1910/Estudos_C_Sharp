using System;
using System.Globalization;

namespace Course{
    class Produto{

        //Atributos Privativos Auto Properties

        // Estou basicamente ao definir esse atributo, ja definindo quais ações eu quero nele, por exemplo dizendo que eu quero a ação get,
        // poerm especificando que a ação SET ele não pdoerá ser alterada por outros arquivos, se fizermos essa alespecificação na hora 
        // de definirmos os atributos não é necessario nemque criemos as funções ou metodos para o get e set posteriormente.

        // Lembrando sempre que quando formos definirmos dessa forma com a auto propertie, podemos colocar com letra maiuscula, normalmente
        // agora se formos definirmos do modo antigo, no qual colocariamos uma função de get e set para cada atributo e ele for privado
        // devemos colocar o nome desse atributo com underline e iniciando com letra minuscula. Até mesmo para posteriormete depois
        // quando vermos essa propriedade em qualquer lugar do nosso codigo fonte, possamos só de olhar já identificar que ela é uma 
        // propriedade privada.

        // Reparem que o atributo nome, ainda permanece dessa forma antiga e porque isso ? porque assim como pode ser analisado
        // o nome possui uma logica definida a ele, sendo assim não é possivel definir essa logica com a auto propertie, sendo assim
        // só existe a possibilidade de criarmos com a propertie normal, assim como ele está definido.
     
        private string _nome; 
        public double Preco{ get; private set;} 
        public int Quantidade{ get; private set;}

        // Sobrecargas de Construtores

        public Produto(){
        }

        public Produto(string Nome, double Preco, int Quantidade) { 
            _nome = Nome;                       
            this.Preco = Preco;                     
           this.Quantidade = Quantidade;
        }      

        public string Nome{
            get {return _nome; } 
            set {

                if (value != null && value.Length > 1){
                _nome = value;     
                }

            }
        }

        // Definindo Funções ou Metodos

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade){
            Quantidade -= quantidade;
        }

        // metodo ToString

        public override string ToString(){
            return _nome + " , $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + Quantidade + " unicades, total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}