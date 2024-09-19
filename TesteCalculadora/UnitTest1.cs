namespace TesteCalculadora
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5, calculadoraTeste.Calculadora.Somar(2,3));
            Assert.Equal(2, calculadoraTeste.Calculadora.Subtrair(4,2));
            Assert.Equal(6, calculadoraTeste.Calculadora.Multiplicar(2,3));
            Assert.Equal(2, calculadoraTeste.Calculadora.Dividir(4,2));
        }
    }
}