// See https://aka.ms/new-console-template for more information

namespace CourseOne
{
    class ProgramOne {
        static void Main(string[] args){

            /* if(condição){
                comando 1               estrutura Simples
                comando 2
            }*/

            int x = 10;

            Console.WriteLine("Bom Dia");

            if(x > 5){
                Console.WriteLine("Boa Tarde");  // pode-se reparar agora que só foi impresso o bom dia e o boa noite, pois a condição dizia
                                                // que só iria mostrar o Boa Tarde se x fosse menor que 5 e como x não é menor que 5 ele não printou o boa tarde.
            }

            Console.WriteLine("Boa Noite");
        }
    }
}