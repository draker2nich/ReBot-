using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[ComEventInterface(typeof(DShellNameSpaceEvents), typeof(DShellNameSpaceEvents_EventProvider))]
[TypeLibType(16)]
public interface DShellNameSpaceEvents_Event
{
	event DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler FavoritesSelectionChange;

	event DShellNameSpaceEvents_SelectionChangeEventHandler SelectionChange;

	event DShellNameSpaceEvents_DoubleClickEventHandler DoubleClick;

	event DShellNameSpaceEvents_InitializedEventHandler Initialized;
}
