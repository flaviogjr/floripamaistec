namespace ExercicioModificadoresAcesso
{
    internal class ProdutoFinanceiro : Produto
    {
        public void acesso()
        {
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro();
            PF1.nome = "Produto dentro classe produto financeiro";
            PF1.cor = "Verde";
            Console.WriteLine("Nome: " + PF1.nome + "   Cor: " + PF1.cor);
            PF1.vender();
            PF1.verificarEstoque();
            PF1.alteraAtributosPrivados(99, 100.0);
        }
    }
}
