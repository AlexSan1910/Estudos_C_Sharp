using System;
using System.Globalization;

namespace Course{
    class Retangulo{

        // atributos
        public double Largura;
        public double Altura;


        // Funções ou Metodos
        public double Area(){
            double area = Altura * Largura;
            return area;
        }

        public double Perimetro(){
            double comprimento = 2 * (Altura + Largura);
            return comprimento;
        }

        public double Diagonal(){
            double diagonal = Math.Sqrt(Largura * Largura + Altura * Altura);
            return diagonal;
        }

    }
}