// See https://aka.ms/new-console-template for more information

namespace Course{
    class Program{
        static void Main(string[] args){
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;              // é necessario sempre que eu declare a variavel antes de usa-la, independente da sua situação.
                                                // é de suma importancia que você saiba que uma variavel declarada dentro de uma função, ela não pode 
            if(preco > 100.0){                  // ser utilizada pra nada fora desta função, ou seja, se eu declarar essa variavel desconto dentro da função
               desconto = preco * 0.1;          // if, el não terá utilidade nenhum fora da função se por acaso eu quiser printar ela... pois será como se ela não existisse.
            }         

            Console.WriteLine(desconto);
        }
    }
}
