using Tmds.MDns;

namespace WLED_SDK.Discoverer.DiscovererEventArgs;

public class DeviceLostEventArgs : EventArgs
{
    public readonly ServiceAnnouncement Announcement;

    public DeviceLostEventArgs(ServiceAnnouncement announcement)
    {
        Announcement = announcement;
    }
}