// STUB di Crystal Reports: solo le firme usate dal portale, per poter compilare
// senza il runtime Crystal installato. Ogni metodo lancia NotSupportedException.
// NON usare in produzione: copiare le DLL reali in lib/Crystal.
using System;
using System.Collections;
using System.ComponentModel;

namespace CrystalDecisions.Shared
{
	public enum ExportFormatType { NoFormat = 0, CrystalReport = 1, RichText = 2, WordForWindows = 3, Excel = 4, PortableDocFormat = 5, HTML32 = 6, HTML40 = 7, ExcelRecord = 8, Text = 9, CharacterSeparatedValues = 10, TabSeperatedText = 11, EditableRTF = 12, Xml = 13, RPTR = 14, ExcelWorkbook = 15 }
	public enum ExportDestinationType { NoDestination = 0, DiskFile = 1, ExchangeFolder = 2, MicrosoftMail = 3 }
	public class ExportFormatOptions { }
	public class ExportDestinationOptions { }
	public class DiskFileDestinationOptions : ExportDestinationOptions { public string DiskFileName { get; set; } }
	public class ExportOptions
	{
		public ExportFormatType ExportFormatType { get; set; }
		public ExportDestinationType ExportDestinationType { get; set; }
		public ExportDestinationOptions ExportDestinationOptions { get; set; }
		public ExportFormatOptions ExportFormatOptions { get; set; }
		public static ExportFormatOptions CreatePdfRtfWordFormatOptions() => throw new NotSupportedException();
		public static ExportFormatOptions CreateExcelFormatOptions() => throw new NotSupportedException();
		public static ExportFormatOptions CreateCharacterSeparatedValuesFormatOptions() => throw new NotSupportedException();
		public static DiskFileDestinationOptions CreateDiskFileDestinationOptions() => throw new NotSupportedException();
	}
	public class ConnectionInfo
	{
		public string ServerName { get; set; }
		public string DatabaseName { get; set; }
		public string UserID { get; set; }
		public string Password { get; set; }
		public bool IntegratedSecurity { get; set; }
		public ConnectionInfoType Type { get; set; }
	}
	public enum ConnectionInfoType { Unknown = 0, SQL = 1, CRQE = 2, MetaData = 3 }
	public class TableLogOnInfo { public ConnectionInfo ConnectionInfo { get; set; } = new ConnectionInfo(); public string TableName { get; set; } }
	public class ParameterValue { }
	public class ParameterDiscreteValue : ParameterValue { public object Value { get; set; } }
	public class ParameterValues : CollectionBase { public int Add(ParameterValue value) => List.Add(value); public void AddValue(object value) => List.Add(new ParameterDiscreteValue { Value = value }); }
	public class ParameterField { public string Name { get; set; } public ParameterValues CurrentValues { get; set; } = new ParameterValues(); }
	public class ParameterFields : CollectionBase { public int Add(ParameterField field) => List.Add(field); public ParameterField this[int index] => (ParameterField)List[index]; }
	public class RequestContext { }
}

namespace CrystalDecisions.ReportSource
{
	using CrystalDecisions.Shared;
	public interface ICachedReport
	{
		bool IsCacheable { get; set; }
		bool ShareDBLogonInfo { get; set; }
		TimeSpan CacheTimeOut { get; set; }
		CrystalDecisions.CrystalReports.Engine.ReportDocument CreateReport();
		string GetCustomizedCacheKey(RequestContext request);
	}
	public static class CachedReportConstants { public static readonly TimeSpan DEFAULT_TIMEOUT = TimeSpan.FromHours(6); }
}

