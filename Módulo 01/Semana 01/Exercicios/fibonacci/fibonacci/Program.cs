// [M01S02] Ex 5 - Sequência de Fibonacci


int n;
int x = 1, y = 0, z = 0;

// Total de números na sequência
Console.Write("Digite o número de ítens que quer ver na sequência: ");
string number = Console.ReadLine();

n = int.Parse(number);


for (int i = 0; i < n; i++) // sequência de Fibonacci
{

    // soma o anterior (y) com o número atual (x)'. Z = resultado
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}
Console.ReadLine();

