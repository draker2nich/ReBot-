using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CUB0kCL30YeF2Gt7jr;
using fCq6WfrEDILJ63bcvr;
using zoxFr96uALPVfCJPYS;

namespace ReBot;

public class CustomTimes : Form
{
	public Dictionary<string, bool> checkBoxes;

	public Dictionary<string, string> textboxTimes;

	private IContainer WSS9Ry23vX;

	private Panel iUD96Ngf7F;

	private TextBox t579UdXrJ8;

	private Label joC9oNngot;

	private CheckBox vFS9rNF5KY;

	private Button MJA9fY3Qo1;

	private Button Qbw9Kf2gGB;

	private CheckBox ElC9itp7PI;

	private TextBox DNN9z6vo5t;

	private CheckBox XTpk7aobFu;

	private TextBox Y6ek9Cv9Mb;

	private CheckBox M6YkkMUkZL;

	private TextBox doTkQJDDHX;

	private CheckBox sSNksP0q6G;

	private TextBox K57kJtI9ae;

	private CheckBox BLGkZUQKiN;

	private TextBox otOk5xJeaS;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomTimes()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				fnoObmmMIjuEZgNdJ4.lcWWeTCzdDCMQ();
				num = 4;
				if (FnEJhxdIXBc1pslIEZ9())
				{
					continue;
				}
				goto case 4;
			case 4:
				checkBoxes = new Dictionary<string, bool>();
				textboxTimes = new Dictionary<string, string>();
				FnEJhxdIXBc1pslIEZ9();
				num = ((!cHhvR1dod2si3oEIDw3()) ? 1 : 5);
				continue;
			case 1:
			case 2:
				base._002Ector();
				break;
			case 6:
				return;
			}
			N1T9hWkNZ1();
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ID19n2rkl2(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!FnEJhxdIXBc1pslIEZ9())
		{
			goto IL_001e;
		}
		goto IL_0086;
		IL_001e:
		Lib.RenameControls(this, this);
		pdd9wPrWkm();
		num = 2;
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 7:
				Text = (string)jD5bGgdQ6wrLmc5oDmp(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3714));
				FnEJhxdIXBc1pslIEZ9();
				num = (cHhvR1dod2si3oEIDw3() ? 5 : 3);
				continue;
			case 0:
				EHR9BVNlTf(null, null);
				aeo9b0U0ur(null, null);
				goto default;
			case 2:
				TLd9IjMnCE(null, null);
				num = 0;
				continue;
			default:
				QfW9WxnH3b(null, null);
				I629g78Df7(null, null);
				num = 6;
				if (FnEJhxdIXBc1pslIEZ9())
				{
					continue;
				}
				goto case 6;
			case 6:
				SA49p460cP(null, null);
				num = 8;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pdd9wPrWkm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cHhvR1dod2si3oEIDw3();
		int num = ((!FnEJhxdIXBc1pslIEZ9()) ? 3 : 2);
		Dictionary<string, bool>.Enumerator enumerator = default(Dictionary<string, bool>.Enumerator);
		Control[] array = default(Control[]);
		Dictionary<string, string>.Enumerator enumerator2 = default(Dictionary<string, string>.Enumerator);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, bool> current = enumerator.Current;
						_ = 0;
						int num2 = ((!FnEJhxdIXBc1pslIEZ9()) ? 3 : 4);
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 4:
								array = base.Controls.Find(current.Key, searchAllChildren: true);
								num2 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto default;
							default:
								frQ7Y8dUls7JgUig64x((CheckBox)array[0], current.Value);
								num2 = 5;
								continue;
							case 1:
								if (array.Length == 0)
								{
									break;
								}
								goto default;
							case 5:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator2 = textboxTimes.GetEnumerator();
				break;
			default:
				goto IL_0125;
			case 0:
			case 2:
				enumerator = checkBoxes.GetEnumerator();
				goto case 1;
			case 4:
				break;
			}
			break;
			IL_0125:
			num = 4;
		}
		try
		{
			Control[] array2 = default(Control[]);
			while (enumerator2.MoveNext())
			{
				KeyValuePair<string, string> current2 = enumerator2.Current;
				cHhvR1dod2si3oEIDw3();
				int num3;
				if (FnEJhxdIXBc1pslIEZ9())
				{
					num3 = 2;
				}
				else
				{
					num3 = 3;
					if (!FnEJhxdIXBc1pslIEZ9())
					{
						goto IL_019e;
					}
				}
				goto IL_01b8;
				IL_01b8:
				while (true)
				{
					switch (num3)
					{
					case 0:
					case 2:
						array2 = ((Control.ControlCollection)vpMqj3drKibgQSmTHKE(this)).Find(current2.Key, searchAllChildren: true);
						break;
					case 1:
					case 3:
						break;
					default:
						num3 = 4;
						continue;
					case 4:
						goto IL_01df;
					case 5:
						goto IL_0204;
					}
					break;
				}
				goto IL_019e;
				IL_019e:
				if (array2.Length == 0)
				{
					continue;
				}
				goto IL_01df;
				IL_01df:
				Q0pZtkdZGjdVFJkOfwJ((TextBox)array2[0], current2.Value);
				num3 = 5;
				if (!FnEJhxdIXBc1pslIEZ9())
				{
					continue;
				}
				goto IL_01b8;
				IL_0204:;
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ij99u95XSl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FnEJhxdIXBc1pslIEZ9();
		int num;
		if (!cHhvR1dod2si3oEIDw3())
		{
			num = 2;
		}
		else
		{
			num = 5;
			if (cHhvR1dod2si3oEIDw3())
			{
			}
		}
		Dictionary<string, bool> dictionary2 = default(Dictionary<string, bool>);
		Dictionary<string, bool>.Enumerator enumerator = default(Dictionary<string, bool>.Enumerator);
		Control[] array = default(Control[]);
		Dictionary<string, string>.Enumerator enumerator2 = default(Dictionary<string, string>.Enumerator);
		Control[] array2 = default(Control[]);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		do
		{
			IL_0136:
			switch (num)
			{
			case 0:
			case 2:
				dictionary2 = new Dictionary<string, bool>();
				break;
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, bool> current = enumerator.Current;
						int num2 = 4;
						while (true)
						{
							switch (num2)
							{
							default:
								dictionary2.Add(current.Key, ((CheckBox)array[0]).Checked);
								num2 = 5;
								continue;
							case 1:
							case 3:
								if (array.Length == 0)
								{
									break;
								}
								goto default;
							case 4:
								array = (Control[])dGyA1rdvgVXRUAI1e0E(base.Controls, current.Key, true);
								_ = 1;
								if (cHhvR1dod2si3oEIDw3())
								{
									num2 = 0;
									continue;
								}
								num2 = 3;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 5:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator2 = textboxTimes.GetEnumerator();
				goto case 4;
			default:
				num = 4;
				goto IL_0136;
			case 4:
				try
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<string, string> current2 = enumerator2.Current;
						FnEJhxdIXBc1pslIEZ9();
						int num3 = (cHhvR1dod2si3oEIDw3() ? 1 : 4);
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (array2.Length == 0)
								{
									break;
								}
								goto default;
							default:
								dictionary.Add(current2.Key, ((TextBox)array2[0]).Text);
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 4:
								array2 = (Control[])dGyA1rdvgVXRUAI1e0E(vpMqj3drKibgQSmTHKE(this), current2.Key, true);
								num3 = 3;
								continue;
							case 5:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
				checkBoxes = dictionary2;
				num = 6;
				goto IL_0136;
			case 6:
				textboxTimes = dictionary;
				num = 7;
				goto IL_0136;
			case 1:
			case 5:
				break;
			case 7:
				return;
			}
			dictionary = new Dictionary<string, string>();
			enumerator = checkBoxes.GetEnumerator();
			num = 3;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TLd9IjMnCE(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		t579UdXrJ8.Enabled = vFS9rNF5KY.Checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EHR9BVNlTf(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		otOk5xJeaS.Enabled = BLGkZUQKiN.Checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aeo9b0U0ur(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gq0nxLdOGL552XshX6a(K57kJtI9ae, sSNksP0q6G.Checked);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QfW9WxnH3b(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gq0nxLdOGL552XshX6a(doTkQJDDHX, M6YkkMUkZL.Checked);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void I629g78Df7(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Y6ek9Cv9Mb.Enabled = XTpk7aobFu.Checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SA49p460cP(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DNN9z6vo5t.Enabled = ElC9itp7PI.Checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tGx9aXPHhO(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ij99u95XSl();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!cHhvR1dod2si3oEIDw3())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (!FnEJhxdIXBc1pslIEZ9())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				if (WSS9Ry23vX != null)
				{
					num = 2;
					if (cHhvR1dod2si3oEIDw3())
					{
					}
					break;
				}
				goto default;
			default:
				KgwT88dElHw0ElQaVDa(this, disposing);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				if (disposing)
				{
					num = 5;
					break;
				}
				goto default;
			case 2:
				WSS9Ry23vX.Dispose();
				goto default;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void N1T9hWkNZ1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 34;
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			switch (num)
			{
			case 51:
				a2ByTodldPXwXu8WRO0(joC9oNngot, new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				joC9oNngot.Location = new Point(12, 9);
				num = 43;
				break;
			case 12:
			case 52:
				WFZlwAdGg7hN9fm8PKs(iUD96Ngf7F, new Size(983, 575));
				num = 40;
				if (true)
				{
					break;
				}
				goto case 26;
			case 26:
				((Control.ControlCollection)Kg0DU3duYgeGiqVZM9v(iUD96Ngf7F)).Add((Control)Y6ek9Cv9Mb);
				((Control.ControlCollection)Kg0DU3duYgeGiqVZM9v(iUD96Ngf7F)).Add((Control)M6YkkMUkZL);
				((Control.ControlCollection)Kg0DU3duYgeGiqVZM9v(iUD96Ngf7F)).Add((Control)doTkQJDDHX);
				ljf5yxdeaTQ054L16Sc(Kg0DU3duYgeGiqVZM9v(iUD96Ngf7F), sSNksP0q6G);
				ljf5yxdeaTQ054L16Sc(iUD96Ngf7F.Controls, K57kJtI9ae);
				num = 28;
				if (0 == 0)
				{
					break;
				}
				goto case 15;
			case 15:
				Y6ek9Cv9Mb.TabIndex = 13;
				M6YkkMUkZL.AutoSize = true;
				a2ByTodldPXwXu8WRO0(M6YkkMUkZL, new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				num = 5;
				if (true)
				{
					break;
				}
				goto case 43;
			case 43:
				joC9oNngot.Name = ajb1k2nt7TG3bU18v9.TYtDTyAefV(4470);
				joC9oNngot.Size = new Size(959, 59);
				SEAqSSdkxaG8atTEF6i(joC9oNngot, 0);
				num = 33;
				if (FnEJhxdIXBc1pslIEZ9())
				{
					break;
				}
				goto case 3;
			case 3:
				vFS9rNF5KY.Name = (string)stESyad0DtB2iUbtbUy(4374);
				vFS9rNF5KY.Size = new Size(100, 22);
				num = 19;
				break;
			case 16:
				t579UdXrJ8.Location = new Point(165, 77);
				t579UdXrJ8.Name = ajb1k2nt7TG3bU18v9.TYtDTyAefV(4436);
				t579UdXrJ8.Size = new Size(806, 24);
				t579UdXrJ8.TabIndex = 3;
				num = 51;
				break;
			case 40:
				iUD96Ngf7F.TabIndex = 0;
				num = 31;
				break;
			case 25:
				a2ByTodldPXwXu8WRO0(K57kJtI9ae, new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				num = 53;
				if (0 == 0)
				{
					break;
				}
				goto case 38;
			case 38:
				DNN9z6vo5t = new TextBox();
				XTpk7aobFu = new CheckBox();
				Y6ek9Cv9Mb = new TextBox();
				num = 9;
				break;
			case 21:
				uJcFKodFWZKvGWiY294(iUD96Ngf7F);
				num = 30;
				break;
			case 20:
				XTpk7aobFu.TabIndex = 14;
				Q0pZtkdZGjdVFJkOfwJ(XTpk7aobFu, stESyad0DtB2iUbtbUy(3952));
				ix6fnmdW1TkPDJmG4ua(XTpk7aobFu, true);
				XTpk7aobFu.CheckedChanged += I629g78Df7;
				num = 29;
				break;
			case 56:
				g9v27pdtca4Uj1IkJK2(BLGkZUQKiN, stESyad0DtB2iUbtbUy(4202));
				BLGkZUQKiN.Size = new Size(114, 22);
				num = 7;
				break;
			case 46:
				base.AutoScaleDimensions = new SizeF(8f, 16f);
				base.AutoScaleMode = AutoScaleMode.Font;
				num = 54;
				if (true)
				{
					break;
				}
				goto case 39;
			case 39:
			case 47:
				otOk5xJeaS.Size = new Size(806, 24);
				otOk5xJeaS.TabIndex = 7;
				MJA9fY3Qo1.DialogResult = DialogResult.Cancel;
				a2ByTodldPXwXu8WRO0(MJA9fY3Qo1, new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				MJA9fY3Qo1.Location = new Point(12, 532);
				MJA9fY3Qo1.Name = ajb1k2nt7TG3bU18v9.TYtDTyAefV(4300);
				num = 32;
				if (true)
				{
					break;
				}
				goto case 29;
			case 29:
				a2ByTodldPXwXu8WRO0(Y6ek9Cv9Mb, new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				Y6ek9Cv9Mb.Location = new Point(165, 233);
				Y6ek9Cv9Mb.Name = ajb1k2nt7TG3bU18v9.TYtDTyAefV(3970);
				WFZlwAdGg7hN9fm8PKs(Y6ek9Cv9Mb, new Size(806, 24));
				num = 15;
				break;
			case 41:
				ElC9itp7PI.UseVisualStyleBackColor = true;
				num = 0;
				break;
			case 2:
				oumgjedwA5Zl4JvhGpM(BLGkZUQKiN, new Point(13, 116));
				num = 56;
				break;
			case 35:
				base.Icon = (Icon)gQd8tadTkA12PAeMXAh(componentResourceManager, ajb1k2nt7TG3bU18v9.TYtDTyAefV(4760));
				base.Name = ajb1k2nt7TG3bU18v9.TYtDTyAefV(4784);
				Q0pZtkdZGjdVFJkOfwJ(this, ajb1k2nt7TG3bU18v9.TYtDTyAefV(4784));
				num = 6;
				break;
			case 6:
				JU8pJHdYXXiFIWCyMqJ(this, new EventHandler(ID19n2rkl2));
				iUD96Ngf7F.ResumeLayout(performLayout: false);
				iUD96Ngf7F.PerformLayout();
				UNdhxHdSXxkQLne0pNm(this, false);
				num = 57;
				break;
			case 54:
				base.ClientSize = new Size(983, 575);
				((Control.ControlCollection)vpMqj3drKibgQSmTHKE(this)).Add((Control)iUD96Ngf7F);
				num = 35;
				break;
			case 8:
				sSNksP0q6G = new CheckBox();
				K57kJtI9ae = new TextBox();
				BLGkZUQKiN = new CheckBox();
				otOk5xJeaS = new TextBox();
				MJA9fY3Qo1 = new Button();
				Qbw9Kf2gGB = new Button();
				vFS9rNF5KY = new CheckBox();
				t579UdXrJ8 = new TextBox();
				num = 48;
				break;
			case 24:
				DNN9z6vo5t.Location = new Point(165, 272);
				DNN9z6vo5t.Name = ajb1k2nt7TG3bU18v9.TYtDTyAefV(3872);
				num = 11;
				if (!cHhvR1dod2si3oEIDw3())
				{
					break;
				}
				goto case 45;
			case 45:
				Qbw9Kf2gGB.DialogResult = DialogResult.OK;
				num = 10;
				if (true)
				{
					break;
				}
				goto case 50;
			case 50:
				oumgjedwA5Zl4JvhGpM(XTpk7aobFu, new Point(13, 233));
				XTpk7aobFu.Name = (string)stESyad0DtB2iUbtbUy(3908);
				XTpk7aobFu.Size = new Size(95, 22);
				num = 20;
				break;
			case 19:
				vFS9rNF5KY.TabIndex = 4;
				vFS9rNF5KY.Text = (string)stESyad0DtB2iUbtbUy(4416);
				ix6fnmdW1TkPDJmG4ua(vFS9rNF5KY, true);
				bWqQHld3kOAR4cijJIG(vFS9rNF5KY, new EventHandler(TLd9IjMnCE));
				num = 37;
				break;
			case 9:
				M6YkkMUkZL = new CheckBox();
				doTkQJDDHX = new TextBox();
				num = 8;
				if (FnEJhxdIXBc1pslIEZ9())
				{
					break;
				}
				goto case 18;
			case 18:
				M6YkkMUkZL.TabIndex = 12;
				M6YkkMUkZL.Text = (string)stESyad0DtB2iUbtbUy(4050);
				ix6fnmdW1TkPDJmG4ua(M6YkkMUkZL, true);
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 49;
			case 49:
				oumgjedwA5Zl4JvhGpM(ElC9itp7PI, new Point(13, 272));
				g9v27pdtca4Uj1IkJK2(ElC9itp7PI, ajb1k2nt7TG3bU18v9.TYtDTyAefV(3808));
				ElC9itp7PI.Size = new Size(100, 22);
				ElC9itp7PI.TabIndex = 16;
				ElC9itp7PI.Text = ajb1k2nt7TG3bU18v9.TYtDTyAefV(3852);
				num = 41;
				if (0 == 0)
				{
					break;
				}
				goto case 23;
			case 23:
				K57kJtI9ae.TabIndex = 9;
				num = 14;
				break;
			case 27:
				SEAqSSdkxaG8atTEF6i(sSNksP0q6G, 10);
				sSNksP0q6G.Text = (string)stESyad0DtB2iUbtbUy(4156);
				sSNksP0q6G.UseVisualStyleBackColor = true;
				bWqQHld3kOAR4cijJIG(sSNksP0q6G, new EventHandler(aeo9b0U0ur));
				num = 25;
				break;
			case 30:
				StAblmdxYUrAoFssx2N(this);
				iUD96Ngf7F.Controls.Add(ElC9itp7PI);
				ljf5yxdeaTQ054L16Sc(Kg0DU3duYgeGiqVZM9v(iUD96Ngf7F), DNN9z6vo5t);
				num = 17;
				if (true)
				{
					break;
				}
				goto case 33;
			case 33:
				joC9oNngot.Text = ajb1k2nt7TG3bU18v9.TYtDTyAefV(4486);
				num = 46;
				break;
			case 37:
				t579UdXrJ8.Font = new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
				num = 16;
				break;
			case 55:
				Qbw9Kf2gGB.Click += tGx9aXPHhO;
				vFS9rNF5KY.AutoSize = true;
				vFS9rNF5KY.Font = new Font((string)stESyad0DtB2iUbtbUy(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
				vFS9rNF5KY.Location = new Point(13, 77);
				num = 3;
				break;
			case 4:
				M6YkkMUkZL.CheckedChanged += QfW9WxnH3b;
				a2ByTodldPXwXu8WRO0(doTkQJDDHX, new Font((string)stESyad0DtB2iUbtbUy(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				oumgjedwA5Zl4JvhGpM(doTkQJDDHX, new Point(165, 193));
				doTkQJDDHX.Name = (string)stESyad0DtB2iUbtbUy(4076);
				doTkQJDDHX.Size = new Size(806, 24);
				doTkQJDDHX.TabIndex = 11;
				sSNksP0q6G.AutoSize = true;
				a2ByTodldPXwXu8WRO0(sSNksP0q6G, new Font((string)stESyad0DtB2iUbtbUy(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				sSNksP0q6G.Location = new Point(13, 154);
				g9v27pdtca4Uj1IkJK2(sSNksP0q6G, stESyad0DtB2iUbtbUy(4112));
				num = 36;
				break;
			case 44:
				a2ByTodldPXwXu8WRO0(ElC9itp7PI, new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				num = 49;
				if (FnEJhxdIXBc1pslIEZ9())
				{
					break;
				}
				goto case 14;
			case 14:
				BLGkZUQKiN.AutoSize = true;
				a2ByTodldPXwXu8WRO0(BLGkZUQKiN, new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204));
				num = 2;
				break;
			case 28:
				ljf5yxdeaTQ054L16Sc(iUD96Ngf7F.Controls, BLGkZUQKiN);
				ljf5yxdeaTQ054L16Sc(iUD96Ngf7F.Controls, otOk5xJeaS);
				iUD96Ngf7F.Controls.Add(MJA9fY3Qo1);
				iUD96Ngf7F.Controls.Add(Qbw9Kf2gGB);
				iUD96Ngf7F.Controls.Add(vFS9rNF5KY);
				iUD96Ngf7F.Controls.Add(t579UdXrJ8);
				num = 13;
				break;
			case 48:
				joC9oNngot = new Label();
				num = 21;
				break;
			case 36:
				sSNksP0q6G.Size = new Size(52, 22);
				num = 27;
				break;
			case 22:
				BLGkZUQKiN.Text = ajb1k2nt7TG3bU18v9.TYtDTyAefV(4244);
				ix6fnmdW1TkPDJmG4ua(BLGkZUQKiN, true);
				BLGkZUQKiN.CheckedChanged += EHR9BVNlTf;
				otOk5xJeaS.Font = new Font((string)stESyad0DtB2iUbtbUy(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
				otOk5xJeaS.Location = new Point(165, 116);
				otOk5xJeaS.Name = (string)stESyad0DtB2iUbtbUy(4266);
				goto case 39;
			case 32:
				MJA9fY3Qo1.Size = new Size(167, 31);
				SEAqSSdkxaG8atTEF6i(MJA9fY3Qo1, 6);
				MJA9fY3Qo1.Text = ajb1k2nt7TG3bU18v9.TYtDTyAefV(4318);
				MJA9fY3Qo1.UseVisualStyleBackColor = true;
				num = 45;
				break;
			case 31:
				o0N09qdqQ99jUai7wio(ElC9itp7PI, true);
				num = 44;
				break;
			case 34:
				componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(pBhnjNbOQaPrc7QP7L.I3HWeT3L8YsJD(33554449)));
				num = 1;
				break;
			case 13:
				ljf5yxdeaTQ054L16Sc(iUD96Ngf7F.Controls, joC9oNngot);
				iUD96Ngf7F.Dock = DockStyle.Fill;
				iUD96Ngf7F.Location = new Point(0, 0);
				iUD96Ngf7F.Name = (string)stESyad0DtB2iUbtbUy(3748);
				_ = 1;
				num = ((!cHhvR1dod2si3oEIDw3()) ? 52 : 47);
				break;
			case 53:
				oumgjedwA5Zl4JvhGpM(K57kJtI9ae, new Point(165, 154));
				g9v27pdtca4Uj1IkJK2(K57kJtI9ae, ajb1k2nt7TG3bU18v9.TYtDTyAefV(4166));
				K57kJtI9ae.Size = new Size(806, 24);
				num = 23;
				if (0 == 0)
				{
					break;
				}
				goto case 42;
			case 42:
				M6YkkMUkZL.Size = new Size(125, 22);
				num = 18;
				break;
			case 17:
				((Control.ControlCollection)Kg0DU3duYgeGiqVZM9v(iUD96Ngf7F)).Add((Control)XTpk7aobFu);
				num = 26;
				break;
			case 7:
				BLGkZUQKiN.TabIndex = 8;
				num = 22;
				break;
			case 11:
				DNN9z6vo5t.Size = new Size(806, 24);
				DNN9z6vo5t.TabIndex = 15;
				XTpk7aobFu.AutoSize = true;
				XTpk7aobFu.Font = new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
				num = 50;
				break;
			case 1:
				iUD96Ngf7F = new Panel();
				ElC9itp7PI = new CheckBox();
				num = 38;
				break;
			case 10:
				Qbw9Kf2gGB.Font = new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
				Qbw9Kf2gGB.Location = new Point(804, 532);
				Qbw9Kf2gGB.Name = (string)stESyad0DtB2iUbtbUy(4334);
				Qbw9Kf2gGB.Size = new Size(167, 31);
				SEAqSSdkxaG8atTEF6i(Qbw9Kf2gGB, 5);
				Q0pZtkdZGjdVFJkOfwJ(Qbw9Kf2gGB, ajb1k2nt7TG3bU18v9.TYtDTyAefV(4352));
				Qbw9Kf2gGB.UseVisualStyleBackColor = true;
				num = 55;
				break;
			case 0:
				ElC9itp7PI.CheckedChanged += SA49p460cP;
				DNN9z6vo5t.Font = new Font(ajb1k2nt7TG3bU18v9.TYtDTyAefV(3764), 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
				num = 24;
				break;
			case 5:
				M6YkkMUkZL.Location = new Point(13, 193);
				M6YkkMUkZL.Name = ajb1k2nt7TG3bU18v9.TYtDTyAefV(4006);
				num = 42;
				break;
			case 57:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FnEJhxdIXBc1pslIEZ9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cHhvR1dod2si3oEIDw3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jD5bGgdQ6wrLmc5oDmp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Lib.w((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void frQ7Y8dUls7JgUig64x(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CheckBox)P_0).Checked = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vpMqj3drKibgQSmTHKE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Control)P_0).Controls;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q0pZtkdZGjdVFJkOfwJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).Text = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dGyA1rdvgVXRUAI1e0E(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Control.ControlCollection)P_0).Find((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gq0nxLdOGL552XshX6a(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).Enabled = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KgwT88dElHw0ElQaVDa(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Form)P_0).Dispose(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uJcFKodFWZKvGWiY294(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).SuspendLayout();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StAblmdxYUrAoFssx2N(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).SuspendLayout();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kg0DU3duYgeGiqVZM9v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Control)P_0).Controls;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ljf5yxdeaTQ054L16Sc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control.ControlCollection)P_0).Add((Control)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object stESyad0DtB2iUbtbUy(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ajb1k2nt7TG3bU18v9.TYtDTyAefV(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WFZlwAdGg7hN9fm8PKs(object P_0, Size P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).Size = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o0N09qdqQ99jUai7wio(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).AutoSize = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a2ByTodldPXwXu8WRO0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).Font = (Font)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oumgjedwA5Zl4JvhGpM(object P_0, Point P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).Location = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g9v27pdtca4Uj1IkJK2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ix6fnmdW1TkPDJmG4ua(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ButtonBase)P_0).UseVisualStyleBackColor = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SEAqSSdkxaG8atTEF6i(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).TabIndex = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bWqQHld3kOAR4cijJIG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CheckBox)P_0).CheckedChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gQd8tadTkA12PAeMXAh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ResourceManager)P_0).GetObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JU8pJHdYXXiFIWCyMqJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Form)P_0).Load += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UNdhxHdSXxkQLne0pNm(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).ResumeLayout(P_1);
	}
}
