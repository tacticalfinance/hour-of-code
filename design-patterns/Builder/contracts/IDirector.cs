namespace design_patterns.Builder.contracts;

public interface IDirector
{
    ICarBuilder Builder { set; }
    void BuildCar();
}