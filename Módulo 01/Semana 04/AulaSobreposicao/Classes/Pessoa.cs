namespace AulaSobreposicao.Classes
{
    public class Pessoa
    {    

        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa(string nome, DateTime nascimento, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            Endereco = endereco;
        }
        public virtual void FazerAniversario()
        {
            Nascimento = Nascimento.AddYears(1);
        }
    }
}
