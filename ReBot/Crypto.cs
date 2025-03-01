using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using fCq6WfrEDILJ63bcvr;
using zoxFr96uALPVfCJPYS;

namespace ReBot;

public class Crypto
{
	private static byte[] Vjp922xGed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string EncryptStringAES(string plainText, string sharedSecret)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!OhDPXFBfSKegGK1d0k()) ? 3 : 5);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		while (true)
		{
			switch (num)
			{
			case 4:
				throw new ArgumentNullException((string)xOed6IVedoDc0cgo2N(1064));
			case 0:
			case 5:
				if (!string.IsNullOrEmpty(plainText))
				{
					if (string.IsNullOrEmpty(sharedSecret))
					{
						goto case 2;
					}
					string text = null;
					goto case 1;
				}
				num = 4;
				break;
			case 2:
			case 3:
				throw new ArgumentNullException((string)xOed6IVedoDc0cgo2N(1086));
			default:
				num = 1;
				break;
			case 1:
				rijndaelManaged = null;
				num = 6;
				break;
			case 6:
				try
				{
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedSecret, Vjp922xGed);
					rijndaelManaged = new RijndaelManaged();
					wxbZNiD4Aj6DVHnyN1(rijndaelManaged, rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8));
					ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					MemoryStream memoryStream = new MemoryStream();
					try
					{
						memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
						LOyndPN7H6DcJ6OY63(memoryStream, Ui3tANRvmsgdplkHqE(rijndaelManaged), 0, rijndaelManaged.IV.Length);
						using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
						{
							using StreamWriter streamWriter = new StreamWriter(stream);
							streamWriter.Write(plainText);
						}
						return (string)CXmUajnsUlxhVplr9y(memoryStream.ToArray());
					}
					finally
					{
						if (memoryStream != null)
						{
							HBc64Fhl0q0oP9qePO(memoryStream);
						}
					}
				}
				finally
				{
					rijndaelManaged?.Clear();
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DecryptStringAES(string cipherText, string sharedSecret)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!OhDPXFBfSKegGK1d0k()) ? 5 : 4);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				if (aWVhRs8NZlGcJBnN8E(cipherText))
				{
					goto case 1;
				}
				if (!aWVhRs8NZlGcJBnN8E(sharedSecret))
				{
					rijndaelManaged = null;
					goto case 3;
				}
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 2:
				throw new ArgumentNullException(ajb1k2nt7TG3bU18v9.TYtDTyAefV(1086));
			default:
				num = 3;
				if (OhDPXFBfSKegGK1d0k())
				{
					continue;
				}
				goto case 3;
			case 3:
			{
				string text = null;
				num = 6;
				continue;
			}
			case 1:
			case 5:
				throw new ArgumentNullException(ajb1k2nt7TG3bU18v9.TYtDTyAefV(1114));
			case 6:
				break;
			}
			break;
		}
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedSecret, Vjp922xGed);
			MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cipherText));
			try
			{
				rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Key = (byte[])waEV9wPYSdU97Z1sHH(rfc2898DeriveBytes, nDjG6eab3oJxKOmKYE(rijndaelManaged) / 8);
				rijndaelManaged.IV = xBY91kceaJ(memoryStream);
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor((byte[])IgiWh4AGbX694vdsjP(rijndaelManaged), rijndaelManaged.IV);
				using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
				using StreamReader streamReader = new StreamReader(stream);
				return streamReader.ReadToEnd();
			}
			finally
			{
				if (memoryStream != null)
				{
					HBc64Fhl0q0oP9qePO(memoryStream);
				}
			}
		}
		catch (Exception ex)
		{
			dDVnjH1B16Jok7mKyN(ex.Message);
			throw;
		}
		finally
		{
			if (rijndaelManaged != null)
			{
				fGGj214Og0RKCIUoHM(rijndaelManaged);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] xBY91kceaJ(Stream P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (0 == 0)
		{
			byte[] array2 = default(byte[]);
			byte[] array = default(byte[]);
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					break;
				default:
					num = 3;
					continue;
				case 3:
					if (P_0.Read(array2, 0, array2.Length) != array2.Length)
					{
						num = 6;
						if (true)
						{
							continue;
						}
						goto case 1;
					}
					return array2;
				case 1:
				case 5:
					if (P_0.Read(array, 0, array.Length) == array.Length)
					{
						array2 = new byte[BitConverter.ToInt32(array, 0)];
						goto case 3;
					}
					break;
				case 0:
					array = new byte[4];
					_ = 1;
					if (p86ti75BMr4yTJpSEe())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					throw new SystemException(ajb1k2nt7TG3bU18v9.TYtDTyAefV(1246));
				}
				break;
			}
		}
		throw new SystemException((string)xOed6IVedoDc0cgo2N(1138));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crypto()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eeSVOqjD3K8a323JEO();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Crypto()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eeSVOqjD3K8a323JEO();
		Vjp922xGed = (byte[])t8EZwsmwTxSwWwqpaw(NgRxLOLSoyClt5tRPc(), xOed6IVedoDc0cgo2N(1314));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xOed6IVedoDc0cgo2N(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wxbZNiD4Aj6DVHnyN1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ui3tANRvmsgdplkHqE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SymmetricAlgorithm)P_0).IV;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LOyndPN7H6DcJ6OY63(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CXmUajnsUlxhVplr9y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToBase64String((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HBc64Fhl0q0oP9qePO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OhDPXFBfSKegGK1d0k()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p86ti75BMr4yTJpSEe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aWVhRs8NZlGcJBnN8E(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nDjG6eab3oJxKOmKYE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SymmetricAlgorithm)P_0).KeySize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object waEV9wPYSdU97Z1sHH(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DeriveBytes)P_0).GetBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IgiWh4AGbX694vdsjP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SymmetricAlgorithm)P_0).Key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dDVnjH1B16Jok7mKyN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Console.WriteLine((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fGGj214Og0RKCIUoHM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eeSVOqjD3K8a323JEO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NgRxLOLSoyClt5tRPc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.ASCII;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t8EZwsmwTxSwWwqpaw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetBytes((string)P_1);
	}
}
