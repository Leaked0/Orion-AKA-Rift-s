using System;
using System.Runtime.InteropServices;

public abstract class _592C5D9E
{
	public enum BCC3AE7C
	{
		CheckedContext_002D9410248 = 6
	}

	public const ushort GetNameItemEvent_002D1142854 = 0;

	public const ushort SplitterPanel_002D4229460 = 0;

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr BeginUpdateResourceW(string ScrollBar_002D2097209, bool IOType_002D8207526);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern bool UpdateResourceW(IntPtr AggKindEnum_002D1113290, IntPtr EXPRLOCAL_002D5836063, IntPtr ACCESS_002D1269551, ushort ToolStripItemDesignerAvailability_002D7160633, byte[] ARRAYMETHOD_002D7661600, uint KeyPair_0060_002D5845374);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern bool EndUpdateResourceW(IntPtr DataGridViewRowPrePaintEventHandler_002D1840158, bool QueryContinueDragEventArgs_002D5793587);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern void RtlMoveMemory(IntPtr EXPRMETHODINFO_002D7717710, IntPtr SqlFileStream_002D4872894, uint LoadOption_002D6072752);

	protected _592C5D9E()
	{
		_ = (new object[1] { this })[0];
		((object)null)._002Ector();
	}
}
