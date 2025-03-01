using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using fCq6WfrEDILJ63bcvr;

namespace ReBot.Classes;

public static class Squad
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ToXml(List<ReBot.PlayerInfo> players, List<ReBot.PlayerInfo> Replacement = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = ajb1k2nt7TG3bU18v9.TYtDTyAefV(84194);
		foreach (ReBot.PlayerInfo player in players)
		{
			text = string.Concat(text, ajb1k2nt7TG3bU18v9.TYtDTyAefV(40420) + player.ID + ajb1k2nt7TG3bU18v9.TYtDTyAefV(17278) + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(player.Pos) + ajb1k2nt7TG3bU18v9.TYtDTyAefV(40448));
		}
		if (Replacement != null && Replacement.Count > 0)
		{
			foreach (ReBot.PlayerInfo item in Replacement)
			{
				text = string.Concat(text, ajb1k2nt7TG3bU18v9.TYtDTyAefV(40420) + item.ID + ajb1k2nt7TG3bU18v9.TYtDTyAefV(84212));
			}
		}
		return text + ajb1k2nt7TG3bU18v9.TYtDTyAefV(84222);
	}
}
