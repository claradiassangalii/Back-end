namespace Models
{
    public class Pessoa
    {
        //Atributos da nossa classe Pessoa
            private string nome { get; set; }
            private int idade{ get; set; }

            private string Email { get; set; }

            private int anoNascimento{ get; set; }

        //Método construtor da classe Pessoa
            public Pessoa (string nomePessoa, int idadePesoa, string nomeEmail)
            {
                this.nome = nomePessoa;
                this.idade = idadePesoa;
                this.nome = nomeEmail;
                this.anoNascimento =DateTime.Now.Year - idadePesoa;
            }
          

        //metodo da classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($" O {nome} com a idade {idade} está cantando");
        }
        public void Informacoes()
        {
            Console.WriteLine($" O {nome} tem {idade} anos, seu email é {Email}, nasceu em {anoNascimento}");
        }
        
        
    } 
}