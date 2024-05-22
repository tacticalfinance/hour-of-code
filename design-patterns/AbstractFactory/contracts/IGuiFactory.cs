namespace design_patterns.AbstractFactory.contracts;

public interface IGuiFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}