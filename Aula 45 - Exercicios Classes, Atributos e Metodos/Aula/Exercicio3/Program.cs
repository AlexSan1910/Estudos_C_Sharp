//Fazer um programa par aler o nome de um aluno e as três notas que ele obteve nos trÊs trimestres do ano, (Primeiro Semestre vale 30 e os outros dois vale 35),
// Ao final, mostrar qual a nota final do aluno no ano, Dizer tambem se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos ontos faltam
// para o aluno obter o minimo para ser aprovado (Que é 60 pontos). Você deve criar uma classe ALUNO para ressolver esse probema.

using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){

            Aluno aluno;
            aluno = new Aluno();

            Console.WriteLine("Digite seu nome: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as Três notas do aluno: ");
            aluno.NotaUm = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            aluno.NotaDois = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            aluno.NotaTres = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota Final: " + aluno.CalculoNotas());

            if (aluno.Aprovado() ==  true){
                Console.WriteLine("Parabens, Aprovado!!");
            }
            else{
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltou " + aluno.NotaRestante() + " Pontos..");
            }
        }
    }
}
