using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class DWebBrowserEvents2_SinkHelper : DWebBrowserEvents2
{
	public DWebBrowserEvents2_NewWindow3EventHandler m_NewWindow3Delegate;

	public DWebBrowserEvents2_SetPhishingFilterStatusEventHandler m_SetPhishingFilterStatusDelegate;

	public DWebBrowserEvents2_WindowStateChangedEventHandler m_WindowStateChangedDelegate;

	public DWebBrowserEvents2_NewProcessEventHandler m_NewProcessDelegate;

	public DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler m_ThirdPartyUrlBlockedDelegate;

	public DWebBrowserEvents2_RedirectXDomainBlockedEventHandler m_RedirectXDomainBlockedDelegate;

	public DWebBrowserEvents2_BeforeScriptExecuteEventHandler m_BeforeScriptExecuteDelegate;

	public DWebBrowserEvents2_WebWorkerStartedEventHandler m_WebWorkerStartedDelegate;

	public DWebBrowserEvents2_WebWorkerFinsihedEventHandler m_WebWorkerFinsihedDelegate;

	public DWebBrowserEvents2_StatusTextChangeEventHandler m_StatusTextChangeDelegate;

	public DWebBrowserEvents2_ProgressChangeEventHandler m_ProgressChangeDelegate;

	public DWebBrowserEvents2_CommandStateChangeEventHandler m_CommandStateChangeDelegate;

	public DWebBrowserEvents2_DownloadBeginEventHandler m_DownloadBeginDelegate;

	public DWebBrowserEvents2_DownloadCompleteEventHandler m_DownloadCompleteDelegate;

	public DWebBrowserEvents2_TitleChangeEventHandler m_TitleChangeDelegate;

	public DWebBrowserEvents2_PropertyChangeEventHandler m_PropertyChangeDelegate;

	public DWebBrowserEvents2_BeforeNavigate2EventHandler m_BeforeNavigate2Delegate;

	public DWebBrowserEvents2_NewWindow2EventHandler m_NewWindow2Delegate;

	public DWebBrowserEvents2_NavigateComplete2EventHandler m_NavigateComplete2Delegate;

	public DWebBrowserEvents2_DocumentCompleteEventHandler m_DocumentCompleteDelegate;

	public DWebBrowserEvents2_OnQuitEventHandler m_OnQuitDelegate;

	public DWebBrowserEvents2_OnVisibleEventHandler m_OnVisibleDelegate;

	public DWebBrowserEvents2_OnToolBarEventHandler m_OnToolBarDelegate;

	public DWebBrowserEvents2_OnMenuBarEventHandler m_OnMenuBarDelegate;

	public DWebBrowserEvents2_OnStatusBarEventHandler m_OnStatusBarDelegate;

	public DWebBrowserEvents2_OnFullScreenEventHandler m_OnFullScreenDelegate;

	public DWebBrowserEvents2_OnTheaterModeEventHandler m_OnTheaterModeDelegate;

	public DWebBrowserEvents2_WindowSetResizableEventHandler m_WindowSetResizableDelegate;

	public DWebBrowserEvents2_WindowSetLeftEventHandler m_WindowSetLeftDelegate;

	public DWebBrowserEvents2_WindowSetTopEventHandler m_WindowSetTopDelegate;

	public DWebBrowserEvents2_WindowSetWidthEventHandler m_WindowSetWidthDelegate;

	public DWebBrowserEvents2_WindowSetHeightEventHandler m_WindowSetHeightDelegate;

	public DWebBrowserEvents2_WindowClosingEventHandler m_WindowClosingDelegate;

	public DWebBrowserEvents2_ClientToHostWindowEventHandler m_ClientToHostWindowDelegate;

	public DWebBrowserEvents2_SetSecureLockIconEventHandler m_SetSecureLockIconDelegate;

	public DWebBrowserEvents2_FileDownloadEventHandler m_FileDownloadDelegate;

	public DWebBrowserEvents2_NavigateErrorEventHandler m_NavigateErrorDelegate;

	public DWebBrowserEvents2_PrintTemplateInstantiationEventHandler m_PrintTemplateInstantiationDelegate;

	public DWebBrowserEvents2_PrintTemplateTeardownEventHandler m_PrintTemplateTeardownDelegate;

	public DWebBrowserEvents2_UpdatePageStatusEventHandler m_UpdatePageStatusDelegate;

	public DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler m_PrivacyImpactedStateChangeDelegate;

	public int m_dwCookie;

	public void NewWindow3(ref object P_0, ref bool P_1, uint P_2, string P_3, string P_4)
	{
		if (m_NewWindow3Delegate != null)
		{
			m_NewWindow3Delegate(ref P_0, ref P_1, P_2, P_3, P_4);
		}
	}

	public void SetPhishingFilterStatus(int P_0)
	{
		if (m_SetPhishingFilterStatusDelegate != null)
		{
			m_SetPhishingFilterStatusDelegate(P_0);
		}
	}

	public void WindowStateChanged(uint P_0, uint P_1)
	{
		if (m_WindowStateChangedDelegate != null)
		{
			m_WindowStateChangedDelegate(P_0, P_1);
		}
	}

	public void NewProcess(int P_0, object P_1, ref bool P_2)
	{
		if (m_NewProcessDelegate != null)
		{
			m_NewProcessDelegate(P_0, P_1, ref P_2);
		}
	}

	public void ThirdPartyUrlBlocked(ref object P_0, uint P_1)
	{
		if (m_ThirdPartyUrlBlockedDelegate != null)
		{
			m_ThirdPartyUrlBlockedDelegate(ref P_0, P_1);
		}
	}

	public void RedirectXDomainBlocked(object P_0, ref object P_1, ref object P_2, ref object P_3, ref object P_4)
	{
		if (m_RedirectXDomainBlockedDelegate != null)
		{
			m_RedirectXDomainBlockedDelegate(P_0, ref P_1, ref P_2, ref P_3, ref P_4);
		}
	}

	public void BeforeScriptExecute(object P_0)
	{
		if (m_BeforeScriptExecuteDelegate != null)
		{
			m_BeforeScriptExecuteDelegate(P_0);
		}
	}

	public void WebWorkerStarted(uint P_0, string P_1)
	{
		if (m_WebWorkerStartedDelegate != null)
		{
			m_WebWorkerStartedDelegate(P_0, P_1);
		}
	}

	public void WebWorkerFinsihed(uint P_0)
	{
		if (m_WebWorkerFinsihedDelegate != null)
		{
			m_WebWorkerFinsihedDelegate(P_0);
		}
	}

	public void StatusTextChange(string P_0)
	{
		if (m_StatusTextChangeDelegate != null)
		{
			m_StatusTextChangeDelegate(P_0);
		}
	}

	public void ProgressChange(int P_0, int P_1)
	{
		if (m_ProgressChangeDelegate != null)
		{
			m_ProgressChangeDelegate(P_0, P_1);
		}
	}

	public void CommandStateChange(int P_0, bool P_1)
	{
		if (m_CommandStateChangeDelegate != null)
		{
			m_CommandStateChangeDelegate(P_0, P_1);
		}
	}

	public void DownloadBegin()
	{
		if (m_DownloadBeginDelegate != null)
		{
			m_DownloadBeginDelegate();
		}
	}

	public void DownloadComplete()
	{
		if (m_DownloadCompleteDelegate != null)
		{
			m_DownloadCompleteDelegate();
		}
	}

	public void TitleChange(string P_0)
	{
		if (m_TitleChangeDelegate != null)
		{
			m_TitleChangeDelegate(P_0);
		}
	}

	public void PropertyChange(string P_0)
	{
		if (m_PropertyChangeDelegate != null)
		{
			m_PropertyChangeDelegate(P_0);
		}
	}

	public void BeforeNavigate2(object P_0, ref object P_1, ref object P_2, ref object P_3, ref object P_4, ref object P_5, ref bool P_6)
	{
		if (m_BeforeNavigate2Delegate != null)
		{
			m_BeforeNavigate2Delegate(P_0, ref P_1, ref P_2, ref P_3, ref P_4, ref P_5, ref P_6);
		}
	}

	public void NewWindow2(ref object P_0, ref bool P_1)
	{
		if (m_NewWindow2Delegate != null)
		{
			m_NewWindow2Delegate(ref P_0, ref P_1);
		}
	}

	public void NavigateComplete2(object P_0, ref object P_1)
	{
		if (m_NavigateComplete2Delegate != null)
		{
			m_NavigateComplete2Delegate(P_0, ref P_1);
		}
	}

	public void DocumentComplete(object P_0, ref object P_1)
	{
		if (m_DocumentCompleteDelegate != null)
		{
			m_DocumentCompleteDelegate(P_0, ref P_1);
		}
	}

	public void OnQuit()
	{
		if (m_OnQuitDelegate != null)
		{
			m_OnQuitDelegate();
		}
	}

	public void OnVisible(bool P_0)
	{
		if (m_OnVisibleDelegate != null)
		{
			m_OnVisibleDelegate(P_0);
		}
	}

	public void OnToolBar(bool P_0)
	{
		if (m_OnToolBarDelegate != null)
		{
			m_OnToolBarDelegate(P_0);
		}
	}

	public void OnMenuBar(bool P_0)
	{
		if (m_OnMenuBarDelegate != null)
		{
			m_OnMenuBarDelegate(P_0);
		}
	}

	public void OnStatusBar(bool P_0)
	{
		if (m_OnStatusBarDelegate != null)
		{
			m_OnStatusBarDelegate(P_0);
		}
	}

	public void OnFullScreen(bool P_0)
	{
		if (m_OnFullScreenDelegate != null)
		{
			m_OnFullScreenDelegate(P_0);
		}
	}

	public void OnTheaterMode(bool P_0)
	{
		if (m_OnTheaterModeDelegate != null)
		{
			m_OnTheaterModeDelegate(P_0);
		}
	}

	public void WindowSetResizable(bool P_0)
	{
		if (m_WindowSetResizableDelegate != null)
		{
			m_WindowSetResizableDelegate(P_0);
		}
	}

	public void WindowSetLeft(int P_0)
	{
		if (m_WindowSetLeftDelegate != null)
		{
			m_WindowSetLeftDelegate(P_0);
		}
	}

	public void WindowSetTop(int P_0)
	{
		if (m_WindowSetTopDelegate != null)
		{
			m_WindowSetTopDelegate(P_0);
		}
	}

	public void WindowSetWidth(int P_0)
	{
		if (m_WindowSetWidthDelegate != null)
		{
			m_WindowSetWidthDelegate(P_0);
		}
	}

	public void WindowSetHeight(int P_0)
	{
		if (m_WindowSetHeightDelegate != null)
		{
			m_WindowSetHeightDelegate(P_0);
		}
	}

	public void WindowClosing(bool P_0, ref bool P_1)
	{
		if (m_WindowClosingDelegate != null)
		{
			m_WindowClosingDelegate(P_0, ref P_1);
		}
	}

	public void ClientToHostWindow(ref int P_0, ref int P_1)
	{
		if (m_ClientToHostWindowDelegate != null)
		{
			m_ClientToHostWindowDelegate(ref P_0, ref P_1);
		}
	}

	public void SetSecureLockIcon(int P_0)
	{
		if (m_SetSecureLockIconDelegate != null)
		{
			m_SetSecureLockIconDelegate(P_0);
		}
	}

	public void FileDownload(bool P_0, ref bool P_1)
	{
		if (m_FileDownloadDelegate != null)
		{
			m_FileDownloadDelegate(P_0, ref P_1);
		}
	}

	public void NavigateError(object P_0, ref object P_1, ref object P_2, ref object P_3, ref bool P_4)
	{
		if (m_NavigateErrorDelegate != null)
		{
			m_NavigateErrorDelegate(P_0, ref P_1, ref P_2, ref P_3, ref P_4);
		}
	}

	public void PrintTemplateInstantiation(object P_0)
	{
		if (m_PrintTemplateInstantiationDelegate != null)
		{
			m_PrintTemplateInstantiationDelegate(P_0);
		}
	}

	public void PrintTemplateTeardown(object P_0)
	{
		if (m_PrintTemplateTeardownDelegate != null)
		{
			m_PrintTemplateTeardownDelegate(P_0);
		}
	}

	public void UpdatePageStatus(object P_0, ref object P_1, ref object P_2)
	{
		if (m_UpdatePageStatusDelegate != null)
		{
			m_UpdatePageStatusDelegate(P_0, ref P_1, ref P_2);
		}
	}

	public void PrivacyImpactedStateChange(bool P_0)
	{
		if (m_PrivacyImpactedStateChangeDelegate != null)
		{
			m_PrivacyImpactedStateChangeDelegate(P_0);
		}
	}

	internal DWebBrowserEvents2_SinkHelper()
	{
		m_dwCookie = 0;
		m_NewWindow3Delegate = null;
		m_SetPhishingFilterStatusDelegate = null;
		m_WindowStateChangedDelegate = null;
		m_NewProcessDelegate = null;
		m_ThirdPartyUrlBlockedDelegate = null;
		m_RedirectXDomainBlockedDelegate = null;
		m_BeforeScriptExecuteDelegate = null;
		m_WebWorkerStartedDelegate = null;
		m_WebWorkerFinsihedDelegate = null;
		m_StatusTextChangeDelegate = null;
		m_ProgressChangeDelegate = null;
		m_CommandStateChangeDelegate = null;
		m_DownloadBeginDelegate = null;
		m_DownloadCompleteDelegate = null;
		m_TitleChangeDelegate = null;
		m_PropertyChangeDelegate = null;
		m_BeforeNavigate2Delegate = null;
		m_NewWindow2Delegate = null;
		m_NavigateComplete2Delegate = null;
		m_DocumentCompleteDelegate = null;
		m_OnQuitDelegate = null;
		m_OnVisibleDelegate = null;
		m_OnToolBarDelegate = null;
		m_OnMenuBarDelegate = null;
		m_OnStatusBarDelegate = null;
		m_OnFullScreenDelegate = null;
		m_OnTheaterModeDelegate = null;
		m_WindowSetResizableDelegate = null;
		m_WindowSetLeftDelegate = null;
		m_WindowSetTopDelegate = null;
		m_WindowSetWidthDelegate = null;
		m_WindowSetHeightDelegate = null;
		m_WindowClosingDelegate = null;
		m_ClientToHostWindowDelegate = null;
		m_SetSecureLockIconDelegate = null;
		m_FileDownloadDelegate = null;
		m_NavigateErrorDelegate = null;
		m_PrintTemplateInstantiationDelegate = null;
		m_PrintTemplateTeardownDelegate = null;
		m_UpdatePageStatusDelegate = null;
		m_PrivacyImpactedStateChangeDelegate = null;
	}
}
