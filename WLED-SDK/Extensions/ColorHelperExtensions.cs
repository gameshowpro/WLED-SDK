using System.Drawing;

namespace WLED_SDK.Extensions;

public static class ColorHelperExtensions
{
    public static string ToHexString(this Color color, bool withHash = true) => $"{(withHash ? "#" : "")}{color.R:X2}{color.G:X2}{color.B:X2}";
    public static string ToHexString(this Color? color, bool withHash = true) => color is null ? "" : ((Color)color).ToHexString(withHash);
}