// Existe uma ordem para cada um dos seus membros de dentro da sua classe, que é essencial que seja seguido para um bom codigo.

using System;
using System.Globalization;

namespace Course{
    class Produto{

        // 1 -Atributos Privativos 
     
        private string _nome; 

        // 2 - Auto Properties 
        public double Preco{ get; private set;} 
        public int Quantidade{ get; private set;}

        // 3 - Construtores e suas sobrecargas

        public Produto(){
        }

        public Produto(string Nome, double Preco, int Quantidade) { 
            _nome = Nome;                       
            this.Preco = Preco;                     
           this.Quantidade = Quantidade;
        }

        // 4 - Properties Customizadas      

        public string Nome{
            get {return _nome; } 
            set {

                if (value != null && value.Length > 1){
                _nome = value;     
                }

            }
        }

        // 5 - Funções e Metodos da Classe

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