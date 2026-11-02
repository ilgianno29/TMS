using System;
using System.Collections.Generic;
using System.Linq;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class SendMailAsync : AppAbstractApi
{
	protected SendMailInfo _MailInfo;

	public SendMailAsync(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override modGeneral.FXRETURN CheckData(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			_MailInfo = (SendMailInfo)ParametersIn["MailInfo"];
			fXRETURN2 = modGeneral.FXRETURN.OK;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN2;
		}
		return result;
	}

	protected override modGeneral.FXRETURN Core(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		string text = "";
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				CallStackAdd();
				rsmess = "";
				List<byte[]> list = new List<byte[]>();
				text = "INSERT INTO IBOMAILER_MAIL (MAILTO,MAILCC,MAILOBJECT,MAILTEXT,MAILTEXTFILE,MAILATTACHMENT,HTML,ISTANZA";
				int num = 0;
				do
				{
					text = text + ",MAILATTACHMENTBLOB" + num + ",MAILATTACHMENTBLOBEXTENSION" + num + ",MAILATTACHMENTBLOBFILENAME" + num;
					num++;
				}
				while (num <= 9);
				text += ") VALUES (";
				text = text + DbConn.SQLFormatString(_MailInfo.MailTo) + ",";
				text = text + DbConn.SQLFormatString(_MailInfo.MailCC) + ",";
				text = text + DbConn.SQLFormatString(_MailInfo.MailObject) + ",";
				text = text + DbConn.SQLFormatString(_MailInfo.MailText) + ",";
				text = text + DbConn.SQLFormatString(_MailInfo.MailTextFile) + ",";
				text = text + DbConn.SQLFormatString(_MailInfo.MailAttachment) + ",";
				text = text + DbConn.SQLFormatString(_MailInfo.Html ? "S" : "N") + ",";
				text += DbConn.SQLFormatString(_MailInfo.Istanza);
				int num2 = 0;
				do
				{
					byte[] array = (byte[])IncasReflection.GetPropertyValue(_MailInfo, "MailAttachmentBlob" + num2);
					string vsStringa = IncasReflection.GetPropertyValue(_MailInfo, "MailAttachmentBlobExtension" + num2).ToString();
					string vsStringa2 = IncasReflection.GetPropertyValue(_MailInfo, "MailAttachmentBlobFilename" + num2).ToString();
					if (array.Count() > 0)
					{
						text = text + ", :" + (num2 + 1) + " ";
						list.Add(array);
					}
					else
					{
						text += ", NULL";
					}
					text = text + "," + DbConn.SQLFormatString(vsStringa);
					text = text + "," + DbConn.SQLFormatString(vsStringa2);
					num2++;
				}
				while (num2 <= 9);
				text += ")";
				fXRETURN = DbConn.SqlExecBlobHelper(text, list, ref rsmess);
				fXRETURN2 = ((fXRETURN != 0) ? fXRETURN : modGeneral.FXRETURN.OK);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				fXRETURN2 = HandleError(ref objEx, ref rsmess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				CallStackRemove();
				result = fXRETURN2;
			}
			return result;
		}
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, SendMailInfo MailInfo, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			SendMailAsync sendMailAsync = new SendMailAsync(objApiContext);
			sendMailAsync.ParametersIn.Add("MailInfo", MailInfo);
			fXRETURN = sendMailAsync.Run(ref rsmess);
			fXRETURN2 = ((fXRETURN != 0) ? fXRETURN : modGeneral.FXRETURN.OK);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN2;
		}
		return result;
	}
}
