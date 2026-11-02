using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class IncasTranslator
{
	protected class WordPart
	{
		public string LeftPart;

		public string RightPart;

		public WordPart(string LeftP, string RightP)
		{
			LeftPart = "";
			RightPart = "";
			LeftPart = LeftP;
			RightPart = RightP;
		}
	}

	protected TranslatableItemDictonary _ItemDictionary;

	protected List<TranslatableItem> _UntranslatedItemDictionary;

	protected TimeSpan _ActivityTime;

	public string Language { get; set; }

	public bool Attivo { get; set; }

	public bool Debug { get; set; }

	public List<TranslatableItem> UntranslatedItemDictionary => _UntranslatedItemDictionary;

	public IncasTranslator(string sLanguage)
	{
		_ItemDictionary = new TranslatableItemDictonary();
		_UntranslatedItemDictionary = new List<TranslatableItem>();
		string language = "";
		Language = language;
		bool attivo = true;
		Attivo = attivo;
		attivo = true;
		Debug = attivo;
		_ActivityTime = default(TimeSpan);
		Language = sLanguage;
	}

	public void ResetActivityTime()
	{
		_ActivityTime = default(TimeSpan);
	}

	public TimeSpan GetActivityTime()
	{
		return _ActivityTime;
	}

	public void AddTranslatableItem(string Language, string Contesto, string Text, string TranslatedText)
	{
		TranslatableItem translatableItem = new TranslatableItem();
		translatableItem.Language = Language;
		translatableItem.Contesto = Contesto;
		translatableItem.Text = Text;
		translatableItem.TranslatedText = TranslatedText;
		if (!_ItemDictionary.ContainsKey(translatableItem))
		{
			_ItemDictionary.Add(translatableItem, translatableItem);
		}
	}

	public void ClearUntranslatedItemDictionary()
	{
		_UntranslatedItemDictionary.Clear();
	}

	public void ClearTranslatableItem()
	{
		_ItemDictionary.Clear();
	}

	private WordPart NormalizeForTranslator(string Parola)
	{
		string text = Parola.TrimEnd('!', ':', ' ', ',', ';', '?', '.');
		string rightP = Parola.Substring(text.Length);
		return new WordPart(text, rightP);
	}

	protected string _TranslateMessage(string Language, string Contesto, string Text, params string[] vParametri)
	{
		TranslatableItem translatableItem = new TranslatableItem();
		string text = "";
		TimeSpan timeSpan = default(TimeSpan);
		if (Debug)
		{
			timeSpan = new TimeSpan(DateAndTime.Now.Ticks);
		}
		if (Attivo)
		{
			if (Operators.CompareString(Text, "", false) == 0)
			{
				text = Text;
			}
			else
			{
				if (Operators.CompareString(Contesto.Trim(), "", false) == 0)
				{
					Contesto = "XXX";
				}
				translatableItem.Language = Language;
				translatableItem.Contesto = Contesto;
				WordPart wordPart = NormalizeForTranslator(Text);
				translatableItem.Text = wordPart.LeftPart;
				if (_ItemDictionary.ContainsKey(translatableItem))
				{
					text = _ItemDictionary[translatableItem].TranslatedText;
				}
				else
				{
					translatableItem.Contesto = "XXX";
					if (_ItemDictionary.ContainsKey(translatableItem))
					{
						text = _ItemDictionary[translatableItem].TranslatedText;
					}
					else
					{
						try
						{
							translatableItem.Contesto = Contesto;
							_UntranslatedItemDictionary.Add(translatableItem);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						text = wordPart.LeftPart;
					}
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					text = wordPart.LeftPart;
				}
				text += wordPart.RightPart;
			}
		}
		else
		{
			text = Text;
		}
		text = string.Format(text, vParametri);
		if (Debug)
		{
			TimeSpan activityTime = _ActivityTime;
			TimeSpan timeSpan2 = new TimeSpan(DateAndTime.Now.Ticks);
			_ActivityTime = activityTime + (timeSpan2 - timeSpan);
		}
		return text;
	}

	public string TranslateMessage(string Contesto, string Text, params string[] vParametri)
	{
		return _TranslateMessage(Language, Contesto, Text, vParametri);
	}

	public string Translate(string Contesto, string Text, params string[] vParametri)
	{
		return _TranslateMessage(Language, Contesto, Text, vParametri);
	}
}
