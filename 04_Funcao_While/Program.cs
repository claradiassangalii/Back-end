//Funçao em JavaScrpt
//funvtion nomeFuncao (nome){}

//funçao / método em C#
//public static string nomeFuncao(string nome){}

class sesi{
    public static void Main()
     {
        //Chamando métodos sem retorno
        MostrarMensagem("Seja bem vindo");

        MostrarMensagem("Sesi / Senai");

        ImprimirDataHora();

        double potencia = Potenciacao (4);

        Console.WriteLine($"Potenciaçao {potencia}");    

        ContagemRegressiva(10);

        JogoQueNrSouEu();
    }
    //metodo com parametro e com retorno
    public static double Potenciacao(int num){
        double resultado = Math.Pow(num, 2);
        return resultado;
    }
    //metodo sem parametro e sem retorno
    public static void ImprimirDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }

    //metodo com parametro e sem retorno
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
    


    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep (500);

        }
        Console.WriteLine("BOMMMMMMMMMMMM");
    }

    public static void JogoQueNrSouEu()
    {
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * ");
        Console.WriteLine("                    Bem-vindo ao jogo             ");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * ");
        Console.WriteLine("");//Linha em branco

        Random rnd = new Random ();
        int nrSorteado = rnd.Next (20);
        int nrDigitado = -1;

        do{
            Console.WriteLine ("Digite um n°");
            nrDigitado = int.Parse (Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine ("O numero digitado é MAIOR que o sorteado");

            else if (nrDigitado < nrSorteado)
            Console.WriteLine("Onumero digitado é MENOR que o sorteado");

        }while (nrDigitado != nrSorteado);
        Console.WriteLine("Parabéns voce acertou");

    }
}
