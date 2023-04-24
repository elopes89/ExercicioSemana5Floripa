using Exercicio4.Model;
using Xunit;

namespace TestesTDD;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int result = Calculadora.Soma(5,5);
        Assert.Equal(10, result);
    }
}