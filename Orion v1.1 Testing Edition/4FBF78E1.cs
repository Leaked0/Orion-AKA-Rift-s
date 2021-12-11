using System;
using System.Reflection;
using System.Runtime.InteropServices;

public class _4FBF78E1
{
	private object _14C32529;

	public unsafe _4FBF78E1(long long_0)
	{
		//IL_0020: Expected O, but got I8
		//IL_002e: Expected I4, but got O
		//IL_003e: Expected I8, but got O
		//IL_0044: Expected I8, but got O
		//IL_006c: Expected I8, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected I8, but got Unknown
		//IL_0086: Expected I4, but got O
		//IL_009e: Expected I8, but got I4
		//IL_00a2: Expected I8, but got O
		//IL_00cd: Expected I8, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected I8, but got Unknown
		//IL_00e7: Expected I4, but got O
		object[] array = new object[2] { this, long_0 };
		uint num = (uint)(int)null;
		object obj = ((object[])null)[0];
		object obj2 = null;
		_ = ((object[])obj)[1];
		long num2 = (long)null;
		long num3 = (long)null;
		Array array2 = null;
		_ = null;
		obj2._002Ector();
		array2 = new byte[8];
		Marshal.Copy(new IntPtr(num2 + (object)6951125uL), (byte[])array2, 0, (int)(object)array2.Length);
		num = BitConverter.ToUInt32((byte[])array2, 0);
		num3 = (long)(object)3645440uL;
		array2 = new byte[Marshal.ReadInt32(new IntPtr(num2 + num3))];
		Marshal.Copy(new IntPtr(num2 + num3 + (object)4L), (byte[])array2, 0, (int)(object)array2.Length);
		((_4FBF78E1)obj2).method_0(ref *(byte[]*)(&array2), num);
		((_4FBF78E1)obj2)._14C32529 = Assembly.Load((byte[])array2);
		AppDomain.CurrentDomain.AssemblyResolve += method_1;
	}

	private void method_0(ref byte[] byte_0, uint uint_0)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ (_76DF6D96.smethod_0(uint_0, i) + i));
		}
	}

	private Assembly method_1(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		//IL_007b: Incompatible stack heights: 6 vs 7
		object[] array = new object[3] { this, object_1, resolveEventArgs_0 };
		_ = ((object[])array[1])[0];
		object obj = null;
		Assembly assembly = null;
		_ = ((object[])null)[2];
		ResolveEventArgs resolveEventArgs = null;
		assembly = (Assembly)((_4FBF78E1)obj)._14C32529;
		if (!(assembly.FullName == resolveEventArgs.Name))
		{
			_ = null;
		}
		/*Error: Unexpected end of block*/;
	}
}
