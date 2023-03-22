using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){

            Funcionario funcionario;

            funcionario = new Funcionario();

            Console.Write("Digite seu nome, salario Bruto e Imposto por favor: ");
            funcionario.Nome = Console.ReadLine();
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            funcionario.Imposto = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + funcionario.Nome + ", R$ " + funcionario.SalarioLiquido());
            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = int.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario);


            
            

        }
    }
}
