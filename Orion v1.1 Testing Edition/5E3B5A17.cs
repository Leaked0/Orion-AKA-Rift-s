internal struct _5E3B5A17
{
	private const int _0F393864 = 11;

	private const uint _5C0D1C42 = 2048u;

	private const int _000135DB = 5;

	private uint _46783DCD;

	public void method_0()
	{
		_46783DCD = 1024u;
	}

	public uint method_1(_72530544 _72530544_0)
	{
		uint num = (_72530544_0._76DC2018 >> 11) * _46783DCD;
		if (_72530544_0._2EBA55FF < num)
		{
			_72530544_0._76DC2018 = num;
			_46783DCD += 2048 - _46783DCD >> 5;
			if (_72530544_0._76DC2018 < 16777216)
			{
				_72530544_0._2EBA55FF = (_72530544_0._2EBA55FF << 8) | (byte)_72530544_0._501E15AB.ReadByte();
				_72530544_0._76DC2018 <<= 8;
			}
			return 0u;
		}
		_72530544_0._76DC2018 -= num;
		_72530544_0._2EBA55FF -= num;
		_46783DCD -= _46783DCD >> 5;
		if (_72530544_0._76DC2018 < 16777216)
		{
			_72530544_0._2EBA55FF = (_72530544_0._2EBA55FF << 8) | (byte)_72530544_0._501E15AB.ReadByte();
			_72530544_0._76DC2018 <<= 8;
		}
		return 1u;
	}
}
