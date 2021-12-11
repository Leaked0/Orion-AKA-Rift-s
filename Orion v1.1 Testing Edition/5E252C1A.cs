using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class _5E252C1A
{
	public class _6ECD0452
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _47E0538A
		{
			public static readonly _47E0538A _34467B0E = new _47E0538A();

			public static RemoteCertificateValidationCallback _397C6312;

			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}
		}

		[CompilerGenerated]
		private string _47B24069;

		[CompilerGenerated]
		private string _2BCE0135;

		public string _31AB67F9
		{
			[CompilerGenerated]
			get
			{
				return _47B24069;
			}
			[CompilerGenerated]
			private set
			{
				_47B24069 = value;
			}
		}

		public string _20EE09A0
		{
			[CompilerGenerated]
			get
			{
				return _2BCE0135;
			}
			[CompilerGenerated]
			private set
			{
				_2BCE0135 = value;
			}
		}

		protected bool method_0(byte[] byte_0)
		{
			int num = BitConverter.ToInt32(byte_0, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(byte_0, 28);
			_31AB67F9 = Encoding.UTF8.GetString(byte_0, index, num);
			if (_31AB67F9[_31AB67F9.Length - 1] != '/')
			{
				_31AB67F9 += "/";
			}
			return true;
		}

		protected void method_1()
		{
			_31AB67F9 = Convert.ToBase64String(Encoding.UTF8.GetBytes(_31AB67F9));
		}

		protected void method_2(string string_2, string string_3)
		{
			method_3(string_2, bool_0: false);
			method_3(string_3, bool_0: true);
		}

		private void method_3(string string_2, bool bool_0)
		{
			if (bool_0)
			{
				StringBuilder stringBuilder = new StringBuilder(_31AB67F9);
				foreach (char c in string_2)
				{
					switch (c)
					{
					default:
						stringBuilder.Append(c);
						break;
					case '=':
						stringBuilder.Append("%3D");
						break;
					case '/':
						stringBuilder.Append("%2F");
						break;
					case '+':
						stringBuilder.Append("%2B");
						break;
					}
				}
				_31AB67F9 = stringBuilder.ToString();
			}
			else
			{
				_31AB67F9 += string_2;
			}
		}

		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}
	}

	public class _5F4A0FBB : _6ECD0452
	{
		[CompilerGenerated]
		private string _16EB5234;
	}

	public class _78E16F26 : _6ECD0452
	{
	}

	private readonly byte[] _221A5740;

	private byte[] _615E2D85;

	private readonly object _13FF206E;

	private _3DE34EE3 _19757996;

	private long _450676EE;

	private readonly int _5D794A3E;

	private int _232F794D;

	private uint _58124C96;

	public _5E252C1A(long long_1)
	{
		object[] object_ = new object[2] { this, long_1 };
		new _78175594().method_112(object_, 3592370);
	}

	public _5E252C1A(byte[] byte_2)
	{
		object obj = (new object[2] { this, byte_2 })[0];
		object obj2 = null;
		_ = ((object[])obj)[1];
		Array array = null;
		((_5E252C1A)obj2)._13FF206E = new object();
		((_5E252C1A)obj2)._19757996 = _3DE34EE3.Invalid;
		obj2._002Ector();
		((_5E252C1A)obj2)._221A5740 = (byte[])array;
	}
}
