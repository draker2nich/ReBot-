using System;
using System.Runtime.CompilerServices;
using fCq6WfrEDILJ63bcvr;

namespace ReBot.Classes;

public static class StringExtentions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ToInt(this string textNumber)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int result = 0;
		int.TryParse(textNumber, out result);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ToBoolean(this string value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				if (!(text == ajb1k2nt7TG3bU18v9.TYtDTyAefV(84964)))
				{
					num = 7;
					break;
				}
				return false;
			case 6:
				if (!(text == (string)tsXIoIEbgsLVnGQZwaJ(2794)))
				{
					goto default;
				}
				return true;
			default:
				alsDNYEc0XVZAnMsxVA();
				num = (In96fiESC10q53Jf4pf() ? 1 : 5);
				break;
			case 1:
			case 3:
				if (!(text == (string)tsXIoIEbgsLVnGQZwaJ(2788)))
				{
					if (!tcIwcgE7i5OsxKoD6HK(text, ajb1k2nt7TG3bU18v9.TYtDTyAefV(84950)))
					{
						goto case 4;
					}
					return false;
				}
				return false;
			case 0:
				text = (string)nNyGq7E6NZ8jsUlZr0M(value);
				num = 2;
				break;
			case 2:
				if (!(text == ajb1k2nt7TG3bU18v9.TYtDTyAefV(9558)))
				{
					if (!(text == ajb1k2nt7TG3bU18v9.TYtDTyAefV(84944)))
					{
						num = 6;
						break;
					}
					return true;
				}
				return true;
			case 7:
				return false;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetUntilOrEmpty(this string text, string stopAt = "-")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		In96fiESC10q53Jf4pf();
		int num;
		if (!alsDNYEc0XVZAnMsxVA())
		{
			num = 4;
			if (alsDNYEc0XVZAnMsxVA())
			{
			}
		}
		else
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				num2 = P0DyDMEKR33qtDseM1q(text, stopAt, StringComparison.Ordinal);
				goto default;
			default:
				if (num2 > 0)
				{
					num = 5;
					if (In96fiESC10q53Jf4pf())
					{
						break;
					}
					goto case 0;
				}
				return text;
			case 0:
			case 4:
				if (!string.IsNullOrEmpty(text))
				{
					num = 3;
					break;
				}
				return string.Empty;
			case 5:
				return text.Substring(0, num2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool In96fiESC10q53Jf4pf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool alsDNYEc0XVZAnMsxVA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nNyGq7E6NZ8jsUlZr0M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToLower();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tsXIoIEbgsLVnGQZwaJ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tcIwcgE7i5OsxKoD6HK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int P0DyDMEKR33qtDseM1q(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}
}
