using NewTalents;
using Xunit;
using System;

namespace NewTalentsTest
{
    public class UnitTest1
    {
        private Calculadora calc = new Calculadora();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int num1, int num2, int result)
        {
            int resultadoCalc = calc.Somar(num1, num2);
            
            Assert.Equal(resultadoCalc, result);
        }
        
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int num1, int num2, int result)
        {
            int resultadoCalc = calc.Multiplicar(num1, num2);

            Assert.Equal(resultadoCalc, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(25, 5, 5)]
        public void TesteDividir(int num1, int num2, int result)
        {
            int resultadoCalc = calc.Dividir(num1, num2);

            Assert.Equal(resultadoCalc, result);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(25, 5, 20)]
        public void TesteSubtrair(int num1, int num2, int result)
        {
            int resultadoCalc = calc.Subtrair(num1, num2);

            Assert.Equal(resultadoCalc, result);
        }

        [Fact]
        public void TesteDividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {

            calc.Somar(2, 2);
            calc.Subtrair(4, 2);
            calc.Somar(4, 4);
            calc.Dividir(10, 2);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}