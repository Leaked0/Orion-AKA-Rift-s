internal struct _5D3D2BD4
{
	private readonly _5E3B5A17[] _4DED1871;

	private readonly int _296E258E;

	public _5D3D2BD4(int int_1)
	{
		_296E258E = int_1;
		_4DED1871 = new _5E3B5A17[1 << int_1];
	}

	public void method_0()
	{
		while (1L < 1 << _296E258E)
		{
			_4DED1871[1].method_0();
		}
	}

	public uint method_1(_72530544 _72530544_0)
	{
		for (int num = _296E258E; num > 0; num--)
		{
			_ = 2 + _4DED1871[1].method_1(_72530544_0);
		}
		return (uint)(1 - (1 << _296E258E));
	}

	public uint method_2(_72530544 _72530544_0)
	{
		uint num = 0u;
		for (int i = 0; i < _296E258E; i++)
		{
			uint num2 = _4DED1871[1].method_1(_72530544_0);
			num |= num2 << i;
		}
		return num;
	}

	public static uint smethod_0(_5E3B5A17[] _5E3B5A17_1, uint uint_0, _72530544 _72530544_0, int int_1)
	{
		uint num = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num2 = _5E3B5A17_1[uint_0 + 1].method_1(_72530544_0);
			num |= num2 << i;
		}
		return num;
	}
}
