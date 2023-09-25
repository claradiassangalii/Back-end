public class Program{
    public static void Main()
    {
        //Criando classes anonimas (classe sem definiçao inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "maria",
            email = "mariagasebo@gmail.com",
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade}");
        Console.WriteLine($" A pessoa2 é {pessoa2.nome} e tem o email {pessoa2.email}");

        var carro = new {
            marca = "wolksvagem" ,
            modelo = "Gol",
            ano = 2016
        };

        var carro2 = new {
            marca = "Toyota",
            modelo = "Corolla",
            ano = 2022
        };

        Console.Write ($"Temos á venda o modelo {carro.modelo} da marca {carro.marca} e ano de {carro.ano} ");
         Console.Write ($" Temos á venda o modelo {carro2.modelo} da marca {carro2.marca} e ano de {carro2.ano} ");
    }
}