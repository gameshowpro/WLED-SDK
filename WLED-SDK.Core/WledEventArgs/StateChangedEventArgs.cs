using WLED_SDK.Core.Models.WledState;

namespace WLED_SDK.Core.WledEventArgs;

public class StateChangedEventArgs : EventArgs
{
    public readonly State? PreviousState;
    public readonly State? State;

    public StateChangedEventArgs(State? previousState, State? state)
    {
        PreviousState = previousState;
        State = state;
    }
}