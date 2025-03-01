using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("A2A08B09-103D-4D3F-B91C-EA455CA82EFA")]
[TypeLibType(4160)]
public interface IShellUIHelper5 : IShellUIHelper4
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	[TypeLibFunc(64)]
	new void ResetFirstBootMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(64)]
	[DispId(2)]
	new void ResetSafeMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(64)]
	[DispId(3)]
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
	new void AddSearchProvider([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(15)]
	new void RunOnceShown();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	new void SkipRunOnce();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(17)]
	new void CustomizeSettings([In] bool fSQM, [In] bool fPhishing, [In][MarshalAs(UnmanagedType.BStr)] string bstrLocale);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(18)]
	new bool SqmEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(19)]
	new bool PhishingEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(20)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string BrandImageUri();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(21)]
	new void SkipTabsWelcome();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	new void DiagnoseConnection();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	new void CustomizeClearType([In] bool fSet);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(24)]
	new uint IsSearchProviderInstalled([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(25)]
	new bool IsSearchMigrated();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(26)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string DefaultSearchProvider();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(27)]
	new void RunOnceRequiredSettingsComplete([In] bool fComplete);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(28)]
	new bool RunOnceHasShown();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(29)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string SearchGuideUrl();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void AddService([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new uint IsServiceInstalled([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string Verb);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	new bool InPrivateFilteringEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(32)]
	new void AddToFavoritesBar([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string Title, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Type);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void BuildNewTabPage();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SetRecentlyClosedVisible([In] bool fVisible);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetActivitiesVisible([In] bool fVisible);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new void ContentDiscoveryReset();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(38)]
	new bool IsSuggestedSitesEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(39)]
	new void EnableSuggestedSites([In] bool fEnable);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(40)]
	new void NavigateToSuggestedSites([In][MarshalAs(UnmanagedType.BStr)] string bstrRelativeUrl);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(41)]
	new void ShowTabsHelp();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(42)]
	new void ShowInPrivateHelp();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(43)]
	new bool msIsSiteMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(47)]
	new void msSiteModeShowThumbBar();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(48)]
	[return: MarshalAs(UnmanagedType.Struct)]
	new object msSiteModeAddThumbBarButton([In][MarshalAs(UnmanagedType.BStr)] string bstrIconURL, [In][MarshalAs(UnmanagedType.BStr)] string bstrTooltip);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(46)]
	new void msSiteModeUpdateThumbBarButton([In][MarshalAs(UnmanagedType.Struct)] object ButtonID, [In] bool fEnabled, [In] bool fVisible);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(44)]
	new void msSiteModeSetIconOverlay([In][MarshalAs(UnmanagedType.BStr)] string IconUrl, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarDescription);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(45)]
	new void msSiteModeClearIconOverlay();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(49)]
	new void msAddSiteMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(51)]
	new void msSiteModeCreateJumpList([In][MarshalAs(UnmanagedType.BStr)] string bstrHeader);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(52)]
	new void msSiteModeAddJumpListItem([In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrActionUri, [In][MarshalAs(UnmanagedType.BStr)] string bstrIconUri, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarWindowType);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(53)]
	new void msSiteModeClearJumpList();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(56)]
	new void msSiteModeShowJumpList();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(54)]
	[return: MarshalAs(UnmanagedType.Struct)]
	new object msSiteModeAddButtonStyle([In][MarshalAs(UnmanagedType.Struct)] object uiButtonID, [In][MarshalAs(UnmanagedType.BStr)] string bstrIconURL, [In][MarshalAs(UnmanagedType.BStr)] string bstrTooltip);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(55)]
	new void msSiteModeShowButtonStyle([In][MarshalAs(UnmanagedType.Struct)] object uiButtonID, [In][MarshalAs(UnmanagedType.Struct)] object uiStyleID);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(58)]
	new void msSiteModeActivate();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(59)]
	[return: MarshalAs(UnmanagedType.Struct)]
	new object msIsSiteModeFirstRun([In] bool fPreserveState);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(57)]
	new void msAddTrackingProtectionList([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string bstrFilterName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(60)]
	new bool msTrackingProtectionEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(61)]
	new bool msActiveXFilteringEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(62)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object msProvisionNetworks([In][MarshalAs(UnmanagedType.BStr)] string bstrProvisioningXml);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(63)]
	void msReportSafeUrl();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(64)]
	void msSiteModeRefreshBadge();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(65)]
	void msSiteModeClearBadge();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(66)]
	void msDiagnoseConnectionUILess();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(67)]
	void msLaunchNetworkClientHelp();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(68)]
	void msChangeDefaultBrowser([In] bool fChange);
}
