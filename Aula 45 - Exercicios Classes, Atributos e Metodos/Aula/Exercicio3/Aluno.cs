
namespace Course{
    class Aluno{

        // Atributos
        public string Nome;
        public double NotaUm;
        public double NotaDois;
        public double NotaTres;

        public double CalculoNotas(){
           return NotaUm + NotaDois + NotaTres;

        }

        public bool Aprovado(){

            if (CalculoNotas() > 60.00){
               return true;
            }
            else{
                return false;
            }
        }

        public double NotaRestante(){

            if (Aprovado() == true){
                return 0.0;
            }
            else{
                return 60.0 - CalculoNotas();
            }

        }

       

    }
}