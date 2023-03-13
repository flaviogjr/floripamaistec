namespace ExerciciosSemana4.Classes
{
    internal class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numeroConta, int agencia, Cliente cliente) : base(numeroConta, agencia, cliente)
        {

            if (cliente.TipoPessoa != Enum.TipoPessoaEnum.FISICA)
            {
                throw new ArgumentNullException("Cliente precisa ser do tipo física");
            }
        }

        
        public override void Sacar(decimal valor)
        {
            valor += 0.10M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria numeroConta, decimal valor)
        {
            valor += 0.05M;
            base.Transferir(numeroConta, valor);
        }
    }
}
