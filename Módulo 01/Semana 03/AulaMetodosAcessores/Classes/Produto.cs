using System.Security.Cryptography.X509Certificates;

namespace AulaMetodosAcessores.Classes
{
    public class Produto
    {
        private string _nome;
        private decimal _preco;
        private int _quantidade;



        public Produto(string nome, decimal preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Métodos acessores - GET e SET
        //GET
        public string GetNome()
        { 
            return _nome;
        }

        //SET
        public void SetNome(string nome)
        {
            if (!string.IsNullOrEmpty(nome)) //Validação para não permitir alteração por string vazia/sem valor
            {
                _nome = nome;
            }

        }
        public decimal GetPreco()
        {
            return _preco;
        }

        public void SetPreco(decimal preco)
        {
            if (preco > 0)
            {
                _preco = preco;
            }

        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            if (quantidade > 0)
            {
                _quantidade = quantidade;
            }

        }


        public void DescreverProduto()
        {
            Console.WriteLine($"O nome do produto é {_nome}. O seu preço é R$ {_preco} e ele tem atualmente {_quantidade} quantidades");
        }

    }
}
