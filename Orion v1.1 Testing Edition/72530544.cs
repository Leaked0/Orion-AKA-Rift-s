using System.IO;

internal class _72530544
{
	private uint _511D23F3 = 1u;

	public const uint _6B1249FB = 16777216u;

	public uint _76DC2018;

	public uint _2EBA55FF;

	public Stream _501E15AB;

	public void method_0(Stream stream_1)
	{
		_501E15AB = stream_1;
		_2EBA55FF = 0u;
		_76DC2018 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			_2EBA55FF = (_2EBA55FF << 8) | (byte)_501E15AB.ReadByte();
		}
	}

	public void method_1()
	{
		_501E15AB = null;
	}

	public uint method_2(int int_0)
	{
		uint num = _76DC2018;
		uint num2 = _2EBA55FF;
		uint num3 = 0u;
		for (int num4 = int_0; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)_501E15AB.ReadByte();
				num <<= 8;
			}
		}
		_76DC2018 = num;
		_2EBA55FF = num2;
		return num3;
	}
}
