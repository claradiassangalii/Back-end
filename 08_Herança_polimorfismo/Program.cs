//classe pai que será herdada pelo filho - SuperClasse
 class Animal
{
    
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}
//classe filha que herdará da classe Animal
//receberá todos os atributos e métodos da SuperClasse
class Cachorro : Animal
{
    public string tipoPelo {get; set;}  
    public void latir(){
        Console.WriteLine($"Ocachorro {cor} está latindo");
    }

  }

class Gato : Animal
{
          
    public override void EmitirSom()
    {
         Console.WriteLine("O gato esta miando");
    }
}

class Program
{
    public static void Main()
    {   
        //não é permitido instancir um objeto de uma classe abstrata
        /*var AnimalGenerico = new Animal();
        AnimalGenerico.EmitirSom();*/

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.EmitirSom();
        meuCachorro.cor = "Branco";
        meuCachorro.EmitirSom();
        meuCachorro.latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}
