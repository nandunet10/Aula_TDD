using Aula_TDD;

namespace Aula_TDD_test
{
    public class CalculosTest
    {
        [Fact]
        public void DividirDoisNumeros()
        {
            //Arrange
            int expectativa = 1;

            int numero1 = 2;
            int numero2 = 2;

            //Act
            int retorno = new Calculos().Dividir(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }

        [Fact]
        public void Dividir_numero_por_zero()
        {
            //Arrange
            string expectativa = "Attempted to divide by zero.";

            int numero1 = 2;
            int numero2 = 0;

            var ex = Record.Exception(() => new Calculos().Dividir(numero1, numero2));

            //Act
            if (!(ex is DivideByZeroException))
                Assert.True(false);

            //Assert
            Assert.Equal(expectativa, ex.Message);
        }

        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange
            int expectativa = 30;

            int numero1 = 10;
            int numero2 = 20;

            //Act
            int retorno = new Calculos().Somar(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }

        [Fact]
        public void SomarDoisOutrosNumeros()
        {
            //Arrange
            int expectativa = 10;

            int numero1 = 4;
            int numero2 = 6;

            //Act
            int retorno = new Calculos().Somar(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }

        [Theory]
        [InlineData(10, 40, 50)]
        [InlineData(-10, -20, -30)]
        public void SomarNumeros(int numero1, int numero2, int expectativa)
        {
            //Arrange


            //Act
            int retorno = new Calculos().Somar(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }

    }
}