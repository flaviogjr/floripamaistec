// [M01S02] Ex 2 - Organizador de lista de frutas


List<string> listaDeFrutas = new List<string>();

bool continuar = true;
while (continuar)
{
    if (listaDeFrutas.Count() == 15)
    {
        continuar = false;
    }
    Console.Write("Digite o nome de uma fruta: ");
    listaDeFrutas.Add(Console.ReadLine());
    Console.Write("Deseja continuar? [s] para sim ou [n] para não: ");

    string resposta = Console.ReadLine();
    if (resposta == "n" || resposta == "nao")
    {
        continuar = false;
    }
}

// coloca a lista em ordem alfabética
listaDeFrutas.Sort();

foreach (string fruta in listaDeFrutas)
{
    Console.WriteLine(fruta);
}

