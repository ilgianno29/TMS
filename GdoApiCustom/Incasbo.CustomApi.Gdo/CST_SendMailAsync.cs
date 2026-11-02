using System;
using System.Collections.Generic;
using System.Linq;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.CustomApi.Gdo;

public class CST_SendMailAsync : AppAbstractApi
{
	protected CST_SendMailInfo _MailInfo;

	public CST_SendMailAsync(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_MailInfo = (CST_SendMailInfo)((AppAbstractApi)this).ParametersIn["MailInfo"];
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
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Invalid comparison between Unknown and I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			List<byte[]> list = new List<byte[]>();
			text = "INSERT INTO IBOMAILER_MAIL (MittenteNome, MittenteEmail, SMTPEnableSSL,MAILTO,MAILCC,MAILOBJECT,MAILTEXT,MAILTEXTFILE,MAILATTACHMENT,HTML,ISTANZA";
			int num = 0;
			checked
			{
				do
				{
					text = text + ",MAILATTACHMENTBLOB" + num + ",MAILATTACHMENTBLOBEXTENSION" + num + ",MAILATTACHMENTBLOBFILENAME" + num;
					num++;
				}
				while (num <= 9);
				text += ") VALUES (";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_MailInfo.MittenteNome) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_MailInfo.MittenteEmail) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_MailInfo.SMTPEnableSSL) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(((SendMailInfo)_MailInfo).MailTo) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(((SendMailInfo)_MailInfo).MailCC) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(((SendMailInfo)_MailInfo).MailObject) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(((SendMailInfo)_MailInfo).MailText) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(((SendMailInfo)_MailInfo).MailTextFile) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(((SendMailInfo)_MailInfo).MailAttachment) + ",";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(((SendMailInfo)_MailInfo).Html ? "S" : "N") + ",";
				text += ((AppBaseClass)this).DbConn.SQLFormatString(((SendMailInfo)_MailInfo).Istanza);
				int num2 = 0;
				do
				{
					byte[] array = (byte[])IncasReflection.GetPropertyValue((object)_MailInfo, "MailAttachmentBlob" + num2);
					string vsStringa = IncasReflection.GetPropertyValue((object)_MailInfo, "MailAttachmentBlobExtension" + num2).ToString();
					string vsStringa2 = IncasReflection.GetPropertyValue((object)_MailInfo, "MailAttachmentBlobFilename" + num2).ToString();
					if (array.Count() > 0)
					{
						text = text + ", :" + (num2 + 1) + " ";
						list.Add(array);
					}
					else
					{
						text += ", NULL";
					}
					text = text + "," + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa);
					text = text + "," + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa2);
					num2++;
				}
				while (num2 <= 9);
				text += ")";
				val = ((AppBaseClass)this).DbConn.SqlExecBlobHelper(text, list, ref rsmess);
			}
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	public static FXRETURN RunProc(AppApiContext objApiContext, CST_SendMailInfo MailInfo, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CST_SendMailAsync cST_SendMailAsync = new CST_SendMailAsync(objApiContext);
			((AppAbstractApi)cST_SendMailAsync).ParametersIn.Add("MailInfo", MailInfo);
			val = ((AppAbstractApi)cST_SendMailAsync).Run(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
			result = val2;
		}
		return result;
	}
}
