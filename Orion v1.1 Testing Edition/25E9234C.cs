using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _25E9234C
{
	private readonly long _5D8D6206;

	private readonly _4CF95CE7 _50126137;

	private readonly Dictionary<uint, string> _72DC29DE;

	private readonly uint _4F771382;

	public _25E9234C(long long_1)
	{
		//IL_0020: Expected O, but got I8
		//IL_0030: Expected I8, but got O
		//IL_0072: Expected I8, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected I8, but got Unknown
		//IL_008c: Expected I4, but got O
		_ = (new object[2] { this, long_1 })[1];
		long num = (long)null;
		Array array = null;
		_ = ((object[])null)[0];
		object obj = null;
		obj._002Ector();
		((_25E9234C)obj)._5D8D6206 = num;
		array = new byte[8];
		Marshal.Copy(new IntPtr(((_25E9234C)obj)._5D8D6206 + (object)6951125uL), (byte[])array, 0, (int)(object)array.Length);
		((_25E9234C)obj)._50126137 = new _4CF95CE7((byte[])array);
		((_25E9234C)obj)._72DC29DE = new Dictionary<uint, string>();
		((_25E9234C)obj)._4F771382 = BitConverter.ToUInt32((byte[])array, 0);
	}
}
