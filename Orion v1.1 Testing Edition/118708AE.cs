using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[Serializable]
internal struct _118708AE
{
	private const uint _6183028B = 2147483648u;

	private const int _67683626 = 32;

	private readonly int _125D2318;

	private readonly uint[] _44B6589F;

	private static readonly _118708AE _160D07F4 = new _118708AE(-1, new uint[1] { 2147483648u });

	private static readonly _118708AE _329674DC = new _118708AE(1);

	private static readonly _118708AE _5DF86F86 = new _118708AE(0);

	private static readonly _118708AE _7E274A93 = new _118708AE(-1);

	private static _118708AE _75D11645 => _329674DC;

	private bool _1352721C
	{
		get
		{
			if (_44B6589F != null)
			{
				return (_44B6589F[0] & 1) == 0;
			}
			return (_125D2318 & 1) == 0;
		}
	}

	private int _405C1070 => (_125D2318 >> 31) - (-_125D2318 >> 31);

	internal int _3FAA23C8 => _125D2318;

	internal uint[] _71786BFF => _44B6589F;

	[Conditional("DEBUG")]
	private void method_0()
	{
		if (_44B6589F != null)
		{
			smethod_11(_44B6589F);
		}
	}

	public override bool DCCAA86A(object object_0)
	{
		if (!(object_0 is _118708AE))
		{
			return false;
		}
		return Equals((_118708AE)object_0);
	}

	public override int vmethod_0()
	{
		if (_44B6589F == null)
		{
			return _125D2318;
		}
		int num = _125D2318;
		int num2 = smethod_11(_44B6589F);
		while (--num2 >= 0)
		{
			num = _3BDC55A7.smethod_7(num, (int)_44B6589F[num2]);
		}
		return num;
	}

