using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents2_WebWorkerFinsihedEventHandler([In] uint dwUniqueID);
