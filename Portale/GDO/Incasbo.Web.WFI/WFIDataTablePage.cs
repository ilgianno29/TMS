using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIDataTablePage : WFIDBPage
{
	protected override FXRETURN LoadData(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = _LoadData(pnlDetail, ref objFunctionArguments, ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	private FXRETURN _LoadData(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Invalid comparison between Unknown and I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Invalid comparison between Unknown and I4
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Invalid comparison between Unknown and I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Invalid comparison between Unknown and I4
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected O, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		string text2 = "";
		bool flag = false;
		List<IIboWebComponent> list = new List<IIboWebComponent>();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Control parent = (Control)pnlDetail;
			switch (objFunctionArguments.Name)
			{
			case "DUPLICAZIONE":
			case "MODIFICA":
			case "CANCELLAZIONE":
			case "VISUALIZZAZIONE":
				if (objFunctionArguments.Data == null)
				{
					rsMess = TranslateMessage("XXX", "Dati incompleti o mancanti.");
				}
				else if (objFunctionArguments.Data.Count == 0)
				{
					rsMess = TranslateMessage("XXX", "Chiave non specificata.");
				}
				else if (!_objFunctionArguments.Parameters.ContainsKey("_datatable"))
				{
					rsMess = TranslateMessage("XXX", "Datatable non specificato. Impossibile caricare i dati.");
				}
				else
				{
					DataTable dataTable = (DataTable)_objFunctionArguments.Parameters["_datatable"];
					text2 = "1=1 " + objFunctionArguments.Data.GetFirstElementSqlWhereForDatatable();
					DataRow[] array = dataTable.Select(text2);
					PerformanceLogAppend("DBPage Before apply filter");
					if (array.Count() != 0)
					{
						DataTable dataTable2 = dataTable.Clone();
						DataRow[] array2 = array;
						foreach (DataRow row in array2)
						{
							dataTable2.ImportRow(row);
						}
						_SessionVariable["_datarows"] = (object)array;
						_SessionVariable["_datatable"] = (object)(DataTable)_objFunctionArguments.Parameters["_datatable"];
						set_BeforeImage(pnlDetail, new BeforeImageFieldsCollection());
						BeforeImageFieldsCollection beforeImageFieldsCollection = get_BeforeImage(pnlDetail);
						foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(parent))
						{
							Control val5 = iIboWebComponentControl;
							IIboWebComponent obj2 = (IIboWebComponent)val5;
							if (Operators.CompareString(obj2.SqlQueryLookup.Trim(), "", false) != 0)
							{
								list.Add(obj2);
							}
							if (Operators.CompareString(obj2.FieldName, "", false) == 0)
							{
								continue;
							}
							text = obj2.FieldName;
							try
							{
								obj = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0][text]);
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								rsMess = TranslateMessage("XXX", "Il campo '{0}' non appartiene alla tabella '{1}'", text, pnlDetail.TableNameLoad);
								ProjectData.ClearProjectError();
								goto end_IL_001f;
							}
							if (obj2 is IboWebImage)
							{
								IboWebImage iboWebImage2 = (IboWebImage)(object)obj2;
								string fieldNameExtension = iboWebImage2.FieldNameExtension;
								try
								{
									if (Operators.CompareString(fieldNameExtension, "", false) != 0)
									{
										object objectValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0][fieldNameExtension]);
										iboWebImage2.FileExtension = objectValue.ToString();
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									rsMess = TranslateMessage("XXX", "Il campo '{0}' non appartiene alla tabella '{1}'", text, pnlDetail.TableNameLoad);
									ProjectData.ClearProjectError();
									goto end_IL_001f;
								}
								iboWebImage2.ObjValue = RuntimeHelpers.GetObjectValue(obj);
								iboWebImage2.OriginalImageUrl = iboWebImage2.ImageUrl;
							}
							else
							{
								obj2.ObjValue = RuntimeHelpers.GetObjectValue(obj);
							}
							if (!beforeImageFieldsCollection.ContainsKey(text))
							{
								beforeImageFieldsCollection.Add(text, new BeforeImageField(text, obj.ToString(), RuntimeHelpers.GetObjectValue(obj)));
							}
							if (Operators.CompareString(objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
							{
								if (IsWfiIdentity(ref obj2))
								{
									obj2.ObjValue = "";
								}
								else if (IsDBIdentity(ref obj2))
								{
									obj2.ObjValue = "";
								}
							}
						}
						break;
					}
					rsMess = TranslateMessage("XXX", "Nessun record trovato.");
				}
				goto end_IL_001f;
			case "INSERIMENTO":
			{
				set_BeforeImage(pnlDetail, new BeforeImageFieldsCollection());
				BeforeImageFieldsCollection beforeImageFieldsCollection = get_BeforeImage(pnlDetail);
				foreach (Control iIboWebComponentControl2 in GetIIboWebComponentControls(parent))
				{
					Control val3 = iIboWebComponentControl2;
					IIboWebComponent val4 = (IIboWebComponent)val3;
					if (Operators.CompareString(val4.FieldName, "", false) == 0)
					{
						continue;
					}
					text = val4.FieldName;
					if ((int)val4.FieldDataType == 1)
					{
						beforeImageFieldsCollection.Add(text, new BeforeImageField(text, Conversions.ToString(-999999), -999999));
					}
					else if (val4 is IboWebImage)
					{
						IboWebImage iboWebImage = (IboWebImage)(object)val4;
						beforeImageFieldsCollection.Add(text, new BeforeImageField(text, "", ""));
						if (Operators.CompareString(iboWebImage.FieldNameExtension, "", false) != 0)
						{
							beforeImageFieldsCollection.Add(iboWebImage.FieldNameExtension, new BeforeImageField(text, "", ""));
						}
					}
					else if (!beforeImageFieldsCollection.ContainsKey(text))
					{
						beforeImageFieldsCollection.Add(text, new BeforeImageField(text, "", ""));
					}
				}
				_SessionVariable["_datatable"] = (object)(DataTable)_objFunctionArguments.Parameters["_datatable"];
				_SessionVariable["_datarows"] = (object)new DataRow[1] { ((DataTable)_objFunctionArguments.Parameters["_datatable"]).NewRow() };
				break;
			}
			default:
				rsMess = TranslateMessage("XXX", "Modalità/funzionalità non gestita.");
				goto end_IL_001f;
			}
			PerformanceLogAppend("DBPage After BeforeImage");
			foreach (Control allIboWebComponentControl in GetAllIboWebComponentControls(parent))
			{
				Control val6 = allIboWebComponentControl;
				if (val6 is IboWebCheckBoxList)
				{
					IboWebCheckBoxList val7 = (IboWebCheckBoxList)val6;
					val7.ReadOnly = !((Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & val7.Enabled);
				}
				else if (val6 is IboWebToolbar)
				{
					IboWebToolbar iboWebToolbar = (IboWebToolbar)(object)val6;
					iboWebToolbar.Enabled = (Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & iboWebToolbar.Enabled;
				}
				else if (val6 is IboGridView)
				{
					IboGridView val8 = (IboGridView)val6;
					val8.ReadOnly = !((Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & ((WebControl)val8).Enabled & !val8.ReadOnly);
				}
				else
				{
					if (!(val6 is IIboWebComponent))
					{
						continue;
					}
					IIboWebComponent obj3 = (IIboWebComponent)val6;
					if (Operators.CompareString(obj3.FieldName, "", false) != 0)
					{
						obj3.ReadOnly = !((Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & obj3.Enabled & !obj3.ReadOnly);
						if (IsDBIdentity(ref obj3))
						{
							obj3.ReadOnly = true;
						}
						else if (IsWfiIdentity(ref obj3))
						{
							obj3.ReadOnly = true;
						}
					}
				}
			}
			PerformanceLogAppend("DBPage After Disable controls");
			val = SetIsKeyPropertyToControls(pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("DBPage After SetIsKeyPropertyToControls");
				val = LoadDataInCheckList(pnlDetail, ref objFunctionArguments, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					PerformanceLogAppend("DBPage After LoadDataInCheckList");
					val = LookupQueryDecode(list, pnlDetail, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						PerformanceLogAppend("DBPage After LookupQueryDecode");
						val2 = (FXRETURN)0;
					}
				}
			}
			end_IL_001f:;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN AfterConfermaClick(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.AfterConfermaClick(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_objFunctionArguments.Parameters.Remove("_datatable");
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN AfterAnnullaClick(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.AfterAnnullaClick(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_objFunctionArguments.Parameters.Remove("_datatable");
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN SaveData(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Invalid comparison between Unknown and I4
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Invalid comparison between Unknown and I4
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Invalid comparison between Unknown and I4
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Invalid comparison between Unknown and I4
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Invalid comparison between Unknown and I4
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Invalid comparison between Unknown and I4
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Invalid comparison between Unknown and I4
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		object obj = null;
		string text3 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Control parent = (Control)pnlDetail;
			if (Operators.CompareString(objFunctionArguments.Name, "DUPLICAZIONE", false) != 0 || !((object)pnlDetail).Equals((object?)this))
			{
				goto IL_007e;
			}
			val = SaveDetailData(ref _SQLQueryToApply, ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_007e;
			}
			val2 = val;
			goto end_IL_001c;
			IL_007e:
			BeforeImageFieldsCollection beforeImageFieldsCollection = get_BeforeImage(pnlDetail);
			DataRow dataRow;
			if (beforeImageFieldsCollection == null)
			{
				rsMess = TranslateMessage("XXX", "Before image del contesto non caricato correttamente. Impossibile proseguire.");
			}
			else
			{
				dataRow = ((DataRow[])_SessionVariable["_datarows"])[0];
				foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(parent))
				{
					Control val3 = iIboWebComponentControl;
					IIboWebComponent obj2 = (IIboWebComponent)val3;
					if (IsDBIdentity(ref obj2) || Operators.CompareString(obj2.FieldName, "", false) == 0)
					{
						continue;
					}
					text2 = obj2.FieldName;
					if (!beforeImageFieldsCollection.ContainsKey(text2))
					{
						continue;
					}
					switch (objFunctionArguments.Name)
					{
					case "INSERIMENTO":
					case "DUPLICAZIONE":
						if ((int)obj2.FieldDataType == 1)
						{
							dataRow[text2] = Conversions.ToDecimal(obj2.ObjValue);
						}
						else if ((int)obj2.FieldDataType == 2)
						{
							if (val3 is IboWebDate)
							{
								dataRow[text2] = Conversions.ToDate(obj2.ObjValue);
							}
							else if (val3 is IboWebDate2)
							{
								dataRow[text2] = Conversions.ToDate(obj2.ObjValue);
							}
							else
							{
								dataRow[text2] = Conversions.ToDate(obj2.ObjValue.ToString());
							}
						}
						else if (val3 is IboWebImage)
						{
							IboWebImage iboWebImage2 = (IboWebImage)(object)val3;
							if (iboWebImage2.ObjValue == null)
							{
								dataRow[text2] = DBNull.Value;
							}
							else
							{
								dataRow[text2] = (byte[])iboWebImage2.ObjValue;
							}
							if (Operators.CompareString(iboWebImage2.FieldNameExtension, "", false) != 0)
							{
								if (iboWebImage2.ObjValue == null)
								{
									dataRow[iboWebImage2.FieldNameExtension] = DBNull.Value;
								}
								else
								{
									dataRow[iboWebImage2.FieldNameExtension] = iboWebImage2.FileExtension;
								}
							}
						}
						else
						{
							dataRow[text2] = obj2.ObjValue.ToString();
						}
						break;
					case "MODIFICA":
						if ((int)obj2.FieldDataType == 1)
						{
							if ((Operators.CompareString(beforeImageFieldsCollection[text2].FieldValue.ToString(), "", false) == 0) & (Operators.CompareString(obj2.ObjValue.ToString(), "", false) != 0))
							{
								dataRow[text2] = Conversions.ToDecimal(obj2.ObjValue);
							}
							else if ((Operators.CompareString(beforeImageFieldsCollection[text2].FieldValue.ToString(), "", false) != 0) & (Operators.CompareString(obj2.ObjValue.ToString(), "", false) == 0))
							{
								dataRow[text2] = Conversions.ToDecimal(obj2.ObjValue);
							}
							else if (Operators.CompareString(beforeImageFieldsCollection[text2].FieldValue.ToString(), "", false) != 0 && Conversions.ToDouble(obj2.ObjValue) != Conversions.ToDouble(beforeImageFieldsCollection[text2].FieldValue))
							{
								dataRow[text2] = Conversions.ToDecimal(obj2.ObjValue);
							}
						}
						else if ((int)obj2.FieldDataType == 2)
						{
							string text4 = obj2.ObjValue.ToString();
							string fieldText = beforeImageFieldsCollection[text2].FieldText;
							bool flag = false;
							if (((Operators.CompareString(text4, "", false) == 0) | (Operators.CompareString(fieldText, "", false) == 0)) & (Operators.CompareString(text4, fieldText, false) != 0))
							{
								flag = true;
							}
							else if (((Operators.CompareString(text4, "", false) != 0) & (Operators.CompareString(fieldText, "", false) != 0)) && DateTime.Compare(Conversions.ToDate(text4), Conversions.ToDate(fieldText)) != 0)
							{
								flag = true;
							}
							if (flag && Operators.CompareString(obj2.ObjValue.ToString(), beforeImageFieldsCollection[text2].FieldText, false) != 0)
							{
								if (val3 is IboWebDate)
								{
									dataRow[text2] = Conversions.ToDate(obj2.ObjValue);
								}
								else if (val3 is IboWebDate2)
								{
									dataRow[text2] = Conversions.ToDate(obj2.ObjValue);
								}
								else
								{
									dataRow[text2] = Conversions.ToDate(obj2.ObjValue.ToString());
								}
							}
						}
						else if (val3 is IboWebImage)
						{
							IboWebImage iboWebImage = (IboWebImage)(object)val3;
							if (Operators.CompareString(iboWebImage.ImageUrl, iboWebImage.OriginalImageUrl, false) == 0)
							{
								break;
							}
							byte[] array = (byte[])iboWebImage.ObjValue;
							if (array == null)
							{
								dataRow[text2] = DBNull.Value;
							}
							else
							{
								dataRow[text2] = array;
							}
							if (Operators.CompareString(iboWebImage.FieldNameExtension, "", false) != 0)
							{
								if (iboWebImage.ObjValue == null)
								{
									dataRow[iboWebImage.FieldNameExtension] = DBNull.Value;
								}
								else
								{
									dataRow[iboWebImage.FieldNameExtension] = iboWebImage.FileExtension;
								}
							}
						}
						else if (Operators.CompareString(obj2.ObjValue.ToString(), beforeImageFieldsCollection[text2].FieldText, false) != 0)
						{
							dataRow[text2] = obj2.ObjValue.ToString();
						}
						break;
					}
				}
				bool flag2 = true;
				if (!((Operators.CompareString(objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
				{
					goto IL_093d;
				}
				int num = checked(objFunctionArguments.Keys.Count() - 1);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					foreach (Control iIboWebComponentControl2 in GetIIboWebComponentControls(parent))
					{
						Control val4 = iIboWebComponentControl2;
						IIboWebComponent obj3 = (IIboWebComponent)val4;
						if (Operators.CompareString(obj3.FieldName.ToUpper(), objFunctionArguments.Keys[i].FieldName.ToUpper(), false) == 0 && !IsDBIdentity(ref obj3) && obj3.IsKey)
						{
							if (Operators.CompareString(text3, "", false) != 0)
							{
								text3 += " AND ";
							}
							text3 = (((int)obj3.FieldDataType != 2) ? (text3 + obj3.FieldName + "=" + base.DbConn.SQLFormatString(obj3.Text)) : (text3 + obj3.FieldName + "=" + base.DbConn.SQLFormatDate((eTipoData)1, obj3.Text)));
						}
					}
				}
				if (Operators.CompareString(text3, "", false) == 0 || ((DataTable)_SessionVariable["_datatable"]).Select(text3).Count() <= 0)
				{
					goto IL_093d;
				}
				rsMess = TranslateMessage("XXX", "Chiave duplicata sul database. Il record che si sta cercando di inserire esiste già.");
			}
			goto end_IL_001c;
			IL_093d:
			val = SaveIsDefault(pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = LogRisorseAzioneInserisci("", "", "salvataggio su datatable", "", ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					foreach (Control iIboWebComponentControl3 in GetIIboWebComponentControls(parent))
					{
						Control val5 = iIboWebComponentControl3;
						IboWebCheckBoxList checkList = (IboWebCheckBoxList)(object)((val5 is IboWebCheckBoxList) ? val5 : null);
						if (checkList == null)
						{
							continue;
						}
						val = SaveDataInCheckList(pnlDetail, ref objFunctionArguments, ref checkList, ref rsMess);
						if ((int)val <= 0)
						{
							continue;
						}
						val2 = val;
						goto end_IL_001c;
					}
					dataRow.AcceptChanges();
					dataRow.Table.AcceptChanges();
					val2 = (FXRETURN)0;
				}
			}
			end_IL_001c:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN SaveIsDefault(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Control parent = (Control)pnlDetail;
			if (Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0)
			{
				foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(parent))
				{
					Control val3 = iIboWebComponentControl;
					IboWebCheckBox val4 = (IboWebCheckBox)(object)((val3 is IboWebCheckBox) ? val3 : null);
					if (val4 == null)
					{
						continue;
					}
					string sWhere = "";
					IIboWebComponent obj = (IIboWebComponent)(object)val4;
					if (!IsDefault(ref obj, ref sWhere) || Operators.CompareString(val4.ValueIfChecked, val4.Value, false) != 0)
					{
						continue;
					}
					foreach (DataRow row in ((DataTable)_SessionVariable["_datatable"]).Rows)
					{
						row[val4.FieldName] = val4.ValueIfNotChecked;
					}
					((DataRow[])_SessionVariable["_datarows"])[0][val4.FieldName] = val4.ValueIfChecked;
				}
			}
			else if (Operators.CompareString(objFunctionArguments.Name, "CANCELLAZIONE", false) == 0)
			{
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN ReleaseMemory(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_SessionVariable != null && ((Operators.CompareString(_WarningBlockedMessage, "", false) == 0) & (Operators.CompareString(_SessionVariable["_AreYouSureBlockedMessageState"].ToString(), "0", false) == 0)))
			{
				if (_ComboQueryCache != null)
				{
					_ComboQueryCache.Clear();
				}
				if (_ComboQueryCacheTop50 != null)
				{
					_ComboQueryCacheTop50.Clear();
				}
				if (_SessionVariable != null && !_IsSessionVariablePersistent)
				{
					foreach (KeyValuePair<string, object> item in _SessionVariable)
					{
						object obj = item;
						if (((Operators.CompareString(((KeyValuePair<string, object>)obj).Key, "_datatable", false) != 0) & (Operators.CompareString(((KeyValuePair<string, object>)obj).Key, "_datarows", false) != 0)) && ((KeyValuePair<string, object>)obj).Value is IDisposable)
						{
							((IDisposable)((KeyValuePair<string, object>)obj).Value).Dispose();
						}
					}
					base.SessionEnvironment.SessionVariables.Remove(PageName);
					_SessionVariable = null;
				}
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}
}
