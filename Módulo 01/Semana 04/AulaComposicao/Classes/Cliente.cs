namespace AulaComposicao.Classes
{
    public class Cliente
    {
        
        public string Nome { get; set; }
        public DateTime Nascimento { get; set;  }
        public Endereco Endereco { get; set; }

        public Cliente(string nome, DateTime nascimento, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            Endereco = endereco;
        }
    }
}
