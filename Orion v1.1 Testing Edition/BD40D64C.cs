using System;
using System.Runtime.InteropServices;

public class BD40D64C
{
	private IntPtr TableLayoutCellPaintEventArgs_002D7610011;

	public IntPtr TreeAccessMethod_002D6590789
	{
		get
		{
			object[] array = new object[1] { this };
			_ = array[0];
			_ = null;
			/*Error: Unexpected end of block*/;
		}
		private set
		{
			//IL_0020: Expected O, but got I
			//IL_0038: Expected I, but got O
			object[] array = new object[2]
			{
				this,
				(nint)value
			};
			object obj = array[0];
			object obj2 = null;
			_ = ((object[])obj)[1];
			nint num = (nint)null;
			((BD40D64C)obj2).TableLayoutCellPaintEventArgs_002D7610011 = (MouseEventArgs_002D119196(num) ? ((IntPtr)num) : Marshal.StringToHGlobalUni(Marshal.PtrToStringUni(num)));
		}
	}

	private string SymbolLoader_002D5495574
	{
		get
		{
			object[] array = new object[1] { this };
			_ = array[0];
			object obj = null;
			if (!((BD40D64C)obj).ListManagerBindingsCollection_002D943815())
			{
			}
			/*Error: Unexpected end of block*/;
		}
	}

	public BD40D64C(uint DrawListViewSubItemEventHandler_002D7458467)
	{
		//IL_0020: Expected O, but got I4
		//IL_0030: Expected I4, but got O
		//IL_005c: Expected I8, but got I4
		//IL_0061: Expected I8, but got O
		object obj = (new object[2] { this, DrawListViewSubItemEventHandler_002D7458467 })[1];
		uint num = (uint)(int)null;
		_ = ((object[])obj)[0];
		object obj2 = null;
		((BD40D64C)obj2).TableLayoutCellPaintEventArgs_002D7610011 = IntPtr.Zero;
		obj2._002Ector();
		((BD40D64C)obj2).TreeAccessMethod_002D6590789 = new IntPtr((long)(object)(ulong)(int)num);
	}

	public BD40D64C(_1560B594._28D158FD DataTableNewRowEventHandler_002D2764305)
	{
		//IL_0020: Expected O, but got I4
		//IL_0030: Expected I4, but got O
		object obj = (new object[2] { this, DataTableNewRowEventHandler_002D2764305 })[1];
		_1560B594._28D158FD _28D158FD = (_1560B594._28D158FD)null;
		_ = ((object[])obj)[0];
		object obj2 = null;
		((BD40D64C)obj2).TableLayoutCellPaintEventArgs_002D7610011 = IntPtr.Zero;
		obj2._002Ector();
		((BD40D64C)obj2).TreeAccessMethod_002D6590789 = (IntPtr)(int)_28D158FD;
	}

	private bool ListManagerBindingsCollection_002D943815()
	{
		object[] array = new object[1] { this };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	private static bool MouseEventArgs_002D119196(IntPtr View_002D2442387)
	{
		//IL_0015: Expected O, but got I
		object[] array = new object[1] { (nint)View_002D2442387 };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	public override string ToString()
	{
		object[] array = new object[1] { this };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	public override int GetHashCode()
	{
		object[] array = new object[1] { this };
		_ = ((object[])null)[0];
		object obj = null;
		_ = null;
		if (!((BD40D64C)obj).ListManagerBindingsCollection_002D943815())
		{
		}
		/*Error: Unexpected end of block*/;
	}

	public override bool Equals(object EXPRFIELD_002D304700)
	{
		object[] object_ = new object[2] { this, EXPRFIELD_002D304700 };
		return (bool)new _78175594().method_112(object_, 3457200);
	}
}
