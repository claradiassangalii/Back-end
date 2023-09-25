namespace Models
public class Clientes{
    private int idClientes { get; set; }
     private string nomeCliente { get; set; }
     private string emailCliente{ get; set; }
      private int Telefone { get; set; }
    private int cpf { get; set; }    
    public int cep { get; set; }
    public int Nr_casa { get; set; }
    private string senha { get; set; }
    private int dataNascimento { get;}


     public Produtos (string nomeCliente, string emailCliente, int Telefone, int cpf, int cep, int nr_casa, string senha, int dataNascimento)
     {
        this.nomeCliente =nomeCliente;
        this.emailClienteo = emailCliente;
        this.Telefone = Telefone;
        this.cpf= cpf;
        this.cep =cep;
        this.Nr_casa = Nr_casa ;
        this.senha = senha;
        this.dataNascimento= dataNascimento;
        
     }

}
