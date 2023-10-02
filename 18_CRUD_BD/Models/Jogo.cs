using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    //DataAnnotation de como será criado o nome da tabela no BD
    [Table("Jogos")]
    public class Jogo
    {
        [Key]   //Falando para o banco de dados que este atributo sera uma chave 

        public int JogoId { get; set; }
        [Required(ErrorMessage="Nome é obrigatório")]
        [MaxLength(200,ErrorMessage = "Descrição pode exceder {1} carateres")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Ativo { get; set; }

    }
}