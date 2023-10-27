using Operacoes;

namespace Operacoes.xunit;

public class UnitTest1
{
    [Fact]
    public void SomarDoisNumeros()
    {
        double num1 = 1;
        double num2 = 1;
        double res = 2;

        var resultado = Operacoes.Somar(num1, num2);

        Assert.Equal(resultado, res);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(1, 2, 4)]
    [InlineData(2, 2, 4)]
    public void SomarDoisNumerosLista(double num1, double num2, double res) 
    {
        var resultado = Operacoes.Somar(num1, num2);

        Assert.Equal(res, resultado);
    }
}