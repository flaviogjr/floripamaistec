namespace AulaConstrutores.Classes
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public Pessoa()
        {
        }
    }
}
