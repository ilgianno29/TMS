using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Api.Gdo.Track;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFICustom;

public class StandardProxyApiFunctions : IIboProxyApiFunctions
{
	protected enum StampaBollaTipoOutputEnum
	{
		None,
		ReportView,
		ReportSave
	}

	public FXRETURN CallApiFunction(string sFunctionName, ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref bool rbReturnToCaller, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_161f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1624: Unknown result type (might be due to invalid IL or missing references)
		//IL_163c: Unknown result type (might be due to invalid IL or missing references)
		//IL_163d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_1640: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Invalid comparison between Unknown and I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Invalid comparison between Unknown and I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Invalid comparison between Unknown and I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Invalid comparison between Unknown and I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Invalid comparison between Unknown and I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Invalid comparison between Unknown and I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Invalid comparison between Unknown and I4
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Invalid comparison between Unknown and I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Invalid comparison between Unknown and I4
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Invalid comparison between Unknown and I4
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Invalid comparison between Unknown and I4
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Invalid comparison between Unknown and I4
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Invalid comparison between Unknown and I4
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Invalid comparison between Unknown and I4
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Invalid comparison between Unknown and I4
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Invalid comparison between Unknown and I4
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Invalid comparison between Unknown and I4
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Invalid comparison between Unknown and I4
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Invalid comparison between Unknown and I4
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Invalid comparison between Unknown and I4
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Invalid comparison between Unknown and I4
		//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec4: Invalid comparison between Unknown and I4
		//IL_0e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Invalid comparison between Unknown and I4
		//IL_0ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001: Invalid comparison between Unknown and I4
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1072: Unknown result type (might be due to invalid IL or missing references)
		//IL_1073: Unknown result type (might be due to invalid IL or missing references)
		//IL_1075: Invalid comparison between Unknown and I4
		//IL_1009: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e9: Invalid comparison between Unknown and I4
		//IL_107d: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1235: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Unknown result type (might be due to invalid IL or missing references)
		//IL_123b: Unknown result type (might be due to invalid IL or missing references)
		//IL_123d: Invalid comparison between Unknown and I4
		//IL_12ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Invalid comparison between Unknown and I4
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_1371: Unknown result type (might be due to invalid IL or missing references)
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_1377: Unknown result type (might be due to invalid IL or missing references)
		//IL_1379: Invalid comparison between Unknown and I4
		//IL_12bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f1: Invalid comparison between Unknown and I4
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_1382: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_154f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_1555: Unknown result type (might be due to invalid IL or missing references)
		//IL_1557: Invalid comparison between Unknown and I4
		//IL_15c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cf: Invalid comparison between Unknown and I4
		//IL_155f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1560: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			rbReturnToCaller = true;
			if (Operators.CompareString(sFunctionName, "Example".ToUpper(), false) != 0)
			{
				switch (sFunctionName)
				{
				case "VIAGGIO.CHIUDI":
					if (robjFunctionArguments.Data.Count == 0)
					{
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
					}
					else
					{
						val2 = ViaggioChiudi(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
					}
					goto end_IL_0007;
				case "VIAGGIO.CHIUDI_E_PARTI":
					if (robjFunctionArguments.Data.Count == 0)
					{
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
					}
					else
					{
						val2 = ViaggioChiudiEParti(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
					}
					goto end_IL_0007;
				case "VIAGGIO.RIAPRI":
					if (robjFunctionArguments.Data.Count == 0)
					{
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
					}
					else
					{
						val2 = ViaggioRiapri(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
					}
					goto end_IL_0007;
				default:
					if (!((Operators.CompareString(sFunctionName, "VIAGGIO.PARTI", false) == 0) | (Operators.CompareString(sFunctionName, "VIAGGIO.INIZIA", false) == 0) | (Operators.CompareString(sFunctionName, "VIAGGIO.PARTENZA", false) == 0)))
					{
						switch (sFunctionName)
						{
						case "VIAGGIO.FINE":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ViaggioFine(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "VIAGGIO.CERTIFICA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ViaggioCertifica(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "VIAGGIO.ANNULLA.CERTIFICA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ViaggioAnnullaCertificazione(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "VIAGGIO.UNISCI":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else if (robjFunctionArguments.Data.Item(0).FieldValuesCount != 2)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "E' necessario selezionare due record", new string[0]);
							}
							else
							{
								val2 = ViaggioUnisci(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONE.ANNULLA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = SpedizioneAnnulla(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONE.DISATTIVA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = SpedizioneDisattiva(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONE.ATTIVA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = SpedizioneAttiva(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONE.CONFERMAPREBOLLA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = SpedizioneConfermaPrebolla(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONE.STAMPABOLLA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = SpedizioneStampaBolla(ref rObjPage, ref robjFunctionArguments, ref rObjSessionEnvironment, StampaBollaTipoOutputEnum.None, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONE.STAMPABOLLA.RPT":
							rbReturnToCaller = false;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = SpedizioneStampaBolla(ref rObjPage, ref robjFunctionArguments, ref rObjSessionEnvironment, StampaBollaTipoOutputEnum.ReportView, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONE.STAMPABOLLA.PDF":
							rbReturnToCaller = false;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = SpedizioneStampaBolla(ref rObjPage, ref robjFunctionArguments, ref rObjSessionEnvironment, StampaBollaTipoOutputEnum.ReportSave, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "TARIFFECONTRATTI.VISUALIZZA":
						{
							rbReturnToCaller = false;
							string text = "WFTARVisualizzaTariffeContratti.aspx";
							rObjSessionEnvironment.SessionVariables.Remove(text);
							rObjSessionEnvironment.SessionVariables.Add(text, new IboDictionaryCollection<string, object>());
							rObjSessionEnvironment.SessionVariables[text]["CONTEXT"] = (object)"DM.DOC.TARIFFE.CONTRATTI#VIS";
							IboAppCallStackHandling robjCallStackHandler = rObjSessionEnvironment.CallStackHandler;
							string sUrl = BaseFunctions.FindFormDir("~/GDO/FORM/" + text);
							BaseFunctions.IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
							break;
						}
						case "SPEDIZIONI.ESITAZIONE":
							rbReturnToCaller = false;
							checked
							{
								if (robjFunctionArguments.Data.Count != 0)
								{
									List<string> list4 = new List<string>();
									int num4 = robjFunctionArguments.Data[0].FieldValuesCount - 1;
									for (int l = 0; l <= num4; l++)
									{
										list4.Add(robjFunctionArguments.Data[0].get_FieldValues(l).ToString());
									}
									Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
									dictionary4.Add("UNIBOL", list4);
									rObjPage.OpenDialogPage("/%APPNAME%/Form/WFDOCSpedizioniEsito.aspx", "DM.DOC.SPEDIZIONI#ESITO", "MODIFICA", dictionary4, ResetSessionVariables: true);
									break;
								}
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
								goto end_IL_0007;
							}
						case "SPEDIZIONI.ANNULLA_ESITAZIONE":
							rbReturnToCaller = true;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = AnnullaEsitoSpedizioni(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONI_LIBERE.ESITAZIONE":
							rbReturnToCaller = false;
							checked
							{
								if (robjFunctionArguments.Data.Count != 0)
								{
									List<string> list2 = new List<string>();
									int num2 = robjFunctionArguments.Data[0].FieldValuesCount - 1;
									for (int j = 0; j <= num2; j++)
									{
										list2.Add(robjFunctionArguments.Data[0].get_FieldValues(j).ToString());
									}
									Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
									dictionary2.Add("UNIBOL", list2);
									rObjPage.OpenDialogPage("/%APPNAME%/Form/WFDOCSpedizioniAttiveLibereEsito.aspx", "DM.DOC.SPEDIZIONI#ESITO", "MODIFICA", dictionary2, ResetSessionVariables: true);
									break;
								}
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
								goto end_IL_0007;
							}
						case "SPEDIZIONI.CREAVIAGGIO":
							rbReturnToCaller = false;
							checked
							{
								if (robjFunctionArguments.Data.Count != 0)
								{
									List<string> list5 = new List<string>();
									int num5 = robjFunctionArguments.Data[0].FieldValuesCount - 1;
									for (int m = 0; m <= num5; m++)
									{
										list5.Add(robjFunctionArguments.Data[0].get_FieldValues(m).ToString());
									}
									string pagina = "/%APPNAME%/Form/WFDocViaggiCrea.aspx";
									string context = "DM.VIAGGIO.CREACONSPEDIZIONI";
									string modalita = "STANDARD";
									Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
									dictionary5.Add("ElencoSpedizioni", list5);
									rObjPage.OpenDialogPage(pagina, context, modalita, dictionary5, ResetSessionVariables: true);
									break;
								}
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
								goto end_IL_0007;
							}
						case "VIAGGI.CALCOLAKMETEMPI":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ViaggiCalcolaKmETempi(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "VIAGGI.SPEDIZIONI.ESITAZIONE":
							rbReturnToCaller = false;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ViaggiEsitaTutteLeSpedizioni(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rObjPage, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "VIAGGI.SPEDIZIONI.DAESITARE":
							rbReturnToCaller = false;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ViaggiSpedizioniDaEsitare(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rObjPage, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "VIAGGI.VOLUMETRICARAGGRUPPATA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = Viaggi_RichiestaVolumetricaRaggruppata(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rObjPage, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONI.ARRIVOATP":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = SpedizioneEsitoATransitPoint(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "IMP.SPEDIZIONI.EVENTI.VALIDAZIONE":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ImpSpedizioneEventiValidazione(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "FATT.ATTIVE.RIELABORA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = RielaboraFatturaAttiva(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "FATT.PASSIVE.RIELABORA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = RielaboraFatturaPassiva(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONI.CREASUBSPEDIZIONI":
							if (robjFunctionArguments.Data.Count != 0)
							{
								break;
							}
							rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							goto end_IL_0007;
						case "SPEDIZIONI.RIASSOCIA_A_LINEA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = RiassociaALinea(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "FATTURE_PASSIVE.ESPORTA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = EsportaFatturePassive(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "FATTURE_ATTIVE.ESPORTA":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = EsportaFattureAttive(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "FATTURE_ATTIVE.ESPORTAXML":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = EsportaFattureAttiveXML(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "CONTRASSEGNI.ESITAZIONE":
							rbReturnToCaller = false;
							checked
							{
								if (robjFunctionArguments.Data.Count != 0)
								{
									List<string> list3 = new List<string>();
									int num3 = robjFunctionArguments.Data[0].FieldValuesCount - 1;
									for (int k = 0; k <= num3; k++)
									{
										list3.Add(robjFunctionArguments.Data[0].get_FieldValues(k).ToString());
									}
									Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
									dictionary3.Add("ID", list3);
									rObjPage.OpenDialogPage("/%APPNAME%/Form/WFDOCContrassegniEsito.aspx", "DM.DOC.CONTRASSEGNI#ESITO", "ESITO", dictionary3, ResetSessionVariables: true);
									break;
								}
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
								goto end_IL_0007;
							}
						case "CONTRASSEGNI.ANNULLA_ESITO":
							rbReturnToCaller = true;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ContrassegniAnnullaEsito(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "CONTRASSEGNI.RIMESSA_OK":
							rbReturnToCaller = true;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ContrassegniConfermaRimessa(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "CONTESTAZIONE.CREA":
							rbReturnToCaller = false;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								string text2 = robjFunctionArguments.Data[0].get_FieldValues(0).ToString();
								WFIPage obj = rObjPage;
								string[] CampiChiave = new string[1] { "unibol" };
								object[] ValoriCampiChiave = new object[1] { text2 };
								val2 = obj.OpenDbPage(ref CampiChiave, ref ValoriCampiChiave, "DM.DOC.CONTESTAZIONI", "INSERIMENTO", text2, null, null, null, null, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "GIACENZA.RIAPRI":
							rbReturnToCaller = true;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = GiacenzaRiapri(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "GIACENZA.CHIUDI":
							rbReturnToCaller = false;
							checked
							{
								if (robjFunctionArguments.Data.Count != 0)
								{
									List<string> list = new List<string>();
									int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
									for (int i = 0; i <= num; i++)
									{
										list.Add(robjFunctionArguments.Data[0].get_FieldValues(i).ToString());
									}
									Dictionary<string, object> dictionary = new Dictionary<string, object>();
									dictionary.Add("ID", list);
									rObjPage.OpenDialogPageInIFrame("/%APPNAME%/Form/WFDOCGiacenzeChiudi.aspx", "DM.DOC.GIACENZE.CHIUDI", "CHIUDI", dictionary, ResetSessionVariables: true, "CHIUDI", "Chiusura giacenza", WFIMaster.IFrameDimension.IFrameContainer1000x600, "", "", ref rsMess);
									break;
								}
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
								goto end_IL_0007;
							}
						case "FATT.PASSIVE.CONTROLLO":
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = ConfermaControlloFatturePassive(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						case "SPEDIZIONI.GENERA_RICONSEGNA":
							rbReturnToCaller = true;
							if (robjFunctionArguments.Data.Count == 0)
							{
								rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
							}
							else
							{
								val2 = GeneraRiconsegne(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
								if ((int)val2 <= 0)
								{
									break;
								}
								val = val2;
							}
							goto end_IL_0007;
						default:
							rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Funzione non riconosciuta", new string[1] { rsMess });
							goto end_IL_0007;
						}
						break;
					}
					if (robjFunctionArguments.Data.Count == 0)
					{
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
					}
					else
					{
						val2 = ViaggioInizia(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rsWarning, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
					}
					goto end_IL_0007;
				}
			}
			val = (FXRETURN)0;
			end_IL_0007:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	FXRETURN IIboProxyApiFunctions.CallApiFunction(string sFunctionName, ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref bool rbReturnToCaller, ref string rsMess)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CallApiFunction
		return this.CallApiFunction(sFunctionName, ref robjFunctionArguments, ref rObjSessionEnvironment, ref rObjPage, ref rsWarning, ref rbReturnToCaller, ref rsMess);
	}

	private FXRETURN ViaggioChiudi(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(i).ToString();
				string rsmess = "";
				val2 = Viaggio_Chiudi_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text2, DateAndTime.Now, ref rsmess);
				if ((int)val2 > 0)
				{
					text += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella chiusura del viaggio {0}: {1}", new string[2] { text2, rsmess });
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				rsWarning = text;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggioChiudiEParti(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(i).ToString();
				string rsmess = "";
				val2 = Viaggio_Chiudi_E_Parti_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text2, DateAndTime.Now, ref rsmess);
				if ((int)val2 > 0)
				{
					text += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella chiusura del viaggio {0}: {1}", new string[2] { text2, rsmess });
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				rsWarning = text;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggioRiapri(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(i).ToString();
				string rsmess = "";
				val2 = Viaggio_Riapri_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text2, DateAndTime.Now, ref rsmess);
				if ((int)val2 > 0)
				{
					text += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella riapertura del viaggio {0}: {1}", new string[2] { text2, rsmess });
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				rsWarning = text;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggioInizia(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(i).ToString();
				string rsmess = "";
				val2 = Viaggio_Partenza_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text2, ref rsmess);
				if ((int)val2 > 0)
				{
					text += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella partenza del viaggio {0}: {1}", new string[2]
					{
						text2,
						rsmess + "\r\n"
					});
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				rsWarning = text;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggioFine(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(i).ToString();
				string rsmess = "";
				Viaggio_Fine_Invoker instance = Viaggio_Fine_Invoker.Instance;
				AppApiContext objApiContext = rObjSessionEnvironment.CreateApiContext();
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, text2, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
				if ((int)val2 > 0)
				{
					text += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella terminazione del viaggio {0}: {1}", new string[2]
					{
						text2,
						rsmess + "\r\n"
					});
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				rsWarning = text;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggioCertifica(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(i).ToString();
				string rsmess = "";
				Viaggio_Certifica_Invoker instance = Viaggio_Certifica_Invoker.Instance;
				AppApiContext objApiContext = rObjSessionEnvironment.CreateApiContext();
				DateTime? data = DateAndTime.Now;
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, text2, data, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
				if ((int)val2 > 0)
				{
					text += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella certificazione del viaggio {0}: {1}", new string[2]
					{
						text2,
						rsmess + "\r\n"
					});
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				rsWarning = text;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggioAnnullaCertificazione(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(i).ToString();
				string rsmess = "";
				Viaggio_AnnullaCertificazione_Invoker instance = Viaggio_AnnullaCertificazione_Invoker.Instance;
				AppApiContext objApiContext = rObjSessionEnvironment.CreateApiContext();
				DateTime? data = DateAndTime.Now;
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, text2, data, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
				if ((int)val2 > 0)
				{
					text += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nell'annullamento della certificazione del viaggio {0}: {1}", new string[2]
					{
						text2,
						rsmess + "\r\n"
					});
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				rsWarning = text;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggioUnisci(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			string idViaggioSorgente = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(0).ToString();
			string idViaggioDestinazione = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(1).ToString();
			val2 = Viaggio_UnisciViaggi_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), idViaggioDestinazione, idViaggioSorgente, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN SpedizioneAnnulla(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			int num = checked(robjFunctionArguments.Data.Item("Unibol").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				text = robjFunctionArguments.Data.Item("Unibol").get_FieldValues(i).ToString();
				string rsmess = "";
				val2 = Spedizione_Annulla_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text, "", ref rsmess);
				if ((int)val2 > 0)
				{
					text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nell'annullamento della spedizione {0}", new string[1] { text }) + ": " + rsmess + "\r\n";
				}
			}
			if (Operators.CompareString(text2, "", false) != 0)
			{
				rsWarning = text2;
			}
			else
			{
				rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Spedizioni annullate correttamente", new string[0]);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN SpedizioneDisattiva(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			int num = checked(robjFunctionArguments.Data.Item("Unibol").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				text = robjFunctionArguments.Data.Item("Unibol").get_FieldValues(i).ToString();
				string rsmess = "";
				val2 = Spedizione_Disattiva_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text, "", ref rsmess);
				if ((int)val2 > 0)
				{
					text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella disattivazione della spedizione {0}", new string[1] { text }) + ": " + rsmess + "\r\n";
				}
			}
			if (Operators.CompareString(text2, "", false) != 0)
			{
				rsWarning = text2;
			}
			else
			{
				rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Spedizioni disattivate correttamente", new string[0]);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN SpedizioneAttiva(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			int num = checked(robjFunctionArguments.Data.Item("Unibol").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				text = robjFunctionArguments.Data.Item("Unibol").get_FieldValues(i).ToString();
				string rsmess = "";
				val2 = Spedizione_Attiva_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text, "", ref rsmess);
				if ((int)val2 > 0)
				{
					text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nell'attivazione della spedizione {0}", new string[1] { text }) + ": " + rsmess + "\r\n";
				}
			}
			if (Operators.CompareString(text2, "", false) != 0)
			{
				rsWarning = text2;
			}
			else
			{
				rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Spedizioni attivate correttamente", new string[0]);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggiCalcolaKmETempi(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			for (int i = 0; i < robjFunctionArguments.Data[0].FieldValuesCount; i = checked(i + 1))
			{
				string text2 = "";
				string text3 = robjFunctionArguments.Data[0].get_FieldValues(i).ToString();
				val2 = ViaggioRicalcolaKmETempi_GDOWSC_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text3, null, rObjSessionEnvironment.WebUser.WebUserInfo.Codice, rObjSessionEnvironment.WebUser.WebUserInfo.DecryptedPassword(), ref rsMess);
				if ((int)val2 > 0)
				{
					text = text + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nel calcolo dei km/tempi per il viaggio {0}", new string[1] { text3 }) + ": " + text2 + "\r\n";
				}
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				rsWarning = text;
			}
			else
			{
				rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Calcolo km/tempi per i viaggi eseguito correttamente", new string[0]);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN SpedizioneConfermaPrebolla(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			int num = checked(robjFunctionArguments.Data.Item("Unibol").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				text = robjFunctionArguments.Data.Item("Unibol").get_FieldValues(i).ToString();
				string rsmess = "";
				val2 = Spedizione_ConfermaPrebolla_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text, ref rsmess);
				if ((int)val2 > 0)
				{
					text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella conferma prebolla della spedizione {0}", new string[1] { text }) + ": " + rsmess + "\r\n";
				}
			}
			if (Operators.CompareString(text2, "", false) != 0)
			{
				rsWarning = text2;
			}
			else
			{
				rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Prebolle confermate correttamente", new string[0]);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN SpedizioneStampaBolla(ref WFIPage rObjPage, ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, StampaBollaTipoOutputEnum TipoOutput, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Invalid comparison between Unknown and I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Invalid comparison between Unknown and I4
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Invalid comparison between Unknown and I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Invalid comparison between Unknown and I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between Unknown and I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			string ReportFileName = "";
			StringCollection stringCollection = new StringCollection();
			string rsmess = "";
			int num = checked(robjFunctionArguments.Data.Item("Unibol").FieldValuesCount - 1);
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					text = robjFunctionArguments.Data.Item("Unibol").get_FieldValues(num2).ToString();
					val2 = Spedizione_StampaBolla_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella generazione del numero DDT della spedizione {0}", new string[1] { text }) + ": " + rsmess;
						break;
					}
					if (TipoOutput == StampaBollaTipoOutputEnum.ReportSave || TipoOutput == StampaBollaTipoOutputEnum.ReportView)
					{
						text = robjFunctionArguments.Data.Item("Unibol").get_FieldValues(num2).ToString();
						val2 = Spedizione_GeneraPdf_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text, ref ReportFileName, ref rsmess);
						if ((int)val2 > 0)
						{
							val = val2;
							rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella generazione del file di stampa DDT della spedizione {0}", new string[1] { text }) + ": " + rsmess;
							break;
						}
						IboSessionEnvironment obj = rObjSessionEnvironment;
						string sNomeFile = ReportFileName;
						string rsMess2 = "";
						obj.AddFileToDelete(sNomeFile, ref rsMess2);
						stringCollection.Add(ReportFileName);
					}
					if (TipoOutput == StampaBollaTipoOutputEnum.ReportSave)
					{
						string text3 = "SELECT NumeroBolla FROM Spedizioni WHERE Unibol=" + rObjSessionEnvironment.DbConn.SQLFormatString(text);
						object obj2 = null;
						val2 = rObjSessionEnvironment.DbConn.DoSql(text3, (object)"", ref obj2, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						val2 = Spedizione_DocumentoInserisci_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), text, "DDT", ReportFileName, obj2.ToString(), DateAndTime.Now.Date, "SALVATAGGIO AUTOMATICO", ref rsmess);
						if ((int)val2 > 0)
						{
							val = val2;
							rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nel salvataggio del DDT per la spedizione {0}", new string[1] { text }) + ": " + rsmess;
							break;
						}
					}
					num2 = checked(num2 + 1);
					continue;
				}
				if ((TipoOutput == StampaBollaTipoOutputEnum.ReportView || TipoOutput == StampaBollaTipoOutputEnum.ReportSave) && stringCollection.Count > 0)
				{
					val2 = rObjPage.PdfMerge(stringCollection, SegnaFileComeDaCancellare: true, ref ReportFileName, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella composizione di un unico file di stampa DDT della spedizione {0}", new string[1] { text }) + ": " + rsmess;
						break;
					}
					val2 = rObjPage.VisualizzaStampa(ReportFileName, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nella generazione del file di stampa DDT della spedizione {0}", new string[1] { text }) + ": " + rsmess + "\r\n";
						break;
					}
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggiEsitaTutteLeSpedizioni(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			string pagina = "/%APPNAME%/Form/WFDOCSpedizioniEsito.aspx";
			string text2 = "";
			DataTable dataTable;
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					text2 = text2 + rObjSessionEnvironment.DbConn.SQLFormatString(robjFunctionArguments.Data[0].get_FieldValues(i).ToString()) + ", ";
				}
				text2 = text2.Substring(0, text2.Length - 2);
				dataTable = null;
				string text3 = "SELECT Unibol FROM Spedizioni WHERE IdViaggio IN (" + text2 + ") ";
				text3 += "AND Stato IN (40, 48) ";
				val2 = rObjSessionEnvironment.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
			}
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				List<string> list = new List<string>();
				foreach (DataRow row in dataTable.Rows)
				{
					list.Add(row["Unibol"].ToString());
				}
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("UNIBOL", list);
				rObjPage.OpenDialogPage(pagina, "DM.DOC.SPEDIZIONI#ESITO", "MODIFICA", dictionary, ResetSessionVariables: true);
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ViaggiSpedizioniDaEsitare(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		checked
		{
			FXRETURN result;
			try
			{
				rsMess = "";
				rsWarning = "";
				rObjSessionEnvironment.CallStackHandler.CallStackAdd();
				string text2 = "";
				string text3 = "";
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					text2 = text2 + rObjSessionEnvironment.DbConn.SQLFormatString(robjFunctionArguments.Data[0].get_FieldValues(i).ToString()) + ", ";
					text3 = text3 + robjFunctionArguments.Data[0].get_FieldValues(i).ToString() + "-";
				}
				text2 = text2.Substring(0, text2.Length - 2);
				text3 = text3.Substring(0, text3.Length - 1);
				string nomRif = "DM.DOC.SPEDIZIONI#ESITO";
				string title = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Spedizioni da esitare per i viaggi " + text3, new string[0]);
				string whereAggiuntiva = "IdViaggio IN ( " + text2 + ") ";
				rObjPage.OpenGridInPage(nomRif, title, whereAggiuntiva);
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				rObjSessionEnvironment.CallStackHandler.CallStackRemove();
				result = val;
			}
			return result;
		}
	}

	private FXRETURN Viaggi_RichiestaVolumetricaRaggruppata(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Invalid comparison between Unknown and I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Invalid comparison between Unknown and I4
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Invalid comparison between Unknown and I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Invalid comparison between Unknown and I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			StringCollection stringCollection = new StringCollection();
			StringEnumerator enumerator;
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					stringCollection.Add(robjFunctionArguments.Data[0].get_FieldValues(i).ToString());
				}
				enumerator = stringCollection.GetEnumerator();
			}
			while (true)
			{
				if (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					DataTable dataTable = null;
					string text = "";
					text = "SELECT T.* FROM (";
					text += "SELECT 'D' Tipo,";
					if ((int)rObjSessionEnvironment.DbConn.ServerType == 0)
					{
						text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
						text = text + "FROM Spedizioni TEMP WHERE IdViaggio=" + rObjSessionEnvironment.DbConn.SQLFormatString(current) + " ";
						text += "AND STATOWMS<>0 AND STATOWMS<>99 ";
						text += "AND TEMP.CORRISPONDENTE IS NULL AND TEMP.PCSDESTINAZIONE = S.PCSDESTINAZIONE ";
						text += "FOR XML PATH('')),1,1,'') AS ListaUnibol, ";
					}
					else if ((int)rObjSessionEnvironment.DbConn.ServerType == 1)
					{
						text += "CAST(wm_concat (DISTINCT S.Unibol) AS VARCHAR2(4000)) AS ListaUnibol, ";
					}
					text += "S.PCSDESTINAZIONE PCSDESTINAZIONE ";
					text += "FROM Spedizioni S ";
					text = text + "WHERE IdViaggio=" + rObjSessionEnvironment.DbConn.SQLFormatString(current) + " ";
					text += "AND STATOWMS<>0 AND STATOWMS<>99 ";
					text += "AND S.CORRISPONDENTE IS NULL ";
					text += "GROUP BY S.PCSDESTINAZIONE ";
					text += " UNION ";
					text += "SELECT 'C' Tipo,";
					if ((int)rObjSessionEnvironment.DbConn.ServerType == 0)
					{
						text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
						text = text + "FROM Spedizioni TEMP WHERE IdViaggio=" + rObjSessionEnvironment.DbConn.SQLFormatString(current) + " ";
						text += "AND STATOWMS<>0 AND STATOWMS<>99 ";
						text += "AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE ";
						text += "FOR XML PATH('') ),1,1,'') AS ListaUnibol, ";
					}
					else if ((int)rObjSessionEnvironment.DbConn.ServerType == 1)
					{
						text += "CAST(wm_concat (DISTINCT S.Unibol) AS VARCHAR2(4000)) AS ListaUnibol, ";
					}
					text += "S.CORRISPONDENTE PCSDESTINAZIONE ";
					text += "FROM Spedizioni S ";
					text = text + "WHERE IdViaggio=" + rObjSessionEnvironment.DbConn.SQLFormatString(current) + " ";
					text += "AND STATOWMS<>0 AND STATOWMS<>99 ";
					text += "AND S.CORRISPONDENTE IS NOT NULL ";
					text += "GROUP BY S.CORRISPONDENTE ) T";
					val2 = rObjSessionEnvironment.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					foreach (DataRow row in dataTable.Rows)
					{
						StringCollection stringCollection2 = new StringCollection();
						string[] array = row["ListaUnibol"].ToString().Split(new char[1] { ',' });
						foreach (string value in array)
						{
							stringCollection2.Add(value);
						}
						string codiceRaggruppamento = current + "-" + row["Tipo"].ToString() + "-" + row["PCSDESTINAZIONE"].ToString();
						val2 = WMS_RichiesteVolumetrichePerRaggruppamentoOrdini_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), current, stringCollection2, codiceRaggruppamento, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							goto end_IL_03f3;
						}
					}
					continue;
				}
				val = (FXRETURN)0;
				break;
				continue;
				end_IL_03f3:
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN SpedizioneEsitoATransitPoint(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			DateTime now = DateAndTime.Now;
			int num = checked(robjFunctionArguments.Data.Item("Unibol").FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				text = robjFunctionArguments.Data.Item("Unibol").get_FieldValues(i).ToString();
				string rsmess = "";
				string Warning = "";
				Spedizione_ArrivoATP_Invoker instance = Spedizione_ArrivoATP_Invoker.Instance;
				AppApiContext objApiContext = rObjSessionEnvironment.CreateApiContext();
				string unibol = text;
				DateTime? data = now;
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, unibol, "", data, "", "", ApplyQuery: true, ref RetQueryToApply, ref Warning, ref rsmess);
				if ((int)val2 > 0)
				{
					text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nell'esitazione a TP della spedizione {0}", new string[1] { text }) + ": " + rsmess + "\r\n";
				}
				else if (Operators.CompareString(Warning, "", false) != 0)
				{
					text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Problema nell'esitazione a TP della spedizione {0}", new string[1] { text }) + ": " + Warning + "\r\n";
				}
			}
			if (Operators.CompareString(text2, "", false) != 0)
			{
				rsWarning = text2;
			}
			else
			{
				rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Spedizioni Esitate correttamente", new string[0]);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ImpSpedizioneEventiValidazione(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			DateTime now = DateAndTime.Now;
			checked
			{
				int num = robjFunctionArguments.Data.Item("Id").FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = robjFunctionArguments.Data.Item("Id").get_FieldValues(i).ToString();
					text = text + "UPDATE IMP_SPEDIZIONI_EVENTI SET STATOELABORAZIONE = 'N' WHERE ID = " + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref text2) + ";";
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					goto IL_00c4;
				}
				val2 = rObjSessionEnvironment.DbConn.SqlExec(text, ref rsMess);
			}
			if ((int)val2 <= 0)
			{
				goto IL_00c4;
			}
			val = val2;
			goto end_IL_000b;
			IL_00c4:
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN RielaboraFatturaPassiva(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			checked
			{
				int num = robjFunctionArguments.Data.Item("Progressivo").FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = robjFunctionArguments.Data.Item("Progressivo").get_FieldValues(i).ToString();
					text += "UPDATE Fatture_Passive_Pilota SET DataOraInizioEsecuzione=NULL, DataOraFineEsecuzione=NULL, Errore=NULL ";
					text = text + "WHERE Progressivo=" + rObjSessionEnvironment.DbConn.SQLFormatString(text2) + " AND IdFatturaGenerata IS NULL;";
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					goto IL_00c9;
				}
				val2 = rObjSessionEnvironment.DbConn.SqlExec(text, ref rsMess);
			}
			if ((int)val2 <= 0)
			{
				goto IL_00c9;
			}
			val = val2;
			goto end_IL_000b;
			IL_00c9:
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN RielaboraFatturaAttiva(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			checked
			{
				int num = robjFunctionArguments.Data.Item("Progressivo").FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = robjFunctionArguments.Data.Item("Progressivo").get_FieldValues(i).ToString();
					text += "UPDATE Fatture_Attive_Pilota SET DataOraInizioEsecuzione=NULL, DataOraFineEsecuzione=NULL, Errore=NULL ";
					text = text + "WHERE Progressivo=" + rObjSessionEnvironment.DbConn.SQLFormatString(text2) + " AND IdFatturaGenerata IS NULL;";
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					goto IL_00c9;
				}
				val2 = rObjSessionEnvironment.DbConn.SqlExec(text, ref rsMess);
			}
			if ((int)val2 <= 0)
			{
				goto IL_00c9;
			}
			val = val2;
			goto end_IL_000b;
			IL_00c9:
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN RiassociaALinea(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			StringCollection stringCollection = new StringCollection();
			StringEnumerator enumerator;
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					stringCollection.Add(robjFunctionArguments.Data[0].get_FieldValues(i).ToString());
				}
				enumerator = stringCollection.GetEnumerator();
			}
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string IdViaggioLinea = "";
				string rsmess = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Id spedizione{1} {2}: ", new string[3] { "<b>", "</b>", current });
				val2 = ViaggioDiLinea_RiassociaSpedizioneAttiva_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), current, ref IdViaggioLinea, ref rsmess);
				if ((int)val2 > 0)
				{
					Warning += rsmess;
				}
				else if (Operators.CompareString(IdViaggioLinea, "", false) != 0)
				{
					Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Associata a linea {0}", new string[1] { IdViaggioLinea });
				}
				else
				{
					Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun giro configurato", new string[0]);
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN EsportaFatturePassive(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			StringCollection stringCollection = new StringCollection();
			StringEnumerator enumerator;
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					stringCollection.Add(robjFunctionArguments.Data[0].get_FieldValues(i).ToString());
				}
				enumerator = stringCollection.GetEnumerator();
			}
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string rsMess2 = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Esportazione fatture{1}{2}{0}Id Fattura{1} {3}: ", new string[4] { "<b>", "</b>", "\r\n", current });
				val2 = FatturePassiveEsporta_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), Conversions.ToLong(current), ref rsMess2);
				if ((int)val2 > 0)
				{
					Warning += rsMess2;
				}
				else
				{
					Warning += "OK";
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN EsportaFattureAttive(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			StringCollection stringCollection = new StringCollection();
			StringEnumerator enumerator;
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					stringCollection.Add(robjFunctionArguments.Data[0].get_FieldValues(i).ToString());
				}
				enumerator = stringCollection.GetEnumerator();
			}
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string rsMess2 = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Esportazione fatture{1}{2}{0}Id Fattura{1} {3}: ", new string[4] { "<b>", "</b>", "\r\n", current });
				val2 = FattureAttiveEsporta_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), Conversions.ToLong(current), ref rsMess2);
				if ((int)val2 > 0)
				{
					Warning += rsMess2;
				}
				else
				{
					Warning += "OK";
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN EsportaFattureAttiveXML(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			StringCollection stringCollection = new StringCollection();
			StringEnumerator enumerator;
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					stringCollection.Add(robjFunctionArguments.Data[0].get_FieldValues(i).ToString());
				}
				enumerator = stringCollection.GetEnumerator();
			}
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				string rsMess2 = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Creazione fattura elettonica{1}{2}{0}Id Fattura{1} {3}: ", new string[4] { "<b>", "</b>", "\r\n", current });
				val2 = FattureAttiveEsportaXML_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), Conversions.ToLong(current), ref rsMess2);
				if ((int)val2 > 0)
				{
					Warning += rsMess2;
				}
				else
				{
					Warning += "OK";
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ContrassegniAnnullaEsito(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			List<int> list = new List<int>();
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(Conversions.ToInteger(robjFunctionArguments.Data[0].get_FieldValues(i)));
				}
			}
			foreach (int item in list)
			{
				string rsmess = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Annullamento esito contrassegni{1}{2}{0}Id contrassegno{1} {3}: ", new string[4]
				{
					"<b>",
					"</b>",
					"\r\n",
					item.ToString()
				});
				Contrassegno_AnnullaEsito_Invoker instance = Contrassegno_AnnullaEsito_Invoker.Instance;
				AppApiContext objApiContext = rObjSessionEnvironment.CreateApiContext();
				int idContrassegno = item;
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, idContrassegno, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
				if ((int)val2 > 0)
				{
					Warning += rsmess;
				}
				else
				{
					Warning += "OK";
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ContrassegniConfermaRimessa(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			List<int> list = new List<int>();
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(Conversions.ToInteger(robjFunctionArguments.Data[0].get_FieldValues(i)));
				}
			}
			foreach (int item in list)
			{
				string rsmess = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Conferma rimessa contrassegni{1}{2}{0}Id rimessa{1} {3}: ", new string[4]
				{
					"<b>",
					"</b>",
					"\r\n",
					item.ToString()
				});
				val2 = Contrassegno_Rimessa_Conferma_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), item, null, ref rsmess);
				if ((int)val2 > 0)
				{
					Warning += rsmess;
				}
				else
				{
					Warning += "OK";
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN GiacenzaRiapri(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Invalid comparison between Unknown and I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			List<int> list = new List<int>();
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(Conversions.ToInteger(robjFunctionArguments.Data[0].get_FieldValues(i)));
				}
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Riapertura pratiche di giacenza{1}{2} ", new string[3] { "<b>", "</b>", "\r\n" });
			}
			foreach (int item in list)
			{
				string rsmess = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Id giacenza {1}:{2} ", new string[3]
				{
					"<b>",
					item.ToString(),
					"</b>"
				});
				Giacenza_Riapri_Invoker instance = Giacenza_Riapri_Invoker.Instance;
				AppApiContext objApiContext = rObjSessionEnvironment.CreateApiContext();
				int idGiacenza = item;
				DateTime? dataRiapertura = DateAndTime.Now;
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, idGiacenza, dataRiapertura, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
				if ((int)val2 > 0)
				{
					Warning += rsmess;
				}
				else
				{
					Warning += "OK";
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ConfermaControlloFatturePassive(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Invalid comparison between Unknown and I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			string codice = rObjSessionEnvironment.WebUser.WebUserInfo.Codice;
			DateTime now = DateAndTime.Now;
			List<int> list = new List<int>();
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(Conversions.ToInteger(robjFunctionArguments.Data[0].get_FieldValues(i)));
				}
				foreach (int item in list)
				{
					int current = item;
					text = "UPDATE Fatture_Passive_Testata SET UtenteDiControllo = " + rObjSessionEnvironment.DbConn.SQLFormatString(codice) + ",";
					text = text + "DataDiControllo = " + rObjSessionEnvironment.DbConn.SQLFormatDate((eTipoData)2, now) + " ";
					text = text + "WHERE IDFATTURA =" + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref current) + ";";
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					goto IL_014e;
				}
				val2 = rObjSessionEnvironment.DbConn.SqlExec(text, ref rsMess);
			}
			if ((int)val2 <= 0)
			{
				goto IL_014e;
			}
			val = val2;
			goto end_IL_000b;
			IL_014e:
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN AnnullaEsitoSpedizioni(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			List<string> list = new List<string>();
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(robjFunctionArguments.Data[0].get_FieldValues(i).ToString());
				}
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Annullo esito spedizioni{1}{2} ", new string[3] { "<b>", "</b>", "\r\n" });
			}
			foreach (string item in list)
			{
				string rsmess = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Id spedizione {1}:{2} ", new string[3] { "<b>", item, "</b>" });
				val2 = Spedizione_AnnullaEsito_Invoker.Instance.RunProc(rObjSessionEnvironment.CreateApiContext(), item, ref rsmess);
				if ((int)val2 > 0)
				{
					Warning += rsmess;
				}
				else
				{
					Warning += "OK";
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN GeneraRiconsegne(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Invalid comparison between Unknown and I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			Warning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			List<string> list = new List<string>();
			checked
			{
				int num = robjFunctionArguments.Data[0].FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(robjFunctionArguments.Data[0].get_FieldValues(i).ToString());
				}
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Generazione riconsegne di spedizione{1}{2} ", new string[3] { "<b>", "</b>", "\r\n" });
			}
			foreach (string item in list)
			{
				string rsmess = "";
				Warning += rObjSessionEnvironment.Translator.TranslateMessage("XXX", "{0}Id spedizione {1}:{2} ", new string[3] { "<b>", item, "</b>" });
				Spedizione_Riconsegna_Invoker instance = Spedizione_Riconsegna_Invoker.Instance;
				AppApiContext objApiContext = rObjSessionEnvironment.CreateApiContext();
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, item, Manuale: true, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
				if ((int)val2 > 0)
				{
					Warning += rsmess;
				}
				else
				{
					Warning += "OK";
				}
				Warning += "\r\n";
			}
			val = (FXRETURN)0;
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}
}
