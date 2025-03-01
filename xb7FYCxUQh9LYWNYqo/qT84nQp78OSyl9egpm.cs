using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using fCq6WfrEDILJ63bcvr;

namespace xb7FYCxUQh9LYWNYqo;

internal static class qT84nQp78OSyl9egpm
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<LinkItem> z9U9DukxA(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<LinkItem> list = new List<LinkItem>();
		foreach (Match item2 in Regex.Matches(P_0, ajb1k2nt7TG3bU18v9.TYtDTyAefV(0), RegexOptions.Singleline))
		{
			string value = item2.Groups[1].Value;
			LinkItem item = default(LinkItem);
			Match match = Regex.Match(value, ajb1k2nt7TG3bU18v9.TYtDTyAefV(34), RegexOptions.Singleline);
			if (match.Success)
			{
				item.Href = match.Groups[1].Value;
			}
			string text = Regex.Replace(value, ajb1k2nt7TG3bU18v9.TYtDTyAefV(66), "", RegexOptions.Singleline);
			item.Text = text;
			list.Add(item);
		}
		return list;
	}
}
