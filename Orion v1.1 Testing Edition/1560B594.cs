using System;
using System.Runtime.InteropServices;

public abstract class _1560B594
{
	public enum _28D158FD
	{
		HtmlToClrEventProxy_002D6838637 = 6
	}

	public const int XmlIgnoreNamespaceReader_002D4817062 = 2;

	public const int SmiXetterAccessMap_002D4440578 = 161;

	public const ushort TrackBarRenderer_002D3022942 = 0;

	public const ushort ScrollBarRenderer_002D2990427 = 0;

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	[DllImport("kernel32")]
	public static extern bool FreeConsole();

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr EXPRSTMT_002D9496963, int ToolStripArrowRenderEventHandler_002D3655363, int InputLanguageChangingEventArgs_002D7390379, int MissingSchemaAction_002D962570);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr BeginUpdateResourceW(string IndexField_002D8091556, bool AsymmetricSignatureFormatter_002D2861056);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern bool UpdateResourceW(IntPtr MouseEventArgs_002D119196, IntPtr ICommandExecutor_002D733476, IntPtr View_002D8469292, ushort WebBrowserRefreshOption_002D9908027, byte[] ToolStripControlHost_002D8943251, uint EnumThreadWindowsCallback_002D7015543);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern bool EndUpdateResourceW(IntPtr ParameterDirection_002D7551389, bool DataGridViewDataErrorContexts_002D7926805);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern void RtlMoveMemory(IntPtr DockingBehavior_002D2652145, IntPtr TableLayoutSettings_002D2608981, uint SqlQueryMetadataCache_002D4736415);

	[DllImport("kernel32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UpdateResource(IntPtr ICSharpInvokeOrInvokeMemberBinder_002D5398249, IntPtr TextBoxAutoCompleteSourceConverter_002D8112238, IntPtr AnchorStyles_002D9039156, short PaintEventHandler_002D4643885, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] GlobalSymbolContext_002D6347519, int TreeViewHitTestInfo_002D5460967);

	protected _1560B594()
	{
		_ = (new object[1] { this })[0];
		((object)null)._002Ector();
	}
}
