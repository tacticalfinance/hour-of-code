using design_patterns.Builder;
using design_patterns.Builder.contracts;
using Xunit;

namespace design_patterns.tests;

public class BuilderTests
{
    [Fact]
    public void TestBuildJeep()
    {
        ICarBuilder jeepCarBuilder = new JeepCarBuilder();
        Assert.NotNull(jeepCarBuilder.Car);

        IDirector director = new Director();
        director.Builder = jeepCarBuilder;
        director.BuildCar();
        Assert.Equal($"body: Jeep\n" +
                     $"engine horsepower: 400\n" +
                     $"number of wheels: 4\n" +
                     $"wheel size: 22\"", jeepCarBuilder.Car.Specification);
    }

    [Fact]
    public void TestBuildHatchback()
    {
        ICarBuilder hatchbackCarBuilder = new HatchbackCarBuilder();
        Assert.NotNull(hatchbackCarBuilder.Car);

        IDirector director = new Director();
        director.Builder = hatchbackCarBuilder;
        director.BuildCar();
        Assert.Equal($"body: Hatchback\n" +
                     $"engine horsepower: 85\n" +
                     $"number of wheels: 4\n" +
                     $"wheel size: 16\"", hatchbackCarBuilder.Car.Specification);
    }

    [Fact]
    public void TestBuildJeepTwice()
    {
        ICarBuilder jeepCarBuilder = new JeepCarBuilder();
        IDirector director = new Director();

        director.Builder = jeepCarBuilder;
        director.BuildCar();
        Assert.Equal($"body: Jeep\n" +
                     $"engine horsepower: 400\n" +
                     $"number of wheels: 4\n" +
                     $"wheel size: 22\"", jeepCarBuilder.Car.Specification);

        director.BuildCar();
        Assert.Equal($"body: Jeep\n" +
                     $"engine horsepower: 400\n" +
                     $"number of wheels: 4\n" +
                     $"wheel size: 22\"", jeepCarBuilder.Car.Specification);
    }
}