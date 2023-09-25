// o namespace é o nome em que usaremos para fazer referencia quando usarmos 
// em outras classes
namespace Sesi.Model
{
    //Declarado nossa classe aluno
    public class Aluno
    {
        //declarando nossos atributos (propriedades da classe aluno)
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }


        private int nrFaltas { get; set; }
        //Criando um método 
        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {nome},eu tenho {idade} anos e estudo na turma {turma}!");
        }

        public void AdicionarFaltas(int nr){
            nrFaltas = nrFaltas + nr;
        }
        public void resumirFaltas(){
            Console.WriteLine($"{nome}, voce tem {nrFaltas} faltas");
        }

        public void justificarFaltas(int nr){

            nrFaltas = nrFaltas - nr;
        }
    
    }
}