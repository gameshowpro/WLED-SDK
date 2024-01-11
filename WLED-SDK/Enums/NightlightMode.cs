using System.ComponentModel;

namespace WLED_SDK.Enums;

public enum NightlightMode
{
    [Description("Instant")] Instant = 0,
    [Description("Fade")] Fade = 1,
    [Description("Color fade")] ColorFade = 2,
    [Description("Sunrise")] Sunrise = 3
}