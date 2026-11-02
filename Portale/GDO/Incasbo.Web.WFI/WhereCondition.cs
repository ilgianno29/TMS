using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WhereCondition
{
	private string _SqlExpression;

	private string _ReadableExpression;

	private bool _CanBeDeleted;

	private bool _UserVisible;

	public string ReadableExpression
	{
		get
		{
			if (Operators.CompareString(_ReadableExpression, "", false) == 0)
			{
				return _SqlExpression;
			}
			return _ReadableExpression;
		}
	}

	public string SqlExpression => _SqlExpression;

	public bool CanBeDeleted => _CanBeDeleted;

	public bool UserVisible => _UserVisible;

	public WhereCondition(string vsSqlExpression)
		: this(vsSqlExpression, "", vbCanBeDeleted: false, vbUserVisible: true)
	{
	}

	public WhereCondition(string vsSqlExpression, string vsReadableExpression)
		: this(vsSqlExpression, vsReadableExpression, vbCanBeDeleted: false, vbUserVisible: true)
	{
	}

	public WhereCondition(string vsSqlExpression, string vsReadableExpression, bool vbCanBeDeleted)
		: this(vsSqlExpression, vsReadableExpression, vbCanBeDeleted, vbUserVisible: true)
	{
	}

	public WhereCondition(string vsSqlExpression, string vsReadableExpression, bool vbCanBeDeleted, bool vbUserVisible)
	{
		_SqlExpression = "";
		_ReadableExpression = "";
		_UserVisible = true;
		_SqlExpression = vsSqlExpression;
		_ReadableExpression = vsReadableExpression;
		_CanBeDeleted = vbCanBeDeleted;
		_UserVisible = vbUserVisible;
	}
}
