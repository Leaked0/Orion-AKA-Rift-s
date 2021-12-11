using System.IO;

public class _61DA2121
{
	private byte[] _1CFD798E;

	private uint _2BD47B44;

	private uint _5F9B6A4D;

	private uint _540126B9;

	private Stream _378700EC;

	private uint _2D425ADF = 1u;

	public uint _1599486B;

	public void method_0(uint uint_5)
	{
		if (_5F9B6A4D != uint_5)
		{
			_1CFD798E = new byte[uint_5];
		}
		_5F9B6A4D = uint_5;
		_2BD47B44 = 0u;
		_540126B9 = 0u;
	}

	public void method_1(Stream stream_1, bool bool_0)
	{
		method_2();
		_378700EC = stream_1;
		if (!bool_0)
		{
			_540126B9 = 0u;
			_2BD47B44 = 0u;
			_1599486B = 0u;
		}
	}

	public void method_2()
	{
		method_3();
		_378700EC = null;
	}

	public void method_3()
	{
		uint num = _2BD47B44 - _540126B9;
		if (num != 0)
		{
			_378700EC.Write(_1CFD798E, (int)_540126B9, (int)num);
			if (_2BD47B44 >= _5F9B6A4D)
			{
				_2BD47B44 = 0u;
			}
			_540126B9 = _2BD47B44;
		}
	}

	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = _2BD47B44 - uint_5 - 1;
		if (num >= _5F9B6A4D)
		{
			num += _5F9B6A4D;
		}
		while (uint_6 != 0)
		{
			if (num >= _5F9B6A4D)
			{
				num = 0u;
			}
			_1CFD798E[_2BD47B44++] = _1CFD798E[num++];
			if (_2BD47B44 >= _5F9B6A4D)
			{
				method_3();
			}
			uint_6--;
		}
	}

	public void method_5(byte byte_1)
	{
		_1CFD798E[_2BD47B44++] = byte_1;
		if (_2BD47B44 >= _5F9B6A4D)
		{
			method_3();
		}
	}

	public byte method_6(uint uint_5)
	{
		uint num = _2BD47B44 - uint_5 - 1;
		if (num >= _5F9B6A4D)
		{
			num += _5F9B6A4D;
		}
		return _1CFD798E[num];
	}
}
