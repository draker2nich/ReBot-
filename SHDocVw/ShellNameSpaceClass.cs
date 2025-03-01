using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[ClassInterface(0)]
[ComSourceInterfaces("SHDocVw.DShellNameSpaceEvents\0\0")]
[TypeLibType(2)]
[Guid("55136805-B2DE-11D1-B9F2-00A0C98BC547")]
public class ShellNameSpaceClass : IShellNameSpace, ShellNameSpace, DShellNameSpaceEvents_Event
{
	[DispId(10)]
	public virtual extern bool SubscriptionsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(10)]
		get;
	}

	[DispId(14)]
	public virtual extern int EnumOptions
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(14)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(14)]
		[param: In]
		set;
	}

	[DispId(15)]
	public virtual extern object SelectedItem
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(15)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(15)]
		[param: In]
		[param: MarshalAs(UnmanagedType.IDispatch)]
		set;
	}

	[DispId(16)]
	public virtual extern object Root
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(17)]
	public virtual extern int Depth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		[param: In]
		set;
	}

	[DispId(18)]
	public virtual extern uint Mode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		[param: In]
		set;
	}

	[DispId(19)]
	public virtual extern uint Flags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		set;
	}

	[DispId(20)]
	public virtual extern uint TVFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		[param: In]
		set;
	}

	[DispId(21)]
	public virtual extern string Columns
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(22)]
	public virtual extern int CountViewTypes
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	public virtual extern event DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler FavoritesSelectionChange;

	public virtual extern event DShellNameSpaceEvents_SelectionChangeEventHandler SelectionChange;

	public virtual extern event DShellNameSpaceEvents_DoubleClickEventHandler DoubleClick;

	public virtual extern event DShellNameSpaceEvents_InitializedEventHandler Initialized;

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	public virtual extern void MoveSelectionUp();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	public virtual extern void MoveSelectionDown();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(3)]
	public virtual extern void ResetSort();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(4)]
	public virtual extern void NewFolder();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(5)]
	public virtual extern void Synchronize();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	public virtual extern void Import();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(7)]
	public virtual extern void Export();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(8)]
	public virtual extern void InvokeContextMenuCommand([In][MarshalAs(UnmanagedType.BStr)] string strCommand);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(9)]
	public virtual extern void MoveSelectionTo();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(11)]
	public virtual extern bool CreateSubscriptionForSelection();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(12)]
	public virtual extern bool DeleteSubscriptionForSelection();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	public virtual extern void SetRoot([In][MarshalAs(UnmanagedType.BStr)] string bstrFullPath);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	public virtual extern void SetViewType([In] int iType);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(24)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	public virtual extern object SelectedItems();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(25)]
	public virtual extern void Expand([In][MarshalAs(UnmanagedType.Struct)] object var, int iDepth);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(26)]
	public virtual extern void UnselectAll();
}
