using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class AZI
{
	private struct QPD
	{
		public long size;

		public long type;
	}

	private struct AV
	{
		public long row_id;

		public string[] content;
	}

	private struct OGA
	{
		public long row_id;

		public string item_type;

		public string item_name;

		public string astable_name;

		public long root_num;

		public string sql_statement;
	}

	private byte[] RJD_125;

	private ushort DT_126;

	private ulong OH_127;

	private OGA[] HFR_128;

	private byte[] XPB_129;

	private AV[] JM_130;

	private string[] FVE_131;

	private int DU(int UTE_298)
	{
		//Discarded unreachable code: IL_0047, IL_005a
		//IL_0051: Expected O, but got I4
		if (UTE_298 > RJD_125.Length)
		{
			return 0;
		}
		checked
		{
			int num = UTE_298 + 8;
			for (int i = UTE_298; i <= num; i++)
			{
				if (i > RJD_125.Length - 1)
				{
					return 0;
				}
				if ((RJD_125[i] & 0x80) != 128)
				{
					return i;
				}
			}
			return UTE_298 + 8;
		}
	}

	private long AHH(int PSL_299, int SH__300)
	{
		//Discarded unreachable code: IL_0131, IL_0144
		//IL_013b: Expected O, but got I4
		//IL_013c: Expected I8, but got I4
		checked
		{
			SH__300++;
			byte[] array = new byte[8];
			object left = SH__300 - PSL_299;
			bool flag = false;
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(left, 0, false), Operators.CompareObjectGreater(left, 9, false))))
			{
				return 0L;
			}
			if (Operators.ConditionalCompareObjectEqual(left, 1, false))
			{
				array[0] = (byte)(RJD_125[PSL_299] & 0x7F);
				return BitConverter.ToInt64(array, 0);
			}
			if (Operators.ConditionalCompareObjectEqual(left, 9, false))
			{
				flag = true;
			}
			int num = 1;
			int num2 = 7;
			int num3 = 0;
			if (flag)
			{
				array[0] = RJD_125[SH__300 - 1];
				SH__300--;
				num3 = 1;
			}
			for (int i = SH__300 - 1; i >= PSL_299; i += -1)
			{
				if (i - 1 >= PSL_299)
				{
					array[num3] = (byte)unchecked(((byte)((uint)RJD_125[i] >> (checked(num - 1) & 7)) & (255 >> num)) | (byte)(RJD_125[checked(i - 1)] << (num2 & 7)));
					num++;
					num3++;
					num2--;
				}
				else if (!flag)
				{
					array[num3] = (byte)(unchecked((byte)((uint)RJD_125[i] >> (checked(num - 1) & 7))) & (255 >> num));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}
	}

	private bool GK(long VOB_301)
	{
		//Discarded unreachable code: IL_0009, IL_001c
		//IL_0013: Expected O, but got I4
		return (VOB_301 & 1) == 1;
	}

	private ulong CPK(int NEY__302, int ORX_303)
	{
		//Discarded unreachable code: IL_0033, IL_0046
		//IL_003d: Expected O, but got I4
		//IL_003e: Expected I8, but got I4
		if (ORX_303 > 8 || ORX_303 == 0)
		{
			return 0uL;
		}
		ulong num = 0uL;
		checked
		{
			int num2 = ORX_303 - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = (num << 8) | RJD_125[NEY__302 + i];
			}
			return num;
		}
	}

	private void RG(ulong NU_304)
	{
		//Discarded unreachable code: IL_084b, IL_085e
		//IL_0855: Expected O, but got I4
		checked
		{
			if (RJD_125[(int)NU_304] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(CPK(Convert.ToInt32(decimal.Add(new decimal(NU_304), new decimal(3L))), 2)), 1m));
				int num2 = 0;
				if (HFR_128 != null)
				{
					num2 = HFR_128.Length;
					HFR_128 = (OGA[])Utils.CopyArray(HFR_128, new OGA[HFR_128.Length + unchecked((int)num) + 1]);
				}
				else
				{
					HFR_128 = new OGA[unchecked((int)num) + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = CPK(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(NU_304), new decimal(8L)), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(NU_304), new decimal(100L)) != 0)
					{
						num4 += NU_304;
					}
					object obj = DU((int)num4);
					long num5 = AHH((int)num4, Conversions.ToInteger(obj));
					object obj2 = DU(Conversions.ToInteger(Operators.AddObject(Operators.AddObject(num4, Operators.SubtractObject(obj, num4)), 1)));
					HFR_128[num2 + i].row_id = AHH(Conversions.ToInteger(Operators.AddObject(Operators.AddObject(num4, Operators.SubtractObject(obj, num4)), 1)), Conversions.ToInteger(obj2));
					num4 = Conversions.ToULong(Operators.AddObject(Operators.AddObject(num4, Operators.SubtractObject(obj2, num4)), 1));
					obj = DU((int)num4);
					obj2 = RuntimeHelpers.GetObjectValue(obj);
					long value = AHH((int)num4, Conversions.ToInteger(obj));
					long[] array = new long[5];
					int num6 = 0;
					do
					{
						obj = Operators.AddObject(obj2, 1);
						obj2 = DU(Conversions.ToInteger(obj));
						array[num6] = AHH(Conversions.ToInteger(obj), Conversions.ToInteger(obj2));
						if (array[num6] > 9)
						{
							if (GK(array[num6]))
							{
								array[num6] = (long)Math.Round((double)(array[num6] - 13) / 2.0);
							}
							else
							{
								array[num6] = (long)Math.Round((double)(array[num6] - 12) / 2.0);
							}
						}
						else
						{
							array[num6] = XPB_129[(int)array[num6]];
						}
						num6++;
					}
					while (num6 <= 4);
					if (decimal.Compare(new decimal(OH_127), 1m) == 0)
					{
						HFR_128[num2 + i].item_type = Encoding.Default.GetString(RJD_125, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(OH_127), new decimal(2L)) == 0)
					{
						HFR_128[num2 + i].item_type = Encoding.Unicode.GetString(RJD_125, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(OH_127), new decimal(3L)) == 0)
					{
						HFR_128[num2 + i].item_type = Encoding.BigEndianUnicode.GetString(RJD_125, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					if (decimal.Compare(new decimal(OH_127), 1m) == 0)
					{
						HFR_128[num2 + i].item_name = Encoding.Default.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(OH_127), new decimal(2L)) == 0)
					{
						HFR_128[num2 + i].item_name = Encoding.Unicode.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(OH_127), new decimal(3L)) == 0)
					{
						HFR_128[num2 + i].item_name = Encoding.BigEndianUnicode.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					HFR_128[num2 + i].root_num = (long)CPK(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					if (decimal.Compare(new decimal(OH_127), 1m) == 0)
					{
						HFR_128[num2 + i].sql_statement = Encoding.Default.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(OH_127), new decimal(2L)) == 0)
					{
						HFR_128[num2 + i].sql_statement = Encoding.Unicode.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(OH_127), new decimal(3L)) == 0)
					{
						HFR_128[num2 + i].sql_statement = Encoding.BigEndianUnicode.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
				}
			}
			else
			{
				if (RJD_125[(int)NU_304] != 5)
				{
					return;
				}
				decimal value2 = decimal.Subtract(new decimal(CPK(Convert.ToInt32(decimal.Add(new decimal(NU_304), new decimal(3L))), 2)), 1m);
				int num7 = Convert.ToInt32(value2);
				for (int j = 0; j <= num7; j++)
				{
					ushort num8 = (ushort)CPK(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(NU_304), new decimal(12L)), new decimal(j * 2))), 2);
					if (decimal.Compare(new decimal(NU_304), new decimal(100L)) == 0)
					{
						RG(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(CPK(num8, 4)), 1m), new decimal(DT_126))));
					}
					else
					{
						RG(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(CPK((int)(NU_304 + num8), 4)), 1m), new decimal(DT_126))));
					}
				}
				RG(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(CPK(Convert.ToInt32(decimal.Add(new decimal(NU_304), new decimal(8L))), 4)), 1m), new decimal(DT_126))));
			}
		}
	}

	private bool FUF(ulong NDB_305)
	{
		//Discarded unreachable code: IL_0771, IL_0784
		//IL_077b: Expected O, but got I4
		//IL_077c: Expected I8, but got I4
		checked
		{
			try
			{
				if (RJD_125[(int)NDB_305] == 13)
				{
					object obj = decimal.Subtract(new decimal(CPK(Convert.ToInt32(decimal.Add(new decimal(NDB_305), new decimal(3L))), 2)), 1m);
					int num = 0;
					if (JM_130 != null)
					{
						num = JM_130.Length;
						JM_130 = (AV[])Utils.CopyArray(JM_130, new AV[Conversions.ToInteger(Operators.AddObject(JM_130.Length, obj)) + 1]);
					}
					else
					{
						JM_130 = new AV[Conversions.ToInteger(obj) + 1];
					}
					int num2 = Conversions.ToInteger(obj);
					QPD[] array = default(QPD[]);
					for (int i = 0; i <= num2; i++)
					{
						ulong num3 = CPK(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(NDB_305), new decimal(8L)), new decimal(i * 2))), 2);
						if (decimal.Compare(new decimal(NDB_305), new decimal(100L)) != 0)
						{
							num3 += NDB_305;
						}
						object obj2 = DU((int)num3);
						long num4 = AHH((int)num3, Conversions.ToInteger(obj2));
						object obj3 = DU(Conversions.ToInteger(Operators.AddObject(Operators.AddObject(num3, Operators.SubtractObject(obj2, num3)), 1)));
						JM_130[num + i].row_id = AHH(Conversions.ToInteger(Operators.AddObject(Operators.AddObject(num3, Operators.SubtractObject(obj2, num3)), 1)), Conversions.ToInteger(obj3));
						num3 = Conversions.ToULong(Operators.AddObject(Operators.AddObject(num3, Operators.SubtractObject(obj3, num3)), 1));
						obj2 = DU((int)num3);
						obj3 = RuntimeHelpers.GetObjectValue(obj2);
						long num5 = AHH((int)num3, Conversions.ToInteger(obj2));
						long num6 = Conversions.ToLong(Operators.AddObject(Operators.SubtractObject(num3, obj2), 1));
						object obj4 = 0;
						while (num6 < num5)
						{
							array = (QPD[])Utils.CopyArray(array, new QPD[Conversions.ToInteger(obj4) + 1]);
							obj2 = Operators.AddObject(obj3, 1);
							obj3 = DU(Conversions.ToInteger(obj2));
							array[Conversions.ToInteger(obj4)].type = AHH(Conversions.ToInteger(obj2), Conversions.ToInteger(obj3));
							if (array[Conversions.ToInteger(obj4)].type > 9)
							{
								if (GK(array[Conversions.ToInteger(obj4)].type))
								{
									array[Conversions.ToInteger(obj4)].size = (long)Math.Round((double)(array[Conversions.ToInteger(obj4)].type - 13) / 2.0);
								}
								else
								{
									array[Conversions.ToInteger(obj4)].size = (long)Math.Round((double)(array[Conversions.ToInteger(obj4)].type - 12) / 2.0);
								}
							}
							else
							{
								array[Conversions.ToInteger(obj4)].size = XPB_129[(int)array[Conversions.ToInteger(obj4)].type];
							}
							num6 = Conversions.ToLong(Operators.AddObject(Operators.AddObject(num6, Operators.SubtractObject(obj3, obj2)), 1));
							obj4 = Operators.AddObject(obj4, 1);
						}
						JM_130[num + i].content = new string[array.Length - 1 + 1];
						int num7 = 0;
						int num8 = array.Length - 1;
						for (int j = 0; j <= num8; j++)
						{
							if (array[j].type > 9)
							{
								if (!GK(array[j].type))
								{
									if (decimal.Compare(new decimal(OH_127), 1m) == 0)
									{
										JM_130[num + i].content[j] = Encoding.Default.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num3), new decimal(num5)), new decimal(num7))), (int)array[j].size);
									}
									else if (decimal.Compare(new decimal(OH_127), new decimal(2L)) == 0)
									{
										JM_130[num + i].content[j] = Encoding.Unicode.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num3), new decimal(num5)), new decimal(num7))), (int)array[j].size);
									}
									else if (decimal.Compare(new decimal(OH_127), new decimal(3L)) == 0)
									{
										JM_130[num + i].content[j] = Encoding.BigEndianUnicode.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num3), new decimal(num5)), new decimal(num7))), (int)array[j].size);
									}
								}
								else
								{
									JM_130[num + i].content[j] = Encoding.Default.GetString(RJD_125, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num3), new decimal(num5)), new decimal(num7))), (int)array[j].size);
								}
							}
							else
							{
								JM_130[num + i].content[j] = Conversions.ToString(CPK(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num3), new decimal(num5)), new decimal(num7))), (int)array[j].size));
							}
							num7 = (int)(num7 + array[j].size);
						}
					}
				}
				else if (RJD_125[(int)NDB_305] == 5)
				{
					ushort num9 = Convert.ToUInt16(decimal.Subtract(new decimal(CPK(Convert.ToInt32(decimal.Add(new decimal(NDB_305), new decimal(3L))), 2)), 1m));
					int num10 = num9;
					for (int k = 0; k <= num10; k++)
					{
						ushort num11 = (ushort)CPK(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(NDB_305), new decimal(12L)), new decimal(k * 2))), 2);
						FUF(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(CPK((int)(NDB_305 + num11), 4)), 1m), new decimal(DT_126))));
					}
					FUF(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(CPK(Convert.ToInt32(decimal.Add(new decimal(NDB_305), new decimal(8L))), 4)), 1m), new decimal(DT_126))));
				}
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public bool JIG(string G_LX_306)
	{
		//Discarded unreachable code: IL_020b, IL_021e
		//IL_0215: Expected O, but got I4
		int num = -1;
		int num2 = HFR_128.Length;
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				if (HFR_128[i].item_name.ToLower().CompareTo(G_LX_306.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			object[] array = HFR_128[num].sql_statement.Substring(HFR_128[num].sql_statement.IndexOf(O.I("GIcx5sfHziHGu7CT5Zw48g==")) + 1).Split(',');
			int num3 = array.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j] = Strings.LTrim(Conversions.ToString(array[j]));
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array[j], null, O.I("mZysbUSaHHLteng/q812yQ=="), new object[1]
				{
					O.I("0XuB4qT44kEu3Z0S79ooOg==")
				}, null, null, null));
				if (Operators.ConditionalCompareObjectGreater(objectValue, 0, false))
				{
					int num4 = j;
					object instance = array[j];
					string memberName = O.I("BvYEfS5WguySRVl36PmRoQ==");
					object[] array2 = new object[2]
					{
						0,
						RuntimeHelpers.GetObjectValue(objectValue)
					};
					object[] arguments = array2;
					bool[] array3 = new bool[2]
					{
						false,
						true
					};
					object obj = NewLateBinding.LateGet(instance, null, memberName, arguments, null, null, array3);
					if (array3[1])
					{
						objectValue = RuntimeHelpers.GetObjectValue(array2[1]);
					}
					array[num4] = RuntimeHelpers.GetObjectValue(obj);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(array[j], null, O.I("mZysbUSaHHLteng/q812yQ=="), new object[1]
				{
					O.I("QfP7wN0JhgpTasBLaortZQ==")
				}, null, null, null), 0, false))
				{
					break;
				}
				FVE_131 = (string[])Utils.CopyArray(FVE_131, new string[j + 1]);
				FVE_131[j] = Conversions.ToString(array[j]);
			}
			return FUF((ulong)((HFR_128[num].root_num - 1) * unchecked((long)DT_126)));
		}
	}

	public int KW()
	{
		//Discarded unreachable code: IL_0009, IL_001c
		//IL_0013: Expected O, but got I4
		return JM_130.Length;
	}

	public string UDF(int _I_307, int _Z_308)
	{
		//Discarded unreachable code: IL_0039, IL_004c
		//IL_0043: Expected O, but got I4
		if (_I_307 >= JM_130.Length)
		{
			return null;
		}
		if (_Z_308 >= JM_130[_I_307].content.Length)
		{
			return null;
		}
		return JM_130[_I_307].content[_Z_308];
	}

	public string UTA(int IA_309, string LH_310)
	{
		//Discarded unreachable code: IL_0045, IL_0058
		//IL_004f: Expected O, but got I4
		//IL_0050: Expected O, but got I4
		int num = -1;
		int num2 = FVE_131.Length;
		for (int i = 0; i <= num2; i = checked(i + 1))
		{
			if (FVE_131[i].ToLower().CompareTo(LH_310.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return UDF(IA_309, num);
	}

	public string[] _VV()
	{
		//Discarded unreachable code: IL_008a, IL_009d
		//IL_0094: Expected O, but got I4
		//IL_0095: Expected O, but got I4
		object obj = 0;
		checked
		{
			int num = HFR_128.Length - 1;
			string[] array = default(string[]);
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(HFR_128[i].item_type, O.I("eAjGZocM9zk9m1EcTDEIVw=="), false) == 0)
				{
					array = (string[])Utils.CopyArray(array, new string[Conversions.ToInteger(obj) + 1]);
					array[Conversions.ToInteger(obj)] = HFR_128[i].item_name;
					obj = Operators.AddObject(obj, 1);
				}
			}
			return array;
		}
	}

	public AZI(string baseName)
	{
		//Discarded unreachable code: IL_011a, IL_012d
		//IL_0124: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		XPB_129 = new byte[10]
		{
			0,
			1,
			2,
			3,
			4,
			6,
			8,
			8,
			0,
			0
		};
		checked
		{
			if (File.Exists(baseName))
			{
				FileSystem.FileOpen(1, baseName, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared);
				string Value = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref Value, -1L);
				FileSystem.FileClose(1);
				RJD_125 = Encoding.Default.GetBytes(Value);
				if (Encoding.Default.GetString(RJD_125, 0, 15).CompareTo("SQLite format 3") != 0)
				{
					throw new Exception("Not a valid SQLite 3 Database File");
				}
				if (RJD_125[52] != 0)
				{
					throw new Exception("Auto-vacuum capable database is not supported");
				}
				DT_126 = (ushort)CPK(16, 2);
				OH_127 = CPK(56, 4);
				if (decimal.Compare(new decimal(OH_127), 0m) == 0)
				{
					OH_127 = 1uL;
				}
				RG(100uL);
			}
		}
	}
}
