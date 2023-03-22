// Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

// Dados do primeiro funcionário:
//Nome: Carlos Silva
//Salário: 6300.00
//Dados do segundo funcionário:
//Nome: Ana Marques
//Salário: 6700.00
//Salário médio = 6500.00
//using System;
//using System.Globalization;
using System;
using System.Globalization;

namespace Course{
    class ProgramTwo{
        static void Main(string[] args){

            Funcionarios employeeOne; // definindo variavel com o tipo da classe Funcionario.
            Funcionarios employeeTwo;

            employeeOne = new Funcionarios(); // instanciando a variavel do tipo classe funcionario.
            employeeTwo = new Funcionarios();

            Console.Write("Por favor digite o nome do primeiro Funcionario: ");
            employeeOne.NameEmployee = Console.ReadLine();
            Console.Write("Por favor digite o salario do funcionario um: ");
            employeeOne.WageEmployee = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            Console.Write("Por favor digite o nome do Segundo Funcionario: ");
            employeeTwo.NameEmployee = Console.ReadLine();
            Console.Write("Por favor digite o salario do funcionario Dois: ");
            employeeTwo.WageEmployee = double.Parse(Console.ReadLine(), provider: CultureInfo.InvariantCulture);

            if(employeeOne.WageEmployee > employeeTwo.WageEmployee){
                Console.WriteLine("o Salario do " + employeeOne.NameEmployee + " é maior");
            }else{
                Console.WriteLine("O salario do " + employeeTwo.NameEmployee + " é o maior");
            }
        }
    }
}