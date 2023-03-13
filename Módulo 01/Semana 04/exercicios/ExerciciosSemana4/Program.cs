using ExerciciosSemana4.Classes;
using ExerciciosSemana4.Enum;

Cliente clientePj = new Cliente("Carlos Alberto", DateTime.Parse("1980-12-25"), "Administrador", EstadoCivilEnum.CASADO, TipoPessoaEnum.JURIDICA);

ContaEmpresarial contaPj = new ContaEmpresarial(0011, 0001, clientePj, 10000, 10, "00111222000101");
contaPj.FazerEmprestimo(1000);
contaPj.Depositar(2000);
contaPj.ExibirSaldo();
contaPj.PagarEmprestimo();
contaPj.ExibirSaldo();


Cliente clientePf = new Cliente ("Miguel Renato", DateTime.Parse("2001-03-12"), "Estudante", EstadoCivilEnum.SOLTEIRO, TipoPessoaEnum.FISICA);

ContaCorrente contaCorrentePf = new ContaCorrente(2020, 0002, clientePf);
contaCorrentePf.Depositar(300);
contaCorrentePf.Sacar(100);
contaCorrentePf.ExibirSaldo();

ContaPoupanca contaPoupancaPf = new ContaPoupanca(2021, 0002, clientePf);
contaPoupancaPf.Depositar(200);
contaPoupancaPf.Transferir(contaCorrentePf, 120);
contaPoupancaPf.ExibirSaldo();

contaCorrentePf.ExibirSaldo();
