using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("FE4106E0-399A-11D0-A48C-00A0C90A8F39")]
[TypeLibType(4096)]
[InterfaceType(2)]
public interface DShellWindowsEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(200)]
	void WindowRegistered([In] int lCookie);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(201)]
	void WindowRevoked([In] int lCookie);
}
