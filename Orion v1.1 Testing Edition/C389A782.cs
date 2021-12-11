using System.Collections;
using System.Windows.Forms;

public class C389A782 : IComparer
{
	private int TokenFacts_002D8285678;

	private SortOrder DateRangeEventArgs_002D6307478;

	public C389A782(int TextDataFormat_002D775777, SortOrder XmlDataImplementation_002D1818087)
	{
		//IL_0020: Expected O, but got I4
		//IL_002b: Expected O, but got I4
		//IL_003b: Expected I4, but got O
		//IL_0043: Expected I4, but got O
		object obj = (new object[3] { this, TextDataFormat_002D775777, XmlDataImplementation_002D1818087 })[1];
		int tokenFacts_002D = (int)null;
		object obj2 = ((object[])obj)[2];
		SortOrder dateRangeEventArgs_002D = (SortOrder)null;
		_ = ((object[])obj2)[0];
		object obj3 = null;
		obj3._002Ector();
		((C389A782)obj3).TokenFacts_002D8285678 = tokenFacts_002D;
		((C389A782)obj3).DateRangeEventArgs_002D6307478 = dateRangeEventArgs_002D;
	}

	public int Compare(object GridEntryCollection_002D8464208, object BackgroundType_002D1506534)
	{
		object[] object_ = new object[3] { this, GridEntryCollection_002D8464208, BackgroundType_002D1506534 };
		return (int)new _78175594().method_112(object_, 3631962);
	}
}
