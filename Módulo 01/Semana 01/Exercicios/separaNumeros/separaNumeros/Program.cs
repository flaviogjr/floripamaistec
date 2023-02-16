// [M01S02] Ex 3 - Separador de números ímpares e pares


List<int> numerosPares = new List<int>();
List<int> numerosImpares = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    int num = int.Parse(Console.ReadLine());

    // verifica se número é par ou ímpar
    if (num % 2 == 0)
    {
        numerosPares.Add(num);
    }
    else
    {
        numerosImpares.Add(num);
    }
}

// organiza lista em ordem crescente
numerosImpares.Sort();
numerosPares.Sort();

// o método Count() conta e o Sum() soma dos números de uma lista
Console.WriteLine($"A lista de números pares possui {numerosPares.Count()} números e a soma deles é igual a {numerosPares.Sum()}");
Console.WriteLine($"A lista de números ímpares possui {numerosImpares.Count()} números e a soma deles é igual a {numerosImpares.Sum()}");


