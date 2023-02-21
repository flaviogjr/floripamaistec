using ExercicioConstrutor.Classes;

Produto produto1 = new Produto("Teclado", 245.99, 58);
Produto produto2 = new Produto();

Console.WriteLine($"O produto {produto1.nome} custa R$ {produto1.preco} e possui {produto1.quantidade} unidades em estoque");
Console.WriteLine($"O produto {produto2.nome} custa R$ {produto2.preco} e possui {produto2.quantidade} unidades em estoque");