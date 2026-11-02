using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class IniFile
{
	public class IniSection
	{
		public class IniKey
		{
			private string m_sKey;

			private string m_sValue;

			private IniSection m_section;

			public string Name => m_sKey;

			public string Value
			{
				get
				{
					return m_sValue;
				}
				set
				{
					m_sValue = value;
				}
			}

			protected internal IniKey(IniSection parent, string sKey)
			{
				m_section = parent;
				m_sKey = sKey;
			}

			public void SetValue(string sValue)
			{
				m_sValue = sValue;
			}

			public string GetValue()
			{
				return m_sValue;
			}

			public bool SetName(string sKey)
			{
				sKey = sKey.Trim();
				if (sKey.Length != 0)
				{
					IniKey key = m_section.GetKey(sKey);
					if (key != this && key != null)
					{
						return false;
					}
					try
					{
						m_section.m_keys.Remove(m_sKey);
						m_section.m_keys[sKey] = this;
						m_sKey = sKey;
						return true;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				return false;
			}

			public string GetName()
			{
				return m_sKey;
			}
		}

		private IniFile m_pIniFile;

		private string m_sSection;

		private Hashtable m_keys;

		public ICollection Keys => m_keys.Values;

		public string Name => m_sSection;

		protected internal IniSection(IniFile parent, string sSection)
		{
			m_pIniFile = parent;
			m_sSection = sSection;
			m_keys = new Hashtable(StringComparer.InvariantCultureIgnoreCase);
		}

		public IniKey AddKey(string sKey)
		{
			sKey = sKey.Trim();
			IniKey iniKey = null;
			if (sKey.Length != 0)
			{
				if (m_keys.ContainsKey(sKey))
				{
					iniKey = (IniKey)m_keys[sKey];
				}
				else
				{
					iniKey = new IniKey(this, sKey);
					m_keys[sKey] = iniKey;
				}
			}
			return iniKey;
		}

		public bool RemoveKey(string sKey)
		{
			return RemoveKey(GetKey(sKey));
		}

		public bool RemoveKey(IniKey Key)
		{
			if (Key != null)
			{
				try
				{
					m_keys.Remove(Key.Name);
					return true;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			return false;
		}

		public bool RemoveAllKeys()
		{
			m_keys.Clear();
			return m_keys.Count == 0;
		}

		public IniKey GetKey(string sKey)
		{
			sKey = sKey.Trim();
			if (m_keys.ContainsKey(sKey))
			{
				return (IniKey)m_keys[sKey];
			}
			return null;
		}

		public bool SetName(string sSection)
		{
			sSection = sSection.Trim();
			if (sSection.Length != 0)
			{
				IniSection section = m_pIniFile.GetSection(sSection);
				if (section != this && section != null)
				{
					return false;
				}
				try
				{
					m_pIniFile.m_sections.Remove(m_sSection);
					m_pIniFile.m_sections[sSection] = this;
					m_sSection = sSection;
					return true;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			return false;
		}

		public string GetName()
		{
			return m_sSection;
		}
	}

	private Hashtable m_sections;

	public ICollection Sections => m_sections.Values;

	public IniFile()
	{
		m_sections = new Hashtable(StringComparer.InvariantCultureIgnoreCase);
	}

	public void Load(string sFileName, bool bMerge = false)
	{
		if (!bMerge)
		{
			RemoveAllSections();
		}
		IniSection iniSection = null;
		StreamReader streamReader = new StreamReader(sFileName);
		Regex regex = new Regex("^([\\s]*#.*)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		Regex regex2 = new Regex("^[\\s]*\\[[\\s]*([^\\[\\s].*[^\\s\\]])[\\s]*\\][\\s]*$", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		Regex regex3 = new Regex("^\\s*([^=\\s]*)[^=]*=(.*)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		while (!streamReader.EndOfStream)
		{
			string text = streamReader.ReadLine();
			if (Operators.CompareString(text, string.Empty, false) != 0)
			{
				Match match = null;
				if (regex.Match(text).Success)
				{
					match = regex.Match(text);
				}
				else if (regex2.Match(text).Success)
				{
					match = regex2.Match(text);
					iniSection = AddSection(match.Groups[1].Value);
				}
				else if (regex3.Match(text).Success && iniSection != null)
				{
					match = regex3.Match(text);
					iniSection.AddKey(match.Groups[1].Value).Value = match.Groups[2].Value;
				}
				else
				{
					iniSection?.AddKey(text);
				}
			}
		}
		streamReader.Close();
	}

	public void Save(string sFileName)
	{
		StreamWriter streamWriter = new StreamWriter(sFileName, append: false);
		foreach (IniSection section in Sections)
		{
			streamWriter.WriteLine($"[{section.Name}]");
			foreach (IniSection.IniKey key in section.Keys)
			{
				if (Operators.CompareString(key.Value, string.Empty, false) != 0)
				{
					streamWriter.WriteLine($"{key.Name}={key.Value}");
				}
				else
				{
					streamWriter.WriteLine($"{key.Name}");
				}
			}
		}
		streamWriter.Close();
	}

	public IniSection AddSection(string sSection)
	{
		IniSection iniSection = null;
		sSection = sSection.Trim();
		if (m_sections.ContainsKey(sSection))
		{
			iniSection = (IniSection)m_sections[sSection];
		}
		else
		{
			iniSection = new IniSection(this, sSection);
			m_sections[sSection] = iniSection;
		}
		return iniSection;
	}

	public bool RemoveSection(string sSection)
	{
		sSection = sSection.Trim();
		return RemoveSection(GetSection(sSection));
	}

	public bool RemoveSection(IniSection Section)
	{
		if (Section != null)
		{
			try
			{
				m_sections.Remove(Section.Name);
				return true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		return false;
	}

	public bool RemoveAllSections()
	{
		m_sections.Clear();
		return m_sections.Count == 0;
	}

	public IniSection GetSection(string sSection)
	{
		sSection = sSection.Trim();
		if (m_sections.ContainsKey(sSection))
		{
			return (IniSection)m_sections[sSection];
		}
		return null;
	}

	public string GetKeyValue(string sSection, string sKey)
	{
		IniSection section = GetSection(sSection);
		if (section != null)
		{
			IniSection.IniKey key = section.GetKey(sKey);
			if (key != null)
			{
				return key.Value.Trim();
			}
		}
		return null;
	}

	public bool SetKeyValue(string sSection, string sKey, string sValue)
	{
		IniSection iniSection = AddSection(sSection);
		if (iniSection != null)
		{
			IniSection.IniKey iniKey = iniSection.AddKey(sKey);
			if (iniKey != null)
			{
				iniKey.Value = sValue;
				return true;
			}
		}
		return false;
	}

	public bool RenameSection(string sSection, string sNewSection)
	{
		bool result = false;
		IniSection section = GetSection(sSection);
		if (section != null)
		{
			result = section.SetName(sNewSection);
		}
		return result;
	}

	public bool RenameKey(string sSection, string sKey, string sNewKey)
	{
		IniSection section = GetSection(sSection);
		if (section != null)
		{
			IniSection.IniKey key = section.GetKey(sKey);
			if (key != null)
			{
				return key.SetName(sNewKey);
			}
		}
		return false;
	}

	public bool RemoveKey(string sSection, string sKey)
	{
		return GetSection(sSection)?.RemoveKey(sKey) ?? false;
	}
}
