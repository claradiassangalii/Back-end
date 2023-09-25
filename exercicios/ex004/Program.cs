
class exercicios{
    
    public static void Main()
    {
        Console.WriteLine("Digite um número");
        int numero = int.Parse(Console.ReadLine());

        double resultado = dobro(numero);
        Console.WriteLine($"O dobro é: {resultado}");

        double resultado2 = metade(numero);
        Console.WriteLine ($"A metade é :{resultado2}");

        tabuada(numero);

        ResumoSalarios()
    }


     public static double dobro (int num){
        double resultado = (num)*2;
        return resultado;
    }
    public static double metade(int num){
        int metade1 = (num)/2;
        return metade1;

    }
  
   public static void tabuada(int num){
    int contador = 1;

        while(contador <= 10){
            Console.WriteLine($"{contador} X {num} = {num * contador}");
            contador++;
        }
   }
   public static void ResumoSalarios()
   {
    int somaSalario = 0;
    int menorSalario = 100000;
    int maiorSalario = 0;
    int salarioEmpregado = 0;
    do{
        Console.WriteLine("Digite o salário do empregado");
        salarioEmpregado = int.Parse(Console.ReadLine());
        somaSalario = somaSalario + salarioEmpregado;
        //somaSalario += salarioEmpregado; //Recomendado
        if(salarioEmpregado > maiorSalario){
            maiorSalario = salarioEmpregado;
        }
        if (salarioEmpregado < menorSalario && salarioEmpregado > 0 ){
            menorSalario = salarioEmpregado;
        }

    }while(salarioEmpregado > 0);

    Console.WriteLine($"A soma dos salários é  {somaSalario} o maior salário é {maiorSalario} e o menor salário é {menorSalario}");
   }
}

   