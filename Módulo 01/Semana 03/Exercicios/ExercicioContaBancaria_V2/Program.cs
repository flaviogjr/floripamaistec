using ExercicioContaBancaria.Classes;

/* CRIAÇÃO DE CONTA */
ContaBancaria conta1 = new ContaBancaria("Juanito Del Toro", 555, 5050, TipoContaEnum.POUPANCA);
ContaBancaria conta2 = new ContaBancaria("Thorin OakShield", TipoContaEnum.CORRENTE);


//ContaBancaria conta2 = new ContaBancaria("Hebe Camargo", TipoContaEnum.CORRENTE);

/*conta1.numero = 2020;
conta1.agencia = 1030;
conta1.nomeTitular = "Carlos Alberto de Nóbrega";
conta1.TipoConta = TipoContaEnum.CORRENTE;*/


/* DEPÓSITO */
conta1.Deposito(1000);
conta2.Deposito(500);

/* SAQUE */
conta1.Saque(80);
conta2.Saque(10);

/* MOSTRAR SALDO */
//conta1.PrintSaldo();
//conta2.PrintSaldo();

/* TRANSFERÊNCIA */
conta1.Transferencia(conta2, 200);

/* RELATÓRIO DE CONTA */
conta1.Relatorio();
conta2.Relatorio();