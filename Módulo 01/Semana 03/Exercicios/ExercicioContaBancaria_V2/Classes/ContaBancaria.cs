using System;

namespace ExercicioContaBancaria.Classes
{
    /* [M1S03] Ex 3 - Alteração de visibilidade da classe ContaBancaria */
    public class ContaBancaria
    {
        private int _numero;
        private int _agencia;
        private string _nomeTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _TipoConta;

        /* [M1S02] Ex 2 - Criação de construtor da classe ContaBancaria */
        public ContaBancaria(string nomeTitular, int agencia, int numero, TipoContaEnum tipoConta) 
        {
            _nomeTitular = nomeTitular;
            _agencia = agencia;
            _numero = numero;
            _TipoConta= tipoConta;
        }

        /* [M1S03] Ex 4 - Criação de construtor secundário para a classe ContaBancaria */
        public ContaBancaria(string nomeTitular, TipoContaEnum tipoConta)
        {
            Random random = new Random();

            _nomeTitular = nomeTitular;
            _agencia = random.Next(0000, 9999);
            _numero = random.Next(0000, 9999);
            _TipoConta = tipoConta;
        }


       public void Deposito(decimal valor)
        {
            if (valor > 0)
            {
                _saldo = _saldo + valor;
            }
            else
            {
                Console.WriteLine("O valor de depósito deve ser maior que R$ 0\n");
            }
            Console.WriteLine($"O saldo atual da conta: {_numero}, do titular: {_nomeTitular} é de R$ {_saldo}\n");
        }

       public void Saque(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de saque deve ser maior que R$ 0\n");
            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor solicitado é maior que o saldo atual!\n");
            }
            else
            {
                _saldo = _saldo - valor;
            }
            Console.WriteLine($"O saldo atual da conta: {_numero}, do titular: {_nomeTitular} é de R$ {_saldo}\n");
        }

        public void PrintSaldo()
        {
            Console.WriteLine($"O saldo atual da conta: {_numero}, do titular: {_nomeTitular} é de R$ {_saldo}\n");
        }

        /* [M1S03] Ex 5 - Criação de método para fazer transferência na classe ContaBancaria */
        public void Transferencia (ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de saque deve ser maior que R$ 0\n");
            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor solicitado é maior que o saldo atual!\n");
            }
            else
            {
                _saldo = _saldo - valor;
                conta.Deposito(valor);

                Console.WriteLine($"O Valor de R$ {valor} foi transferido com sucesso\n");
            }
            Console.WriteLine($"O saldo atual da conta: {_numero}, do titular: {_nomeTitular} é de R$ {_saldo}\n");
        }

        public void Relatorio()
        {
            Console.WriteLine($"Nome do titular: {_nomeTitular}");
            Console.WriteLine($"Agência: {_agencia}");
            Console.WriteLine($"Conta: {_numero}");
            Console.WriteLine($"Tipo de conta: {_TipoConta}");
            Console.WriteLine($"O saldo atual é de R$ {_saldo}\n");
        }

    }
}
