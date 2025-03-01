using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using fCq6WfrEDILJ63bcvr;
using j1OFGCoCY8sWgQrYi8;
using Microsoft.Win32;
using ReBot;
using ReBot.Classes;
using zoxFr96uALPVfCJPYS;

namespace v5B2xLE6I3MJEapV5x;

internal static class NTChBG30n4Hb5KiU91
{
	internal static bool R3Kq4WVLvi;

	internal static bool z7fqnu7FEk;

	internal static bool eOuqwc85UH;

	internal static string Is6quYZ2Kc;

	[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DETqF2JH2L(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	private static void TTFqeumO9O(string[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IUPeb2cd94GT7UacF9.kLjw4iIsCLsZtxc4lksN0j();
		try
		{
			bool createdNew = true;
			string name = rCNqAxSnXi();
			using (new Mutex(initiallyOwned: true, name, out createdNew))
			{
				if (createdNew)
				{
					goto IL_004c;
				}
				int num;
				Process currentProcess = default(Process);
				if (P_0.Length != 0)
				{
					num = 7;
				}
				else
				{
					currentProcess = Process.GetCurrentProcess();
					num = 6;
				}
				goto IL_016f;
				IL_0152:
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(defaultValue: false);
				goto IL_00ac;
				IL_011e:
				if (P_0.Length != 0)
				{
					goto IL_0135;
				}
				goto IL_0152;
				IL_00e0:
				if (P_0.Length == 0 || !P_0[0].Contains(ajb1k2nt7TG3bU18v9.TYtDTyAefV(11326)))
				{
					goto IL_011e;
				}
				R3Kq4WVLvi = true;
				eBOFdxOQqLx6xPR4up9();
				num = (lnuFmdOUk0JLxquHJOT() ? 9 : 10);
				goto IL_016f;
				IL_016f:
				Process[] processesByName = default(Process[]);
				int num2 = default(int);
				Process process = default(Process);
				while (true)
				{
					switch (num)
					{
					case 0:
						z7fqnu7FEk = true;
						num = 2;
						continue;
					case 7:
						break;
					case 6:
						processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
						num2 = 0;
						goto case 11;
					case 5:
						goto IL_00ac;
					case 1:
						return;
					case 2:
						goto IL_00e0;
					case 3:
					case 10:
						goto IL_011e;
					case 4:
					case 9:
						goto IL_0135;
					default:
						num = 5;
						continue;
					case 8:
						if (process.MainModule.FileName == currentProcess.MainModule.FileName)
						{
							DETqF2JH2L(process.MainWindowHandle);
							return;
						}
						goto IL_01e1;
					case 11:
						{
							if (num2 < processesByName.Length)
							{
								process = processesByName[num2];
								if (process.Id != currentProcess.Id)
								{
									num = 8;
									continue;
								}
								goto IL_01e1;
							}
							return;
						}
						IL_01e1:
						num2++;
						num = 11;
						continue;
					}
					break;
				}
				goto IL_004c;
				IL_0135:
				if (P_0[0].Contains(ajb1k2nt7TG3bU18v9.TYtDTyAefV(38952)))
				{
					eOuqwc85UH = true;
				}
				goto IL_0152;
				IL_00ac:
				fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
				Application.Run(new global::ReBot.ReBot());
				num = 1;
				if (!eBOFdxOQqLx6xPR4up9())
				{
					return;
				}
				goto IL_016f;
				IL_004c:
				if (P_0.Length == 0 || !P_0[0].Contains(ajb1k2nt7TG3bU18v9.TYtDTyAefV(11308)))
				{
					goto IL_00e0;
				}
				num = 0;
				goto IL_016f;
			}
		}
		catch (Exception)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private static string rCNqAxSnXi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			using MD5 mD = MD5.Create();
			return (string)viJmCwOOg7fbG1VECXn(mD, yl2pn9OvUrVH97TyYeF(sBNfROOZNfiToepc6JS(EZRiTOOrulZvSiTVO5b())));
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string tHyqdJlL1E(MD5 P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0067;
		IL_001a:
		byte[] array = (byte[])dDtmf2OxTQyjrkeBXdd(P_0, xBsAxOOFdT8JddOsiY8(U8TWstOEeqB5Xu7jgOb(), P_1));
		num = 5;
		if (lnuFmdOUk0JLxquHJOT())
		{
		}
		goto IL_0067;
		IL_0067:
		int num2 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				if (num2 >= array.Length)
				{
					num = 7;
					continue;
				}
				stringBuilder.Append(array[num2].ToString(ajb1k2nt7TG3bU18v9.TYtDTyAefV(9910)));
				num2++;
				num = 0;
				continue;
			case 2:
			case 6:
				num2 = 0;
				goto default;
			case 5:
				stringBuilder = new StringBuilder();
				lnuFmdOUk0JLxquHJOT();
				num = ((!eBOFdxOQqLx6xPR4up9()) ? 1 : 6);
				continue;
			case 7:
				return stringBuilder.ToString();
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void lW2qmBB1eF(string P_0, string P_1, uint P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey((string)bSfeSIOuOSMreqvUi49(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81434), P_0), RegistryKeyPermissionCheck.ReadWriteSubTree);
			try
			{
				registryKey.SetValue(P_1, P_2, RegistryValueKind.DWord);
			}
			finally
			{
				if (registryKey != null)
				{
					kuL0hFOeWvDUdQZESpw(registryKey);
				}
			}
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey((string)et5YiGO0U2uCc9MVSW8(81552) + P_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			try
			{
				jWnGONOGEJLTL5Q4hUq(registryKey2, P_1, P_2, RegistryValueKind.DWord);
			}
			finally
			{
				if (registryKey2 != null)
				{
					kuL0hFOeWvDUdQZESpw(registryKey2);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sBAqPihq0F(string P_0, string P_1, uint P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			using RegistryKey registryKey = LYkMp8Oq8nmtJH9sFOr(Registry.CurrentUser, (string)et5YiGO0U2uCc9MVSW8(81694) + P_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(P_1, P_2, RegistryValueKind.DWord);
		}
		catch (Exception)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aM0q39vshN(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey((string)bSfeSIOuOSMreqvUi49(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81694), P_0), RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null && rS9EA7OlWFicr7fSmJe(registryKey, P_1) != null)
		{
			zguDvJOw3AMiYqigouj(registryKey, P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VgrqxNZY36(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RegistryKey registryKey = (RegistryKey)K0cX7vOtoKfPSClKZk4(Registry.CurrentUser, bSfeSIOuOSMreqvUi49(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81694), P_0), RegistryKeyPermissionCheck.ReadWriteSubTree);
		object result = default(object);
		try
		{
			if (registryKey != null && rS9EA7OlWFicr7fSmJe(registryKey, P_1) != null)
			{
				_ = 0;
				int num;
				if (eBOFdxOQqLx6xPR4up9())
				{
					num = 2;
					if (lnuFmdOUk0JLxquHJOT())
					{
						goto IL_0058;
					}
				}
				else
				{
					num = 3;
				}
				switch (num)
				{
				case 0:
				case 2:
					break;
				default:
					goto end_IL_002a;
				case 3:
					goto end_IL_002a;
				}
				goto IL_0058;
			}
			result = null;
			return result;
			IL_0058:
			result = rS9EA7OlWFicr7fSmJe(registryKey, P_1);
			return result;
			end_IL_002a:;
		}
		finally
		{
			if (registryKey != null)
			{
				kuL0hFOeWvDUdQZESpw(registryKey);
			}
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void qKkqEOlI98(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (lnuFmdOUk0JLxquHJOT() ? 3 : 2);
		RegistryKey registryKey = default(RegistryKey);
		RegistryKey registryKey2 = default(RegistryKey);
		do
		{
			switch (num)
			{
			case 0:
			case 2:
				registryKey = Registry.CurrentUser.OpenSubKey((string)et5YiGO0U2uCc9MVSW8(81434) + P_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
				goto case 1;
			case 1:
			case 3:
				try
				{
					if (registryKey != null && registryKey.GetValue(P_1) != null)
					{
						registryKey.DeleteValue(P_1);
					}
				}
				finally
				{
					if (registryKey != null)
					{
						kuL0hFOeWvDUdQZESpw(registryKey);
					}
				}
				registryKey2 = (RegistryKey)K0cX7vOtoKfPSClKZk4(Registry.CurrentUser, (string)et5YiGO0U2uCc9MVSW8(81552) + P_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
				break;
			default:
				goto IL_00c2;
			case 4:
				break;
			}
			break;
			IL_00c2:
			num = 4;
		}
		while (!lnuFmdOUk0JLxquHJOT());
		try
		{
			if (registryKey2 != null && rS9EA7OlWFicr7fSmJe(registryKey2, P_1) != null)
			{
				zguDvJOw3AMiYqigouj(registryKey2, P_1);
			}
		}
		finally
		{
			((IDisposable)registryKey2)?.Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void zc7q0NrBaE(bool P_0 = true, CheckedListBox P_1 = null, uint? P_2 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<string> list = new List<string>();
		if (P_1 != null)
		{
			for (int i = 0; i < P_1.CheckedItems.Count; i++)
			{
				list.Add(P_1.CheckedItems[i].ToString().GetUntilOrEmpty(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81746)));
			}
		}
		Dictionary<string, uint> dictionary = new Dictionary<string, uint>();
		if (P_0)
		{
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81752), FshqGAc5xw(P_2));
		}
		else
		{
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81752), FshqGAc5xw(P_2));
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81806), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81868), 6u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81940), 6u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81990), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82074), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82148), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82188), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82234), 0u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82314), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82386), 0u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82448), 0u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82500), 0u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82552), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82622), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82682), 0u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82728), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82790), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82840), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82902), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(82960), 0u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83022), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83080), 0u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83132), 1u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83170), 0u);
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83228), 1u);
		}
		string fileName = Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);
		if (string.Compare(fileName, ajb1k2nt7TG3bU18v9.TYtDTyAefV(83262), ignoreCase: true) == 0 || string.Compare(fileName, ajb1k2nt7TG3bU18v9.TYtDTyAefV(83286), ignoreCase: true) == 0)
		{
			return;
		}
		foreach (KeyValuePair<string, uint> item in dictionary)
		{
			if (P_0)
			{
				if (P_1 == null || list.Contains(item.Key.Replace(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83314), "")))
				{
					lW2qmBB1eF(item.Key, fileName, item.Value);
				}
			}
			else
			{
				qKkqEOlI98(item.Key, fileName);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint FshqGAc5xw(uint? P_0 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int result = 7;
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83334), RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.QueryValues))
		{
			object value = registryKey.GetValue(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83410));
			if (value == null)
			{
				value = registryKey.GetValue(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83434));
				if (value == null)
				{
					throw new ApplicationException(ajb1k2nt7TG3bU18v9.TYtDTyAefV(83452));
				}
			}
			int.TryParse(value.ToString().Split('.')[0], out result);
		}
		uint result2 = ((!P_0.HasValue) ? 11001u : P_0.Value);
		switch (result)
		{
		case 7:
			result2 = 7000u;
			break;
		case 8:
			result2 = 8000u;
			break;
		case 9:
			result2 = 9000u;
			break;
		case 10:
			result2 = 10000u;
			break;
		}
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NTChBG30n4Hb5KiU91()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 1:
				IUPeb2cd94GT7UacF9.kLjw4iIsCLsZtxc4lksN0j();
				num = 0;
				break;
			case 2:
			case 4:
				z7fqnu7FEk = false;
				goto default;
			default:
				eOuqwc85UH = false;
				Is6quYZ2Kc = Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);
				num = 6;
				break;
			case 0:
				R3Kq4WVLvi = false;
				eBOFdxOQqLx6xPR4up9();
				if (lnuFmdOUk0JLxquHJOT())
				{
					num = 5;
					if (true)
					{
						break;
					}
					goto default;
				}
				num = 4;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eBOFdxOQqLx6xPR4up9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lnuFmdOUk0JLxquHJOT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EZRiTOOrulZvSiTVO5b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Process.GetCurrentProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sBNfROOZNfiToepc6JS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Process)P_0).MainModule;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yl2pn9OvUrVH97TyYeF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ProcessModule)P_0).FileName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object viJmCwOOg7fbG1VECXn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return tHyqdJlL1E((MD5)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U8TWstOEeqB5Xu7jgOb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xBsAxOOFdT8JddOsiY8(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dDtmf2OxTQyjrkeBXdd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bSfeSIOuOSMreqvUi49(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kuL0hFOeWvDUdQZESpw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object et5YiGO0U2uCc9MVSW8(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jWnGONOGEJLTL5Q4hUq(object P_0, object P_1, object P_2, RegistryValueKind P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((RegistryKey)P_0).SetValue((string)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LYkMp8Oq8nmtJH9sFOr(object P_0, object P_1, RegistryKeyPermissionCheck P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RegistryKey)P_0).CreateSubKey((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rS9EA7OlWFicr7fSmJe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RegistryKey)P_0).GetValue((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zguDvJOw3AMiYqigouj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((RegistryKey)P_0).DeleteValue((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K0cX7vOtoKfPSClKZk4(object P_0, object P_1, RegistryKeyPermissionCheck P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RegistryKey)P_0).OpenSubKey((string)P_1, P_2);
	}
}
