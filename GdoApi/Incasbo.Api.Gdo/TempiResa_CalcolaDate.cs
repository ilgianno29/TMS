using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class TempiResa_CalcolaDate : AppAbstractApi
{
	protected string _Cliente;

	protected string _PCSPartenza;

	protected string _ZonaSpedizione;

	protected string _TipoSpedizione;

	protected string _TipoServizio;

	protected string _TipoMerce;

	protected DateTime? _DataRiferimento;

	protected DateTime _DataConsegnaDa;

	protected DateTime _DataConsegnaA;

	protected DateTime _DataUscitaMagazzino;

	public TempiResa_CalcolaDate(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Cliente = "";
		_PCSPartenza = "*ALL";
		_ZonaSpedizione = "*ALL";
		_TipoSpedizione = "*ALL";
		_TipoServizio = "*ALL";
		_TipoMerce = "*ALL";
		_DataConsegnaDa = DateAndTime.Now.Date;
		_DataConsegnaA = DateAndTime.Now.Date;
		_DataUscitaMagazzino = DateAndTime.Now.Date;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Cliente = ((AppAbstractApi)this).ParametersIn["Cliente"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("PCSPartenza"))
			{
				_PCSPartenza = ((AppAbstractApi)this).ParametersIn["PCSPartenza"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ZonaSpedizione"))
			{
				_ZonaSpedizione = ((AppAbstractApi)this).ParametersIn["ZonaSpedizione"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoSpedizione"))
			{
				_TipoSpedizione = ((AppAbstractApi)this).ParametersIn["TipoSpedizione"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoServizio"))
			{
				_TipoServizio = ((AppAbstractApi)this).ParametersIn["TipoServizio"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoMerce"))
			{
				_TipoMerce = ((AppAbstractApi)this).ParametersIn["TipoMerce"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataRiferimento"))
			{
				_DataRiferimento = (DateTime?)((AppAbstractApi)this).ParametersIn["DataRiferimento"];
			}
			if (!_DataRiferimento.HasValue)
			{
				_DataRiferimento = DateAndTime.Now;
			}
			((AppAbstractApi)this).ParametersOut.Add("DataConsegnaDa", _DataConsegnaDa);
			((AppAbstractApi)this).ParametersOut.Add("DataConsegnaA", _DataConsegnaA);
			((AppAbstractApi)this).ParametersOut.Add("DataUscitaMagazzino", _DataUscitaMagazzino);
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			int GiorniDiConsegnaDa = default(int);
			int GiorniDiConsegnaA = default(int);
			int GiorniDiUscitaMagazzino = default(int);
			val = TempiResa_CalcolaGiorni_Invoker.Instance.RunProc(this._ApiContext, _Cliente, _TipoServizio, _TipoSpedizione, _TipoMerce, _PCSPartenza, _ZonaSpedizione, _DataRiferimento, ref GiorniDiConsegnaDa, ref GiorniDiConsegnaA, ref GiorniDiUscitaMagazzino, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				DateTime DataCalcolata = default(DateTime);
				val = Calendario_CalcolaDate_Invoker.Instance.RunProc(this._ApiContext, _DataRiferimento.Value, GiorniDiConsegnaDa, ref DataCalcolata, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					_DataConsegnaDa = DataCalcolata;
					DateTime DataCalcolata2 = default(DateTime);
					val = Calendario_CalcolaDate_Invoker.Instance.RunProc(this._ApiContext, _DataRiferimento.Value, GiorniDiConsegnaA, ref DataCalcolata2, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						_DataConsegnaA = DataCalcolata2;
						DateTime DataCalcolata3 = default(DateTime);
						val = Calendario_CalcolaDate_Invoker.Instance.RunProc(this._ApiContext, _DataRiferimento.Value, GiorniDiUscitaMagazzino, ref DataCalcolata3, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							_DataUscitaMagazzino = DataCalcolata3;
							((AppAbstractApi)this).ParametersOut["DataConsegnaDa"] = _DataConsegnaDa;
							((AppAbstractApi)this).ParametersOut["DataConsegnaA"] = _DataConsegnaA;
							((AppAbstractApi)this).ParametersOut["DataUscitaMagazzino"] = _DataUscitaMagazzino;
							val2 = (FXRETURN)0;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}
}
