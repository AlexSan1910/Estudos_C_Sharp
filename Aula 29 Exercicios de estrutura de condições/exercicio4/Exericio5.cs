// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
// começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

namespace Course{
    class Program{
        static void Main(string[] args){

            
            int hourStar = 2;
            int hourEnd = 16;
            int hourPlaying = 0;

            if(hourStar < hourEnd){
                hourPlaying = hourEnd - hourStar;
            }
            else{
                hourPlaying = 24 - hourStar + hourEnd;
            }

            Console.WriteLine("o jogo durou " + hourPlaying + " hora(s)");
        }
    }
}