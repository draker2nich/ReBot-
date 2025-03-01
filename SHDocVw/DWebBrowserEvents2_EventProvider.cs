using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SHDocVw;

internal sealed class DWebBrowserEvents2_EventProvider : DWebBrowserEvents2_Event, IDisposable
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			160, 21, 167, 52, 135, 101, 208, 17, 146, 74,
			0, 32, 175, 199, 172, 77
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_NewWindow3(DWebBrowserEvents2_NewWindow3EventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_NewWindow3Delegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NewWindow3(DWebBrowserEvents2_NewWindow3EventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_NewWindow3Delegate != null && ((dWebBrowserEvents2_SinkHelper.m_NewWindow3Delegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_SetPhishingFilterStatus(DWebBrowserEvents2_SetPhishingFilterStatusEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_SetPhishingFilterStatusDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_SetPhishingFilterStatus(DWebBrowserEvents2_SetPhishingFilterStatusEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_SetPhishingFilterStatusDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_SetPhishingFilterStatusDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WindowStateChanged(DWebBrowserEvents2_WindowStateChangedEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WindowStateChangedDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowStateChanged(DWebBrowserEvents2_WindowStateChangedEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WindowStateChangedDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WindowStateChangedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_NewProcess(DWebBrowserEvents2_NewProcessEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_NewProcessDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NewProcess(DWebBrowserEvents2_NewProcessEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_NewProcessDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_NewProcessDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_ThirdPartyUrlBlocked(DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_ThirdPartyUrlBlockedDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_ThirdPartyUrlBlocked(DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_ThirdPartyUrlBlockedDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_ThirdPartyUrlBlockedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_RedirectXDomainBlocked(DWebBrowserEvents2_RedirectXDomainBlockedEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_RedirectXDomainBlockedDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_RedirectXDomainBlocked(DWebBrowserEvents2_RedirectXDomainBlockedEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_RedirectXDomainBlockedDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_RedirectXDomainBlockedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_BeforeScriptExecute(DWebBrowserEvents2_BeforeScriptExecuteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_BeforeScriptExecuteDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_BeforeScriptExecute(DWebBrowserEvents2_BeforeScriptExecuteEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_BeforeScriptExecuteDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_BeforeScriptExecuteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WebWorkerStarted(DWebBrowserEvents2_WebWorkerStartedEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WebWorkerStartedDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WebWorkerStarted(DWebBrowserEvents2_WebWorkerStartedEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WebWorkerStartedDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WebWorkerStartedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WebWorkerFinsihed(DWebBrowserEvents2_WebWorkerFinsihedEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WebWorkerFinsihedDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WebWorkerFinsihed(DWebBrowserEvents2_WebWorkerFinsihedEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WebWorkerFinsihedDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WebWorkerFinsihedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_StatusTextChange(DWebBrowserEvents2_StatusTextChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_StatusTextChange(DWebBrowserEvents2_StatusTextChangeEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_ProgressChange(DWebBrowserEvents2_ProgressChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_ProgressChange(DWebBrowserEvents2_ProgressChangeEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_CommandStateChange(DWebBrowserEvents2_CommandStateChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_CommandStateChange(DWebBrowserEvents2_CommandStateChangeEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_DownloadBegin(DWebBrowserEvents2_DownloadBeginEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_DownloadBegin(DWebBrowserEvents2_DownloadBeginEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_DownloadComplete(DWebBrowserEvents2_DownloadCompleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_DownloadComplete(DWebBrowserEvents2_DownloadCompleteEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_TitleChange(DWebBrowserEvents2_TitleChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_TitleChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_TitleChange(DWebBrowserEvents2_TitleChangeEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_TitleChangeDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_TitleChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_PropertyChange(DWebBrowserEvents2_PropertyChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_PropertyChange(DWebBrowserEvents2_PropertyChangeEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_BeforeNavigate2(DWebBrowserEvents2_BeforeNavigate2EventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_BeforeNavigate2(DWebBrowserEvents2_BeforeNavigate2EventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate != null && ((dWebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_NewWindow2(DWebBrowserEvents2_NewWindow2EventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_NewWindow2Delegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NewWindow2(DWebBrowserEvents2_NewWindow2EventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_NewWindow2Delegate != null && ((dWebBrowserEvents2_SinkHelper.m_NewWindow2Delegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_NavigateComplete2(DWebBrowserEvents2_NavigateComplete2EventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NavigateComplete2(DWebBrowserEvents2_NavigateComplete2EventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate != null && ((dWebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_DocumentComplete(DWebBrowserEvents2_DocumentCompleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_DocumentComplete(DWebBrowserEvents2_DocumentCompleteEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_OnQuit(DWebBrowserEvents2_OnQuitEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_OnQuitDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_OnQuit(DWebBrowserEvents2_OnQuitEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_OnQuitDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_OnQuitDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_OnVisible(DWebBrowserEvents2_OnVisibleEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_OnVisibleDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_OnVisible(DWebBrowserEvents2_OnVisibleEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_OnVisibleDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_OnVisibleDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_OnToolBar(DWebBrowserEvents2_OnToolBarEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_OnToolBarDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_OnToolBar(DWebBrowserEvents2_OnToolBarEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_OnToolBarDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_OnToolBarDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_OnMenuBar(DWebBrowserEvents2_OnMenuBarEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_OnMenuBar(DWebBrowserEvents2_OnMenuBarEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_OnStatusBar(DWebBrowserEvents2_OnStatusBarEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_OnStatusBar(DWebBrowserEvents2_OnStatusBarEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_OnFullScreen(DWebBrowserEvents2_OnFullScreenEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_OnFullScreen(DWebBrowserEvents2_OnFullScreenEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_OnTheaterMode(DWebBrowserEvents2_OnTheaterModeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_OnTheaterMode(DWebBrowserEvents2_OnTheaterModeEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WindowSetResizable(DWebBrowserEvents2_WindowSetResizableEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowSetResizable(DWebBrowserEvents2_WindowSetResizableEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WindowSetLeft(DWebBrowserEvents2_WindowSetLeftEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowSetLeft(DWebBrowserEvents2_WindowSetLeftEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WindowSetTop(DWebBrowserEvents2_WindowSetTopEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowSetTop(DWebBrowserEvents2_WindowSetTopEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WindowSetWidth(DWebBrowserEvents2_WindowSetWidthEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowSetWidth(DWebBrowserEvents2_WindowSetWidthEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WindowSetHeight(DWebBrowserEvents2_WindowSetHeightEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowSetHeight(DWebBrowserEvents2_WindowSetHeightEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_WindowClosing(DWebBrowserEvents2_WindowClosingEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_WindowClosingDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowClosing(DWebBrowserEvents2_WindowClosingEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_WindowClosingDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_WindowClosingDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_ClientToHostWindow(DWebBrowserEvents2_ClientToHostWindowEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_ClientToHostWindow(DWebBrowserEvents2_ClientToHostWindowEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_SetSecureLockIcon(DWebBrowserEvents2_SetSecureLockIconEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_SetSecureLockIcon(DWebBrowserEvents2_SetSecureLockIconEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_FileDownload(DWebBrowserEvents2_FileDownloadEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_FileDownloadDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_FileDownload(DWebBrowserEvents2_FileDownloadEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_FileDownloadDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_FileDownloadDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_NavigateError(DWebBrowserEvents2_NavigateErrorEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NavigateError(DWebBrowserEvents2_NavigateErrorEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_PrintTemplateInstantiation(DWebBrowserEvents2_PrintTemplateInstantiationEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_PrintTemplateInstantiation(DWebBrowserEvents2_PrintTemplateInstantiationEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_PrintTemplateTeardown(DWebBrowserEvents2_PrintTemplateTeardownEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_PrintTemplateTeardown(DWebBrowserEvents2_PrintTemplateTeardownEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_UpdatePageStatus(DWebBrowserEvents2_UpdatePageStatusEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_UpdatePageStatus(DWebBrowserEvents2_UpdatePageStatusEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public void add_PrivacyImpactedStateChange(DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = new DWebBrowserEvents2_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dWebBrowserEvents2_SinkHelper, out pdwCookie);
			dWebBrowserEvents2_SinkHelper.m_dwCookie = pdwCookie;
			dWebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dWebBrowserEvents2_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_PrivacyImpactedStateChange(DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler P_0)
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
				DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
				if (dWebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate != null && ((dWebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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

	public DWebBrowserEvents2_EventProvider(object P_0)
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
					DWebBrowserEvents2_SinkHelper dWebBrowserEvents2_SinkHelper = (DWebBrowserEvents2_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(dWebBrowserEvents2_SinkHelper.m_dwCookie);
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
