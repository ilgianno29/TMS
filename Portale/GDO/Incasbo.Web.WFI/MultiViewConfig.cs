using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class MultiViewConfig
{
	private MultiView _MultiView;

	private string[] _Tabella;

	private string[][] _keys;

	private string[] _Where;

	private int[] _ParentView;

	private int _ActiveView;

	private bool _ActiveViewChanged;

	public DataTable[] DataTable;

	public DataTable[] DataTableBeforeImage;

	public FunctionArguments[] objFunctionArguments;

	private bool _Inizializzato;

	private string[] _lblDataAccessModeId;

	private List<MultiViewForeignKey>[] _ForeignKey;

	private DataRow[] _ActiveDataRowArray;

	public List<MultiViewForeignKey>[] ForeignKey => _ForeignKey;

	public MultiView MultiView
	{
		get
		{
			return _MultiView;
		}
		set
		{
			_MultiView = value;
			checked
			{
				if (_MultiView != null && !_Inizializzato)
				{
					_Tabella = new string[((ControlCollection)MultiView.Views).Count - 1 + 1];
					_Where = new string[((ControlCollection)MultiView.Views).Count - 1 + 1];
					_ParentView = new int[((ControlCollection)MultiView.Views).Count - 1 + 1];
					_ParentView[0] = -1;
					DataTable = new DataTable[((ControlCollection)MultiView.Views).Count - 1 + 1];
					DataTableBeforeImage = new DataTable[((ControlCollection)MultiView.Views).Count - 1 + 1];
					objFunctionArguments = new FunctionArguments[((ControlCollection)MultiView.Views).Count - 1 + 1];
					_lblDataAccessModeId = new string[((ControlCollection)MultiView.Views).Count - 1 + 1];
					_ForeignKey = new List<MultiViewForeignKey>[((ControlCollection)MultiView.Views).Count - 1 + 1];
					int num = ((ControlCollection)MultiView.Views).Count - 1;
					for (int i = 0; i <= num; i++)
					{
						_ForeignKey[i] = new List<MultiViewForeignKey>();
					}
					_ActiveDataRowArray = new DataRow[((ControlCollection)MultiView.Views).Count - 1 + 1];
					_Inizializzato = true;
				}
			}
		}
	}

	public string[] Tabella
	{
		get
		{
			return _Tabella;
		}
		set
		{
			_Tabella = value;
		}
	}

	public string ActiveViewTabella => _Tabella[ActiveView];

	public string[] Where
	{
		get
		{
			return _Where;
		}
		set
		{
			_Where = value;
		}
	}

	public string ActiveViewWhere => _Where[ActiveView];

	public int ActiveView
	{
		get
		{
			return _ActiveView;
		}
		set
		{
			_ActiveDataRowArray[_ActiveView] = ActiveDataRow;
			_ActiveView = value;
			_MultiView.ActiveViewIndex = value;
			_ActiveViewChanged = true;
		}
	}

	public int[] ParentView
	{
		get
		{
			return _ParentView;
		}
		set
		{
			_ParentView = value;
		}
	}

	public bool ActiveViewChanged
	{
		get
		{
			bool activeViewChanged = _ActiveViewChanged;
			_ActiveViewChanged = false;
			return activeViewChanged;
		}
	}

// Proprieta' VB con parametro, convertita in metodi
	public int get_GetIndexViewByID(string sId)
	{
		checked
		{
			int num = ((ControlCollection)_MultiView.Views).Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(((Control)_MultiView.Views[i]).ID.ToUpper(), sId.ToUpper(), false) == 0)
				{
					return i;
				}
			}
			return 0;
		}
	}


	public string[] lblDataAccessModeId => _lblDataAccessModeId;

	public DataRow ActiveDataRow { get; set; }

	public DataRow[] ActiveDataRowArray => _ActiveDataRowArray;

	public DataTable ActiveDataTable => DataTable[ActiveView];

	public string[][] Keys
	{
		get
		{
			return _keys;
		}
		set
		{
			_keys = value;
		}
	}

	public MultiViewConfig()
	{
		_ActiveViewChanged = false;
		_Inizializzato = false;
	}

	public void AddForeignKey(int iViewIndex, string _FieldName1, string _FieldName2, string _ViewParentId)
	{
		_ForeignKey[iViewIndex].Add(new MultiViewForeignKey(_FieldName1, _FieldName2, _ViewParentId, this.get_GetIndexViewByID(_ViewParentId)));
		string text = _FieldName1 + "=<%<%ViewId%>.<%FieldName%>%>";
		text = Strings.Replace(text, "<%ViewId%>", _ViewParentId, 1, -1, (CompareMethod)0);
		text = Strings.Replace(text, "<%FieldName%>", _FieldName2, 1, -1, (CompareMethod)0);
		Where[iViewIndex] = text;
		_ParentView[iViewIndex] = this.get_GetIndexViewByID(_ViewParentId);
	}

	public void AddForeignKey(int iViewIndex, string _FieldName1, string _FieldName2, int _ViewParentIndex)
	{
		AddForeignKey(iViewIndex, _FieldName1, _FieldName2, ((Control)MultiView.Views[_ViewParentIndex]).ID);
	}
}
