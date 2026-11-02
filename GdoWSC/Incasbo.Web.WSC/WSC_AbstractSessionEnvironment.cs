namespace Incasbo.Web.WSC;

public abstract class WSC_AbstractSessionEnvironment
{
	protected string _User;

	protected string _Group;

	protected string _Organizzazione;

	protected string _Password;

	protected string _UserDescription;

	public virtual string User
	{
		get
		{
			return _User;
		}
		set
		{
			_User = value;
		}
	}

	public virtual string Group
	{
		get
		{
			return _Group;
		}
		set
		{
			_Group = value;
		}
	}

	public virtual string Organizzazione
	{
		get
		{
			return _Organizzazione;
		}
		set
		{
			_Organizzazione = value;
		}
	}

	public virtual string UserDescription
	{
		get
		{
			return _UserDescription;
		}
		set
		{
			_UserDescription = value;
		}
	}

	public virtual string Password
	{
		get
		{
			return _Password;
		}
		set
		{
			_Password = value;
		}
	}

	protected WSC_AbstractSessionEnvironment()
	{
		_User = "";
		_Group = "";
		_Organizzazione = "";
		_Password = "";
		_UserDescription = "";
	}
}
