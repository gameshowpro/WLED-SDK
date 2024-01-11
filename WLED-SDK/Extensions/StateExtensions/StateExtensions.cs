using WLED_SDK.WledClients;

namespace WLED_SDK.Extensions.StateExtensions;

public static class StateExtensions
{
    public static async Task TurnOnAsync(this IWledClient client)
        => await client.SendJsonAsync(new { on = true });

    public static async Task TurnOffAsync(this IWledClient client)
        => await client.SendJsonAsync(new { on = false });

    public static async Task ToggleOnOffAsync(this IWledClient client)
        => await client.SendJsonAsync(new { on = "t" });
}