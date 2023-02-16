//[M01S02] Ex 1 - Buscador de números primos



// array para armazenamento de dez números
int[] arrayDeNumeros = new int[10];

// Contador array
for (int i = 0; i < 10; i++)
{
    // Soma + 1 pois o índice do array inicia em 0
    Console.Write($"Digite o {i + 1}º número: ");

    int num = int.Parse(Console.ReadLine());
    arrayDeNumeros[i] = num;
}

// Contador para verificar se cada número do array é primo
for (int i = 0; i < 10; i++)
{

    // o contador vai marcar quantas vezes ele é divisível por um número menor que ele
    // começa em 1 porque todo número é divisível por 1 e nenhum por zero
    int contador = 1;

    // Inicia-se em 1 porque o primeiro índice é zero e nenhum número pode ser dividido por zero.
    for (int n = 1; n < arrayDeNumeros[i]; n++)
    {
        if (arrayDeNumeros[i] % n == 0)
        {
            contador = contador + 1;
            // ou contador++;
        }
    }

    // se o contador == 2 é sinal que ele é divisível somente por 0 e por ele mesmo - número primo.
    if (contador == 2)
    {
        Console.WriteLine($"O número {arrayDeNumeros[i]} é primo. Ela está na posição {i} do Array de números.");
    }
}
