// Fazer um programa para ler os dados de um funcionario (Nome, Salario Bruto e Imposto).
// em seguida, mostrar os dados do funcionario(nome e Salario Liquido). em seguida, aumentar
// o salario do funcionario com base em uma porcentagem dada(somento o salario bruto é afetado
// pela porcentagem) e mostrar novamente os dados do funcionario. use a classe projetada abaixo.

using System;
using System.Globalization;

namespace Course{
    class Funcionario{

        // Atributos 
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        // Funções ou Metodo
        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcent){
            SalarioBruto = SalarioBruto + (SalarioBruto * porcent / 100.0);
        }

        public override string ToString(){
            return Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}