using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using CUB0kCL30YeF2Gt7jr;
using zoxFr96uALPVfCJPYS;

namespace fCq6WfrEDILJ63bcvr;

internal class ajb1k2nt7TG3bU18v9
{
	internal class PNfd3ptdd4kpDa9vy2 : Attribute
	{
		internal class XFpMwjIkFNwULaBPG9<tbNEnVq8URqMOpFYCr>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public XFpMwjIkFNwULaBPG9()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool EtxaQ7FmLbudI1Y8UNv()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool VmEdg0FHMrVmc2djRdA()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PNfd3ptdd4kpDa9vy2(typeof(XFpMwjIkFNwULaBPG9<object>[]))]
		public PNfd3ptdd4kpDa9vy2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
			nb6utfFLxuc01NVNm2U(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nb6utfFLxuc01NVNm2U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Attribute)P_0)._002Ector();
		}
	}

	internal class q9LjCLwAefsvvXu0x5
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[PNfd3ptdd4kpDa9vy2(typeof(PNfd3ptdd4kpDa9vy2.XFpMwjIkFNwULaBPG9<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if ((string)Aq2S3bFfwk7y6Q9MTTu(Convert.ToBase64String(hXTDe8F1Y2.GetName().GetPublicKeyToken()), TYtDTyAefV(8996)) != TYtDTyAefV(85020))
			{
				while (true)
				{
					ce4DmfsmSrOT856tDgfrkMb();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[PNfd3ptdd4kpDa9vy2(typeof(PNfd3ptdd4kpDa9vy2.XFpMwjIkFNwULaBPG9<object>[]))]
		internal static string kYCDrdaNTe(string P_0, string P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] bytes = ((Encoding)eclu3rF9Y02sSuU8WEO()).GetBytes(P_0);
			byte[] array = bytes;
			byte[] array2 = new byte[32];
			yC7eGFFzcVu2NnoHYoT(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] array3 = array2;
			byte[] iV = (byte[])LQ0Q1UxssHVjqpta7jg(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = pQEDZgWAfx();
			jgOTM0xyHZCx6VgC9RE(symmetricAlgorithm, array3);
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			ldyp9uxd5mT5CWREmIm(cryptoStream, array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String((byte[])WkADsxxI6J80gcSomR0(memoryStream));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public q9LjCLwAefsvvXu0x5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Aq2S3bFfwk7y6Q9MTTu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kYCDrdaNTe((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eclu3rF9Y02sSuU8WEO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Encoding.Unicode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yC7eGFFzcVu2NnoHYoT(object P_0, RuntimeFieldHandle P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LQ0Q1UxssHVjqpta7jg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N3fD8j1FMc((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jgOTM0xyHZCx6VgC9RE(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ldyp9uxd5mT5CWREmIm(object P_0, object P_1, int P_2, int P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WkADsxxI6J80gcSomR0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemoryStream)P_0).ToArray();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint w2Klkg81v02SFfnXLF(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr N7IXfUCq8uKT1tW76S();

	internal struct bZlCHnBVbO3LWGosg3
	{
		internal bool xW1DfriYyD;

		internal byte[] l1jDKXQBZ1;
	}

	[Flags]
	private enum nGre27yEhTxpb5RLO4
	{

	}

	private static uint[] DLhDd5V3oU;

	private static byte[] vETD3AvW8o;

	private static byte[] ElgDEWQgTa;

	private static IntPtr PyuDGccOo4;

	private static object mnJDCR1ZfW;

	internal static w2Klkg81v02SFfnXLF edYDbYlW9h;

	internal static w2Klkg81v02SFfnXLF yANDWYln91;

	private static long rGSDgZJfHg;

	private static bool xGLDh0voCc;

	private static Assembly hXTDe8F1Y2;

	private static int xiwDnL5O9y;

	private static bool Ev5Da3wAxS;

	private static int nqBDpyTWyf;

	private static bool o8tDPTNLjM;

	private static byte[] UGeD0POm64;

	private static long CP6DBHgnx3;

	private static byte[] l0pDxsNCua;

	private static bool g8PDmkHJ2v;

	private static int bQODI5SVr7;

	private static IntPtr SENDAEiQFW;

	private static SortedList gkNDuy2ko3;

	private static int pEtDRPJivO;

	[PNfd3ptdd4kpDa9vy2(typeof(PNfd3ptdd4kpDa9vy2.XFpMwjIkFNwULaBPG9<object>[]))]
	private static bool tYVDUlTSdu;

	private static IntPtr JkND6vSFPi;

	private static int[] JJaD4RCV2I;

	private static bool ntrDwHfSJZ;

	internal static Hashtable TI9DofEmCd;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ajb1k2nt7TG3bU18v9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hXTDe8F1Y2 = Type.GetTypeFromHandle(pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(33554629)).Assembly;
		DLhDd5V3oU = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		g8PDmkHJ2v = false;
		o8tDPTNLjM = false;
		vETD3AvW8o = new byte[0];
		l0pDxsNCua = new byte[0];
		ElgDEWQgTa = new byte[0];
		UGeD0POm64 = new byte[0];
		PyuDGccOo4 = IntPtr.Zero;
		SENDAEiQFW = IntPtr.Zero;
		mnJDCR1ZfW = new string[0];
		JJaD4RCV2I = new int[0];
		xiwDnL5O9y = 1;
		ntrDwHfSJZ = false;
		gkNDuy2ko3 = new SortedList();
		bQODI5SVr7 = 0;
		CP6DBHgnx3 = 0L;
		edYDbYlW9h = null;
		yANDWYln91 = null;
		rGSDgZJfHg = 0L;
		nqBDpyTWyf = 0;
		Ev5Da3wAxS = false;
		xGLDh0voCc = false;
		pEtDRPJivO = 0;
		JkND6vSFPi = IntPtr.Zero;
		tYVDUlTSdu = false;
		TI9DofEmCd = new Hashtable();
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zZFWeTC3R1FO6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] vGwXzRnaHw(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uint[] array = new uint[16];
		int num = 448 - P_0.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(P_0.Length + num2 / 8 + 8);
		ulong num4 = (ulong)P_0.Length * 8uL;
		byte[] array2 = new byte[num3];
		for (int i = 0; i < P_0.Length; i++)
		{
			array2[i] = P_0[i];
		}
		array2[P_0.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFF);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint num7 = 1732584193u;
		uint num8 = 4023233417u;
		uint num9 = 2562383102u;
		uint num10 = 271733878u;
		for (uint num11 = 0u; num11 < num6 / 16; num11++)
		{
			uint num12 = num11 << 6;
			for (uint num13 = 0u; num13 < 61; num13 += 4)
			{
				array[num13 >> 2] = (uint)((array2[num12 + (num13 + 3)] << 24) | (array2[num12 + (num13 + 2)] << 16) | (array2[num12 + (num13 + 1)] << 8) | array2[num12 + num13]);
			}
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			uint num17 = num10;
			dy1D7xTWVl(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			dy1D7xTWVl(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			dy1D7xTWVl(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			dy1D7xTWVl(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			dy1D7xTWVl(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			dy1D7xTWVl(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			dy1D7xTWVl(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			dy1D7xTWVl(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			dy1D7xTWVl(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			dy1D7xTWVl(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			dy1D7xTWVl(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			dy1D7xTWVl(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			dy1D7xTWVl(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			dy1D7xTWVl(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			dy1D7xTWVl(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			dy1D7xTWVl(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			iijD9uUD2y(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			iijD9uUD2y(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			iijD9uUD2y(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			iijD9uUD2y(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			iijD9uUD2y(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			iijD9uUD2y(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			iijD9uUD2y(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			iijD9uUD2y(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			iijD9uUD2y(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			iijD9uUD2y(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			iijD9uUD2y(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			iijD9uUD2y(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			iijD9uUD2y(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			iijD9uUD2y(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			iijD9uUD2y(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			iijD9uUD2y(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			YPQDklf9CS(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			YPQDklf9CS(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			YPQDklf9CS(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			YPQDklf9CS(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			YPQDklf9CS(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			YPQDklf9CS(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			YPQDklf9CS(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			YPQDklf9CS(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			YPQDklf9CS(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			YPQDklf9CS(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			YPQDklf9CS(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			YPQDklf9CS(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			YPQDklf9CS(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			YPQDklf9CS(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			YPQDklf9CS(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			YPQDklf9CS(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			ALxDQwipSO(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			ALxDQwipSO(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			ALxDQwipSO(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			ALxDQwipSO(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			ALxDQwipSO(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			ALxDQwipSO(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			ALxDQwipSO(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			ALxDQwipSO(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			ALxDQwipSO(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			ALxDQwipSO(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			ALxDQwipSO(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			ALxDQwipSO(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			ALxDQwipSO(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			ALxDQwipSO(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			ALxDQwipSO(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			ALxDQwipSO(ref num8, num9, num10, num7, 9u, 21, 64u, array);
			num7 += num14;
			num8 += num15;
			num9 += num16;
			num10 += num17;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num10), 0, array3, 12, 4);
		return array3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void dy1D7xTWVl(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + UqWDsDAhqB(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + DLhDd5V3oU[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void iijD9uUD2y(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + UqWDsDAhqB(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + DLhDd5V3oU[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void YPQDklf9CS(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + UqWDsDAhqB(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + DLhDd5V3oU[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ALxDQwipSO(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + UqWDsDAhqB(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + DLhDd5V3oU[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint UqWDsDAhqB(uint P_0, ushort P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool v3YDJ0NlEa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!g8PDmkHJ2v)
		{
			wPVD50bbPR();
			g8PDmkHJ2v = true;
		}
		return o8tDPTNLjM;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm pQEDZgWAfx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (v3YDJ0NlEa())
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
			catch
			{
				return new RijndaelManaged();
			}
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wPVD50bbPR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			new RijndaelManaged();
			o8tDPTNLjM = false;
		}
		catch
		{
			o8tDPTNLjM = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] N3fD8j1FMc(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!v3YDJ0NlEa())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return vGwXzRnaHw(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PNfd3ptdd4kpDa9vy2(typeof(PNfd3ptdd4kpDa9vy2.XFpMwjIkFNwULaBPG9<object>[]))]
	internal static bool fpuDLrHbcU(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (l0pDxsNCua.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(hXTDe8F1Y2.GetManifestResourceStream("{11111-22222-20001-00000}"));
			binaryReader.BaseStream.Position = 0L;
			RSACryptoServiceProvider.UseMachineKeyStore = true;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] rgbKey = new ajb1k2nt7TG3bU18v9().aLmDSYNhAM();
			byte[] array2 = new ajb1k2nt7TG3bU18v9().QoIDyGY2ai();
			byte[] publicKeyToken = hXTDe8F1Y2.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array2[1] = publicKeyToken[0];
				array2[3] = publicKeyToken[1];
				array2[5] = publicKeyToken[2];
				array2[7] = publicKeyToken[3];
				array2[9] = publicKeyToken[4];
				array2[11] = publicKeyToken[5];
				array2[13] = publicKeyToken[6];
				array2[15] = publicKeyToken[7];
			}
			SymmetricAlgorithm symmetricAlgorithm = pQEDZgWAfx();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array2);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			l0pDxsNCua = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
		}
		if (vETD3AvW8o.Length == 0)
		{
			vETD3AvW8o = bewDH9qiD7(cNdDMsgEWo(hXTDe8F1Y2).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[4]
			{
				l0pDxsNCua[P_0],
				l0pDxsNCua[P_0 + 1],
				l0pDxsNCua[P_0 + 2],
				l0pDxsNCua[P_0 + 3]
			}, 0);
		}
		catch
		{
		}
		try
		{
			if (vETD3AvW8o[num] == 128)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint m4TD2eDGMF(uint P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PNfd3ptdd4kpDa9vy2(typeof(PNfd3ptdd4kpDa9vy2.XFpMwjIkFNwULaBPG9<object>[]))]
	internal static string TYtDTyAefV(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 178;
		byte[] array2 = default(byte[]);
		int num9 = default(int);
		int num8 = default(int);
		byte[] array = default(byte[]);
		int num7 = default(int);
		byte[] array7 = default(byte[]);
		int num4 = default(int);
		uint num22 = default(uint);
		uint num5 = default(uint);
		int num24 = default(int);
		int num17 = default(int);
		int num18 = default(int);
		int num15 = default(int);
		int num10 = default(int);
		uint num26 = default(uint);
		uint num12 = default(uint);
		byte[] array5 = default(byte[]);
		byte[] array4 = default(byte[]);
		uint num11 = default(uint);
		uint num19 = default(uint);
		MemoryStream memoryStream = default(MemoryStream);
		int num20 = default(int);
		byte[] array6 = default(byte[]);
		BinaryReader binaryReader = default(BinaryReader);
		uint num13 = default(uint);
		byte[] array3 = default(byte[]);
		int num23 = default(int);
		int num14 = default(int);
		int num25 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		int num16 = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		uint num21 = default(uint);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num6;
				switch (num2)
				{
				case 125:
					array2[7] = 128;
					num2 = 199;
					continue;
				case 103:
					num9 = 25 + 23;
					num6 = 237;
					goto IL_1872;
				case 60:
					num8 = 80 - 16;
					num = 75;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 33;
				case 5:
					array[0] = 112;
					num = 57;
					break;
				case 285:
					num9 = 156 - 41;
					num2 = 113;
					continue;
				case 108:
					num7 = 19 + 40;
					num2 = 284;
					continue;
				case 155:
					array2[31] = (byte)num8;
					num6 = 41;
					goto IL_1872;
				case 160:
					array7[num4 + 1] = (byte)((num22 & 0xFF00) >> 8);
					num6 = 175;
					goto IL_1872;
				case 21:
					num5 = (uint)(num24 * 4);
					num2 = 88;
					continue;
				case 423:
					array[7] = (byte)num7;
					num6 = 218;
					goto IL_1872;
				case 133:
					array[1] = (byte)num7;
					num6 = 108;
					goto IL_1872;
				case 32:
					if (num17 > 0)
					{
						num2 = 251;
						continue;
					}
					goto case 82;
				case 261:
					array2[12] = 3;
					num6 = 243;
					goto IL_1872;
				case 72:
				case 269:
					num18++;
					num6 = 170;
					goto IL_1872;
				case 235:
					array2[26] = (byte)num9;
					num2 = 376;
					continue;
				case 162:
					array2[17] = (byte)num8;
					num = 290;
					break;
				case 360:
					num15 = 0;
					num2 = 171;
					continue;
				case 73:
					num5 = (uint)num4;
					num2 = 118;
					continue;
				case 163:
					array2[22] = 93;
					num2 = 273;
					continue;
				case 208:
				case 216:
					array2[30] = 104;
					num = 316;
					if (0 == 0)
					{
						break;
					}
					goto case 212;
				case 212:
					num7 = 73 + 14;
					num = 239;
					if (0 == 0)
					{
						break;
					}
					goto case 78;
				case 78:
					array[4] = (byte)num10;
					num = 358;
					break;
				case 8:
					num9 = 152 - 50;
					num6 = 124;
					goto IL_1872;
				case 316:
					array2[30] = 116;
					num = 425;
					if (true)
					{
						break;
					}
					goto case 231;
				case 231:
					array2[10] = 170;
					num2 = 19;
					continue;
				case 111:
				{
					uint num27 = num26;
					uint num28 = num26;
					uint num29 = 237682431u;
					uint num30 = 2008922833u;
					uint num31 = 179264172u;
					uint num32 = 905070102u;
					uint num33 = num28;
					uint num34 = 1049191591u;
					uint num35 = ((num30 << 4) | (num30 >> 28)) + num29;
					uint num36 = num35 & 0xF0F0F0F;
					num35 &= 0xF0F0F0F0u;
					num30 = (num35 >> 4) | (num36 << 4);
					num32 = 0x65CA2A22 ^ (621148301 - num29);
					num29 ^= num30;
					uint num37 = ((num31 >> 12) | (num31 << 20)) ^ num30;
					uint num38 = num37 & 0xF0F0F0F;
					num37 &= 0xF0F0F0F0u;
					num31 = (num37 >> 4) | (num38 << 4);
					uint num39 = ((num34 << 14) | (num34 >> 18)) ^ num30;
					uint num40 = num39 & 0xFF00FF;
					num39 &= 0xFF00FF00u;
					num34 = (num39 >> 8) | (num40 << 8);
					num33 ^= num33 << 6;
					num33 += num29;
					num33 ^= num33 >> 1;
					num33 += num31;
					num33 ^= num33 << 11;
					num33 += num34;
					num33 = (((num31 << 9) + num32) ^ num29) + num33;
					num26 = num27 + (uint)(double)num33;
					num6 = 14;
					goto IL_1872;
				}
				case 24:
					num9 = 64 + 108;
					num = 116;
					break;
				case 82:
					num5 = 0u;
					num6 = 354;
					goto IL_1872;
				case 206:
					num9 = 253 - 84;
					num2 = 201;
					continue;
				case 67:
					num8 = 145 - 48;
					num = 288;
					break;
				case 29:
					array2[23] = 168;
					num6 = 215;
					goto IL_1872;
				case 40:
					num12 = 255u;
					num = 360;
					break;
				case 330:
					num9 = 56 + 13;
					num2 = 142;
					continue;
				case 313:
					array2[12] = (byte)num9;
					num = 401;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 218;
				case 373:
					array2[26] = 117;
					num6 = 403;
					goto IL_1872;
				case 80:
					num10 = 185 - 61;
					num6 = 329;
					goto IL_1872;
				case 233:
					array2[1] = 99;
					num = 156;
					break;
				case 41:
					array2[31] = 66;
					num = 149;
					break;
				case 270:
					array2[9] = (byte)num8;
					num = 414;
					if (0 == 0)
					{
						break;
					}
					goto case 46;
				case 46:
					array2[31] = 96;
					num = 179;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 347;
				case 138:
					array2[9] = (byte)num8;
					num2 = 326;
					continue;
				case 130:
					array[2] = 91;
					num = 23;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 394;
				case 394:
					array[13] = (byte)num10;
					num = 405;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 311;
				case 143:
					num9 = 150 - 50;
					num2 = 134;
					continue;
				case 6:
					array[10] = 92;
					num2 = 420;
					continue;
				case 288:
					array2[13] = (byte)num8;
					num2 = 279;
					continue;
				case 20:
					num9 = 33 + 101;
					num6 = 389;
					goto IL_1872;
				case 191:
					num9 = 159 - 53;
					num6 = 4;
					goto IL_1872;
				case 275:
					num10 = 25 + 41;
					num = 331;
					break;
				case 349:
					array2[15] = 202;
					num6 = 20;
					goto IL_1872;
				case 112:
					num9 = 178 - 59;
					num = 244;
					break;
				case 348:
					num8 = 214 - 71;
					num6 = 211;
					goto IL_1872;
				case 355:
					array5[13] = array4[6];
					num2 = 203;
					continue;
				case 283:
				case 392:
					num26 = num11;
					num = 324;
					break;
				case 247:
					array2[18] = 58;
					num = 368;
					break;
				case 375:
					array2[2] = (byte)num8;
					num = 105;
					if (true)
					{
						break;
					}
					goto case 71;
				case 71:
					array2[22] = (byte)num8;
					num = 3;
					break;
				case 174:
					num8 = 170 - 56;
					num2 = 33;
					continue;
				case 417:
					array2[19] = 17;
					num = 377;
					if (true)
					{
						break;
					}
					goto case 399;
				case 399:
					num8 = 54 + 99;
					num = 262;
					break;
				case 107:
					num8 = 87 + 22;
					num2 = 138;
					continue;
				case 255:
					array2[24] = (byte)num9;
					num = 189;
					if (0 == 0)
					{
						break;
					}
					goto case 412;
				case 412:
					array2[25] = 102;
					num6 = 281;
					goto IL_1872;
				case 312:
					array2[3] = 154;
					num6 = 357;
					goto IL_1872;
				case 70:
					ElgDEWQgTa = array7;
					num = 383;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 44;
				case 44:
					array[12] = (byte)num7;
					num2 = 139;
					continue;
				case 258:
					array5 = array;
					num = 315;
					break;
				case 300:
					num7 = 87 + 22;
					num6 = 364;
					goto IL_1872;
				case 190:
					num19 <<= 8;
					num6 = 224;
					goto IL_1872;
				case 368:
					num8 = 204 - 68;
					num = 409;
					if (true)
					{
						break;
					}
					goto case 237;
				case 237:
					array2[4] = (byte)num9;
					num = 228;
					if (true)
					{
						break;
					}
					goto case 164;
				case 164:
					num9 = 51 - 15;
					num6 = 151;
					goto IL_1872;
				case 147:
					num19 = 0u;
					num2 = 145;
					continue;
				case 345:
					array2[9] = (byte)num8;
					num2 = 182;
					continue;
				case 199:
					num9 = 151 - 50;
					_ = 1;
					num6 = (eE8GWvYBy2tFJjbhDE() ? 216 : 34);
					goto IL_1872;
				case 398:
					wIMKJgeqrXx9CsXMQN(memoryStream);
					num = 177;
					if (0 == 0)
					{
						break;
					}
					goto case 367;
				case 367:
					num7 = 194 - 64;
					num2 = 81;
					continue;
				case 296:
					num7 = 129 - 43;
					num = 286;
					break;
				case 411:
					num8 = 87 + 48;
					num2 = 71;
					continue;
				case 3:
					array2[22] = 134;
					num6 = 214;
					goto IL_1872;
				case 387:
					array[8] = 154;
					num = 93;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 95;
				case 95:
					array2[10] = 155;
					num2 = 295;
					continue;
				case 286:
					array[11] = (byte)num7;
					num2 = 271;
					continue;
				case 225:
					num8 = 81 + 97;
					num = 106;
					break;
				case 211:
					array2[17] = (byte)num8;
					num = 9;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 340;
				case 340:
					num8 = 169 - 56;
					num2 = 323;
					continue;
				case 351:
					array2[28] = 96;
					num6 = 321;
					goto IL_1872;
				case 325:
					array2[23] = 91;
					num2 = 29;
					continue;
				case 26:
					num7 = 128 - 42;
					num2 = 363;
					continue;
				case 66:
				case 161:
					if (num20 >= array5.Length)
					{
						num2 = 89;
						continue;
					}
					array6[num20] ^= array5[num20];
					num6 = 230;
					goto IL_1872;
				case 181:
					array2[26] = (byte)num8;
					num2 = 174;
					continue;
				case 51:
					array[8] = (byte)num10;
					num2 = 209;
					continue;
				case 204:
					array2[14] = 110;
					num2 = 167;
					continue;
				case 180:
					array2[19] = (byte)num9;
					num = 417;
					if (true)
					{
						break;
					}
					goto case 260;
				case 260:
					ug1aHN6MkhjZZgWj3K(Kl1gE0kmNBV6AuKUG5(binaryReader), 0L);
					num = 419;
					break;
				case 356:
					array5[9] = array4[4];
					num6 = 166;
					goto IL_1872;
				case 307:
					num8 = 190 - 63;
					num = 241;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 185;
				case 257:
					array2[7] = 4;
					num = 35;
					break;
				case 426:
					num10 = 222 - 74;
					num6 = 310;
					goto IL_1872;
				case 15:
					num8 = 117 + 3;
					num2 = 141;
					continue;
				case 420:
					array[10] = 168;
					num = 26;
					break;
				case 390:
					num8 = 33 + 72;
					num = 347;
					if (0 == 0)
					{
						break;
					}
					goto case 84;
				case 84:
					array[6] = (byte)num7;
					num = 302;
					break;
				case 322:
					num7 = 106 - 63;
					num2 = 10;
					continue;
				case 331:
					array[6] = (byte)num10;
					num = 74;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 95;
				case 273:
					num9 = 179 - 107;
					num = 110;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 192;
				case 192:
					num8 = 49 + 123;
					num = 291;
					if (true)
					{
						break;
					}
					goto case 76;
				case 76:
					num10 = 200 - 66;
					num2 = 272;
					continue;
				case 86:
					num13 = 0u;
					num6 = 85;
					goto IL_1872;
				case 14:
					num11 = num26;
					num2 = 173;
					continue;
				case 119:
					array2[21] = 170;
					num2 = 369;
					continue;
				case 381:
					array[3] = (byte)num10;
					num2 = 240;
					continue;
				case 256:
					array2[25] = (byte)num8;
					num = 407;
					break;
				case 45:
					num8 = 80 + 71;
					num6 = 345;
					goto IL_1872;
				case 154:
					array2[15] = 156;
					num2 = 349;
					continue;
				case 10:
					array[5] = (byte)num7;
					num2 = 259;
					continue;
				case 48:
					array2 = new byte[32];
					num = 289;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 128;
				case 128:
					num8 = 212 - 70;
					num2 = 155;
					continue;
				case 219:
					num10 = 174 + 46;
					num = 169;
					if (true)
					{
						break;
					}
					goto case 241;
				case 241:
					array2[7] = (byte)num8;
					num2 = 125;
					continue;
				case 378:
					array[3] = (byte)num7;
					num6 = 242;
					goto IL_1872;
				case 236:
					num8 = 184 + 16;
					num6 = 181;
					goto IL_1872;
				case 386:
					array2[16] = 147;
					num2 = 49;
					continue;
				case 117:
					array2[4] = 62;
					num = 31;
					if (0 == 0)
					{
						break;
					}
					goto case 320;
				case 320:
					array2[11] = (byte)num9;
					num = 410;
					break;
				case 328:
					array2[5] = (byte)num9;
					num2 = 205;
					continue;
				case 228:
					array2[4] = 1;
					num = 150;
					break;
				case 90:
					array2[13] = (byte)num9;
					num = 67;
					if (true)
					{
						break;
					}
					goto case 11;
				case 11:
					num8 = 28 + 105;
					num6 = 422;
					goto IL_1872;
				case 246:
					array[9] = (byte)num10;
					num = 277;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 110;
				case 166:
					array5[11] = array4[5];
					num2 = 355;
					continue;
				case 113:
					array2[14] = (byte)num9;
					num6 = 154;
					goto IL_1872;
				case 353:
					num7 = 104 - 56;
					num = 133;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 33;
				case 335:
					num8 = 123 + 109;
					num2 = 193;
					continue;
				case 359:
					array2[10] = 115;
					num6 = 231;
					goto IL_1872;
				case 250:
					array2[11] = 39;
					num = 372;
					if (true)
					{
						break;
					}
					goto case 343;
				case 343:
					array7 = new byte[array3.Length];
					num6 = 221;
					goto IL_1872;
				case 354:
					num18 = 0;
					num2 = 61;
					continue;
				case 176:
					array[15] = 207;
					num2 = 258;
					continue;
				case 264:
					array2[29] = (byte)num8;
					num2 = 97;
					continue;
				case 276:
					array[9] = (byte)num10;
					num2 = 304;
					continue;
				case 38:
					array[11] = 43;
					num = 296;
					if (0 == 0)
					{
						break;
					}
					goto case 280;
				case 280:
					num9 = 236 - 78;
					num = 415;
					if (true)
					{
						break;
					}
					goto case 183;
				case 183:
					array[13] = 97;
					num2 = 303;
					continue;
				case 74:
					num7 = 99 - 59;
					num2 = 84;
					continue;
				case 159:
					num8 = 229 - 76;
					num = 379;
					if (0 == 0)
					{
						break;
					}
					goto case 99;
				case 99:
					array2[11] = 101;
					num = 250;
					if (true)
					{
						break;
					}
					goto case 91;
				case 91:
					num8 = 79 + 56;
					num2 = 385;
					continue;
				case 239:
					array[0] = (byte)num7;
					num = 5;
					break;
				case 323:
					array2[9] = (byte)num8;
					num2 = 45;
					continue;
				case 120:
					num10 = 225 - 75;
					num2 = 121;
					continue;
				case 23:
					array[2] = 219;
					num6 = 311;
					goto IL_1872;
				case 97:
					num8 = 125 - 93;
					num2 = 28;
					continue;
				case 341:
					array[0] = 70;
					num2 = 185;
					continue;
				case 402:
					array[0] = (byte)num7;
					num = 238;
					break;
				case 205:
					num8 = 103 + 51;
					num2 = 43;
					continue;
				case 321:
					num8 = 79 + 53;
					num2 = 148;
					continue;
				case 227:
					array2[10] = 71;
					num2 = 95;
					continue;
				case 25:
					array[15] = 92;
					num6 = 176;
					goto IL_1872;
				case 184:
					array[14] = 172;
					num2 = 7;
					continue;
				case 186:
					num9 = 104 + 117;
					num6 = 362;
					goto IL_1872;
				case 317:
					num8 = 95 + 124;
					num2 = 162;
					continue;
				case 7:
					num7 = 68 + 118;
					num = 232;
					break;
				case 336:
					array7[num4] = (byte)(num22 & 0xFF);
					num2 = 160;
					continue;
				case 34:
				case 53:
					array2[7] = (byte)num9;
					num6 = 257;
					goto IL_1872;
				case 52:
					num11 = 0u;
					num = 86;
					break;
				case 377:
					num8 = 114 + 10;
					num2 = 413;
					continue;
				case 50:
					array[3] = 101;
					num6 = 12;
					goto IL_1872;
				case 118:
					num19 = (uint)((array3[num5 + 3] << 24) | (array3[num5 + 2] << 16) | (array3[num5 + 1] << 8) | array3[num5]);
					num6 = 283;
					goto IL_1872;
				case 243:
					num9 = 220 - 73;
					num6 = 313;
					goto IL_1872;
				case 135:
					array[8] = 149;
					num6 = 219;
					goto IL_1872;
				case 397:
					num8 = 31 + 0;
					num = 55;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 81;
				case 81:
					array[10] = (byte)num7;
					num2 = 6;
					continue;
				case 149:
					array2[31] = 61;
					num2 = 46;
					continue;
				case 334:
					num9 = 112 + 61;
					num = 278;
					break;
				case 168:
					num8 = 184 - 61;
					num = 327;
					if (true)
					{
						break;
					}
					goto case 13;
				case 13:
					array2[21] = 82;
					num6 = 206;
					goto IL_1872;
				case 287:
					array2[22] = (byte)num9;
					num = 163;
					break;
				case 363:
					array[10] = (byte)num7;
					num6 = 104;
					goto IL_1872;
				case 132:
					num8 = 2 + 12;
					num = 16;
					if (0 == 0)
					{
						break;
					}
					goto case 422;
				case 422:
					array2[8] = (byte)num8;
					num = 384;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 127;
				case 127:
					array2[6] = 86;
					num = 129;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 39;
				case 59:
					array2[4] = 118;
					num = 103;
					break;
				case 388:
					array[0] = (byte)num10;
					num2 = 341;
					continue;
				case 220:
					array6 = array2;
					num2 = 102;
					continue;
				case 102:
					array = new byte[16];
					num6 = 212;
					goto IL_1872;
				case 101:
					num20 = 0;
					num6 = 66;
					goto IL_1872;
				case 153:
					num10 = 213 - 71;
					num2 = 308;
					continue;
				case 167:
					num9 = 85 + 62;
					num2 = 314;
					continue;
				case 129:
					array2[6] = 82;
					num = 319;
					break;
				case 203:
					array5[15] = array4[7];
					num6 = 101;
					goto IL_1872;
				case 332:
					array2[21] = (byte)num8;
					num = 292;
					if (0 == 0)
					{
						break;
					}
					goto case 215;
				case 215:
					num9 = 129 - 43;
					num = 255;
					break;
				case 39:
					array[13] = (byte)num7;
					num6 = 183;
					goto IL_1872;
				case 385:
					array2[2] = (byte)num8;
					num = 131;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 365;
				case 365:
					ElgDEWQgTa = (byte[])Rclw3v7cP1hoXUUyMt(memoryStream);
					num = 398;
					break;
				case 337:
					num23 = 0;
					num2 = 122;
					continue;
				case 12:
					num10 = 208 - 69;
					num2 = 381;
					continue;
				case 391:
					array[14] = (byte)num10;
					num2 = 184;
					continue;
				case 56:
					array[12] = (byte)num7;
					num2 = 393;
					continue;
				case 218:
					array[7] = 136;
					num = 300;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 359;
				case 379:
					array2[11] = (byte)num8;
					num2 = 99;
					continue;
				case 303:
					num10 = 94 + 84;
					num2 = 394;
					continue;
				case 210:
					num9 = 91 + 102;
					num2 = 180;
					continue;
				case 116:
					array2[0] = (byte)num9;
					num = 233;
					if (true)
					{
						break;
					}
					goto case 294;
				case 294:
					array2[26] = 102;
					num = 373;
					if (true)
					{
						break;
					}
					goto case 18;
				case 18:
					array2[30] = (byte)num9;
					goto case 202;
				default:
					num6 = 202;
					goto IL_1872;
				case 61:
				case 170:
					if (num18 >= num14)
					{
						num = 70;
						if (true)
						{
							break;
						}
						goto case 198;
					}
					num24 = num18 % num25;
					num6 = 195;
					goto IL_1872;
				case 198:
					num8 = 109 + 19;
					num = 264;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 152;
				case 77:
					array2[19] = (byte)num9;
					num6 = 94;
					goto IL_1872;
				case 338:
					array[10] = (byte)num10;
					num = 38;
					if (0 == 0)
					{
						break;
					}
					goto case 58;
				case 58:
					num7 = 247 - 82;
					num = 266;
					if (true)
					{
						break;
					}
					goto case 371;
				case 371:
					num7 = 133 - 44;
					num2 = 301;
					continue;
				case 30:
					num15 += 8;
					num = 424;
					break;
				case 361:
					array[1] = 201;
					num6 = 426;
					goto IL_1872;
				case 421:
					if (num17 > 0)
					{
						num2 = 147;
						continue;
					}
					goto IL_0d89;
				case 173:
					if (num18 == num14 - 1)
					{
						num = 96;
						if (!eE8GWvYBy2tFJjbhDE())
						{
							break;
						}
						goto case 63;
					}
					goto IL_2480;
				case 63:
					array5[7] = array4[3];
					num = 356;
					if (true)
					{
						break;
					}
					goto case 346;
				case 346:
					array2[1] = 151;
					num2 = 396;
					continue;
				case 189:
					array2[24] = 114;
					num2 = 164;
					continue;
				case 4:
					array2[16] = (byte)num9;
					num6 = 386;
					goto IL_1872;
				case 244:
					array2[11] = (byte)num9;
					num6 = 159;
					goto IL_1872;
				case 259:
					num10 = 192 - 64;
					num2 = 306;
					continue;
				case 400:
					num9 = 19 + 20;
					num6 = 90;
					goto IL_1872;
				case 407:
					num9 = 239 + 2;
					num = 268;
					if (true)
					{
						break;
					}
					goto case 85;
				case 85:
					num19 = 0u;
					num = 32;
					break;
				case 380:
					array2[31] = (byte)num9;
					num2 = 60;
					continue;
				case 158:
					if (array4.Length <= 0)
					{
						goto case 101;
					}
					num = 36;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 175;
				case 327:
					array2[8] = (byte)num8;
					num2 = 11;
					continue;
				case 326:
					num8 = 9 + 111;
					num = 374;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 423;
				case 329:
					array[15] = (byte)num10;
					num = 120;
					break;
				case 177:
					wIMKJgeqrXx9CsXMQN(cryptoStream);
					num = 27;
					if (0 == 0)
					{
						break;
					}
					goto case 105;
				case 105:
					array2[3] = 94;
					num2 = 280;
					continue;
				case 413:
					array2[19] = (byte)num8;
					num = 1;
					if (true)
					{
						break;
					}
					goto case 214;
				case 214:
					num9 = 173 - 57;
					num2 = 287;
					continue;
				case 221:
					num25 = array6.Length / 4;
					num2 = 52;
					continue;
				case 298:
					num8 = 13 + 113;
					num2 = 126;
					continue;
				case 305:
					array[4] = 120;
					num2 = 109;
					continue;
				case 425:
					array2[30] = 159;
					num = 42;
					break;
				case 201:
					array2[21] = (byte)num9;
					num = 8;
					break;
				case 372:
					num9 = 107 - 85;
					num = 320;
					break;
				case 75:
					array2[31] = (byte)num8;
					num = 220;
					if (0 == 0)
					{
						break;
					}
					goto case 223;
				case 223:
					array2[27] = (byte)num9;
					num = 335;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 248;
				case 248:
					num7 = 16 + 31;
					num = 56;
					break;
				case 262:
					array2[20] = (byte)num8;
					num = 229;
					if (eE8GWvYBy2tFJjbhDE())
					{
						goto case 222;
					}
					break;
				case 319:
					array2[6] = 114;
					num2 = 245;
					continue;
				case 282:
					array2[6] = (byte)num8;
					num6 = 307;
					goto IL_1872;
				case 43:
					array2[5] = (byte)num8;
					num6 = 127;
					goto IL_1872;
				case 301:
					array[4] = (byte)num7;
					num = 305;
					break;
				case 384:
					array2[8] = 235;
					num2 = 107;
					continue;
				case 144:
					num23++;
					num = 226;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 93;
				case 93:
					array[8] = 198;
					num = 135;
					break;
				case 141:
					array2[13] = (byte)num8;
					num = 400;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 193;
				case 193:
					array2[27] = (byte)num8;
					num2 = 225;
					continue;
				case 62:
					array[3] = 155;
					num = 50;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 72;
				case 299:
					array5[5] = array4[2];
					num = 63;
					if (true)
					{
						break;
					}
					goto case 140;
				case 140:
					array2[13] = (byte)num9;
					num = 204;
					break;
				case 122:
				case 226:
					if (num23 < num17)
					{
						if (num23 > 0)
						{
							num2 = 366;
							continue;
						}
						goto case 424;
					}
					num6 = 72;
					goto IL_1872;
				case 9:
					array2[17] = 61;
					num = 317;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 114;
				case 114:
					array[2] = 114;
					num2 = 130;
					continue;
				case 131:
					num8 = 118 + 19;
					num = 375;
					break;
				case 310:
					array[1] = (byte)num10;
					num2 = 353;
					continue;
				case 251:
					num14++;
					num2 = 82;
					continue;
				case 333:
					array2[5] = 175;
					num = 408;
					if (true)
					{
						break;
					}
					goto case 396;
				case 396:
					array2[2] = 146;
					num = 91;
					if (true)
					{
						break;
					}
					goto case 136;
				case 136:
					array7[num4 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
					num6 = 269;
					goto IL_1872;
				case 16:
					array2[13] = (byte)num8;
					num = 15;
					if (0 == 0)
					{
						break;
					}
					goto case 148;
				case 148:
					array2[28] = (byte)num8;
					num2 = 92;
					continue;
				case 252:
					array2[20] = 46;
					num = 399;
					if (true)
					{
						break;
					}
					goto case 109;
				case 109:
					num10 = 239 - 79;
					num6 = 78;
					goto IL_1872;
				case 88:
					num13 = (uint)((array6[num5 + 3] << 24) | (array6[num5 + 2] << 16) | (array6[num5 + 1] << 8) | array6[num5]);
					num2 = 40;
					continue;
				case 42:
					num9 = 88 + 102;
					num2 = 18;
					continue;
				case 277:
					num10 = 89 - 35;
					num = 37;
					if (true)
					{
						break;
					}
					goto case 64;
				case 64:
					num9 = 140 + 108;
					num = 140;
					break;
				case 178:
					if (ElgDEWQgTa.Length == 0)
					{
						num = 267;
						if (0 == 0)
						{
							break;
						}
						goto case 309;
					}
					goto case 383;
				case 309:
					num16++;
					num = 69;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
					num7 = 117 + 3;
					num6 = 39;
					goto IL_1872;
				case 207:
					cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					num = 65;
					if (true)
					{
						break;
					}
					goto case 172;
				case 172:
					array5[3] = array4[1];
					num6 = 299;
					goto IL_1872;
				case 370:
					num10 = 98 + 90;
					num = 395;
					break;
				case 295:
					array2[11] = 92;
					num = 112;
					break;
				case 171:
					if (num18 != num14 - 1)
					{
						goto IL_0d89;
					}
					num6 = 421;
					goto IL_1872;
				case 195:
					num4 = num18 * 4;
					num = 21;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 152;
				case 152:
					array[10] = 152;
					num2 = 367;
					continue;
				case 209:
					num10 = 123 + 98;
					num = 68;
					if (0 == 0)
					{
						break;
					}
					goto case 272;
				case 272:
					array[4] = (byte)num10;
					num = 371;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 279;
				case 279:
					array2[13] = 211;
					num2 = 64;
					continue;
				case 382:
					array2[16] = 105;
					num6 = 191;
					goto IL_1872;
				case 157:
					num17 = array3.Length % 4;
					num = 200;
					break;
				case 54:
					num10 = 216 - 72;
					num2 = 276;
					continue;
				case 22:
					num8 = 41 + 113;
					num2 = 418;
					continue;
				case 318:
					array[2] = (byte)num10;
					num = 83;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 65;
				case 65:
					x3gHesvi7LNXORimn6(cryptoStream, array3, 0, array3.Length);
					num6 = 263;
					goto IL_1872;
				case 79:
					num21 = num11 ^ num19;
					num = 337;
					if (true)
					{
						break;
					}
					goto case 369;
				case 369:
					num8 = 63 + 98;
					num6 = 332;
					goto IL_1872;
				case 230:
					num20++;
					num = 161;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 406;
				case 406:
					if (array4 == null)
					{
						goto case 101;
					}
					num6 = 158;
					goto IL_1872;
				case 49:
					array2[17] = 166;
					num = 348;
					break;
				case 96:
					if (num17 > 0)
					{
						num6 = 79;
						goto IL_1872;
					}
					goto IL_2480;
				case 146:
					num16 = 0;
					num = 17;
					if (0 == 0)
					{
						break;
					}
					goto case 194;
				case 194:
					array[7] = 61;
					num = 98;
					if (true)
					{
						break;
					}
					goto case 83;
				case 83:
					array[3] = 62;
					num6 = 87;
					goto IL_1872;
				case 124:
					array2[21] = (byte)num9;
					num2 = 119;
					continue;
				case 263:
					zB0w0saAD03Whww6a7(cryptoStream);
					num6 = 365;
					goto IL_1872;
				case 17:
				case 69:
					if (num16 < num17)
					{
						if (num16 > 0)
						{
							num = 190;
							if (true)
							{
								break;
							}
							goto case 153;
						}
						goto case 224;
					}
					num = 392;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 370;
				case 224:
					num19 |= array3[array3.Length - (1 + num16)];
					num6 = 309;
					goto IL_1872;
				case 395:
					array[5] = (byte)num10;
					num = 322;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 78;
				case 311:
					num10 = 140 + 6;
					num2 = 318;
					continue;
				case 409:
					array2[18] = (byte)num8;
					num = 115;
					break;
				case 350:
					num10 = 222 - 74;
					num = 187;
					if (true)
					{
						break;
					}
					goto case 268;
				case 268:
					array2[25] = (byte)num9;
					num6 = 294;
					goto IL_1872;
				case 31:
					num9 = 171 - 57;
					num = 297;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 266;
				case 266:
					array[1] = (byte)num7;
					num = 361;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 89;
				case 89:
					if (P_0 != -1)
					{
						goto case 157;
					}
					num = 196;
					if (0 == 0)
					{
						break;
					}
					goto case 197;
				case 197:
					transform = (ICryptoTransform)BLxLoJ21Z5ixtAqMeu(symmetricAlgorithm, array6, array5);
					num = 222;
					break;
				case 308:
					array[15] = (byte)num10;
					num = 80;
					break;
				case 36:
					array5[1] = array4[0];
					num6 = 172;
					goto IL_1872;
				case 2:
					array[13] = 92;
					num2 = 0;
					continue;
				case 175:
					array7[num4 + 2] = (byte)((num22 & 0xFF0000) >> 16);
					num = 136;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 209;
				case 187:
					array[15] = (byte)num10;
					num6 = 153;
					goto IL_1872;
				case 278:
					array2[0] = (byte)num9;
					num = 24;
					if (true)
					{
						break;
					}
					goto case 416;
				case 416:
					array2[3] = 39;
					num = 117;
					if (true)
					{
						break;
					}
					goto case 229;
				case 229:
					num9 = 221 - 114;
					num6 = 342;
					goto IL_1872;
				case 200:
					num14 = array3.Length / 4;
					num6 = 343;
					goto IL_1872;
				case 37:
					array[9] = (byte)num10;
					num = 152;
					break;
				case 393:
					array[12] = 231;
					num = 2;
					if (true)
					{
						break;
					}
					goto case 145;
				case 145:
					num11 += num13;
					num = 146;
					break;
				case 306:
					array[6] = (byte)num10;
					num6 = 275;
					goto IL_1872;
				case 424:
					array7[num4 + num23] = (byte)((num21 & num12) >> num15);
					num2 = 144;
					continue;
				case 27:
					array3 = ElgDEWQgTa;
					num = 157;
					break;
				case 92:
					array2[28] = 38;
					num = 188;
					if (0 == 0)
					{
						break;
					}
					goto case 342;
				case 342:
					array2[20] = (byte)num9;
					num = 13;
					if (0 == 0)
					{
						break;
					}
					goto case 315;
				case 315:
					aclRpZUWxYWE9heXKd(array5);
					num2 = 123;
					continue;
				case 123:
					array4 = (byte[])DO9EddpAVF8fhEJmST(Vr8E3CXTc87Ij8Al4V(hXTDe8F1Y2));
					num2 = 406;
					continue;
				case 33:
					array2[27] = (byte)num8;
					num = 143;
					break;
				case 358:
					num10 = 163 - 97;
					num2 = 249;
					continue;
				case 126:
					array2[28] = (byte)num8;
					num = 351;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 142;
				case 142:
					array2[1] = (byte)num9;
					num2 = 186;
					continue;
				case 202:
					array2[30] = 69;
					num2 = 128;
					continue;
				case 366:
					num12 <<= 8;
					num = 30;
					if (true)
					{
						break;
					}
					goto case 182;
				case 182:
					num8 = 133 - 78;
					num = 270;
					break;
				case 267:
					binaryReader = new BinaryReader((Stream)Fl5gsduCHP8CwCBvuf(hXTDe8F1Y2, "6ZqaBvAp1vTFQ8EFQ1.ld1OpKVoK0TrYNQdXp"));
					num2 = 260;
					continue;
				case 139:
					array[12] = 117;
					num = 248;
					break;
				case 19:
					array2[10] = 94;
					num6 = 227;
					goto IL_1872;
				case 1:
					num9 = 14 + 114;
					num2 = 77;
					continue;
				case 290:
					array2[17] = 46;
					num2 = 247;
					continue;
				case 47:
					num10 = 141 - 47;
					num = 246;
					break;
				case 68:
					array[8] = (byte)num10;
					num = 387;
					break;
				case 28:
					array2[29] = (byte)num8;
					goto case 208;
				case 265:
					SeT97B3a3dJhygRJyC(binaryReader);
					num = 48;
					break;
				case 297:
					array2[4] = (byte)num9;
					num6 = 59;
					goto IL_1872;
				case 405:
					num10 = 156 - 52;
					num = 391;
					if (true)
					{
						break;
					}
					goto case 169;
				case 169:
					array[8] = (byte)num10;
					num2 = 54;
					continue;
				case 253:
					array2[23] = 99;
					num = 137;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 410;
				case 410:
					array2[12] = 164;
					num = 261;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 238;
				case 238:
					num10 = 188 - 62;
					num2 = 388;
					continue;
				case 389:
					array2[15] = (byte)num9;
					num = 254;
					break;
				case 106:
					array2[28] = (byte)num8;
					num = 298;
					if (0 == 0)
					{
						break;
					}
					goto case 110;
				case 110:
					array2[22] = (byte)num9;
					num6 = 253;
					goto IL_1872;
				case 121:
					array[15] = (byte)num10;
					num6 = 25;
					goto IL_1872;
				case 150:
					array2[5] = 126;
					num2 = 397;
					continue;
				case 87:
					array[3] = 90;
					num2 = 62;
					continue;
				case 245:
					num8 = 128 + 90;
					num6 = 282;
					goto IL_1872;
				case 415:
					array2[3] = (byte)num9;
					num = 312;
					if (0 == 0)
					{
						break;
					}
					goto case 274;
				case 274:
					array[1] = 50;
					num6 = 58;
					goto IL_1872;
				case 292:
					array2[21] = 50;
					num = 411;
					break;
				case 185:
					num10 = 93 + 25;
					num = 213;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 271;
				case 271:
					array[11] = 38;
					num6 = 344;
					goto IL_1872;
				case 156:
					array2[1] = 142;
					num6 = 330;
					goto IL_1872;
				case 347:
					array2[18] = (byte)num8;
					num6 = 100;
					goto IL_1872;
				case 35:
					array2[8] = 88;
					num = 168;
					if (0 == 0)
					{
						break;
					}
					goto case 408;
				case 408:
					num9 = 109 + 35;
					num = 328;
					if (0 == 0)
					{
						break;
					}
					goto case 151;
				case 151:
					array2[24] = (byte)num9;
					num2 = 412;
					continue;
				case 94:
					array2[19] = 136;
					num = 252;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 134;
				case 134:
					array2[27] = (byte)num9;
					num = 293;
					break;
				case 314:
					array2[14] = (byte)num9;
					num = 285;
					if (0 == 0)
					{
						break;
					}
					goto case 418;
				case 418:
					array2[26] = (byte)num8;
					num = 236;
					break;
				case 57:
					num7 = 129 - 43;
					num6 = 402;
					goto IL_1872;
				case 357:
					array2[3] = 125;
					num6 = 416;
					goto IL_1872;
				case 213:
					array[1] = (byte)num10;
					num = 274;
					break;
				case 419:
					array3 = (byte[])XFhhfcI69AZaEY8y1b(binaryReader, (int)fESHu2SGR0JOUqv2Yo(Kl1gE0kmNBV6AuKUG5(binaryReader)));
					num = 265;
					break;
				case 362:
					array2[1] = (byte)num9;
					num6 = 346;
					goto IL_1872;
				case 304:
					array[9] = 170;
					num = 47;
					if (0 == 0)
					{
						break;
					}
					goto case 240;
				case 240:
					num7 = 184 + 60;
					num6 = 378;
					goto IL_1872;
				case 376:
					array2[26] = 102;
					num2 = 22;
					continue;
				case 401:
					num9 = 134 + 31;
					num = 404;
					if (true)
					{
						break;
					}
					goto case 374;
				case 374:
					array2[9] = (byte)num8;
					num6 = 192;
					goto IL_1872;
				case 302:
					num10 = 118 + 56;
					num = 234;
					break;
				case 254:
					num9 = 91 + 83;
					num2 = 165;
					continue;
				case 104:
					num10 = 133 + 74;
					num2 = 338;
					continue;
				case 344:
					num7 = 125 - 41;
					num2 = 44;
					continue;
				case 234:
					array[7] = (byte)num10;
					num2 = 217;
					continue;
				case 137:
					array2[23] = 123;
					num2 = 325;
					continue;
				case 404:
					array2[12] = (byte)num9;
					num = 132;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 352;
				case 352:
					array[5] = 141;
					num = 370;
					break;
				case 165:
					array2[16] = (byte)num9;
					num = 382;
					break;
				case 414:
					array2[10] = 150;
					num6 = 359;
					goto IL_1872;
				case 232:
					array[14] = (byte)num7;
					num = 350;
					break;
				case 289:
					array2[0] = 134;
					num6 = 334;
					goto IL_1872;
				case 98:
					num10 = 111 + 75;
					num = 51;
					if (0 == 0)
					{
						break;
					}
					goto case 100;
				case 100:
					array2[18] = 72;
					num2 = 210;
					continue;
				case 364:
					array[7] = (byte)num7;
					num2 = 194;
					continue;
				case 179:
					num9 = 224 - 74;
					num = 380;
					break;
				case 403:
					num9 = 77 + 53;
					num6 = 235;
					goto IL_1872;
				case 324:
					num11 = 0u;
					num2 = 111;
					continue;
				case 115:
					array2[18] = 135;
					num6 = 390;
					goto IL_1872;
				case 217:
					num7 = 154 - 51;
					num = 423;
					break;
				case 339:
					rZP2Fjmi4ioUBtLvT8(symmetricAlgorithm, CipherMode.CBC);
					num6 = 197;
					goto IL_1872;
				case 281:
					num8 = 191 - 63;
					num6 = 256;
					goto IL_1872;
				case 249:
					array[4] = (byte)num10;
					num = 352;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 292;
				case 293:
					num9 = 217 - 72;
					num2 = 223;
					continue;
				case 383:
					num3 = oyfPHC4rrSt1CwMZA8(ElgDEWQgTa, P_0);
					num = 427;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 55;
				case 55:
					array2[5] = (byte)num8;
					num2 = 333;
					continue;
				case 291:
					array2[9] = (byte)num8;
					num2 = 340;
					continue;
				case 188:
					array2[29] = 64;
					num = 198;
					if (!eE8GWvYBy2tFJjbhDE())
					{
						break;
					}
					goto case 197;
				case 284:
					array[2] = (byte)num7;
					num = 114;
					break;
				case 242:
					array[4] = 31;
					num6 = 76;
					goto IL_1872;
				case 427:
					try
					{
						return (string)Ypk4ADlNlygZWnYIFo(WZloAdNvcpuc90mHtl(), ElgDEWQgTa, P_0 + 4, num3);
					}
					catch
					{
					}
					return "";
				case 222:
					memoryStream = new MemoryStream();
					num = 207;
					if (0 == 0)
					{
						break;
					}
					goto case 356;
				case 196:
					{
						symmetricAlgorithm = (SymmetricAlgorithm)TmBYAK1fSxV5U5vm3q();
						num2 = 339;
						continue;
					}
					IL_2480:
					num22 = num11 ^ num19;
					num = 336;
					if (AKSAXfM0L7GPr06AcV())
					{
						break;
					}
					goto case 180;
					IL_0d89:
					num11 += num13;
					num2 = 73;
					continue;
					IL_1872:
					num = num6;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PNfd3ptdd4kpDa9vy2(typeof(PNfd3ptdd4kpDa9vy2.XFpMwjIkFNwULaBPG9<object>[]))]
	internal static string YjyDl45kDy(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int PtuDNjnHSD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void uDhDVMh7dv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Delegate qSaDtohaS8(IntPtr P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Delegate)Type.GetTypeFromHandle(pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(16777462)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(16777263)),
			Type.GetTypeFromHandle(pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(16777365))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cNdDMsgEWo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PNfd3ptdd4kpDa9vy2(typeof(PNfd3ptdd4kpDa9vy2.XFpMwjIkFNwULaBPG9<object>[]))]
	private static byte[] bewDH9qiD7(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PNfd3ptdd4kpDa9vy2(typeof(PNfd3ptdd4kpDa9vy2.XFpMwjIkFNwULaBPG9<object>[]))]
	private static byte[] J5TDvmNer2(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = pQEDZgWAfx();
		symmetricAlgorithm.Key = new byte[32]
		{
			129, 135, 77, 235, 109, 240, 100, 141, 30, 4,
			84, 9, 32, 204, 214, 241, 32, 112, 38, 182,
			237, 95, 210, 118, 214, 117, 81, 169, 69, 239,
			142, 97
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			245, 115, 17, 154, 19, 136, 100, 231, 29, 23,
			219, 250, 175, 204, 160, 41
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] ESJDctBB7H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] zkWDjcPmF5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] QoIDyGY2ai()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] aLmDSYNhAM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] BjmDOqqyZP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] iUwDq53Gbg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] QO8DX930EW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] AowDDDyxsW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] FVTDYm6KwB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] UPgDFGZG66()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ajb1k2nt7TG3bU18v9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fl5gsduCHP8CwCBvuf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kl1gE0kmNBV6AuKUG5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).BaseStream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ug1aHN6MkhjZZgWj3K(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long fESHu2SGR0JOUqv2Yo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XFhhfcI69AZaEY8y1b(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SeT97B3a3dJhygRJyC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BinaryReader)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aclRpZUWxYWE9heXKd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Reverse((Array)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Vr8E3CXTc87Ij8Al4V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DO9EddpAVF8fhEJmST(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TmBYAK1fSxV5U5vm3q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return pQEDZgWAfx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rZP2Fjmi4ioUBtLvT8(object P_0, CipherMode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BLxLoJ21Z5ixtAqMeu(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x3gHesvi7LNXORimn6(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zB0w0saAD03Whww6a7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CryptoStream)P_0).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rclw3v7cP1hoXUUyMt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wIMKJgeqrXx9CsXMQN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int oyfPHC4rrSt1CwMZA8(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WZloAdNvcpuc90mHtl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.Unicode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ypk4ADlNlygZWnYIFo(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AKSAXfM0L7GPr06AcV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eE8GWvYBy2tFJjbhDE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
