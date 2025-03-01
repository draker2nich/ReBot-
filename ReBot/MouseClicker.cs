using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using zoxFr96uALPVfCJPYS;

namespace ReBot;

public static class MouseClicker
{
	private static IntPtr AHL95THgYB;

	private static bool vxs98VuaIM;

	private static int Ftg9Lfro3L;

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "PostMessage")]
	private static extern int HkZ9JqyTih(int P_0, int P_1, int P_2, IntPtr P_3);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
	private static extern int ByP9Z8E4ga(int P_0, int P_1, int P_2, IntPtr P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init(IntPtr ptr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!i3SPBoiAhQGruCyTYk())
		{
			num = 3;
			if (!HdlMImCDKgQS6ErS8s())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (!HdlMImCDKgQS6ErS8s())
			{
				return;
			}
		}
		goto IL_0061;
		IL_0061:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 2:
				goto IL_0049;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				vxs98VuaIM = true;
				goto IL_0049;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_0049:
		AHL95THgYB = ptr;
		goto IL_002a;
		IL_002a:
		Ftg9Lfro3L = AHL95THgYB.ToInt32();
		num = 5;
		if (i3SPBoiAhQGruCyTYk())
		{
			goto IL_0049;
		}
		goto IL_0061;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MouseClicker()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Clear()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vxs98VuaIM = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MouseDown(int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (vxs98VuaIM)
		{
			ByP9Z8E4ga(Ftg9Lfro3L, 513, 0, new IntPtr(y * 65536 + x));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MouseUp(int int_1, int int_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (vxs98VuaIM)
		{
			ByP9Z8E4ga(Ftg9Lfro3L, 514, 0, new IntPtr(int_2 * 65536 + int_1));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MouseMove(int int_1, int int_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (vxs98VuaIM)
		{
			ByP9Z8E4ga(Ftg9Lfro3L, 512, 0, new IntPtr(int_2 * 65536 + int_1));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MouseChar(char char_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (vxs98VuaIM)
		{
			ByP9Z8E4ga(Ftg9Lfro3L, 258, char_0, IntPtr.Zero);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MouseString(string string_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HdlMImCDKgQS6ErS8s();
		int num = (i3SPBoiAhQGruCyTYk() ? 2 : 4);
		string text = default(string);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				return;
			case 0:
			case 4:
				if (!vxs98VuaIM)
				{
					return;
				}
				text = string_0;
				num = 5;
				break;
			case 6:
				if (num2 >= text.Length)
				{
					num = 7;
					break;
				}
				M3RZxUM0wC1M6pE0ts(text[num2]);
				goto case 3;
			case 3:
				num2++;
				num = 6;
				break;
			case 5:
				num2 = 0;
				goto case 6;
			default:
				num = 3;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HdlMImCDKgQS6ErS8s()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool i3SPBoiAhQGruCyTYk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M3RZxUM0wC1M6pE0ts(char char_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MouseChar(char_0);
	}
}
