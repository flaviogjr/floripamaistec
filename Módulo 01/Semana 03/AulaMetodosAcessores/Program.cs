using AulaMetodosAcessores.Classes;

Produto produto = new Produto("TV", 990, 10);

//Parametros alterados para o construtor
//produto.nome = "TV 32 polegadas";
//produto.preco = 990;
//produto.quantidade = 10;

Console.WriteLine(produto.GetNome());
Console.WriteLine(produto.GetPreco());
Console.WriteLine(produto.GetQuantidade());

produto.SetNome("");
Console.WriteLine(produto.GetNome());



//.DescreverProduto();