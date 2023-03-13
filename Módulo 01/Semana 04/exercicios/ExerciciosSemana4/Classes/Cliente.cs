using ExerciciosSemana4.Enum;

namespace ExerciciosSemana4.Classes
{
    internal class Cliente
    {
        public Cliente(string nome, DateTime nascimento, string profissao, EstadoCivilEnum estadoCivil, TipoPessoaEnum tipoPessoa)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;
        }

        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public EstadoCivilEnum EstadoCivil { get; private set; }
        public TipoPessoaEnum TipoPessoa { get; private set; }

    }
}
