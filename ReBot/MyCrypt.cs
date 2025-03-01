using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using fCq6WfrEDILJ63bcvr;
using zoxFr96uALPVfCJPYS;

namespace ReBot;

public class MyCrypt
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Encode(string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)PxR03DySr2ekBNrREJV(text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string jiT93aWx8M(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		byte[] bytes = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num)
			{
			case 5:
				bytes = Encoding.ASCII.GetBytes(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2090));
				HVg3JVyYOj80BHkuZgd();
				num = ((!Bk22CQyThNjIRexPBVl()) ? 4 : 0);
				break;
			default:
				_ = new byte[0];
				num = 6;
				break;
			case 0:
			case 2:
				array2 = (byte[])AlRVoBybqW97CcvV7NQ(Encoding.ASCII, P_0);
				goto default;
			case 1:
				array = (byte[])AlRVoBybqW97CcvV7NQ(za0aIcycNmHKhxlQ6ab(), t4d277y6QEiDJyeeLbD(2038));
				num = 5;
				break;
			case 6:
			{
				object obj = EwlkpYy7e72RUwvBrMJ();
				jIiLDmyKgZo1VaGSEEL(obj, bytes);
				sO5RcwypXoLmZJH6iXp(obj, array);
				((SymmetricAlgorithm)obj).Mode = CipherMode.CBC;
				QrLNBVy2y2Y4CHd5Vse(obj, PaddingMode.Zeros);
				return ByteArrayToString((byte[])x6seDbygK7h6RZfy4kK(((SymmetricAlgorithm)obj).CreateEncryptor(), array2, 0, array2.Length));
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ByteArrayToString(byte[] ba)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BitConverter.ToString(ba).Replace((string)t4d277y6QEiDJyeeLbD(2110), "");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MyCrypt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PvWxvvyC48mNxcjs35g();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PxR03DySr2ekBNrREJV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jiT93aWx8M((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object za0aIcycNmHKhxlQ6ab()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.ASCII;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t4d277y6QEiDJyeeLbD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AlRVoBybqW97CcvV7NQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EwlkpYy7e72RUwvBrMJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TripleDES.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jIiLDmyKgZo1VaGSEEL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sO5RcwypXoLmZJH6iXp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QrLNBVy2y2Y4CHd5Vse(object P_0, PaddingMode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).Padding = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x6seDbygK7h6RZfy4kK(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICryptoTransform)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Bk22CQyThNjIRexPBVl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HVg3JVyYOj80BHkuZgd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PvWxvvyC48mNxcjs35g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
	}
}
