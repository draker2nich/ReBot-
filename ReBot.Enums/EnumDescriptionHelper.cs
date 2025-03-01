using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CUB0kCL30YeF2Gt7jr;

namespace ReBot.Enums;

public static class EnumDescriptionHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEnumDescription(Enum value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gvRK9hEdwW54KIYregs())
		{
			num = 2;
			if (qeAd9rEIAxl8yxy6bjM())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0042;
		IL_006b:
		DescriptionAttribute[] array = default(DescriptionAttribute[]);
		if (array.Length != 0)
		{
			num = 5;
			goto IL_0042;
		}
		goto IL_00c1;
		IL_0042:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto IL_006b;
			case 4:
				goto IL_006b;
			case 0:
			case 2:
				array = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(Rs5rCgEoHyHlCC59CiN(pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(16777520)), inherit: false);
				break;
			case 5:
				return (string)f3Q24mEQHulH1QsKa4o(array[0]);
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		if (array != null)
		{
			goto IL_006b;
		}
		goto IL_00c1;
		IL_00c1:
		return value.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Rs5rCgEoHyHlCC59CiN(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f3Q24mEQHulH1QsKa4o(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DescriptionAttribute)P_0).Description;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gvRK9hEdwW54KIYregs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qeAd9rEIAxl8yxy6bjM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
