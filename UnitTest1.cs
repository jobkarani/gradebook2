namespace GradeBook.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // arrange
        var x = 10;
        var y = 2;
        var expected = 20;

        // act
        var actual = x * y;

        // assert
        Assert.Equal(expected,actual);

    }
}