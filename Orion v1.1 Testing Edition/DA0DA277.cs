using System;
using System.Runtime.InteropServices;

internal sealed class DA0DA277 : IDisposable
{
	private IntPtr DrawListViewColumnHeaderEventHandler_002D2367639;

	private readonly bool EXPRFIELDINFO_002D4436423;

	private bool QueryContinueDragEventHandler_002D9915365
	{
		get
		{
			object[] array = new object[1] { this };
			_ = array[0];
			object obj = null;
			_ = ((DA0DA277)obj).DrawListViewColumnHeaderEventHandler_002D2367639;
			_ = null;
			/*Error: Unexpected end of block*/;
		}
	}

	public IntPtr VariableSymbol_002D7091555
	{
		get
		{
			object[] array = new object[1] { this };
			_ = array[0];
			object obj = null;
			if (((DA0DA277)obj).QueryContinueDragEventHandler_002D9915365)
			{
			}
			/*Error: Unexpected end of block*/;
		}
	}

	public DA0DA277(IntPtr SqlInfoMessageEventHandler_002D3833934, int RelatedView_002D6841256)
	{
		object[] object_ = new object[3] { this, SqlInfoMessageEventHandler_002D3833934, RelatedView_002D6841256 };
		new _78175594().method_112(object_, 3606496);
	}

	public void Dispose()
	{
		object[] array = new object[1] { this };
		_ = array[0];
		object obj = null;
		if (((DA0DA277)obj).EXPRFIELDINFO_002D4436423 && !((DA0DA277)obj).QueryContinueDragEventHandler_002D9915365)
		{
			Marshal.FreeHGlobal(((DA0DA277)obj).DrawListViewColumnHeaderEventHandler_002D2367639);
			((DA0DA277)obj).DrawListViewColumnHeaderEventHandler_002D2367639 = IntPtr.Zero;
		}
	}
}
