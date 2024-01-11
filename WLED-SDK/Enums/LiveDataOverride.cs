using System.ComponentModel;

namespace WLED_SDK.Enums;

public enum LiveDataOverride
{
    [Description("Off")] Off = 0,
    [Description("Until live data ends")] UntilLiveDataEnds = 1,
    [Description("Until ESP reboot")] UntilEspReboot = 2
}