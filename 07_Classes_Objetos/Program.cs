//Sempre que formos utilizar bibliotecas ou classes já criadas 
//importamos ela com o using
using Sesi.Model;

class Program
{
    public static void Main()
    {
        //criando uma viriável aluno1 e instanciando da class Aluno
        //ou seja, etsmaos cirnado nosso objrto
        var aluno1 = new Aluno();
        //Atribuindo valor ao atributo nome do aluno1
        aluno1.nome = "Clara";
        aluno1.idade = 17;
        aluno1.turma = "2º EM";
        aluno1.Apresentar();   
        aluno1.resumirFaltas();
        aluno1.justificarFaltas(2);
        aluno1.resumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.resumirFaltas();
        aluno1.justificarFaltas(2);
        aluno1.resumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.resumirFaltas();
                                                    
    //************************************************
        var aluno2 = new Aluno();
        aluno2.nome = "Giovana";
        aluno2.idade = 15;
        aluno2.turma = "1ºEM";
        aluno2.Apresentar();

    }
}