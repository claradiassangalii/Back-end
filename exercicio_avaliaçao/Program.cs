using Contacorrente;
public class program{
    public static void Main()
    {   
        
        Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine($"Bem vindo ao SesiBank");
        Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.Clear();    
        Console.WriteLine("Digite o nome");
        conta conta1 = new conta(Console.ReadLine(), 0);

        string opcao = "";



        do{
            Console.WriteLine("*********escolha a opçao*********");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar ");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            opcao = Console.ReadLine();

            Console.Clear();

            switch(opcao){

            case "1":
            conta1.consultarSaldo();
            break;

            case "2":
            conta1.depositar();
            break;

            case "3":
            conta1.Sacar();
            break;
            
            case "4":
            Console.WriteLine("Obrigado, volte sempre");
            System.Threading.Thread.Sleep(1000);
            break;
        }

        }while(opcao != "0");
            
        
        }
    }
