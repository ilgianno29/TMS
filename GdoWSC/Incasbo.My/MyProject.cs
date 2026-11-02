using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;

namespace Incasbo.My;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		private readonly ContextValue<T> m_Context;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				T val = m_Context.Value;
				if (val == null)
				{
					val = new T();
					m_Context.Value = val;
				}
				return val;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
			m_Context = new ContextValue<T>();
		}
	}
}
