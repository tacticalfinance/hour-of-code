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
        IRifle rifle = new FlashlightDecorator(new Rifle());
        Assert.Equal("Rifle + Flashlight", rifle.Description);
        Assert.Equal(600.0, rifle.Price);
    }

    [Fact]
    public void TestRifleWithRedDotSight()
    {
        IRifle rifle = new RedDotSightDecorator(new Rifle());
        Assert.Equal("Rifle + Red Dot Sight", rifle.Description);
        Assert.Equal(600.0, rifle.Price);
    }

    [Fact]
    public void TestRifleWithBipods()
    {
        IRifle rifle = new BipodsDecorator(new Rifle());
        Assert.Equal("Rifle + Bipods", rifle.Description);
        Assert.Equal(620.0, rifle.Price);
    }

    [Fact]
    public void TestRifleWithRedDotSightAndBipods()
    {
        IRifle rifle = new BipodsDecorator(new RedDotSightDecorator(new Rifle()));
        Assert.Equal("Rifle + Red Dot Sight + Bipods", rifle.Description);
        Assert.Equal(720.0, rifle.Price);
    }

    [Fact]
    public void TestRifleWithRedDotSightBipodsAndFlashlight()
    {
        IRifle rifle = new FlashlightDecorator(new BipodsDecorator(new RedDotSightDecorator(new Rifle())));
        Assert.Equal("Rifle + Red Dot Sight + Bipods + Flashlight", rifle.Description);
        Assert.Equal(820.0, rifle.Price);
    }
}