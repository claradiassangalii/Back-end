Console.WriteLine("Digite sua placa:");
string numPlaca = Console.ReadLine();

string final = numPlaca.Substring(numPlaca.Length -1, 1); 




if (final== "2" ||final== "1"){
    Console.WriteLine($"Voce pode rodar na segunda-feira");
}

else if (final== "3" || final == "4"){
    Console.WriteLine($"Voce nao pode rodar na terça-feira");
}

else if (final == "5" || final == "6"){
    Console.WriteLine($"Voce nao pode rodar na quarta-feira");
}

else if (final == "7" || final == "8"){
    Console.WriteLine($"Voce nao pode rodar na quinta-feira");
}

else if (final == "9" || final == "0"){
    Console.WriteLine($"Voce nao pode rodar na sexta-feira");
}

