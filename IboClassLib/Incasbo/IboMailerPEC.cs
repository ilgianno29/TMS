using System;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Web.Mail;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

public class IboMailerPEC
{
	protected string _DestinatarioIndirizzo;

	protected string _DestinatarioCCIndirizzo;

	protected string _MittenteNome;

	protected string _MittenteEmail;

	protected string _SMTPServer;

	protected string _SMTPPort;

	protected string _MittenteUser;

	protected string _MittentePwd;

	protected string _Oggetto;

	protected string _Messaggio;

	protected string _MessaggioFile;

	protected StringCollection _Allegati;

	protected bool _EnabledSSL;

	protected bool _isBodyHtml;

	protected MailMessage _mex;

	protected string _destAddress;

	protected string _ccAddress;

	protected MailAttachment _attachment;

	public IboMailerPEC(string sDestinatarioIndirizzo, string sMittenteNome, string sMittenteEmail, string sDestinatarioCCIndirizzo, string sSMTPServer, string sSMTPPort, bool bEnabledSSL, string sMittenteUser, string sMittentePwd, string sOggetto, string sMessaggio, string sMessaggioFile, bool isBodyHtml, ref StringCollection Allegati)
	{
		_DestinatarioIndirizzo = "";
		_DestinatarioCCIndirizzo = "";
		_MittenteNome = "";
		_MittenteEmail = "";
		_SMTPServer = "";
		_SMTPPort = "";
		_MittenteUser = "";
		_MittentePwd = "";
		_Oggetto = "";
		_Messaggio = "";
		_MessaggioFile = "";
		_Allegati = null;
		_EnabledSSL = false;
		_isBodyHtml = false;
		_mex = null;
		_attachment = null;
		_DestinatarioIndirizzo = sDestinatarioIndirizzo;
		_DestinatarioCCIndirizzo = sDestinatarioCCIndirizzo;
		_MittenteNome = sMittenteNome;
		_MittenteEmail = sMittenteEmail;
		_SMTPServer = sSMTPServer;
		_SMTPPort = sSMTPPort;
		_EnabledSSL = bEnabledSSL;
		_MittenteUser = sMittenteUser;
		_MittentePwd = sMittentePwd;
		_Oggetto = sOggetto;
		_Messaggio = sMessaggio;
		_MessaggioFile = sMessaggioFile;
		_Allegati = Allegati;
		_isBodyHtml = isBodyHtml;
	}

	public bool Invia(ref string smess)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		string text = "";
		bool result = default(bool);
		try
		{
			result = false;
			smess = "";
			_mex = new MailMessage();
			_mex.BodyEncoding = Encoding.Default;
			if (_isBodyHtml)
			{
				_mex.BodyFormat = (MailFormat)1;
			}
			else
			{
				_mex.BodyFormat = (MailFormat)0;
			}
			_mex.Subject = Strings.Replace(_Oggetto, "\r\n", " ", 1, -1, (CompareMethod)0);
			_mex.From = _MittenteEmail;
			if (Operators.CompareString(_MessaggioFile, "", false) != 0)
			{
				text = File.ReadAllText(_MessaggioFile);
			}
			if (Operators.CompareString(_Messaggio, "", false) != 0)
			{
				text = _Messaggio + "\r\n" + text;
			}
			if (_isBodyHtml)
			{
				text = Strings.Replace(GetHtmlModel(), "<%BODY%>", text, 1, -1, (CompareMethod)0);
			}
			_mex.Body = Strings.Replace(text, "\r\n", "\r", 1, -1, (CompareMethod)0);
			_mex.To = _DestinatarioIndirizzo;
			_mex.Cc = _DestinatarioCCIndirizzo;
			_mex.Priority = (MailPriority)2;
			if (_Allegati != null)
			{
				StringEnumerator enumerator = _Allegati.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (Operators.CompareString(current, "", false) != 0)
					{
						_attachment = new MailAttachment(current);
						_mex.Attachments.Add(_attachment);
						_attachment = null;
					}
				}
			}
			_mex.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserver", _SMTPServer);
			if (!Versioned.IsNumeric((object)_SMTPPort))
			{
				_SMTPPort = "465";
			}
			_mex.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", _SMTPPort);
			_mex.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", "2");
			_mex.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
			_mex.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", _MittenteUser);
			_mex.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", _MittentePwd);
			_mex.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
			SmtpMail.SmtpServer = _SMTPServer + ":" + _SMTPPort;
			SmtpMail.Send(_mex);
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			smess = ex2.ToString();
			ProjectData.ClearProjectError();
		}
		finally
		{
			_mex = null;
		}
		return result;
	}

	protected string GetHtmlModel()
	{
		string text = "";
		return "<html xmlns=\"http://www.w3.org/1999/xhtml\"><head><title>Titolo documento</title></head><body><%BODY%></body></html>";
	}
}
