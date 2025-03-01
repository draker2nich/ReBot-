using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D")]
[TypeLibType(4112)]
[InterfaceType(2)]
public interface DWebBrowserEvents2
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(102)]
	void StatusTextChange([In][MarshalAs(UnmanagedType.BStr)] string Text);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(108)]
	void ProgressChange([In] int Progress, [In] int ProgressMax);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(105)]
	void CommandStateChange([In] int Command, [In] bool Enable);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(106)]
	void DownloadBegin();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(104)]
	void DownloadComplete();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(113)]
	void TitleChange([In][MarshalAs(UnmanagedType.BStr)] string Text);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(112)]
	void PropertyChange([In][MarshalAs(UnmanagedType.BStr)] string szProperty);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(250)]
	void BeforeNavigate2([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL, [In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [In][MarshalAs(UnmanagedType.Struct)] ref object Headers, [In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(251)]
	void NewWindow2([In][Out][MarshalAs(UnmanagedType.IDispatch)] ref object ppDisp, [In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(252)]
	void NavigateComplete2([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(259)]
	void DocumentComplete([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(253)]
	void OnQuit();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(254)]
	void OnVisible([In] bool Visible);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(255)]
	void OnToolBar([In] bool ToolBar);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(256)]
	void OnMenuBar([In] bool MenuBar);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(257)]
	void OnStatusBar([In] bool StatusBar);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(258)]
	void OnFullScreen([In] bool FullScreen);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(260)]
	void OnTheaterMode([In] bool TheaterMode);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(262)]
	void WindowSetResizable([In] bool Resizable);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(264)]
	void WindowSetLeft([In] int Left);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(265)]
	void WindowSetTop([In] int Top);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(266)]
	void WindowSetWidth([In] int Width);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(267)]
	void WindowSetHeight([In] int Height);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(263)]
	void WindowClosing([In] bool IsChildWindow, [In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(268)]
	void ClientToHostWindow([In][Out] ref int CX, [In][Out] ref int CY);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(269)]
	void SetSecureLockIcon([In] int SecureLockIcon);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(270)]
	void FileDownload([In] bool ActiveDocument, [In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(271)]
	void NavigateError([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL, [In][MarshalAs(UnmanagedType.Struct)] ref object Frame, [In][MarshalAs(UnmanagedType.Struct)] ref object StatusCode, [In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(225)]
	void PrintTemplateInstantiation([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(226)]
	void PrintTemplateTeardown([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(227)]
	void UpdatePageStatus([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object nPage, [In][MarshalAs(UnmanagedType.Struct)] ref object fDone);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(272)]
	void PrivacyImpactedStateChange([In] bool bImpacted);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(273)]
	void NewWindow3([In][Out][MarshalAs(UnmanagedType.IDispatch)] ref object ppDisp, [In][Out] ref bool Cancel, [In] uint dwFlags, [In][MarshalAs(UnmanagedType.BStr)] string bstrUrlContext, [In][MarshalAs(UnmanagedType.BStr)] string bstrUrl);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(282)]
	void SetPhishingFilterStatus([In] int PhishingFilterStatus);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(283)]
	void WindowStateChanged([In] uint dwWindowStateFlags, [In] uint dwValidFlagsMask);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(284)]
	void NewProcess([In] int lCauseFlag, [In][MarshalAs(UnmanagedType.IDispatch)] object pWB2, [In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(285)]
	void ThirdPartyUrlBlocked([In][MarshalAs(UnmanagedType.Struct)] ref object URL, [In] uint dwCount);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(286)]
	void RedirectXDomainBlocked([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object StartURL, [In][MarshalAs(UnmanagedType.Struct)] ref object RedirectURL, [In][MarshalAs(UnmanagedType.Struct)] ref object Frame, [In][MarshalAs(UnmanagedType.Struct)] ref object StatusCode);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(290)]
	void BeforeScriptExecute([In][MarshalAs(UnmanagedType.IDispatch)] object pDispWindow);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(288)]
	void WebWorkerStarted([In] uint dwUniqueID, [In][MarshalAs(UnmanagedType.BStr)] string bstrWorkerLabel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(289)]
	void WebWorkerFinsihed([In] uint dwUniqueID);
}
