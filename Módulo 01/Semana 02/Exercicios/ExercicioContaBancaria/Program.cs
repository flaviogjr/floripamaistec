


using ExercicioContaBancaria.Classes;

/* CRIAÇÃO DE CONTA */
ContaBancaria conta1 = new ContaBancaria();

conta1.numero = 2020;
conta1.agencia = 1030;
conta1.nomeTitular = "Carlos Alberto de Nóbrega";
conta1.TipoConta = TipoContaEnum.CORRENTE;


/* DEPÓSITO */
conta1.Deposito(1000);

/* SAQUE */
conta1.Saque(80);

/* MOSTRAR SALDO */
conta1.PrintSaldo();


