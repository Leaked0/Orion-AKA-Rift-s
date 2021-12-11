using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class _49B29FF2
{
	public const int FlatButtonAppearance_002D908499 = 0;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int GetScrollPos(IntPtr HtmlShimManager_002D9930932, int ParameterDirection_002D7551389);

	public static bool ConstCastResult_002D3687952(this ListView BinOpFuncKind_002D3359414, int SmiConnection_002D6978950, int ToolTipIcon_002D4716565, out int ConstraintConverter_002D7578480, out int ComICategorizePropertiesHandler_002D28406)
	{
		object[] array = new object[5] { BinOpFuncKind_002D3359414, SmiConnection_002D6978950, ToolTipIcon_002D4716565, ConstraintConverter_002D7578480, ComICategorizePropertiesHandler_002D28406 };
		try
		{
			return (bool)new _78175594().method_112(array, 3430812);
		}
		finally
		{
			ConstraintConverter_002D7578480 = (int)array[3];
			ComICategorizePropertiesHandler_002D28406 = (int)array[4];
		}
	}

	public static int ForeachKind_002D4321466(this ListView _GUID_002D1547100, int DataGridViewComboBoxColumn_002D6017064)
	{
		//IL_0020: Expected O, but got I4
		//IL_002e: Expected I4, but got O
		//IL_0045: Expected I4, but got O
		//IL_009e: Incompatible stack heights: 6 vs 0
		//IL_00b1: Incompatible stack heights: 0 vs 6
		object[] array = new object[2] { _GUID_002D1547100, DataGridViewComboBoxColumn_002D6017064 };
		int num = (int)null;
		List<ColumnHeader> list;
		_ = ((object[])(object)(list = null))[0];
		ListView listView = null;
		_ = ((object[])null)[1];
		int num2 = (int)null;
		num2 += GetScrollPos(listView.Handle, 0);
		list = listView.DataGridViewHitTestType_002D9596967();
		for (num = 0; num < list.Count; num++)
		{
			num2 -= list[num].Width;
			if (num2 <= 0)
			{
				break;
			}
		}
		/*Error: Unexpected end of block*/;
	}

	public static List<ColumnHeader> DataGridViewHitTestType_002D9596967(this ListView SqlSingle_002D4656026)
	{
		//IL_0023: Expected I4, but got O
		//IL_0029: Expected I4, but got O
		//IL_0096: Incompatible stack heights: 6 vs 0
		//IL_00ae: Incompatible stack heights: 0 vs 6
		object[] array = new object[1] { SqlSingle_002D4656026 };
		int num = (int)null;
		int num2 = (int)null;
		_ = null;
		List<ColumnHeader> list;
		_ = ((object[])(object)(list = null))[0];
		ListView listView = null;
		list = new List<ColumnHeader>();
		num = 0;
		while (true)
		{
			if (num < listView.Columns.Count)
			{
				for (num2 = 0; num2 < listView.Columns.Count; num2++)
				{
					if (listView.Columns[num2].DisplayIndex == num)
					{
						goto IL_00b1;
					}
				}
				goto IL_0090;
			}
			goto IL_00b1;
			IL_00b1:
			list.Add(listView.Columns[num2]);
			goto IL_0090;
			IL_0090:
			num++;
		}
	}

	public static void HtmlWindow_002D5749139(this ListView TrackBarRenderer_002D3022942, params string[] NameGenerator_002D1098628)
	{
		//IL_003e: Expected I4, but got O
		//IL_008a: Incompatible stack heights: 6 vs 0
		//IL_009e: Incompatible stack heights: 0 vs 6
		object[] array = new object[2] { TrackBarRenderer_002D3022942, NameGenerator_002D1098628 };
		object obj = array[0];
		ListView listView = null;
		_ = ((object[])obj)[1];
		Array array2 = null;
		int num = (int)null;
		ListViewItem listViewItem = null;
		_ = null;
		listViewItem = listView.Items.Add((string)((object[])array2)[0]);
		for (num = 1; num < (nint)(object)array2.Length; num++)
		{
			listViewItem.SubItems.Add((string)((object[])array2)[num]);
		}
	}

	public static void SqlXml_002D7995579(this ListView MethPropWithInst_002D4418268, params object[] DataGridViewCellFormattingEventArgs_002D3742187)
	{
		object[] object_ = new object[2] { MethPropWithInst_002D4418268, DataGridViewCellFormattingEventArgs_002D3742187 };
		new _78175594().method_112(object_, 3451279);
	}

	public static void MessageDecoder_002D5640719(this ListView DataGridViewRowErrorTextNeededEventHandler_002D3734783, int ComboBoxStyle_002D6151919)
	{
		//IL_0020: Expected O, but got I4
		//IL_002e: Expected I4, but got O
		//IL_0063: Incompatible stack heights: 5 vs 0
		//IL_007b: Incompatible stack heights: 0 vs 5
		object[] array = new object[2] { DataGridViewRowErrorTextNeededEventHandler_002D3734783, ComboBoxStyle_002D6151919 };
		int num = (int)null;
		object obj = ((object[])null)[0];
		ListView listView = null;
		_ = ((object[])obj)[1];
		for (num = 0; num < listView.Columns.Count; num++)
		{
			listView.Columns[num].Width = -2;
		}
	}
}
