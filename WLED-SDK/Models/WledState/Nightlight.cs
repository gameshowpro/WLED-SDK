using Newtonsoft.Json;
using WLED_SDK.Enums;

namespace WLED_SDK.Models.WledState;

public class Nightlight
{
    /// <summary>
    /// On/Off state of nightlight.
    /// </summary>
    [JsonProperty("on")]
    public bool On { get; private set; }

    /// <summary>
    /// Duration of nightlight in minutes.
    /// </summary>
    [JsonProperty("dur")]
    public int Duration { get; private set; }

    /// <summary>
    /// Mode of nightlight.
    /// </summary>
    [JsonProperty("mode")]
    public NightlightMode Mode { get; private set; }

    /// <summary>
    /// Target brightness of nightlight.
    /// </summary>
    [JsonProperty("tbri")]
    public int TargetBrightness { get; private set; }

    /// <summary>
    /// Remaining nightlight duration in seconds, -1 if not active.
    /// </summary>
    [JsonProperty("rem")]
    public int RemainingTime { get; private set; }
}