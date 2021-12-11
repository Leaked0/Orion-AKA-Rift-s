using System;
using System.Runtime.InteropServices;

public class _4CF95CE7
{
	[StructLayout(LayoutKind.Explicit)]
	private struct _0837437C
	{
		[FieldOffset(0)]
		public ulong _10D2530D;

		[FieldOffset(0)]
		public uint _5693528B;

		[FieldOffset(4)]
		public uint _5B7858E4;
	}

	private const int _46203504 = 15;

	private const int _64746180 = 8;

	private const int _093932A5 = 2;

	private const int _1D0B108B = 32;

	private readonly uint[] _29E51E7A;

	private const uint _6A3E0818 = 4207804417u;

	private const uint _720B54DE = 4207804418u;

	public _4CF95CE7(byte[] byte_0)
	{
		uint num = 4u;
		uint[] array = new uint[2];
		_29E51E7A = new uint[32];
		uint num2 = 7u;
		array[1] = 0u;
		while (num2 != uint.MaxValue)
		{
			array[num2 / num] = (array[num2 / num] << 8) + byte_0[num2];
			num2--;
		}
		_29E51E7A[0] = 929906454u;
		for (num2 = 1u; num2 < 32; num2++)
		{
			_29E51E7A[num2] = _29E51E7A[num2 - 1] + 1655664218;
		}
		uint num3 = 0u;
		uint num4 = 0u;
		num2 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		while (num3 < 96)
		{
			num6 = (_29E51E7A[num2] = _76DF6D96.smethod_0(_29E51E7A[num2] + num6 + num5, 3));
			num5 = (array[num4] = _76DF6D96.smethod_0(array[num4] + num6 + num5, (int)(num6 + num5)));
			num3++;
			num2 = (num2 + 1) % 32u;
			num4 = (num4 + 1) % 2u;
		}
	}

	private void method_0(ref _0837437C _0837437C_0)
	{
		uint num = _0837437C_0._5693528B + _29E51E7A[0];
		uint num2 = _0837437C_0._5B7858E4 + _29E51E7A[1];
		for (uint num3 = 1u; num3 <= 15; num3++)
		{
			num = _76DF6D96.smethod_0(num ^ num2, (int)num2) + _29E51E7A[2 * num3];
			num2 = _76DF6D96.smethod_0(num2 ^ num, (int)num) + _29E51E7A[2 * num3 + 1];
		}
		_0837437C_0._5693528B = num;
		_0837437C_0._5B7858E4 = num2;
	}

	private void method_1(ref _0837437C _0837437C_0)
	{
		uint num = _0837437C_0._5B7858E4;
		uint num2 = _0837437C_0._5693528B;
		for (uint num3 = 15u; num3 != 0; num3--)
		{
			num = _76DF6D96.smethod_1(num - _29E51E7A[2 * num3 + 1], (int)num2) ^ num2;
			num2 = _76DF6D96.smethod_1(num2 - _29E51E7A[2 * num3], (int)num) ^ num;
		}
		_0837437C_0._5B7858E4 = num - _29E51E7A[1];
		_0837437C_0._5693528B = num2 - _29E51E7A[0];
	}

	public byte[] method_2(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		method_4(byte_0, array);
		return array;
	}

	public byte[] method_3(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		method_5(byte_0, array);
		return array;
	}

	public void method_4(byte[] byte_0, byte[] byte_1)
	{
		_0837437C _0837437C_ = default(_0837437C);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			_0837437C_._10D2530D = BitConverter.ToUInt64(byte_0, i);
			method_0(ref _0837437C_);
			BitConverter.GetBytes(_0837437C_._10D2530D).CopyTo(byte_1, i);
		}
	}

	public void method_5(byte[] byte_0, byte[] byte_1)
	{
		_0837437C _0837437C_ = default(_0837437C);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			_0837437C_._10D2530D = BitConverter.ToUInt64(byte_0, i);
			method_1(ref _0837437C_);
			BitConverter.GetBytes(_0837437C_._10D2530D).CopyTo(byte_1, i);
		}
	}
}
