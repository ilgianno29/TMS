using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using Incasbo.Api.App;
using Incasbo.Model.Map;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class DelsyTrackGeneraViaggi : AppAbstractApi
{
	protected List<Viaggio> _Viaggi;

	protected string _Filtro;

	protected bool _SoloEffettivi;

	protected TipologiaMappa _Tipologia;

	public DelsyTrackGeneraViaggi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Viaggi = null;
		_Filtro = "";
		_SoloEffettivi = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["Filtro"].ToString(), "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Obbligatorio passare il Filtro");
			}
			else
			{
				_Filtro = ((AppAbstractApi)this).ParametersIn["Filtro"].ToString();
				if (!((AppAbstractApi)this).ParametersIn.ContainsKey("SoloEffettivi"))
				{
					rsmess = this.TranslateMessage("XXX", "Obbligatorio passare il valore se viasualizzare solo viaggi effettivi");
				}
				else
				{
					_SoloEffettivi = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["SoloEffettivi"]);
					if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["Tipologia"].ToString(), "", false) == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Obbligatorio passare la Tipologia (Mappa o Certificazione");
					}
					else
					{
						_Tipologia = (TipologiaMappa)((AppAbstractApi)this).ParametersIn["Tipologia"];
						base._ParametersOut.Add("Viaggi", null);
						val2 = (FXRETURN)0;
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Invalid comparison between Unknown and I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between Unknown and I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		List<Incasbo.Model.Map.Viaggio> list = new List<Incasbo.Model.Map.Viaggio>();
		string text = "";
		DataTable rObjDataTable = null;
		Incasbo.Model.Map.Viaggio Viaggio = null;
		ColorGenerator colorGenerator = new ColorGenerator(40, 20);
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_Tipologia == TipologiaMappa.Certificazione)
			{
				text = "SELECT * FROM VW_MAPPA_VIAGGI_CERT WHERE 1=1 ";
				goto IL_007c;
			}
			if (_Tipologia == TipologiaMappa.MonitorViaggi)
			{
				text = "SELECT * FROM VW_TRK_MAPPA_VIAGGI WHERE 1=1 ";
				goto IL_007c;
			}
			rsmess = this.TranslateMessage("XXX", "Tipologia non riconosciuta");
			goto end_IL_0023;
			IL_007c:
			if (Operators.CompareString(_Filtro, "", false) != 0)
			{
				text = text + " AND " + _Filtro;
			}
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count > 0)
				{
					foreach (DataRow row in rObjDataTable.Rows)
					{
						val = DelsyTrackRilevaPuntiViaggio_Invoker.Instance.RunProc(this._ApiContext, row["IDVIAGGIO"].ToString(), _SoloEffettivi, ref Viaggio, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							if (Information.IsNothing((object)Viaggio))
							{
								continue;
							}
							val = SetColorViaggioSelezionato(ref Viaggio, ref rsmess);
							if ((int)val <= 0)
							{
								Viaggio.Colore = colorGenerator.GetColor();
								Viaggio.Mezzo = row["MEZZO"].ToString();
								list.Add(Viaggio);
								continue;
							}
							val2 = val;
						}
						goto end_IL_0023;
					}
				}
				base._ParametersOut["Viaggi"] = list;
				val2 = (FXRETURN)0;
			}
			end_IL_0023:;
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

	private FXRETURN SetColorViaggioSelezionato(ref Incasbo.Model.Map.Viaggio v, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string Valore = "";
		Color color = default(Color);
		FXRETURN result;
		try
		{
			rsMess = "";
			val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(this._ApiContext, "VIAGGIO.COLORI", "Linee", ref Valore, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				v.ColoreLineeSelezionato = HexToColor(Valore);
				val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(this._ApiContext, "VIAGGIO.COLORI", "Tour", ref Valore, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					v.ColoreTourSelezionato = HexToColor(Valore);
					val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(this._ApiContext, "VIAGGIO.COLORI", "LineePia", ref Valore, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						v.ColoreLineeSelezionatoPianificato = HexToColor(Valore);
						val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(this._ApiContext, "VIAGGIO.COLORI", "TourPia", ref Valore, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							v.ColoreTourSelezionatoPianificato = HexToColor(Valore);
							val = (FXRETURN)0;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	private Color HexToColor(string hexColor)
	{
		if (hexColor.IndexOf('#') != -1)
		{
			hexColor = hexColor.Replace("#", "");
		}
		int red = 0;
		int green = 0;
		int blue = 0;
		if (hexColor.Length == 6)
		{
			red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
			green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
			blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
		}
		else if (hexColor.Length == 3)
		{
			red = int.Parse(hexColor[0].ToString() + hexColor[0], NumberStyles.AllowHexSpecifier);
			green = int.Parse(hexColor[1].ToString() + hexColor[1], NumberStyles.AllowHexSpecifier);
			blue = int.Parse(hexColor[2].ToString() + hexColor[2], NumberStyles.AllowHexSpecifier);
		}
		return Color.FromArgb(red, green, blue);
	}
}
