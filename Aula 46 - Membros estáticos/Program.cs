using System;
using System.Globalization;

namespace Course{
    class Program{

        static double Pi = 3.14; // decalrando o valor de Pi como estatico, pois estou declarando fora do metodo statico e pra acessar
                                 // dentro dele, precisa ser estatica.
        static void Main(string[] args){

            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circuferencia(double raio){// criando uma função, e não há necessidade de criamos essa função com a palavra public.. 
                                                 // pois essa função não tera necesidade de ser publica, uma vez que ela já está dento da 
                                                 // mesma classe em que ela será utilizada.
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio){
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}
