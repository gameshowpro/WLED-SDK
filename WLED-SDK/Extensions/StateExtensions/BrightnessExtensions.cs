using WLED_SDK.WledClients;

namespace WLED_SDK.Extensions.StateExtensions;

public static class BrightnessExtensions
{
    public static async Task SetBrightnessAsync(this IWledClient client, int brightness = 128)
        => await client.SendJsonAsync(new { bri = Math.Clamp(brightness, 0, 255) });

    public static async Task SetRandomBrightnessAsync(this IWledClient client)
        => await client.SendJsonAsync(new { bri = "r" });

    public static async Task IncreaseBrightnessAsync(this IWledClient client, int amount = 10)
        => await client.SendJsonAsync(new { bri = $"~{Math.Clamp(amount, 0, 255)}" });

    public static async Task DecreaseBrightnessAsync(this IWledClient client, int amount = 10)
        => await client.SendJsonAsync(new { bri = $"~-{Math.Clamp(amount, 0, 255)}" });
}