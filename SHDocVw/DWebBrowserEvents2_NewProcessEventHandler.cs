using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_NewProcessEventHandler([In] int lCauseFlag, [In][MarshalAs(UnmanagedType.IDispatch)] object pWB2, [In][Out] ref bool Cancel);
