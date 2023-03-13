namespace ExerciciosSemana4.Classes
{
    internal class ContaEmpresarial : ContaBancaria
    {
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public decimal ValorUsado { get; private set; }
        public string CNPJ { get; private set; }

        public ContaEmpresarial(int numeroConta, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string cnpj) : base(numeroConta, agencia, cliente)
        {
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            CNPJ = cnpj;

            if (cliente.TipoPessoa != Enum.TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentNullException("Cliente precisa ser do tipo jurídica.");
            }
        }

        public void FazerEmprestimo(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor solicitado precisa ser maior que R$ 0.");
                return;
            }

            if (PossuiEmprestimo)
            {
                Console.WriteLine("Cliente possui empréstimo ativo. Não é possível efetuar novo empréstimo antes da quitação da dívida atual.");
                return;
            }

            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine($"Empréstimo não autorizado - Valor superior ao limite permitido: R$  {LimiteEmprestimo}.");
                return;
            }

            PossuiEmprestimo = true;
            base.Depositar(valor);
            ValorUsado = valor;
            Console.WriteLine($"Empréstimo no valor de R$ {ValorUsado} foi autorizado e já disponível na conta.");
            Console.WriteLine("*********************************************************");

        }

        public void PagarEmprestimo()
        {
            decimal totalDevido = ValorUsado + (ValorUsado * TaxaJuros / 100);
            
            if (totalDevido > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para pagamento do empréstimo!");
                Console.WriteLine($"Valor da dívida atual: R$ {totalDevido}.");
                return;
            }

            PossuiEmprestimo = false;
            ValorUsado = 0;
            Sacar(totalDevido);
            Console.WriteLine($"\nEmpréstimo no valor de R$ {totalDevido} quitado.");
            Console.WriteLine("*********************************************************");

        }


        public override void Sacar(decimal valor)
        {
            valor += 1;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria numeroConta, decimal valor)
        {
            valor += 0.50M;
            base.Transferir(numeroConta, valor);
        }
    }
}
