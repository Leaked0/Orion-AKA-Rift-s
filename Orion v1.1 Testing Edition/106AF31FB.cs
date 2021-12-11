using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

[DefaultMember("Item")]
public class _106AF31FB : E1CDEB1C
{
	[CompilerGenerated]
	private readonly Dictionary<ushort, string> SqlInt_002D9421617;

	private Dictionary<ushort, string> ToolStripContainer_002D5472397
	{
		[CompilerGenerated]
		get
		{
			object[] array = new object[1] { this };
			_ = array[0];
			_ = null;
			/*Error: Unexpected end of block*/;
		}
	}

	public string ImageList_002D2271716
	{
		get
		{
			//IL_0020: Expected O, but got I4
			object[] array = new object[2] { this, ProgressBarRenderer_002D4316901 };
			_ = ((object[])array[0])[1];
			_ = null;
			/*Error: Unexpected end of block*/;
		}
		set
		{
			//IL_0020: Expected O, but got I4
			//IL_004b: Expected I4, but got O
			object[] array = new object[3] { this, WebBrowserDocumentCompletedEventHandler_002D7311999, value };
			object obj = array[2];
			string value2 = null;
			object obj2 = ((object[])obj)[0];
			object obj3 = null;
			_ = ((object[])obj2)[1];
			ushort key = (ushort)(int)null;
			((_106AF31FB)obj3).ToolStripContainer_002D5472397[key] = value2;
		}
	}

	private ushort IconEffect_002D638403
	{
		get
		{
			object[] array = new object[1] { this };
			_ = array[0];
			_ = null;
			_ = null;
			_ = null;
			/*Error: Unexpected end of block*/;
		}
	}

	public _106AF31FB()
	{
		_ = (new object[1] { this })[0];
		object obj = null;
		((_106AF31FB)obj).SqlInt_002D9421617 = new Dictionary<ushort, string>();
		((E1CDEB1C)obj)._002Ector(new BD40D64C(_1560B594._28D158FD.HtmlToClrEventProxy_002D6838637), (BD40D64C)null, _7A7ADE97.BindingsCollection_002D3668254);
	}

	public static ushort MethodRequiredEnum_002D580296(int SqlDependencyProcessDispatcher_002D4815019)
	{
		//IL_0015: Expected O, but got I4
		object[] array = new object[1] { SqlDependencyProcessDispatcher_002D4815019 };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	protected override void Write(BinaryWriter TypeUniqueIdentifierSchemaImporterExtension_002D2523494)
	{
		//IL_003c: Expected I4, but got O
		//IL_0043: Expected I4, but got O
		//IL_0071: Expected I4, but got O
		//IL_00a0: Expected I4, but got O
		//IL_00c9: Incompatible stack heights: 7 vs 0
		//IL_00d8: Incompatible stack heights: 0 vs 7
		object[] array = new object[2] { this, TypeUniqueIdentifierSchemaImporterExtension_002D2523494 };
		_ = array[1];
		BinaryWriter binaryWriter = null;
		string value = null;
		ushort num = (ushort)(int)null;
		_ = null;
		int num2 = (int)null;
		_ = ((object[])null)[0];
		object obj = null;
		for (num2 = 0; num2 < 16; num2++)
		{
			num = (ushort)(int)(object)(ushort)((((_106AF31FB)obj).IconEffect_002D638403 - 1) * 16 + num2);
			if (((_106AF31FB)obj).ToolStripContainer_002D5472397.TryGetValue(num, out value))
			{
				binaryWriter.Write((ushort)(int)(object)(ushort)value.Length);
				binaryWriter.Write(Encoding.Unicode.GetBytes(value));
			}
			else
			{
				binaryWriter.Write((ushort)0);
			}
		}
	}

	public override string ToString()
	{
		object[] object_ = new object[1] { this };
		return (string)new _78175594().method_112(object_, 3612418);
	}
}
