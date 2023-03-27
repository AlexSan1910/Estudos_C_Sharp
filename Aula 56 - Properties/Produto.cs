using System;
using System.Globalization;

namespace Course{
    class Produto{

        //Atributos Privativos
        private string _nome; 
        private double _preco;
        private int _quantidade; 

        // Sobrecargas de Construtores

        public Produto(){
        }

        public Produto(string Nome, double Preco, int Quantidade) { 
            _nome = Nome;                       
            _preco = Preco;                     
           _quantidade = Quantidade;
        }   

        // Definindo Properties 

        // Reparem que agora dentro dessa Propertie, eu consigo definir em apenas uma unica "função ou metodo" duas ações nesse caso 
        // a ação de Get e a Ação de Set, isso é bom porque evitamos de criar varias funções desnecessarias e tambem no arquivo de program
        // facilita de adaicionarmos valores a esses atributos, para criar essa propertie basta apenas definirmos get e abre e fecha chaves
        // e definir a função do get, e basta definirmos o set e entre chaves definir a função de set.. Reparem que nesse caso definimos
        // uma logica de condição.. é de suma importancia que saibamos que o "value" representado nessa função se trata basicamente do valor
        // de entrada que o usuario irá digitar, numa função convencional definiriamos entre parenteses o nome dessa entrada e o seu tipo
        // e durante a função relacionariamos o nome dessa entrada com o do atributo assim como o exemplo abaixo:

        /*public string SetNome(string nome){
            if (_nome != null && _nome.Length > 1){
                _nome = nome;     
            }
        }*/

        // porem já nessa propertie não há a necessidade de fazermos isso, basta simplesmente definirmos esse valor com value, e o c#
        // automaticamente irá entender o que isso significa.      

        public string Nome{
            get {return _nome; } 
            set {

                if (value != null && value.Length > 1){
                _nome = value;     
                }

            }
        }

        public double Preco{
            get {return _preco;}
        }

        public int Quantidade{
            get {return _quantidade; }
        }
        // Definindo Funções ou Metodos

        public double ValorTotalEmEstoque(){
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade){
            _quantidade -= quantidade;
        }

        // metodo ToString

        public override string ToString(){
            return _nome + " , $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + _quantidade + " unicades, total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}