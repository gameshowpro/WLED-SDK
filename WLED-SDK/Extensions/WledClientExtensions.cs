using WLED_SDK.Models.WledInfo;
using WLED_SDK.Models.WledState;
using WLED_SDK.WledClients;

namespace WLED_SDK.Extensions;

public static class WledClientExtensions
{
    public static State GetStateOrThrow(this IWledClient client)
        => client.State ?? throw new InvalidOperationException("Client is not connected or the state has not been received yet.");

    public static Info GetInfoOrThrow(this IWledClient client)
        => client.Info ?? throw new InvalidOperationException("Client is not connected or the info has not been received yet.");
}