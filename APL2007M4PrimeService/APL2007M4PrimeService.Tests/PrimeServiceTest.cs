using System.Numbers;
using Xunit;

namespace APL2007M4PrimeService.Tests;
public class PrimeServiceTest
{
    private readonly PrimeService _primeService;

    public PrimeServiceTest()
    {
        _primeService = new PrimeService();
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    [InlineData(11, true)]
    [InlineData(12, false)]
    [InlineData(13, true)]
    [InlineData(14, false)]
    [InlineData(15, false)]
    [InlineData(16, false)]
    [InlineData(17, true)]
    [InlineData(18, false)]
    [InlineData(19, true)]
    [InlineData(20, false)]
    [InlineData(-1, false)] // Número negativo
    [InlineData(0, false)]  // Zero
    [InlineData(2147483647, true)] // Número grande (maior número primo de 32 bits)
    public void IsPrime_ReturnsExpectedResult(int value, bool expected)
    {
        var result = _primeService.IsPrime(value);
        Assert.Equal(expected, result);
    }
}