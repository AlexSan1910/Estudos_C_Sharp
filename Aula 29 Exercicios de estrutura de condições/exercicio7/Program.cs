// Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
// de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
// ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
// Se o ponto estiver na origem, escreva a mensagem “Origem”.
// Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
// situação.

namespace uri1041 {
    class Program {
        static void Main(string[] args) {

            double eixoX = 0.0;
            double eixoY = 0.0;

            if (eixoX == 0.0 && eixoY == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (eixoX == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (eixoY == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (eixoX > 0.0 && eixoY > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (eixoX < 0.0 && eixoY > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (eixoX < 0.0 && eixoY < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
    }
}