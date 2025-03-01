using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using fCq6WfrEDILJ63bcvr;
using zoxFr96uALPVfCJPYS;

namespace T6LXx0kYgvX8HsA1iE;

internal class vqDvvfQKjsb1YDJOsQ
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct zFP0IDsy0SDeG3DqGJ
	{
		public int Ax3XrJM2qi;

		public long QOwXf41AEl;

		public int uq7XK6bby2;
	}

	[DllImport("advapi32.dll", EntryPoint = "AdjustTokenPrivileges", ExactSpelling = true, SetLastError = true)]
	internal static extern bool NnAqB7KmSc(IntPtr P_0, bool P_1, ref zFP0IDsy0SDeG3DqGJ P_2, int P_3, IntPtr P_4, IntPtr P_5);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess", ExactSpelling = true)]
	internal static extern IntPtr PqZqbLmPgl();

	[DllImport("advapi32.dll", EntryPoint = "InitiateSystemShutdownEx")]
	private static extern int D83qWiW4OH(string P_0, string P_1, int P_2, bool P_3, bool P_4);

	[DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeValue", SetLastError = true)]
	internal static extern bool UosqguttV8(string P_0, string P_1, ref long P_2);

	[DllImport("advapi32.dll", EntryPoint = "OpenProcessToken", ExactSpelling = true, SetLastError = true)]
	internal static extern bool VZkqpuPJfr(IntPtr P_0, int P_1, ref IntPtr P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void R9IqamFYgJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		IntPtr zero = default(IntPtr);
		zFP0IDsy0SDeG3DqGJ zFP0IDsy0SDeG3DqGJ = default(zFP0IDsy0SDeG3DqGJ);
		while (true)
		{
			switch (num)
			{
			case 4:
				zero = IntPtr.Zero;
				_ = 1;
				num = (v6ehEiOPTShO9VTfypo() ? 5 : 6);
				break;
			case 1:
			case 6:
				if (VZkqpuPJfr(PqZqbLmPgl(), 40, ref zero))
				{
					zFP0IDsy0SDeG3DqGJ.Ax3XrJM2qi = 1;
					goto case 2;
				}
				return;
			case 0:
				UosqguttV8(null, (string)Rt0FOSOATu3uyWKF3pX(83548), ref zFP0IDsy0SDeG3DqGJ.QOwXf41AEl);
				NnAqB7KmSc(zero, _0020: false, ref zFP0IDsy0SDeG3DqGJ, 0, IntPtr.Zero, IntPtr.Zero);
				num = 7;
				break;
			case 2:
			case 5:
				zFP0IDsy0SDeG3DqGJ.uq7XK6bby2 = 2;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				zFP0IDsy0SDeG3DqGJ.QOwXf41AEl = 0L;
				num = 0;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int J9lqhgT6OO(bool P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		t7Z6LhO1CX7fV1Wh7lL();
		return D83qWiW4OH(null, null, 0, P_1, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public vqDvvfQKjsb1YDJOsQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rt0FOSOATu3uyWKF3pX(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pTNifoOab44rGjFRyIf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool v6ehEiOPTShO9VTfypo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t7Z6LhO1CX7fV1Wh7lL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		R9IqamFYgJ();
	}
}
