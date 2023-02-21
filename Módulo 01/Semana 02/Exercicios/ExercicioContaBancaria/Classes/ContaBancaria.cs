namespace ExercicioContaBancaria.Classes
{
    /* TERCEIRO EXERCÍCIO */
    public class ContaBancaria
    {
        public int numero;
        public int agencia;
        public string nomeTitular;
        public decimal saldo = 0;
        public TipoContaEnum TipoConta;



        /* QUARTO EXERCÍCIO */
        public void Deposito(decimal valor)
        {
            if (valor > 0)
            {
                saldo = saldo + valor;
            }
            else
            {
                Console.WriteLine("O valor de depósito deve ser maior que R$ 0");
            }
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");

        }

        /* QUINTO EXERCÍCIO */
        public void Saque(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de saque deve ser maior que R$ 0");
            }
            else if (valor > saldo)
            {
                Console.WriteLine("O valor solicitado é maior que o saldo atual!");
            }
            else
            {
                saldo = saldo - valor;
            }
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");


        }

        /* SEXTO EXERCÍCIO */
        public void PrintSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
    }
}