namespace CrystalDecisions.CrystalReports.Engine
{
	using CrystalDecisions.Shared;
	public class SCRCollection : CollectionBase { }
	public class FieldDefinition { public string Name { get; set; } }
	public class FieldDefinitions : SCRCollection { public FieldDefinition this[int index] => (FieldDefinition)List[index]; }
	public class Section { public string Name { get; set; } }
	public class Sections : CollectionBase { public Section this[int index] => (Section)List[index]; public Section this[string name] => throw new NotSupportedException(); }
	public class ReportDefinition { public Sections Sections { get; } = new Sections(); }
	public class ReportOptions { public bool EnableSaveDataWithReport { get; set; } }
	public class Table { public string Name { get; set; } public string Location { get; set; } public TableLogOnInfo LogOnInfo { get; } = new TableLogOnInfo(); public void ApplyLogOnInfo(TableLogOnInfo info) => throw new NotSupportedException(); }
	public class Tables : SCRCollection { public Table this[int index] => (Table)List[index]; }
	public class Database { public Tables Tables { get; } = new Tables(); }
	public class ParameterFieldDefinition : FieldDefinition { public string ParameterFieldName { get; set; } public void ApplyCurrentValues(ParameterValues values) => throw new NotSupportedException(); public ParameterValues CurrentValues { get; } = new ParameterValues(); }
	public class ParameterFieldDefinitions : FieldDefinitions { public new ParameterFieldDefinition this[int index] => (ParameterFieldDefinition)List[index]; public ParameterFieldDefinition this[string name] => throw new NotSupportedException(); }
	public class FormulaFieldDefinition : FieldDefinition { public string FormulaName { get; set; } public string Text { get; set; } }
	public class FormulaFieldDefinitions : FieldDefinitions { public new FormulaFieldDefinition this[int index] => (FormulaFieldDefinition)List[index]; public FormulaFieldDefinition this[string name] => throw new NotSupportedException(); }
	public class DataDefinition { public ParameterFieldDefinitions ParameterFields { get; } = new ParameterFieldDefinitions(); public FormulaFieldDefinitions FormulaFields { get; } = new FormulaFieldDefinitions(); public string RecordSelectionFormula { get; set; } }
	public class ReportDocuments : CollectionBase { public ReportDocument this[int index] => (ReportDocument)List[index]; public ReportDocument this[string name] => throw new NotSupportedException(); }
	public class ReportDocument : Component
	{
		public virtual ReportDefinition ReportDefinition { get; } = new ReportDefinition();
		public virtual ReportOptions ReportOptions { get; } = new ReportOptions();
		public virtual Database Database { get; } = new Database();
		public virtual DataDefinition DataDefinition { get; } = new DataDefinition();
		public virtual ParameterFields ParameterFields { get; } = new ParameterFields();
		public virtual ReportDocuments Subreports { get; } = new ReportDocuments();
		public virtual ExportOptions ExportOptions { get; } = new ExportOptions();
		public virtual string RecordSelectionFormula { get; set; }
		public virtual string FileName { get; set; }
		public virtual bool IsLoaded => false;
		public virtual void Load(string filename) => throw new NotSupportedException();
		public virtual void SetDataSource(object dataSource) => throw new NotSupportedException();
		public virtual void SetDatabaseLogon(string user, string password) => throw new NotSupportedException();
		public virtual void SetDatabaseLogon(string user, string password, string server, string database) => throw new NotSupportedException();
		public virtual void SetParameterValue(string name, object value) => throw new NotSupportedException();
		public virtual void SetParameterValue(int index, object value) => throw new NotSupportedException();
		public virtual void Export() => throw new NotSupportedException();
		public virtual void Export(ExportOptions options) => throw new NotSupportedException();
		public virtual void ExportToDisk(ExportFormatType formatType, string fileName) => throw new NotSupportedException();
		public virtual System.IO.Stream ExportToStream(ExportFormatType formatType) => throw new NotSupportedException();
		public virtual void Refresh() => throw new NotSupportedException();
		public virtual void Close() => throw new NotSupportedException();
	}
	public class ReportClass : ReportDocument
	{
		public virtual string ResourceName { get; set; }
		public virtual bool NewGenerator { get; set; }
		public virtual string FullResourceName { get; set; }
	}
}

namespace CrystalDecisions.Web
{
	using CrystalDecisions.Shared;
	public class CrystalReportViewerBase : System.Web.UI.WebControls.WebControl
	{
		public string SelectionFormula { get; set; }
		public object ReportSource { get; set; }
		public bool HasDrillUpButton { get; set; }
		public bool HasSearchButton { get; set; }
		public bool HasZoomFactorList { get; set; }
		public bool HasPageNavigationButtons { get; set; }
		public bool HasGotoPageButton { get; set; }
		public bool HasDrilldownTabs { get; set; }
		public bool EnableDrillDown { get; set; }
	}
	public class CrystalReportViewer : CrystalReportViewerBase
	{
		public ParameterFields ParameterFieldInfo { get; set; }
		public bool HasToggleGroupTreeButton { get; set; }
		public bool HasCrystalLogo { get; set; }
		public bool EnableDatabaseLogonPrompt { get; set; }
		public bool EnableParameterPrompt { get; set; }
		public bool DisplayToolbar { get; set; }
		public bool HasPrintButton { get; set; }
		public bool HasExportButton { get; set; }
		public bool BestFitPage { get; set; }
		public string ToolPanelView { get; set; }
		public void RefreshReport() => throw new NotSupportedException();
		public void Dispose(bool disposing) { }
	}
	public class Report { public string FileName { get; set; } }
	public class CrystalReportSource : System.Web.UI.Control
	{
		public Report Report { get; } = new Report();
		public CrystalDecisions.CrystalReports.Engine.ReportDocument ReportDocument { get; } = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
		public bool EnableCaching { get; set; }
	}
}
