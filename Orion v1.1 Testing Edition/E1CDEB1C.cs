using System;
using System.IO;
using System.Runtime.CompilerServices;

public abstract class E1CDEB1C
{
	private readonly BD40D64C RichTextBoxWordPunctuations_002D1730855;

	private readonly ushort ConvertEventHandler_002D1830576;

	[CompilerGenerated]
	private BD40D64C ImmutablePropertyDescriptorGridEntry_002D3946366;

	public BD40D64C SelectionMode_002D3150434
	{
		[CompilerGenerated]
		get
		{
			object[] array = new object[1] { this };
			_ = array[0];
			_ = null;
			/*Error: Unexpected end of block*/;
		}
		[CompilerGenerated]
		set
		{
			object[] array = new object[2] { this, value };
			object obj = array[0];
			object obj2 = null;
			_ = ((object[])obj)[1];
			BD40D64C bD40D64C = (((E1CDEB1C)obj2).ImmutablePropertyDescriptorGridEntry_002D3946366 = null);
		}
	}

	internal E1CDEB1C(BD40D64C ToolStripDropDownCloseReason_002D3548669, BD40D64C ToolStripItemEventHandler_002D3183392, ushort ConvertEventHandler_002D1830576)
	{
		//IL_0036: Expected O, but got I4
		//IL_0056: Expected I4, but got O
		object obj = (new object[4] { this, ToolStripDropDownCloseReason_002D3548669, ToolStripItemEventHandler_002D3183392, ConvertEventHandler_002D1830576 })[0];
		object obj2 = null;
		object obj3 = ((object[])obj)[2];
		BD40D64C selectionMode_002D = null;
		object obj4 = ((object[])obj3)[3];
		ushort convertEventHandler_002D = (ushort)(int)null;
		_ = ((object[])obj4)[1];
		BD40D64C richTextBoxWordPunctuations_002D = null;
		obj2._002Ector();
		((E1CDEB1C)obj2).RichTextBoxWordPunctuations_002D1730855 = richTextBoxWordPunctuations_002D;
		((E1CDEB1C)obj2).SelectionMode_002D3150434 = selectionMode_002D;
		((E1CDEB1C)obj2).ConvertEventHandler_002D1830576 = convertEventHandler_002D;
	}

	protected abstract void Write(BinaryWriter AutoIncrementInt_002D7597938);

	private byte[] VariableSymbol_002D7091555()
	{
		object[] array = new object[1] { this };
		_ = ((object[])null)[0];
		_ = null;
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	public void XmlDataDocument_002D2943522(string BindingCompleteContext_002D7946121)
	{
		object[] array = new object[2] { this, BindingCompleteContext_002D7946121 };
		object obj = array[0];
		object obj2 = null;
		_ = ((object[])obj)[1];
		string pREDEFPROP_002D = null;
		((E1CDEB1C)obj2).ComboBoxState_002D1007033(pREDEFPROP_002D, ((E1CDEB1C)obj2).RichTextBoxWordPunctuations_002D1730855, ((E1CDEB1C)obj2).SelectionMode_002D3150434, ((E1CDEB1C)obj2).ConvertEventHandler_002D1830576);
	}

	private void ComboBoxState_002D1007033(string PREDEFPROP_002D5634900, BD40D64C ColumnHeaderAutoResizeStyle_002D5334539, BD40D64C DataGridViewSortCompareEventArgs_002D4359569, ushort BindingCompleteState_002D566889)
	{
		//IL_0041: Expected O, but got I4
		//IL_0068: Expected I4, but got O
		object[] array = new object[5] { this, PREDEFPROP_002D5634900, ColumnHeaderAutoResizeStyle_002D5334539, DataGridViewSortCompareEventArgs_002D4359569, BindingCompleteState_002D566889 };
		Array array2;
		object obj = ((object[])(array2 = null))[2];
		BD40D64C comPropertyDescriptorRefresh_002D = null;
		_ = ((object[])obj)[3];
		BD40D64C binOpMask_002D = null;
		object obj2 = ((object[])null)[4];
		ushort flatStyle_002D = (ushort)(int)null;
		object obj3 = ((object[])obj2)[0];
		object obj4 = null;
		_ = ((object[])obj3)[1];
		string dataGridViewComboBoxEditingControl_002D = null;
		array2 = ((E1CDEB1C)obj4).VariableSymbol_002D7091555();
		DataGridViewRowEventHandler_002D3645728(dataGridViewComboBoxEditingControl_002D, comPropertyDescriptorRefresh_002D, binOpMask_002D, flatStyle_002D, (byte[])array2);
	}

	private static void DataGridViewRowEventHandler_002D3645728(string DataGridViewComboBoxEditingControl_002D7828898, BD40D64C ComPropertyDescriptorRefresh_002D2068770, BD40D64C BinOpMask_002D6402677, ushort FlatStyle_002D8095174, byte[] StreamDataFeed_002D4964890)
	{
		object[] object_ = new object[5] { DataGridViewComboBoxEditingControl_002D7828898, ComPropertyDescriptorRefresh_002D2068770, BinOpMask_002D6402677, FlatStyle_002D8095174, StreamDataFeed_002D4964890 };
		new _78175594().method_112(object_, 3478222);
	}
}
