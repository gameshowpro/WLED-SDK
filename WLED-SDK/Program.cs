using WLED_SDK.Extensions.StateExtensions;
using WLED_SDK.WledClients;

// Create a new WLED WebSocket client for the specified device (by IP or hostname)
//  We use the 'using' statement to ensure the client is properly disposed of when we're done
using var client = new WledWebsocketClient("[Your WLED Device IP or Hostname]");

// Connect to the WLED device
//  This will wait until the WLED device sends it's initial state (can be disabled by passing false)
await client.ConnectAsync();

Console.WriteLine($"Connected to {client.Info!.Name} running WLED {client.Info.Version} ({client.Info.VersionId})");

// Turn on the WLED device
await client.TurnOnAsync();

// Set the brightness to 50% (0-255)
await client.SetBrightnessAsync(128);

// Set an effect (e.g., Rainbow) (https://kno.wled.ge/features/effects/)
await client.SetEffectAsync(9);

// Set a palette (e.g., Default) (https://kno.wled.ge/features/palettes/)
await client.SetPaletteAsync(0);

await Task.Delay(1000);

// Stop the connection to the WLED device
await client.StopAsync();