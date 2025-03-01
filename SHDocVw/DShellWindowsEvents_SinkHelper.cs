using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class DShellWindowsEvents_SinkHelper : DShellWindowsEvents
{
	public DShellWindowsEvents_WindowRegisteredEventHandler m_WindowRegisteredDelegate;

	public DShellWindowsEvents_WindowRevokedEventHandler m_WindowRevokedDelegate;

	public int m_dwCookie;

	public void WindowRegistered(int P_0)
	{
		if (m_WindowRegisteredDelegate != null)
		{
			m_WindowRegisteredDelegate(P_0);
		}
	}

	public void WindowRevoked(int P_0)
	{
		if (m_WindowRevokedDelegate != null)
		{
			m_WindowRevokedDelegate(P_0);
		}
	}

	internal DShellWindowsEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_WindowRegisteredDelegate = null;
		m_WindowRevokedDelegate = null;
	}
}
