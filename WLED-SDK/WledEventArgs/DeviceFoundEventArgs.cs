using Tmds.MDns;

namespace WLED_SDK.WledEventArgs;

public class WledDeviceFoundEventArgs : EventArgs
{
    public readonly ServiceAnnouncement Announcement;

    public WledDeviceFoundEventArgs(ServiceAnnouncement announcement)
    {
        Announcement = announcement;
    }
}