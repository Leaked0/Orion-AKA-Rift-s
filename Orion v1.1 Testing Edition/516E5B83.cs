using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;

internal static class _516E5B83
{
	[Serializable]
	[CompilerGenerated]
	private sealed class EF036490
	{
		public static readonly EF036490 RichTextBoxSelectionTypes_002D4644506;

		public static Func<string, char> MethodTypeInferrer_002D5090698;

		static EF036490()
		{
			_ = null;
			RichTextBoxSelectionTypes_002D4644506 = new EF036490();
		}

		public EF036490()
		{
			_ = (new object[1] { this })[0];
			((object)null)._002Ector();
		}

		internal char BinOpFuncKind_002D3359414(string SqlDataReaderSmi_002D1468224)
		{
			object[] array = new object[2] { this, SqlDataReaderSmi_002D1468224 };
			_ = ((object[])array[0])[1];
			string text = null;
			_ = null;
			/*Error: Unexpected end of block*/;
		}
	}

	public static readonly string NumericUpDownAcceleration_002D2598810;

	public static bool IsolationLevel_002D4619105;

	public static bool ScrollButton_002D8815475;

	public static string SqlClientEncryptionAlgorithm_002D2000378;

	public static string Panel_002D3120523;

	private static readonly Random PredefinedName_002D9631319;

	public static bool DockingBehavior_002D2652145;

	[CompilerGenerated]
	private static string DataTableClearEventArgs_002D3837083;

	[CompilerGenerated]
	private static string DataGridViewTextBoxEditingControl_002D2479607;

	[CompilerGenerated]
	private static string NameManager_002D4343992;

	[CompilerGenerated]
	private static string DragEventArgs_002D7897977;

	public static string ToolStripDropDownClosingEventArgs_002D7866129
	{
		[CompilerGenerated]
		get
		{
			_ = null;
			_ = null;
			/*Error: Unexpected end of block*/;
		}
		[CompilerGenerated]
		set
		{
			object[] array = new object[1] { value };
			_ = array[0];
			string text = (DataTableClearEventArgs_002D3837083 = null);
		}
	}

	public static string TypeSmallIntSchemaImporterExtension_002D1022140
	{
		[CompilerGenerated]
		get
		{
			_ = null;
			_ = null;
			/*Error: Unexpected end of block*/;
		}
		[CompilerGenerated]
		set
		{
			object[] array = new object[1] { value };
			_ = array[0];
			string text = (DataGridViewTextBoxEditingControl_002D2479607 = null);
		}
	}

	public static string IMessageFilter_002D8084678
	{
		[CompilerGenerated]
		get
		{
			_ = null;
			_ = null;
			/*Error: Unexpected end of block*/;
		}
		[CompilerGenerated]
		set
		{
			object[] array = new object[1] { value };
			_ = array[0];
			string text = (NameManager_002D4343992 = null);
		}
	}

	public static string ContainerControl_002D7417779
	{
		[CompilerGenerated]
		get
		{
			_ = null;
			_ = null;
			/*Error: Unexpected end of block*/;
		}
		[CompilerGenerated]
		set
		{
			object[] array = new object[1] { value };
			_ = array[0];
			string text = (DragEventArgs_002D7897977 = null);
		}
	}

	public static string ARRAYMETHOD_002D7661600()
	{
		_ = null;
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	public static string GlobalAttributeDeclaration_002D7191869(int MergeAction_002D5204409)
	{
		//IL_0015: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		object[] array = new object[1] { MergeAction_002D5204409 };
		_ = array[0];
		int count = (int)null;
		Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", count);
		_ = EF036490.MethodTypeInferrer_002D5090698 ?? null;
		/*Error: Unexpected end of block*/;
	}

	private static string Cursor_002D2189612(string HtmlWindow_002D5749139)
	{
		object[] object_ = new object[1] { HtmlWindow_002D5749139 };
		return (string)new _78175594().method_112(object_, 3431198);
	}

	private static object CheckBox_002D1480468(ManagementObject GetAttributesEventHandler_002D6406963)
	{
		object[] array = new object[1] { GetAttributesEventHandler_002D6406963 };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	private static object ComboBoxRenderer_002D9239589(ManagementObject ServerInfo_002D2072995)
	{
		object[] array = new object[1] { ServerInfo_002D2072995 };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	private static object TransparentIdentifierMemberSymbol_002D2646332(ManagementObject BOID_002D1581318)
	{
		object[] array = new object[1] { BOID_002D1581318 };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	private static object MappingType_002D6056795(ManagementObject DataGridViewCellStateChangedEventHandler_002D3566387)
	{
		object[] array = new object[1] { DataGridViewCellStateChangedEventHandler_002D3566387 };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	private static object SchemaSerializationMode_002D9426622(ManagementObject SimpleType_002D5572372)
	{
		object[] array = new object[1] { SimpleType_002D5572372 };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	public static string DataGridViewCellValueEventHandler_002D5026473()
	{
		_ = null;
		_ = null;
		object obj = null;
		_ = null;
		object obj2 = null;
		_ = null;
		_ = null;
		object obj3 = null;
		obj3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get().Cast<ManagementObject>().Select(CheckBox_002D1480468)
			.FirstOrDefault();
		obj = new ManagementObjectSearcher("SELECT * from Win32_VideoController").Get().Cast<ManagementObject>().Select(TransparentIdentifierMemberSymbol_002D2646332)
			.FirstOrDefault();
		obj2 = new ManagementObjectSearcher("SELECT * from Win32_VideoController").Get().Cast<ManagementObject>().Select(MappingType_002D6056795)
			.FirstOrDefault();
		Cursor_002D2189612(string.Concat(new List<string>
		{
			obj?.ToString(),
			"|",
			obj3?.ToString(),
			"|",
			obj2?.ToString()
		}));
		while (true)
		{
			Cursor_002D2189612((string)/*Error near IL_011d: Stack underflow*/ + (string)/*Error near IL_011d: Stack underflow*/ + null);
		}
	}

	static _516E5B83()
	{
		_ = null;
		NumericUpDownAcceleration_002D2598810 = "https://api.auth.gg/csharp/";
		PredefinedName_002D9631319 = new Random();
	}
}
