namespace design_patterns.Builder.contracts;

public interface ICarBuilder
{
    ICar BuildCar(string carType);
}