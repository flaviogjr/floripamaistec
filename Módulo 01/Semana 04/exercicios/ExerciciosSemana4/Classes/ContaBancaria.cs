namespace ExerciciosSemana4.Classes
{
    internal class ContaBancaria
    {
        public ContaBancaria(int numeroConta, int agencia, Cliente cliente)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            Cliente = cliente;
        }

        public int NumeroConta { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; }


        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de saque deve ser maior que R$ 0\n");
                return;
            }

            if (valor > Saldo)
            {
                Console.WriteLine("O valor solicitado é maior que o saldo atual!\n");
                return;
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"\nEfetuado Saque de R$ {valor} na conta: {NumeroConta}, do titular: {Cliente.Nome}");
                Console.WriteLine("*********************************************************");
            }

        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
                Console.WriteLine($"\nEfetuado depósito de R$ {valor} na conta: {NumeroConta}, do titular: {Cliente.Nome}");
                Console.WriteLine("*********************************************************");
            }
            else
            {
                Console.WriteLine("O valor de depósito deve ser maior que R$ 0\n");
            }
            
        }

        public virtual void Transferir(ContaBancaria numeroConta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de saque deve ser maior que R$ 0\n");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor solicitado é maior que o saldo atual!\n");
            }
            else
            {
                Saldo = Saldo - valor;
                numeroConta.Depositar(valor);

                Console.WriteLine($"O Valor de R$ {valor} foi transferido com sucesso\n");
                Console.WriteLine("*********************************************************");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"\nO saldo atual da conta: {NumeroConta}, do titular: {Cliente.Nome} é de R$ {Saldo}");
            Console.WriteLine("*********************************************************");
        }

    }
}
