using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

public class _78175594
{
	private static class _08651210
	{
	}

	private abstract class _21600297
	{
		public abstract _21600297 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual _68145C97 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual _21600297 vmethod_5()
		{
			return this;
		}

		public virtual Type vmethod_6()
		{
			throw new InvalidOperationException();
		}

		public virtual TypeCode vmethod_7()
		{
			throw new InvalidOperationException();
		}

		public virtual bool CEFC7244()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short B427AF17()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int B09CBB3E()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long vmethod_9()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char AEF8DCB0()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_10()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort vmethod_11()
		{
			return Convert.ToUInt16(vmethod_1());
		}

		public virtual uint vmethod_12()
		{
			return Convert.ToUInt32(vmethod_1());
		}

		public virtual ulong vmethod_13()
		{
			return Convert.ToUInt64(vmethod_1());
		}

		public virtual float E86374E7()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double D1F6DB83()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			object obj = vmethod_1();
			if (obj == null)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		public virtual IntPtr EA7E6274()
		{
			throw new InvalidOperationException();
		}

		public virtual UIntPtr vmethod_14()
		{
			throw new InvalidOperationException();
		}

		public unsafe virtual void* vmethod_15()
		{
			throw new InvalidOperationException();
		}

		public virtual object vmethod_16(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class _68145C97 : _21600297
	{
		public override _68145C97 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	private sealed class _126D027D : _68145C97
	{
		private int _2160345C;

		public _126D027D(int int_1)
		{
			_2160345C = int_1;
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override _21600297 vmethod_0()
		{
			return new _126D027D(_2160345C);
		}

		public override object vmethod_1()
		{
			return _2160345C;
		}

		public override void vmethod_2(object object_0)
		{
			_2160345C = Convert.ToInt32(object_0);
		}

		public override bool CEFC7244()
		{
			return _2160345C != 0;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_2160345C;
		}

		public override short B427AF17()
		{
			return (short)_2160345C;
		}

		public override int B09CBB3E()
		{
			return _2160345C;
		}

		public override long vmethod_9()
		{
			return _2160345C;
		}

		public override char AEF8DCB0()
		{
			return (char)_2160345C;
		}

		public override byte vmethod_10()
		{
			return (byte)_2160345C;
		}

		public override ushort vmethod_11()
		{
			return (ushort)_2160345C;
		}

		public override uint vmethod_12()
		{
			return (uint)_2160345C;
		}

		public override ulong vmethod_13()
		{
			return (uint)_2160345C;
		}

		public override float E86374E7()
		{
			return _2160345C;
		}

		public override double D1F6DB83()
		{
			return _2160345C;
		}

		public override IntPtr EA7E6274()
		{
			return new IntPtr(_2160345C);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)_2160345C);
		}

		public override _21600297 vmethod_5()
		{
			return new _5E6145AE((uint)_2160345C);
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			if ((object)type_0 == typeof(IntPtr))
			{
				if (IntPtr.Size == 4)
				{
					return new IntPtr(bool_0 ? checked((int)(uint)_2160345C) : _2160345C);
				}
				return new IntPtr(bool_0 ? ((long)(uint)_2160345C) : ((long)_2160345C));
			}
			if ((object)type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(bool_0 ? ((uint)_2160345C) : checked((uint)_2160345C));
			}
			checked
			{
				return Type.GetTypeCode(type_0) switch
				{
					TypeCode.SByte => bool_0 ? ((sbyte)(uint)_2160345C) : ((sbyte)_2160345C), 
					TypeCode.Byte => bool_0 ? ((byte)(uint)_2160345C) : ((byte)_2160345C), 
					TypeCode.Int16 => bool_0 ? ((short)(uint)_2160345C) : ((short)_2160345C), 
					TypeCode.UInt16 => bool_0 ? ((ushort)(uint)_2160345C) : ((ushort)_2160345C), 
					TypeCode.Int32 => bool_0 ? ((int)(uint)_2160345C) : _2160345C, 
					TypeCode.UInt32 => bool_0 ? unchecked((uint)_2160345C) : ((uint)_2160345C), 
					TypeCode.Int64 => unchecked(bool_0 ? ((long)(uint)_2160345C) : ((long)_2160345C)), 
					TypeCode.UInt64 => bool_0 ? unchecked((uint)_2160345C) : ((uint)_2160345C), 
					TypeCode.Double => bool_0 ? ((double)unchecked((uint)_2160345C)) : ((double)_2160345C), 
					_ => throw new ArgumentException(), 
				};
			}
		}
	}

	private sealed class _5EE40585 : _68145C97
	{
		private long _7FDA0A4C;

		public _5EE40585(long long_1)
		{
			_7FDA0A4C = long_1;
		}

		public override Type vmethod_6()
		{
			return typeof(long);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		public override _21600297 vmethod_5()
		{
			return new _2A140318((ulong)_7FDA0A4C);
		}

		public override _21600297 vmethod_0()
		{
			return new _5EE40585(_7FDA0A4C);
		}

		public override object vmethod_1()
		{
			return _7FDA0A4C;
		}

		public override void vmethod_2(object object_0)
		{
			_7FDA0A4C = Convert.ToInt64(object_0);
		}

		public override bool CEFC7244()
		{
			return (ulong)_7FDA0A4C > 0uL;
		}

		public override char AEF8DCB0()
		{
			return (char)_7FDA0A4C;
		}

		public override byte vmethod_10()
		{
			return (byte)_7FDA0A4C;
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_7FDA0A4C;
		}

		public override short B427AF17()
		{
			return (short)_7FDA0A4C;
		}

		public override int B09CBB3E()
		{
			return (int)_7FDA0A4C;
		}

		public override long vmethod_9()
		{
			return _7FDA0A4C;
		}

		public override ushort vmethod_11()
		{
			return (ushort)_7FDA0A4C;
		}

		public override uint vmethod_12()
		{
			return (uint)_7FDA0A4C;
		}

		public override ulong vmethod_13()
		{
			return (ulong)_7FDA0A4C;
		}

		public override float E86374E7()
		{
			return _7FDA0A4C;
		}

		public override double D1F6DB83()
		{
			return _7FDA0A4C;
		}

		public override IntPtr EA7E6274()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)_7FDA0A4C) : _7FDA0A4C);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((ulong)((UIntPtr.Size == 4) ? ((uint)_7FDA0A4C) : _7FDA0A4C));
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			checked
			{
				if ((object)type_0 == typeof(IntPtr))
				{
					return new IntPtr(bool_0 ? ((long)(ulong)_7FDA0A4C) : _7FDA0A4C);
				}
				if ((object)type_0 == typeof(UIntPtr))
				{
					return new UIntPtr(bool_0 ? unchecked((ulong)_7FDA0A4C) : ((ulong)_7FDA0A4C));
				}
				return Type.GetTypeCode(type_0) switch
				{
					TypeCode.SByte => bool_0 ? ((sbyte)(ulong)_7FDA0A4C) : ((sbyte)_7FDA0A4C), 
					TypeCode.Byte => bool_0 ? ((byte)(ulong)_7FDA0A4C) : ((byte)_7FDA0A4C), 
					TypeCode.Int16 => bool_0 ? ((short)(ulong)_7FDA0A4C) : ((short)_7FDA0A4C), 
					TypeCode.UInt16 => bool_0 ? ((ushort)(uint)_7FDA0A4C) : ((ushort)_7FDA0A4C), 
					TypeCode.Int32 => bool_0 ? ((int)(ulong)_7FDA0A4C) : ((int)_7FDA0A4C), 
					TypeCode.UInt32 => bool_0 ? ((uint)(ulong)_7FDA0A4C) : ((uint)_7FDA0A4C), 
					TypeCode.Int64 => bool_0 ? ((long)(ulong)_7FDA0A4C) : _7FDA0A4C, 
					TypeCode.UInt64 => bool_0 ? unchecked((ulong)_7FDA0A4C) : ((ulong)_7FDA0A4C), 
					TypeCode.Double => bool_0 ? ((double)unchecked((ulong)_7FDA0A4C)) : ((double)_7FDA0A4C), 
					_ => throw new ArgumentException(), 
				};
			}
		}
	}

	private sealed class _7BBB7ACD : _68145C97
	{
		private float _6E923DE6;

		public _7BBB7ACD(float float_1)
		{
			_6E923DE6 = float_1;
		}

		public override Type vmethod_6()
		{
			return typeof(float);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		public override _21600297 vmethod_0()
		{
			return new _7BBB7ACD(_6E923DE6);
		}

		public override object vmethod_1()
		{
			return _6E923DE6;
		}

		public override void vmethod_2(object object_0)
		{
			_6E923DE6 = Convert.ToSingle(object_0);
		}

		public override bool CEFC7244()
		{
			return Convert.ToBoolean(_6E923DE6);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_6E923DE6;
		}

		public override short B427AF17()
		{
			return (short)_6E923DE6;
		}

		public override int B09CBB3E()
		{
			return (int)_6E923DE6;
		}

		public override long vmethod_9()
		{
			return (long)_6E923DE6;
		}

		public override char AEF8DCB0()
		{
			return (char)_6E923DE6;
		}

		public override byte vmethod_10()
		{
			return (byte)_6E923DE6;
		}

		public override ushort vmethod_11()
		{
			return (ushort)_6E923DE6;
		}

		public override uint vmethod_12()
		{
			return (uint)_6E923DE6;
		}

		public override ulong vmethod_13()
		{
			return (ulong)_6E923DE6;
		}

		public override float E86374E7()
		{
			return _6E923DE6;
		}

		public override double D1F6DB83()
		{
			return _6E923DE6;
		}

		public override IntPtr EA7E6274()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)_6E923DE6) : ((long)_6E923DE6));
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)_6E923DE6) : ((ulong)_6E923DE6));
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			checked
			{
				if ((object)type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)_6E923DE6);
				}
				if ((object)type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)_6E923DE6);
				}
				return Type.GetTypeCode(type_0) switch
				{
					TypeCode.SByte => bool_0 ? ((sbyte)(uint)_6E923DE6) : ((sbyte)_6E923DE6), 
					TypeCode.Byte => (byte)_6E923DE6, 
					TypeCode.Int16 => bool_0 ? ((short)(uint)_6E923DE6) : ((short)_6E923DE6), 
					TypeCode.UInt16 => (ushort)_6E923DE6, 
					TypeCode.Int32 => (int)_6E923DE6, 
					TypeCode.UInt32 => (uint)_6E923DE6, 
					TypeCode.UInt64 => (ulong)_6E923DE6, 
					_ => throw new ArgumentException(), 
				};
			}
		}
	}

	private sealed class _28644A28 : _68145C97
	{
		private double _7CA2778D;

		public _28644A28(double double_1)
		{
			_7CA2778D = double_1;
		}

		public override Type vmethod_6()
		{
			return typeof(double);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		public override _21600297 vmethod_0()
		{
			return new _28644A28(_7CA2778D);
		}

		public override object vmethod_1()
		{
			return _7CA2778D;
		}

		public override void vmethod_2(object object_0)
		{
			_7CA2778D = (double)object_0;
		}

		public override bool CEFC7244()
		{
			return Convert.ToBoolean(_7CA2778D);
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_7CA2778D;
		}

		public override short B427AF17()
		{
			return (short)_7CA2778D;
		}

		public override int B09CBB3E()
		{
			return (int)_7CA2778D;
		}

		public override long vmethod_9()
		{
			return (long)_7CA2778D;
		}

		public override char AEF8DCB0()
		{
			return (char)_7CA2778D;
		}

		public override byte vmethod_10()
		{
			return (byte)_7CA2778D;
		}

		public override ushort vmethod_11()
		{
			return (ushort)_7CA2778D;
		}

		public override uint vmethod_12()
		{
			return (uint)_7CA2778D;
		}

		public override ulong vmethod_13()
		{
			return (ulong)_7CA2778D;
		}

		public override float E86374E7()
		{
			return (float)_7CA2778D;
		}

		public override double D1F6DB83()
		{
			return _7CA2778D;
		}

		public override IntPtr EA7E6274()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)_7CA2778D) : ((long)_7CA2778D));
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)_7CA2778D) : ((ulong)_7CA2778D));
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			checked
			{
				if ((object)type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)_7CA2778D);
				}
				if ((object)type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)_7CA2778D);
				}
				return Type.GetTypeCode(type_0) switch
				{
					TypeCode.SByte => bool_0 ? ((sbyte)(uint)_7CA2778D) : ((sbyte)_7CA2778D), 
					TypeCode.Byte => (byte)_7CA2778D, 
					TypeCode.Int16 => bool_0 ? ((short)(uint)_7CA2778D) : ((short)_7CA2778D), 
					TypeCode.UInt16 => (ushort)_7CA2778D, 
					TypeCode.Int32 => (int)_7CA2778D, 
					TypeCode.UInt32 => (uint)_7CA2778D, 
					TypeCode.Int64 => (long)_7CA2778D, 
					TypeCode.UInt64 => (ulong)_7CA2778D, 
					TypeCode.Double => _7CA2778D, 
					_ => throw new ArgumentException(), 
				};
			}
		}
	}

	private sealed class _2AA82573 : _68145C97
	{
		private string _54F65D58;

		public _2AA82573(string string_1)
		{
			_54F65D58 = string_1;
		}

		public override Type vmethod_6()
		{
			return typeof(string);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override _21600297 vmethod_0()
		{
			return new _2AA82573(_54F65D58);
		}

		public override object vmethod_1()
		{
			return _54F65D58;
		}

		public override void vmethod_2(object object_0)
		{
			_54F65D58 = ((object_0 != null) ? Convert.ToString(object_0) : null);
		}

		public override bool CEFC7244()
		{
			return _54F65D58 != null;
		}

		public override string ToString()
		{
			return _54F65D58;
		}
	}

	private sealed class _2D757F03 : _21600297
	{
		private short _38470B1E;

		public _2D757F03(short short_1)
		{
			_38470B1E = short_1;
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override _21600297 vmethod_0()
		{
			return new _2D757F03(_38470B1E);
		}

		public override object vmethod_1()
		{
			return _38470B1E;
		}

		public override void vmethod_2(object object_0)
		{
			_38470B1E = Convert.ToInt16(object_0);
		}

		public override _68145C97 vmethod_4()
		{
			return new _126D027D(B09CBB3E());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_38470B1E;
		}

		public override byte vmethod_10()
		{
			return (byte)_38470B1E;
		}

		public override short B427AF17()
		{
			return _38470B1E;
		}

		public override ushort vmethod_11()
		{
			return (ushort)_38470B1E;
		}

		public override int B09CBB3E()
		{
			return _38470B1E;
		}

		public override uint vmethod_12()
		{
			return (uint)_38470B1E;
		}
	}

	private sealed class _6D75718F : _21600297
	{
		private ushort _27276BAB;

		public _6D75718F(ushort ushort_1)
		{
			_27276BAB = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override _21600297 vmethod_0()
		{
			return new _6D75718F(_27276BAB);
		}

		public override object vmethod_1()
		{
			return _27276BAB;
		}

		public override void vmethod_2(object object_0)
		{
			_27276BAB = Convert.ToUInt16(object_0);
		}

		public override _68145C97 vmethod_4()
		{
			return new _126D027D(B09CBB3E());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_27276BAB;
		}

		public override byte vmethod_10()
		{
			return (byte)_27276BAB;
		}

		public override short B427AF17()
		{
			return (short)_27276BAB;
		}

		public override ushort vmethod_11()
		{
			return _27276BAB;
		}

		public override int B09CBB3E()
		{
			return _27276BAB;
		}

		public override uint vmethod_12()
		{
			return _27276BAB;
		}
	}

	private sealed class _64C25F46 : _21600297
	{
		private bool _5CFB0951;

		public _64C25F46(bool bool_1)
		{
			_5CFB0951 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override _21600297 vmethod_0()
		{
			return new _64C25F46(_5CFB0951);
		}

		public override object vmethod_1()
		{
			return _5CFB0951;
		}

		public override void vmethod_2(object object_0)
		{
			_5CFB0951 = Convert.ToBoolean(object_0);
		}

		public override _68145C97 vmethod_4()
		{
			return new _126D027D(B09CBB3E());
		}

		public override int B09CBB3E()
		{
			if (!_5CFB0951)
			{
				return 0;
			}
			return 1;
		}
	}

	private sealed class _3EEA6600 : _21600297
	{
		private char _487D2464;

		public _3EEA6600(char char_1)
		{
			_487D2464 = char_1;
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override _21600297 vmethod_0()
		{
			return new _3EEA6600(_487D2464);
		}

		public override object vmethod_1()
		{
			return _487D2464;
		}

		public override void vmethod_2(object object_0)
		{
			_487D2464 = Convert.ToChar(object_0);
		}

		public override _68145C97 vmethod_4()
		{
			return new _126D027D(B09CBB3E());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_487D2464;
		}

		public override byte vmethod_10()
		{
			return (byte)_487D2464;
		}

		public override short B427AF17()
		{
			return (short)_487D2464;
		}

		public override ushort vmethod_11()
		{
			return _487D2464;
		}

		public override int B09CBB3E()
		{
			return _487D2464;
		}

		public override uint vmethod_12()
		{
			return _487D2464;
		}
	}

	private sealed class _157029B6 : _21600297
	{
		private byte _543859BC;

		public _157029B6(byte byte_1)
		{
			_543859BC = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override _21600297 vmethod_0()
		{
			return new _157029B6(_543859BC);
		}

		public override object vmethod_1()
		{
			return _543859BC;
		}

		public override void vmethod_2(object object_0)
		{
			_543859BC = Convert.ToByte(object_0);
		}

		public override _68145C97 vmethod_4()
		{
			return new _126D027D(B09CBB3E());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_543859BC;
		}

		public override byte vmethod_10()
		{
			return _543859BC;
		}

		public override short B427AF17()
		{
			return _543859BC;
		}

		public override ushort vmethod_11()
		{
			return _543859BC;
		}

		public override int B09CBB3E()
		{
			return _543859BC;
		}

		public override uint vmethod_12()
		{
			return _543859BC;
		}
	}

	private sealed class _7C4A2F04 : _21600297
	{
		private sbyte _7F0F5936;

		public _7C4A2F04(sbyte sbyte_1)
		{
			_7F0F5936 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override _21600297 vmethod_0()
		{
			return new _7C4A2F04(_7F0F5936);
		}

		public override object vmethod_1()
		{
			return _7F0F5936;
		}

		public override void vmethod_2(object object_0)
		{
			_7F0F5936 = Convert.ToSByte(object_0);
		}

		public override _68145C97 vmethod_4()
		{
			return new _126D027D(B09CBB3E());
		}

		public override sbyte vmethod_8()
		{
			return _7F0F5936;
		}

		public override byte vmethod_10()
		{
			return (byte)_7F0F5936;
		}

		public override short B427AF17()
		{
			return _7F0F5936;
		}

		public override ushort vmethod_11()
		{
			return (ushort)_7F0F5936;
		}

		public override int B09CBB3E()
		{
			return _7F0F5936;
		}

		public override uint vmethod_12()
		{
			return (uint)_7F0F5936;
		}
	}

	private sealed class _5E6145AE : _21600297
	{
		private uint _44B62C33;

		public _5E6145AE(uint uint_1)
		{
			_44B62C33 = uint_1;
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override _21600297 vmethod_0()
		{
			return new _5E6145AE(_44B62C33);
		}

		public override object vmethod_1()
		{
			return _44B62C33;
		}

		public override void vmethod_2(object object_0)
		{
			_44B62C33 = Convert.ToUInt32(object_0);
		}

		public override _68145C97 vmethod_4()
		{
			return new _126D027D(B09CBB3E());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_44B62C33;
		}

		public override byte vmethod_10()
		{
			return (byte)_44B62C33;
		}

		public override short B427AF17()
		{
			return (short)_44B62C33;
		}

		public override ushort vmethod_11()
		{
			return (ushort)_44B62C33;
		}

		public override int B09CBB3E()
		{
			return (int)_44B62C33;
		}

		public override uint vmethod_12()
		{
			return _44B62C33;
		}
	}

	private sealed class _2A140318 : _21600297
	{
		private ulong _56360C17;

		public _2A140318(ulong ulong_1)
		{
			_56360C17 = ulong_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override _21600297 vmethod_0()
		{
			return new _2A140318(_56360C17);
		}

		public override object vmethod_1()
		{
			return _56360C17;
		}

		public override void vmethod_2(object object_0)
		{
			_56360C17 = Convert.ToUInt64(object_0);
		}

		public override _68145C97 vmethod_4()
		{
			return new _5EE40585(vmethod_9());
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)_56360C17;
		}

		public override byte vmethod_10()
		{
			return (byte)_56360C17;
		}

		public override short B427AF17()
		{
			return (short)_56360C17;
		}

		public override ushort vmethod_11()
		{
			return (ushort)_56360C17;
		}

		public override int B09CBB3E()
		{
			return (int)_56360C17;
		}

		public override uint vmethod_12()
		{
			return (uint)_56360C17;
		}

		public override long vmethod_9()
		{
			return (long)_56360C17;
		}

		public override ulong vmethod_13()
		{
			return _56360C17;
		}
	}

	private sealed class _4DB54CCC : _68145C97
	{
		private object _226E48CB;

		public _4DB54CCC(object object_1)
		{
			_226E48CB = object_1;
		}

		public override Type vmethod_6()
		{
			return typeof(object);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override _21600297 vmethod_0()
		{
			return new _4DB54CCC(_226E48CB);
		}

		public override object vmethod_1()
		{
			return _226E48CB;
		}

		public override void vmethod_2(object object_1)
		{
			_226E48CB = object_1;
		}

		public override bool CEFC7244()
		{
			return _226E48CB != null;
		}
	}

	private sealed class _040A72F8 : _68145C97
	{
		private object _0D2D39A2;

		private Type _1FEB4F49;

		private _21600297 _6AF36958;

		public _040A72F8(object object_1, Type type_1)
		{
			_0D2D39A2 = object_1;
			_1FEB4F49 = type_1;
			_6AF36958 = smethod_0(object_1);
		}

		private unsafe static _21600297 smethod_0(object object_1)
		{
			IntPtr intPtr = ((object_1 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_1)));
			if (IntPtr.Size == 4)
			{
				return new _126D027D(intPtr.ToInt32());
			}
			return new _5EE40585(intPtr.ToInt64());
		}

		public override Type vmethod_6()
		{
			return _1FEB4F49;
		}

		public override TypeCode vmethod_7()
		{
			if (IntPtr.Size != 4)
			{
				return TypeCode.UInt64;
			}
			return TypeCode.UInt32;
		}

		public override _21600297 vmethod_0()
		{
			return new _040A72F8(_0D2D39A2, _1FEB4F49);
		}

		public override object vmethod_1()
		{
			return _0D2D39A2;
		}

		public override void vmethod_2(object object_1)
		{
			_0D2D39A2 = object_1;
			_6AF36958 = smethod_0(object_1);
		}

		public override bool CEFC7244()
		{
			return _0D2D39A2 != null;
		}

		public override sbyte vmethod_8()
		{
			return _6AF36958.vmethod_8();
		}

		public override short B427AF17()
		{
			return _6AF36958.B427AF17();
		}

		public override int B09CBB3E()
		{
			return _6AF36958.B09CBB3E();
		}

		public override long vmethod_9()
		{
			return _6AF36958.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return _6AF36958.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return _6AF36958.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return _6AF36958.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return _6AF36958.vmethod_13();
		}

		public override float E86374E7()
		{
			return _6AF36958.E86374E7();
		}

		public override double D1F6DB83()
		{
			return _6AF36958.D1F6DB83();
		}

		public override IntPtr EA7E6274()
		{
			return _6AF36958.EA7E6274();
		}

		public override UIntPtr vmethod_14()
		{
			return _6AF36958.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(_0D2D39A2);
		}

		public override object vmethod_16(Type type_1, bool bool_0)
		{
			return _6AF36958.vmethod_16(type_1, bool_0);
		}
	}

	private sealed class _4DEB451A : _68145C97
	{
		private object _40F44376;

		public _4DEB451A(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			_40F44376 = object_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override _21600297 vmethod_0()
		{
			return new _4DEB451A(_40F44376);
		}

		public override object vmethod_1()
		{
			return _40F44376;
		}

		public override void vmethod_2(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			_40F44376 = object_1;
		}
	}

	private sealed class _57B059F4 : _68145C97
	{
		private Array _2F49596D;

		public _57B059F4(Array array_1)
		{
			_2F49596D = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override _21600297 vmethod_0()
		{
			return new _57B059F4(_2F49596D);
		}

		public override object vmethod_1()
		{
			return _2F49596D;
		}

		public override void vmethod_2(object object_0)
		{
			_2F49596D = (Array)object_0;
		}

		public override bool CEFC7244()
		{
			return _2F49596D != null;
		}
	}

	private abstract class _6F6A1065 : _68145C97
	{
		public override bool vmethod_3()
		{
			return true;
		}
	}

	private sealed class _640F66ED : _6F6A1065
	{
		private _21600297 _296D27EF;

		public _640F66ED(_21600297 _21600297_1)
		{
			_296D27EF = _21600297_1;
		}

		public override Type vmethod_6()
		{
			return _296D27EF.vmethod_6();
		}

		public override _21600297 vmethod_0()
		{
			return new _640F66ED(_296D27EF);
		}

		public override object vmethod_1()
		{
			return _296D27EF.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			_296D27EF.vmethod_2(object_0);
		}

		public override bool CEFC7244()
		{
			return _296D27EF != null;
		}
	}

	private sealed class _7D3D6A85 : _6F6A1065
	{
		private _21600297 _5B3A77C5;

		private _21600297 _631D295A;

		public _7D3D6A85(_21600297 _21600297_2, _21600297 _21600297_3)
		{
			_5B3A77C5 = _21600297_2;
			_631D295A = _21600297_3;
		}

		public override Type vmethod_6()
		{
			return _5B3A77C5.vmethod_6();
		}

		public override _21600297 vmethod_0()
		{
			return new _7D3D6A85(_5B3A77C5, _631D295A);
		}

		public override object vmethod_1()
		{
			return _5B3A77C5.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			_5B3A77C5.vmethod_2(object_0);
			_631D295A.vmethod_2(_5B3A77C5.vmethod_1());
		}

		public override bool CEFC7244()
		{
			return _5B3A77C5 != null;
		}
	}

	private sealed class _1C46174C : _6F6A1065
	{
		private FieldInfo _08791BFA;

		private object _4F6D435B;

		public _1C46174C(FieldInfo fieldInfo_1, object object_1)
		{
			_08791BFA = fieldInfo_1;
			_4F6D435B = object_1;
		}

		public override Type vmethod_6()
		{
			return _08791BFA.FieldType;
		}

		public override _21600297 vmethod_0()
		{
			return new _1C46174C(_08791BFA, _4F6D435B);
		}

		public override object vmethod_1()
		{
			return _08791BFA.GetValue(_4F6D435B);
		}

		public override void vmethod_2(object object_1)
		{
			_08791BFA.SetValue(_4F6D435B, object_1);
		}
	}

	private sealed class _742E5594 : _6F6A1065
	{
		private Array _034D1AAB;

		private int _16937202;

		public _742E5594(Array array_1, int int_1)
		{
			_034D1AAB = array_1;
			_16937202 = int_1;
		}

		public override Type vmethod_6()
		{
			return _034D1AAB.GetType().GetElementType();
		}

		public override _21600297 vmethod_0()
		{
			return new _742E5594(_034D1AAB, _16937202);
		}

		public override object vmethod_1()
		{
			return _034D1AAB.GetValue(_16937202);
		}

		public override void vmethod_2(object object_0)
		{
			_034D1AAB.SetValue(object_0, _16937202);
		}

		public override UIntPtr vmethod_14()
		{
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(UIntPtr), new Type[2]
			{
				_034D1AAB.GetType(),
				typeof(int)
			}, typeof(_78175594).Module, skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg, 0);
			iLGenerator.Emit(OpCodes.Ldarg, 1);
			iLGenerator.Emit(OpCodes.Ldelema, _034D1AAB.GetType().GetElementType());
			iLGenerator.Emit(OpCodes.Conv_U);
			iLGenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[2] { _034D1AAB, _16937202 });
		}
	}

	private sealed class _72B5764C : _68145C97
	{
		private MethodBase _1F184E32;

		public _72B5764C(MethodBase methodBase_1)
		{
			_1F184E32 = methodBase_1;
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override _21600297 vmethod_0()
		{
			return new _72B5764C(_1F184E32);
		}

		public override object vmethod_1()
		{
			return _1F184E32;
		}

		public override void vmethod_2(object object_0)
		{
			_1F184E32 = (MethodBase)object_0;
		}

		public override bool CEFC7244()
		{
			return (object)_1F184E32 != null;
		}

		public override IntPtr EA7E6274()
		{
			return _1F184E32.MethodHandle.GetFunctionPointer();
		}
	}

	private sealed class _65634F03 : _68145C97
	{
		private IntPtr _6E3C2E62;

		private _21600297 _1CFF5CAC;

		public _65634F03(IntPtr intptr_1)
		{
			_6E3C2E62 = intptr_1;
			_1CFF5CAC = smethod_0(_6E3C2E62);
		}

		private static _21600297 smethod_0(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new _126D027D(intptr_1.ToInt32());
			}
			return new _5EE40585(intptr_1.ToInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return _1CFF5CAC.vmethod_7();
		}

		public override _21600297 vmethod_0()
		{
			return new _65634F03(_6E3C2E62);
		}

		public override object vmethod_1()
		{
			return _6E3C2E62;
		}

		public override void vmethod_2(object object_0)
		{
			_6E3C2E62 = (IntPtr)object_0;
			_1CFF5CAC = smethod_0(_6E3C2E62);
		}

		public override bool CEFC7244()
		{
			return _6E3C2E62 != IntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return _1CFF5CAC.vmethod_8();
		}

		public override short B427AF17()
		{
			return _1CFF5CAC.B427AF17();
		}

		public override int B09CBB3E()
		{
			return _1CFF5CAC.B09CBB3E();
		}

		public override long vmethod_9()
		{
			return _1CFF5CAC.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return _1CFF5CAC.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return _1CFF5CAC.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return _1CFF5CAC.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return _1CFF5CAC.vmethod_13();
		}

		public override float E86374E7()
		{
			return _1CFF5CAC.E86374E7();
		}

		public override double D1F6DB83()
		{
			return _1CFF5CAC.D1F6DB83();
		}

		public override IntPtr EA7E6274()
		{
			return _6E3C2E62;
		}

		public override UIntPtr vmethod_14()
		{
			return _1CFF5CAC.vmethod_14();
		}

		public unsafe override void* vmethod_15()
		{
			return _6E3C2E62.ToPointer();
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return _1CFF5CAC.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class _71071801 : _68145C97
	{
		private UIntPtr _28D16504;

		private _21600297 _5D952698;

		public _71071801(UIntPtr uintptr_1)
		{
			_28D16504 = uintptr_1;
			_5D952698 = smethod_0(_28D16504);
		}

		private static _21600297 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new _126D027D((int)uintptr_1.ToUInt32());
			}
			return new _5EE40585((long)uintptr_1.ToUInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return _5D952698.vmethod_7();
		}

		public override _21600297 vmethod_0()
		{
			return new _71071801(_28D16504);
		}

		public override object vmethod_1()
		{
			return _28D16504;
		}

		public override void vmethod_2(object object_0)
		{
			_28D16504 = (UIntPtr)object_0;
			_5D952698 = smethod_0(_28D16504);
		}

		public override bool CEFC7244()
		{
			return _28D16504 != UIntPtr.Zero;
		}

		public override sbyte vmethod_8()
		{
			return _5D952698.vmethod_8();
		}

		public override short B427AF17()
		{
			return _5D952698.B427AF17();
		}

		public override int B09CBB3E()
		{
			return _5D952698.B09CBB3E();
		}

		public override long vmethod_9()
		{
			return _5D952698.vmethod_9();
		}

		public override byte vmethod_10()
		{
			return _5D952698.vmethod_10();
		}

		public override ushort vmethod_11()
		{
			return _5D952698.vmethod_11();
		}

		public override uint vmethod_12()
		{
			return _5D952698.vmethod_12();
		}

		public override ulong vmethod_13()
		{
			return _5D952698.vmethod_13();
		}

		public override float E86374E7()
		{
			return _5D952698.E86374E7();
		}

		public override double D1F6DB83()
		{
			return _5D952698.D1F6DB83();
		}

		public override IntPtr EA7E6274()
		{
			return _5D952698.EA7E6274();
		}

		public override UIntPtr vmethod_14()
		{
			return _28D16504;
		}

		public unsafe override void* vmethod_15()
		{
			return _28D16504.ToPointer();
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return _5D952698.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class _44DC09D3 : _68145C97
	{
		private Enum _2F5D5B4E;

		private _21600297 _398A405D;

		public _44DC09D3(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			_2F5D5B4E = enum_1;
			_398A405D = smethod_0(_2F5D5B4E);
		}

		private static _21600297 smethod_0(Enum enum_1)
		{
			switch (enum_1.GetTypeCode())
			{
			default:
				throw new InvalidOperationException();
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
				return new _126D027D(Convert.ToInt32(enum_1));
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
				return new _126D027D((int)Convert.ToUInt32(enum_1));
			case TypeCode.Int64:
				return new _5EE40585(Convert.ToInt64(enum_1));
			case TypeCode.UInt64:
				return new _5EE40585((long)Convert.ToUInt64(enum_1));
			}
		}

		public override _21600297 vmethod_5()
		{
			return _398A405D.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return _2F5D5B4E.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return _398A405D.vmethod_7();
		}

		public override _21600297 vmethod_0()
		{
			return new _44DC09D3(_2F5D5B4E);
		}

		public override object vmethod_1()
		{
			return _2F5D5B4E;
		}

		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			_2F5D5B4E = (Enum)object_0;
			_398A405D = smethod_0(_2F5D5B4E);
		}

		public override byte vmethod_10()
		{
			return _398A405D.vmethod_10();
		}

		public override sbyte vmethod_8()
		{
			return _398A405D.vmethod_8();
		}

		public override short B427AF17()
		{
			return _398A405D.B427AF17();
		}

		public override ushort vmethod_11()
		{
			return _398A405D.vmethod_11();
		}

		public override int B09CBB3E()
		{
			return _398A405D.B09CBB3E();
		}

		public override uint vmethod_12()
		{
			return _398A405D.vmethod_12();
		}

		public override long vmethod_9()
		{
			return _398A405D.vmethod_9();
		}

		public override ulong vmethod_13()
		{
			return _398A405D.vmethod_13();
		}

		public override float E86374E7()
		{
			return _398A405D.E86374E7();
		}

		public override double D1F6DB83()
		{
			return _398A405D.D1F6DB83();
		}

		public override IntPtr EA7E6274()
		{
			return new IntPtr((IntPtr.Size == 4) ? B09CBB3E() : vmethod_9());
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? vmethod_12() : vmethod_13());
		}

		public override object vmethod_16(Type type_0, bool bool_0)
		{
			return _398A405D.vmethod_16(type_0, bool_0);
		}
	}

	private sealed class _304258A5 : _6F6A1065
	{
		private IntPtr _09F178F9;

		private Type _271A37B6;

		public _304258A5(IntPtr intptr_1, Type type_1)
		{
			_09F178F9 = intptr_1;
			_271A37B6 = type_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override _21600297 vmethod_0()
		{
			return new _304258A5(_09F178F9, _271A37B6);
		}

		public override object vmethod_1()
		{
			if (!_271A37B6.IsValueType)
			{
				throw new InvalidOperationException();
			}
			return Marshal.PtrToStructure(_09F178F9, _271A37B6);
		}

		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			if (_271A37B6.IsValueType)
			{
				Marshal.StructureToPtr(object_0, _09F178F9, fDeleteOld: false);
				return;
			}
			switch (Type.GetTypeCode(object_0.GetType()))
			{
			default:
				throw new ArgumentException();
			case TypeCode.Char:
				Marshal.WriteInt16(_09F178F9, Convert.ToChar(object_0));
				break;
			case TypeCode.SByte:
				Marshal.WriteByte(_09F178F9, (byte)Convert.ToSByte(object_0));
				break;
			case TypeCode.Byte:
				Marshal.WriteByte(_09F178F9, Convert.ToByte(object_0));
				break;
			case TypeCode.Int16:
				Marshal.WriteInt16(_09F178F9, Convert.ToInt16(object_0));
				break;
			case TypeCode.UInt16:
				Marshal.WriteInt16(_09F178F9, (short)Convert.ToUInt16(object_0));
				break;
			case TypeCode.Int32:
				Marshal.WriteInt32(_09F178F9, Convert.ToInt32(object_0));
				break;
			case TypeCode.UInt32:
				Marshal.WriteInt32(_09F178F9, (int)Convert.ToUInt32(object_0));
				break;
			case TypeCode.Int64:
				Marshal.WriteInt64(_09F178F9, Convert.ToInt64(object_0));
				break;
			case TypeCode.UInt64:
				Marshal.WriteInt64(_09F178F9, (long)Convert.ToUInt64(object_0));
				break;
			case TypeCode.Single:
				Marshal.WriteInt32(_09F178F9, BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(object_0)), 0));
				break;
			case TypeCode.Double:
				Marshal.WriteInt64(_09F178F9, BitConverter.ToInt64(BitConverter.GetBytes(Convert.ToDouble(object_0)), 0));
				break;
			}
		}

		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(_09F178F9);
		}

		public override short B427AF17()
		{
			return Marshal.ReadInt16(_09F178F9);
		}

		public override int B09CBB3E()
		{
			return Marshal.ReadInt32(_09F178F9);
		}

		public override long vmethod_9()
		{
			return Marshal.ReadInt64(_09F178F9);
		}

		public override char AEF8DCB0()
		{
			return (char)Marshal.ReadInt16(_09F178F9);
		}

		public override byte vmethod_10()
		{
			return Marshal.ReadByte(_09F178F9);
		}

		public override ushort vmethod_11()
		{
			return (ushort)Marshal.ReadInt16(_09F178F9);
		}

		public override uint vmethod_12()
		{
			return (uint)Marshal.ReadInt32(_09F178F9);
		}

		public override ulong vmethod_13()
		{
			return (ulong)Marshal.ReadInt64(_09F178F9);
		}

		public override float E86374E7()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(_09F178F9)), 0);
		}

		public override double D1F6DB83()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(_09F178F9)), 0);
		}

		public override IntPtr EA7E6274()
		{
			return new IntPtr((IntPtr.Size == 4) ? Marshal.ReadInt32(_09F178F9) : Marshal.ReadInt64(_09F178F9));
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((ulong)((IntPtr.Size == 4) ? ((uint)Marshal.ReadInt32(_09F178F9)) : Marshal.ReadInt64(_09F178F9)));
		}
	}

	private sealed class _4EDA20B8
	{
		private byte _6EB30AA9;

		private int _21C469A9;

		private int _3FC773B9;

		public _4EDA20B8(byte byte_1, int int_2, int int_3)
		{
			_6EB30AA9 = byte_1;
			_21C469A9 = int_2;
			_3FC773B9 = int_3;
		}

		public byte method_0()
		{
			return _6EB30AA9;
		}

		public int method_1()
		{
			return _21C469A9;
		}

		public int method_2()
		{
			return _3FC773B9;
		}
	}

	private sealed class _35F01253
	{
		private int _190D6CA7;

		private int _6C020027;

		private List<_4EDA20B8> _4B045ABA = new List<_4EDA20B8>();

		public _35F01253(int int_2, int int_3)
		{
			_190D6CA7 = int_2;
			_6C020027 = int_3;
		}

		public int method_0()
		{
			return _190D6CA7;
		}

		public int method_1()
		{
			return _6C020027;
		}

		public int method_2(_35F01253 _35F01253_0)
		{
			if (_35F01253_0 == null)
			{
				return 1;
			}
			int num = _190D6CA7.CompareTo(_35F01253_0.method_0());
			if (num == 0)
			{
				num = _35F01253_0.method_1().CompareTo(_6C020027);
			}
			return num;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			_4B045ABA.Add(new _4EDA20B8(byte_0, int_2, int_3));
		}

		public List<_4EDA20B8> method_4()
		{
			return _4B045ABA;
		}
	}

	internal delegate void _082421F7();

	private readonly Dictionary<uint, _082421F7> _02D80D37 = new Dictionary<uint, _082421F7>();

	private readonly Module _47E82D97 = typeof(_78175594).Module;

	private readonly long _11B36298;

	private int _022B0EDA;

	private Type _00081A81;

	private Stack<_68145C97> _25F8441D = new Stack<_68145C97>();

	private static readonly Dictionary<int, object> _74851D79 = new Dictionary<int, object>();

	private static readonly Dictionary<MethodBase, DynamicMethod> _240B3C39 = new Dictionary<MethodBase, DynamicMethod>();

	private List<_21600297> _1F6E243F = new List<_21600297>();

	private List<_35F01253> _35726215 = new List<_35F01253>();

	private Stack<_35F01253> _3DE43E02 = new Stack<_35F01253>();

	private Stack<int> _18F37474 = new Stack<int>();

	private Exception _626806D4;

	private _4EDA20B8 _3FA81011;

	private List<IntPtr> _269B225D = new List<IntPtr>();

	public _78175594()
	{
		_11B36298 = Marshal.GetHINSTANCE(_47E82D97).ToInt64();
		_02D80D37[0u] = method_72;
		_02D80D37[1u] = method_58;
		_02D80D37[2u] = method_108;
		_02D80D37[3u] = method_82;
		_02D80D37[4u] = method_36;
		_02D80D37[5u] = method_42;
		_02D80D37[6u] = method_85;
		_02D80D37[7u] = method_9;
		_02D80D37[8u] = method_63;
		_02D80D37[9u] = method_52;
		_02D80D37[10u] = method_43;
		_02D80D37[11u] = method_81;
		_02D80D37[12u] = method_80;
		_02D80D37[13u] = method_106;
		_02D80D37[14u] = method_75;
		_02D80D37[15u] = method_45;
		_02D80D37[16u] = method_87;
		_02D80D37[17u] = method_107;
		_02D80D37[18u] = method_49;
		_02D80D37[19u] = method_68;
		_02D80D37[20u] = method_88;
		_02D80D37[21u] = method_56;
		_02D80D37[22u] = method_37;
		_02D80D37[23u] = method_67;
		_02D80D37[24u] = method_84;
		_02D80D37[25u] = method_47;
		_02D80D37[26u] = method_57;
		_02D80D37[27u] = method_78;
		_02D80D37[28u] = method_93;
		_02D80D37[29u] = method_91;
		_02D80D37[30u] = method_76;
		_02D80D37[31u] = method_39;
		_02D80D37[32u] = method_62;
		_02D80D37[33u] = method_50;
		_02D80D37[34u] = method_83;
		_02D80D37[35u] = method_98;
		_02D80D37[36u] = method_64;
		_02D80D37[37u] = method_35;
		_02D80D37[38u] = method_73;
		_02D80D37[39u] = method_97;
		_02D80D37[40u] = method_103;
		_02D80D37[41u] = method_90;
		_02D80D37[42u] = method_94;
		_02D80D37[43u] = method_48;
		_02D80D37[44u] = method_104;
		_02D80D37[45u] = method_70;
		_02D80D37[46u] = method_100;
		_02D80D37[47u] = method_46;
		_02D80D37[48u] = method_65;
		_02D80D37[49u] = method_38;
		_02D80D37[50u] = method_40;
		_02D80D37[51u] = method_53;
		_02D80D37[52u] = method_109;
		_02D80D37[53u] = method_99;
		_02D80D37[54u] = method_54;
		_02D80D37[55u] = method_92;
		_02D80D37[56u] = method_77;
		_02D80D37[57u] = method_61;
		_02D80D37[58u] = method_102;
		_02D80D37[59u] = method_41;
		_02D80D37[60u] = method_74;
		_02D80D37[61u] = method_69;
		_02D80D37[62u] = method_44;
		_02D80D37[63u] = method_59;
		_02D80D37[64u] = method_66;
		_02D80D37[65u] = method_110;
		_02D80D37[66u] = method_101;
		_02D80D37[67u] = method_105;
		_02D80D37[68u] = method_96;
		_02D80D37[69u] = method_86;
		_02D80D37[70u] = method_95;
		_02D80D37[71u] = method_89;
		_02D80D37[72u] = method_51;
		_02D80D37[73u] = method_60;
		_02D80D37[74u] = method_55;
		_02D80D37[75u] = method_79;
		_02D80D37[76u] = method_71;
		_02D80D37[77u] = method_89;
		_02D80D37[78u] = method_56;
		_02D80D37[79u] = method_55;
		_02D80D37[80u] = method_60;
		_02D80D37[81u] = method_75;
		_02D80D37[82u] = method_79;
		_02D80D37[83u] = method_37;
		_02D80D37[84u] = method_80;
		_02D80D37[85u] = method_72;
		_02D80D37[86u] = method_101;
		_02D80D37[87u] = method_61;
		_02D80D37[88u] = method_74;
		_02D80D37[89u] = method_79;
		_02D80D37[90u] = method_80;
		_02D80D37[91u] = method_55;
		_02D80D37[92u] = method_37;
		_02D80D37[93u] = method_60;
		_02D80D37[94u] = method_55;
		_02D80D37[95u] = method_57;
		_02D80D37[96u] = method_104;
		_02D80D37[97u] = method_72;
		_02D80D37[98u] = method_93;
		_02D80D37[99u] = method_58;
		_02D80D37[100u] = method_72;
		_02D80D37[101u] = method_79;
		_02D80D37[102u] = method_55;
		_02D80D37[103u] = method_36;
		_02D80D37[104u] = method_49;
		_02D80D37[105u] = method_40;
		_02D80D37[106u] = method_70;
		_02D80D37[107u] = method_83;
		_02D80D37[108u] = method_100;
		_02D80D37[109u] = method_41;
		_02D80D37[110u] = method_46;
		_02D80D37[111u] = method_92;
		_02D80D37[112u] = method_44;
		_02D80D37[113u] = method_60;
		_02D80D37[114u] = method_72;
		_02D80D37[115u] = method_110;
		_02D80D37[116u] = method_70;
		_02D80D37[117u] = method_40;
		_02D80D37[118u] = method_109;
		_02D80D37[119u] = method_79;
		_02D80D37[120u] = method_74;
		_02D80D37[121u] = method_53;
		_02D80D37[122u] = method_65;
		_02D80D37[123u] = method_92;
		_02D80D37[124u] = method_55;
		_02D80D37[125u] = method_52;
		_02D80D37[126u] = method_39;
		_02D80D37[127u] = method_47;
		_02D80D37[128u] = method_66;
		_02D80D37[129u] = method_93;
		_02D80D37[130u] = method_44;
		_02D80D37[131u] = method_101;
		_02D80D37[132u] = method_79;
		_02D80D37[133u] = method_93;
		_02D80D37[134u] = method_66;
		_02D80D37[135u] = method_74;
		_02D80D37[136u] = method_100;
		_02D80D37[137u] = method_47;
		_02D80D37[138u] = method_63;
		_02D80D37[139u] = method_72;
		_02D80D37[140u] = method_106;
		_02D80D37[141u] = method_93;
		_02D80D37[142u] = method_101;
		_02D80D37[143u] = method_103;
		_02D80D37[144u] = method_72;
		_02D80D37[145u] = method_105;
		_02D80D37[146u] = method_91;
		_02D80D37[147u] = method_91;
		_02D80D37[148u] = method_74;
		_02D80D37[149u] = method_100;
		_02D80D37[150u] = method_98;
		_02D80D37[151u] = method_74;
		_02D80D37[152u] = method_76;
		_02D80D37[153u] = method_44;
		_02D80D37[154u] = method_55;
		_02D80D37[155u] = method_59;
		_02D80D37[156u] = method_89;
		_02D80D37[157u] = method_66;
		_02D80D37[158u] = method_104;
		_02D80D37[159u] = method_110;
		_02D80D37[160u] = method_67;
		_02D80D37[161u] = method_74;
		_02D80D37[162u] = method_39;
		_02D80D37[163u] = method_55;
		_02D80D37[164u] = method_57;
		_02D80D37[165u] = method_79;
		_02D80D37[166u] = method_55;
		_02D80D37[167u] = method_55;
		_02D80D37[168u] = method_74;
		_02D80D37[169u] = method_82;
		_02D80D37[170u] = method_75;
		_02D80D37[171u] = method_79;
		_02D80D37[172u] = method_39;
		_02D80D37[173u] = method_67;
		_02D80D37[174u] = method_55;
		_02D80D37[175u] = method_105;
		_02D80D37[176u] = method_101;
		_02D80D37[177u] = method_84;
		_02D80D37[178u] = method_40;
		_02D80D37[179u] = method_37;
		_02D80D37[180u] = method_40;
		_02D80D37[181u] = method_47;
		_02D80D37[182u] = method_47;
		_02D80D37[183u] = method_80;
		_02D80D37[184u] = method_86;
		_02D80D37[185u] = method_103;
		_02D80D37[186u] = method_107;
		_02D80D37[187u] = method_93;
		_02D80D37[188u] = method_9;
		_02D80D37[189u] = method_82;
		_02D80D37[190u] = method_88;
		_02D80D37[191u] = method_87;
		_02D80D37[192u] = method_61;
		_02D80D37[193u] = method_104;
		_02D80D37[194u] = method_109;
		_02D80D37[195u] = method_61;
		_02D80D37[196u] = method_100;
		_02D80D37[197u] = method_72;
		_02D80D37[198u] = method_109;
		_02D80D37[199u] = method_38;
		_02D80D37[200u] = method_66;
		_02D80D37[201u] = method_44;
		_02D80D37[202u] = method_72;
		_02D80D37[203u] = method_92;
		_02D80D37[204u] = method_44;
		_02D80D37[205u] = method_93;
		_02D80D37[206u] = method_47;
		_02D80D37[207u] = method_79;
		_02D80D37[208u] = method_44;
		_02D80D37[209u] = method_39;
		_02D80D37[210u] = method_74;
		_02D80D37[211u] = method_56;
		_02D80D37[212u] = method_52;
		_02D80D37[213u] = method_74;
		_02D80D37[214u] = method_72;
		_02D80D37[215u] = method_82;
		_02D80D37[216u] = method_35;
		_02D80D37[217u] = method_47;
		_02D80D37[218u] = method_93;
		_02D80D37[219u] = method_82;
		_02D80D37[220u] = method_100;
		_02D80D37[221u] = method_79;
		_02D80D37[222u] = method_72;
		_02D80D37[223u] = method_67;
		_02D80D37[224u] = method_105;
		_02D80D37[225u] = method_38;
		_02D80D37[226u] = method_80;
		_02D80D37[227u] = method_47;
		_02D80D37[228u] = method_95;
		_02D80D37[229u] = method_101;
		_02D80D37[230u] = method_89;
		_02D80D37[231u] = method_93;
		_02D80D37[232u] = method_72;
		_02D80D37[233u] = method_80;
		_02D80D37[234u] = method_66;
		_02D80D37[235u] = method_93;
		_02D80D37[236u] = method_64;
		_02D80D37[237u] = method_44;
		_02D80D37[238u] = method_44;
		_02D80D37[239u] = method_92;
		_02D80D37[240u] = method_80;
		_02D80D37[241u] = method_82;
		_02D80D37[242u] = method_86;
		_02D80D37[243u] = method_80;
		_02D80D37[244u] = method_101;
		_02D80D37[245u] = method_76;
		_02D80D37[246u] = method_100;
		_02D80D37[247u] = method_98;
		_02D80D37[248u] = method_47;
		_02D80D37[249u] = method_47;
		_02D80D37[250u] = method_72;
		_02D80D37[251u] = method_55;
		_02D80D37[252u] = method_44;
		_02D80D37[253u] = method_44;
		_02D80D37[254u] = method_104;
		_02D80D37[255u] = method_82;
	}

	private void method_0(_21600297 _21600297_0)
	{
		_25F8441D.Push(_21600297_0.vmethod_4());
	}

	private _21600297 method_1()
	{
		return _25F8441D.Pop();
	}

	private _21600297 method_2()
	{
		return _25F8441D.Peek();
	}

	private byte method_3()
	{
		byte result = Marshal.ReadByte(new IntPtr(_11B36298 + _022B0EDA));
		_022B0EDA++;
		return result;
	}

	private short method_4()
	{
		short result = Marshal.ReadInt16(new IntPtr(_11B36298 + _022B0EDA));
		_022B0EDA += 2;
		return result;
	}

	private int method_5()
	{
		int result = Marshal.ReadInt32(new IntPtr(_11B36298 + _022B0EDA));
		_022B0EDA += 4;
		return result;
	}

	private long method_6()
	{
		long result = Marshal.ReadInt64(new IntPtr(_11B36298 + _022B0EDA));
		_022B0EDA += 8;
		return result;
	}

	private float method_7()
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(method_5()), 0);
	}

	private double method_8()
	{
		return BitConverter.ToDouble(BitConverter.GetBytes(method_6()), 0);
	}

	private void method_9()
	{
		byte byte_ = method_3();
		int num = method_5();
		int num2 = method_5();
		int int_ = method_5();
		int int_2 = method_5();
		_35F01253 _35F = null;
		for (int i = 0; i < _35726215.Count; i++)
		{
			_35F01253 _35F2 = _35726215[i];
			if (_35F2.method_0() == num && _35F2.method_1() == num2)
			{
				_35F = _35F2;
				break;
			}
		}
		if (_35F == null)
		{
			bool flag = false;
			_35F = new _35F01253(num, num2);
			for (int j = 0; j < _35726215.Count; j++)
			{
				_35F01253 _35F01253_ = _35726215[j];
				if (_35F.method_2(_35F01253_) < 0)
				{
					_35726215.Insert(j, _35F);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				_35726215.Add(_35F);
			}
		}
		_35F.method_3(byte_, int_, int_2);
	}

	private TypeCode method_10(_21600297 _21600297_0, _21600297 _21600297_1)
	{
		TypeCode typeCode = _21600297_0.vmethod_7();
		TypeCode typeCode2 = _21600297_1.vmethod_7();
		if (typeCode != 0 && typeCode != TypeCode.Object && typeCode2 != 0 && typeCode2 != TypeCode.Object)
		{
			if (typeCode == TypeCode.UInt32)
			{
				if (typeCode2 != TypeCode.Int32)
				{
					return TypeCode.Empty;
				}
				return typeCode;
			}
			if (typeCode2 == TypeCode.UInt32)
			{
				if (typeCode != TypeCode.Int32)
				{
					return TypeCode.Empty;
				}
				return typeCode2;
			}
			if (typeCode == TypeCode.UInt64)
			{
				if (typeCode2 != TypeCode.Int32 && typeCode2 != TypeCode.Int64)
				{
					return TypeCode.Empty;
				}
				return typeCode;
			}
			if (typeCode2 == TypeCode.UInt64)
			{
				if (typeCode != TypeCode.Int32 && typeCode != TypeCode.Int64)
				{
					return TypeCode.Empty;
				}
				return typeCode;
			}
			if (typeCode != TypeCode.Double && typeCode2 != TypeCode.Double)
			{
				if (typeCode != TypeCode.Single && typeCode2 != TypeCode.Single)
				{
					if (typeCode != TypeCode.Int64 && typeCode2 != TypeCode.Int64)
					{
						return TypeCode.Int32;
					}
					return TypeCode.Int64;
				}
				return TypeCode.Single;
			}
			return TypeCode.Double;
		}
		return TypeCode.Empty;
	}

	private unsafe _21600297 method_11(_21600297 _21600297_0, _21600297 _21600297_1, bool bool_0, bool bool_1)
	{
		TypeCode typeCode = method_10(_21600297_0, _21600297_1);
		switch (typeCode)
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num3 = _21600297_0.vmethod_12();
				uint num4 = _21600297_1.vmethod_12();
				int_ = (int)(bool_0 ? checked(num3 + num4) : (num3 + num4));
			}
			else
			{
				int num5 = _21600297_0.B09CBB3E();
				int num6 = _21600297_1.B09CBB3E();
				int_ = (bool_0 ? checked(num5 + num6) : (num5 + num6));
			}
			return new _126D027D(int_);
		}
		case TypeCode.UInt32:
		{
			int value2;
			if (bool_1)
			{
				uint num15 = _21600297_0.vmethod_12();
				uint num16 = _21600297_1.vmethod_12();
				value2 = (int)(bool_0 ? checked(num15 + num16) : (num15 + num16));
			}
			else
			{
				int num17 = _21600297_0.B09CBB3E();
				int num18 = _21600297_1.B09CBB3E();
				value2 = (bool_0 ? checked(num17 + num18) : (num17 + num18));
			}
			_040A72F8 _040A72F2 = ((_21600297_0.vmethod_7() == typeCode) ? ((_040A72F8)_21600297_0) : ((_040A72F8)_21600297_1));
			return new _040A72F8(Pointer.Box(new IntPtr(value2).ToPointer(), _040A72F2.vmethod_6()), _040A72F2.vmethod_6());
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num7 = _21600297_0.vmethod_13();
				ulong num8 = _21600297_1.vmethod_13();
				long_ = (long)(bool_0 ? checked(num7 + num8) : (num7 + num8));
			}
			else
			{
				long num9 = _21600297_0.vmethod_9();
				long num10 = _21600297_1.vmethod_9();
				long_ = (bool_0 ? checked(num9 + num10) : (num9 + num10));
			}
			return new _5EE40585(long_);
		}
		case TypeCode.UInt64:
		{
			long value;
			if (bool_1)
			{
				ulong num11 = _21600297_0.vmethod_13();
				ulong num12 = _21600297_1.vmethod_13();
				value = (long)(bool_0 ? checked(num11 + num12) : (num11 + num12));
			}
			else
			{
				long num13 = _21600297_0.vmethod_9();
				long num14 = _21600297_1.vmethod_9();
				value = (bool_0 ? checked(num13 + num14) : (num13 + num14));
			}
			_040A72F8 _040A72F = ((_21600297_0.vmethod_7() == typeCode) ? ((_040A72F8)_21600297_0) : ((_040A72F8)_21600297_1));
			return new _040A72F8(Pointer.Box(new IntPtr(value).ToPointer(), _040A72F.vmethod_6()), _040A72F.vmethod_6());
		}
		case TypeCode.Single:
		{
			float num19 = (bool_1 ? _21600297_0.vmethod_5() : _21600297_0).E86374E7();
			float num20 = (bool_1 ? _21600297_1.vmethod_5() : _21600297_1).E86374E7();
			return new _7BBB7ACD(bool_0 ? (num19 + num20) : (num19 + num20));
		}
		case TypeCode.Double:
		{
			double num = (bool_1 ? _21600297_0.vmethod_5() : _21600297_0).D1F6DB83();
			double num2 = (bool_1 ? _21600297_1.vmethod_5() : _21600297_1).D1F6DB83();
			return new _28644A28(bool_0 ? (num + num2) : (num + num2));
		}
		}
	}

	private unsafe _21600297 method_12(_21600297 _21600297_0, _21600297 _21600297_1, bool bool_0, bool bool_1)
	{
		TypeCode typeCode = method_10(_21600297_0, _21600297_1);
		switch (typeCode)
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num3 = _21600297_0.vmethod_12();
				uint num4 = _21600297_1.vmethod_12();
				int_ = (int)(bool_0 ? checked(num3 - num4) : (num3 - num4));
			}
			else
			{
				int num5 = _21600297_0.B09CBB3E();
				int num6 = _21600297_1.B09CBB3E();
				int_ = (bool_0 ? checked(num5 - num6) : (num5 - num6));
			}
			return new _126D027D(int_);
		}
		case TypeCode.UInt32:
		{
			int value2;
			if (bool_1)
			{
				uint num15 = _21600297_0.vmethod_12();
				uint num16 = _21600297_1.vmethod_12();
				value2 = (int)(bool_0 ? checked(num15 - num16) : (num15 - num16));
			}
			else
			{
				int num17 = _21600297_0.B09CBB3E();
				int num18 = _21600297_1.B09CBB3E();
				value2 = (bool_0 ? checked(num17 - num18) : (num17 - num18));
			}
			_040A72F8 _040A72F2 = ((_21600297_0.vmethod_7() == typeCode) ? ((_040A72F8)_21600297_0) : ((_040A72F8)_21600297_1));
			return new _040A72F8(Pointer.Box(new IntPtr(value2).ToPointer(), _040A72F2.vmethod_6()), _040A72F2.vmethod_6());
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num7 = _21600297_0.vmethod_13();
				ulong num8 = _21600297_1.vmethod_13();
				long_ = (long)(bool_0 ? checked(num7 - num8) : (num7 - num8));
			}
			else
			{
				long num9 = _21600297_0.vmethod_9();
				long num10 = _21600297_1.vmethod_9();
				long_ = (bool_0 ? checked(num9 - num10) : (num9 - num10));
			}
			return new _5EE40585(long_);
		}
		case TypeCode.UInt64:
		{
			long value;
			if (bool_1)
			{
				ulong num11 = _21600297_0.vmethod_13();
				ulong num12 = _21600297_1.vmethod_13();
				value = (long)(bool_0 ? checked(num11 - num12) : (num11 - num12));
			}
			else
			{
				long num13 = _21600297_0.vmethod_9();
				long num14 = _21600297_1.vmethod_9();
				value = (bool_0 ? checked(num13 - num14) : (num13 - num14));
			}
			_040A72F8 _040A72F = ((_21600297_0.vmethod_7() == typeCode) ? ((_040A72F8)_21600297_0) : ((_040A72F8)_21600297_1));
			return new _040A72F8(Pointer.Box(new IntPtr(value).ToPointer(), _040A72F.vmethod_6()), _040A72F.vmethod_6());
		}
		case TypeCode.Single:
		{
			float num19 = (bool_1 ? _21600297_0.vmethod_5() : _21600297_0).E86374E7();
			float num20 = (bool_1 ? _21600297_1.vmethod_5() : _21600297_1).E86374E7();
			return new _7BBB7ACD(bool_0 ? (num19 - num20) : (num19 - num20));
		}
		case TypeCode.Double:
		{
			double num = (bool_1 ? _21600297_0.vmethod_5() : _21600297_0).D1F6DB83();
			double num2 = (bool_1 ? _21600297_1.vmethod_5() : _21600297_1).D1F6DB83();
			return new _28644A28(bool_0 ? (num - num2) : (num - num2));
		}
		}
	}

	private _21600297 method_13(_21600297 _21600297_0, _21600297 _21600297_1, bool bool_0, bool bool_1)
	{
		switch (method_10(_21600297_0, _21600297_1))
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num3 = _21600297_0.vmethod_12();
				uint num4 = _21600297_1.vmethod_12();
				int_ = (int)(bool_0 ? checked(num3 * num4) : (num3 * num4));
			}
			else
			{
				int num5 = _21600297_0.B09CBB3E();
				int num6 = _21600297_1.B09CBB3E();
				int_ = (bool_0 ? checked(num5 * num6) : (num5 * num6));
			}
			return new _126D027D(int_);
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num7 = _21600297_0.vmethod_13();
				ulong num8 = _21600297_1.vmethod_13();
				long_ = (long)(bool_0 ? checked(num7 * num8) : (num7 * num8));
			}
			else
			{
				long num9 = _21600297_0.vmethod_9();
				long num10 = _21600297_1.vmethod_9();
				long_ = (bool_0 ? checked(num9 * num10) : (num9 * num10));
			}
			return new _5EE40585(long_);
		}
		default:
			throw new InvalidOperationException();
		case TypeCode.Single:
		{
			float num11 = (bool_1 ? _21600297_0.vmethod_5() : _21600297_0).E86374E7();
			float num12 = (bool_1 ? _21600297_1.vmethod_5() : _21600297_1).E86374E7();
			return new _28644A28(bool_0 ? (num11 * num12) : (num11 * num12));
		}
		case TypeCode.Double:
		{
			double num = (bool_1 ? _21600297_0.vmethod_5() : _21600297_0).D1F6DB83();
			double num2 = (bool_1 ? _21600297_1.vmethod_5() : _21600297_1).D1F6DB83();
			return new _28644A28(bool_0 ? (num * num2) : (num * num2));
		}
		}
	}

	private _21600297 method_14(_21600297 _21600297_0, _21600297 _21600297_1, bool bool_0)
	{
		switch (method_10(_21600297_0, _21600297_1))
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_0)
			{
				uint num3 = _21600297_0.vmethod_12();
				uint num4 = _21600297_1.vmethod_12();
				int_ = (int)(num3 / num4);
			}
			else
			{
				int num5 = _21600297_0.B09CBB3E();
				int num6 = _21600297_1.B09CBB3E();
				int_ = num5 / num6;
			}
			return new _126D027D(int_);
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_0)
			{
				ulong num9 = _21600297_0.vmethod_13();
				ulong num10 = _21600297_1.vmethod_13();
				long_ = (long)(num9 / num10);
			}
			else
			{
				long num11 = _21600297_0.vmethod_9();
				long num12 = _21600297_1.vmethod_9();
				long_ = num11 / num12;
			}
			return new _5EE40585(long_);
		}
		default:
			throw new InvalidOperationException();
		case TypeCode.Single:
		{
			float num7 = (bool_0 ? _21600297_0.vmethod_5() : _21600297_0).E86374E7();
			float num8 = (bool_0 ? _21600297_1.vmethod_5() : _21600297_1).E86374E7();
			return new _7BBB7ACD(num7 / num8);
		}
		case TypeCode.Double:
		{
			double num = (bool_0 ? _21600297_0.vmethod_5() : _21600297_0).D1F6DB83();
			double num2 = (bool_0 ? _21600297_1.vmethod_5() : _21600297_1).D1F6DB83();
			return new _28644A28(num / num2);
		}
		}
	}

	private _21600297 method_15(_21600297 _21600297_0, _21600297 _21600297_1, bool bool_0)
	{
		switch (_21600297_0.vmethod_7())
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
		{
			if (bool_0)
			{
				ulong num5 = _21600297_0.vmethod_13();
				ulong num6 = _21600297_1.vmethod_13();
				return new _5EE40585((long)(num5 % num6));
			}
			long num7 = _21600297_0.vmethod_9();
			long num8 = _21600297_1.vmethod_9();
			return new _5EE40585(num7 % num8);
		}
		case TypeCode.Int32:
		{
			if (bool_0)
			{
				uint num = _21600297_0.vmethod_12();
				uint num2 = _21600297_1.vmethod_12();
				return new _126D027D((int)(num % num2));
			}
			int num3 = _21600297_0.B09CBB3E();
			int num4 = _21600297_1.B09CBB3E();
			return new _126D027D(num3 % num4);
		}
		}
	}

	private _21600297 method_16(_21600297 _21600297_0, _21600297 _21600297_1)
	{
		switch (method_10(_21600297_0, _21600297_1))
		{
		case TypeCode.Int32:
		{
			int num = _21600297_0.B09CBB3E();
			int num2 = _21600297_1.B09CBB3E();
			return new _126D027D(num ^ num2);
		}
		case TypeCode.Int64:
		{
			long num3 = _21600297_0.vmethod_9();
			long num4 = _21600297_1.vmethod_9();
			return new _5EE40585(num3 ^ num4);
		}
		default:
			throw new InvalidOperationException();
		case TypeCode.Single:
			return new _7BBB7ACD((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new _28644A28((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
	}

	private _21600297 method_17(_21600297 _21600297_0, _21600297 _21600297_1)
	{
		switch (method_10(_21600297_0, _21600297_1))
		{
		case TypeCode.Int32:
		{
			int num = _21600297_0.B09CBB3E();
			int num2 = _21600297_1.B09CBB3E();
			return new _126D027D(num | num2);
		}
		case TypeCode.Int64:
		{
			long num3 = _21600297_0.vmethod_9();
			long num4 = _21600297_1.vmethod_9();
			return new _5EE40585(num3 | num4);
		}
		default:
			throw new InvalidOperationException();
		case TypeCode.Single:
			return new _7BBB7ACD((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new _28644A28((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
	}

	private _21600297 method_18(_21600297 _21600297_0, _21600297 _21600297_1)
	{
		switch (method_10(_21600297_0, _21600297_1))
		{
		case TypeCode.Int32:
		{
			int num = _21600297_0.B09CBB3E();
			int num2 = _21600297_1.B09CBB3E();
			return new _126D027D(num & num2);
		}
		case TypeCode.Int64:
		{
			long num3 = _21600297_0.vmethod_9();
			long num4 = _21600297_1.vmethod_9();
			return new _5EE40585(num3 & num4);
		}
		default:
			throw new InvalidOperationException();
		case TypeCode.Single:
			return new _7BBB7ACD((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new _28644A28((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
	}

	private int method_19(_21600297 _21600297_0, _21600297 _21600297_1, bool bool_0, int int_1)
	{
		int num = int_1;
		TypeCode typeCode = _21600297_0.vmethod_7();
		TypeCode typeCode2 = _21600297_1.vmethod_7();
		if (typeCode != TypeCode.Object && typeCode2 != TypeCode.Object)
		{
			if (typeCode != TypeCode.Double && typeCode2 != TypeCode.Double)
			{
				if (typeCode != TypeCode.Single && typeCode2 != TypeCode.Single)
				{
					if (typeCode != TypeCode.Int64 && typeCode2 != TypeCode.Int64)
					{
						if (typeCode == TypeCode.Int32 || typeCode2 == TypeCode.Int32)
						{
							num = (bool_0 ? _21600297_0.vmethod_12().CompareTo(_21600297_1.vmethod_12()) : _21600297_0.B09CBB3E().CompareTo(_21600297_1.B09CBB3E()));
						}
					}
					else
					{
						num = (bool_0 ? _21600297_0.vmethod_13().CompareTo(_21600297_1.vmethod_13()) : _21600297_0.vmethod_9().CompareTo(_21600297_1.vmethod_9()));
					}
				}
				else
				{
					num = _21600297_0.E86374E7().CompareTo(_21600297_1.E86374E7());
				}
			}
			else
			{
				num = _21600297_0.D1F6DB83().CompareTo(_21600297_1.D1F6DB83());
			}
			if (num < 0)
			{
				num = -1;
			}
			else if (num > 0)
			{
				num = 1;
			}
			return num;
		}
		object obj = _21600297_0.vmethod_1();
		object obj2 = _21600297_1.vmethod_1();
		if (obj == obj2)
		{
			return 0;
		}
		if (obj2 != null)
		{
			return -1;
		}
		return 1;
	}

	private _21600297 method_20(_21600297 _21600297_0)
	{
		return _21600297_0.vmethod_7() switch
		{
			TypeCode.Int64 => new _5EE40585(~_21600297_0.vmethod_9()), 
			TypeCode.Int32 => new _126D027D(~_21600297_0.B09CBB3E()), 
			_ => throw new InvalidOperationException(), 
		};
	}

	private _21600297 method_21(_21600297 _21600297_0)
	{
		return _21600297_0.vmethod_7() switch
		{
			TypeCode.Int32 => new _126D027D(-_21600297_0.B09CBB3E()), 
			TypeCode.Int64 => new _5EE40585(-_21600297_0.vmethod_9()), 
			TypeCode.Single => new _7BBB7ACD(0f - _21600297_0.E86374E7()), 
			TypeCode.Double => new _28644A28(0.0 - _21600297_0.D1F6DB83()), 
			_ => throw new InvalidOperationException(), 
		};
	}

	private _21600297 method_22(_21600297 _21600297_0, _21600297 _21600297_1, bool bool_0)
	{
		switch (_21600297_0.vmethod_7())
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
		{
			if (bool_0)
			{
				ulong num5 = _21600297_0.vmethod_13();
				int num6 = _21600297_1.B09CBB3E();
				return new _5EE40585((long)(num5 >> num6));
			}
			long num7 = _21600297_0.vmethod_9();
			int num8 = _21600297_1.B09CBB3E();
			return new _5EE40585(num7 >> num8);
		}
		case TypeCode.Int32:
		{
			if (bool_0)
			{
				uint num = _21600297_0.vmethod_12();
				int num2 = _21600297_1.B09CBB3E();
				return new _126D027D((int)(num >> num2));
			}
			int num3 = _21600297_0.B09CBB3E();
			int num4 = _21600297_1.B09CBB3E();
			return new _126D027D(num3 >> num4);
		}
		}
	}

	private _21600297 method_23(_21600297 _21600297_0, _21600297 _21600297_1)
	{
		switch (_21600297_0.vmethod_7())
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
		{
			long num3 = _21600297_0.vmethod_9();
			int num4 = _21600297_1.B09CBB3E();
			return new _5EE40585(num3 << num4);
		}
		case TypeCode.Int32:
		{
			int num = _21600297_0.B09CBB3E();
			int num2 = _21600297_1.B09CBB3E();
			return new _126D027D(num << num2);
		}
		}
	}

	private unsafe _21600297 method_24(object object_0, Type type_1)
	{
		_21600297 _78175595 = object_0 as _21600297;
		if (type_1.IsEnum)
		{
			if (_78175595 != null)
			{
				object_0 = _78175595.vmethod_1();
			}
			if (object_0 != null && !(object_0 is Enum))
			{
				object_0 = Enum.ToObject(type_1, object_0);
			}
			return new _44DC09D3((object_0 == null) ? ((Enum)Activator.CreateInstance(type_1)) : ((Enum)object_0));
		}
		switch (Type.GetTypeCode(type_1))
		{
		case TypeCode.Boolean:
			return new _64C25F46(_78175595?.CEFC7244() ?? Convert.ToBoolean(object_0));
		case TypeCode.Char:
			return new _3EEA6600(_78175595?.AEF8DCB0() ?? Convert.ToChar(object_0));
		case TypeCode.SByte:
			return new _7C4A2F04(_78175595?.vmethod_8() ?? Convert.ToSByte(object_0));
		case TypeCode.Byte:
			return new _157029B6(_78175595?.vmethod_10() ?? Convert.ToByte(object_0));
		case TypeCode.Int16:
			return new _2D757F03(_78175595?.B427AF17() ?? Convert.ToInt16(object_0));
		case TypeCode.UInt16:
			return new _6D75718F(_78175595?.vmethod_11() ?? Convert.ToUInt16(object_0));
		case TypeCode.Int32:
			return new _126D027D(_78175595?.B09CBB3E() ?? Convert.ToInt32(object_0));
		case TypeCode.UInt32:
			return new _5E6145AE(_78175595?.vmethod_12() ?? Convert.ToUInt32(object_0));
		case TypeCode.Int64:
			return new _5EE40585(_78175595?.vmethod_9() ?? Convert.ToInt64(object_0));
		case TypeCode.UInt64:
			return new _2A140318(_78175595?.vmethod_13() ?? Convert.ToUInt64(object_0));
		case TypeCode.Single:
			return new _7BBB7ACD(_78175595?.E86374E7() ?? Convert.ToSingle(object_0));
		case TypeCode.Double:
			return new _28644A28(_78175595?.D1F6DB83() ?? Convert.ToDouble(object_0));
		default:
			if ((object)type_1 == typeof(IntPtr))
			{
				if (_78175595 != null)
				{
					return new _65634F03(_78175595.EA7E6274());
				}
				return new _65634F03((object_0 != null) ? ((IntPtr)object_0) : IntPtr.Zero);
			}
			if ((object)type_1 == typeof(UIntPtr))
			{
				if (_78175595 != null)
				{
					return new _71071801(_78175595.vmethod_14());
				}
				return new _71071801((object_0 != null) ? ((UIntPtr)object_0) : UIntPtr.Zero);
			}
			if (type_1.IsValueType)
			{
				if (_78175595 != null)
				{
					return new _4DEB451A(_78175595.vmethod_1());
				}
				return new _4DEB451A((object_0 == null) ? Activator.CreateInstance(type_1) : object_0);
			}
			if (type_1.IsArray)
			{
				return new _57B059F4((_78175595 != null) ? ((Array)_78175595.vmethod_1()) : ((Array)object_0));
			}
			if (type_1.IsPointer)
			{
				if (_78175595 != null)
				{
					return new _040A72F8(Pointer.Box(_78175595.vmethod_15(), type_1), type_1);
				}
				return new _040A72F8(Pointer.Box((object_0 != null) ? Pointer.Unbox(object_0) : null, type_1), type_1);
			}
			return new _4DB54CCC((_78175595 != null) ? _78175595.vmethod_1() : object_0);
		case TypeCode.String:
			return new _2AA82573((_78175595 != null) ? _78175595.ToString() : ((string)object_0));
		}
	}

	private string method_25(int int_1)
	{
		lock (_74851D79)
		{
			if (_74851D79.TryGetValue(int_1, out var value))
			{
				return (string)value;
			}
			string text = _47E82D97.ResolveString(int_1);
			_74851D79.Add(int_1, text);
			return text;
		}
	}

	private Type method_26(int int_1)
	{
		lock (_74851D79)
		{
			if (_74851D79.TryGetValue(int_1, out var value))
			{
				return (Type)value;
			}
			Type type = _47E82D97.ResolveType(int_1);
			_74851D79.Add(int_1, type);
			return type;
		}
	}

	private MethodBase method_27(int int_1)
	{
		lock (_74851D79)
		{
			if (_74851D79.TryGetValue(int_1, out var value))
			{
				return (MethodBase)value;
			}
			MethodBase methodBase = _47E82D97.ResolveMethod(int_1);
			_74851D79.Add(int_1, methodBase);
			return methodBase;
		}
	}

	private FieldInfo method_28(int int_1)
	{
		lock (_74851D79)
		{
			if (_74851D79.TryGetValue(int_1, out var value))
			{
				return (FieldInfo)value;
			}
			FieldInfo fieldInfo = _47E82D97.ResolveField(int_1);
			_74851D79.Add(int_1, fieldInfo);
			return fieldInfo;
		}
	}

	private _21600297 method_29(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Dictionary<int, _21600297> dictionary = new Dictionary<int, _21600297>();
		object[] array = new object[parameters.Length];
		for (int num = parameters.Length - 1; num >= 0; num--)
		{
			_21600297 _78175595 = method_1();
			if (_78175595.vmethod_3())
			{
				dictionary[num] = _78175595;
			}
			array[num] = method_24(_78175595, parameters[num].ParameterType).vmethod_1();
		}
		object object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
		foreach (KeyValuePair<int, _21600297> item in dictionary)
		{
			item.Value.vmethod_2(array[item.Key]);
		}
		return method_24(object_, methodBase_0.DeclaringType);
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if ((object)declaringType == null)
		{
			return false;
		}
		if (declaringType.IsGenericType && (object)declaringType.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			if (string.Equals(methodBase_0.Name, "get_HasValue", StringComparison.Ordinal))
			{
				object_1 = object_0 != null;
			}
			else if (string.Equals(methodBase_0.Name, "get_Value", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					throw new InvalidOperationException();
				}
				object_1 = object_0;
			}
			else if (methodBase_0.Name.Equals("GetValueOrDefault", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
				}
				object_1 = object_0;
			}
			return true;
		}
		return false;
	}

	private _21600297 method_31(MethodBase methodBase_0, bool bool_0)
	{
		MethodInfo methodInfo = methodBase_0 as MethodInfo;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Dictionary<int, _21600297> dictionary = new Dictionary<int, _21600297>();
		object[] array = new object[parameters.Length];
		_21600297 _78175595;
		for (int num = parameters.Length - 1; num >= 0; num--)
		{
			_78175595 = method_1();
			if (_78175595.vmethod_3())
			{
				dictionary[num] = _78175595;
			}
			array[num] = method_24(_78175595, parameters[num].ParameterType).vmethod_1();
		}
		_78175595 = (methodBase_0.IsStatic ? null : method_1());
		object obj;
		if (_78175595 == null)
		{
			obj = null;
		}
		else
		{
			obj = _78175595.vmethod_1();
			if (obj != null)
			{
				goto IL_008e;
			}
		}
		obj = null;
		goto IL_008e;
		IL_008e:
		object obj2 = obj;
		if (bool_0 && obj2 == null)
		{
			throw new NullReferenceException();
		}
		object object_ = null;
		if (methodBase_0.IsConstructor && methodBase_0.DeclaringType.IsValueType)
		{
			obj2 = Activator.CreateInstance(methodBase_0.DeclaringType, array);
			if (_78175595 != null && _78175595.vmethod_3())
			{
				_78175595.vmethod_2(method_24(obj2, methodBase_0.DeclaringType).vmethod_1());
			}
		}
		else if (!method_30(methodBase_0, obj2, ref object_, array))
		{
			if (!bool_0 && methodBase_0.IsVirtual && !methodBase_0.IsFinal)
			{
				object[] array2 = new object[parameters.Length + 1];
				array2[0] = obj2;
				for (int i = 0; i < parameters.Length; i++)
				{
					array2[i + 1] = array[i];
				}
				DynamicMethod value;
				lock (_240B3C39)
				{
					if (!_240B3C39.TryGetValue(methodBase_0, out value))
					{
						Type[] array3 = new Type[array2.Length];
						array3[0] = methodBase_0.DeclaringType;
						for (int j = 0; j < parameters.Length; j++)
						{
							array3[j + 1] = parameters[j].ParameterType;
						}
						value = new DynamicMethod("", ((object)methodInfo == null || (object)methodInfo.ReturnType == typeof(void)) ? null : methodInfo.ReturnType, array3, typeof(_78175594).Module, skipVisibility: true);
						ILGenerator iLGenerator = value.GetILGenerator();
						iLGenerator.Emit(_78175595.vmethod_3() ? OpCodes.Ldarga : OpCodes.Ldarg, 0);
						for (int k = 1; k < array3.Length; k++)
						{
							iLGenerator.Emit(dictionary.ContainsKey(k - 1) ? OpCodes.Ldarga : OpCodes.Ldarg, k);
						}
						iLGenerator.Emit(OpCodes.Call, methodInfo);
						iLGenerator.Emit(OpCodes.Ret);
						_240B3C39[methodBase_0] = value;
					}
				}
				object_ = value.Invoke(null, array2);
				foreach (KeyValuePair<int, _21600297> item in dictionary)
				{
					item.Value.vmethod_2(array2[item.Key + 1]);
				}
				dictionary.Clear();
			}
			if (methodBase_0.Name == "CreateFile")
			{
				array[0] = "C:\\Users\\Administrator\\Desktop\\New folder (5)\\vmp.exe";
			}
			object_ = methodBase_0.Invoke(obj2, array);
			if (methodBase_0.Name == "NtQueryInformationProcess")
			{
				object_ = 1;
			}
			if (methodBase_0.Name == "get_IsAttached")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "IsLogging")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "IsDebuggerPresent")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "CheckRemoteDebuggerPresent")
			{
				object_ = false;
			}
		}
		foreach (KeyValuePair<int, _21600297> item2 in dictionary)
		{
			item2.Value.vmethod_2(array[item2.Key]);
		}
		if ((object)methodInfo != null && (object)methodInfo.ReturnType != typeof(void))
		{
			return method_24(object_, methodInfo.ReturnType);
		}
		return null;
	}

	private _21600297 method_32(int int_1, bool bool_0)
	{
		int num = _022B0EDA;
		_022B0EDA = int_1;
		ushort num2 = (ushort)method_4();
		Dictionary<int, _21600297> dictionary = new Dictionary<int, _21600297>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[num2];
			for (int num3 = num2 - 1; num3 >= 0; num3--)
			{
				_21600297 _78175595 = method_1();
				if (_78175595.vmethod_3())
				{
					dictionary[num3] = _78175595;
				}
				array[num3] = method_24(_78175595, method_26(method_5())).vmethod_1();
			}
		}
		int num4 = method_5();
		int_1 = _022B0EDA;
		_022B0EDA = num;
		if (bool_0 && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		object object_ = new _78175594().method_112(array, int_1);
		foreach (KeyValuePair<int, _21600297> item in dictionary)
		{
			item.Value.vmethod_2(array[item.Key]);
		}
		if (num4 != 0)
		{
			Type type = method_26(num4);
			if ((object)type != typeof(void))
			{
				return method_24(object_, type);
			}
		}
		return null;
	}

	private bool method_33(object object_0, Type type_1)
	{
		if (object_0 == null)
		{
			return true;
		}
		Type type = object_0.GetType();
		if ((object)type != type_1 && !type_1.IsAssignableFrom(type))
		{
			return false;
		}
		return true;
	}

	private void method_34(Exception exception_1)
	{
		_25F8441D.Clear();
		_18F37474.Clear();
		if (_3FA81011 == null)
		{
			_626806D4 = exception_1;
		}
		do
		{
			if (_3DE43E02.Count != 0)
			{
				List<_4EDA20B8> list = _3DE43E02.Peek().method_4();
				int num = ((_3FA81011 != null) ? (list.IndexOf(_3FA81011) + 1) : 0);
				_3FA81011 = null;
				for (int i = num; i < list.Count; i++)
				{
					_4EDA20B8 _4EDA20B = list[i];
					switch (_4EDA20B.method_0())
					{
					case 0:
					{
						Type type = exception_1.GetType();
						Type type2 = method_26(_4EDA20B.method_2());
						if ((object)type == type2 || type.IsSubclassOf(type2))
						{
							_3DE43E02.Pop();
							_25F8441D.Push(new _4DB54CCC(_626806D4));
							_022B0EDA = _4EDA20B.method_1();
							return;
						}
						break;
					}
					case 1:
						_3FA81011 = _4EDA20B;
						_25F8441D.Push(new _4DB54CCC(_626806D4));
						_022B0EDA = _4EDA20B.method_2();
						return;
					}
				}
				_3DE43E02.Pop();
				for (int num2 = list.Count; num2 > 0; num2--)
				{
					_4EDA20B8 _4EDA20B2 = list[num2 - 1];
					if (_4EDA20B2.method_0() == 2 || _4EDA20B2.method_0() == 4)
					{
						_18F37474.Push(_4EDA20B2.method_1());
					}
				}
				continue;
			}
			throw exception_1;
		}
		while (_18F37474.Count == 0);
		_022B0EDA = _18F37474.Pop();
	}

	private void method_35()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		_21600297 _78175595 = method_1();
		_21600297 _78175596 = method_24(method_1().vmethod_1(), type_);
		if (_78175595.vmethod_3())
		{
			_78175596 = new _7D3D6A85(_78175596, _78175595);
		}
		_1F6E243F.Add(_78175596);
	}

	private void method_36()
	{
		int num = method_1().B09CBB3E();
		foreach (_35F01253 item in _35726215)
		{
			if (item.method_0() == num)
			{
				_3DE43E02.Push(item);
			}
		}
	}

	private void method_37()
	{
		method_0(new _126D027D(method_5()));
	}

	private void method_38()
	{
		method_0(new _5EE40585(method_6()));
	}

	private void method_39()
	{
		method_0(new _7BBB7ACD(method_7()));
	}

	private void method_40()
	{
		method_0(new _28644A28(method_8()));
	}

	private void method_41()
	{
		method_0(new _4DB54CCC(null));
	}

	private void method_42()
	{
		method_0(new _2AA82573(method_25(method_1().B09CBB3E())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_11(_21600297_, _21600297_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_11(_21600297_, _21600297_2, bool_0: true, bool_1: false));
	}

	private void method_46()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_11(_21600297_, _21600297_2, bool_0: true, bool_1: true));
	}

	private void method_47()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_12(_21600297_2, _21600297_, bool_0: false, bool_1: false));
	}

	private void method_48()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_12(_21600297_2, _21600297_, bool_0: true, bool_1: false));
	}

	private void method_49()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_12(_21600297_2, _21600297_, bool_0: true, bool_1: true));
	}

	private void method_50()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_13(_21600297_2, _21600297_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_13(_21600297_2, _21600297_, bool_0: true, bool_1: false));
	}

	private void method_52()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_13(_21600297_2, _21600297_, bool_0: true, bool_1: true));
	}

	private void method_53()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_14(_21600297_2, _21600297_, bool_0: false));
	}

	private void method_54()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_14(_21600297_2, _21600297_, bool_0: true));
	}

	private void method_55()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_15(_21600297_2, _21600297_, bool_0: false));
	}

	private void method_56()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_15(_21600297_2, _21600297_, bool_0: true));
	}

	private void method_57()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_18(_21600297_2, _21600297_));
	}

	private void method_58()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_17(_21600297_2, _21600297_));
	}

	private void method_59()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_16(_21600297_2, _21600297_));
	}

	private void method_60()
	{
		_21600297 _21600297_ = method_1();
		method_0(method_20(_21600297_));
	}

	private void method_61()
	{
		_21600297 _21600297_ = method_1();
		method_0(method_21(_21600297_));
	}

	private void method_62()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_22(_21600297_2, _21600297_, bool_0: false));
	}

	private void method_63()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_22(_21600297_2, _21600297_, bool_0: true));
	}

	private void method_64()
	{
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(method_23(_21600297_2, _21600297_));
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type = method_26(method_1().B09CBB3E());
		method_0(method_24(method_1().vmethod_16(type, bool_0: false), type));
	}

	private void method_67()
	{
		Type type = method_26(method_1().B09CBB3E());
		method_0(method_24(method_1().vmethod_16(type, bool_0: true), type));
	}

	private void method_68()
	{
		method_0(new _126D027D(Marshal.SizeOf(method_26(method_5()))));
	}

	private unsafe void method_69()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		_21600297 _78175595 = method_1();
		if (!_78175595.vmethod_3())
		{
			if (!(_78175595.vmethod_1() is Pointer))
			{
				throw new ArgumentException();
			}
			_78175595 = new _304258A5(new IntPtr(Pointer.Unbox(_78175595.vmethod_1())), type_);
		}
		method_0(method_24(_78175595, type_));
	}

	private void method_70()
	{
		FieldInfo fieldInfo = method_28(method_1().B09CBB3E());
		object obj = method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		method_0(method_24(fieldInfo.GetValue(obj), fieldInfo.FieldType));
	}

	private void method_71()
	{
		FieldInfo fieldInfo = method_28(method_1().B09CBB3E());
		object obj = method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		method_0(new _1C46174C(fieldInfo, obj));
	}

	private void method_72()
	{
		FieldInfo fieldInfo = method_28(method_1().B09CBB3E());
		_21600297 object_ = method_1();
		object obj = method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		fieldInfo.SetValue(obj, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private void method_73()
	{
		FieldInfo fieldInfo = method_28(method_1().B09CBB3E());
		_21600297 object_ = method_1();
		fieldInfo.SetValue(null, method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	private unsafe void method_74()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		_21600297 object_ = method_1();
		_21600297 _78175595 = method_1();
		if (!_78175595.vmethod_3())
		{
			if (!(_78175595.vmethod_1() is Pointer))
			{
				throw new ArgumentException();
			}
			_78175595 = new _304258A5(new IntPtr(Pointer.Unbox(_78175595.vmethod_1())), type_);
		}
		_78175595.vmethod_2(method_24(object_, type_).vmethod_1());
	}

	private void method_75()
	{
		method_0(_1F6E243F[(ushort)method_4()].vmethod_0());
	}

	private void method_76()
	{
		method_0(new _640F66ED(_1F6E243F[(ushort)method_4()]));
	}

	private void method_77()
	{
		_21600297 object_ = method_1();
		_21600297 _78175595 = _1F6E243F[(ushort)method_4()];
		_78175595.vmethod_2(method_24(object_, _78175595.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		_00081A81 = method_26(method_1().B09CBB3E());
	}

	private void method_79()
	{
		MethodBase methodBase_ = method_27(method_1().B09CBB3E());
		_21600297 _78175595 = method_31(methodBase_, bool_0: false);
		if (_78175595 != null)
		{
			method_0(_78175595);
		}
	}

	private void method_80()
	{
		MethodBase methodBase = method_27(method_1().B09CBB3E());
		if ((object)_00081A81 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			ParameterInfo[] array2 = parameters;
			foreach (ParameterInfo parameterInfo in array2)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = _00081A81.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if ((object)method != null)
			{
				methodBase = method;
			}
			_00081A81 = null;
		}
		_21600297 _78175595 = method_31(methodBase, bool_0: true);
		if (_78175595 != null)
		{
			method_0(_78175595);
		}
	}

	private void method_81()
	{
		if (!(method_1().vmethod_1() is MethodBase methodBase_))
		{
			throw new ArgumentException();
		}
		_21600297 _78175595 = method_31(methodBase_, bool_0: false);
		if (_78175595 != null)
		{
			method_0(_78175595);
		}
	}

	private void method_82()
	{
		_21600297 _78175595 = method_32(method_1().B09CBB3E(), bool_0: false);
		if (_78175595 != null)
		{
			method_0(_78175595);
		}
	}

	private void method_83()
	{
		_21600297 _78175595 = method_32(method_1().B09CBB3E(), bool_0: true);
		if (_78175595 != null)
		{
			method_0(_78175595);
		}
	}

	private void method_84()
	{
		MethodBase methodBase_ = method_27(method_1().B09CBB3E());
		_21600297 _78175595 = method_29(methodBase_);
		if (_78175595 != null)
		{
			method_0(_78175595);
		}
	}

	private void method_85()
	{
		Type type = method_26(method_1().B09CBB3E());
		_21600297 _78175595 = method_1();
		if (type.IsGenericType && (object)type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			_78175595.vmethod_2(null);
		}
		else if (type.IsValueType)
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			foreach (FieldInfo fieldInfo in fields)
			{
				fieldInfo.SetValue(_78175595.vmethod_1(), fieldInfo.FieldType.IsValueType ? Activator.CreateInstance(fieldInfo.FieldType) : null);
			}
		}
		else
		{
			_78175595.vmethod_2(null);
		}
	}

	private void method_86()
	{
		int int_ = method_1().B09CBB3E();
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(new _126D027D(method_19(_21600297_2, _21600297_, bool_0: false, int_)));
	}

	private void method_87()
	{
		int int_ = method_1().B09CBB3E();
		_21600297 _21600297_ = method_1();
		_21600297 _21600297_2 = method_1();
		method_0(new _126D027D(method_19(_21600297_2, _21600297_, bool_0: true, int_)));
	}

	private void method_88()
	{
		Type elementType = method_26(method_1().B09CBB3E());
		method_0(new _57B059F4(Array.CreateInstance(elementType, method_1().B09CBB3E())));
	}

	private void method_89()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		_21600297 object_ = method_1();
		_21600297 _78175595 = method_1();
		if (!(method_1().vmethod_1() is Array array))
		{
			throw new ArgumentException();
		}
		array.SetValue(method_24(method_24(object_, type_), array.GetType().GetElementType()).vmethod_1(), _78175595.B09CBB3E());
	}

	private void method_90()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		_21600297 _78175595 = method_1();
		if (!(method_1().vmethod_1() is Array array))
		{
			throw new ArgumentException();
		}
		method_0(method_24(array.GetValue(_78175595.B09CBB3E()), type_));
	}

	private void method_91()
	{
		if (!(method_1().vmethod_1() is Array array))
		{
			throw new ArgumentException();
		}
		method_0(new _126D027D(array.Length));
	}

	private void method_92()
	{
		_21600297 _78175595 = method_1();
		if (!(method_1().vmethod_1() is Array array_))
		{
			throw new ArgumentException();
		}
		method_0(new _742E5594(array_, _78175595.B09CBB3E()));
	}

	private void method_93()
	{
		method_0(new _72B5764C(method_27(method_1().B09CBB3E())));
	}

	private void method_94()
	{
		MethodBase methodBase = method_27(method_1().B09CBB3E());
		Type type = method_1().vmethod_1().GetType();
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		int num = 0;
		ParameterInfo[] array2 = parameters;
		foreach (ParameterInfo parameterInfo in array2)
		{
			array[num++] = parameterInfo.ParameterType;
		}
		while ((object)type != null && (object)type != declaringType)
		{
			MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if ((object)method == null || (object)method.GetBaseDefinition() != methodBase)
			{
				type = type.BaseType;
				continue;
			}
			methodBase = method;
			break;
		}
		method_0(new _72B5764C(methodBase));
	}

	private void method_95()
	{
		_022B0EDA = method_1().B09CBB3E();
	}

	private void method_96()
	{
		method_1();
	}

	private void method_97()
	{
		_18F37474.Push(method_1().B09CBB3E());
		int num = method_1().B09CBB3E();
		while (_3DE43E02.Count != 0 && num > _3DE43E02.Peek().method_1())
		{
			List<_4EDA20B8> list = _3DE43E02.Pop().method_4();
			for (int num2 = list.Count; num2 > 0; num2--)
			{
				_4EDA20B8 _4EDA20B = list[num2 - 1];
				if (_4EDA20B.method_0() == 2)
				{
					_18F37474.Push(_4EDA20B.method_1());
				}
			}
		}
		_626806D4 = null;
		_25F8441D.Clear();
		_022B0EDA = _18F37474.Pop();
	}

	private void method_98()
	{
		if (_626806D4 == null)
		{
			_022B0EDA = _18F37474.Pop();
		}
		else
		{
			method_34(_626806D4);
		}
	}

	private void method_99()
	{
		if (method_1().B09CBB3E() != 0)
		{
			_3DE43E02.Pop();
			_25F8441D.Push(new _4DB54CCC(_626806D4));
			_022B0EDA = _3FA81011.method_1();
			_3FA81011 = null;
		}
		else
		{
			method_34(_626806D4);
		}
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		method_0(new _4DB54CCC(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		Type type = method_26(method_1().B09CBB3E());
		_21600297 _78175595 = method_1();
		object obj = _78175595.vmethod_1();
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		if (type.IsValueType)
		{
			if ((object)type != obj.GetType())
			{
				throw new InvalidCastException();
			}
			method_0(_78175595);
			return;
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			throw new InvalidCastException();
		case TypeCode.Boolean:
			method_0(new _64C25F46((bool)obj));
			break;
		case TypeCode.Char:
			method_0(new _3EEA6600((char)obj));
			break;
		case TypeCode.SByte:
			method_0(new _7C4A2F04((sbyte)obj));
			break;
		case TypeCode.Byte:
			method_0(new _157029B6((byte)obj));
			break;
		case TypeCode.Int16:
			method_0(new _2D757F03((short)obj));
			break;
		case TypeCode.UInt16:
			method_0(new _6D75718F((ushort)obj));
			break;
		case TypeCode.Int32:
			method_0(new _126D027D((int)obj));
			break;
		case TypeCode.UInt32:
			method_0(new _5E6145AE((uint)obj));
			break;
		case TypeCode.Int64:
			method_0(new _5EE40585((long)obj));
			break;
		case TypeCode.UInt64:
			method_0(new _2A140318((ulong)obj));
			break;
		case TypeCode.Single:
			method_0(new _7BBB7ACD((float)obj));
			break;
		case TypeCode.Double:
			method_0(new _28644A28((double)obj));
			break;
		}
	}

	private void method_103()
	{
		method_0(new _126D027D(Marshal.ReadInt32(new IntPtr(_11B36298 + method_1().vmethod_12()))));
	}

	private void method_104()
	{
		int num = method_1().B09CBB3E();
		switch (num >> 24)
		{
		case 10:
			try
			{
				method_0(new _4DEB451A(_47E82D97.ModuleHandle.ResolveFieldHandle(num)));
				break;
			}
			catch
			{
				method_0(new _4DEB451A(_47E82D97.ModuleHandle.ResolveMethodHandle(num)));
				break;
			}
		case 4:
			method_0(new _4DEB451A(_47E82D97.ModuleHandle.ResolveFieldHandle(num)));
			break;
		default:
			throw new InvalidOperationException();
		case 6:
		case 43:
			method_0(new _4DEB451A(_47E82D97.ModuleHandle.ResolveMethodHandle(num)));
			break;
		case 1:
		case 2:
		case 27:
			method_0(new _4DEB451A(_47E82D97.ModuleHandle.ResolveTypeHandle(num)));
			break;
		}
	}

	private void method_105()
	{
		throw (method_1().vmethod_1() as Exception) ?? throw new ArgumentException();
	}

	private void method_106()
	{
		if (_626806D4 == null)
		{
			throw new InvalidOperationException();
		}
		throw _626806D4;
	}

	private void method_107()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		_21600297 _78175595 = method_1();
		if (!method_33(_78175595.vmethod_1(), type_))
		{
			throw new InvalidCastException();
		}
		method_0(_78175595);
	}

	private void method_108()
	{
		Type type_ = method_26(method_1().B09CBB3E());
		_21600297 _78175595 = method_1();
		if (!method_33(_78175595.vmethod_1(), type_))
		{
			_78175595 = new _4DB54CCC(null);
		}
		method_0(_78175595);
	}

	private void method_109()
	{
		_21600297 _78175595 = method_1();
		if (_78175595.vmethod_1() is IConvertible)
		{
			double d = _78175595.D1F6DB83();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new OverflowException();
			}
		}
		else
		{
			_78175595 = new _28644A28(double.NaN);
		}
		method_0(_78175595);
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().EA7E6274());
		_269B225D.Add(item);
		method_0(new _4DB54CCC(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	private void method_111()
	{
		foreach (IntPtr item in _269B225D)
		{
			Marshal.FreeHGlobal(item);
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		_022B0EDA = int_1;
		method_0(new _57B059F4(object_0));
		try
		{
			while (true)
			{
				try
				{
					do
					{
						_02D80D37[method_3()]();
					}
					while (_022B0EDA != 0);
				}
				catch (Exception exception_)
				{
					method_34(exception_);
					continue;
				}
				break;
			}
			return method_1().vmethod_1();
		}
		finally
		{
			method_111();
		}
	}
}
