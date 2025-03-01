using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using fCq6WfrEDILJ63bcvr;
using SHDocVw;
using zoxFr96uALPVfCJPYS;

namespace ReBot;

public class ExWebBrowser : System.Windows.Forms.WebBrowser
{
	private bool QjdqXqf70q;

	private int EFMqDhpMRV;

	public string LocationURL;

	[CompilerGenerated]
	private string f4LqYTCF3l;

	public string UserAgent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f4LqYTCF3l;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			f4LqYTCF3l = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExWebBrowser()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XYcqygvHflmExAPCEGJ();
		int num = (lFTknLvXst3cvnVaYs6() ? 1 : 2);
		while (true)
		{
			switch (num)
			{
			case 5:
				FphZVHvJYRedGAx3ls8(this);
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
				num = 5;
				continue;
			case 4:
				wo4hWfvfpVLrlixtGK2(this, new WebBrowserDocumentCompletedEventHandler(Ehgqyv7lqC));
				break;
			case 6:
				return;
			}
			ru8KUAvz5CjSMMNLd7a(this, Je8Oogv9qfYdBn3afHA(10846));
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Zoom(object zoom)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			int cmdID = 63;
			int cmdexecopt = 2;
			SHDocVw.WebBrowser obj = (SHDocVw.WebBrowser)Bje0DCOsi9TMLegMRrG(this);
			object pvaIn = zoom;
			object pvaOut = zoom;
			obj.ExecWB((OLECMDID)cmdID, (OLECMDEXECOPT)cmdexecopt, ref pvaIn, ref pvaOut);
		}
		catch (Exception)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ehgqyv7lqC(object P_0, WebBrowserDocumentCompletedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (XYcqygvHflmExAPCEGJ())
		{
			num = 4;
		}
		else
		{
			num = 5;
			if (!XYcqygvHflmExAPCEGJ())
			{
				return;
			}
		}
		SHDocVw.WebBrowser webBrowser = default(SHDocVw.WebBrowser);
		while (true)
		{
			switch (num)
			{
			case 1:
				LocationURL = webBrowser.LocationURL;
				webBrowser.NavigateComplete2 += MCMqSAYLkT;
				num = 6;
				if (XYcqygvHflmExAPCEGJ())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				base.DocumentCompleted -= Ehgqyv7lqC;
				num = 3;
				break;
			case 2:
			case 5:
				webBrowser.BeforeNavigate2 += fiSqqqkg5A;
				goto case 1;
			default:
				num = 1;
				break;
			case 3:
				webBrowser = (SHDocVw.WebBrowser)base.ActiveXInstance;
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MCMqSAYLkT(object P_0, ref object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LocationURL = ((SHDocVw.WebBrowser)base.ActiveXInstance).LocationURL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lBIqOlhxjM(object P_0, WebBrowserDocumentCompletedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fiSqqqkg5A(object P_0, ref object P_1, ref object P_2, ref object P_3, ref object P_4, ref object P_5, ref bool P_6)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!lFTknLvXst3cvnVaYs6())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				R8KDNUOyiEV45jrtQ3Z(this, (string)P_1, (string)P_3, (byte[])P_4, (string)P_5);
				return;
			case 6:
				if (!string.IsNullOrEmpty(UserAgent))
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				return;
			case 0:
				if (QjdqXqf70q)
				{
					QjdqXqf70q = false;
					num = 7;
				}
				else
				{
					P_5 = P_5?.ToString() + string.Format(ajb1k2nt7TG3bU18v9.TYtDTyAefV(81396), UserAgent);
					_ = 0;
					num = (XYcqygvHflmExAPCEGJ() ? 1 : 3);
				}
				break;
			case 1:
			case 2:
				QjdqXqf70q = true;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				P_6 = true;
				goto case 3;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XYcqygvHflmExAPCEGJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lFTknLvXst3cvnVaYs6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FphZVHvJYRedGAx3ls8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((System.Windows.Forms.WebBrowser)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wo4hWfvfpVLrlixtGK2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((System.Windows.Forms.WebBrowser)P_0).DocumentCompleted += (WebBrowserDocumentCompletedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Je8Oogv9qfYdBn3afHA(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ru8KUAvz5CjSMMNLd7a(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((System.Windows.Forms.WebBrowser)P_0).Navigate((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bje0DCOsi9TMLegMRrG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((WebBrowserBase)P_0).ActiveXInstance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R8KDNUOyiEV45jrtQ3Z(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((System.Windows.Forms.WebBrowser)P_0).Navigate((string)P_1, (string)P_2, (byte[])P_3, (string)P_4);
	}
}
