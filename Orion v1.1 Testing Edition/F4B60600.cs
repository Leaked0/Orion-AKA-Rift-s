using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Orion;

internal static class F4B60600
{
	public static readonly _8F92C2D2 ParameterDirection_002D7551389 = new _8F92C2D2("Orion.ini");

	[STAThread]
	private static void LabelImageIndexer_002D9858116()
	{
		Console.Title = "Orion Loader";
		string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
		if (!File.Exists(pathRoot + "Windows\\System32\\drivers\\etc\\hosts."))
		{
			File.Create(pathRoot + "Windows\\System32\\drivers\\etc\\hosts.");
		}
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12;
		_2FE4B071.DpiHelper_002D9390971("OrionTesting", "355177", "kN9GWZ9Mo9lHE3KQV0otCTXu2j9S5RSAJ5r", "1.0");
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		_3C48D007.Name_002D6302427("Checking for illegal processes...");
		F4B60600.TrackBar_002D4771558();
		_3C48D007.Name_002D6302427("Sending log...");
		F4B60600.TrackBar_002D4771558();
		if (ParameterDirection_002D7551389.InternalDataCollectionBase_002D6806912("EULA"))
		{
			Application.Run(new Main());
			return;
		}
		_3C48D007.Name_002D6302427("EULA not accepted, launching form...");
		Application.Run(new EULA());
	}

	private static void TrackBar_002D4771558()
	{
		new _78175594().method_112(null, 3472846);
	}

	public static void TrackBar_002D4771558()
	{
		new _78175594().method_112(null, 3419161);
	}
}
