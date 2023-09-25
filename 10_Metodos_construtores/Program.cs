using Models;

public class program
{
    public static void Main()
    {
        //Criando um obj da clsse Pesoa
        //instanciando sem um método construtor
        /*Pessoa pessoa1 = new Pessoa() ;
        pessoa1.nome = "Douglas";
        pessoa1.idade = 23;
        pessoa1.Cantar();

        //Alternativa para criaçao de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            nome = "Ricardo",
            idade = 23
        };
        pessoa2.Cantar();*/

        Pessoa pessoa1 = new Pessoa("Douglas" , 35, "diassanagliclara@gmail.com");
        pessoa1.Cantar();
        pessoa1.Informacoes();
    /*************************************************************************/
        Pessoa pessoa2 = new Pessoa("clara", 17, "Giovanasilva@gmail.com");
        pessoa2.Cantar();
        pessoa2.Informacoes();

       

    }
    
}