using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SHDocVw;

internal sealed class DShellWindowsEvents_EventProvider : DShellWindowsEvents_Event, IDisposable
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			224, 6, 65, 254, 154, 57, 208, 17, 164, 140,
			0, 160, 201, 10, 143, 57
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_WindowRegistered(DShellWindowsEvents_WindowRegisteredEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DShellWindowsEvents_SinkHelper dShellWindowsEvents_SinkHelper = new DShellWindowsEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dShellWindowsEvents_SinkHelper, out pdwCookie);
			dShellWindowsEvents_SinkHelper.m_dwCookie = pdwCookie;
			dShellWindowsEvents_SinkHelper.m_WindowRegisteredDelegate = P_0;
			m_aEventSinkHelpers.Add(dShellWindowsEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowRegistered(DShellWindowsEvents_WindowRegisteredEventHandler P_0)
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
				DShellWindowsEvents_SinkHelper dShellWindowsEvents_SinkHelper = (DShellWindowsEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dShellWindowsEvents_SinkHelper.m_WindowRegisteredDelegate != null && ((dShellWindowsEvents_SinkHelper.m_WindowRegisteredDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dShellWindowsEvents_SinkHelper.m_dwCookie);
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

	public void add_WindowRevoked(DShellWindowsEvents_WindowRevokedEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DShellWindowsEvents_SinkHelper dShellWindowsEvents_SinkHelper = new DShellWindowsEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dShellWindowsEvents_SinkHelper, out pdwCookie);
			dShellWindowsEvents_SinkHelper.m_dwCookie = pdwCookie;
			dShellWindowsEvents_SinkHelper.m_WindowRevokedDelegate = P_0;
			m_aEventSinkHelpers.Add(dShellWindowsEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_WindowRevoked(DShellWindowsEvents_WindowRevokedEventHandler P_0)
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
				DShellWindowsEvents_SinkHelper dShellWindowsEvents_SinkHelper = (DShellWindowsEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dShellWindowsEvents_SinkHelper.m_WindowRevokedDelegate != null && ((dShellWindowsEvents_SinkHelper.m_WindowRevokedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dShellWindowsEvents_SinkHelper.m_dwCookie);
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

	public DShellWindowsEvents_EventProvider(object P_0)
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
					DShellWindowsEvents_SinkHelper dShellWindowsEvents_SinkHelper = (DShellWindowsEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(dShellWindowsEvents_SinkHelper.m_dwCookie);
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
