using System;
using System.Globalization;

namespace Course{
    class Program{

        // Notem que não houve a necessidade de criamos um objeto do tipo Calculadora, pois como os atributos e os metodos são todos 
        // estaticos "ou seja, não alteram o seu valor", podemos então simplesmente chamar a propria classe ao invés de definirmos um objeto
        // e posteriormente ter que chamar o objeto puxando o atributo ou metodo.

        static void Main(string[] args){

            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
