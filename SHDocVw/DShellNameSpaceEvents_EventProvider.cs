using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SHDocVw;

internal sealed class DShellNameSpaceEvents_EventProvider : DShellNameSpaceEvents_Event, IDisposable
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			6, 104, 19, 85, 222, 178, 209, 17, 185, 242,
			0, 160, 201, 139, 197, 71
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_FavoritesSelectionChange(DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = new DShellNameSpaceEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dShellNameSpaceEvents_SinkHelper, out pdwCookie);
			dShellNameSpaceEvents_SinkHelper.m_dwCookie = pdwCookie;
			dShellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dShellNameSpaceEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_FavoritesSelectionChange(DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler P_0)
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dShellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate != null && ((dShellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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

	public void add_SelectionChange(DShellNameSpaceEvents_SelectionChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = new DShellNameSpaceEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dShellNameSpaceEvents_SinkHelper, out pdwCookie);
			dShellNameSpaceEvents_SinkHelper.m_dwCookie = pdwCookie;
			dShellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(dShellNameSpaceEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_SelectionChange(DShellNameSpaceEvents_SelectionChangeEventHandler P_0)
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dShellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate != null && ((dShellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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

	public void add_DoubleClick(DShellNameSpaceEvents_DoubleClickEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = new DShellNameSpaceEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dShellNameSpaceEvents_SinkHelper, out pdwCookie);
			dShellNameSpaceEvents_SinkHelper.m_dwCookie = pdwCookie;
			dShellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate = P_0;
			m_aEventSinkHelpers.Add(dShellNameSpaceEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_DoubleClick(DShellNameSpaceEvents_DoubleClickEventHandler P_0)
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dShellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate != null && ((dShellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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

	public void add_Initialized(DShellNameSpaceEvents_InitializedEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = new DShellNameSpaceEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(dShellNameSpaceEvents_SinkHelper, out pdwCookie);
			dShellNameSpaceEvents_SinkHelper.m_dwCookie = pdwCookie;
			dShellNameSpaceEvents_SinkHelper.m_InitializedDelegate = P_0;
			m_aEventSinkHelpers.Add(dShellNameSpaceEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_Initialized(DShellNameSpaceEvents_InitializedEventHandler P_0)
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
				DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (dShellNameSpaceEvents_SinkHelper.m_InitializedDelegate != null && ((dShellNameSpaceEvents_SinkHelper.m_InitializedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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

	public DShellNameSpaceEvents_EventProvider(object P_0)
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
					DShellNameSpaceEvents_SinkHelper dShellNameSpaceEvents_SinkHelper = (DShellNameSpaceEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(dShellNameSpaceEvents_SinkHelper.m_dwCookie);
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
