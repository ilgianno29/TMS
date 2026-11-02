using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class PCS_InserisciModifica : GdoAbstractApi
{
	protected PCS _PCS;

	protected string _InsMod;

	protected DataTable _BeforeImage;

	public PCS_InserisciModifica(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_InsMod = "I";
		_BeforeImage = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_PCS = (PCS)this._ParametersIn["PCS"];
			this._ParametersOut.Add("PCS", _PCS);
			val = CheckRiferimentiPrimari(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = VerificaAzione(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = ImpostaDefault(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = CheckRiferimentiSecondari(ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							if (Operators.CompareString(_InsMod, "I", false) == 0)
							{
								_PCS.UteAgg = this._User;
								_PCS.UteIns = this._User;
								_PCS.DatAgg = null;
								_PCS.DatIns = null;
							}
							else
							{
								_PCS.UteAgg = this._User;
								_PCS.UteIns = null;
								_PCS.DatAgg = DateAndTime.Now;
								_PCS.DatIns = null;
							}
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Invalid comparison between Unknown and I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Invalid comparison between Unknown and I4
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string sQuery = "";
			if (Operators.CompareString(_InsMod, "I", false) == 0)
			{
				if (Operators.CompareString(_PCS.Codice, "", false) != 0)
				{
					goto IL_0090;
				}
				long rlReturnValue = default(long);
				val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.PCS", ref rlReturnValue, ref rsmess);
				if ((int)val <= 0)
				{
					_PCS.Codice = rlReturnValue.ToString();
					goto IL_0090;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_PCS.CodiceEsterno, "", false) != 0)
				{
					goto IL_049a;
				}
				val = CreateQueryUPDATE(_PCS, ref sQuery, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					bool flag = false;
					bool flag2 = false;
					if (((_PCS.Localita != null) & (_PCS.Indirizzo != null) & (_PCS.Cap != null) & (_PCS.Nazione != null)) && ((Operators.CompareString(_PCS.Localita, "", false) != 0) & (Operators.CompareString(_PCS.Indirizzo, "", false) != 0) & (Operators.CompareString(_PCS.Cap, "", false) != 0) & (Operators.CompareString(_PCS.Nazione, "", false) != 0)))
					{
						if (Operators.CompareString(_BeforeImage.Rows[0]["Localita"].ToString().ToUpper(), _PCS.Localita.ToUpper(), false) != 0)
						{
							flag = true;
						}
						if (Operators.CompareString(_BeforeImage.Rows[0]["Indirizzo"].ToString().ToUpper(), _PCS.Indirizzo.ToUpper(), false) != 0)
						{
							flag = true;
						}
						if (Operators.CompareString(_BeforeImage.Rows[0]["Cap"].ToString().ToUpper(), _PCS.Cap.ToUpper(), false) != 0)
						{
							flag = true;
						}
						if (Operators.CompareString(_BeforeImage.Rows[0]["Nazione"].ToString().ToUpper(), _PCS.Nazione.ToUpper(), false) != 0)
						{
							flag = true;
						}
					}
					if (((_PCS.Latitudine != null) & (_PCS.Longitudine != null)) && ((Operators.CompareString(_PCS.Latitudine, "", false) != 0) & (Operators.CompareString(_PCS.Longitudine, "", false) != 0)))
					{
						if (Operators.CompareString(_BeforeImage.Rows[0]["Latitudine"].ToString(), _PCS.Latitudine, false) != 0)
						{
							flag = true;
							flag2 = true;
						}
						if (Operators.CompareString(_BeforeImage.Rows[0]["Longitudine"].ToString(), _PCS.Longitudine, false) != 0)
						{
							flag = true;
							flag2 = true;
						}
					}
					if (flag)
					{
						string text = "DELETE FROM PCS_Geocodifica WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Codice);
						sQuery = sQuery + text + ";";
					}
					if (!flag2)
					{
						goto IL_049a;
					}
					string sQuery2 = "";
					val = InsertGeocodifica(ref sQuery2, ref rsmess);
					if ((int)val <= 0)
					{
						sQuery += sQuery2;
						goto IL_049a;
					}
					val2 = val;
				}
			}
			goto end_IL_0005;
			IL_0090:
			val = CreateQueryINSERT(_PCS, ref sQuery, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string sQuery3 = "";
				val = DeterminaZone(ref sQuery3, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					sQuery = sQuery + sQuery3 + ";";
					sQuery3 = "";
					val = InsertGeocodifica(ref sQuery3, ref rsmess);
					if ((int)val <= 0)
					{
						sQuery += sQuery3;
						goto IL_049a;
					}
					val2 = val;
				}
			}
			goto end_IL_0005;
			IL_049a:
			string sQuery4 = "";
			val = CreaQueryPCS_Acquisiti(ref sQuery4, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(sQuery4, "", false) != 0)
				{
					sQuery = sQuery + sQuery4 + ";";
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(sQuery, ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
			end_IL_0005:;
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

	protected FXRETURN CheckRiferimentiPrimari(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Invalid comparison between Unknown and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_PCS.Codice, "", false) != 0 || !((Operators.CompareString(_PCS.CodiceEsterno, "", false) != 0) & (Operators.CompareString(_PCS.Cliente, "", false) != 0)))
			{
				goto IL_0120;
			}
			string text = "SELECT CodiceInterno FROM PCS_Acquisiti WHERE Cliente=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Cliente) + " ";
			text = text + "AND CodiceEsterno=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.CodiceEsterno);
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val <= 0)
			{
				if (rObjDataTable.Rows.Count > 0)
				{
					_PCS.Codice = rObjDataTable.Rows[0]["CodiceInterno"].ToString();
				}
				goto IL_0120;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0120:
			val2 = (FXRETURN)0;
			end_IL_0005:;
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

	protected FXRETURN CheckRiferimentiSecondari(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Invalid comparison between Unknown and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Invalid comparison between Unknown and I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Invalid comparison between Unknown and I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Invalid comparison between Unknown and I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object objRes = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_PCS.PuntoRitiro1 == null || Operators.CompareString(_PCS.PuntoRitiro1, "", false) == 0)
			{
				goto IL_00b8;
			}
			text = "SELECT COUNT(*) FROM PCS WHERE PuntoDiDeposito='S' AND CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.PuntoRitiro1);
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
			if ((int)val <= 0)
			{
				if (Conversions.ToInteger(objRes) == 0)
				{
					_PCS.PuntoRitiro1 = null;
				}
				goto IL_00b8;
			}
			val2 = val;
			goto end_IL_000e;
			IL_028c:
			if (_PCS.GruppoTariffa == null || Operators.CompareString(_PCS.GruppoTariffa, "", false) == 0)
			{
				goto IL_0328;
			}
			text = "SELECT COUNT(*) FROM PCS_GruppiTariffari WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.GruppoTariffa);
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
			if ((int)val <= 0)
			{
				if (Conversions.ToInteger(objRes) == 0)
				{
					_PCS.GruppoTariffa = null;
				}
				goto IL_0328;
			}
			val2 = val;
			goto end_IL_000e;
			IL_01f0:
			if (_PCS.CodiceDestinatario == null || Operators.CompareString(_PCS.CodiceDestinatario, "", false) == 0)
			{
				goto IL_028c;
			}
			text = "SELECT COUNT(*) FROM PCS WHERE Destinatario='S' AND CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.CodiceDestinatario);
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
			if ((int)val <= 0)
			{
				if (Conversions.ToInteger(objRes) == 0)
				{
					_PCS.CodiceDestinatario = null;
				}
				goto IL_028c;
			}
			val2 = val;
			goto end_IL_000e;
			IL_0154:
			if (_PCS.PuntoRitiro3 == null || Operators.CompareString(_PCS.PuntoRitiro3, "", false) == 0)
			{
				goto IL_01f0;
			}
			text = "SELECT COUNT(*) FROM PCS WHERE PuntoDiDeposito='S' AND CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.PuntoRitiro3);
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
			if ((int)val <= 0)
			{
				if (Conversions.ToInteger(objRes) == 0)
				{
					_PCS.PuntoRitiro3 = null;
				}
				goto IL_01f0;
			}
			val2 = val;
			goto end_IL_000e;
			IL_03d2:
			val2 = (FXRETURN)0;
			goto end_IL_000e;
			IL_00b8:
			if (_PCS.PuntoRitiro2 == null || Operators.CompareString(_PCS.PuntoRitiro2, "", false) == 0)
			{
				goto IL_0154;
			}
			text = "SELECT COUNT(*) FROM PCS WHERE PuntoDiDeposito='S' AND CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.PuntoRitiro2);
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
			if ((int)val <= 0)
			{
				if (Conversions.ToInteger(objRes) == 0)
				{
					_PCS.PuntoRitiro2 = null;
				}
				goto IL_0154;
			}
			val2 = val;
			goto end_IL_000e;
			IL_0328:
			if (_PCS.CodiceTrasportatore == null || Operators.CompareString(_PCS.CodiceTrasportatore, "", false) == 0)
			{
				goto IL_03d2;
			}
			_PCS.IsFiliale = "N";
			text = "SELECT COUNT(*) FROM Trasportatori WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.CodiceTrasportatore);
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
			if ((int)val <= 0)
			{
				if (Conversions.ToInteger(objRes) == 0)
				{
					_PCS.CodiceTrasportatore = null;
				}
				goto IL_03d2;
			}
			val2 = val;
			end_IL_000e:;
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

	protected FXRETURN DeterminaZone(ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text2 = base.ApplicationDefault.TipoMerceDefault();
			string ZonaSpedizione = "";
			string ZonaTariffaAttiva = "";
			string ZonaTariffaPassiva = "";
			val = Localita_DeterminaZone_Invoker.Instance.RunProc(this._ApiContext, text2, _PCS.Localita, _PCS.Provincia, _PCS.Cap, _PCS.Nazione, ref ZonaSpedizione, ref ZonaTariffaAttiva, ref ZonaTariffaPassiva, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "INSERT INTO PCS_ZONE(PCS, TipoMerce, ZonaSpedizione, ZonaTariffaAttiva, ZonaTariffaPassiva) VALUES (";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Codice) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ZonaSpedizione) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ZonaTariffaAttiva) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ZonaTariffaPassiva) + ")";
				if (Operators.CompareString(text2, "*ALL", false) == 0)
				{
					goto IL_023f;
				}
				ZonaSpedizione = "";
				ZonaTariffaAttiva = "";
				ZonaTariffaPassiva = "";
				val = Localita_DeterminaZone_Invoker.Instance.RunProc(this._ApiContext, "*ALL", _PCS.Localita, _PCS.Provincia, _PCS.Cap, _PCS.Nazione, ref ZonaSpedizione, ref ZonaTariffaAttiva, ref ZonaTariffaPassiva, ref rsmess);
				if ((int)val <= 0)
				{
					text += "; INSERT INTO PCS_ZONE(PCS, TipoMerce, ZonaSpedizione, ZonaTariffaAttiva, ZonaTariffaPassiva) VALUES (";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Codice) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString("*ALL") + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ZonaSpedizione) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ZonaTariffaAttiva) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ZonaTariffaPassiva) + ") ";
					goto IL_023f;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_023f:
			sQuery = text;
			val2 = (FXRETURN)0;
			end_IL_000b:;
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

	protected FXRETURN CreaQueryPCS_Acquisiti(ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "";
			if ((Operators.CompareString(_PCS.CodiceEsterno, "", false) != 0) & (Operators.CompareString(_PCS.Cliente, "", false) != 0))
			{
				if (Operators.CompareString(_InsMod, "I", false) == 0)
				{
					text = "INSERT INTO PCS_ACQUISITI (CLIENTE, CODICEESTERNO, CODICEINTERNO, RAGIONESOCIALE, INDIRIZZO, ";
					text += "CAP, LOCALITA, PROVINCIA, NAZIONE, UTEINS, UTEAGG) VALUES (";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Cliente) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.CodiceEsterno) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Codice) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.RagioneSociale) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Indirizzo) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Cap) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Localita) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Provincia) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Nazione) + ", ";
					text = text + this.DbConn.SQLFormatString(this._User) + ", ";
					text = text + this.DbConn.SQLFormatString(this._User) + ") ";
				}
				else
				{
					text = "UPDATE PCS_ACQUISITI ";
					text = text + "SET RAGIONESOCIALE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.RagioneSociale) + ", ";
					text = text + "INDIRIZZO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Indirizzo) + ", ";
					text = text + "CAP=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Cap) + ", ";
					text = text + "LOCALITA=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Localita) + ", ";
					text = text + "PROVINCIA=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Provincia) + ", ";
					text = text + "NAZIONE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Nazione) + ", ";
					text = text + "UTEAGG=" + this.DbConn.SQLFormatString(this._User) + ", ";
					text += "DATAGG=GETDATE() ";
					text = text + "WHERE CLIENTE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Cliente) + " ";
					text = text + "AND CODICEESTERNO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.CodiceEsterno) + " ";
				}
			}
			sQuery = text;
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

	protected FXRETURN VerificaAzione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_PCS.Codice, "", false) == 0)
			{
				_InsMod = "I";
				goto IL_00c5;
			}
			string vsSQLClause = "SELECT PCS.*, G.Latitudine, G.Longitudine FROM PCS LEFT JOIN PCS_Geocodifica G ON G.Codice = PCS.Codice WHERE PCS.CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Codice);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _BeforeImage, ref rsmess);
			if ((int)val <= 0)
			{
				if (_BeforeImage.Rows.Count > 0)
				{
					_InsMod = "M";
				}
				else
				{
					_InsMod = "I";
					_BeforeImage = null;
				}
				goto IL_00c5;
			}
			val2 = val;
			goto end_IL_0005;
			IL_00c5:
			val2 = (FXRETURN)0;
			end_IL_0005:;
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

	protected FXRETURN ImpostaDefault(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_InsMod, "I", false) == 0)
			{
				if (_PCS.PuntoDiCarico == null)
				{
					_PCS.PuntoDiCarico = "N";
				}
				if (_PCS.PuntoDiDeposito == null)
				{
					_PCS.PuntoDiDeposito = "N";
				}
				if (_PCS.PuntoDiDestino == null)
				{
					_PCS.PuntoDiDestino = "N";
				}
				if (_PCS.PuntoDiParcoVeicolare == null)
				{
					_PCS.PuntoDiParcoVeicolare = "N";
				}
				if ((Operators.CompareString(_PCS.PuntoDiCarico, "N", false) == 0) & (Operators.CompareString(_PCS.PuntoDiDeposito, "N", false) == 0) & (Operators.CompareString(_PCS.PuntoDiDestino, "N", false) == 0) & (Operators.CompareString(_PCS.PuntoDiParcoVeicolare, "N", false) == 0))
				{
					_PCS.PuntoDiDestino = "S";
				}
			}
			else
			{
				string text = "";
				DataRow dataRow = _BeforeImage.Rows[0];
				text = ((_PCS.PuntoDiCarico == null) ? (text + dataRow["PuntoDiCarico"].ToString()) : (text + _PCS.PuntoDiCarico.ToString()));
				text = ((_PCS.PuntoDiDeposito == null) ? (text + dataRow["PuntoDiDeposito"].ToString()) : (text + _PCS.PuntoDiDeposito.ToString()));
				text = ((_PCS.PuntoDiDestino == null) ? (text + dataRow["PuntoDiDestino"].ToString()) : (text + _PCS.PuntoDiDestino.ToString()));
				text = ((_PCS.PuntoDiParcoVeicolare == null) ? (text + dataRow["PuntoDiParcoVeicolare"].ToString()) : (text + _PCS.PuntoDiParcoVeicolare.ToString()));
				dataRow = null;
				if (!text.Contains("S"))
				{
					_PCS.PuntoDiDestino = "S";
				}
			}
			if ((_PCS.Nazione == null) & (Operators.CompareString(_InsMod, "I", false) == 0))
			{
				_PCS.Nazione = base.ApplicationDefault.NazioneDefault();
			}
			if ((Operators.CompareString(_PCS.Nazione, "", false) == 0) & (Operators.CompareString(_InsMod, "I", false) == 0))
			{
				_PCS.Nazione = base.ApplicationDefault.NazioneDefault();
			}
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

	protected FXRETURN CreateQueryINSERT(object obj, ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Invalid comparison between Unknown and I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Invalid comparison between Unknown and I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "INSERT INTO %TABLENAME% (";
			PropertyInfo[] publicProperties = IncasReflection.GetPublicProperties(RuntimeHelpers.GetObjectValue(obj));
			PropertyInfo[] array = publicProperties;
			foreach (PropertyInfo propertyInfo in array)
			{
				Dictionary<string, object> customListAttributesForProperties = IncasReflection.GetCustomListAttributesForProperties(propertyInfo);
				bool flag = true;
				if (customListAttributesForProperties.ContainsKey("Bind"))
				{
					flag = Conversions.ToBoolean(customListAttributesForProperties["Bind"]);
				}
				if (flag)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
					if (objectValue != null)
					{
						sQuery = sQuery + propertyInfo.Name + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1));
			sQuery += ") VALUES (";
			PropertyInfo[] array2 = publicProperties;
			foreach (PropertyInfo propertyInfo2 in array2)
			{
				Dictionary<string, object> customListAttributesForProperties2 = IncasReflection.GetCustomListAttributesForProperties(propertyInfo2);
				bool flag2 = true;
				if (customListAttributesForProperties2.ContainsKey("Bind"))
				{
					flag2 = Conversions.ToBoolean(customListAttributesForProperties2["Bind"]);
				}
				if (!flag2)
				{
					continue;
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(propertyInfo2.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
				if (objectValue2 != null)
				{
					eTipoDati val3 = modGeneral.DataTypeToBaseType(objectValue2.GetType());
					if ((int)val3 == 0)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue2.ToString()) + ",";
					}
					else if ((int)val3 == 3)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(objectValue2)) + ",";
					}
					else if ((int)val3 == 2 || (int)val3 == 1)
					{
						string obj2 = sQuery;
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						decimal pNumero = Conversions.ToDecimal(objectValue2);
						sQuery = obj2 + dbConn.SQLFormatNumber(ref pNumero) + ",";
					}
					else
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue2.ToString()) + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1)) + ")";
			Dictionary<string, object> customListAttributes = IncasReflection.GetCustomListAttributes(RuntimeHelpers.GetObjectValue(obj));
			if (customListAttributes.ContainsKey("TableName"))
			{
				sQuery = sQuery.Replace("%TABLENAME%", customListAttributes["TableName"].ToString());
			}
			else
			{
				sQuery = sQuery.Replace("%TABLENAME%", obj.GetType().Name);
			}
			sQuery += ";";
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

	protected FXRETURN CreateQueryUPDATE(object obj, ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Invalid comparison between Unknown and I4
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			PropertyInfo[] publicProperties = IncasReflection.GetPublicProperties(RuntimeHelpers.GetObjectValue(obj));
			Dictionary<string, object> customListAttributes = IncasReflection.GetCustomListAttributes(RuntimeHelpers.GetObjectValue(obj));
			StringCollection stringCollection = new StringCollection();
			if (customListAttributes.ContainsKey("Key"))
			{
				string[] array = (string[])customListAttributes["Key"];
				foreach (string text in array)
				{
					stringCollection.Add(text.ToUpper());
				}
			}
			sQuery = "UPDATE %TABLENAME% SET ";
			PropertyInfo[] array2 = publicProperties;
			foreach (PropertyInfo propertyInfo in array2)
			{
				Dictionary<string, object> customListAttributesForProperties = IncasReflection.GetCustomListAttributesForProperties(propertyInfo);
				bool flag = true;
				if (customListAttributesForProperties.ContainsKey("Bind"))
				{
					flag = Conversions.ToBoolean(customListAttributesForProperties["Bind"]);
				}
				if (!flag)
				{
					continue;
				}
				object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
				if (objectValue != null && !stringCollection.Contains(propertyInfo.Name.ToUpper()))
				{
					sQuery = sQuery + propertyInfo.Name + "=";
					eTipoDati val3 = modGeneral.DataTypeToBaseType(objectValue.GetType());
					if ((int)val3 == 0)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue.ToString()) + ",";
					}
					else if ((int)val3 == 3)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(objectValue)) + ",";
					}
					else if ((int)val3 == 2 || (int)val3 == 1)
					{
						string obj2 = sQuery;
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						decimal pNumero = Conversions.ToDecimal(objectValue);
						sQuery = obj2 + dbConn.SQLFormatNumber(ref pNumero) + ",";
					}
					else
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue.ToString()) + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1)) + " ";
			sQuery += "WHERE 1=1 ";
			if (customListAttributes.ContainsKey("TableName"))
			{
				sQuery = sQuery.Replace("%TABLENAME%", customListAttributes["TableName"].ToString());
			}
			else
			{
				sQuery = sQuery.Replace("%TABLENAME%", obj.GetType().Name);
			}
			StringEnumerator enumerator = stringCollection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				sQuery = sQuery + " AND " + current + "=" + ((AppBaseClass)this).DbConn.SQLFormatString(IncasReflection.GetPropertyValue(RuntimeHelpers.GetObjectValue(obj), current).ToString()) + " ";
			}
			sQuery += ";";
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

	protected FXRETURN InsertGeocodifica(ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			if ((Operators.CompareString(_PCS.Latitudine, "", false) != 0) & (Operators.CompareString(_PCS.Longitudine, "", false) != 0))
			{
				text = "INSERT INTO PCS_Geocodifica (Codice,TipoGeocodifica,Latitudine,Longitudine,FormatoCoordinate,UteAgg,UteIns) VALUES (";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Codice) + ", ";
				text += "'IMP', ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Latitudine) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS.Longitudine) + ", ";
				text += "'OG_GEODECIMAL', ";
				text = text + this.DbConn.SQLFormatString(this._User) + ", ";
				text = text + this.DbConn.SQLFormatString(this._User) + ");";
			}
			sQuery = text;
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
}
