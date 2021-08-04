using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal sealed class VSD
{
	private static int NV(List<string> QSU_272)
	{
		//Discarded unreachable code: IL_0034, IL_0047
		//IL_003e: Expected O, but got I4
		int num = int.Parse(QSU_272[0]);
		int num2 = int.Parse(QSU_272[1]);
		return 0xFF ^ ((checked((num << 4) + num2) ^ 0xA3) & 0xFF);
	}

	internal static string IH(string DC_273, string XEJ_274, string QW_275)
	{
		//Discarded unreachable code: IL_032c, IL_033f
		//IL_0336: Expected O, but got I4
		//IL_0337: Expected O, but got I4
		checked
		{
			try
			{
				if (Operators.CompareString(DC_273, string.Empty, false) == 0 || Operators.CompareString(XEJ_274, string.Empty, false) == 0 || Operators.CompareString(QW_275, string.Empty, false) == 0)
				{
					return "";
				}
				List<string> list = new List<string>();
				int i = 0;
				for (int length = XEJ_274.Length; i < length; i++)
				{
					list.Add(XEJ_274[i].ToString());
				}
				List<string> list2 = new List<string>();
				int num = list.Count - 1;
				for (int j = 0; j <= num; j++)
				{
					if (Operators.CompareString(list[j], O.I("AyURveR6TLk5LkeEjVF0KQ=="), false) == 0)
					{
						list2.Add(O.I("oz/PYMClyUpTZTchpNSZxA=="));
					}
					if (Operators.CompareString(list[j], O.I("VFwapXPm9QAQPVQBFYDF4w=="), false) == 0)
					{
						list2.Add(O.I("ubKLVND1JL/X/JP/q22Uvw=="));
					}
					if (Operators.CompareString(list[j], O.I("/U+YZxAL5zwAh4WWT7hRRg=="), false) == 0)
					{
						list2.Add(O.I("0L8vpAMkdv5bmwTwutPk+A=="));
					}
					if (Operators.CompareString(list[j], O.I("F1GmSuOaAc3A+d/Y1l1ZXw=="), false) == 0)
					{
						list2.Add(O.I("EtYTxmZ46xvjwIyWDSJacA=="));
					}
					if (Operators.CompareString(list[j], O.I("+Xi+jW65KCXnUnm+mrSncQ=="), false) == 0)
					{
						list2.Add(O.I("S867FXFcGJe+Tyfd9zng1A=="));
					}
					if (Operators.CompareString(list[j], O.I("z9tWQpyzham3gPPiITzT/A=="), false) == 0)
					{
						list2.Add(O.I("SBwbznYWpBlADVIouFVz3A=="));
					}
					if (O.I("zKARoQjYwrjUrWhyx8C9TQ==").IndexOf(list[j]) == -1)
					{
						list2.Add(list[j]);
					}
				}
				List<string> list3 = list2;
				int num2 = 0;
				if (NV(list3) == 255)
				{
					num2 = NV(list3);
				}
				list3.Remove(list3[0]);
				list3.Remove(list3[0]);
				list3.Remove(list3[0]);
				list3.Remove(list3[0]);
				num2 = NV(list3);
				List<string> list4 = list3;
				list4.Remove(list4[0]);
				list4.Remove(list4[0]);
				int num3 = NV(list3) * 2;
				int num4 = num3 - 1;
				for (int k = 0; k <= num4; k++)
				{
					list3.Remove(list3[0]);
				}
				string text = "";
				int num5 = num2 - 1;
				for (int l = -1; l <= num5; l++)
				{
					string str = Strings.ChrW(NV(list3)).ToString();
					list3.Remove(list3[0]);
					list3.Remove(list3[0]);
					text += str;
				}
				string text2 = DC_273 + QW_275;
				int count = text.IndexOf(text2, StringComparison.Ordinal);
				text = text.Remove(0, count);
				return text.Replace(text2, "");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
