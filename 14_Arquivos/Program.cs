using System.IO;

public class Program
{
  
    public static void Main()
    {
       
    ChamarArquivos();
    lerArquivo();
        
    }

    
    public static void lerArquivo()
    {
        
        try
        {
            string caminhoArquivo = "Arquivo/arquivo.txt";

            //Verificar se o arquivo existe 
            if(File.Exists(caminhoArquivo ) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando 
                //a verificaçao 
                File.Create(caminhoArquivo );
                
            }
        
            using (StreamReader arquivo = new StreamReader("Arquivo/arquivo.txt"))
            {
                string linha;
                while(( linha = arquivo.ReadLine()) !=null)
                {
                    Console.WriteLine(linha);
                }

            }
        }
        catch(Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");

        }
    }
      public static void ChamarArquivos()
    {
         try
        {
           
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt"))
            {
                Console.WriteLine("Digite algum texto para salvar");
                string texto = Console.ReadLine();
                arquivo.WriteLine(texto);
            }
        }

        catch(Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");

        }
    }
}