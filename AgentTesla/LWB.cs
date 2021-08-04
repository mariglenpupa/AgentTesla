using System;
using System.Collections;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class LWB
{
	public static string RNU()
	{
		//Discarded unreachable code: IL_0068, IL_007b
		//IL_0072: Expected O, but got I4
		//IL_0073: Expected O, but got I4
		string text = "";
		try
		{
			text = UZ(MD5.Create(), Conversions.ToString(Operators.ConcatenateObject(CL(), NZF())));
			if (text.Contains(O.I("0XuB4qT44kEu3Z0S79ooOg==")))
			{
				return text.Replace(O.I("0XuB4qT44kEu3Z0S79ooOg=="), "");
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text = O.I("NYwSMsx0/B7nRn6LyB19PA==");
			ProjectData.ClearProjectError();
			return text;
		}
	}

	private static object NZF()
	{
		//Discarded unreachable code: IL_006f, IL_0082
		//IL_0079: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		string result = string.Empty;
		ManagementClass managementClass = new ManagementClass(O.I("OY/80jDifzi7984QV8fXZg=="));
		ManagementObjectCollection instances = managementClass.GetInstances();
		foreach (ManagementObject item in instances)
		{
			result = item.Properties[O.I("B5YDTLEDBjd+8zy5lzEfjw==")].Value.ToString();
		}
		return result;
	}

	private static string CL()
	{
		//Discarded unreachable code: IL_00ce, IL_00e1
		//IL_00d8: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject(O.I("p/i+lQ2V1nI3nTAZaLeyJw==")));
			string text = string.Empty;
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, O.I("aOgzVe2oj9qrO3i0YWamnQ=="), new object[1]
			{
				O.I("TRFEgTZqj8RrwTk5dNbwqw==")
			}, null, null, null));
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)objectValue2).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					text = Conversions.ToString(Operators.ConcatenateObject(text, NewLateBinding.LateGet(objectValue3, null, O.I("UrjZGnTdlnRsR8TeeLyCng=="), new object[0], null, null, null)));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string empty = string.Empty;
			ProjectData.ClearProjectError();
			return empty;
		}
	}

	public static string UZ(MD5 ZC_219, string LVF_220)
	{
		//Discarded unreachable code: IL_007f, IL_0092
		//IL_0089: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		byte[] array = ZC_219.ComputeHash(Encoding.UTF8.GetBytes(LVF_220));
		StringBuilder stringBuilder = new StringBuilder();
		int num = checked(array.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			if (((i % 2 == 0) & (i != checked(array.Length - 1))) && i > 0)
			{
				stringBuilder.Append(O.I("q542gy/+wDIUJhH3OGKnNg=="));
			}
			stringBuilder.Append(array[i].ToString(O.I("00jGcfxtQ9s3AGYCJIG6qg==")));
		}
		return stringBuilder.ToString().ToUpper();
	}
}
