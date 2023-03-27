using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            

           Produto p = new Produto("TV", 1000, 10);

           /* p.Quantidade = -10; // perceba-se que mesmo que haja definido uma função, para adicionarmos uma quantidade de produto ao estoque
           // e retirar essa quantidade do estoque, ainda assim existe a possibilidade do usuario simplesmente vir aqui e digitar isso por
           // exemplo, alterar o valor desse atrbuto, sem necessariamente charmar função que foi criada justamente pra isso. é justamente 
           // por conta disso que iremos definir encapsulamentos, para que o usuario não acesse normalmente e da forma que quiser esses
           // parametros.

           // A partir do momento que definimos esse argumento ou atributo como "private" estamos querendo dizer com outras palavras que 
           // esse argumento estará inacessivel devido ao nivel de proteção que esse atributo ou classe possui.*/

           // com esse nivel de proteção se tentarmos por exemplos tentar printar o valor que esta nesse atributo, não será possivel, porque
           // agora com o private não é possivel mais acessar a informação que está dentro de private.

           Console.WriteLine(p.GetNome()); // obtendo o valor que está dentro do atributo _nome e jogando ele aqui para ser printado na
           // tela usuario, obvio que pra isso existe uma função chamada GetNome e dentro dela existe um retorne desse atributo.

           //Console.WriteLine("Digite o nome que deseja alterar do produto: ");
           p.SetNome("TV 4K"); // Basicamente estou solicitando ao usuario para que ele digite o valor a ser alterado do produto
                                          // no formato string.

        }
    }
}