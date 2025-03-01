using System.Runtime.InteropServices;

namespace SHDocVw;

[ComEventInterface(typeof(DShellWindowsEvents), typeof(DShellWindowsEvents_EventProvider))]
[TypeLibType(16)]
[ComVisible(false)]
public interface DShellWindowsEvents_Event
{
	event DShellWindowsEvents_WindowRegisteredEventHandler WindowRegistered;

	event DShellWindowsEvents_WindowRevokedEventHandler WindowRevoked;
}
