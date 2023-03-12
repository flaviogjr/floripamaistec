using AulaProperties.Classes;

Produto produto = new Produto("TV 32 Polegadas", 990, 10);

//Parametros alterados para o construtor
//produto.nome = "TV 32 polegadas";
//produto.preco = 990;
//produto.quantidade = 10;

//Console.WriteLine(produto.GetNome());
//Console.WriteLine(produto.GetPreco());
//Console.WriteLine(produto.GetQuantidade());

//produto.SetNome("");
//Console.WriteLine(produto.GetNome());

//.DescreverProduto();

Console.WriteLine(produto.Nome);
produto.Nome = "TV 40 Polegadas";
Console.WriteLine(produto.Nome);

produto.Quantidade = 10;
Console.WriteLine(produto.Quantidade);