//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
//seguir, calcule e mostre o valor da conta a pagar.

// 1 Cachorro-Quente R$ 4,00
// 2 X-Tudo          R$ 4,50
// 3 X-Bancon        R$ 5,00
// 4 Torrada Simples R$ 2,00
// 5 Refrigerante    R$ 1,50

namespace Course{
    class Program{
        static void Main(string[] args){

            int userChoice = 10;
            int amountChoice = 3;


            float cachorroQuente = 4.0f;
            float xTudo = 4.50f;
            float xBacon = 5.00f;
            float torradaSimples = 2.00f;
            float refrigerante = 1.00f;

            if(userChoice == 1){
                float calcCachorroQuente = cachorroQuente * amountChoice;
                Console.WriteLine("Total de: R$" + calcCachorroQuente + " Reais");
            }
            else if(userChoice == 2){
                float calcXTudo = xTudo * amountChoice;
                Console.WriteLine("Total de: R$" + calcXTudo + " Reais");
            }
            else if(userChoice == 3){
                float calcXBacon = xBacon * amountChoice;
                Console.WriteLine("Total de: R$" + calcXBacon + " Reais");
            }
            else if(userChoice == 4){
                float calcTorradaSimples = torradaSimples * amountChoice;
                Console.WriteLine("Total de: R$" + calcTorradaSimples + " Reais");
            }
            else if(userChoice == 5){
                float calcRefrigerante = refrigerante * amountChoice;
                Console.WriteLine("Total de: R$" + calcRefrigerante + " Reais");
            }
            else{
                Console.WriteLine("Por favor digite uma opção valida");
            }

        }
    }
}
