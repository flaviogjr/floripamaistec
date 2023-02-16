// [M01S02] Ex 4 - Cálculo de média de aprovação


string[] nomeAluno = new string[5];
decimal[] mediaAluno = new decimal[5];


for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome do(a) {i + 1}º aluno(a): ");
    nomeAluno[i] = Console.ReadLine();

    Console.Write($"Digite a média do {i + 1}º aluno(a): ");
    mediaAluno[i] = decimal.Parse(Console.ReadLine());
}


for (int i = 0; i < 5; i++)
{
    if (mediaAluno[i] >= 6)
    {
        Console.WriteLine($"O(A) aluno(a) {nomeAluno[i]} está APROVADO(A)");
    }
    else
    {
        Console.WriteLine($"O(A) aluno(a) {nomeAluno[i]} está REPROVADO(A)");
    }
}

