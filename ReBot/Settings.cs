using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CUB0kCL30YeF2Gt7jr;
using fCq6WfrEDILJ63bcvr;
using zoxFr96uALPVfCJPYS;

namespace ReBot;

public class Settings
{
	public struct SectionPair : IComparable<SectionPair>
	{
		public string Section;

		public string Key;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CompareTo(SectionPair other)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Key.CompareTo(other.Key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ByKey(SectionPair key1, SectionPair key2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Lfy9KBFpPRTw3GHVqBy(key1.Key, key2.Key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eNhFf8F7Yp7ssx3sDcy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BVJb5HFKeka7ArALeRq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Lfy9KBFpPRTw3GHVqBy(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).CompareTo((string)P_1);
		}
	}

	public Hashtable keyPairs;

	private string PKMqICcmc9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Settings(string iniPath)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kEfnaEOWv3naWmJXwmA();
		int num = (YxMsKbOkPG5ksMfp7Ip() ? 7 : 5);
		string text2 = default(string);
		TextReader textReader = default(TextReader);
		SectionPair sectionPair = default(SectionPair);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 7:
				keyPairs = new Hashtable();
				LRYTpGO3EDgApGms4wK(this);
				num = 4;
				break;
			case 2:
				if (File.Exists(iniPath))
				{
					num = 8;
					break;
				}
				return;
			case 3:
			{
				string text = null;
				text2 = null;
				goto case 6;
			}
			default:
				num = 6;
				break;
			case 0:
			case 5:
				fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
				goto case 1;
			case 4:
				textReader = null;
				num = 3;
				if (!YxMsKbOkPG5ksMfp7Ip())
				{
					break;
				}
				goto case 6;
			case 6:
			{
				string[] array = null;
				PKMqICcmc9 = iniPath;
				num = 2;
				break;
			}
			case 8:
				try
				{
					textReader = new StreamReader(iniPath);
					for (string text = (string)zXm7hEOT3aMAhjkUktC(textReader); text != null; text = textReader.ReadLine())
					{
						text = (string)P1gZ7oOYOBAvtKxqQSG(text);
						if (text != "")
						{
							if (fJECMoOciyu93u3ddPX(text, QggOEwOSFxraO9NbKgS(17948)) && elLFU9O6KLaXCPWbxtT(text, ajb1k2nt7TG3bU18v9.TYtDTyAefV(29800)))
							{
								text2 = text.Substring(1, DCRruEObvkGMCHRlKNv(text) - 2);
							}
							else
							{
								string[] array = text.Split(new char[1] { '=' }, 2);
								string value = null;
								if (text2 == null)
								{
									text2 = ajb1k2nt7TG3bU18v9.TYtDTyAefV(83536);
								}
								sectionPair.Section = text2;
								sectionPair.Key = array[0];
								if (array.Length > 1)
								{
									value = array[1];
									keyPairs.Add(sectionPair, value);
								}
								else if (text2 == ajb1k2nt7TG3bU18v9.TYtDTyAefV(9126))
								{
									keyPairs.Add(sectionPair, value);
								}
							}
						}
					}
					return;
				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					if (textReader != null)
					{
						AXYbTvO78dAam0hEFPr(textReader);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string rs(string sectionName, string settingName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		SectionPair sectionPair = default(SectionPair);
		object obj;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				sectionName = ajb1k2nt7TG3bU18v9.TYtDTyAefV(83536);
				num = 5;
				if (kEfnaEOWv3naWmJXwmA())
				{
					continue;
				}
				goto case 5;
			case 5:
				sectionPair.Section = sectionName;
				goto default;
			case 0:
				if (qI7EGcOKEjIqxdPdYMU(sectionName, ""))
				{
					kEfnaEOWv3naWmJXwmA();
					num = ((!YxMsKbOkPG5ksMfp7Ip()) ? 2 : 4);
					continue;
				}
				goto case 5;
			default:
				sectionPair.Key = settingName;
				obj = (string)keyPairs[sectionPair];
				if (obj == null)
				{
					num = 6;
					continue;
				}
				break;
			case 6:
				obj = "";
				break;
			}
			break;
		}
		return (string)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string rs(string settingName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!YxMsKbOkPG5ksMfp7Ip()) ? 1 : 3);
		SectionPair sectionPair = default(SectionPair);
		object obj;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				sectionPair.Section = ajb1k2nt7TG3bU18v9.TYtDTyAefV(83536);
				num = 4;
				continue;
			default:
				obj = (string)keyPairs[sectionPair];
				if (obj == null)
				{
					num = 5;
					continue;
				}
				break;
			case 4:
				sectionPair.Key = settingName;
				goto default;
			case 5:
				obj = "";
				break;
			}
			break;
		}
		return (string)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetString(string settingName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return rs(settingName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] EnumSection(string sectionName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YxMsKbOkPG5ksMfp7Ip();
		int num;
		if (kEfnaEOWv3naWmJXwmA())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		ArrayList arrayList = default(ArrayList);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 2:
				arrayList = new ArrayList();
				break;
			case 4:
				goto IL_0086;
			}
			break;
		}
		goto IL_002a;
		IL_0086:
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			while (enumerator.MoveNext())
			{
				SectionPair sectionPair = (SectionPair)lUFbAcO2Ngftf1u2m2T(enumerator);
				kEfnaEOWv3naWmJXwmA();
				int num2 = (YxMsKbOkPG5ksMfp7Ip() ? 3 : 2);
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_00b1;
					case 0:
					case 2:
						if (sectionPair.Section == sectionName)
						{
							goto IL_00b1;
						}
						break;
					case 4:
						break;
					}
					break;
					IL_00b1:
					a8sQDbOgVuW91PI0uJS(arrayList, sectionPair.Key);
					num2 = 4;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				Oq333iOCdsnC61GJqF0(disposable);
			}
		}
		return (string[])arrayList.ToArray(Type.GetTypeFromHandle(HA5PNUOimjGHtXieYGh(16777225)));
		IL_002a:
		enumerator = ((IEnumerable)iNIGPLOpHB2PxFhYDJE(keyPairs)).GetEnumerator();
		goto IL_0086;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ws(string sectionName, string settingName, string settingValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		SectionPair sectionPair = default(SectionPair);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				sectionPair.Section = sectionName;
				sectionPair.Key = settingName;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				sectionName = ajb1k2nt7TG3bU18v9.TYtDTyAefV(83536);
				goto case 2;
			case 6:
				if (sectionName == "")
				{
					kEfnaEOWv3naWmJXwmA();
					num = ((!YxMsKbOkPG5ksMfp7Ip()) ? 5 : 4);
					continue;
				}
				goto case 2;
			case 3:
				if (keyPairs.ContainsKey(sectionPair))
				{
					num = 0;
					continue;
				}
				break;
			case 0:
				dwyn4tOMfU0t2tCmKtm(keyPairs, sectionPair);
				break;
			case 7:
				return;
			}
			keyPairs.Add(sectionPair, settingValue);
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ws(string sectionName, string settingName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ws(sectionName, settingName, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteSetting(string sectionName, string settingName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		SectionPair sectionPair = default(SectionPair);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				sectionPair.Key = settingName;
				num = 2;
				break;
			default:
				dwyn4tOMfU0t2tCmKtm(keyPairs, sectionPair);
				num = 6;
				break;
			case 2:
				if (qfpbCiOBsFmk0pq3d09(keyPairs, sectionPair))
				{
					goto default;
				}
				return;
			case 0:
				do
				{
					sectionPair.Section = sectionName;
					YxMsKbOkPG5ksMfp7Ip();
					if (!kEfnaEOWv3naWmJXwmA())
					{
						num = 5;
						continue;
					}
					num = 4;
					break;
				}
				while (YxMsKbOkPG5ksMfp7Ip());
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveSettings(string newFilePath = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (YxMsKbOkPG5ksMfp7Ip() ? 6 : 3);
		string text2 = default(string);
		IEnumerator enumerator = default(IEnumerator);
		ArrayList arrayList = default(ArrayList);
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 5:
				text2 = "";
				goto case 1;
			default:
				num = 1;
				continue;
			case 1:
				enumerator = (IEnumerator)rFsGMfO5t0glBQTyDt0(keyPairs.Keys);
				goto case 4;
			case 4:
			case 6:
				try
				{
					while (QNghUjOVlZcy5ZY93xe(enumerator))
					{
						SectionPair sectionPair = (SectionPair)lUFbAcO2Ngftf1u2m2T(enumerator);
						_ = 1;
						int num2 = (YxMsKbOkPG5ksMfp7Ip() ? 3 : 2);
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 2:
								if (!arrayList.Contains(sectionPair.Section))
								{
									goto IL_0101;
								}
								break;
							default:
								goto IL_0101;
							case 4:
								break;
							}
							break;
							IL_0101:
							a8sQDbOgVuW91PI0uJS(arrayList, sectionPair.Section);
							num2 = 4;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						disposable.Dispose();
					}
				}
				T2uH7tODsURhMNfli6R(arrayList);
				enumerator = arrayList.GetEnumerator();
				num = 7;
				continue;
			case 0:
			case 3:
				arrayList = new ArrayList();
				num = 2;
				continue;
			case 2:
				text = "";
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		try
		{
			while (enumerator.MoveNext())
			{
				string text3 = (string)lUFbAcO2Ngftf1u2m2T(enumerator);
				text2 = (string)YdyUYgORRsqwCFJGWfB(text2, ajb1k2nt7TG3bU18v9.TYtDTyAefV(17948), text3, ajb1k2nt7TG3bU18v9.TYtDTyAefV(26664));
				List<SectionPair> list = new List<SectionPair>();
				{
					IEnumerator enumerator2 = keyPairs.Keys.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							SectionPair item = (SectionPair)lUFbAcO2Ngftf1u2m2T(enumerator2);
							_ = 0;
							int num3 = ((!kEfnaEOWv3naWmJXwmA()) ? 3 : 2);
							while (true)
							{
								switch (num3)
								{
								default:
									goto IL_01ea;
								case 0:
								case 2:
									if (qI7EGcOKEjIqxdPdYMU(item.Section, text3))
									{
										goto IL_01ea;
									}
									break;
								case 4:
									break;
								}
								break;
								IL_01ea:
								list.Add(item);
								num3 = 4;
							}
						}
					}
					finally
					{
						IDisposable disposable3 = enumerator2 as IDisposable;
						if (disposable3 != null)
						{
							disposable3.Dispose();
						}
					}
				}
				list.Sort(SectionPair.ByKey);
				foreach (SectionPair item2 in list)
				{
					YxMsKbOkPG5ksMfp7Ip();
					int num4;
					if (kEfnaEOWv3naWmJXwmA())
					{
						num4 = 4;
						if (1 == 0)
						{
							goto IL_02ba;
						}
					}
					else
					{
						num4 = 3;
					}
					goto IL_0300;
					IL_02ba:
					text2 = text2 + item2.Key + text + ajb1k2nt7TG3bU18v9.TYtDTyAefV(21870);
					num4 = 5;
					goto IL_0300;
					IL_0300:
					while (true)
					{
						switch (num4)
						{
						case 2:
							break;
						case 1:
						case 3:
							text = (string)QB7IAeOna569ELmh6Zm(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81746), text);
							break;
						default:
							num4 = 2;
							continue;
						case 0:
						case 4:
							text = (string)RZBXUYONCfGjUqKpMo7(keyPairs, item2);
							if (text == null)
							{
								break;
							}
							goto case 1;
						case 5:
							goto IL_0355;
						}
						break;
					}
					goto IL_02ba;
					IL_0355:;
				}
				text2 = (string)QB7IAeOna569ELmh6Zm(text2, QggOEwOSFxraO9NbKgS(21870));
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable2)
			{
				Oq333iOCdsnC61GJqF0(disposable2);
			}
		}
		try
		{
			StreamWriter streamWriter = new StreamWriter(newFilePath);
			X55LnMOhQpRRJWp0NEh(streamWriter, text2);
			eAW0yEO82djLkDX9EjF(streamWriter);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SaveSettings(PKMqICcmc9);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LRYTpGO3EDgApGms4wK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zXm7hEOT3aMAhjkUktC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TextReader)P_0).ReadLine();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P1gZ7oOYOBAvtKxqQSG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QggOEwOSFxraO9NbKgS(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fJECMoOciyu93u3ddPX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool elLFU9O6KLaXCPWbxtT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DCRruEObvkGMCHRlKNv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AXYbTvO78dAam0hEFPr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TextReader)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kEfnaEOWv3naWmJXwmA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YxMsKbOkPG5ksMfp7Ip()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qI7EGcOKEjIqxdPdYMU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iNIGPLOpHB2PxFhYDJE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Hashtable)P_0).Keys;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lUFbAcO2Ngftf1u2m2T(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int a8sQDbOgVuW91PI0uJS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ArrayList)P_0).Add(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Oq333iOCdsnC61GJqF0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle HA5PNUOimjGHtXieYGh(int token)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dwyn4tOMfU0t2tCmKtm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Hashtable)P_0).Remove(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qfpbCiOBsFmk0pq3d09(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Hashtable)P_0).ContainsKey(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rFsGMfO5t0glBQTyDt0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable)P_0).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QNghUjOVlZcy5ZY93xe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T2uH7tODsURhMNfli6R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ArrayList)P_0).Sort();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YdyUYgORRsqwCFJGWfB(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RZBXUYONCfGjUqKpMo7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Hashtable)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QB7IAeOna569ELmh6Zm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X55LnMOhQpRRJWp0NEh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TextWriter)P_0).Write((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eAW0yEO82djLkDX9EjF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TextWriter)P_0).Close();
	}
}