	private int method_1(_118708AE _118708AE_4)
	{
		if ((_125D2318 ^ _118708AE_4._125D2318) < 0)
		{
			if (_125D2318 >= 0)
			{
				return 1;
			}
			return -1;
		}
		if (_44B6589F == null)
		{
			if (_118708AE_4._44B6589F == null)
			{
				if (_125D2318 >= _118708AE_4._125D2318)
				{
					if (_125D2318 <= _118708AE_4._125D2318)
					{
						return 0;
					}
					return 1;
				}
				return -1;
			}
			return -_118708AE_4._125D2318;
		}
		int num;
		int num2;
		if (_118708AE_4._44B6589F != null && (num = smethod_11(_44B6589F)) <= (num2 = smethod_11(_118708AE_4._44B6589F)))
		{
			if (num < num2)
			{
				return -_125D2318;
			}
			int num3 = smethod_12(_44B6589F, _118708AE_4._44B6589F, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (_44B6589F[num3 - 1] >= _118708AE_4._44B6589F[num3 - 1])
			{
				return _125D2318;
			}
			return -_125D2318;
		}
		return _125D2318;
	}

	internal byte[] method_2()
	{
		if (_44B6589F == null && _125D2318 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (_44B6589F == null)
		{
			array = new uint[1] { (uint)_125D2318 };
			b = (byte)((_125D2318 < 0) ? 255u : 0u);
		}
		else if (_125D2318 == -1)
		{
			array = (uint[])_44B6589F.Clone();
			_3BDC55A7.smethod_0(array);
			b = byte.MaxValue;
		}
		else
		{
			array = _44B6589F;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		uint[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			uint num2 = array3[i];
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 0xFFu);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 0x80) == (b & 0x80))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	private _118708AE(int int_2)
	{
		if (int_2 == int.MinValue)
		{
			this = _160D07F4;
			return;
		}
		_125D2318 = int_2;
		_44B6589F = null;
	}

	internal _118708AE(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = byte_0.Length;
		bool flag = num > 0 && (byte_0[num - 1] & 0x80) == 128;
		while (num > 0 && byte_0[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			_125D2318 = 0;
			_44B6589F = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				_125D2318 = -1;
			}
			else
			{
				_125D2318 = 0;
			}
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				_125D2318 <<= 8;
				_125D2318 |= byte_0[num2];
			}
			_44B6589F = null;
			if (_125D2318 < 0 && !flag)
			{
				_44B6589F = new uint[1];
				_44B6589F[0] = (uint)_125D2318;
				_125D2318 = 1;
			}
			if (_125D2318 == int.MinValue)
			{
				this = _160D07F4;
			}
			return;
		}
		int num3 = num % 4;
		int num4 = num / 4 + ((num3 != 0) ? 1 : 0);
		bool flag2 = true;
		uint[] array = new uint[num4];
		int num5 = 3;
		int i;
		for (i = 0; i < num4 - ((num3 != 0) ? 1 : 0); i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (byte_0[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= byte_0[num5];
				num5--;
			}
			num5 += 8;
		}
		if (num3 != 0)
		{
			if (flag)
			{
				array[num4 - 1] = uint.MaxValue;
			}
			for (num5 = num - 1; num5 >= num - num3; num5--)
			{
				if (byte_0[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= byte_0[num5];
			}
		}
		if (flag2)
		{
			this = _5DF86F86;
		}
		else if (flag)
		{
			_3BDC55A7.smethod_0(array);
			int num6 = array.Length;
			while (num6 > 0 && array[num6 - 1] == 0)
			{
				num6--;
			}
			if (num6 == 1 && (int)array[0] > 0)
			{
				if (array[0] == 1)
				{
					this = _7E274A93;
					return;
				}
				if (array[0] == 2147483648u)
				{
					this = _160D07F4;
					return;
				}
				_125D2318 = -1 * (int)array[0];
				_44B6589F = null;
			}
			else if (num6 != array.Length)
			{
				_125D2318 = -1;
				_44B6589F = new uint[num6];
				Array.Copy(array, _44B6589F, num6);
			}
			else
			{
				_125D2318 = -1;
				_44B6589F = array;
			}
		}
		else
		{
			_125D2318 = 1;
			_44B6589F = array;
		}
	}

	internal _118708AE(int int_2, uint[] uint_2)
	{
		_125D2318 = int_2;
		_44B6589F = uint_2;
	}

	private static void smethod_0(ref _1C970974 _1C970974_0, ref _1C970974 _1C970974_1, ref _1C970974 _1C970974_2, ref _1C970974 _1C970974_3)
	{
		_3BDC55A7.smethod_2(ref _1C970974_0, ref _1C970974_3);
		_1C970974_0.method_12(ref _1C970974_3, ref _1C970974_1);
		_1C970974_0.method_13(ref _1C970974_2);
	}

	private static void smethod_1(ref _1C970974 _1C970974_0, ref _1C970974 _1C970974_1, ref _1C970974 _1C970974_2)
	{
		_3BDC55A7.smethod_2(ref _1C970974_0, ref _1C970974_2);
		_1C970974_0.method_12(ref _1C970974_2, ref _1C970974_2);
		_1C970974_0.method_13(ref _1C970974_1);
	}

	private static void smethod_2(uint uint_2, ref _1C970974 _1C970974_0, ref _1C970974 _1C970974_1, ref _1C970974 _1C970974_2, ref _1C970974 _1C970974_3)
	{
		while (uint_2 != 0)
		{
			if ((uint_2 & 1) == 1)
			{
				smethod_0(ref _1C970974_0, ref _1C970974_1, ref _1C970974_2, ref _1C970974_3);
			}
			if (uint_2 != 1)
			{
				smethod_1(ref _1C970974_1, ref _1C970974_2, ref _1C970974_3);
				uint_2 >>= 1;
				continue;
			}
			break;
		}
	}

	private static void smethod_3(uint uint_2, ref _1C970974 _1C970974_0, ref _1C970974 _1C970974_1, ref _1C970974 _1C970974_2, ref _1C970974 _1C970974_3)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((uint_2 & 1) == 1)
			{
				smethod_0(ref _1C970974_0, ref _1C970974_1, ref _1C970974_2, ref _1C970974_3);
			}
			smethod_1(ref _1C970974_1, ref _1C970974_2, ref _1C970974_3);
			uint_2 >>= 1;
		}
	}

	internal static _118708AE smethod_4(_118708AE _118708AE_4, _118708AE _118708AE_5, _118708AE _118708AE_6)
	{
		if (_118708AE_5._405C1070 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int int_ = 1;
		int int_2 = 1;
		int int_3 = 1;
		bool boolean_ = _118708AE_5._1352721C;
		_1C970974 _1C970974_ = new _1C970974(_75D11645, ref int_);
		_1C970974 _1C970974_2 = new _1C970974(_118708AE_4, ref int_2);
		_1C970974 _1C970974_3 = new _1C970974(_118708AE_6, ref int_3);
		_1C970974 _1C970974_4 = new _1C970974(_1C970974_2._1B2D4FD4);
		_1C970974_.method_13(ref _1C970974_3);
		if (_118708AE_5._44B6589F == null)
		{
			smethod_2((uint)_118708AE_5._125D2318, ref _1C970974_, ref _1C970974_2, ref _1C970974_3, ref _1C970974_4);
		}
		else
		{
			int num = smethod_11(_118708AE_5._44B6589F);
			for (int i = 0; i < num - 1; i++)
			{
				smethod_3(_118708AE_5._44B6589F[i], ref _1C970974_, ref _1C970974_2, ref _1C970974_3, ref _1C970974_4);
			}
			smethod_2(_118708AE_5._44B6589F[num - 1], ref _1C970974_, ref _1C970974_2, ref _1C970974_3, ref _1C970974_4);
		}
		return _1C970974_.method_1((_118708AE_4._125D2318 > 0) ? 1 : (boolean_ ? 1 : (-1)));
	}

	[SpecialName]
	public static bool smethod_5(_118708AE _118708AE_4, _118708AE _118708AE_5)
	{
		return _118708AE_4.method_1(_118708AE_5) < 0;
	}

	[SpecialName]
	public static bool smethod_6(_118708AE _118708AE_4, _118708AE _118708AE_5)
	{
		return _118708AE_4.method_1(_118708AE_5) <= 0;
	}

	[SpecialName]
	public static bool smethod_7(_118708AE _118708AE_4, _118708AE _118708AE_5)
	{
		return _118708AE_4.method_1(_118708AE_5) > 0;
	}

	[SpecialName]
	public static bool smethod_8(_118708AE _118708AE_4, _118708AE _118708AE_5)
	{
		return _118708AE_4.method_1(_118708AE_5) >= 0;
	}

	[SpecialName]
	public static bool smethod_9(_118708AE _118708AE_4, _118708AE _118708AE_5)
	{
		return _118708AE_4.Equals(_118708AE_5);
	}

	[SpecialName]
	public static bool smethod_10(_118708AE _118708AE_4, _118708AE _118708AE_5)
	{
		return !_118708AE_4.Equals(_118708AE_5);
	}

	private static int smethod_11(uint[] uint_2)
	{
		int num = uint_2.Length;
		if (uint_2[num - 1] != 0)
		{
			return num;
		}
		return num - 1;
	}

	private static int smethod_12(uint[] uint_2, uint[] uint_3, int int_2)
	{
		int num = int_2;
		do
		{
			if (--num < 0)
			{
				return 0;
			}
		}
		while (uint_2[num] == uint_3[num]);
		return num + 1;
	}
}
