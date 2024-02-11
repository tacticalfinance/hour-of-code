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

    [Fact]
    public void TestPoint()
    {
        IPoint point = new Point(10, 20);
        Assert.Equal(10, point.XCor);
        Assert.Equal(20, point.YCor);
    }

    [Fact]
    public void TestTrivialSolution()
    {
        IOriginalRectangle originalRectangle = new OriginalRectangle(50, 50, 100, 50, 100, 30, 50, 30);
        INewRectangle newRectangle = new NewRectangleTrivial(
            new Point(originalRectangle.TopLeftX, originalRectangle.TopLeftY),
            originalRectangle.TopRightX - originalRectangle.TopLeftX,
            originalRectangle.TopLeftY - originalRectangle.BottomLeftY);

        Assert.Equal(50, newRectangle.TopLeftPoint.XCor);
        Assert.Equal(50, newRectangle.TopLeftPoint.YCor);
        Assert.Equal(50, newRectangle.Width);
        Assert.Equal(20, newRectangle.Height);
    }
}