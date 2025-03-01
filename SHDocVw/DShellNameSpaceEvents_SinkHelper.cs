using System.Runtime.InteropServices;

namespace SHDocVw;

[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(TypeLibTypeFlags.FHidden)]
public sealed class DShellNameSpaceEvents_SinkHelper : DShellNameSpaceEvents
{
	public DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler m_FavoritesSelectionChangeDelegate;

	public DShellNameSpaceEvents_SelectionChangeEventHandler m_SelectionChangeDelegate;

	public DShellNameSpaceEvents_DoubleClickEventHandler m_DoubleClickDelegate;

	public DShellNameSpaceEvents_InitializedEventHandler m_InitializedDelegate;

	public int m_dwCookie;

	public void FavoritesSelectionChange(int P_0, int P_1, string P_2, string P_3, int P_4, string P_5, int P_6)
	{
		if (m_FavoritesSelectionChangeDelegate != null)
		{
			m_FavoritesSelectionChangeDelegate(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		}
	}

	public void SelectionChange()
	{
		if (m_SelectionChangeDelegate != null)
		{
			m_SelectionChangeDelegate();
		}
	}

	public void DoubleClick()
	{
		if (m_DoubleClickDelegate != null)
		{
			m_DoubleClickDelegate();
		}
	}

	public void Initialized()
	{
		if (m_InitializedDelegate != null)
		{
			m_InitializedDelegate();
		}
	}

	internal DShellNameSpaceEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_FavoritesSelectionChangeDelegate = null;
		m_SelectionChangeDelegate = null;
		m_DoubleClickDelegate = null;
		m_InitializedDelegate = null;
	}
}
