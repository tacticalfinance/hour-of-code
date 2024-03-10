namespace design_patterns.State;

public interface ICandyVendingMachine
{
    string Message { get; set; }
    void InsertCoin();
    void PressButton();
    void SetState(ICandyVendingMachineState candyVendingMachineState);
    void Dispense();
}