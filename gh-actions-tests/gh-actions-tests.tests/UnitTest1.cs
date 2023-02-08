using Xunit;

namespace gh_actions_tests.tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldWork()
    {
        // Arrange
        var sut = new Calculator();
        
        // Act
        var result = sut.Add(1, 2);
        
        // Assert
        Assert.Equal(3, result);
    }
}