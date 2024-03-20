using design_patterns.Builder;
using design_patterns.Builder.contracts;
using Xunit;

namespace design_patterns.tests;

public class BuilderTests
{
    [Fact]
    public void TestBuildJeep()
    {
        ICarBuilder carBuilder = new CarBuilder();
        ICar jeep = carBuilder.BuildCar("Jeep");
        Assert.Equal($"body: Jeep\n" +
                     $"engine horsepower: 400\n" +
                     $"number of wheels: 4\n" +
                     $"wheel size: 22\"", jeep.Specification);
    }

    [Fact]
    public void TestBuildHatchback()
    {
        ICarBuilder carBuilder = new CarBuilder();
        ICar hatchback = carBuilder.BuildCar("Hatchback");
        Assert.Equal($"body: Hatchback\n" +
                     $"engine horsepower: 85\n" +
                     $"number of wheels: 4\n" +
                     $"wheel size: 16\"", hatchback.Specification);
    }
}