using System;

namespace Course{
    class Triangulo{
        public double A;// publica para acessos a outros arquivos, com a letra maiuscula pois é utilizado esse padrão em um atributo.
        public double B;
        public double C;

        public double Area(){// como os dados que irei utilizar já estão nessa classe triangulo, que são os atributos A, B e C, eu posso deixar os parenteses sem 
                             // nada dentro.. porem se eu fosse utilizar outros atributos de outras classes ou outras variavel de outros arquivos
                             // ai sim talvez eu teria que definir dentro dos parenteses.
                             // definindo essa função como publica para ser acessada em outros arquivos, definindo com o 
                             // tipo double pois pode ser um numero quebrado com o nome do metodo "Função" em Maiusculo.   

            double p = (A + B + C) / 2.0; // como não estou mechendo com um triangulo em especifico, eu não preciso definir se é o lado A do triangulo X por exemplo, eu só coloco os lados.
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // fazendo o calculo da raiza quadrada.
            return raiz; // estou dizendo que esse metodo, ou função irá retornar o valor de raiz, pra quando eu querer puxar esse resultado la no outro arquivo.


        }

    }; 
}