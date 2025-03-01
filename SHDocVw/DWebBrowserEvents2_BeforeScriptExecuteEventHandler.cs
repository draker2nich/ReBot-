using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents2_BeforeScriptExecuteEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDispWindow);
