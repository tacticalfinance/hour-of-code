using design_patterns.AbstractFactory.contracts;

namespace design_patterns.AbstractFactory;

public class DarkThemeFactory : IGuiFactory
{
    public IButton CreateButton() => new DarkButton();
    public ITextBox CreateTextBox() => new DarkTextBox();
}