class Program
{
    public static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($" Estou passando pela {i}º vez no for");
        }
        for (int sesi = 10; sesi >= 0; sesi--)
        {
            Console.WriteLine($"Variável sesi vale {sesi}");
        }

        int numero = 87;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.Write($"{numero} X  {cont} = {numero * cont}");
        }

        //declarando valores ao nosso vetor
        string[] alunos = new string[35];

        //Atribuindo valores ao nosso vetor 
        alunos[1] = "Abner";
        alunos[2] = "Adalberto";
        alunos[3] = "Ana Carolina ";
        alunos[34] = "samuel";

        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[1] = 34;
        cadeiras[2] = 69;
        cadeiras[3] = 99;
        cadeiras[4] = 50;

        int laura = 0; //soma
        int jorge = 0; //maior
        int bianca = 100; //menor
        foreach (int enzo in cadeiras)
            {
                laura=laura+enzo;
                if(enzo > jorge){
                    (jorge=enzo);
                }if (enzo < bianca){
                    (bianca=enzo);
                }
                
            }
            Console.WriteLine($"Soma: {laura}, Maior: {jorge}, Menor:{bianca}");

            Array.Sort(cadeiras);

            for (int x = 0; x<cadeiras.Length; x++){
                Console.WriteLine($"Pos{x} - valor {cadeiras[x]} ");
            }
    }
}
