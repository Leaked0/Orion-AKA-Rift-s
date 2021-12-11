using System;
using System.Diagnostics;

internal struct _1C970974
{
	private const int _49756BAB = 32;

	private int _6A291078;

	private uint _04A24D91;

	private uint[] _327374F1;

	private bool _09786990;

	internal int _1B2D4FD4 => _6A291078 + 1;

	private int _57D7069A
	{
		get
		{
			int num = 0;
			for (int num2 = _6A291078; num2 >= 0; num2--)
			{
				if (_327374F1[num2] != 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	[Conditional("DEBUG")]
	private void method_0(bool bool_1)
	{
	}

	internal _1C970974(int int_2)
	{
		_6A291078 = 0;
		_04A24D91 = 0u;
		if (int_2 > 1)
		{
			_327374F1 = new uint[int_2];
			_09786990 = true;
		}
		else
		{
			_327374F1 = null;
			_09786990 = false;
		}
	}

	internal _1C970974(_118708AE _118708AE_0, ref int int_2)
	{
		_09786990 = false;
		_327374F1 = _118708AE_0._71786BFF;
		int int32_ = _118708AE_0._3FAA23C8;
		int num = int32_ >> 31;
		int_2 = (int_2 ^ num) - num;
		if (_327374F1 == null)
		{
			_6A291078 = 0;
			_04A24D91 = (uint)((int32_ ^ num) - num);
			return;
		}
		_6A291078 = _327374F1.Length - 1;
		_04A24D91 = _327374F1[0];
		while (_6A291078 > 0 && _327374F1[_6A291078] == 0)
		{
			_6A291078--;
		}
	}

	internal _118708AE method_1(int int_2)
	{
		method_2(int_2, out int_2, out var uint_);
		return new _118708AE(int_2, uint_);
	}

	private void method_2(int int_2, out int int_3, out uint[] uint_2)
	{
		if (_6A291078 == 0)
		{
			if (_04A24D91 <= int.MaxValue)
			{
				int_3 = int_2 * (int)_04A24D91;
				uint_2 = null;
				return;
			}
			if (_327374F1 == null)
			{
				_327374F1 = new uint[1] { _04A24D91 };
			}
			else if (_09786990)
			{
				_327374F1[0] = _04A24D91;
			}
			else if (_327374F1[0] != _04A24D91)
			{
				_327374F1 = new uint[1] { _04A24D91 };
			}
		}
		int_3 = int_2;
		int num = _327374F1.Length - _6A291078 - 1;
		if (num <= 1)
		{
			if (num == 0 || _327374F1[_6A291078 + 1] == 0)
			{
				_09786990 = false;
				uint_2 = _327374F1;
				return;
			}
			if (_09786990)
			{
				_327374F1[_6A291078 + 1] = 0u;
				_09786990 = false;
				uint_2 = _327374F1;
				return;
			}
		}
		uint_2 = _327374F1;
		Array.Resize(ref uint_2, _6A291078 + 1);
		if (!_09786990)
		{
			_327374F1 = uint_2;
		}
	}

	private void method_3(uint uint_2)
	{
		_04A24D91 = uint_2;
		_6A291078 = 0;
	}

	private void method_4(ulong ulong_0)
	{
		uint num = _3BDC55A7.smethod_5(ulong_0);
		if (num == 0)
		{
			_04A24D91 = _3BDC55A7.smethod_4(ulong_0);
			_6A291078 = 0;
		}
		else
		{
			method_6(2);
			_327374F1[0] = (uint)ulong_0;
			_327374F1[1] = num;
		}
	}

	private void method_5()
	{
		if (_6A291078 > 0 && _327374F1[_6A291078] == 0)
		{
			_04A24D91 = _327374F1[0];
			while (--_6A291078 > 0 && _327374F1[_6A291078] == 0)
			{
			}
		}
	}

	private void method_6(int int_2)
	{
		if (int_2 <= 1)
		{
			_6A291078 = 0;
			return;
		}
		if (!_09786990 || _327374F1.Length < int_2)
		{
			_327374F1 = new uint[int_2];
			_09786990 = true;
		}
		_6A291078 = int_2 - 1;
	}

	private void method_7(int int_2)
	{
		if (int_2 <= 1)
		{
			_6A291078 = 0;
			_04A24D91 = 0u;
			return;
		}
		if (_09786990 && _327374F1.Length >= int_2)
		{
			Array.Clear(_327374F1, 0, int_2);
		}
		else
		{
			_327374F1 = new uint[int_2];
			_09786990 = true;
		}
		_6A291078 = int_2 - 1;
	}

	private void method_8(int int_2, int int_3)
	{
		if (int_2 <= 1)
		{
			if (_6A291078 > 0)
			{
				_04A24D91 = _327374F1[0];
			}
			_6A291078 = 0;
			return;
		}
		if (_09786990 && _327374F1.Length >= int_2)
		{
			if (_6A291078 + 1 < int_2)
			{
				Array.Clear(_327374F1, _6A291078 + 1, int_2 - _6A291078 - 1);
				if (_6A291078 == 0)
				{
					_327374F1[0] = _04A24D91;
				}
			}
		}
		else
		{
			uint[] array = new uint[int_2 + int_3];
			if (_6A291078 == 0)
			{
				array[0] = _04A24D91;
			}
			else
			{
				Array.Copy(_327374F1, array, Math.Min(int_2, _6A291078 + 1));
			}
			_327374F1 = array;
			_09786990 = true;
		}
		_6A291078 = int_2 - 1;
	}

	private void method_9(int int_2 = 0)
	{
		if (!_09786990)
		{
			uint[] destinationArray = new uint[_6A291078 + 1 + int_2];
			Array.Copy(_327374F1, destinationArray, _6A291078 + 1);
			_327374F1 = destinationArray;
			_09786990 = true;
		}
	}

	private void method_10(ref _1C970974 _1C970974_0, int int_2)
	{
		if (_1C970974_0._6A291078 == 0)
		{
			_04A24D91 = _1C970974_0._04A24D91;
			_6A291078 = 0;
			return;
		}
		if (!_09786990 || _327374F1.Length <= _1C970974_0._6A291078)
		{
			_327374F1 = new uint[_1C970974_0._6A291078 + 1 + int_2];
			_09786990 = true;
		}
		_6A291078 = _1C970974_0._6A291078;
		Array.Copy(_1C970974_0._327374F1, _327374F1, _6A291078 + 1);
	}

	private void method_11(uint uint_2)
	{
		switch (uint_2)
		{
		case 0u:
			method_3(0u);
			return;
		case 1u:
			return;
		}
		if (_6A291078 == 0)
		{
			method_4((ulong)_04A24D91 * (ulong)uint_2);
			return;
		}
		method_9(1);
		for (int i = 0; i <= _6A291078; i++)
		{
			smethod_3(ref _327374F1[i], uint_2, 0u);
		}
	}

	internal void method_12(ref _1C970974 _1C970974_0, ref _1C970974 _1C970974_1)
	{
		if (_1C970974_0._6A291078 == 0)
		{
			if (_1C970974_1._6A291078 == 0)
			{
				method_4((ulong)_1C970974_0._04A24D91 * (ulong)_1C970974_1._04A24D91);
				return;
			}
			method_10(ref _1C970974_1, 1);
			method_11(_1C970974_0._04A24D91);
			return;
		}
		if (_1C970974_1._6A291078 == 0)
		{
			method_10(ref _1C970974_0, 1);
			method_11(_1C970974_1._04A24D91);
			return;
		}
		method_7(_1C970974_0._6A291078 + _1C970974_1._6A291078 + 2);
		uint[] array;
		int num;
		uint[] array2;
		int num2;
		if (_1C970974_0._57D7069A <= _1C970974_1._57D7069A)
		{
			array = _1C970974_0._327374F1;
			num = _1C970974_0._6A291078 + 1;
			array2 = _1C970974_1._327374F1;
			num2 = _1C970974_1._6A291078 + 1;
		}
		else
		{
			array = _1C970974_1._327374F1;
			num = _1C970974_1._6A291078 + 1;
			array2 = _1C970974_0._327374F1;
			num2 = _1C970974_0._6A291078 + 1;
		}
		for (int i = 0; i < num; i++)
		{
			uint num3 = array[i];
			if (num3 != 0)
			{
				uint num4 = 0u;
				int num5 = i;
				int num6 = 0;
				while (num6 < num2)
				{
					num4 = smethod_4(ref _327374F1[num5], num3, array2[num6], num4);
					num6++;
					num5++;
				}
				while (num4 != 0)
				{
					num4 = smethod_2(ref _327374F1[num5++], 0u, num4);
				}
			}
		}
		method_5();
	}

	private static uint smethod_0(ref _1C970974 _1C970974_0, uint uint_2)
	{
		if (uint_2 == 1)
		{
			return 0u;
		}
		if (_1C970974_0._6A291078 == 0)
		{
			return _1C970974_0._04A24D91 % uint_2;
		}
		ulong num = 0uL;
		for (int num2 = _1C970974_0._6A291078; num2 >= 0; num2--)
		{
			num = _3BDC55A7.smethod_3((uint)num, _1C970974_0._327374F1[num2]);
			num %= uint_2;
		}
		return (uint)num;
	}

	internal void method_13(ref _1C970974 _1C970974_0)
	{
		if (_1C970974_0._6A291078 == 0)
		{
			method_3(smethod_0(ref this, _1C970974_0._04A24D91));
		}
		else if (_6A291078 != 0)
		{
			_1C970974 _1C970974_ = default(_1C970974);
			smethod_1(ref this, ref _1C970974_0, bool_1: false, ref _1C970974_);
		}
	}

	private static void smethod_1(ref _1C970974 _1C970974_0, ref _1C970974 _1C970974_1, bool bool_1, ref _1C970974 _1C970974_2)
	{
		_1C970974_2.method_3(0u);
		if (_1C970974_0._6A291078 < _1C970974_1._6A291078)
		{
			return;
		}
		int num = _1C970974_1._6A291078 + 1;
		int num2 = _1C970974_0._6A291078 - _1C970974_1._6A291078;
		int num3 = num2;
		int num4 = _1C970974_0._6A291078;
		while (true)
		{
			if (num4 >= num2)
			{
				if (_1C970974_1._327374F1[num4 - num2] == _1C970974_0._327374F1[num4])
				{
					num4--;
					continue;
				}
				if (_1C970974_1._327374F1[num4 - num2] < _1C970974_0._327374F1[num4])
				{
					num3++;
				}
				break;
			}
			num3++;
			break;
		}
		if (num3 == 0)
		{
			return;
		}
		if (bool_1)
		{
			_1C970974_2.method_6(num3);
		}
		uint num5 = _1C970974_1._327374F1[num - 1];
		uint num6 = _1C970974_1._327374F1[num - 2];
		int num7 = _3BDC55A7.smethod_8(num5);
		int num8 = 32 - num7;
		if (num7 > 0)
		{
			num5 = (num5 << num7) | (num6 >> num8);
			num6 <<= num7;
			if (num > 2)
			{
				num6 |= _1C970974_1._327374F1[num - 3] >> num8;
			}
		}
		_1C970974_0.method_9();
		int num9 = num3;
		while (--num9 >= 0)
		{
			uint num10 = ((num9 + num <= _1C970974_0._6A291078) ? _1C970974_0._327374F1[num9 + num] : 0u);
			ulong num11 = _3BDC55A7.smethod_3(num10, _1C970974_0._327374F1[num9 + num - 1]);
			uint num12 = _1C970974_0._327374F1[num9 + num - 2];
			if (num7 > 0)
			{
				num11 = (num11 << num7) | (num12 >> num8);
				num12 <<= num7;
				if (num9 + num >= 3)
				{
					num12 |= _1C970974_0._327374F1[num9 + num - 3] >> num8;
				}
			}
			ulong num13 = num11 / num5;
			ulong num14 = (uint)(num11 % num5);
			if (num13 > 4294967295L)
			{
				num14 += num5 * (num13 - 4294967295L);
				num13 = 4294967295uL;
			}
			for (; num14 <= 4294967295L && num13 * num6 > _3BDC55A7.smethod_3((uint)num14, num12); num14 += num5)
			{
				num13--;
			}
			if (num13 > 0L)
			{
				ulong num15 = 0uL;
				for (int i = 0; i < num; i++)
				{
					num15 += _1C970974_1._327374F1[i] * num13;
					uint num16 = (uint)num15;
					num15 >>= 32;
					if (_1C970974_0._327374F1[num9 + i] < num16)
					{
						num15++;
					}
					_1C970974_0._327374F1[num9 + i] -= num16;
				}
				if (num10 < num15)
				{
					uint uint_ = 0u;
					for (int j = 0; j < num; j++)
					{
						uint_ = smethod_2(ref _1C970974_0._327374F1[num9 + j], _1C970974_1._327374F1[j], uint_);
					}
					num13--;
				}
				_1C970974_0._6A291078 = num9 + num - 1;
			}
			if (bool_1)
			{
				if (num3 == 1)
				{
					_1C970974_2._04A24D91 = (uint)num13;
				}
				else
				{
					_1C970974_2._327374F1[num9] = (uint)num13;
				}
			}
		}
		_1C970974_0._6A291078 = num - 1;
		_1C970974_0.method_5();
	}

	private static uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)((long)uint_2 + (long)uint_3 + uint_4);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	private static uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)((long)uint_2 * (long)uint_3 + uint_4);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	private static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		ulong num = (ulong)((long)uint_3 * (long)uint_4 + uint_2 + uint_5);
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}
}
