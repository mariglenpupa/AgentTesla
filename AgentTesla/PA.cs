using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.VisualBasic.CompilerServices;

internal class PA
{
	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess", SetLastError = true)]
	public static extern IntPtr VVP();

	[DllImport("advapi32.dll", EntryPoint = "GetKernelObjectSecurity", SetLastError = true)]
	public static extern bool AK(IntPtr HU_209, int PLQ_210, [Out] byte[] LLS_211, uint QQ_212, ref uint LTY_213);

	[DllImport("advapi32.dll", EntryPoint = "SetKernelObjectSecurity", SetLastError = true)]
	public static extern bool SH(IntPtr XI_214, int AC__215, byte[] UHS_216);

	private T SEO<T>(ref T QF_217, T EY_218)
	{
		//Discarded unreachable code: IL_0009, IL_001c
		//IL_0013: Expected O, but got I4
		QF_217 = EY_218;
		return EY_218;
	}

	private RawSecurityDescriptor GJPI()
	{
		//Discarded unreachable code: IL_006f, IL_0082
		//IL_0079: Expected O, but got I4
		IntPtr hU_ = VVP();
		byte[] QF_ = new byte[1];
		uint LTY_ = 0u;
		try
		{
			AK(hU_, 4, QF_, 0u, ref LTY_);
			if ((long)LTY_ < 0L || (long)LTY_ > 32767L)
			{
				return null;
			}
			checked
			{
				if (!AK(hU_, 4, SEO(ref QF_, new byte[(int)(unchecked((long)LTY_) - 1L) + 1]), LTY_, ref LTY_))
				{
					return null;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return new RawSecurityDescriptor(QF_, 0);
	}

	public bool JG()
	{
		//Discarded unreachable code: IL_006b, IL_007e
		//IL_0075: Expected O, but got I4
		IntPtr xI_ = VVP();
		try
		{
			RawSecurityDescriptor rawSecurityDescriptor = GJPI();
			rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 987135, new SecurityIdentifier(WellKnownSidType.WorldSid, null), false, null));
			byte[] array = new byte[checked(rawSecurityDescriptor.BinaryLength - 1 + 1)];
			rawSecurityDescriptor.GetBinaryForm(array, 0);
			if (SH(xI_, 4, array))
			{
				return true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return false;
	}

	public bool IT()
	{
		//Discarded unreachable code: IL_0056, IL_0069
		//IL_0060: Expected O, but got I4
		IntPtr xI_ = VVP();
		try
		{
			RawSecurityDescriptor rawSecurityDescriptor = GJPI();
			rawSecurityDescriptor.DiscretionaryAcl.RemoveAce(0);
			byte[] array = new byte[checked(rawSecurityDescriptor.BinaryLength - 1 + 1)];
			rawSecurityDescriptor.GetBinaryForm(array, 0);
			if (SH(xI_, 4, array))
			{
				return true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return false;
	}
}
