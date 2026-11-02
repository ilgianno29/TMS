using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class IboMailer
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

	protected MailAddress _destAddress;

	protected MailAddress _ccAddress;

	protected Attachment _attachment;

	protected MailAddress author;

	public IboMailer(string sDestinatarioIndirizzo, string sMittenteNome, string sMittenteEmail, string sDestinatarioCCIndirizzo, string sSMTPServer, string sSMTPPort, bool bEnabledSSL, string sMittenteUser, string sMittentePwd, string sOggetto, string sMessaggio, string sMessaggioFile, bool isBodyHtml, ref StringCollection Allegati)
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
		_DestinatarioIndirizzo = sDestinatarioIndirizzo;
		_DestinatarioCCIndirizzo = sDestinatarioCCIndirizzo;
		_MittenteNome = sMittenteNome;
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
		author = new MailAddress(sMittenteEmail, sMittenteNome);
	}

	public bool Invia(ref string smess)
	{
		string text = "";
		bool result = default(bool);
		try
		{
			result = false;
			smess = "";
			_mex = new MailMessage();
			_mex.BodyEncoding = Encoding.Default;
			_mex.IsBodyHtml = _isBodyHtml;
			_mex.Subject = Strings.Replace(_Oggetto, "\r\n", " ", 1, -1, (CompareMethod)0);
			_mex.Sender = author;
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
			text = Strings.Replace(text, "<%CRLF%>", "\r\n", 1, -1, (CompareMethod)0);
			_mex.Body = Strings.Replace(text, "\r\n", "\r", 1, -1, (CompareMethod)0);
			_mex.From = author;
			_mex.ReplyTo = author;
			string[] array = Strings.Split(_DestinatarioIndirizzo, ";", -1, (CompareMethod)0);
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (Operators.CompareString(text2, "", false) != 0)
				{
					_destAddress = new MailAddress(text2);
					_mex.To.Add(_destAddress);
				}
			}
			if (Operators.CompareString(_DestinatarioCCIndirizzo, "", false) != 0)
			{
				string[] array3 = Strings.Split(_DestinatarioCCIndirizzo, ";", -1, (CompareMethod)0);
				string[] array4 = array3;
				foreach (string text3 in array4)
				{
					if (Operators.CompareString(text3, "", false) != 0)
					{
						_ccAddress = new MailAddress(text3);
						_mex.CC.Add(_ccAddress);
					}
				}
			}
			_mex.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
			if (_Allegati != null)
			{
				StringEnumerator enumerator = _Allegati.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (Operators.CompareString(current, "", false) != 0)
					{
						_attachment = new Attachment(current);
						_mex.Attachments.Add(_attachment);
						_attachment = null;
					}
				}
			}
			SmtpClient smtpClient = ((!Versioned.IsNumeric((object)_SMTPPort)) ? new SmtpClient(_SMTPServer) : new SmtpClient(_SMTPServer, Conversions.ToInteger(_SMTPPort)));
			smtpClient.EnableSsl = _EnabledSSL;
			smtpClient.Timeout = 30000;
			smtpClient.Credentials = new NetworkCredential(_MittenteUser, _MittentePwd);
			smtpClient.Send(_mex);
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
			_mex.Dispose();
			_mex = null;
		}
		return result;
	}

	protected string GetHtmlModel()
	{
		string text = "";
		return "<!DOCTYPE html><html xmlns=\"http://www.w3.org/1999/xhtml\"><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/><title>NoTitle</title></head><body><%BODY%></body></html>";
	}

	public static modGeneral.FXRETURN IsValidEmail(string strEmail, ref string rsMess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		Regex regex = new Regex("\\S+@\\S+\\.\\S+");
		modGeneral.FXRETURN result;
		try
		{
			rsMess = "";
			if (Operators.CompareString(strEmail, "", false) != 0 && !regex.IsMatch(strEmail))
			{
				rsMess = strEmail + " is a not valid E-mail";
			}
			else
			{
				fXRETURN = modGeneral.FXRETURN.OK;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
		}
		return result;
	}

	public static bool IsValidEmail(string strEmail)
	{
		string rsMess = "";
		return IsValidEmail(strEmail, ref rsMess) == modGeneral.FXRETURN.OK;
	}
}
