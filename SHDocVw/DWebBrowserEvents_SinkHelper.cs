using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class DWebBrowserEvents_SinkHelper : DWebBrowserEvents
{
	public DWebBrowserEvents_BeforeNavigateEventHandler m_BeforeNavigateDelegate;

	public DWebBrowserEvents_NavigateCompleteEventHandler m_NavigateCompleteDelegate;

	public DWebBrowserEvents_StatusTextChangeEventHandler m_StatusTextChangeDelegate;

	public DWebBrowserEvents_ProgressChangeEventHandler m_ProgressChangeDelegate;

	public DWebBrowserEvents_DownloadCompleteEventHandler m_DownloadCompleteDelegate;

	public DWebBrowserEvents_CommandStateChangeEventHandler m_CommandStateChangeDelegate;

	public DWebBrowserEvents_DownloadBeginEventHandler m_DownloadBeginDelegate;

	public DWebBrowserEvents_NewWindowEventHandler m_NewWindowDelegate;

	public DWebBrowserEvents_TitleChangeEventHandler m_TitleChangeDelegate;

	public DWebBrowserEvents_FrameBeforeNavigateEventHandler m_FrameBeforeNavigateDelegate;

	public DWebBrowserEvents_FrameNavigateCompleteEventHandler m_FrameNavigateCompleteDelegate;

	public DWebBrowserEvents_FrameNewWindowEventHandler m_FrameNewWindowDelegate;

	public DWebBrowserEvents_QuitEventHandler m_QuitDelegate;

	public DWebBrowserEvents_WindowMoveEventHandler m_WindowMoveDelegate;

	public DWebBrowserEvents_WindowResizeEventHandler m_WindowResizeDelegate;

	public DWebBrowserEvents_WindowActivateEventHandler m_WindowActivateDelegate;

	public DWebBrowserEvents_PropertyChangeEventHandler m_PropertyChangeDelegate;

	public int m_dwCookie;

	public void BeforeNavigate(string P_0, int P_1, string P_2, ref object P_3, string P_4, ref bool P_5)
	{
		if (m_BeforeNavigateDelegate != null)
		{
			m_BeforeNavigateDelegate(P_0, P_1, P_2, ref P_3, P_4, ref P_5);
		}
	}

	public void NavigateComplete(string P_0)
	{
		if (m_NavigateCompleteDelegate != null)
		{
			m_NavigateCompleteDelegate(P_0);
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

	public void DownloadComplete()
	{
		if (m_DownloadCompleteDelegate != null)
		{
			m_DownloadCompleteDelegate();
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

	public void NewWindow(string P_0, int P_1, string P_2, ref object P_3, string P_4, ref bool P_5)
	{
		if (m_NewWindowDelegate != null)
		{
			m_NewWindowDelegate(P_0, P_1, P_2, ref P_3, P_4, ref P_5);
		}
	}

	public void TitleChange(string P_0)
	{
		if (m_TitleChangeDelegate != null)
		{
			m_TitleChangeDelegate(P_0);
		}
	}

	public void FrameBeforeNavigate(string P_0, int P_1, string P_2, ref object P_3, string P_4, ref bool P_5)
	{
		if (m_FrameBeforeNavigateDelegate != null)
		{
			m_FrameBeforeNavigateDelegate(P_0, P_1, P_2, ref P_3, P_4, ref P_5);
		}
	}

	public void FrameNavigateComplete(string P_0)
	{
		if (m_FrameNavigateCompleteDelegate != null)
		{
			m_FrameNavigateCompleteDelegate(P_0);
		}
	}

	public void FrameNewWindow(string P_0, int P_1, string P_2, ref object P_3, string P_4, ref bool P_5)
	{
		if (m_FrameNewWindowDelegate != null)
		{
			m_FrameNewWindowDelegate(P_0, P_1, P_2, ref P_3, P_4, ref P_5);
		}
	}

	public void Quit(ref bool P_0)
	{
		if (m_QuitDelegate != null)
		{
			m_QuitDelegate(ref P_0);
		}
	}

	public void WindowMove()
	{
		if (m_WindowMoveDelegate != null)
		{
			m_WindowMoveDelegate();
		}
	}

	public void WindowResize()
	{
		if (m_WindowResizeDelegate != null)
		{
			m_WindowResizeDelegate();
		}
	}

	public void WindowActivate()
	{
		if (m_WindowActivateDelegate != null)
		{
			m_WindowActivateDelegate();
		}
	}

	public void PropertyChange(string P_0)
	{
		if (m_PropertyChangeDelegate != null)
		{
			m_PropertyChangeDelegate(P_0);
		}
	}

	internal DWebBrowserEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_BeforeNavigateDelegate = null;
		m_NavigateCompleteDelegate = null;
		m_StatusTextChangeDelegate = null;
		m_ProgressChangeDelegate = null;
		m_DownloadCompleteDelegate = null;
		m_CommandStateChangeDelegate = null;
		m_DownloadBeginDelegate = null;
		m_NewWindowDelegate = null;
		m_TitleChangeDelegate = null;
		m_FrameBeforeNavigateDelegate = null;
		m_FrameNavigateCompleteDelegate = null;
		m_FrameNewWindowDelegate = null;
		m_QuitDelegate = null;
		m_WindowMoveDelegate = null;
		m_WindowResizeDelegate = null;
		m_WindowActivateDelegate = null;
		m_PropertyChangeDelegate = null;
	}
}
