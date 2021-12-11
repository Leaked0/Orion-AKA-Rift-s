using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

[CompilerGenerated]
internal static class A21D917D
{
	private static object PredefinedMembers_002D4657806;

	private static Dictionary<string, bool> PropertyGridCommands_002D8896116;

	private static Dictionary<string, string> DataGridViewRowContextMenuStripNeededEventArgs_002D4797296;

	private static Dictionary<string, string> GetAttributesEventHandler_002D8709258;

	private static int DataGridViewColumnDividerDoubleClickEventArgs_002D5234108;

	private static string FlatButtonAppearanceConverter_002D7101248(CultureInfo ColorDepth_002D9152659)
	{
		object[] array = new object[1] { ColorDepth_002D9152659 };
		_ = array[0];
		/*Error: Unexpected end of block*/;
	}

	private static Assembly ScrollProperties_002D8963029(AssemblyName BaseTreeIterator_002D1057985)
	{
		//IL_0049: Expected I4, but got O
		//IL_00b0: Incompatible stack heights: 9 vs 0
		//IL_00c4: Incompatible stack heights: 0 vs 9
		//IL_00c6: Incompatible stack heights: 0 vs 1
		object[] array = new object[1] { BaseTreeIterator_002D1057985 };
		AssemblyName assemblyName = null;
		Array array2 = null;
		Assembly assembly;
		_ = ((object[])(object)(assembly = null))[0];
		AssemblyName assemblyName2 = null;
		AppDomain appDomain = null;
		Array array3 = null;
		int num = (int)null;
		_ = null;
		appDomain = AppDomain.CurrentDomain;
		array2 = appDomain.GetAssemblies();
		array3 = array2;
		num = 0;
		while (true)
		{
			if (num < (nint)(object)array3.Length)
			{
				assembly = (Assembly)((object[])array3)[num];
				assemblyName = assembly.GetName();
				if (!string.Equals(assemblyName.Name, assemblyName2.Name, StringComparison.InvariantCultureIgnoreCase))
				{
					goto IL_00aa;
				}
			}
			else
			{
				_ = null;
			}
			if (string.Equals(FlatButtonAppearanceConverter_002D7101248(assemblyName.CultureInfo), FlatButtonAppearanceConverter_002D7101248(assemblyName2.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
			{
				break;
			}
			goto IL_00aa;
			IL_00aa:
			num++;
		}
		/*Error: Unexpected end of block*/;
	}

	private static void UnresolvedAggregateSymbol_002D820329(Stream MultiSelectRootGridEntry_002D7110518, Stream SqlFileStream_002D4872894)
	{
		//IL_002f: Expected I4, but got O
		//IL_0062: Incompatible stack heights: 6 vs 0
		//IL_007f: Expected I4, but got O
		//IL_0084: Incompatible stack heights: 0 vs 6
		object[] array = new object[2] { MultiSelectRootGridEntry_002D7110518, SqlFileStream_002D4872894 };
		_ = null;
		int num = (int)null;
		_ = ((object[])null)[0];
		Stream stream = null;
		Array array2;
		_ = ((object[])(array2 = null))[1];
		Stream stream2 = null;
		array2 = new byte[81920];
		while ((num = stream.Read((byte[])array2, 0, (int)(object)array2.Length)) != 0)
		{
			stream2.Write((byte[])array2, 0, num);
		}
	}

	private static Stream ValidationConstraints_002D9382479(string CMemberLookupResults_002D9992316)
	{
		object[] object_ = new object[1] { CMemberLookupResults_002D9992316 };
		return (Stream)new _78175594().method_112(object_, 3599929);
	}

	private static Stream IsolationLevel_002D1484903(Dictionary<string, string> PropertyTabChangedEventArgs_002D1229508, string MergePropertyDescriptor_002D9837782)
	{
		//IL_0055: Incompatible stack heights: 5 vs 6
		object[] array = new object[2] { PropertyTabChangedEventArgs_002D1229508, MergePropertyDescriptor_002D9837782 };
		_ = array[1];
		string key = null;
		string value;
		_ = ((object[])(object)(value = null))[0];
		Dictionary<string, string> dictionary = null;
		_ = null;
		if (!dictionary.TryGetValue(key, out value))
		{
			_ = null;
		}
		/*Error: Unexpected end of block*/;
	}

	private static byte[] ToolStripLocationCancelEventHandler_002D7659074(Stream _003CAllConstraintInterfaces_003Ed___002D9189288)
	{
		object[] object_ = new object[1] { _003CAllConstraintInterfaces_003Ed___002D9189288 };
		return (byte[])(Array)new _78175594().method_112(object_, 3592107);
	}

	private static Assembly _0024ArrayType_0024_0024_0024BYQMPBXXZ_002D9775825(Dictionary<string, string> DataViewManager_002D6498145, Dictionary<string, string> XmlTreeGen_002D6061547, AssemblyName GridEntryRecreateChildrenEventArgs_002D7306621)
	{
		object[] object_ = new object[3] { DataViewManager_002D6498145, XmlTreeGen_002D6061547, GridEntryRecreateChildrenEventArgs_002D7306621 };
		return (Assembly)new _78175594().method_112(object_, 3467954);
	}

	public static Assembly TriangleDirection_002D546080(object DataGridViewCellStateChangedEventHandler_002D3566387, ResolveEventArgs DropDownButtonAdapter_002D4010347)
	{
		object[] object_ = new object[2] { DataGridViewCellStateChangedEventHandler_002D3566387, DropDownButtonAdapter_002D4010347 };
		return (Assembly)new _78175594().method_112(object_, 3419707);
	}

	static A21D917D()
	{
		_ = null;
		PredefinedMembers_002D4657806 = new object();
		PropertyGridCommands_002D8896116 = new Dictionary<string, bool>();
		DataGridViewRowContextMenuStripNeededEventArgs_002D4797296 = new Dictionary<string, string>();
		GetAttributesEventHandler_002D8709258 = new Dictionary<string, string>();
		DataGridViewRowContextMenuStripNeededEventArgs_002D4797296.Add("autoupdater.net", "costura.autoupdater.net.dll.compressed");
		GetAttributesEventHandler_002D8709258.Add("autoupdater.net", "costura.autoupdater.net.pdb.compressed");
		DataGridViewRowContextMenuStripNeededEventArgs_002D4797296.Add("costura", "costura.costura.dll.compressed");
		GetAttributesEventHandler_002D8709258.Add("costura", "costura.costura.pdb.compressed");
		DataGridViewRowContextMenuStripNeededEventArgs_002D4797296.Add("guna.ui2", "costura.guna.ui2.dll.compressed");
		DataGridViewRowContextMenuStripNeededEventArgs_002D4797296.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		DataGridViewRowContextMenuStripNeededEventArgs_002D4797296.Add("ookii.dialogs.winforms", "costura.ookii.dialogs.winforms.dll.compressed");
		GetAttributesEventHandler_002D8709258.Add("ookii.dialogs.winforms", "costura.ookii.dialogs.winforms.pdb.compressed");
		DataGridViewRowContextMenuStripNeededEventArgs_002D4797296.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
	}

	public static void AccessibleNavigation_002D9553235()
	{
		_ = null;
		AppDomain appDomain = null;
		_ = null;
		if (Interlocked.Exchange(ref DataGridViewColumnDividerDoubleClickEventArgs_002D5234108, 1) != 1)
		{
			appDomain = AppDomain.CurrentDomain;
			appDomain.AssemblyResolve += delegate(object DataGridViewCellStateChangedEventHandler_002D3566387, ResolveEventArgs DropDownButtonAdapter_002D4010347)
			{
				object[] object_ = new object[2] { DataGridViewCellStateChangedEventHandler_002D3566387, DropDownButtonAdapter_002D4010347 };
				return (Assembly)new _78175594().method_112(object_, 3419707);
			};
		}
	}
}
