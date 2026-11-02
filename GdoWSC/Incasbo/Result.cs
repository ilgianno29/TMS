using System.Runtime.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

[DataContract]
public class Result
{
	[DataMember]
	public bool Good { get; set; }

	[DataMember]
	public string Reason { get; set; }

	public Result(string BadReason)
	{
		bool good = true;
		Good = good;
		string reason = "";
		Reason = reason;
		if (Operators.CompareString(BadReason, "", false) == 0)
		{
			Good = true;
			return;
		}
		Good = false;
		Reason = BadReason;
	}

	public Result()
	{
		bool good = true;
		Good = good;
		string reason = "";
		Reason = reason;
	}
}
