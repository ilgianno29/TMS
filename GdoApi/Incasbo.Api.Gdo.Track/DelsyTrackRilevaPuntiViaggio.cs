using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Model.Map;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class DelsyTrackRilevaPuntiViaggio : AppAbstractApi
{
	protected string _IdViaggio;

	protected Viaggio _Viaggio;

	protected string _IdToFind;

	protected bool _SoloEffettivo;

	public DelsyTrackRilevaPuntiViaggio(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_Viaggio = null;
		_IdToFind = "";
		_SoloEffettivo = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_SoloEffettivo = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["SoloEffettivo"]);
			base._ParametersOut.Add("Viaggio", null);
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
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Invalid comparison between Unknown and I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Invalid comparison between Unknown and I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Invalid comparison between Unknown and I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Invalid comparison between Unknown and I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		Incasbo.Model.Map.Viaggio viaggio = null;
		object objRes = null;
		string text = "";
		DataTable rObjDataTable = null;
		DataTable rObjDataTable2 = null;
		PuntoSuMappa puntoSuMappa = null;
		List<PuntoSuMappa> list = new List<PuntoSuMappa>();
		List<PuntoSuMappa> list2 = new List<PuntoSuMappa>();
		string icona = "";
		string IconaSelezionata = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		bool visibile = true;
		bool flag = false;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			bool flag2 = false;
			text = "SELECT * FROM VW_TRK_MAPPA_PUNTIVIAGGIO ";
			text = text + "WHERE IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
			bool flag3 = false;
			text += "ORDER BY Sequenza";
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
						EsitoOrdine esitoPunto = DelsyTrackFunction.GetEsitoPunto(row["ESITO"].ToString());
						Tipologia tipologiaPunto = DelsyTrackFunction.GetTipologiaPunto(row["TIPOLOGIA"].ToString());
						val = DelsyTrackFunction.GetIconePuntoSuMappa(this._ApiContext, tipologiaPunto, ref icona, ref IconaSelezionata, ref rsmess);
						if ((int)val <= 0)
						{
							text2 = row["TOOLTIP"].ToString();
							text3 = row["Descrizione"].ToString();
							text4 = row["FIXTOOLTIP"].ToString();
							text5 = row["COLOREFIXTOOLTIP"].ToString();
							if ((Operators.CompareString(row["LONGITUDINE"].ToString(), "", false) != 0) & (Operators.CompareString(row["LONGITUDINE"].ToString(), "", false) != 0))
							{
								puntoSuMappa = new PuntoSuMappa(modGeneral.EnsureIsDecimal(RuntimeHelpers.GetObjectValue(row["LONGITUDINE"])), modGeneral.EnsureIsDecimal(RuntimeHelpers.GetObjectValue(row["LATITUDINE"])), _IdViaggio + "_" + row["ID"].ToString(), tipologiaPunto, icona, IconaSelezionata, text2, text3, text4, text5, esitoPunto);
								list.Add(puntoSuMappa);
							}
							continue;
						}
						val2 = val;
						goto end_IL_0058;
					}
				}
				text = "SELECT IDVIAGGIOOBC FROM VIAGGI WHERE IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(objRes)))
					{
						flag = true;
					}
					if (!(!flag & !_SoloEffettivo))
					{
						goto IL_04ee;
					}
					text = "SELECT * FROM VW_MAPPA_PUNTIVIAGGIO_PIA ";
					text = text + "WHERE IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
					text += "ORDER BY SEQUENZA";
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable2, ref rsmess);
					if ((int)val <= 0)
					{
						if (rObjDataTable2.Rows.Count > 0)
						{
							foreach (DataRow row2 in rObjDataTable2.Rows)
							{
								Tipologia tipologiaPunto = DelsyTrackFunction.GetTipologiaPunto(row2["TIPOLOGIA"].ToString());
								val = DelsyTrackFunction.GetIconePuntoSuMappa(this._ApiContext, tipologiaPunto, ref icona, ref IconaSelezionata, ref rsmess);
								if ((int)val <= 0)
								{
									text2 = row2["TOOLTIP"].ToString();
									text4 = row2["FIXTOOLTIP"].ToString();
									text5 = row2["COLOREFIXTOOLTIP"].ToString();
									if ((Operators.CompareString(row2["LONGITUDINE"].ToString(), "", false) != 0) & (Operators.CompareString(row2["LONGITUDINE"].ToString(), "", false) != 0))
									{
										puntoSuMappa = new PuntoSuMappa(modGeneral.EnsureIsDecimal(RuntimeHelpers.GetObjectValue(row2["LONGITUDINE"])), modGeneral.EnsureIsDecimal(RuntimeHelpers.GetObjectValue(row2["LATITUDINE"])), "P" + _IdViaggio + "_" + row2["ID"].ToString(), tipologiaPunto, icona, IconaSelezionata, text2, text2, text4, text5);
										list2.Add(puntoSuMappa);
									}
									continue;
								}
								val2 = val;
								goto end_IL_0058;
							}
						}
						goto IL_04ee;
					}
					val2 = val;
				}
			}
			goto end_IL_0058;
			IL_04ee:
			if (_SoloEffettivo)
			{
				visibile = false;
			}
			viaggio = new Incasbo.Model.Map.Viaggio(_IdViaggio, list, list2, visibile, flag);
			base._ParametersOut["Viaggio"] = viaggio;
			val2 = (FXRETURN)0;
			end_IL_0058:;
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

	private bool FindPuntoCaricoScarico(PuntoSuMappa p)
	{
		if (Operators.CompareString(p.ID, _IdToFind, false) == 0)
		{
			return true;
		}
		return false;
	}
}
