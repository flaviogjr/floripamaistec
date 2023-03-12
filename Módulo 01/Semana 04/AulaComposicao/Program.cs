using AulaComposicao.Classes;

Cliente paulo = new Cliente("Paulo", DateTime.Parse("1999-01-25"), new Endereco() 
{
    Logradouro = "Sua Rua",
    Numero = "50",
    Estado = "Seu Estado", 
    Cidade = "Sua Cidade",
    Pais = "Brasil",
    CEP = "99000000"
});
