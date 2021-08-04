using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace My
{
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[HideModuleName]
	[StandardModule]
	internal sealed class W
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class UV
		{
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(UV);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public UV()
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class H<T> where T : new()
		{
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (m_ThreadStaticValue == null)
					{
						m_ThreadStaticValue = new T();
					}
					return m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public H()
			{
			}
		}

		private static readonly H<E> B_0 = new H<E>();

		private static readonly H<_P> S_1 = new H<_P>();

		private static readonly H<User> PY_2 = new H<User>();

		private static readonly H<UV> UT_3 = new H<UV>();

		[HelpKeyword("My.Computer")]
		internal static E F_4
		{
			[DebuggerHidden]
			get
			{
				//Discarded unreachable code: IL_000b, IL_001e
				//IL_0015: Expected O, but got I4
				return B_0.GetInstance;
			}
		}

		[HelpKeyword("My.Application")]
		internal static _P G_5
		{
			[DebuggerHidden]
			get
			{
				//Discarded unreachable code: IL_000b, IL_001e
				//IL_0015: Expected O, but got I4
				return S_1.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static User X_6
		{
			[DebuggerHidden]
			get
			{
				//Discarded unreachable code: IL_000b, IL_001e
				//IL_0015: Expected O, but got I4
				return PY_2.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static UV L_7
		{
			[DebuggerHidden]
			get
			{
				//Discarded unreachable code: IL_000b, IL_001e
				//IL_0015: Expected O, but got I4
				return UT_3.GetInstance;
			}
		}
	}
}
