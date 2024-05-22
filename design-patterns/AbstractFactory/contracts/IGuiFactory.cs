namespace design_patterns.AbstractFactory.contracts;

public interface IGuiFactory
{
    IButton CreateButton(string theme);
    ITextBox CreateTextBox(string theme);
}