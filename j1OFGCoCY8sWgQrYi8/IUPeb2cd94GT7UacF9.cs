using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using CUB0kCL30YeF2Gt7jr;
using fCq6WfrEDILJ63bcvr;
using zoxFr96uALPVfCJPYS;

namespace j1OFGCoCY8sWgQrYi8;

internal class IUPeb2cd94GT7UacF9
{
	private enum nybuKGi8rwhKBm6EQe
	{

	}

	internal class C9DSh9l5uawJWd8vaR
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static uint KGtY8QhYqZ(void* P_0, uint P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uint result = 0u;
			if (BitConverter.IsLittleEndian)
			{
				result = *(uint*)P_0;
			}
			else
			{
				switch (P_1)
				{
				case 4u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8) | (((byte*)P_0)[2] << 16) | (((byte*)P_0)[3] << 24));
					break;
				case 3u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8) | (((byte*)P_0)[2] << 16));
					break;
				case 2u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8));
					break;
				case 1u:
					result = *(byte*)P_0;
					break;
				}
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static void nN5YLQPRI1(uint P_0, void* P_1, uint P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (BitConverter.IsLittleEndian)
			{
				switch (P_2)
				{
				case 2u:
				case 3u:
				case 4u:
					*(uint*)P_1 = P_0;
					break;
				case 1u:
					*(byte*)P_1 = (byte)P_0;
					break;
				}
				return;
			}
			switch (P_2)
			{
			case 4u:
				*(byte*)P_1 = (byte)P_0;
				((byte*)P_1)[1] = (byte)(P_0 >> 8);
				((byte*)P_1)[2] = (byte)(P_0 >> 16);
				((byte*)P_1)[3] = (byte)(P_0 >> 24);
				break;
			case 3u:
				*(byte*)P_1 = (byte)P_0;
				((byte*)P_1)[1] = (byte)(P_0 >> 8);
				((byte*)P_1)[2] = (byte)(P_0 >> 16);
				break;
			case 2u:
				*(byte*)P_1 = (byte)P_0;
				((byte*)P_1)[1] = (byte)(P_0 >> 8);
				break;
			case 1u:
				*(byte*)P_1 = (byte)P_0;
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static bool p37Y1A4ZgQ(void* P_0, void* P_1, uint P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bool flag = true;
			uint num = 0u;
			while (flag && num < P_2)
			{
				flag = ((byte*)P_0)[(int)num] == ((byte*)P_1)[(int)num];
				num++;
			}
			return flag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static bool wCYY25qB2j(void* P_0, string P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] array = (byte[])woosGlxtFJM95yfla80(Encoding.ASCII, P_1);
			fixed (byte* ptr = array)
			{
				return p37Y1A4ZgQ(P_0, ptr, (uint)array.Length);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static void TLOYT9FgFh(void* P_0, byte P_1, uint P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			for (uint num = 0u; num < P_2; num++)
			{
				((byte*)P_0)[(int)num] = P_1;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static void caFYlAo6NM(void* P_0, void* P_1, uint P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			for (uint num = 0u; num < P_2; num++)
			{
				((byte*)P_0)[(int)num] = ((byte*)P_1)[(int)num];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static void qBHYN8mN8m(void* P_0, string P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] bytes = ((Encoding)kiHQINxWbiGlNlCgYmk()).GetBytes(P_1);
			fixed (byte* ptr = bytes)
			{
				caFYlAo6NM(P_0, ptr, (uint)bytes.Length);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static void NC4YVMo9Kq(byte* P_0, byte* P_1, uint P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (BitConverter.IsLittleEndian)
			{
				if (P_2 < 5)
				{
					*(int*)P_0 = *(int*)P_1;
					return;
				}
				byte* ptr = P_0 + (int)P_2;
				while (P_0 < ptr)
				{
					*(int*)P_0 = *(int*)P_1;
					P_0 += 4;
					P_1 += 4;
				}
			}
			else if (P_2 > 8 && P_1 + (int)P_2 < P_0)
			{
				caFYlAo6NM(P_0, P_1, P_2);
			}
			else
			{
				byte* ptr2 = P_0 + (int)P_2;
				while (P_0 < ptr2)
				{
					*P_0 = *P_1;
					P_0++;
					P_1++;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static uint kFGYtFYIZj(byte[] P_0, uint P_1, nybuKGi8rwhKBm6EQe P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uint result = 0u;
			fixed (byte* ptr = P_0)
			{
				if (wCYY25qB2j(ptr + (int)P_1, ajb1k2nt7TG3bU18v9.TYtDTyAefV(85106)))
				{
					result = *(uint*)(ptr + (int)P_1 + (nint)P_2 * (nint)4);
				}
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static uint wUPYM2iYUU(byte[] P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Bg2fE5xkiyhoR241xuh(P_0, 0u, (nybuKGi8rwhKBm6EQe)2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static uint RgsYHwTOfr(byte[] P_0, uint P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kFGYtFYIZj(P_0, P_1, (nybuKGi8rwhKBm6EQe)3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static uint O0PYvikSOi(byte[] P_0, uint P_1, byte[] P_2, uint P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fixed (byte* ptr = P_0)
			{
				fixed (byte* ptr5 = P_2)
				{
					byte* ptr2 = ptr + (int)P_1;
					uint num = 32u;
					byte* ptr3 = ptr2 + (int)P_3 - 1;
					byte* ptr4 = ptr2 + 1;
					byte** ptr6 = (byte**)(ptr5 + (int)P_3 + 36000 - (nint)sizeof(byte*) * (nint)4096 - (long)(ptr5 + (int)P_3) % 8L);
					byte* ptr7 = ptr5 + (int)num;
					byte* ptr8 = ptr5 + (int)num + 4 + 1;
					byte* ptr9 = ptr8;
					byte* ptr10 = ptr4;
					uint num2 = 1073741824u;
					uint* ptr11 = (uint*)ptr5;
					byte* ptr12 = ptr3 - 16;
					qBHYN8mN8m(ptr11, (string)E50ltgx3Iux1E4sSBC0(85106));
					*ptr5 = 81;
					ptr5[1] = 67;
					ptr5[2] = 76;
					ptr5[3] = 90;
					nN5YLQPRI1(3u, ptr11 + 1, 4u);
					nN5YLQPRI1(P_3, ptr11 + 3, 4u);
					for (uint num3 = 0u; num3 < 4096; num3++)
					{
						ptr6[num3] = ptr2;
					}
					(ptr5 + (int)num)[4] = *ptr2;
					while (ptr4 < ptr12 - 2050u)
					{
						if ((num2 & 1) == 1)
						{
							if (ptr8 + 2050u + 128 > ptr5 + (int)P_3 + 2050u + 256)
							{
								caFYlAo6NM(ptr5 + (int)num, ptr2, P_3);
								nN5YLQPRI1(0u, ptr11 + 4, 4u);
								nN5YLQPRI1(P_3 + num + 4, ptr11 + 2, 4u);
								qBHYN8mN8m(ptr5 + (int)KGtY8QhYqZ(ptr11 + 2, 4u) - 4, ajb1k2nt7TG3bU18v9.TYtDTyAefV(85106));
								return KGtY8QhYqZ(ptr11 + 2, 4u);
							}
							nN5YLQPRI1((uint)((num2 >> 1) | int.MinValue), ptr7, 4u);
							ptr7 = ptr8;
							ptr8 += 4;
							num2 = 2147483648u;
							if (ptr8 - ptr9 > ptr4 - ptr10 && ptr4 + 4100u < ptr12)
							{
								for (; ptr4 < ptr10 + 2050u - 32; ptr4 += 31)
								{
									nN5YLQPRI1(2147483648u, ptr8 - 4, 4u);
									NC4YVMo9Kq(ptr8, ptr4, 31u);
									ptr8 += 35;
								}
								ptr10 = ptr4;
								ptr9 = ptr8;
								ptr7 = ptr8 - 4;
							}
						}
						uint num4;
						if (KGtY8QhYqZ(ptr4, 4u) == KGtY8QhYqZ(ptr4 + 1, 4u))
						{
							num4 = KGtY8QhYqZ(ptr4, 4u);
							byte* ptr13 = ptr4;
							for (ptr4 += 5; num4 == KGtY8QhYqZ(ptr4, 4u) && ptr4 < ptr13 + 2050u - 4; ptr4 += 4)
							{
							}
							nN5YLQPRI1(((num4 & 0xFF) << 16) | (uint)(int)(ptr4 - ptr13 << 4) | 0xF, ptr8, 4u);
							ptr8 += 3;
							num2 = (num2 >> 1) | 0x80000000u;
							continue;
						}
						num4 = KGtY8QhYqZ(ptr4, 4u);
						uint num3 = ((num4 >> 12) ^ num4) & 0xFFF;
						byte* ptr14 = ptr6[num3];
						ptr6[num3] = ptr4;
						if ((!BitConverter.IsLittleEndian) ? (ptr4 - ptr14 <= 131071 && ptr4 - ptr14 > 3 && *ptr4 == *ptr14 && ptr4[1] == ptr14[1] && ptr4[2] == ptr14[2]) : (ptr4 - ptr14 <= 131071 && ptr4 - ptr14 > 3 && ((*(uint*)ptr14 ^ *(uint*)ptr4) & 0xFFFFFF) == 0))
						{
							uint num5 = (uint)(ptr4 - ptr14);
							if ((!BitConverter.IsLittleEndian) ? (ptr14[3] != ptr4[3]) : (*(uint*)ptr14 != *(uint*)ptr4))
							{
								if (num5 <= 63)
								{
									*ptr8 = (byte)(num5 << 2);
									ptr8++;
									num2 = (num2 >> 1) | 0x80000000u;
									ptr4 += 3;
								}
								else if (num5 <= 16383)
								{
									uint num6 = (num5 << 2) | 1;
									nN5YLQPRI1(num6, ptr8, 2u);
									ptr8 += 2;
									num2 = (num2 >> 1) | 0x80000000u;
									ptr4 += 3;
								}
								else
								{
									*ptr8 = *ptr4;
									ptr8++;
									ptr4++;
									num2 >>= 1;
								}
								continue;
							}
							num2 = (num2 >> 1) | 0x80000000u;
							uint num7;
							for (num7 = 3u; ptr14[(int)num7] == ptr4[(int)num7] && num7 < 2050; num7++)
							{
							}
							ptr4 += (int)num7;
							if (num7 <= 18 && num5 <= 1023)
							{
								uint num8 = (num7 - 3 << 2) | (num5 << 6) | 2;
								nN5YLQPRI1(num8, ptr8, 2u);
								ptr8 += 2;
							}
							else if (num7 <= 34 && num5 <= 65535)
							{
								uint num9 = (num7 - 3 << 3) | (num5 << 8) | 3;
								nN5YLQPRI1(num9, ptr8, 3u);
								ptr8 += 3;
							}
							else if (num7 >= 3)
							{
								uint num10 = (num7 - 3 << 4) | (num5 << 15) | 7;
								nN5YLQPRI1(num10, ptr8, 4u);
								ptr8 += 4;
							}
						}
						else
						{
							*ptr8 = *ptr4;
							ptr8++;
							ptr4++;
							num2 >>= 1;
						}
					}
					while (ptr4 <= ptr3)
					{
						if ((num2 & 1) == 1)
						{
							nN5YLQPRI1((num2 >> 1) | 0x80000000u, ptr7, 4u);
							ptr7 = ptr8;
							ptr8 += 4;
							num2 = 2147483648u;
						}
						*ptr8 = *ptr4;
						ptr8++;
						ptr4++;
						num2 >>= 1;
					}
					while ((num2 & 1) != 1)
					{
						num2 >>= 1;
					}
					nN5YLQPRI1((num2 >> 1) | 0x80000000u, ptr7, 4u);
					ptr8 += 4;
					nN5YLQPRI1(1u, ptr11 + 4, 4u);
					nN5YLQPRI1((uint)(ptr8 - ptr5 - 1 + 4), ptr11 + 2, 4u);
					qBHYN8mN8m(ptr5 + (int)KGtY8QhYqZ(ptr11 + 2, 4u) - 4, ajb1k2nt7TG3bU18v9.TYtDTyAefV(85106));
				}
			}
			return wUPYM2iYUU(P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static uint LOcYcHu4E9(byte[] P_0, uint P_1, byte[] P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fixed (byte* ptr = P_0)
			{
				fixed (byte* ptr4 = P_2)
				{
					byte* ptr2 = ptr + (int)P_1;
					uint num = 32u;
					byte* ptr3 = ptr2 + (int)num;
					byte* ptr5 = ptr4;
					uint* ptr6 = (uint*)ptr2;
					byte* ptr7 = ptr4 + (int)KGtY8QhYqZ(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16];
					ccyRGgxTwtaopYCBjIL(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					uint[] array2 = array;
					byte* ptr8 = ptr7 - 4;
					if (!wCYY25qB2j(ptr6, ajb1k2nt7TG3bU18v9.TYtDTyAefV(85106)))
					{
						return 0u;
					}
					if (KGtY8QhYqZ(ptr6 + 1, 4u) != 3)
					{
						return 0u;
					}
					if (!wCYY25qB2j(ptr2 + (int)KGtY8QhYqZ(ptr6 + 2, 4u) - 4, ajb1k2nt7TG3bU18v9.TYtDTyAefV(85106)))
					{
						return 0u;
					}
					if (KGtY8QhYqZ(ptr6 + 4, 4u) != 1)
					{
						caFYlAo6NM(ptr4, ptr2 + (int)num, KGtY8QhYqZ(ptr6 + 3, 4u));
						return KGtY8QhYqZ(ptr6 + 3, 4u);
					}
					if (ptr5 >= ptr8)
					{
						ptr3 += 4;
						while (ptr5 < ptr7)
						{
							*ptr5 = *ptr3;
							ptr5++;
							ptr3++;
						}
						return (uint)(ptr5 - ptr4);
					}
					while (true)
					{
						if (num2 == 1)
						{
							num2 = KGtY8QhYqZ(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = KGtY8QhYqZ(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								NC4YVMo9Kq(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								NC4YVMo9Kq(ptr5, ptr5 - (int)num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								NC4YVMo9Kq(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								NC4YVMo9Kq(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								NC4YVMo9Kq(ptr5, ptr5 - (int)num4, num5);
								ptr5 += (int)num5;
								ptr3 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								TLOYT9FgFh(ptr5, b, num5);
								ptr5 += (int)num5;
								ptr3 += 3;
							}
						}
						else
						{
							NC4YVMo9Kq(ptr5, ptr3, 4u);
							ptr5 += (int)array2[num2 & 0xF];
							ptr3 += (int)array2[num2 & 0xF];
							num2 >>= (int)(byte)array2[num2 & 0xF];
							if (ptr5 >= ptr8)
							{
								break;
							}
						}
					}
					while (ptr5 < ptr7)
					{
						if (num2 == 1)
						{
							ptr3 += 4;
							num2 = 2147483648u;
						}
						*ptr5 = *ptr3;
						ptr5++;
						ptr3++;
						num2 >>= 1;
					}
					return (uint)(ptr5 - ptr4);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] b21YjOxudf(string P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] array = null;
			FileStream fileStream = File.Open(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				array = new byte[rNsExFxYOXM0CUBoXLs(fileStream)];
				l0BRiXxS8e4sYmBxDBf(fileStream, array, 0, array.Length);
				return array;
			}
			finally
			{
				fileStream.Close();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] tIRYyvborP(string P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] array = b21YjOxudf(P_0);
			return (byte[])IDLUg1xcikbWUNAyC3U(array);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] gILYSpXaV2(string P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] array = b21YjOxudf(P_0);
			return FTwYq3ciUG(array);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] aWDYOioy5G(byte[] P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lOkYDHciqK(P_0, 0u, Convert.ToUInt32(P_0.Length));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] FTwYq3ciUG(byte[] P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte[])Yf9sXax6Jy5EmR27UtG(P_0, 0u);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object r7uYX7ygcj(byte[] P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return me1tJPx7Fd5UVaZ5bZX(SQXe6vxbUoKQZ3qWeuO(pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(16777432)).GetMethod(ajb1k2nt7TG3bU18v9.TYtDTyAefV(85118), new Type[1] { typeof(byte[]) }), null, new object[1] { P_0 });
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] lOkYDHciqK(byte[] P_0, uint P_1, uint P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] array = new byte[P_2 + 36000];
			uint num = h8hV8TxKOac4FgE5j6o(P_0, P_1, array, P_2);
			byte[] array2 = new byte[num];
			for (uint num2 = 0u; num2 < num; num2++)
			{
				array2[num2] = array[num2];
			}
			return array2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] omBYYwcLJk(byte[] P_0, uint P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uint num = RgsYHwTOfr(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				wDxAiLxpjr2LJFHO2iZ(P_0, P_1, array);
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public C9DSh9l5uawJWd8vaR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
			iyiNAix2bYoOwsDK9OB(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object woosGlxtFJM95yfla80(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kiHQINxWbiGlNlCgYmk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Encoding.ASCII;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static uint Bg2fE5xkiyhoR241xuh(object P_0, uint P_1, nybuKGi8rwhKBm6EQe P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kFGYtFYIZj((byte[])P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object E50ltgx3Iux1E4sSBC0(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ccyRGgxTwtaopYCBjIL(object P_0, RuntimeFieldHandle P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long rNsExFxYOXM0CUBoXLs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Stream)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int l0BRiXxS8e4sYmBxDBf(object P_0, object P_1, int P_2, int P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IDLUg1xcikbWUNAyC3U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aWDYOioy5G((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Yf9sXax6Jy5EmR27UtG(object P_0, uint P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return omBYYwcLJk((byte[])P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type SQXe6vxbUoKQZ3qWeuO(RuntimeTypeHandle P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Type.GetTypeFromHandle(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object me1tJPx7Fd5UVaZ5bZX(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static uint h8hV8TxKOac4FgE5j6o(object P_0, uint P_1, object P_2, uint P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return O0PYvikSOi((byte[])P_0, P_1, (byte[])P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static uint wDxAiLxpjr2LJFHO2iZ(object P_0, uint P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LOcYcHu4E9((byte[])P_0, P_1, (byte[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iyiNAix2bYoOwsDK9OB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}
	}

	private static string[] pU5YsrlZSW;

	private static object t33YJkxC9v;

	private static bool anmYZ1yC1o;

	private static bool i3bY5EcIuI;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Y2nY9im4qZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 344;
		if (false)
		{
			goto IL_001d;
		}
		goto IL_03bb;
		IL_03bf:
		int num2;
		int num5 = default(int);
		int num18 = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		int num3 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		uint num11 = default(uint);
		int num20 = default(int);
		byte[] array7 = default(byte[]);
		BinaryReader binaryReader = default(BinaryReader);
		uint num19 = default(uint);
		byte[] array4 = default(byte[]);
		uint num22 = default(uint);
		byte[] array5 = default(byte[]);
		byte[] array3 = default(byte[]);
		uint num23 = default(uint);
		uint num15 = default(uint);
		uint num17 = default(uint);
		int num21 = default(int);
		uint num16 = default(uint);
		byte[] array6 = default(byte[]);
		byte[] array8 = default(byte[]);
		int num7 = default(int);
		uint num8 = default(uint);
		int num10 = default(int);
		int num9 = default(int);
		int num12 = default(int);
		while (true)
		{
			int num6;
			switch (num2)
			{
			case 91:
				break;
			case 403:
				if (num5 == num18 - 1)
				{
					num6 = 215;
					goto IL_03b7;
				}
				goto IL_2315;
			case 328:
				array[9] = 231;
				num6 = 70;
				goto IL_03b7;
			case 196:
				array2[25] = (byte)num4;
				num = 69;
				goto IL_03bb;
			case 318:
				array2[5] = (byte)num4;
				num6 = 0;
				goto IL_03b7;
			case 367:
				num4 = 154 - 50;
				num = 52;
				goto IL_03bb;
			case 253:
				array[15] = 112;
				num2 = 115;
				continue;
			case 268:
				num4 = 70 - 39;
				num = 245;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 390;
			case 205:
				array2[18] = (byte)num4;
				num = 31;
				if (u6fWuorJP3LRGAxWBS())
				{
					goto case 1;
				}
				goto IL_03bb;
			case 1:
				array2[24] = (byte)num4;
				num2 = 256;
				continue;
			case 204:
				num3 = 79 + 122;
				num = 63;
				if (!gCV1W975YZX86lT0Rj())
				{
					goto case 251;
				}
				goto IL_03bb;
			case 251:
				array2[21] = (byte)num4;
				num6 = 389;
				goto IL_03b7;
			case 133:
				array[15] = (byte)num3;
				num6 = 356;
				goto IL_03b7;
			case 376:
				num13++;
				num = 135;
				if (false)
				{
					goto case 323;
				}
				goto IL_03bb;
			case 323:
				array[7] = 142;
				num2 = 3;
				continue;
			case 395:
				array[1] = 90;
				num6 = 209;
				goto IL_03b7;
			case 350:
				array[8] = 202;
				num6 = 38;
				goto IL_03b7;
			case 164:
				array[4] = 208;
				num6 = 144;
				goto IL_03b7;
			case 283:
				array[1] = 85;
				num2 = 59;
				continue;
			case 363:
				num3 = 5 + 41;
				num6 = 176;
				goto IL_03b7;
			case 372:
				num4 = 207 - 69;
				num = 45;
				if (u6fWuorJP3LRGAxWBS())
				{
					goto case 90;
				}
				goto IL_03bb;
			case 90:
				array[14] = (byte)num3;
				num6 = 170;
				goto IL_03b7;
			case 134:
				num3 = 204 - 68;
				num = 361;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 136;
			case 216:
				num14++;
				num6 = 358;
				goto IL_03b7;
			case 287:
				num4 = 19 + 2;
				num = 175;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 322;
			case 315:
				array2[18] = 107;
				num = 92;
				goto IL_03bb;
			case 208:
				array2[22] = (byte)num4;
				num6 = 157;
				goto IL_03b7;
			case 92:
				array2[18] = 232;
				num = 247;
				goto IL_03bb;
			case 274:
				array[3] = 60;
				num6 = 308;
				goto IL_03b7;
			case 60:
				array[0] = (byte)num3;
				num = 177;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 104;
			case 369:
				num4 = 156 + 38;
				goto case 275;
			default:
				num6 = 275;
				goto IL_03b7;
			case 306:
				array[0] = 129;
				num = 120;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 0;
			case 194:
				array2[23] = 102;
				num = 192;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 147;
			case 123:
				array[12] = (byte)num3;
				num2 = 7;
				continue;
			case 131:
				array2[6] = 124;
				num = 367;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 321;
			case 321:
				array2[0] = 154;
				num6 = 280;
				goto IL_03b7;
			case 254:
				num11 = 0u;
				num2 = 258;
				continue;
			case 20:
				array2[16] = 243;
				num2 = 276;
				continue;
			case 95:
				num20 = array7.Length / 4;
				num = 347;
				goto IL_03bb;
			case 45:
				array2[11] = (byte)num4;
				num = 269;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 183;
			case 183:
				array2[6] = 99;
				num2 = 131;
				continue;
			case 25:
				num11 = 0u;
				num = 193;
				goto IL_03bb;
			case 160:
				array2[24] = 113;
				num6 = 6;
				goto IL_03b7;
			case 120:
				num3 = 83 + 70;
				num = 352;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 2;
			case 2:
				array[6] = (byte)num3;
				num = 400;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 50;
			case 50:
				array2[8] = (byte)num4;
				num = 370;
				goto IL_03bb;
			case 115:
				array[15] = 95;
				num2 = 331;
				continue;
			case 166:
				array2[21] = (byte)num4;
				num = 58;
				goto IL_03bb;
			case 396:
				num4 = 63 + 38;
				num = 171;
				goto IL_03bb;
			case 126:
				array[3] = (byte)num3;
				num6 = 364;
				goto IL_03b7;
			case 7:
				num3 = 119 - 63;
				num6 = 238;
				goto IL_03b7;
			case 153:
				array2[16] = 14;
				num2 = 377;
				continue;
			case 295:
				array2[6] = 118;
				num2 = 162;
				continue;
			case 345:
				num4 = 106 + 31;
				num2 = 97;
				continue;
			case 154:
				num4 = 118 - 91;
				num6 = 41;
				goto IL_03b7;
			case 77:
				num4 = 107 + 13;
				num6 = 156;
				goto IL_03b7;
			case 175:
				array2[1] = (byte)num4;
				num = 355;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 368;
			case 368:
				VEEUt9DkYR6l0MBlpX(H2ovUUMt7xkbVcflO4(binaryReader), 0L);
				num6 = 270;
				goto IL_03b7;
			case 401:
				num19 = 255u;
				num6 = 15;
				goto IL_03b7;
			case 180:
				num4 = 107 + 31;
				num = 251;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 337;
			case 337:
				array[1] = (byte)num3;
				num2 = 395;
				continue;
			case 379:
				num4 = 55 + 78;
				num2 = 301;
				continue;
			case 64:
				num11 = (uint)((array4[num22 + 3] << 24) | (array4[num22 + 2] << 16) | (array4[num22 + 1] << 8) | array4[num22]);
				num6 = 112;
				goto IL_03b7;
			case 264:
				num3 = 86 + 46;
				num = 71;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 84;
			case 84:
				num4 = 111 + 63;
				num = 88;
				goto IL_03bb;
			case 130:
				array[4] = (byte)num3;
				num = 28;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 355;
			case 355:
				array2[1] = 216;
				num = 249;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 231;
			case 231:
				num3 = 135 - 45;
				num2 = 147;
				continue;
			case 249:
				num4 = 143 + 73;
				num6 = 93;
				goto IL_03b7;
			case 384:
				array2[14] = (byte)num4;
				num = 200;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 199;
			case 199:
				array2[29] = (byte)num4;
				num2 = 67;
				continue;
			case 103:
				num14 = 0;
				num6 = 187;
				goto IL_03b7;
			case 76:
				array2[31] = (byte)num4;
				num6 = 379;
				goto IL_03b7;
			case 5:
				array2[21] = 89;
				num6 = 180;
				goto IL_03b7;
			case 53:
				num18 = array4.Length / 4;
				num = 113;
				goto IL_03bb;
			case 48:
				num4 = 47 - 21;
				num2 = 342;
				continue;
			case 343:
				array2[31] = 29;
				num6 = 262;
				goto IL_03b7;
			case 108:
				num3 = 122 + 102;
				num = 133;
				goto IL_03bb;
			case 277:
				array2[16] = 118;
				num2 = 20;
				continue;
			case 243:
				num4 = 0 + 83;
				num2 = 8;
				continue;
			case 197:
				num4 = 132 - 44;
				num = 236;
				goto IL_03bb;
			case 233:
				array2[15] = 134;
				num = 23;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 82;
			case 82:
				array5 = array3;
				num6 = 297;
				goto IL_03b7;
			case 222:
				array[9] = (byte)num3;
				num = 155;
				goto IL_03bb;
			case 266:
				num11 |= array4[array4.Length - (1 + num13)];
				num = 376;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 223;
			case 168:
				array2[0] = (byte)num4;
				num = 279;
				goto IL_03bb;
			case 210:
				array[12] = (byte)num3;
				num = 18;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 361;
			case 256:
				array2[24] = 123;
				num = 160;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 71;
			case 71:
				array[3] = (byte)num3;
				num = 106;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 80;
			case 80:
				num23 = num15 ^ num11;
				num2 = 103;
				continue;
			case 294:
				array2[22] = (byte)num4;
				num2 = 114;
				continue;
			case 378:
				num4 = 28 + 79;
				num = 288;
				goto IL_03bb;
			case 119:
				pU5YsrlZSW = (string[])hyZm4v0t56x1iL0dgX((Assembly)t33YJkxC9v);
				num2 = 232;
				continue;
			case 265:
				num4 = 240 - 80;
				num2 = 242;
				continue;
			case 335:
				array2[5] = (byte)num4;
				num = 295;
				goto IL_03bb;
			case 280:
				num4 = 51 + 75;
				num = 168;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 83;
			case 83:
				num4 = 31 + 10;
				num2 = 196;
				continue;
			case 330:
				num4 = 229 - 76;
				num = 205;
				goto IL_03bb;
			case 112:
			case 299:
				num17 = num15;
				num2 = 281;
				continue;
			case 46:
				array2[19] = (byte)num4;
				num = 13;
				goto IL_03bb;
			case 122:
				array[7] = 207;
				num = 217;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 147;
			case 147:
				array[9] = (byte)num3;
				num = 204;
				goto IL_03bb;
			case 386:
				array[11] = (byte)num3;
				num = 220;
				goto IL_03bb;
			case 177:
				num3 = 105 + 109;
				num2 = 206;
				continue;
			case 319:
				array[9] = (byte)num3;
				num2 = 231;
				continue;
			case 28:
				array[4] = 114;
				num = 118;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 349;
			case 349:
				num22 = (uint)(num21 * 4);
				num = 394;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 366;
			case 366:
				array2[1] = (byte)num4;
				num = 287;
				goto IL_03bb;
			case 110:
				array2[30] = (byte)num4;
				num = 285;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 172;
			case 172:
				array[10] = (byte)num3;
				num2 = 91;
				continue;
			case 100:
				array[12] = (byte)num3;
				num2 = 107;
				continue;
			case 257:
				array2[26] = 94;
				num2 = 85;
				continue;
			case 136:
				num4 = 50 + 85;
				num6 = 229;
				goto IL_03b7;
			case 305:
				num16 = 0u;
				num = 25;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 29;
			case 255:
				array2[5] = 162;
				num2 = 241;
				continue;
			case 148:
			{
				uint num24 = num17;
				uint num25 = num17;
				uint num26 = 237682431u;
				uint num27 = 2008922833u;
				uint num28 = 179264172u;
				uint num29 = 905070102u;
				uint num30 = num25;
				uint num31 = 1049191591u;
				uint num32 = ((num27 << 4) | (num27 >> 28)) + num26;
				uint num33 = num32 & 0xF0F0F0F;
				num32 &= 0xF0F0F0F0u;
				num27 = (num32 >> 4) | (num33 << 4);
				num29 = 0x65CA2A22 ^ (621148301 - num26);
				num26 ^= num27;
				uint num34 = ((num28 >> 12) | (num28 << 20)) ^ num27;
				uint num35 = num34 & 0xF0F0F0F;
				num34 &= 0xF0F0F0F0u;
				num28 = (num34 >> 4) | (num35 << 4);
				uint num36 = ((num31 << 14) | (num31 >> 18)) ^ num27;
				uint num37 = num36 & 0xFF00FF;
				num36 &= 0xFF00FF00u;
				num31 = (num36 >> 8) | (num37 << 8);
				num30 ^= num30 << 6;
				num30 += num26;
				num30 ^= num30 >> 1;
				num30 += num28;
				num30 ^= num30 << 11;
				num30 += num31;
				num30 = (((num28 << 9) + num29) ^ num26) + num30;
				num17 = num24 + (uint)(double)num30;
				num2 = 272;
				continue;
			}
			case 171:
				array2[21] = (byte)num4;
				num2 = 235;
				continue;
			case 303:
				array2[19] = 162;
				num = 136;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 181;
			case 181:
				array2[21] = (byte)num4;
				num6 = 398;
				goto IL_03b7;
			case 297:
				t33YJkxC9v = CNWug3H3SEem2Qdg0q(z07SCSJFvHdVXS1w6A(array5));
				num2 = 119;
				continue;
			case 9:
				num4 = 212 - 70;
				num6 = 182;
				goto IL_03b7;
			case 195:
				num4 = 123 + 109;
				num2 = 11;
				continue;
			case 24:
				num4 = 130 - 43;
				num2 = 179;
				continue;
			case 218:
				array2[12] = (byte)num4;
				num2 = 21;
				continue;
			case 385:
				array2[9] = 220;
				num = 39;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 96;
			case 96:
				array2[30] = (byte)num4;
				num = 139;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 27;
			case 27:
				array2[14] = 46;
				num2 = 239;
				continue;
			case 202:
				num4 = 39 + 63;
				num6 = 357;
				goto IL_03b7;
			case 40:
				array2[17] = 164;
				num = 55;
				goto IL_03bb;
			case 361:
				array[2] = (byte)num3;
				num2 = 141;
				continue;
			case 338:
				array2[27] = (byte)num4;
				num = 244;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 189;
			case 189:
				array2[28] = (byte)num4;
				num6 = 282;
				goto IL_03b7;
			case 63:
				array[9] = (byte)num3;
				num6 = 173;
				goto IL_03b7;
			case 149:
				array2[10] = (byte)num4;
				num = 165;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 33;
			case 33:
				array[13] = 18;
				num = 74;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 229;
			case 229:
				array2[19] = (byte)num4;
				num2 = 353;
				continue;
			case 247:
				num4 = 231 - 77;
				num6 = 46;
				goto IL_03b7;
			case 52:
				array2[6] = (byte)num4;
				num = 360;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 117;
			case 8:
				array2[0] = (byte)num4;
				num = 128;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 229;
			case 347:
				num15 = 0u;
				num6 = 305;
				goto IL_03b7;
			case 211:
				num4 = 76 + 107;
				num = 329;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 190;
			case 190:
				num4 = 208 + 10;
				num = 332;
				if (u6fWuorJP3LRGAxWBS())
				{
					goto case 328;
				}
				goto IL_03bb;
			case 106:
				num3 = 102 + 30;
				num = 125;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 398;
			case 398:
				num4 = 198 - 66;
				num6 = 294;
				goto IL_03b7;
			case 184:
				array2[5] = (byte)num4;
				num2 = 309;
				continue;
			case 140:
				num4 = 78 + 95;
				num2 = 26;
				continue;
			case 118:
				num3 = 207 - 69;
				num = 102;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 217;
			case 217:
				array[7] = 161;
				num2 = 87;
				continue;
			case 241:
				num4 = 246 - 82;
				num2 = 184;
				continue;
			case 98:
				array2[10] = 112;
				num = 190;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 399;
			case 399:
				num3 = 107 + 44;
				num2 = 387;
				continue;
			case 230:
				array2[19] = 106;
				num = 142;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 380;
			case 239:
				array2[14] = 102;
				_ = 1;
				if (!u6fWuorJP3LRGAxWBS())
				{
					num = 4;
					if (false)
					{
						goto case 388;
					}
				}
				else
				{
					num = 185;
					if (false)
					{
						goto case 352;
					}
				}
				goto IL_03bb;
			case 388:
				array2[18] = 127;
				num2 = 315;
				continue;
			case 377:
				array2[17] = 134;
				num2 = 40;
				continue;
			case 285:
				num4 = 112 + 5;
				num2 = 96;
				continue;
			case 89:
				array[13] = (byte)num3;
				num2 = 307;
				continue;
			case 59:
				num3 = 244 - 81;
				num6 = 337;
				goto IL_03b7;
			case 26:
				array2[30] = (byte)num4;
				num6 = 104;
				goto IL_03b7;
			case 145:
				array[0] = 196;
				num = 163;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 73;
			case 73:
				num3 = 13 + 124;
				num2 = 126;
				continue;
			case 198:
				array[5] = (byte)num3;
				num6 = 219;
				goto IL_03b7;
			case 236:
				array2[9] = (byte)num4;
				num2 = 385;
				continue;
			case 342:
				array2[7] = (byte)num4;
				num = 151;
				goto IL_03bb;
			case 334:
				array2[16] = (byte)num4;
				num = 202;
				goto IL_03bb;
			case 308:
				array[4] = 87;
				num2 = 167;
				continue;
			case 207:
				num3 = 113 + 91;
				num2 = 123;
				continue;
			case 324:
				array[14] = 113;
				num = 32;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 312;
			case 312:
				num4 = 82 + 9;
				num = 149;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 34;
			case 34:
				array2[23] = (byte)num4;
				num6 = 284;
				goto IL_03b7;
			case 36:
				num4 = 213 + 27;
				num = 169;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 327;
			case 327:
				array[14] = 177;
				num = 324;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 390;
			case 390:
				array6 = (byte[])M6GTguByQ5LjbDqVmc(binaryReader, (int)K3WGMvbfbYk0LkrPI5(H2ovUUMt7xkbVcflO4(binaryReader)));
				num2 = 333;
				continue;
			case 259:
				array[0] = 133;
				num = 145;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 359;
			case 359:
				array2[13] = (byte)num4;
				num6 = 27;
				goto IL_03b7;
			case 17:
				array2[4] = 169;
				num2 = 371;
				continue;
			case 325:
				num3 = 71 + 56;
				num2 = 273;
				continue;
			case 356:
				array8 = array;
				num = 271;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 132;
			case 132:
				array2[28] = 41;
				num2 = 369;
				continue;
			case 165:
				num4 = 84 + 32;
				num6 = 66;
				goto IL_03b7;
			case 310:
				num4 = 59 + 34;
				num = 218;
				goto IL_03bb;
			case 373:
				num18++;
				num = 111;
				goto IL_03bb;
			case 16:
				num4 = 222 - 74;
				num = 199;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 179;
			case 179:
				array2[13] = (byte)num4;
				num2 = 19;
				continue;
			case 81:
				array2[19] = (byte)num4;
				num2 = 230;
				continue;
			case 150:
				array2[4] = 143;
				num2 = 17;
				continue;
			case 278:
				array2[24] = 158;
				num6 = 83;
				goto IL_03b7;
			case 340:
				array[1] = 103;
				num2 = 283;
				continue;
			case 374:
				array[11] = 169;
				num6 = 363;
				goto IL_03b7;
			case 101:
				array3[num7 + 1] = (byte)((num8 & 0xFF00) >> 8);
				num = 375;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 201;
			case 260:
				num3 = 161 - 53;
				num = 351;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 147;
			case 42:
				array2[0] = 106;
				num6 = 243;
				goto IL_03b7;
			case 275:
				array2[28] = (byte)num4;
				num = 29;
				goto IL_03bb;
			case 146:
				num4 = 44 - 7;
				num2 = 339;
				continue;
			case 87:
				array[7] = 196;
				num2 = 323;
				continue;
			case 10:
				array4 = array6;
				num6 = 348;
				goto IL_03b7;
			case 234:
				num4 = 0 + 66;
				num = 47;
				goto IL_03bb;
			case 209:
				num3 = 237 - 79;
				num2 = 161;
				continue;
			case 62:
				binaryReader = new BinaryReader((Stream)zAfNcb3VwlCLcVgkxZ(d2boo4TpT2CVJ0NykG(typeof(ajb1k2nt7TG3bU18v9).TypeHandle).Assembly, ajb1k2nt7TG3bU18v9.TYtDTyAefV(85028)));
				num = 368;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 139;
			case 139:
				array2[30] = 164;
				num = 140;
				goto IL_03bb;
			case 293:
				num3 = 73 + 119;
				num6 = 89;
				goto IL_03b7;
			case 30:
				array2[25] = (byte)num4;
				num2 = 213;
				continue;
			case 235:
				num4 = 70 + 47;
				num2 = 37;
				continue;
			case 258:
				num15 += num16;
				num2 = 286;
				continue;
			case 68:
				array2[12] = (byte)num4;
				num2 = 263;
				continue;
			case 169:
				array2[29] = (byte)num4;
				num2 = 54;
				continue;
			case 70:
				array[10] = 72;
				num = 137;
				goto IL_03bb;
			case 3:
				num3 = 114 - 10;
				num2 = 94;
				continue;
			case 161:
				array[1] = (byte)num3;
				num = 336;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 329;
			case 329:
				array2[2] = (byte)num4;
				num6 = 86;
				goto IL_03b7;
			case 307:
				array[13] = 134;
				num6 = 322;
				goto IL_03b7;
			case 296:
				array2[27] = 188;
				num = 248;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 380;
			case 276:
				array2[16] = 166;
				num = 153;
				goto IL_03bb;
			case 104:
				num4 = 20 + 106;
				num2 = 76;
				continue;
			case 21:
				num4 = 46 - 14;
				num2 = 68;
				continue;
			case 317:
				array2[11] = 171;
				num = 9;
				goto IL_03bb;
			case 113:
				array3 = new byte[array4.Length];
				num2 = 95;
				continue;
			case 371:
				num4 = 204 + 30;
				num6 = 159;
				goto IL_03b7;
			case 261:
				array3[num7 + num14] = (byte)((num23 & num19) >> num10);
				num6 = 216;
				goto IL_03b7;
			case 263:
				num4 = 125 - 41;
				num = 44;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 97;
			case 97:
				array2[8] = (byte)num4;
				num2 = 75;
				continue;
			case 237:
				array[5] = (byte)num3;
				num2 = 392;
				continue;
			case 250:
				array2[26] = (byte)num4;
				num6 = 296;
				goto IL_03b7;
			case 72:
				array2[24] = (byte)num4;
				num2 = 56;
				continue;
			case 228:
				num4 = 154 + 43;
				num = 124;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 19;
			case 19:
				num4 = 16 + 123;
				num2 = 359;
				continue;
			case 12:
				num4 = 59 + 102;
				num = 50;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 322;
			case 322:
				array[13] = 155;
				num = 362;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 301;
			case 301:
				array2[31] = (byte)num4;
				num2 = 343;
				continue;
			case 252:
				num3 = 129 - 49;
				num2 = 386;
				continue;
			case 65:
				array2[2] = (byte)num4;
				num2 = 77;
				continue;
			case 397:
				num4 = 207 - 69;
				num6 = 318;
				goto IL_03b7;
			case 232:
				anmYZ1yC1o = true;
				num6 = 404;
				goto IL_03b7;
			case 201:
				array2[22] = (byte)num4;
				num = 194;
				goto IL_03bb;
			case 394:
				num16 = (uint)((array7[num22 + 3] << 24) | (array7[num22 + 2] << 16) | (array7[num22 + 1] << 8) | array7[num22]);
				num = 401;
				goto IL_03bb;
			case 193:
				if (num9 > 0)
				{
					num = 373;
					if (!u6fWuorJP3LRGAxWBS())
					{
						goto IL_03bb;
					}
					goto case 112;
				}
				goto case 111;
			case 128:
				array2[0] = 86;
				num6 = 191;
				goto IL_03b7;
			case 245:
				array2[20] = (byte)num4;
				num2 = 396;
				continue;
			case 242:
				array2[8] = (byte)num4;
				num = 345;
				goto IL_03bb;
			case 289:
				array[2] = 164;
				num6 = 73;
				goto IL_03b7;
			case 143:
				array[5] = (byte)num3;
				num6 = 57;
				goto IL_03b7;
			case 141:
				array[2] = 109;
				num = 289;
				goto IL_03bb;
			case 240:
			case 314:
				if (num5 >= num18)
				{
					num6 = 82;
					goto IL_03b7;
				}
				num21 = num5 % num20;
				num = 354;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 85;
			case 281:
				num15 = 255u;
				num2 = 148;
				continue;
			case 11:
				array2[27] = (byte)num4;
				num = 365;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 400;
			case 400:
				array[6] = 160;
				num2 = 391;
				continue;
			case 225:
				array7 = array2;
				num6 = 214;
				goto IL_03b7;
			case 284:
				num4 = 221 - 73;
				num2 = 72;
				continue;
			case 137:
				array[10] = 159;
				num = 227;
				goto IL_03bb;
			case 142:
				num4 = 198 - 66;
				num = 35;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 28;
			case 220:
				num3 = 200 - 66;
				num = 210;
				goto IL_03bb;
			case 4:
			case 99:
				num4 = 218 - 72;
				num6 = 384;
				goto IL_03b7;
			case 213:
				array2[25] = 143;
				num6 = 228;
				goto IL_03b7;
			case 215:
				if (num9 > 0)
				{
					num = 254;
					if (gCV1W975YZX86lT0Rj())
					{
						goto IL_03bb;
					}
					goto case 150;
				}
				goto IL_2315;
			case 66:
				array2[10] = (byte)num4;
				num2 = 234;
				continue;
			case 286:
				num13 = 0;
				num = 152;
				goto IL_03bb;
			case 13:
				array2[19] = 108;
				num6 = 303;
				goto IL_03b7;
			case 300:
				array3[num7 + 3] = (byte)((num8 & 0xFF000000u) >> 24);
				num6 = 129;
				goto IL_03b7;
			case 353:
				num4 = 138 - 46;
				num = 81;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 170;
			case 170:
				array[14] = 132;
				num2 = 327;
				continue;
			case 206:
				array[0] = (byte)num3;
				num6 = 340;
				goto IL_03b7;
			case 6:
				array2[24] = 100;
				num2 = 278;
				continue;
			case 124:
				goto IL_260c;
			case 248:
				goto IL_2629;
			case 75:
				array2[8] = 112;
				num2 = 12;
				continue;
			case 54:
				num4 = 233 - 77;
				num2 = 110;
				continue;
			case 18:
				num3 = 12 + 83;
				num = 100;
				goto IL_03bb;
			case 186:
				array2[28] = 106;
				num2 = 381;
				continue;
			case 382:
				array[5] = (byte)num3;
				num6 = 121;
				goto IL_03b7;
			case 125:
				array[3] = (byte)num3;
				num = 274;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 176;
			case 176:
				array[11] = (byte)num3;
				num6 = 252;
				goto IL_03b7;
			case 351:
				array[8] = (byte)num3;
				num2 = 350;
				continue;
			case 29:
				num4 = 99 + 97;
				num6 = 116;
				goto IL_03b7;
			case 332:
				array2[10] = (byte)num4;
				num = 372;
				goto IL_03bb;
			case 313:
				num10 += 8;
				num6 = 261;
				goto IL_03b7;
			case 292:
				num12++;
				num = 402;
				goto IL_03bb;
			case 344:
				if (!anmYZ1yC1o)
				{
					num = 62;
					goto IL_03bb;
				}
				return;
			case 174:
				num19 <<= 8;
				num6 = 313;
				goto IL_03b7;
			case 155:
				num3 = 92 + 41;
				num = 319;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 290;
			case 290:
				num3 = 113 + 33;
				num = 172;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 47;
			case 47:
				array2[10] = (byte)num4;
				num6 = 98;
				goto IL_03b7;
			case 158:
				if (num5 == num18 - 1)
				{
					num = 226;
					goto IL_03bb;
				}
				goto IL_24c5;
			case 163:
				num3 = 249 - 83;
				num = 60;
				goto IL_03bb;
			case 159:
				array2[4] = (byte)num4;
				num6 = 255;
				goto IL_03b7;
			case 389:
				num4 = 116 + 113;
				num6 = 166;
				goto IL_03b7;
			case 192:
				array2[23] = 96;
				num6 = 78;
				goto IL_03b7;
			case 333:
				array2 = new byte[32];
				num = 42;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 272;
			case 272:
				num15 = num17;
				num = 158;
				goto IL_03bb;
			case 138:
				num15 += num16;
				num2 = 64;
				continue;
			case 326:
				num4 = 167 + 38;
				num6 = 212;
				goto IL_03b7;
			case 244:
				array2[27] = 84;
				num2 = 146;
				continue;
			case 354:
				num7 = num5 * 4;
				num6 = 349;
				goto IL_03b7;
			case 121:
				num3 = 96 + 3;
				num2 = 237;
				continue;
			case 93:
				array2[1] = (byte)num4;
				num = 22;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 240;
			case 85:
				num4 = 24 + 114;
				num = 316;
				goto IL_03bb;
			case 187:
			case 358:
				if (num14 < num9)
				{
					if (num14 > 0)
					{
						num = 174;
						if (gCV1W975YZX86lT0Rj())
						{
							goto IL_03bb;
						}
						goto case 34;
					}
					goto case 261;
				}
				num6 = 224;
				goto IL_03b7;
			case 279:
				num4 = 62 + 48;
				num2 = 366;
				continue;
			case 182:
				array2[12] = (byte)num4;
				num = 311;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 393;
			case 393:
				array2[20] = (byte)num4;
				num = 127;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 107;
			case 107:
				array[12] = 158;
				num6 = 207;
				goto IL_03b7;
			case 188:
				array[15] = (byte)num3;
				num2 = 108;
				continue;
			case 200:
				array2[14] = 142;
				num = 14;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 191;
			case 191:
				array2[0] = 107;
				num6 = 321;
				goto IL_03b7;
			case 383:
				num3 = 141 - 47;
				num2 = 382;
				continue;
			case 157:
				array2[22] = 155;
				num2 = 346;
				continue;
			case 380:
			case 402:
				if (num12 < array8.Length)
				{
					array7[num12] ^= array8[num12];
					num6 = 292;
					goto IL_03b7;
				}
				num2 = 10;
				continue;
			case 144:
				array[5] = 150;
				num2 = 383;
				continue;
			case 214:
				array = new byte[16];
				num = 306;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 30;
			case 298:
				array2[15] = 127;
				num6 = 233;
				goto IL_03b7;
			case 117:
				array[11] = (byte)num3;
				num6 = 374;
				goto IL_03b7;
			case 57:
				num3 = 163 - 54;
				num = 2;
				goto IL_03bb;
			case 14:
				array2[14] = 122;
				num = 154;
				goto IL_03bb;
			case 109:
				array2[6] = (byte)num4;
				num = 183;
				goto IL_03bb;
			case 151:
				num4 = 171 - 57;
				num = 267;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 227;
			case 227:
				array[10] = 146;
				num6 = 290;
				goto IL_03b7;
			case 55:
				num4 = 28 - 20;
				num = 304;
				goto IL_03bb;
			case 162:
				num4 = 141 - 47;
				num = 109;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 23;
			case 23:
				array2[15] = 235;
				num6 = 61;
				goto IL_03b7;
			case 365:
				num4 = 195 - 65;
				num6 = 338;
				goto IL_03b7;
			case 320:
				num3 = 154 - 32;
				num2 = 246;
				continue;
			case 226:
				if (num9 > 0)
				{
					num2 = 80;
					continue;
				}
				goto IL_24c5;
			case 56:
				num4 = 53 + 40;
				num6 = 1;
				goto IL_03b7;
			case 43:
				array[9] = (byte)num3;
				num2 = 328;
				continue;
			case 35:
				array2[20] = (byte)num4;
				num2 = 105;
				continue;
			case 135:
			case 152:
				if (num13 < num9)
				{
					if (num13 <= 0)
					{
						goto case 266;
					}
					num = 49;
					if (!gCV1W975YZX86lT0Rj())
					{
						goto case 187;
					}
				}
				else
				{
					num = 299;
					if (!gCV1W975YZX86lT0Rj())
					{
						goto case 80;
					}
				}
				goto IL_03bb;
			case 269:
				array2[11] = 118;
				num6 = 317;
				goto IL_03b7;
			case 61:
				num4 = 174 - 58;
				num = 334;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 88;
			case 88:
				array2[7] = (byte)num4;
				num6 = 48;
				goto IL_03b7;
			case 39:
				array2[10] = 119;
				num2 = 312;
				continue;
			case 267:
				array2[8] = (byte)num4;
				num6 = 223;
				goto IL_03b7;
			case 51:
				array2[3] = 124;
				num2 = 326;
				continue;
			case 316:
				array2[26] = (byte)num4;
				num = 302;
				goto IL_03bb;
			case 370:
				num4 = 28 + 54;
				num = 221;
				goto IL_03bb;
			case 311:
				array2[12] = 168;
				num = 310;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 322;
			case 86:
				num4 = 218 + 15;
				num = 65;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 31;
			case 31:
				array2[18] = 122;
				num = 388;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 170;
			case 129:
			case 224:
				num5++;
				num = 314;
				if (!gCV1W975YZX86lT0Rj())
				{
					goto case 164;
				}
				goto IL_03bb;
			case 392:
				num3 = 58 + 13;
				num = 198;
				goto IL_03bb;
			case 309:
				array2[5] = 46;
				num2 = 397;
				continue;
			case 185:
			case 291:
				num3 = 125 - 41;
				num2 = 222;
				continue;
			case 270:
				array5 = new byte[0];
				num2 = 390;
				continue;
			case 58:
				num4 = 150 - 78;
				num = 181;
				goto IL_03bb;
			case 156:
				array2[3] = (byte)num4;
				num = 51;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 271;
			case 271:
				num12 = 0;
				num2 = 380;
				continue;
			case 381:
				num4 = 91 + 106;
				num = 189;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 302;
			case 302:
				array2[26] = 182;
				num6 = 341;
				goto IL_03b7;
			case 219:
				num3 = 111 + 61;
				num6 = 143;
				goto IL_03b7;
			case 375:
				array3[num7 + 2] = (byte)((num8 & 0xFF0000) >> 16);
				num = 300;
				goto IL_03bb;
			case 44:
				array2[13] = (byte)num4;
				num = 24;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 10;
			case 67:
				num4 = 242 - 80;
				num6 = 79;
				goto IL_03b7;
			case 38:
				array[8] = 120;
				num6 = 320;
				goto IL_03b7;
			case 102:
				array[4] = (byte)num3;
				num2 = 164;
				continue;
			case 94:
				array[7] = (byte)num3;
				num6 = 260;
				goto IL_03b7;
			case 221:
				array2[9] = (byte)num4;
				num6 = 197;
				goto IL_03b7;
			case 336:
				array[1] = 140;
				num2 = 134;
				continue;
			case 262:
				array2[31] = 21;
				num = 225;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 127;
			case 127:
				array2[20] = 85;
				num = 268;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 49;
			case 49:
				num11 <<= 8;
				num6 = 266;
				goto IL_03b7;
			case 364:
				array[3] = 106;
				num = 264;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 360;
			case 360:
				array2[7] = 52;
				num6 = 84;
				goto IL_03b7;
			case 15:
				num10 = 0;
				num = 403;
				goto IL_03bb;
			case 348:
				num9 = array4.Length % 4;
				num2 = 53;
				continue;
			case 304:
				array2[17] = (byte)num4;
				num2 = 330;
				continue;
			case 116:
				array2[29] = (byte)num4;
				num = 16;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 79;
			case 79:
				array2[29] = (byte)num4;
				num6 = 36;
				goto IL_03b7;
			case 341:
				num4 = 96 + 89;
				num = 250;
				goto IL_03bb;
			case 32:
				array[14] = 25;
				num6 = 253;
				goto IL_03b7;
			case 357:
				array2[16] = (byte)num4;
				num6 = 277;
				goto IL_03b7;
			case 69:
				num4 = 236 - 78;
				num6 = 30;
				goto IL_03b7;
			case 37:
				array2[21] = (byte)num4;
				num = 5;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 346;
			case 346:
				num4 = 33 - 32;
				num = 201;
				goto IL_03bb;
			case 282:
				array2[28] = 154;
				num = 132;
				if (!gCV1W975YZX86lT0Rj())
				{
					goto case 287;
				}
				goto IL_03bb;
			case 223:
				array2[8] = 133;
				num6 = 265;
				goto IL_03b7;
			case 339:
				array2[27] = (byte)num4;
				num2 = 378;
				continue;
			case 41:
				array2[14] = (byte)num4;
				num6 = 298;
				goto IL_03b7;
			case 288:
				array2[28] = (byte)num4;
				num = 186;
				if (u6fWuorJP3LRGAxWBS())
				{
					goto case 287;
				}
				goto IL_03bb;
			case 362:
				array[13] = 224;
				num = 33;
				goto IL_03bb;
			case 167:
				num3 = 225 - 75;
				num = 130;
				if (gCV1W975YZX86lT0Rj())
				{
					goto IL_03bb;
				}
				goto case 386;
			case 114:
				num4 = 23 + 44;
				num = 208;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 178;
			case 178:
				array3[num7] = (byte)(num8 & 0xFF);
				num = 101;
				goto IL_03bb;
			case 173:
				num3 = 107 + 80;
				num6 = 43;
				goto IL_03b7;
			case 74:
				num3 = 205 - 68;
				num = 90;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 105;
			case 105:
				num4 = 22 + 3;
				num6 = 393;
				goto IL_03b7;
			case 331:
				num3 = 34 + 68;
				num2 = 188;
				continue;
			case 273:
				array[7] = (byte)num3;
				num2 = 122;
				continue;
			case 246:
				array[8] = (byte)num3;
				goto case 185;
			case 352:
				array[0] = (byte)num3;
				num6 = 259;
				goto IL_03b7;
			case 0:
				num4 = 136 - 102;
				num = 335;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 78;
			case 78:
				num4 = 110 - 73;
				num = 34;
				goto IL_03bb;
			case 111:
				num22 = 0u;
				num = 203;
				if (true)
				{
					goto IL_03bb;
				}
				goto case 391;
			case 391:
				array[6] = 101;
				num6 = 399;
				goto IL_03b7;
			case 22:
				array2[2] = 102;
				num = 211;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 108;
			case 203:
				num5 = 0;
				num2 = 240;
				continue;
			case 212:
				array2[3] = (byte)num4;
				num = 150;
				goto IL_03bb;
			case 387:
				array[6] = (byte)num3;
				num = 325;
				if (!u6fWuorJP3LRGAxWBS())
				{
					goto IL_03bb;
				}
				goto case 138;
			case 238:
				array[12] = (byte)num3;
				num2 = 293;
				continue;
			case 404:
				return;
				IL_24c5:
				num8 = num15 ^ num11;
				num = 178;
				if (0 == 0)
				{
					goto IL_03bb;
				}
				goto case 4;
				IL_03b7:
				num = num6;
				goto IL_03bb;
				IL_2315:
				num22 = (uint)num7;
				num6 = 138;
				goto IL_03b7;
			}
			break;
		}
		goto IL_001d;
		IL_2629:
		array2[27] = 118;
		num2 = 195;
		goto IL_03bf;
		IL_260c:
		array2[25] = (byte)num4;
		num = 257;
		if (true)
		{
			goto IL_03bb;
		}
		goto IL_2629;
		IL_001d:
		num3 = 124 + 5;
		num = 117;
		if (!u6fWuorJP3LRGAxWBS())
		{
			goto IL_03bb;
		}
		goto IL_260c;
		IL_03bb:
		num2 = num;
		goto IL_03bf;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string[] bMUYkxBsYl(Assembly P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if ((object)P_0 == Type.GetTypeFromHandle(pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(33554639)).Assembly)
		{
			if (!anmYZ1yC1o)
			{
				Y2nY9im4qZ();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)t33YJkxC9v).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly k4bYQdkRDr(object P_0, ResolveEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!anmYZ1yC1o)
		{
			Y2nY9im4qZ();
		}
		string name = P_1.Name;
		for (int i = 0; i < pU5YsrlZSW.Length; i++)
		{
			if (pU5YsrlZSW[i] == name)
			{
				return (Assembly)t33YJkxC9v;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IUPeb2cd94GT7UacF9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base._002Ector();
		AppDomain.CurrentDomain.ResourceResolve += k4bYQdkRDr;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!i3bY5EcIuI)
		{
			i3bY5EcIuI = true;
			new IUPeb2cd94GT7UacF9();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IUPeb2cd94GT7UacF9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pU5YsrlZSW = new string[0];
		t33YJkxC9v = null;
		anmYZ1yC1o = false;
		i3bY5EcIuI = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type d2boo4TpT2CVJ0NykG(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zAfNcb3VwlCLcVgkxZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H2ovUUMt7xkbVcflO4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).BaseStream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VEEUt9DkYR6l0MBlpX(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long K3WGMvbfbYk0LkrPI5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M6GTguByQ5LjbDqVmc(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z07SCSJFvHdVXS1w6A(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return C9DSh9l5uawJWd8vaR.FTwYq3ciUG((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CNWug3H3SEem2Qdg0q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return C9DSh9l5uawJWd8vaR.r7uYX7ygcj((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hyZm4v0t56x1iL0dgX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gCV1W975YZX86lT0Rj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u6fWuorJP3LRGAxWBS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
