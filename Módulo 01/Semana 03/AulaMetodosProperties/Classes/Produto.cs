using System.Security.Cryptography.X509Certificates;

namespace AulaProperties.Classes
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

        public string Nome
        {
            get => _nome;  //Primeira forma de sintaxe - Arrow function - equivale a { return _nome;}
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value; //Segunda forma de sintaxe
                } 
            }
        }

        //Métodos acessores - GET e SET
        //GET
       
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

        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        //public void SetQuantidade(int quantidade)
        //{
        //    if (quantidade > 0)
        //    {
        //        _quantidade = quantidade;
        //    }

        //}

        //Auto properties
        public int Quantidade { get; set; }


        public void DescreverProduto()
        {
            Console.WriteLine($"O nome do produto é {_nome}. O seu preço é R$ {_preco} e ele tem atualmente {_quantidade} quantidades");
        }

    }
}
