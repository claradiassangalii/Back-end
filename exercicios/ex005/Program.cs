class Exercicio
{

    public static void Main()
    {

        listaChurrasco();
        SonhosDeConsumo();
    }
    public static void listaChurrasco()
    {
        string[] lista = new string[6];

        for (int i = 0; i < 6; i++) {
        Console.WriteLine("Digite o produto que vamos comprar");

        string produto = Console.ReadLine();
        lista[i] = produto;
        }
        Array.Sort(lista);
        foreach(string item in lista){
            Console.WriteLine(item);
        }
    }

    public static void SonhosDeConsumo(){
        string[] sonhos = new string[3];
        decimal [] valores = new decimal[3];
        decimal total = 0;

        for (int i = 0; i < 3; i++){
            Console.WriteLine($"Digite o seu {i}° sonhos de consumo");
            string sonho = Console.ReadLine();
            Console.WriteLine("Valor do seu {i°} sonho");
            sonhos[i] = sonho;
            decimal valor = decimal.Parse(Console.ReadLine());
            valores[i] = valor;
        }
        foreach (decimal val in valores){
            total = total + val;
            Console.WriteLine($"Seus sonhos custarão aproximadamente R${total}");
        }

        
    }
}