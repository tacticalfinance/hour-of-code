using design_patterns.Strategy;
using Xunit;

namespace design_patterns.tests;

public class StrategyTests
{
    [Fact]
    public void TestNavigator()
    {
        INavigator navigator = new Navigator();

        var route = navigator.Navigate(NavigationType.Flying, new Coordinate(20.0, 0.0), new Coordinate(21.0, 1.0));
        Assert.Equal(NavigationType.Flying, route.NavigationType);
        Assert.Equal(2, route.Coordinates.Length);
        Assert.Equal(20.0, route.Coordinates[0].Latitude);
        Assert.Equal(0.0, route.Coordinates[0].Longitude);
        Assert.Equal(21.0, route.Coordinates[1].Latitude);
        Assert.Equal(1.0, route.Coordinates[1].Longitude);

        route = navigator.Navigate(NavigationType.Driving, new Coordinate(20.0, 0.0), new Coordinate(21.0, 1.0));
        Assert.Equal(NavigationType.Driving, route.NavigationType);
        Assert.Equal(3, route.Coordinates.Length);
        Assert.Equal(20.0, route.Coordinates[0].Latitude);
        Assert.Equal(0.0, route.Coordinates[0].Longitude);
        Assert.Equal(20.5, route.Coordinates[1].Latitude);
        Assert.Equal(0.5, route.Coordinates[1].Longitude);
        Assert.Equal(21.0, route.Coordinates[2].Latitude);
        Assert.Equal(1.0, route.Coordinates[2].Longitude);

        route = navigator.Navigate(NavigationType.Cycling, new Coordinate(20.0, 0.0), new Coordinate(21.0, 1.0));
        Assert.Equal(NavigationType.Cycling, route.NavigationType);
        Assert.Equal(5, route.Coordinates.Length);
        Assert.Equal(20.0, route.Coordinates[0].Latitude);
        Assert.Equal(0.0, route.Coordinates[0].Longitude);
        Assert.Equal(20.25, route.Coordinates[1].Latitude);
        Assert.Equal(0.25, route.Coordinates[1].Longitude);
        Assert.Equal(20.5, route.Coordinates[2].Latitude);
        Assert.Equal(0.5, route.Coordinates[2].Longitude);
        Assert.Equal(20.75, route.Coordinates[3].Latitude);
        Assert.Equal(0.75, route.Coordinates[3].Longitude);
        Assert.Equal(21.0, route.Coordinates[4].Latitude);
        Assert.Equal(1.0, route.Coordinates[4].Longitude);
    }
}