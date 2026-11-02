#define DEBUG
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class sqlSelect
{
	public enum OrderBySortOrder
	{
		Ascending,
		Descending,
		NotSet
	}

	private Collection<FieldNameAlias> SqlFieldsList;

	private string sSqlFrom;

	private int iSqlTop;

	private Dictionary<string, WhereCondition> _SqlWhere;

	private Dictionary<string, FieldNameOrderBy> SqlOrderBy;

	private eServerType ServerType;

	public Dictionary<string, WhereCondition> SqlWhere => _SqlWhere;

	public string SqlFromClause
	{
		get
		{
			return sSqlFrom;
		}
		set
		{
			sSqlFrom = value;
		}
	}

	public int SqlTopClause
	{
		get
		{
			return iSqlTop;
		}
		set
		{
			iSqlTop = value;
		}
	}

	public string SqlSelectClause
	{
		get
		{
			string text = "";
			int count = SqlFieldsList.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					text += SqlFieldsList[i - 1].ToString();
					if (i < SqlFieldsList.Count)
					{
						text += ", ";
					}
				}
				return text;
			}
		}
	}

	public string SqlOrderByClause
	{
		get
		{
			string text = "";
			int count = SqlOrderBy.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					text += SqlOrderBy.ToList()[i - 1].Value.ToString();
					if (i < SqlOrderBy.Count)
					{
						text += ", ";
					}
				}
				return text;
			}
		}
	}

	public string SqlWhereClause
	{
		get
		{
			string text = "";
			int count = _SqlWhere.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					text = text + " (" + _SqlWhere.ToList()[i - 1].Value.SqlExpression + ") ";
					if (i < _SqlWhere.Count)
					{
						text += " AND ";
					}
				}
				return text;
			}
		}
	}

	public string WhereClauseReadableExpression => this.get_WhereClauseReadableExpression(", ");

