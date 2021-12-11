internal abstract class _19AA4AB3
{
	public struct _3B6B4531
	{
		public uint _53E452EE;

		public void method_0()
		{
			_53E452EE = 0u;
		}

		public void method_1()
		{
			if (_53E452EE < 4)
			{
				_53E452EE = 0u;
			}
			else if (_53E452EE < 10)
			{
				_53E452EE -= 3u;
			}
			else
			{
				_53E452EE -= 6u;
			}
		}

		public void method_2()
		{
			_53E452EE = ((_53E452EE < 7) ? 7u : 10u);
		}

		public void method_3()
		{
			_53E452EE = ((_53E452EE < 7) ? 8u : 11u);
		}

		public void method_4()
		{
			_53E452EE = ((_53E452EE < 7) ? 9u : 11u);
		}

		public bool method_5()
		{
			return _53E452EE < 7;
		}
	}

	public const uint _074046CA = 12u;

	public const int _67280AC9 = 6;

	private const int _6CA70FF7 = 2;

	public const uint _7DBB5608 = 4u;

	public const uint _2E45704D = 2u;

	public const int _3F6A7225 = 4;

	public const uint _1AAB3C2A = 4u;

	public const uint _2EEE178B = 14u;

	public const uint _06E53974 = 128u;

	public const int _6B645670 = 4;

	public const uint _39A46E2D = 16u;

	public const int _14957A08 = 3;

	public const int _119D3D47 = 3;

	public const int _447A2BF8 = 8;

	public const uint _6B2C45BA = 8u;

	public const uint _42006C0D = 8u;

	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2;
		if (uint_9 < 4)
		{
			return uint_9;
		}
		return 3u;
	}
}
