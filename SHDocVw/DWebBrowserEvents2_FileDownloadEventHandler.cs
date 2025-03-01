using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_FileDownloadEventHandler([In] bool ActiveDocument, [In][Out] ref bool Cancel);
