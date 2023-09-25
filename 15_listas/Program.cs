using System.Collections.Generic;
using Sesi.Models;

public class Program
{

    public static void Main()
    {   
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos á lista 
        listaNumeros.Add(10); //posiçao [0]
        listaNumeros.Add(20); //posiçao [1]
        listaNumeros.Add(45); //posiçao [2]


        //acessando os dados da lista pelo indice
        Console.WriteLine(listaNumeros[2]);

        listaNumeros.Add(65); //posiçao [3]

        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");




        List<string> listaNomes = new List<string>();
        listaNomes.Add("Giovana");
        listaNomes.Add("Rafaela");
        listaNomes.Add("Julia");

        Console.WriteLine(listaNomes[2]);
        Console.WriteLine($"Nesse momento temos {listaNomes.Count} nomes cadastrados");

        Console.WriteLine("*********************************************************");


        //criando uma lista já atribuindo valores
        List<int> numeros = new List<int>{1,2,3,4,5,6,7,8};
        Console.WriteLine($"Quantidade de elementos  na lista numeros: {numeros.Count}");
        numeros.Remove(2); //Remover o elemento 2
        
        numeros.RemoveAt(1); //Remover o elemento no indice 1
        numeros.RemoveRange(2,2); //remover 2 elementos a partir do indice 2

        //Substituindo informaçoes do item da lista
        numeros[0] = 100;


        //iterando sobre todos os itens da lista
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero);
        }


        foreach(string nome in listaNomes)
        {
            Console.WriteLine(nome);
        }
        //Criando uma lista com objetos da |Classealunos
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno á minha lista 
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno ("Patricia", 17));

        //Exibindo lista de alunos
        Console.WriteLine("Lista Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
        }
        


        //Criando uma nova lista porem ordenando por nome
        //LINQ utilizando Sintaxe de consulta
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno.nome);
        }

        //LINQ utilizado |Sintaxe de métodos
        var consulta = listaAlunos
                        .Where(aluno => aluno.idade == 17)
                        .OrderBy(aluno => aluno.nome);  


        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }
    }
}