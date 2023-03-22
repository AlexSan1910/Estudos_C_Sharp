using System;
using System.Globalization;

namespace Course{
    class Calculadora{
        public static double Pi = 3.14; // estamos definindo em todas as operações o nome estatico, justamente pelo fato de que essa variavel.
        // não terá alterações, sendo assim ela pode ser estatica, e como os metodos abaixo abaixo tambem não terá alterações, eu posso da 
        // mesma forma definir eles como metodos estaticos, justamente porque como não terá alterações neles, será sempre o mesmo resultado
        // não há necessidade de definirmos como normal, mas sim como estatica... e no programa principal, ao invés de chamarmos o objeto
        // que criamos do tipo calculadora por exemplo, não teremos mais a necessidade de criar esse objeto e muito menos instanciar
        // basta simplesmente chamar o proprio metodo ao invés de um objeto.


        public static double Circunferencia(double raio){// criando uma função, e não há necessidade de criamos essa função com a palavra public.. 
                                                 // pois essa função não tera necesidade de ser publica, uma vez que ela já está dento da 
                                                 // mesma classe em que ela será utilizada.
            return 2.0 * Pi * raio;
        }

        public static double Volume(double raio){
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}