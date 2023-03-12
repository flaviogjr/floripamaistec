using System.Security.Cryptography.X509Certificates;

namespace AulaEncapsulamento.Classes
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

        public void DescreverProduto()
        {
            Console.WriteLine($"O nome do produto é {_nome}. O seu preço é R$ {_preco} e ele tem atualmente {_quantidade} quantidades");
        }

    }
}
