// Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
// seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
// nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

namespace Course{
    class Program{
        static void Main(string[] args){

            float numberUser = -25.02f;

            if (numberUser >= 0 && numberUser <= 25f){
                Console.WriteLine("Intervalo 0 a 25");
            }
            else if (numberUser >= 25.01f && numberUser <= 50f){
                Console.WriteLine("Intervalo 25 a 50");
            }
            else if (numberUser >= 50.01f && numberUser <= 75f){
                Console.WriteLine("Intervalo 50 a 75");
            }
            else if (numberUser >= 50.01f && numberUser <= 100f){
                Console.WriteLine("Intervalo 75 a 100");
            }
            else {
                Console.WriteLine("Fora de Intervalo");
            }
        }
    }
}