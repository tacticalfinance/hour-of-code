namespace design_patterns.State;

public class CandyVendingMachine : ICandyVendingMachine
{
    private int _numberOfCandies;
    private CandyVendingMachineState _state;

    public CandyVendingMachine(int numberOfCandies)
    {
        _numberOfCandies = numberOfCandies;
        Init();
    }

    public string Message { get; private set; }

    public void InsertCoin()
    {
        switch (_state)
        {
            case CandyVendingMachineState.NoCandy:
                Message = "No candies available";
                break;
            case CandyVendingMachineState.NoCoin:
                _state = CandyVendingMachineState.ContainsCoin;
                Message = "Ready";
                break;
            case CandyVendingMachineState.ContainsCoin:
                Message = "Coin already inserted";
                break;
            case CandyVendingMachineState.Dispense:
                throw new NotImplementedException();
        }
    }

    public void PressButton()
    {
        switch (_state)
        {
            case CandyVendingMachineState.NoCandy:
                Message = "No candies available";
                break;
            case CandyVendingMachineState.NoCoin:
                Message = "Please insert a coin";
                break;
            case CandyVendingMachineState.ContainsCoin:
                _state = CandyVendingMachineState.Dispense;
                Message = "Dispensing";
                Dispense();
                break;
            case CandyVendingMachineState.Dispense:
                throw new NotImplementedException();
        }
    }

    private void Init()
    {
        _state = _numberOfCandies == 0 ? CandyVendingMachineState.NoCandy : CandyVendingMachineState.NoCoin;
        Message = _state == CandyVendingMachineState.NoCandy
            ? "No candies available"
            : "Please insert a coin";
    }

    private void Dispense()
    {
        _numberOfCandies--;
        Init();
    }
}