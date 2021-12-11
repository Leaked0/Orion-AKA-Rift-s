using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

internal class _108A18AAF
{
	private static void smethod_0()
	{
		new _78175594().method_112(null, 3588090);
	}

	static _108A18AAF()
	{
		new _78175594().method_112(null, 9391969);
	}

	public static int __EXTERNCALL_374480()
	{
		return (int)(object)new Random().Next();
	}

	public static int __EXTERNCALL_372858(uint P_0, uint P_1)
	{
		//IL_0015: Expected O, but got I4
		//IL_0020: Expected O, but got I4
		//IL_002e: Expected I8, but got O
		//IL_0036: Expected I4, but got O
		//IL_003d: Expected I, but got O
		//IL_0045: Expected I4, but got O
		//IL_007d: Expected I8, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected I8, but got Unknown
		object[] array = new object[2] { P_0, P_1 };
		long num = (long)null;
		_ = ((object[])null)[1];
		uint uint_ = (uint)(int)null;
		_ = null;
		nint num2 = (nint)null;
		_ = ((object[])null)[0];
		uint num3 = (uint)(int)null;
		num = Marshal.GetHINSTANCE(typeof(_48CE5C73).Module).ToInt64();
		return (int)(object)new _48CE5C73().method_0(new IntPtr(num + (object)(ulong)(int)num3), uint_);
	}

	public static Array __EXTERNCALL_373F33(object P_0)
	{
		//IL_002b: Expected I4, but got O
		//IL_0072: Incompatible stack heights: 5 vs 0
		//IL_008a: Incompatible stack heights: 0 vs 5
		object[] array = new object[1] { P_0 };
		_ = array[0];
		object obj = null;
		int num = (int)null;
		_ = null;
		MemoryStream memoryStream = null;
		memoryStream = new MemoryStream();
		for (num = ((_50CD666C)obj)._77B210A1; num < ((_50CD666C)obj)._587E6919.Count; num++)
		{
			memoryStream.Write(BitConverter.GetBytes(((_50CD666C)obj)._587E6919[num]), 0, 4);
		}
		/*Error: Unexpected end of block*/;
	}

	public static extern void __EXTERNCALL_36D595(object P_0, int P_1);

	public static void __EXTERNCALL_34FBD1(object P_0)
	{
		object[] array = new object[1] { P_0 };
		_ = null;
		Array array2 = null;
		object obj = null;
		array2 = Encoding.Unicode.GetBytes(Dns.GetHostName().ToUpperInvariant());
		__EXTERNCALL_34E56F(obj, array2, _50CD666C._2BF554F7._7F1737A9);
	}

	public static void __EXTERNCALL_34FB0E(object P_0)
	{
		//IL_0023: Expected I4, but got O
		//IL_0029: Expected I4, but got O
		//IL_0043: Expected I4, but got O
		//IL_0049: Expected I4, but got O
		//IL_0055: Expected I4, but got O
		//IL_00d0: Incompatible stack heights: 11 vs 0
		//IL_00e4: Incompatible stack heights: 0 vs 11
		//IL_00f0: Incompatible stack heights: 11 vs 0
		object[] array = new object[1] { P_0 };
		uint num = (uint)(int)null;
		PlatformID platformID = (PlatformID)null;
		FileInfo fileInfo = null;
		Array array2;
		_ = ((object[])(array2 = null))[0];
		object obj = null;
		uint num2 = (uint)(int)null;
		int num3 = (int)null;
		StringBuilder stringBuilder = null;
		uint num4 = (uint)(int)null;
		_ = null;
		switch (Environment.OSVersion.Platform)
		{
		case PlatformID.Unix:
		{
			DirectoryInfo directoryInfo = new DirectoryInfo("/dev/disk/by-uuid");
			stringBuilder = new StringBuilder();
			array2 = directoryInfo.GetFiles("*");
			for (num3 = 0; num3 < (nint)(object)array2.Length; num3++)
			{
				fileInfo = (FileInfo)((object[])array2)[num3];
				stringBuilder.Append(fileInfo.Name);
			}
			if (stringBuilder.Length > 0)
			{
				__EXTERNCALL_34E56F(obj, Encoding.UTF8.GetBytes(stringBuilder.ToString()), _50CD666C._2BF554F7._3EFE2DED);
			}
			break;
		}
		default:
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			num = 0u;
			num2 = 0u;
			num4 = 0u;
			if (_2CEC1FEE.GetVolumeInformation(pathRoot, null, 0u, ref num, ref num2, ref num4, null, 0u) && num != 0)
			{
				__EXTERNCALL_34E56F(obj, BitConverter.GetBytes(num), _50CD666C._2BF554F7._3EFE2DED);
			}
			break;
		}
		case PlatformID.MacOSX:
			break;
		}
	}

	public static void __EXTERNCALL_352DEA(object P_0)
	{
		//IL_0023: Expected I4, but got O
		//IL_0030: Expected I4, but got O
		//IL_00e3: Incompatible stack heights: 8 vs 0
		//IL_00f7: Incompatible stack heights: 0 vs 8
		object[] array = new object[1] { P_0 };
		int num = (int)null;
		NetworkInterface networkInterface = null;
		_ = null;
		int num2 = (int)null;
		_ = ((object[])null)[0];
		object obj = null;
		Array array2 = null;
		Array array3 = null;
		num2 = ((_50CD666C)obj)._587E6919.Count;
		array2 = null;
		array3 = NetworkInterface.GetAllNetworkInterfaces();
		for (num = 0; num < (nint)(object)array3.Length; num++)
		{
			networkInterface = (NetworkInterface)((object[])array3)[num];
			if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
			{
				array2 = networkInterface.GetPhysicalAddress().GetAddressBytes();
				if ((nint)(object)array2.Length >= 3)
				{
					__EXTERNCALL_36D1DC(obj, array2);
				}
			}
		}
		if (num2 == ((_50CD666C)obj)._587E6919.Count && array2 != null && (nint)(object)array2.Length >= 3)
		{
			__EXTERNCALL_34E56F(obj, array2, _50CD666C._2BF554F7._5F4346B8);
		}
	}

	public static extern void __EXTERNCALL_34E56F(object P_0, Array P_1, _50CD666C._2BF554F7 P_2);

	public static void __EXTERNCALL_36D1DC(object P_0, Array P_1)
	{
		//IL_003f: Expected I4, but got O
		object[] array = new object[2] { P_0, P_1 };
		object obj = array[1];
		Array array2 = null;
		_ = ((object[])obj)[0];
		object obj2 = null;
		_ = null;
		int num = (int)null;
		num = (((byte[])array2)[0] << 16) + (((byte[])array2)[1] << 8) + ((byte[])array2)[2];
		if (num != 1385 && num != 3113 && num != 7188 && num != 20566 && num != 1023 && num != 3386 && num != 4698 && num != 5469 && num != 6138 && num != 7640 && num != 8776 && num != 9646 && num != 20722 && num != 7234 && num != 8694)
		{
			__EXTERNCALL_34E56F(obj2, array2, _50CD666C._2BF554F7._5F4346B8);
		}
	}

	public extern bool __EXTERNCALLVIRT_372AC9(object P_0, Array P_1);

	public extern string __EXTERNCALLVIRT_3458B0(object P_0, uint P_1);

	public extern bool __EXTERNCALLVIRT_34623B(object P_0, string P_1);
}
