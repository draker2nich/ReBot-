using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using ReBot.Enums;

namespace ReBot.Classes;

public static class LanguageSettings
{
	public static Localizations CurrentLocalization;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CultureInfo Gx5XsUhRHS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CultureInfo(EnumDescriptionHelper.GetEnumDescription(CurrentLocalization));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SDxXJsRJbb(Localizations P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CurrentLocalization = P_0;
		Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)runXM1EgRKcir5pDHIl(CurrentLocalization));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EmlCn7Epyp0wgktJ3ZY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WgV74aE2VwNIgAlbHRf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object runXM1EgRKcir5pDHIl(Enum value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EnumDescriptionHelper.GetEnumDescription(value);
	}
}
