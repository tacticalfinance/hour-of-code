using design_patterns.AbstractFactory.contracts;

namespace design_patterns.AbstractFactory;

public class LightTextBox : ITextBox
{
    public void Render() => Console.WriteLine("Light TextBox");
}