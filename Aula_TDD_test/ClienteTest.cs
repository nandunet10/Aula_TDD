using Aula_TDD;

namespace Aula_TDD_test
{
    public class ClienteTest
    {
        [Fact]
        public void UsuarioMaiorDeIdade()
        {
            //Arrange
            bool expected = true;
            var cliente = new Cliente();

            cliente.Nome = "Fernando";
            cliente.Idade = 31;

            //Act
            bool actual = cliente.MaiorDeIdade();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsuarioMenorDeIdade()
        {
            //Arrange
            bool expected = false;
            var cliente = new Cliente();

            cliente.Nome = "Mariana";
            cliente.Idade = 09;

            //Act
            bool actual = cliente.MaiorDeIdade();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ListaCliente))]
        public void Os_campos_de_cliente_tem_conteudo(Cliente cliente)
        {
            //Arrange


            //Act

            //Assert
            Assert.NotEmpty(cliente.Nome);
            Assert.NotEmpty(cliente.Email);
            Assert.IsType<Cliente>(cliente);
        }

        public static IEnumerable<object[]> ListaCliente => new[]
        {
            new object[] { new Cliente { Id = 1, Nome = "Fernando", Email = "fernando.oliveira91@gmail.com", Idade = 31} },
            new object[] { new Cliente { Id = 2, Nome = "Barbara", Email = "barbara.stefanie92@gmail.com", Idade = 31} },
            new object[] { new Cliente { Id = 3, Nome = "Mariana", Email = "mariana.oliveira2013@gmail.com", Idade = 31} },
            new object[] { new Cliente { Id = 4, Nome = "Manuella", Email = "manuella.oliveira2017@gmail.com", Idade = 31} }
        };
    }
}
