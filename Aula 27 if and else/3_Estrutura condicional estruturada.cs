namespace CourseThree
{
    class ProgramThree {
        static void Main(string[] args){

            /*
            if(condição 1){
                comando 1
                comando 2
            }
            else if(condição 2){
                comando 3
                comando 4               estrutura de encadeamento
            }
            else if(condição 3){
                comando 5
                comando 6
            }
            else{
                comando 7
                comando 8
            }
            */
            Console.WriteLine("Digite a sua hora atual");
            int hour = 12;

            if(hour < 12){
                Console.WriteLine("Bom Dia");
            }
            else if(hour < 18){// se a hora não é menor do que 12 eu nem tenho a necessidade de especificar que a hora é maior ou igual a 12
                Console.WriteLine("Boa Tarde"); // pois como o programa já identificou que a hora não é menor que 12 ele já descartou esse intervalo de hora.
            }
            else if(hour >= 18){
                Console.WriteLine("Boa Noite");
            }
            else{
                Console.WriteLine("Digite uma hora valida por favor");
            }

        }
    }
}