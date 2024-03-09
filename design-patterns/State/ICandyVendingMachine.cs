namespace design_patterns.State;

public interface ICandyVendingMachine
{
    string Message { get; }
    void InsertCoin();
    void PressButton();
}