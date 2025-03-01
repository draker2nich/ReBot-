using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("EAB22AC3-30C1-11CF-A7EB-0000C05BAE0B")]
[ComSourceInterfaces("SHDocVw.DWebBrowserEvents\0SHDocVw.DWebBrowserEvents2\0\0")]
[ClassInterface(0)]
[TypeLibType(34)]
public class WebBrowser_V1Class : IWebBrowser, WebBrowser_V1, DWebBrowserEvents_Event, IWebBrowser2, DWebBrowserEvents2_Event
{
	[DispId(200)]
	public virtual extern object Application
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(201)]
	public virtual extern object Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(202)]
	public virtual extern object Container
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(203)]
	public virtual extern object Document
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(204)]
	public virtual extern bool TopLevelContainer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	public virtual extern string Type
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(206)]
	public virtual extern int Left
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
	}

	[DispId(207)]
	public virtual extern int Top
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
	}

	[DispId(208)]
	public virtual extern int Width
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(208)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(208)]
		[param: In]
		set;
	}

	[DispId(209)]
	public virtual extern int Height
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(209)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(209)]
		[param: In]
		set;
	}

	[DispId(210)]
	public virtual extern string LocationName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	public virtual extern string LocationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(212)]
	public virtual extern bool Busy
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	public virtual extern object IWebBrowser2_Application
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	public virtual extern object IWebBrowser2_Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	public virtual extern object IWebBrowser2_Container
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	public virtual extern object IWebBrowser2_Document
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	public virtual extern bool IWebBrowser2_TopLevelContainer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	public virtual extern string IWebBrowser2_Type
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	public virtual extern int IWebBrowser2_Left
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern int IWebBrowser2_Top
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern int IWebBrowser2_Width
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern int IWebBrowser2_Height
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern string IWebBrowser2_LocationName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	public virtual extern string IWebBrowser2_LocationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	public virtual extern bool IWebBrowser2_Busy
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	public virtual extern string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	public virtual extern int HWND
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	public virtual extern string FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	public virtual extern string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	public virtual extern bool Visible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool StatusBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern string StatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	public virtual extern int ToolBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool MenuBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern tagREADYSTATE ReadyState
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(4)]
		get;
	}

	public virtual extern bool Offline
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool Silent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool RegisterAsBrowser
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool RegisterAsDropTarget
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool TheaterMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool AddressBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern bool Resizable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	public virtual extern event DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

	public virtual extern event DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

	public virtual extern event DWebBrowserEvents_StatusTextChangeEventHandler StatusTextChange;

	public virtual extern event DWebBrowserEvents_ProgressChangeEventHandler ProgressChange;

	public virtual extern event DWebBrowserEvents_DownloadCompleteEventHandler DownloadComplete;

	public virtual extern event DWebBrowserEvents_CommandStateChangeEventHandler CommandStateChange;

	public virtual extern event DWebBrowserEvents_DownloadBeginEventHandler DownloadBegin;

	public virtual extern event DWebBrowserEvents_NewWindowEventHandler NewWindow;

	public virtual extern event DWebBrowserEvents_TitleChangeEventHandler TitleChange;

	public virtual extern event DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

	public virtual extern event DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

	public virtual extern event DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

	public virtual extern event DWebBrowserEvents_QuitEventHandler DWebBrowserEvents_Event_Quit;

	public virtual extern event DWebBrowserEvents_WindowMoveEventHandler WindowMove;

	public virtual extern event DWebBrowserEvents_WindowResizeEventHandler WindowResize;

	public virtual extern event DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

	public virtual extern event DWebBrowserEvents_PropertyChangeEventHandler PropertyChange;

	public virtual extern event DWebBrowserEvents2_StatusTextChangeEventHandler DWebBrowserEvents2_Event_StatusTextChange;

	public virtual extern event DWebBrowserEvents2_ProgressChangeEventHandler DWebBrowserEvents2_Event_ProgressChange;

	public virtual extern event DWebBrowserEvents2_CommandStateChangeEventHandler DWebBrowserEvents2_Event_CommandStateChange;

	public virtual extern event DWebBrowserEvents2_DownloadBeginEventHandler DWebBrowserEvents2_Event_DownloadBegin;

	public virtual extern event DWebBrowserEvents2_DownloadCompleteEventHandler DWebBrowserEvents2_Event_DownloadComplete;

	public virtual extern event DWebBrowserEvents2_TitleChangeEventHandler DWebBrowserEvents2_Event_TitleChange;

	public virtual extern event DWebBrowserEvents2_PropertyChangeEventHandler DWebBrowserEvents2_Event_PropertyChange;

	public virtual extern event DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

	public virtual extern event DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

	public virtual extern event DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

	public virtual extern event DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

	public virtual extern event DWebBrowserEvents2_OnQuitEventHandler OnQuit;

	public virtual extern event DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

	public virtual extern event DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

	public virtual extern event DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

	public virtual extern event DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

	public virtual extern event DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

	public virtual extern event DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

	public virtual extern event DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

	public virtual extern event DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

	public virtual extern event DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

	public virtual extern event DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

	public virtual extern event DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

	public virtual extern event DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

	public virtual extern event DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

	public virtual extern event DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

	public virtual extern event DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

	public virtual extern event DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

	public virtual extern event DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

	public virtual extern event DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

	public virtual extern event DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

	public virtual extern event DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;

	public virtual extern event DWebBrowserEvents2_NewWindow3EventHandler NewWindow3;

	public virtual extern event DWebBrowserEvents2_SetPhishingFilterStatusEventHandler SetPhishingFilterStatus;

	public virtual extern event DWebBrowserEvents2_WindowStateChangedEventHandler WindowStateChanged;

	public virtual extern event DWebBrowserEvents2_NewProcessEventHandler NewProcess;

	public virtual extern event DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler ThirdPartyUrlBlocked;

	public virtual extern event DWebBrowserEvents2_RedirectXDomainBlockedEventHandler RedirectXDomainBlocked;

	public virtual extern event DWebBrowserEvents2_BeforeScriptExecuteEventHandler BeforeScriptExecute;

	public virtual extern event DWebBrowserEvents2_WebWorkerStartedEventHandler WebWorkerStarted;

	public virtual extern event DWebBrowserEvents2_WebWorkerFinsihedEventHandler WebWorkerFinsihed;

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(100)]
	public virtual extern void GoBack();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(101)]
	public virtual extern void GoForward();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(102)]
	public virtual extern void GoHome();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(103)]
	public virtual extern void GoSearch();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(104)]
	public virtual extern void Navigate([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(-550)]
	public virtual extern void Refresh();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(105)]
	public virtual extern void Refresh2([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Level);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(106)]
	public virtual extern void Stop();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void IWebBrowser2_GoBack();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void IWebBrowser2_GoForward();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void IWebBrowser2_GoHome();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void IWebBrowser2_GoSearch();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void IWebBrowser2_Navigate([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void IWebBrowser2_Refresh();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void IWebBrowser2_Refresh2([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Level);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void IWebBrowser2_Stop();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void Quit();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void ClientToWindow([In][Out] ref int pcx, [In][Out] ref int pcy);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void PutProperty([In][MarshalAs(UnmanagedType.BStr)] string Property, [In][MarshalAs(UnmanagedType.Struct)] object vtValue);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object GetProperty([In][MarshalAs(UnmanagedType.BStr)] string Property);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void Navigate2([In][MarshalAs(UnmanagedType.Struct)] ref object URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern OLECMDF QueryStatusWB([In] OLECMDID cmdID);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void ExecWB([In] OLECMDID cmdID, [In] OLECMDEXECOPT cmdexecopt, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvaIn, [Optional][In][Out][MarshalAs(UnmanagedType.Struct)] ref object pvaOut);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	public virtual extern void ShowBrowserBar([In][MarshalAs(UnmanagedType.Struct)] ref object pvaClsid, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarShow, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarSize);
}
