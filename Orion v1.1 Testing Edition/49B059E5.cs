using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

public class _49B059E5
{
	public static readonly _49B059E5 _749E5324 = new _49B059E5();

	[CompilerGenerated]
	private _50CD666C _50DD7D03;

	[CompilerGenerated]
	private _25E9234C _75111218;

	[CompilerGenerated]
	private _5E252C1A _7B5A4EC1;

	[CompilerGenerated]
	private _4FBF78E1 _76776B4A;

	public _50CD666C _13DE6429
	{
		[CompilerGenerated]
		get
		{
			return _50DD7D03;
		}
		[CompilerGenerated]
		private set
		{
			_50DD7D03 = value;
		}
	}

	public _25E9234C _37A748C1
	{
		[CompilerGenerated]
		get
		{
			return _75111218;
		}
		[CompilerGenerated]
		private set
		{
			_75111218 = value;
		}
	}

	public _5E252C1A _28A36D98
	{
		[CompilerGenerated]
		get
		{
			return _7B5A4EC1;
		}
		[CompilerGenerated]
		private set
		{
			_7B5A4EC1 = value;
		}
	}

	public _4FBF78E1 _565904E7
	{
		[CompilerGenerated]
		get
		{
			return _76776B4A;
		}
		[CompilerGenerated]
		private set
		{
			_76776B4A = value;
		}
	}

