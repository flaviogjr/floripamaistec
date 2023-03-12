namespace AulaSobreposicao.Classes
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public int Semestre { get; set; }

        public Aluno(string nome, DateTime nascimento, Endereco endereco, string curso, int semestre) : base(nome, nascimento, endereco)
        {
            Curso = curso;
            Semestre = semestre;
        }

    }
}
