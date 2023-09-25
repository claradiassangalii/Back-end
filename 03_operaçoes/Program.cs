Console.WriteLine("Digite o valor de x:");
int x = int.Parse (Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse (Console.ReadLine());
//Exemplos de operadores aritméticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;   //calculando o resto da divisao de 
int restoDiv3 = y % 2;

//console para exibir na tela
//soma: 15

Console.WriteLine($"soma:{soma}");
Console.WriteLine($"subtraçao: {subtracao}");
Console.WriteLine($"multiplicaçao:{multiplicacao}");
Console.WriteLine($"divisão:{divisao}");
Console.WriteLine($"resto:{resto}");

if (restoDiv2 == 0){
    Console.WriteLine($" O número {x} é par");
} else{
    Console.WriteLine($" O numero {x} é ímpar");
}

if (restoDiv3 == 0){
    Console.WriteLine($" O número {y} é par");
} else{
    Console.WriteLine($" O numero {y} é ímpar");
}

//operador ternário
//condiçao ? se verdade: senao 
string resultado = (restoDiv2 == 0) ? $"O número {y} é par" : $"O número {y} é ímpar"
Console.WriteLine(resultado);


int diaSemana = 3;
//Aprendendo o switch case
switch (diaSemana) {
    case 1:
     Console.WriteLine("Hoje é Domingo"); 
    break;
      case 2:
     Console.WriteLine("Hoje é Segunda"); 
    break;
      case 3:
     Console.WriteLine("Hoje é Terça"); 
    break;
      case 4:
     Console.WriteLine("Hoje é Quarta"); 
    break;
      case 5:
     Console.WriteLine("Hoje é Quinta"); 
    
      case 6:
     Console.WriteLine("Hoje é Sexta"); 
    break;
      case 7:
     Console.WriteLine("Hoje é Sabado"); 
    break;
     default:
     Console.WriteLine("Dia inválido");
     break;

}

