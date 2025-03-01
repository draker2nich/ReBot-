using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4160)]
[Guid("A7FE6EDA-1932-4281-B881-87B31B8BC52C")]
public interface IShellUIHelper2 : IShellUIHelper
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(64)]
	[DispId(1)]
	new void ResetFirstBootMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	[TypeLibFunc(64)]
	new void ResetSafeMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(3)]
	[TypeLibFunc(64)]
	new void RefreshOfflineDesktop();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(4)]
	new void AddFavorite([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Title);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(5)]
	new void AddChannel([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	new void AddDesktopComponent([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string Type, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Left, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Top, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Width, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Height);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(7)]
	new bool IsSubscribed([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(8)]
	new void NavigateAndFind([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string strQuery, [In][MarshalAs(UnmanagedType.Struct)] ref object varTargetFrame);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(9)]
	new void ImportExportFavorites([In] bool fImport, [In][MarshalAs(UnmanagedType.BStr)] string strImpExpPath);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(10)]
	new void AutoCompleteSaveForm([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Form);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(11)]
	new void AutoScan([In][MarshalAs(UnmanagedType.BStr)] string strSearch, [In][MarshalAs(UnmanagedType.BStr)] string strFailureUrl, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarTargetFrame);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(64)]
	[DispId(12)]
	new void AutoCompleteAttach([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Reserved);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	[return: MarshalAs(UnmanagedType.Struct)]
	new object ShowBrowserUI([In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarIn);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(14)]
	void AddSearchProvider([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(15)]
	void RunOnceShown();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	void SkipRunOnce();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(17)]
	void CustomizeSettings([In] bool fSQM, [In] bool fPhishing, [In][MarshalAs(UnmanagedType.BStr)] string bstrLocale);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(18)]
	bool SqmEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(19)]
	bool PhishingEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(20)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string BrandImageUri();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(21)]
	void SkipTabsWelcome();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	void DiagnoseConnection();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	void CustomizeClearType([In] bool fSet);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(24)]
	uint IsSearchProviderInstalled([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(25)]
	bool IsSearchMigrated();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(26)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string DefaultSearchProvider();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(27)]
	void RunOnceRequiredSettingsComplete([In] bool fComplete);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(28)]
	bool RunOnceHasShown();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(29)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string SearchGuideUrl();
}
