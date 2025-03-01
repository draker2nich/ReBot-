using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("64AB4BB7-111E-11D1-8F79-00C04FC2FBE1")]
[TypeLibType(2)]
[ClassInterface(0)]
public class ShellUIHelperClass : IShellUIHelper6, ShellUIHelper
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(64)]
	[DispId(1)]
	public virtual extern void ResetFirstBootMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	[TypeLibFunc(64)]
	public virtual extern void ResetSafeMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(3)]
	[TypeLibFunc(64)]
	public virtual extern void RefreshOfflineDesktop();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(4)]
	public virtual extern void AddFavorite([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Title);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(5)]
	public virtual extern void AddChannel([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	public virtual extern void AddDesktopComponent([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string Type, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Left, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Top, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Width, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Height);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(7)]
	public virtual extern bool IsSubscribed([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(8)]
	public virtual extern void NavigateAndFind([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string strQuery, [In][MarshalAs(UnmanagedType.Struct)] ref object varTargetFrame);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(9)]
	public virtual extern void ImportExportFavorites([In] bool fImport, [In][MarshalAs(UnmanagedType.BStr)] string strImpExpPath);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(10)]
	public virtual extern void AutoCompleteSaveForm([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Form);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(11)]
	public virtual extern void AutoScan([In][MarshalAs(UnmanagedType.BStr)] string strSearch, [In][MarshalAs(UnmanagedType.BStr)] string strFailureUrl, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarTargetFrame);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(12)]
	[TypeLibFunc(64)]
	public virtual extern void AutoCompleteAttach([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Reserved);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object ShowBrowserUI([In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarIn);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(14)]
	public virtual extern void AddSearchProvider([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(15)]
	public virtual extern void RunOnceShown();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	public virtual extern void SkipRunOnce();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(17)]
	public virtual extern void CustomizeSettings([In] bool fSQM, [In] bool fPhishing, [In][MarshalAs(UnmanagedType.BStr)] string bstrLocale);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(18)]
	public virtual extern bool SqmEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(19)]
	public virtual extern bool PhishingEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(20)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string BrandImageUri();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(21)]
	public virtual extern void SkipTabsWelcome();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	public virtual extern void DiagnoseConnection();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	public virtual extern void CustomizeClearType([In] bool fSet);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(24)]
	public virtual extern uint IsSearchProviderInstalled([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(25)]
	public virtual extern bool IsSearchMigrated();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(26)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string DefaultSearchProvider();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(27)]
	public virtual extern void RunOnceRequiredSettingsComplete([In] bool fComplete);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(28)]
	public virtual extern bool RunOnceHasShown();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(29)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string SearchGuideUrl();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	public virtual extern void AddService([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	public virtual extern uint IsServiceInstalled([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string Verb);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	public virtual extern bool InPrivateFilteringEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(32)]
	public virtual extern void AddToFavoritesBar([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string Title, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Type);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	public virtual extern void BuildNewTabPage();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	public virtual extern void SetRecentlyClosedVisible([In] bool fVisible);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	public virtual extern void SetActivitiesVisible([In] bool fVisible);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	public virtual extern void ContentDiscoveryReset();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(38)]
	public virtual extern bool IsSuggestedSitesEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(39)]
	public virtual extern void EnableSuggestedSites([In] bool fEnable);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(40)]
	public virtual extern void NavigateToSuggestedSites([In][MarshalAs(UnmanagedType.BStr)] string bstrRelativeUrl);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(41)]
	public virtual extern void ShowTabsHelp();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(42)]
	public virtual extern void ShowInPrivateHelp();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(43)]
	public virtual extern bool msIsSiteMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(47)]
	public virtual extern void msSiteModeShowThumbBar();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(48)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object msSiteModeAddThumbBarButton([In][MarshalAs(UnmanagedType.BStr)] string bstrIconURL, [In][MarshalAs(UnmanagedType.BStr)] string bstrTooltip);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(46)]
	public virtual extern void msSiteModeUpdateThumbBarButton([In][MarshalAs(UnmanagedType.Struct)] object ButtonID, [In] bool fEnabled, [In] bool fVisible);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(44)]
	public virtual extern void msSiteModeSetIconOverlay([In][MarshalAs(UnmanagedType.BStr)] string IconUrl, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarDescription);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(45)]
	public virtual extern void msSiteModeClearIconOverlay();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(49)]
	public virtual extern void msAddSiteMode();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(51)]
	public virtual extern void msSiteModeCreateJumpList([In][MarshalAs(UnmanagedType.BStr)] string bstrHeader);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(52)]
	public virtual extern void msSiteModeAddJumpListItem([In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrActionUri, [In][MarshalAs(UnmanagedType.BStr)] string bstrIconUri, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarWindowType);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(53)]
	public virtual extern void msSiteModeClearJumpList();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(56)]
	public virtual extern void msSiteModeShowJumpList();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(54)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object msSiteModeAddButtonStyle([In][MarshalAs(UnmanagedType.Struct)] object uiButtonID, [In][MarshalAs(UnmanagedType.BStr)] string bstrIconURL, [In][MarshalAs(UnmanagedType.BStr)] string bstrTooltip);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(55)]
	public virtual extern void msSiteModeShowButtonStyle([In][MarshalAs(UnmanagedType.Struct)] object uiButtonID, [In][MarshalAs(UnmanagedType.Struct)] object uiStyleID);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(58)]
	public virtual extern void msSiteModeActivate();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(59)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object msIsSiteModeFirstRun([In] bool fPreserveState);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(57)]
	public virtual extern void msAddTrackingProtectionList([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string bstrFilterName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(60)]
	public virtual extern bool msTrackingProtectionEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(61)]
	public virtual extern bool msActiveXFilteringEnabled();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(62)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object msProvisionNetworks([In][MarshalAs(UnmanagedType.BStr)] string bstrProvisioningXml);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(63)]
	public virtual extern void msReportSafeUrl();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(64)]
	public virtual extern void msSiteModeRefreshBadge();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(65)]
	public virtual extern void msSiteModeClearBadge();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(66)]
	public virtual extern void msDiagnoseConnectionUILess();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(67)]
	public virtual extern void msLaunchNetworkClientHelp();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(68)]
	public virtual extern void msChangeDefaultBrowser([In] bool fChange);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(69)]
	public virtual extern void msStopPeriodicTileUpdate();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(70)]
	public virtual extern void msStartPeriodicTileUpdate([In][MarshalAs(UnmanagedType.Struct)] object pollingUris, [Optional][In][MarshalAs(UnmanagedType.Struct)] object startTime, [Optional][In][MarshalAs(UnmanagedType.Struct)] object uiUpdateRecurrence);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(75)]
	public virtual extern void msStartPeriodicTileUpdateBatch([In][MarshalAs(UnmanagedType.Struct)] object pollingUris, [Optional][In][MarshalAs(UnmanagedType.Struct)] object startTime, [Optional][In][MarshalAs(UnmanagedType.Struct)] object uiUpdateRecurrence);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(71)]
	public virtual extern void msClearTile();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(72)]
	public virtual extern void msEnableTileNotificationQueue([In] bool fChange);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(73)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object msPinnedSiteState();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(76)]
	public virtual extern void msEnableTileNotificationQueueForSquare150x150([In] bool fChange);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(77)]
	public virtual extern void msEnableTileNotificationQueueForWide310x150([In] bool fChange);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(78)]
	public virtual extern void msEnableTileNotificationQueueForSquare310x310([In] bool fChange);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(79)]
	public virtual extern void msScheduledTileNotification([In][MarshalAs(UnmanagedType.BStr)] string bstrNotificationXml, [In][MarshalAs(UnmanagedType.BStr)] string bstrNotificationId, [In][MarshalAs(UnmanagedType.BStr)] string bstrNotificationTag, [Optional][In][MarshalAs(UnmanagedType.Struct)] object startTime, [Optional][In][MarshalAs(UnmanagedType.Struct)] object expirationTime);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(80)]
	public virtual extern void msRemoveScheduledTileNotification([In][MarshalAs(UnmanagedType.BStr)] string bstrNotificationId);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(81)]
	public virtual extern void msStartPeriodicBadgeUpdate([In][MarshalAs(UnmanagedType.BStr)] string pollingUri, [Optional][In][MarshalAs(UnmanagedType.Struct)] object startTime, [Optional][In][MarshalAs(UnmanagedType.Struct)] object uiUpdateRecurrence);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(82)]
	public virtual extern void msStopPeriodicBadgeUpdate();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(74)]
	public virtual extern void msLaunchInternetOptions();
}
