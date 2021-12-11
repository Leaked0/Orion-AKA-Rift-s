using System;
using System.IO;

public class _093D37D5
{
	private class _6B4C0874
	{
		private _5E3B5A17 _4CDA3DA1;

		private _5E3B5A17 _4B772429;

		private readonly _5D3D2BD4[] _6B6259F8 = new _5D3D2BD4[16];

		private readonly _5D3D2BD4[] _58E975AD = new _5D3D2BD4[16];

		private _5D3D2BD4 _25884AB0 = new _5D3D2BD4(8);

		private uint _27812CE4;

		public void method_0(uint uint_1)
		{
			for (uint num = _27812CE4; num < uint_1; num++)
			{
				_6B6259F8[num] = new _5D3D2BD4(3);
				_58E975AD[num] = new _5D3D2BD4(3);
			}
			_27812CE4 = uint_1;
		}

		public void method_1()
		{
			_4CDA3DA1.method_0();
			while (0 < _27812CE4)
			{
				_6B6259F8[0].method_0();
				_58E975AD[0].method_0();
			}
			_4B772429.method_0();
			_25884AB0.method_0();
		}

		public uint method_2(_72530544 _72530544_0, uint uint_1)
		{
			if (_4CDA3DA1.method_1(_72530544_0) == 0)
			{
				return _6B6259F8[uint_1].method_1(_72530544_0);
			}
			uint num = 8u;
			if (_4B772429.method_1(_72530544_0) == 0)
			{
				return num + _58E975AD[uint_1].method_1(_72530544_0);
			}
			num += 8;
			return num + _25884AB0.method_1(_72530544_0);
		}
	}

	private class _07263F4C
	{
		private struct _75B676AB
		{
			private _5E3B5A17[] _6A0E2E17;

			public void method_0()
			{
				_6A0E2E17 = new _5E3B5A17[768];
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					_6A0E2E17[i].method_0();
				}
			}

			public byte method_2(_72530544 _72530544_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | _6A0E2E17[num].method_1(_72530544_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte method_3(_72530544 _72530544_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(byte_0 >> 7) & 1u;
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = _6A0E2E17[(1 + num2 << 8) + num].method_1(_72530544_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | _6A0E2E17[num].method_1(_72530544_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private uint _30541EB4 = 1u;

		private _75B676AB[] _031D7477;

		private int _7D1F63B5;

		private int _2A373410;

		private uint _59D44C4A;

		public void method_0(int int_2, int int_3)
		{
			if (_031D7477 == null || _7D1F63B5 != int_3 || _2A373410 != int_2)
			{
				_2A373410 = int_2;
				_59D44C4A = (uint)((1 << int_2) - 1);
				_7D1F63B5 = int_3;
				uint num = (uint)(1 << _7D1F63B5 + _2A373410);
				_031D7477 = new _75B676AB[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					_031D7477[num2].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << _7D1F63B5 + _2A373410);
			while (0 < num)
			{
				_031D7477[0].method_1();
			}
		}

		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & _59D44C4A) << _7D1F63B5) + (uint)(byte_0 >> 8 - _7D1F63B5);
		}

		public byte method_3(_72530544 _72530544_0, uint uint_2, byte byte_0)
		{
			return _031D7477[method_2(uint_2, byte_0)].method_2(_72530544_0);
		}

		public byte method_4(_72530544 _72530544_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return _031D7477[method_2(uint_2, byte_0)].method_3(_72530544_0, byte_1);
		}
	}

	private uint _264D6CA3 = 1u;

	private readonly _61DA2121 _4D412FBC = new _61DA2121();

	private readonly _72530544 _5DB76C2B = new _72530544();

	private readonly _5E3B5A17[] _6D924149 = new _5E3B5A17[192];

	private readonly _5E3B5A17[] _63D372D5 = new _5E3B5A17[12];

	private readonly _5E3B5A17[] _32E078BA = new _5E3B5A17[12];

	private readonly _5E3B5A17[] _6DAA720F = new _5E3B5A17[12];

	private readonly _5E3B5A17[] _572E3D19 = new _5E3B5A17[12];

	private readonly _5E3B5A17[] _46F04453 = new _5E3B5A17[192];

	private readonly _5D3D2BD4[] _525F50CD = new _5D3D2BD4[4];

	private readonly _5E3B5A17[] _6A42745A = new _5E3B5A17[114];

	private _5D3D2BD4 _549C726B = new _5D3D2BD4(4);

	private readonly _6B4C0874 _6EAC048C = new _6B4C0874();

	private readonly _6B4C0874 _3FF57FCF = new _6B4C0874();

	private readonly _07263F4C _6E6E4ABA = new _07263F4C();

	private uint _654B4F6C;

	private uint _4B00340F;

	private uint _086D33E0;

	public _093D37D5()
	{
		_654B4F6C = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			_525F50CD[i] = new _5D3D2BD4(6);
		}
	}

	private void method_0(uint uint_4)
	{
		if (_654B4F6C != uint_4)
		{
			_654B4F6C = uint_4;
			_4B00340F = Math.Max(_654B4F6C, 1u);
			uint uint_5 = Math.Max(_4B00340F, 4096u);
			_4D412FBC.method_0(uint_5);
		}
	}

	private void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		_6E6E4ABA.method_0(int_0, int_1);
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = (uint)(1 << int_0);
		_6EAC048C.method_0(num);
		_3FF57FCF.method_0(num);
		_086D33E0 = num - 1;
	}

	private void method_3(Stream stream_0, Stream stream_1)
	{
		_5DB76C2B.method_0(stream_0);
		_4D412FBC.method_1(stream_1, bool_0: false);
		while (true)
		{
			for (uint num = 0u; num <= _086D33E0; num++)
			{
				uint num2 = 0 + num;
				_6D924149[num2].method_0();
				_46F04453[num2].method_0();
			}
			_63D372D5[0].method_0();
			_32E078BA[0].method_0();
			_6DAA720F[0].method_0();
			_572E3D19[0].method_0();
		}
	}

	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
	}

	public void method_5(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int int_ = (int)byte_0[0] % 9;
		int num = (int)byte_0[0] / 9;
		int int_2 = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			num3 += (uint)(byte_0[1 + i] << i * 8);
		}
		method_0(num3);
		method_1(int_2, int_);
		method_2(num2);
	}
}
