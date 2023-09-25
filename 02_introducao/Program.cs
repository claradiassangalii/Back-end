//declarando uma variáve do tipo inteira e sem nenhum valor
//int num1;

//declarando uma variável do tipo inteiro e atribuindo valor 5
//int num2 = 5;

//declarando variavel string
//string nomeAluno = "Paulo";

//variável o tipo lógico (true ou false)
//bool resultado = true;

//variável do tipo double valor com varias casas decimais
//double coordenada = 1.256458654;

//variável do tipo decimal - utilizado para valores
//decimal valor = 1.80M;
int idade = 35;
string meuNome = "Clara";
Console.WriteLine($"meu nome e {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine("Em que cidade voce nasceu?");

//ReadLine serve apenas para que eu receba uma informaçao do usuário
// e armazeno em um variável
string nomeCidade = Console.ReadLine();
Console.WriteLine($"voce nasceu em {nomeCidade}");