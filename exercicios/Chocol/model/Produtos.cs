namespace Models
public class Produtos{
    private int id_produto {get; set;}
     private string nome { get; set; }
     private string descricao { get; set; }
      private decimal preco { get; set; }
    private string imagem { get;}

     public Produtos (string nome, string descricao, decimal preco, string imagem)
     {
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
        this.imagem = imagem;
     }
}
