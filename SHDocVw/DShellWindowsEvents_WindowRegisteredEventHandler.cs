using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DShellWindowsEvents_WindowRegisteredEventHandler([In] int lCookie);
