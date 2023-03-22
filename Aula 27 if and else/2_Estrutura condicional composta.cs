namespace CourseTwo
{
    class ProgramTwo {
        static void Main(string[] args){

            /* 
            if(condição){
                comando 1
                comando 2
            }
            else{                       estrutura composta
                comando 3
                comando 4
            }
            */

            Console.WriteLine("Entre com um numero inteiro");
            int number = int.Parse(Console.ReadLine()); // leitura do que o usuario irá digitar e armazenar dentro da variavel x.

            if (number % 2 == 0){ // se o resto da variavel x for divido por 2 e for igual a zero, será um numero par
                Console.WriteLine("Seu numero é par"); // se a condição acima for verdadeira irá printar essa mensagem  na tela do usuario
            }
            else{
                Console.WriteLine("Seu numero é impar");// se a mensagem não for verdadeira irá printar essa mensagem na tela do usuario.
            }
        }
    }
}