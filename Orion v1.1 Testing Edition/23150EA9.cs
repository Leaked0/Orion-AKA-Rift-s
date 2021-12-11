using System;
using System.Runtime.InteropServices;

public static class _23150EA9
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void _00955BDD(int int_0, int[] int_1);

	private static readonly byte[] _63E943B1 = new byte[30]
	{
		85, 139, 236, 83, 87, 139, 69, 8, 15, 162,
		139, 125, 12, 137, 7, 137, 95, 4, 137, 79,
		8, 137, 87, 12, 95, 91, 139, 229, 93, 195
	};

	private static readonly byte[] _6C156C63 = new byte[26]
	{
		83, 73, 137, 208, 137, 200, 15, 162, 65, 137,
		64, 0, 65, 137, 88, 4, 65, 137, 72, 8,
		65, 137, 80, 12, 91, 195
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? _63E943B1 : _6C156C63);
			intPtr = _2CEC1FEE.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), _2CEC1FEE._5A5B00CC._6AA8208C | _2CEC1FEE._5A5B00CC._72153512, _2CEC1FEE._51C16571._146217B1);
			Marshal.Copy(array, 0, intPtr, array.Length);
			_00955BDD _00955BDD = (_00955BDD)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(_00955BDD));
			GCHandle gCHandle = default(GCHandle);
			int[] array2 = new int[4];
			try
			{
				gCHandle = GCHandle.Alloc(array2, GCHandleType.Pinned);
				_00955BDD(int_0, array2);
			}
			finally
			{
				if (gCHandle != default(GCHandle))
				{
					gCHandle.Free();
				}
			}
			return array2;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				_2CEC1FEE.VirtualFree(intPtr, 0u, 32768u);
			}
		}
	}
}
