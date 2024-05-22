using design_patterns.AbstractFactory.contracts;

namespace design_patterns.AbstractFactory;

public class DarkButton : IButton
{
    public void Render() => Console.WriteLine("Dark Button");
}