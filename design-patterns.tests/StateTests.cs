using design_patterns.State;
using Xunit;

namespace design_patterns.tests;

public class StateTests
{
    [Fact]
    public void TestConstructionWithoutCandies()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(0);
        Assert.Equal("No candies available", candyVendingMachine.Message);
    }

    [Fact]
    public void TestConstructionWithCandies()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(1);
        Assert.Equal("Please insert a coin", candyVendingMachine.Message);
    }

    [Fact]
    public void TestInsertCoinWhenNoCandies()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(0);
        candyVendingMachine.InsertCoin();
        Assert.Equal("No candies available", candyVendingMachine.Message);
    }

    [Fact]
    public void TestInsertCoinWhenThereAreCandies()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(1);
        candyVendingMachine.InsertCoin();
        Assert.Equal("Ready", candyVendingMachine.Message);
    }

    [Fact]
    public void TestInsertMultipleCoins()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(1);
        candyVendingMachine.InsertCoin();
        Assert.Equal("Ready", candyVendingMachine.Message);
        candyVendingMachine.InsertCoin();
        Assert.Equal("Coin already inserted", candyVendingMachine.Message);
    }


    [Fact]
    public void TestPressButtonWhenNoCandies()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(0);
        candyVendingMachine.PressButton();
        Assert.Equal("No candies available", candyVendingMachine.Message);
    }

    [Fact]
    public void TestPressButtonWhenThereAreCandiesButNoCoin()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(1);
        candyVendingMachine.PressButton();
        Assert.Equal("Please insert a coin", candyVendingMachine.Message);
    }

    [Fact]
    public void TestPressButtonWhenThereIsOneCandyAndCoin()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(1);
        candyVendingMachine.InsertCoin();
        candyVendingMachine.PressButton();
        Assert.Equal("No candies available", candyVendingMachine.Message);
    }

    [Fact]
    public void TestPressButtonWhenThereAreMoreThenOneCandyAndCoin()
    {
        ICandyVendingMachine candyVendingMachine = new CandyVendingMachine(2);
        candyVendingMachine.InsertCoin();
        candyVendingMachine.PressButton();
        Assert.Equal("Please insert a coin", candyVendingMachine.Message);
    }
}