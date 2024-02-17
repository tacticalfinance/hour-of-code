using design_patterns.Strategy;
using Xunit;

namespace design_patterns.tests;

public class StrategyTests
{
    [Fact]
    public void TestNavigator()
    {
        INavigator navigator = new Navigator();
        var route = navigator.Navigate(new Coordinate(20.0, 0.0), new Coordinate(21.0, 1.0));
        Assert.Equal(2, route.Coordinates.Length);
        Assert.Equal(20.0, route.Coordinates[0].Latitude);
        Assert.Equal(0.0, route.Coordinates[0].Longitude);
        Assert.Equal(21.0, route.Coordinates[1].Latitude);
        Assert.Equal(1.0, route.Coordinates[1].Longitude);
    }
}