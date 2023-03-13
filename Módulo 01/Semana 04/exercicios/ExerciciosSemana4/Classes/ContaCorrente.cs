namespace ExerciciosSemana4.Classes
{
    internal class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, int agencia, Cliente cliente) : base(numeroConta, agencia, cliente)
        {
            if (cliente.TipoPessoa != Enum.TipoPessoaEnum.FISICA)
            {
                throw new ArgumentNullException("Cliente precisa ser do tipo física");
            }

        }

        public override void Sacar(decimal valor)
        {
            valor += 0.50M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria numeroConta, decimal valor)
        {
            valor += 0.25M;
            base.Transferir(numeroConta, valor);
        }
    }
}
