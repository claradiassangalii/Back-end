// exercicio 1 Calculando a média de 3 notas de um aluno
//receber o nome do aluno e armazenar em uma variavel do tipo string
//receber a nota 1, converter e armazenar em uma variável int
//Receber nota 2, converter e armazenar em uma variável int
//receber nota 3, converter e armazenar em uma variável int

//Declarar uma variavel do tipo int, para receber a média das notas 
//(nota1 + nota2 + nota3)

//Exibir se o aluno esta aprovado considerando nota acima de 7

Console.WriteLine("Digite o nome do aluno:");
string nomeAluno = Console.ReadLine();

Console.WriteLine($"Digite a nota 1 do {nomeAluno}:");
int nota1 = int.Parse (Console.ReadLine());

Console.WriteLine($"Digite a nota 2 do {nomeAluno}:");
int nota2 = int.Parse (Console.ReadLine());

Console.WriteLine($"Digite a nota 1 do {nomeAluno}:");
int nota3 = int.Parse (Console.ReadLine());

int media = (nota1 + nota2 + nota3) / 3;

if (media >= 7){
    Console.WriteLine($"O aluno {nomeAluno} foi aprovado");
} else{
    Console.WriteLine($"O aluno {nomeAluno} foi reprovado");
}
