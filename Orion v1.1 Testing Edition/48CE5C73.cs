using System;
using System.Runtime.InteropServices;

public class _48CE5C73
{
	private static uint[] _3E3A4A33;

	public _48CE5C73()
	{
		if (_3E3A4A33 != null)
		{
			return;
		}
		_3E3A4A33 = new uint[256];
		for (int i = 0; i < 256; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ 0xEDB88320u));
			}
			_3E3A4A33[i] = num;
		}
	}

	public uint method_0(IntPtr intptr_0, uint uint_1)
	{
		uint num = 0u;
		for (int i = 0; i < uint_1; i++)
		{
			num = _3E3A4A33[(Marshal.ReadByte(new IntPtr(intptr_0.ToInt64() + i)) ^ num) & 0xFF] ^ (num >> 8);
		}
		return ~num;
	}
}
