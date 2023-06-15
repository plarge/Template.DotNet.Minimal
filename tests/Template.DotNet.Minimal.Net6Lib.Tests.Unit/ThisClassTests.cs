using NFluent;

namespace Template.DotNet.Minimal.Net6Lib.Tests.Unit;

public class ThisClassTests
{
    [Fact]
    public void DoSomething_ShouldReturnOne_WhenCalled()
    {
        // Arrange
        const int expected = 1;
        var sut = new ThisClass();

        // Act
        var result = sut.DoSomething();

        // Assert
        Check.That(result).Equals(expected);
    }
}