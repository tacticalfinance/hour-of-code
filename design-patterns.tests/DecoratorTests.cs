using design_patterns.Decorator;
using design_patterns.Decorator.contracts;
using Xunit;

namespace design_patterns.tests;

public class DecoratorTests
{
    [Fact]
    public void TestRifle()
    {
        IRifle rifle = new Rifle();
        Assert.Equal("Rifle", rifle.Description);
        Assert.Equal(500.0, rifle.Price);
    }

    [Fact]
    public void TestRifleWithFlashlight()
    {
        IRifle rifle = new RifleWithFlashlight();
        Assert.Equal("Rifle + Flashlight", rifle.Description);
        Assert.Equal(600.0, rifle.Price);
    }

    [Fact]
    public void TestRifleWithRedDotSight()
    {
        IRifle rifle = new RifleWithRedDotSight();
        Assert.Equal("Rifle + Red Dot Sight", rifle.Description);
        Assert.Equal(600.0, rifle.Price);
    }

    [Fact]
    public void TestRifleWithBipods()
    {
        IRifle rifle = new RifleWithBipods();
        Assert.Equal("Rifle + Bipods", rifle.Description);
        Assert.Equal(620.0, rifle.Price);
    }

    [Fact]
    public void TestRifleWithRedDotSightAndBipods()
    {
        IRifle rifle = new TestRifleWithRedDotSightAndBipods();
        Assert.Equal("Rifle + Red Dot Sight + Bipods", rifle.Description);
        Assert.Equal(720.0, rifle.Price);
    }
}