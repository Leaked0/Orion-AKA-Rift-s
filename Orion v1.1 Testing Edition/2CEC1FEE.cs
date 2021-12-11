using System;
using System.Runtime.InteropServices;
using System.Text;

internal static class _2CEC1FEE
{
	[Flags]
	public enum _5A5B00CC : uint
	{
		_6AA8208C = 0x1000u,
		_72153512 = 0x2000u
	}

	[Flags]
	public enum _51C16571 : uint
	{
		_62D85F6B = 0x1u,
		_23A8283F = 0x2u,
		_690033DB = 0x4u,
		_01E54A28 = 0x8u,
		_5FA80400 = 0x10u,
		_19627F2D = 0x20u,
		_146217B1 = 0x40u,
		_40EA7801 = 0x100u
	}

	[Flags]
	public enum _15EA2052 : uint
	{
		_14632801 = 0x1u,
		_4B885FFF = 0x2u,
		_16E30110 = 0x4u,
		_12EB3569 = 0x1Fu
	}

	[Flags]
	public enum _2A3249B8 : uint
	{
		_6CCF580B = 0x20000000u,
		_283B3930 = 0x40000000u,
		_1C34222B = 0x80000000u
	}

	public const int _5E994E93 = int.MinValue;

	public const int _3CD47F35 = 3;

	public const int _79934B29 = 128;

	public const int _44C33B93 = 1;

	public const int _603E7B1B = 2;

	public static readonly IntPtr _635A45CD = new IntPtr(-1);

	public static readonly IntPtr _3BD774BF = IntPtr.Zero;

	public static readonly IntPtr _5F606C1C = new IntPtr(-1);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, int int_5, int int_6, IntPtr intptr_3, int int_7, int int_8, IntPtr intptr_4);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, _51C16571 _51C16571_0, int int_5, int int_6, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool FlushViewOfFile(IntPtr intptr_3, int int_5);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, _15EA2052 _15EA2052_0, int int_5, int int_6, IntPtr intptr_4);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr OpenFileMapping(int int_5, bool bool_0, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAlloc(IntPtr intptr_3, UIntPtr uintptr_0, _5A5B00CC _5A5B00CC_0, _51C16571 _51C16571_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualFree(IntPtr intptr_3, uint uint_0, uint uint_1);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, _51C16571 _51C16571_0, out _51C16571 _51C16571_1);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	[DllImport("kernel32", SetLastError = true)]
	public static extern uint EnumSystemFirmwareTables(uint uint_0, IntPtr intptr_3, uint uint_1);

	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetSystemFirmwareTable(uint uint_0, uint uint_1, IntPtr intptr_3, uint uint_2);

	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, IntPtr intptr_4, uint uint_0, out uint uint_1);
}
