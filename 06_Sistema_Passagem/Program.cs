class program
{
     public static string[] poltronas = new string[43];
    public static void Main()
    {

        Console.Clear();
        Console.WriteLine("Bem vindo ao SesiBus");
        Console.WriteLine("**************************");
        Console.WriteLine("Contamos com 42 lugares disponíveis");
        Menu();
    }

    public static void Menu()
    {
        string opcao = "";
        do {
            Console.WriteLine("######### MENU #########");
            Console.WriteLine("1 - Para comprar passagens");
            Console.WriteLine("2 - Para poltronas disponiveis");
            Console.WriteLine("0 - Para fechar o sistema");
            opcao = Console.ReadLine();

            Console.Clear();
           
        }while(opcao != "0");

        switch(opcao) {
            case "0":
                Console.WriteLine("Obrigado, volte sempre");
                System.Thereading.Thread.Sleep(1000);
                break;

            case "1":
                    ComprarPassagem();
                break;

            case "2":
                    PoltronasDisponiveis();

            default:
                Console.WriteLine("Opção inválida");
                break;

        }
            
    }
    public static void ComprarPassagem(){
            Console.WriteLine("Quantas passagens deseja comprar?");
            int nrPassagem =int.Parse(Console.ReadLine());
            
            for(int i=1;i<=nrPassagem; i++)
            {
                Console.WriteLine($"Digite a poltrona da{i}° passagem:");
                int nrPoltrona = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o nome do passageiro:");
                string nome = Console.ReadLine();
                MarcarPoltrona(nrPoltrona, nome);
            }
        }
    public static void MarcarPoltrona(int nrPoltrona, string nome){
        poltronas[nrPoltrona] = nome;
    }
    public static void  PoltronasDisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponíveis");
        for(int i = 1; i < 10; i++){
            if(poltronas[i] == null){
                Console.WriteLine($"N° {i}");
            }
        }
    }
}