// Proprieta' VB con parametro, convertita in metodi
	public string get_WhereClauseReadableExpression(string Separator)
	{
		string text = "";
		int count = _SqlWhere.Count;
		checked
		{
			for (int i = 1; i <= count; i++)
			{
				if (_SqlWhere.ToList()[i - 1].Value.UserVisible)
				{
					text = text + " (" + _SqlWhere.ToList()[i - 1].Value.ReadableExpression + ")";
					if (i < _SqlWhere.Count)
					{
						text += Separator;
					}
				}
			}
			return text;
		}
	}


	public Dictionary<string, WhereCondition> WhereConditions => _SqlWhere;

	public sqlSelect(eServerType vServerType)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		sSqlFrom = "";
		iSqlTop = 0;
		SqlFieldsList = new Collection<FieldNameAlias>();
		SqlOrderBy = new Dictionary<string, FieldNameOrderBy>();
		_SqlWhere = new Dictionary<string, WhereCondition>();
		ServerType = vServerType;
	}

	public void AddSelectField(ref string vsFieldName, string vsAliasName)
	{
		if (Operators.CompareString(vsFieldName, "", false) != 0)
		{
			if (Operators.CompareString(vsAliasName, "", false) == 0)
			{
				vsAliasName = vsFieldName;
			}
			SqlFieldsList.Add(new FieldNameAlias(vsFieldName, vsAliasName));
		}
	}

	public void AddSelectField(ref string vsFieldName)
	{
		AddSelectField(ref vsFieldName, vsFieldName);
	}

	public void ClearSelectField()
	{
		SqlFieldsList.Clear();
	}

	public void AddOrderByField(string vsFieldName, OrderBySortOrder veSortOrder)
	{
		SqlOrderBy.Add(vsFieldName, new FieldNameOrderBy(vsFieldName, veSortOrder));
	}

	public bool ExistsOrderByField(string vsFieldName)
	{
		return SqlOrderBy.ContainsKey(vsFieldName);
	}

	public FieldNameOrderBy ItemOrderByField(string vsFieldName)
	{
		if (ExistsOrderByField(vsFieldName))
		{
			return SqlOrderBy[vsFieldName];
		}
		return null;
	}

	public void ClearOrderByField()
	{
		SqlOrderBy.Clear();
	}

	public bool ExistsWhereCondition(string vsWhereCondition)
	{
		return _SqlWhere.ContainsKey(vsWhereCondition);
	}

	public void AddWhere(string vsWhere, string vsReadableExpression, bool vbCanBeDeleted)
	{
		AddWhere(vsWhere, vsReadableExpression, vbCanBeDeleted, vbUserVisible: true);
	}

	public void AddWhere(string vsWhere, string vsReadableExpression, bool vbCanBeDeleted, bool vbUserVisible)
	{
		if (Operators.CompareString(vsWhere, "", false) != 0 && !ExistsWhereCondition(vsWhere))
		{
			_SqlWhere.Add(vsWhere, new WhereCondition(vsWhere, vsReadableExpression, vbCanBeDeleted, vbUserVisible));
		}
	}

	public void AddWhere(string vsWhere, string vsReadableExpression)
	{
		AddWhere(vsWhere, vsReadableExpression, vbCanBeDeleted: false);
	}

	public void AddWhere(string vsWhere)
	{
		AddWhere(vsWhere, null, vbCanBeDeleted: false);
	}

	public void ClearWhere()
	{
		_SqlWhere.Clear();
	}

	public void ClearUserVisibleWhere()
	{
		int num = default(int);
		while (num < _SqlWhere.Count)
		{
			if (_SqlWhere.ToList()[num].Value.UserVisible)
			{
				_SqlWhere.Remove(_SqlWhere.ToList()[num].Value.SqlExpression);
			}
			else
			{
				num = checked(num + 1);
			}
		}
	}

	public void ClearDeletable()
	{
		int num = default(int);
		while (num < _SqlWhere.Count)
		{
			Debug.Print(_SqlWhere.ToList()[num].Value.SqlExpression.ToString() + " " + _SqlWhere.ToList()[num].Value.CanBeDeleted);
			if (_SqlWhere.ToList()[num].Value.CanBeDeleted)
			{
				_SqlWhere.Remove(_SqlWhere.ToList()[num].Value.SqlExpression);
			}
			else
			{
				num = checked(num + 1);
			}
		}
	}

	public override string ToString()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		string text = "";
		text = (((int)ServerType == 1) ? (text + "SELECT " + SqlSelectClause) : ((iSqlTop <= 0) ? (text + "SELECT " + SqlSelectClause) : (text + "SELECT TOP " + Conversions.ToString(iSqlTop) + " " + SqlSelectClause)));
		if (Operators.CompareString(sSqlFrom, "", false) != 0)
		{
			text = text + " FROM " + sSqlFrom;
		}
		if (Operators.CompareString(SqlWhereClause, "", false) != 0)
		{
			text = text + " WHERE " + SqlWhereClause;
		}
		if (Operators.CompareString(SqlOrderByClause, "", false) != 0)
		{
			text = text + " ORDER BY " + SqlOrderByClause;
		}
		if ((int)ServerType == 1 && iSqlTop > 0)
		{
			text = "SELECT * FROM (" + text + ") T_T WHERE ROWNUM <= " + Conversions.ToString(iSqlTop) + " ";
		}
		return text;
	}

	public sqlSelect Copy()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		sqlSelect sqlSelect2 = new sqlSelect(ServerType);
		string text = "";
		checked
		{
			int num = SqlFieldsList.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string vsFieldName = SqlFieldsList[i].FieldName;
				sqlSelect2.AddSelectField(ref vsFieldName, SqlFieldsList[i].AliasName);
			}
			sqlSelect2.SqlFromClause = SqlFromClause;
			sqlSelect2.SqlTopClause = SqlTopClause;
			List<KeyValuePair<string, WhereCondition>> list = _SqlWhere.ToList();
			int num2 = _SqlWhere.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				sqlSelect2.AddWhere(list[i].Value.SqlExpression, list[i].Value.ReadableExpression, list[i].Value.CanBeDeleted);
			}
			list = null;
			int num3 = SqlOrderBy.Count - 1;
			for (int i = 0; i <= num3; i++)
			{
				sqlSelect2.AddOrderByField(SqlOrderBy.ToList()[i].Value.FieldName, SqlOrderBy.ToList()[i].Value.SortOrder);
			}
			return sqlSelect2;
		}
	}
}