	public static bool smethod_0()
	{
		_ = null;
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	public static bool smethod_1(bool bool_0)
	{
		object[] object_ = new object[1] { bool_0 };
		return (bool)new _78175594().method_112(object_, 3476647);
	}

	internal static bool smethod_2(byte[] byte_0)
	{
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				if (num + 3 >= byte_0.Length || byte_0[num] != 81 || byte_0[num + 1] != 69 || byte_0[num + 2] != 77 || byte_0[num + 3] != 85)
				{
					if (num + 8 >= byte_0.Length || byte_0[num] != 77 || byte_0[num + 1] != 105 || byte_0[num + 2] != 99 || byte_0[num + 3] != 114 || byte_0[num + 4] != 111 || byte_0[num + 5] != 115 || byte_0[num + 6] != 111 || byte_0[num + 7] != 102 || byte_0[num + 8] != 116)
					{
						if (num + 6 >= byte_0.Length || byte_0[num] != 105 || byte_0[num + 1] != 110 || byte_0[num + 2] != 110 || byte_0[num + 3] != 111 || byte_0[num + 4] != 116 || byte_0[num + 5] != 101 || byte_0[num + 6] != 107)
						{
							if (num + 9 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 105 || byte_0[num + 2] != 114 || byte_0[num + 3] != 116 || byte_0[num + 4] != 117 || byte_0[num + 5] != 97 || byte_0[num + 6] != 108 || byte_0[num + 7] != 66 || byte_0[num + 8] != 111 || byte_0[num + 9] != 120)
							{
								if (num + 5 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 77 || byte_0[num + 2] != 119 || byte_0[num + 3] != 97 || byte_0[num + 4] != 114 || byte_0[num + 5] != 101)
								{
									if (num + 8 < byte_0.Length && byte_0[num] == 80 && byte_0[num + 1] == 97 && byte_0[num + 2] == 114 && byte_0[num + 3] == 97 && byte_0[num + 4] == 108 && byte_0[num + 5] == 108 && byte_0[num + 6] == 101 && byte_0[num + 7] == 108 && byte_0[num + 8] == 115)
									{
										break;
									}
									num++;
									continue;
								}
								return true;
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_3()
	{
		//IL_0007: Expected I, but got O
		//IL_0013: Expected I4, but got O
		//IL_0019: Expected I4, but got O
		//IL_0025: Expected I4, but got O
		//IL_0032: Expected I4, but got O
		//IL_0038: Expected I4, but got O
		//IL_017d: Incompatible stack heights: 11 vs 0
		_ = null;
		IntPtr num = (nint)null;
		Array array = null;
		uint num2 = (uint)(int)null;
		int num3 = (int)null;
		Array array2 = null;
		uint num4 = (uint)(int)null;
		Array array3 = null;
		_ = null;
		int num5 = (int)null;
		int num6 = (int)null;
		array3 = _23150EA9.smethod_0(1);
		if (((((int[])array3)[2] >> 31) & 1) == 0)
		{
			num2 = 1381190978u;
			num3 = (int)_2CEC1FEE.EnumSystemFirmwareTables(1381190978u, IntPtr.Zero, 0u);
			if (num3 > 0)
			{
			}
			while (true)
			{
				num = Marshal.AllocHGlobal(num3);
				_2CEC1FEE.EnumSystemFirmwareTables(num2, num, (uint)num3);
				array = new byte[num3];
				Marshal.Copy(num, (byte[])array, 0, num3);
				Marshal.FreeHGlobal(num);
				for (num6 = 0; num6 < num3 / 4; num6 += 4)
				{
					num4 = BitConverter.ToUInt32((byte[])array, num6);
					num5 = (int)_2CEC1FEE.GetSystemFirmwareTable(num2, num4, IntPtr.Zero, 0u);
					if (num5 > 0)
					{
						num = Marshal.AllocHGlobal(num5);
						_2CEC1FEE.GetSystemFirmwareTable(num2, num4, num, (uint)num5);
						array2 = new byte[num5];
						Marshal.Copy(num, (byte[])array2, 0, num5);
						Marshal.FreeHGlobal(num);
						if (smethod_2((byte[])array2))
						{
							goto end_IL_0086;
						}
					}
				}
				continue;
				end_IL_0086:
				break;
			}
		}
		array3 = _23150EA9.smethod_0(1073741824);
		if (((int[])array3)[1] == 1919117645)
		{
		}
		while (true)
		{
			if (((int[])array3)[2] == 1718580079 && ((int[])array3)[3] == 1984438388)
			{
				array3 = _23150EA9.smethod_0(1073741827);
				if (((uint)((int[])array3)[1] & (true ? 1u : 0u)) != 0)
				{
					break;
				}
			}
		}
		/*Error: Unexpected end of block*/;
	}

	public static bool smethod_4()
	{
		if (_2DCB5ADF.smethod_0())
		{
			return false;
		}
		long num = Marshal.GetHINSTANCE(typeof(_49B059E5).Module).ToInt64();
		uint num2 = (uint)Marshal.ReadInt32(new IntPtr(num + 6951133L));
		long num3 = 6951137L;
		bool result = true;
		byte[] array = new byte[12];
		_48CE5C73 _48CE5C74 = new _48CE5C73();
		if (Marshal.ReadInt32(new IntPtr(num + 6950916L)) != (int)_48CE5C74.method_0(new IntPtr(num + 6951137L), num2))
		{
			result = false;
		}
		_4E4A4235 _4E4A4236 = new _4E4A4235();
		for (int i = 0; i < num2; i += array.Length)
		{
			Marshal.Copy(new IntPtr(num + num3 + i), array, 0, array.Length);
			uint num4 = _4E4A4236.method_0(BitConverter.ToUInt32(array, 0));
			uint uint_ = _4E4A4236.method_0(BitConverter.ToUInt32(array, 4));
			uint num5 = _4E4A4236.method_0(BitConverter.ToUInt32(array, 8));
			if (_48CE5C74.method_0(new IntPtr(num + num4), uint_) != num5)
			{
				result = false;
			}
		}
		num2 = (uint)Marshal.ReadInt32(new IntPtr(num + _2DCB5ADF.smethod_3()));
		num3 = _2DCB5ADF.smethod_2();
		if (Marshal.ReadInt32(new IntPtr(num + _2DCB5ADF.smethod_4())) != (int)_48CE5C74.method_0(new IntPtr(num + num3), num2))
		{
			result = false;
		}
		_4E4A4235 _4E4A4237 = new _4E4A4235();
		for (int j = 0; j < num2; j += array.Length)
		{
			Marshal.Copy(new IntPtr(num + num3 + j), array, 0, array.Length);
			uint num6 = _4E4A4237.method_0(BitConverter.ToUInt32(array, 0));
			uint uint_2 = _4E4A4237.method_0(BitConverter.ToUInt32(array, 4));
			uint num7 = _4E4A4237.method_0(BitConverter.ToUInt32(array, 8));
			if (_48CE5C74.method_0(new IntPtr(num + num6), uint_2) != num7)
			{
				result = false;
			}
		}
		return result;
	}

	public unsafe static bool smethod_5(ref string string_0)
	{
		//IL_0015: Expected O, but got Ref
		object[] array = new object[1] { (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref string_0) };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	private static string smethod_6(uint uint_0)
	{
		//IL_0015: Expected O, but got I4
		object[] array = new object[1] { uint_0 };
		_ = array[0];
		_ = null;
		/*Error: Unexpected end of block*/;
	}

	public static void smethod_7(string string_0)
	{
		MessageBox.Show(string_0, Assembly.GetExecutingAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	private static void smethod_8()
	{
		new _78175594().method_112(null, 3596638);
	}

	public bool method_0(long long_0)
	{
		//IL_0020: Expected O, but got I8
		//IL_0030: Expected I8, but got O
		//IL_00a6: Expected I8, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected I8, but got Unknown
		//IL_00c0: Expected I4, but got O
		//IL_00dc: Expected I8, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected I8, but got Unknown
		//IL_00f6: Expected I4, but got O
		//IL_012f: Expected I4, but got O
		//IL_0153: Incompatible stack heights: 8 vs 0
		//IL_0159: Incompatible stack heights: 0 vs 8
		object[] array = new object[2] { this, long_0 };
		_ = array[1];
		long num = (long)null;
		_ = null;
		_ = null;
		Array array2 = null;
		Array array3;
		_ = ((object[])(array3 = null))[0];
		object obj = null;
		Array array4 = null;
		Thread thread = new Thread(smethod_8);
		thread.IsBackground = true;
		thread.Start();
		((_49B059E5)obj)._13DE6429 = new _50CD666C();
		((_49B059E5)obj)._37A748C1 = new _25E9234C(num);
		while (true)
		{
			array2 = new byte[8];
			Marshal.Copy(new IntPtr(num + (object)6951125uL), (byte[])array2, 0, (int)(object)array2.Length);
			array3 = new byte[64];
			Marshal.Copy(new IntPtr(num + (object)3645440uL), (byte[])array3, 0, (int)(object)array3.Length);
			array3 = new _4CF95CE7((byte[])array2).method_3((byte[])array3);
			array4 = new byte[0];
			Array.Copy(array3, 0, array4, 0, (int)(object)array4.Length);
			_50CD666C _50CD666C_ = ((_49B059E5)obj)._13DE6429;
			if (!((_108A18AAF)/*Error near IL_0141: Stack underflow*/).__EXTERNCALLVIRT_372AC9((object)_50CD666C_, array4))
			{
				((_49B059E5)obj)._28A36D98 = new _5E252C1A(num);
			}
		}
	}

	public static string smethod_9()
	{
		_ = null;
		_ = null;
		/*Error: Unexpected end of block*/;
	}
}
