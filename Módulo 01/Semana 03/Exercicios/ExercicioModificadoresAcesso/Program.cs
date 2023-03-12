using ExercicioModificadoresAcesso;

Produto produto1 = new Produto();

produto1.nome = "Calculadora";
produto1.verificarEstoque();
Console.WriteLine($"O nome do produto é: {produto1.nome}");

ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();

classeFilha.nome = "Produto Financeiro";
classeFilha.verificarEstoque();
classeFilha.acesso();
