

namespace Course{
    class ConversorDeMoeda{

        public static double compraDolar;
        public static double cotacaoDolar;

        public static double CalculoDolar(){
            double calc = compraDolar * cotacaoDolar;
            return (calc * 0.06) + calc;
        }

    }
}