using System.Collections.Generic;
using Incasbo.Api.App;
using Incasbo.Api.Params;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

public abstract class WMSAbstractApi : AppAbstractApi
{
	protected class WMSMessageConfig
	{
		public static Dictionary<WMSMessageType, bool> WmsMessageEnabled { get; set; }

		public static string WmsUMPeso { get; set; }

		public static string WmsUMVolume { get; set; }

		static WMSMessageConfig()
		{
			Dictionary<WMSMessageType, bool> wmsMessageEnabled = new Dictionary<WMSMessageType, bool>();
			WmsMessageEnabled = wmsMessageEnabled;
			string wmsUMPeso = "G";
			WmsUMPeso = wmsUMPeso;
			wmsUMPeso = "CM3";
			WmsUMVolume = wmsUMPeso;
		}

		public static void Init(ref AppParams appParams)
		{
			if (WmsMessageEnabled.Count == 0)
			{
				WmsMessageEnabled.Add(WMSMessageType.UnKnown, value: false);
				ApplicationParams applicationParams = (ApplicationParams)(object)appParams;
				WmsMessageEnabled.Add(WMSMessageType.AssegnaSequenzaConsegnaOrdine, Operators.CompareString(applicationParams.WmsMethodEnabled("AssegnaSequenzaConsegnaOrdine"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.AssociaSpedizioneABatch, Operators.CompareString(applicationParams.WmsMethodEnabled("AssociaSpedizioneABatch"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.AssociaSpedizioneAViaggio, Operators.CompareString(applicationParams.WmsMethodEnabled("AssociaSpedizioneAViaggio"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.AssociaSpedizioneAViaggioChiuso, Operators.CompareString(applicationParams.WmsMethodEnabled("AssociaSpedizioneAViaggioChiuso"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.CalcolaNumeroPalletSagome, Operators.CompareString(applicationParams.WmsMethodEnabled("CalcolaNumeroPalletSagome"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.CreazioneBatch, Operators.CompareString(applicationParams.WmsMethodEnabled("CreazioneBatch"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.CreazioneViaggio, Operators.CompareString(applicationParams.WmsMethodEnabled("CreazioneViaggio"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.CancellazioneViaggio, Operators.CompareString(applicationParams.WmsMethodEnabled("CancellazioneViaggio"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.RiapriViaggio, Operators.CompareString(applicationParams.WmsMethodEnabled("RiapriViaggio"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.DisassociaSpedizioneABatch, Operators.CompareString(applicationParams.WmsMethodEnabled("DisassociaSpedizioneABatch"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.DisassociaSpedizioneAViaggio, Operators.CompareString(applicationParams.WmsMethodEnabled("DisassociaSpedizioneAViaggio"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.DisassociaSpedizioneAViaggioChiuso, Operators.CompareString(applicationParams.WmsMethodEnabled("DisassociaSpedizioneAViaggioChiuso"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.AggiornaQuantitaSpedizione, Operators.CompareString(applicationParams.WmsMethodEnabled("AggiornaQuantitaSpedizione"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.CalcolaNumeroPalletSagomeViaggio, Operators.CompareString(applicationParams.WmsMethodEnabled("CalcolaNumeroPalletSagomeViaggio"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.AssociaSpedizioneALinea, Operators.CompareString(applicationParams.WmsMethodEnabled("AssociaSpedizioneALinea"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.DisassociaSpedizioneALinea, Operators.CompareString(applicationParams.WmsMethodEnabled("DisassociaSpedizioneALinea"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.CreaViaggio_AssociaSpedizioniAViaggio, Operators.CompareString(applicationParams.WmsMethodEnabled("CreaViaggio_AssociaSpedizioniAViaggio"), "S", false) == 0);
				WmsMessageEnabled.Add(WMSMessageType.RichiesteVolumetrichePerRaggruppamentoOrdini, Operators.CompareString(applicationParams.WmsMethodEnabled("RichiesteVolumetrichePerRaggruppamentoOrdini"), "S", false) == 0);
				WmsUMPeso = applicationParams.WmsGetParams("UMPeso");
				if (Operators.CompareString(WmsUMPeso, "", false) == 0)
				{
					WmsUMPeso = "G";
				}
				WmsUMVolume = applicationParams.WmsGetParams("UMVolume");
				if (Operators.CompareString(WmsUMVolume, "", false) == 0)
				{
					WmsUMVolume = "CM3";
				}
			}
		}
	}

	public WMSAbstractApi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		this._LogFileName = "WMSApi_%USER%.log";
		this._AlwaysInsert = true;
	}
}
