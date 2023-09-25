namespace Models
public class Produtos{
     private string nomeCliente { get; set; }
     private string emailCliente{ get; set; }
      private int Telefone { get; set; }
    private int cpf { get; set; }    
    public int cep { get; set; }
    public int Nr_casa { get; set; }

     public Produtos (string nomeCliente, string emailCliente, int Telefone, int cpf, int cep)
     {
        this.nomeCliente =nomeCliente;
        this.emailClienteo = emailCliente;
        this.Telefone = Telefone;
        this.cpf= cpf;
        this.cep =cep;
        this.Nr_casa = Nr_casa ;
     }

}