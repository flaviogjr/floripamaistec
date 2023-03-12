namespace AulaSobreposicao.Classes
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string Cargo { get; set; }

        public Funcionario (string nome, DateTime nascimento, Endereco endereco, decimal salario, string cargo) : base(nome, nascimento, endereco)
        {
            Salario = salario;
            Cargo = cargo;
        }

        public void ReceberAumento(decimal valor)
        {
            Salario = Salario + valor;
        }

        public override void FazerAniversario()
        {
            //Aumento de 10% de salrio no anioversário
            Salario *= 1.10M;
            base.FazerAniversario();
        }
       
    }
}
