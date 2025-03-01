using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SHDocVw;

internal sealed class DWebBrowserEvents_EventProvider : DWebBrowserEvents_Event, IDisposable
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			194, 42, 178, 234, 193, 48, 207, 17, 167, 235,
			0, 0, 192, 91, 174, 11
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_BeforeNavigate(DWebBrowserEvents_BeforeNavigateEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_BeforeNavigate(DWebBrowserEvents_BeforeNavigateEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate != null && ((dWebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_NavigateComplete(DWebBrowserEvents_NavigateCompleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NavigateComplete(DWebBrowserEvents_NavigateCompleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate != null && ((dWebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_StatusTextChange(DWebBrowserEvents_StatusTextChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_StatusTextChange(DWebBrowserEvents_StatusTextChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate != null && ((dWebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_ProgressChange(DWebBrowserEvents_ProgressChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_ProgressChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_ProgressChange(DWebBrowserEvents_ProgressChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_ProgressChangeDelegate != null && ((dWebBrowserEvents_SinkHelper.m_ProgressChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_DownloadComplete(DWebBrowserEvents_DownloadCompleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_DownloadComplete(DWebBrowserEvents_DownloadCompleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate != null && ((dWebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_CommandStateChange(DWebBrowserEvents_CommandStateChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_CommandStateChange(DWebBrowserEvents_CommandStateChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate != null && ((dWebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_DownloadBegin(DWebBrowserEvents_DownloadBeginEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_DownloadBeginDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_DownloadBegin(DWebBrowserEvents_DownloadBeginEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_DownloadBeginDelegate != null && ((dWebBrowserEvents_SinkHelper.m_DownloadBeginDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_NewWindow(DWebBrowserEvents_NewWindowEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_NewWindowDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NewWindow(DWebBrowserEvents_NewWindowEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_NewWindowDelegate != null && ((dWebBrowserEvents_SinkHelper.m_NewWindowDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_TitleChange(DWebBrowserEvents_TitleChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_TitleChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_TitleChange(DWebBrowserEvents_TitleChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_TitleChangeDelegate != null && ((dWebBrowserEvents_SinkHelper.m_TitleChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_FrameBeforeNavigate(DWebBrowserEvents_FrameBeforeNavigateEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_FrameBeforeNavigate(DWebBrowserEvents_FrameBeforeNavigateEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate != null && ((dWebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_FrameNavigateComplete(DWebBrowserEvents_FrameNavigateCompleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_FrameNavigateComplete(DWebBrowserEvents_FrameNavigateCompleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate != null && ((dWebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_FrameNewWindow(DWebBrowserEvents_FrameNewWindowEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_FrameNewWindow(DWebBrowserEvents_FrameNewWindowEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate != null && ((dWebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_Quit(DWebBrowserEvents_QuitEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_QuitDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_Quit(DWebBrowserEvents_QuitEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_QuitDelegate != null && ((dWebBrowserEvents_SinkHelper.m_QuitDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_WindowMove(DWebBrowserEvents_WindowMoveEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_WindowMoveDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowMove(DWebBrowserEvents_WindowMoveEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_WindowMoveDelegate != null && ((dWebBrowserEvents_SinkHelper.m_WindowMoveDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_WindowResize(DWebBrowserEvents_WindowResizeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_WindowResizeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowResize(DWebBrowserEvents_WindowResizeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_WindowResizeDelegate != null && ((dWebBrowserEvents_SinkHelper.m_WindowResizeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_WindowActivate(DWebBrowserEvents_WindowActivateEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_WindowActivateDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowActivate(DWebBrowserEvents_WindowActivateEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_WindowActivateDelegate != null && ((dWebBrowserEvents_SinkHelper.m_WindowActivateDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_PropertyChange(DWebBrowserEvents_PropertyChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = new DWebBrowserEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents_SinkHelper, out pdwCookie);
			dWebBrowserEvents_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents_SinkHelper.m_PropertyChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_PropertyChange(DWebBrowserEvents_PropertyChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents_SinkHelper.m_PropertyChangeDelegate != null && ((dWebBrowserEvents_SinkHelper.m_PropertyChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public DWebBrowserEvents_EventProvider(object P_0)
	{
		m_ConnectionPointContainer = (IConnectionPointContainer)P_0;
	}

	public void Finalize()
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 < count)
			{
				do
				{
					DWebBrowserEvents_SinkHelper dWebBrowserEvents_SinkHelper = (DWebBrowserEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(dWebBrowserEvents_SinkHelper.m_dwCookie);
					num++;
				}
				while (num < count);
			}
			Marshal.ReleaseComObject(m_ConnectionPoint);
		}
		catch (Exception)
		{
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void Dispose()
	{
		Finalize();
		GC.SuppressFinalize(this);
	}
}
