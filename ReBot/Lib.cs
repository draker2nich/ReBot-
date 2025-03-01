using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using fCq6WfrEDILJ63bcvr;
using rD9BTdvLIJYvvCMKZ8;
using ReBot.Properties;
using zoxFr96uALPVfCJPYS;

namespace ReBot;

public static class Lib
{
	public static Dictionary<string, string> lng;

	public static Dictionary<string, SettingValidate> SettingValidateList;

	public static ToolTip tt;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Lib()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ERbPyEyMc2jKKyweZ6q();
		int num;
		if (ptfLFByibbVSQYfoLNS())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (!ptfLFByibbVSQYfoLNS())
			{
				goto IL_008a;
			}
		}
		goto IL_0044;
		IL_00bd:
		lng = new Dictionary<string, string>();
		num = 4;
		if (ERbPyEyMc2jKKyweZ6q())
		{
		}
		goto IL_0044;
		IL_008a:
		Dictionary<string, SettingValidate> settingValidateList = SettingValidateList;
		string key = ajb1k2nt7TG3bU18v9.TYtDTyAefV(2116);
		SettingValidate settingValidate = new SettingValidate();
		settingValidate.mhb9EpVSJs((PgADUw050obe94RDW7)1);
		settingValidate.Default = 0;
		settingValidateList.Add(key, settingValidate);
		num = 6;
		if (true)
		{
			goto IL_0044;
		}
		goto IL_00bd;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 4:
				SettingValidateList = new Dictionary<string, SettingValidate>();
				break;
			default:
				num = 5;
				continue;
			case 0:
			case 2:
				bSanEUyBMVxetBoRphJ();
				goto IL_00bd;
			case 5:
				break;
			case 1:
			case 3:
				goto IL_00bd;
			case 6:
				return;
			}
			break;
		}
		goto IL_008a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTT(Control control)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		string text = default(string);
		while (true)
		{
			string languageKey;
			switch (num)
			{
			case 0:
				if (!(control.Tag.ToString() != ""))
				{
					_ = 0;
					if (ptfLFByibbVSQYfoLNS())
					{
						num = 7;
						break;
					}
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				}
				languageKey = iANwiGyV6LbfKyNfMdN(control).ToString();
				goto IL_00a9;
			case 6:
				vX4V5SyNOXMeCiFR5H9(tt, text, control, 0);
				num = 8;
				break;
			case 1:
				tt.IsBalloon = true;
				sN6E2nyRI1vYwywXZuj(tt, string.Empty, control);
				num = 6;
				break;
			case 2:
			case 7:
				languageKey = (string)ioStxNy57o02LkTlM7U(control) + ajb1k2nt7TG3bU18v9.TYtDTyAefV(2142);
				goto IL_00a9;
			case 3:
			case 5:
				if (icK4OeyDUk7kWc7ElkC(text.Trim(), ""))
				{
					tt.InitialDelay = 0;
					goto case 1;
				}
				return;
			default:
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				tt = new ToolTip();
				num = 0;
				if (1 == 0)
				{
					return;
				}
				break;
			case 8:
				return;
				IL_00a9:
				text = w(languageKey);
				if (text != null)
				{
					goto case 3;
				}
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void HideTT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JBqwTaynNUBP0mWMYDL(tt);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<KeyValuePair> GetSpecList()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new List<KeyValuePair>
		{
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2110), ajb1k2nt7TG3bU18v9.TYtDTyAefV(2110)),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2152), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2160))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2186), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2194))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2220), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2228))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2254), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2262))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2288), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2296))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2322), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2330))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2356), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2364))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2390), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2398)))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string w(string LanguageKey)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string value = "";
		lng.TryGetValue(LanguageKey, out value);
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string w(string LanguageKey, params string[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string value = "";
		lng.TryGetValue(LanguageKey, out value);
		return string.Format(value, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<KeyValuePair> GetPlayerSortTypeList()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new List<KeyValuePair>
		{
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2424), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2470))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2496), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2528))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2554), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2576))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2602), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2628))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2654), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2672))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2698), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2718))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2744), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2762)))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<KeyValuePair> GetTaskList()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new List<KeyValuePair>
		{
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2788), ""),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2794), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2800))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2826), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2832))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2858), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2864))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2890), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2896))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2922), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2928))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2954), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2960)))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RenameControls(Control MainControl, Control ctl)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			string key = "";
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2986), ajb1k2nt7TG3bU18v9.TYtDTyAefV(3030));
			dictionary.Add(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3064), (string)FEij9UyhCecxpRGjO3y(3110));
			foreach (Control item in (ArrangedElementCollection)OhsZSTy8T2cuQn0xDSY(ctl))
			{
				int num = 9;
				while (true)
				{
					switch (num)
					{
					case 9:
						key = (string)knHKR3yaqiLPawK9h6M(ioStxNy57o02LkTlM7U(MainControl), ajb1k2nt7TG3bU18v9.TYtDTyAefV(3158), item.Name);
						ptfLFByibbVSQYfoLNS();
						if (!ERbPyEyMc2jKKyweZ6q())
						{
							num = 4;
							continue;
						}
						num = 5;
						if (ptfLFByibbVSQYfoLNS())
						{
							continue;
						}
						goto case 7;
					case 7:
						if (iANwiGyV6LbfKyNfMdN(item) == null)
						{
							goto IL_0112;
						}
						goto case 3;
					default:
						num = 3;
						if (ptfLFByibbVSQYfoLNS())
						{
							continue;
						}
						goto case 1;
					case 1:
					case 4:
						if (!lng.ContainsKey(key))
						{
							if (dictionary.ContainsKey(key) && lng.ContainsKey(dictionary[key]))
							{
								item.Text = lng[dictionary[key]];
								num = 8;
								continue;
							}
							goto case 0;
						}
						num = 2;
						continue;
					case 2:
						if (!((string)ioStxNy57o02LkTlM7U(item) == ajb1k2nt7TG3bU18v9.TYtDTyAefV(3164)))
						{
							goto IL_0112;
						}
						num = 7;
						if (0 == 0)
						{
							continue;
						}
						goto case 3;
					case 3:
						if (!(item.Tag.ToString() == (string)FEij9UyhCecxpRGjO3y(3182)))
						{
							item.Text = w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3224));
							goto case 0;
						}
						item.Text = w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3194));
						num = 0;
						continue;
					case 0:
					case 5:
					case 6:
					case 8:
						RenameControls(MainControl, item);
						num = 10;
						continue;
					case 10:
						break;
						IL_0112:
						if (item.Name == ajb1k2nt7TG3bU18v9.TYtDTyAefV(3244) && iANwiGyV6LbfKyNfMdN(item) != null)
						{
							if (Lm9yYIyPPLgs5HxYty3(item.Tag.ToString(), FEij9UyhCecxpRGjO3y(3264)))
							{
								item.Text = w((string)FEij9UyhCecxpRGjO3y(3282));
							}
							else
							{
								item.Text = (string)IZmvWfyAdpQrT8S1oZ5(FEij9UyhCecxpRGjO3y(3300));
							}
						}
						else
						{
							item.Text = lng[key];
						}
						goto case 0;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			uX6rLMy1WMvpoEnU9aK(ex.Message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Int2Text(int arg, string enumerator)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string[] array = w(enumerator).Split(',');
		if (array[arg] != null)
		{
			return array[arg];
		}
		return string.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetLanguage(string LanguageCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ERbPyEyMc2jKKyweZ6q();
		int num;
		if (ptfLFByibbVSQYfoLNS())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
			if (!ptfLFByibbVSQYfoLNS())
			{
				return;
			}
		}
		goto IL_0176;
		IL_002a:
		string text = (string)knHKR3yaqiLPawK9h6M(FEij9UyhCecxpRGjO3y(3332), LanguageCode, FEij9UyhCecxpRGjO3y(3346));
		TextReader textReader = default(TextReader);
		if (!QyaG1Sy4uC9WuhUYA3E(text))
		{
			object obj = X9iqDiyLnRwCv8uDug7(G0KJTlyjGOCpEvjyChC(), (string)FEij9UyhCecxpRGjO3y(3358) + LanguageCode.Replace(ajb1k2nt7TG3bU18v9.TYtDTyAefV(2110), ajb1k2nt7TG3bU18v9.TYtDTyAefV(3158)));
			if (obj == null)
			{
				num = 8;
			}
			else
			{
				textReader = new StringReader((string)obj);
				num = 9;
			}
			goto IL_0176;
		}
		string[] array = default(string[]);
		try
		{
			textReader = new StreamReader(text);
			for (string text2 = (string)X8EJ8Cym3LHSi5D67Ij(textReader); text2 != null; text2 = (string)X8EJ8Cym3LHSi5D67Ij(textReader))
			{
				text2 = (string)EVHHRKyH21wZh5l4NCM(text2);
				if (text2 != "")
				{
					array = (string[])reNsShyXkEOseM5gmvq(text2, new char[1] { '=' }, 2);
					if (array.Length > 1)
					{
						lng.Add(array[0].Trim(), array[1].Trim());
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
				g51oSPyJ2Dd1sdL5bNo(textReader);
			}
		}
		IL_0176:
		while (true)
		{
			string text2;
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 1:
				textReader = null;
				num = 3;
				continue;
			case 5:
				lng.Add(array[0].Trim(), array[1].Trim());
				goto case 6;
			case 8:
				return;
			case 3:
				text2 = null;
				array = null;
				lng.Clear();
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				if (array.Length > 1)
				{
					num = 5;
					continue;
				}
				goto case 6;
			case 6:
			case 7:
				text2 = (string)X8EJ8Cym3LHSi5D67Ij(textReader);
				goto IL_011e;
			case 9:
				text2 = textReader.ReadLine();
				goto IL_011e;
			default:
				num = 2;
				if (ptfLFByibbVSQYfoLNS())
				{
					continue;
				}
				return;
			case 10:
				return;
				IL_011e:
				if (text2 == null)
				{
					num = 10;
					continue;
				}
				text2 = text2.Trim();
				if (text2 != "")
				{
					array = text2.Split(new char[1] { '=' }, 2);
					goto case 2;
				}
				goto case 6;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<KeyValuePair> GetCampList()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new List<KeyValuePair>
		{
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3372), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3388))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3414), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3426))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3452), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3470))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3496), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3514))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3540), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3550)))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<KeyValuePair> GetPlayerOrderList()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new List<KeyValuePair>
		{
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3576), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3602))),
			new KeyValuePair(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3630), w(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3662)))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void BindComboboxList(ComboBox comboBox, List<KeyValuePair> GetComboboxList)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		comboBox.ValueMember = ajb1k2nt7TG3bU18v9.TYtDTyAefV(3690);
		comboBox.DisplayMember = ajb1k2nt7TG3bU18v9.TYtDTyAefV(3700);
		int selectedIndex = comboBox.SelectedIndex;
		comboBox.DataSource = GetComboboxList;
		comboBox.SelectedIndex = selectedIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bSanEUyBMVxetBoRphJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ptfLFByibbVSQYfoLNS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ERbPyEyMc2jKKyweZ6q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ioStxNy57o02LkTlM7U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Control)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iANwiGyV6LbfKyNfMdN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Control)P_0).Tag;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool icK4OeyDUk7kWc7ElkC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sN6E2nyRI1vYwywXZuj(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ToolTip)P_0).Show((string)P_1, (IWin32Window)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vX4V5SyNOXMeCiFR5H9(object P_0, object P_1, object P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ToolTip)P_0).Show((string)P_1, (IWin32Window)P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JBqwTaynNUBP0mWMYDL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Component)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FEij9UyhCecxpRGjO3y(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OhsZSTy8T2cuQn0xDSY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Control)P_0).Controls;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object knHKR3yaqiLPawK9h6M(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Lm9yYIyPPLgs5HxYty3(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IZmvWfyAdpQrT8S1oZ5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return w((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult uX6rLMy1WMvpoEnU9aK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MessageBox.Show((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QyaG1Sy4uC9WuhUYA3E(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return File.Exists((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G0KJTlyjGOCpEvjyChC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ResourceManager;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X9iqDiyLnRwCv8uDug7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ResourceManager)P_0).GetObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X8EJ8Cym3LHSi5D67Ij(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TextReader)P_0).ReadLine();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EVHHRKyH21wZh5l4NCM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object reNsShyXkEOseM5gmvq(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g51oSPyJ2Dd1sdL5bNo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TextReader)P_0).Close();
	}
}
