using WLED_SDK.Models.WledInfo;

namespace WLED_SDK.WledEventArgs;

public class InfoChangedEventArgs : EventArgs
{
    public readonly Info? PreviousInfo;
    public readonly Info? Info;

    public InfoChangedEventArgs(Info? previousInfo, Info? info)
    {
        PreviousInfo = previousInfo;
        Info = info;
    }
}