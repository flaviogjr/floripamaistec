using AulaConstrutores.Classes;

Pessoa pessoa1 = new Pessoa("Anacleto");

Console.WriteLine($"O nome da pessoa 1 é: { pessoa1.nome}");

Pessoa pessoa2 = new Pessoa("Trevisan", 40, 1.78f);
Console.WriteLine($"O nome da pessoa 2 é: {pessoa2.nome}, sua idade é: {pessoa2.idade} anos e sua altura é: {pessoa2.altura} metros");

Pessoa pessoa3 = new Pessoa();
Console.WriteLine($"O nome da pessoa 3 é: {pessoa3.nome}, sua idade é: {pessoa3.idade} anos e sua altura é: {pessoa3.altura} metros");
