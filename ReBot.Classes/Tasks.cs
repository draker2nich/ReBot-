using System.Collections.Generic;
using System.Runtime.CompilerServices;
using fCq6WfrEDILJ63bcvr;

namespace ReBot.Classes;

public static class Tasks
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ToXml(List<ReBot.PlayerInfo> players = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (players == null || players.Count == 0)
		{
			return ajb1k2nt7TG3bU18v9.TYtDTyAefV(84242);
		}
		string text = ajb1k2nt7TG3bU18v9.TYtDTyAefV(84262);
		foreach (ReBot.PlayerInfo player in players)
		{
			if (player.Task != 0)
			{
				text += string.Format(ajb1k2nt7TG3bU18v9.TYtDTyAefV(84280), player.ID, player.Task);
			}
		}
		return text + ajb1k2nt7TG3bU18v9.TYtDTyAefV(84342);
	}
}
