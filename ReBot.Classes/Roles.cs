using System.Collections.Generic;
using System.Runtime.CompilerServices;
using fCq6WfrEDILJ63bcvr;

namespace ReBot.Classes;

public static class Roles
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ToXml(List<ReBot.PlayerInfo> players = null, int[] cap = null, int[] left = null, int[] right = null, int[] free = null, int[] pen = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (players == null || players.Count == 0)
		{
			return ajb1k2nt7TG3bU18v9.TYtDTyAefV(84630);
		}
		string text = Ik7X9MKSRw(players, cap);
		string text2 = Ik7X9MKSRw(players, left);
		string text3 = Ik7X9MKSRw(players, right);
		string text4 = Ik7X9MKSRw(players, free);
		string text5 = Ik7X9MKSRw(players, pen);
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(84782) + text + ajb1k2nt7TG3bU18v9.TYtDTyAefV(84818) + text2 + ajb1k2nt7TG3bU18v9.TYtDTyAefV(84852) + text3 + ajb1k2nt7TG3bU18v9.TYtDTyAefV(84888) + text5 + ajb1k2nt7TG3bU18v9.TYtDTyAefV(84914) + text4 + ajb1k2nt7TG3bU18v9.TYtDTyAefV(84212);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string Ik7X9MKSRw(List<ReBot.PlayerInfo> P_0 = null, int[] P_1 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0 == null || P_0.Count == 0 || P_1 == null || P_1.Length == 0)
		{
			return "";
		}
		foreach (int num in P_1)
		{
			foreach (ReBot.PlayerInfo item in P_0)
			{
				if (num == item.Number)
				{
					return item.ID;
				}
			}
		}
		return "";
	}
}
