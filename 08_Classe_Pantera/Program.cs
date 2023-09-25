using Animal;

class Program
{
    static void Main()
    {
        var Pantera1 = new Pantera();

        Pantera1.nome = "Pantera preta";
        Pantera1.peso = "140kg";
        Pantera1.cor = "preta";
        Pantera1.especie = "panthera onca";
        Pantera1.alimentacao = "herbívoros, lebres, répteis, insetos, enguias, peixes";
        Pantera1.correr();
        Pantera1.cacar();
    }
}
