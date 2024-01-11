using WLED_SDK.Builders;
using WLED_SDK.Extensions.StateExtensions;
using WLED_SDK.WledClients;

Console.Clear();

using var client = new WledWebsocketClient("ledstrip.local");
await client.ConnectAsync();

Console.WriteLine($"Connected to {client.Info!.Name} running WLED {client.Info.Version} ({client.Info.VersionId})");

var segmentBuilder = new SegmentBuilder(client);
segmentBuilder.AddSegment(189, 297, "Computer").Effect(80).Palette(0);
segmentBuilder.AddSegment(0, 118, "Vensterbank").Effect(27).Palette(50);
segmentBuilder.AddSegment(118, 189, "Extra").On(false);

await client.SetSegmentsAsync(segmentBuilder);
await Task.Delay(1000);

var builder = new PresetBuilder(5, "Dit is een test");
builder.QuickLoadLabel("MOOI");

await client.SavePresetAsync(builder);

await Task.Delay(-1);