namespace ExercicioModificadoresAcesso
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preco;

        
        public void verificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método verificar estoque da classe produto");
        }

        protected void vender()
        {
            Console.WriteLine("Vendendo produto, acessando o método vender da classe produto");
        }

        private void descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método descartar da classe produto");
        }

        protected void alteraAtributosPrivados(double peso, double preco)
        {
            this.peso = peso;
            this.preco = preco;
            Console.WriteLine("Variável de escopo da classe (peso): " + peso);
            Console.WriteLine("Variável de escopo da classe (preço): " + preco);

        }

    }
}
