using AulaModificadoresAcesso;

Produto produto1 = new Produto();

produto1.nome = "Calculadora";
produto1.verificarEstoque();
Console.WriteLine($"O nome do produto é: {produto1.nome}");

Console.WriteLine("------ Abaixo será valores e ações de uma classe filha");

ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();

classeFilha.nome = "Produto Financeiro";
classeFilha.verificarEstoque();
classeFilha.acesso();
