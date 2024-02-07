using design_patterns.Adapter;
using Xunit;

namespace design_patterns.tests;

public class AdapterTests
{
    [Fact]
    public void TestOriginalRectangle()
    {
        IOriginalRectangle rectangle = new OriginalRectangle(50, 50, 100, 50, 100, 30, 50, 30);
        Assert.Equal(50, rectangle.TopLeftX);
        Assert.Equal(50, rectangle.TopLeftY);
        Assert.Equal(100, rectangle.TopRightX);
        Assert.Equal(50, rectangle.TopRightY);
        Assert.Equal(100, rectangle.BottomRightX);
        Assert.Equal(30, rectangle.BottomRightY);
        Assert.Equal(50, rectangle.BottomLeftX);
        Assert.Equal(30, rectangle.BottomLeftY);
    }
}