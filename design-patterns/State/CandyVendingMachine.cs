namespace design_patterns.State;

public class CandyVendingMachine : ICandyVendingMachine
{
    private int _numberOfCandies;
    private ICandyVendingMachineState _state = null!;
    public string Message { get; set; } = null!;

    public CandyVendingMachine(int numberOfCandies)
    {
        _numberOfCandies = numberOfCandies;
        Init();
    }

    private void Init()
    {
        _state = _numberOfCandies == 0 ? new NoCandyState(this) : new NoCoinState(this);
        Message = _numberOfCandies == 0
            ? "No candies available"
            : "Please insert a coin";
    }

    public void InsertCoin()
    {
        _state.InsertCoin();
    }

    public void PressButton()
    {
        _state.PressButton();
    }

    public void SetState(ICandyVendingMachineState newState)
    {
        _state = newState;
    }

    public void Dispense()
    {
        _numberOfCandies--;
        Init();
    }
}