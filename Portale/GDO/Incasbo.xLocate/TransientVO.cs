using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[XmlInclude(typeof(CallerContextProperty))]
[XmlInclude(typeof(CallerContext))]
[XmlInclude(typeof(Suggestion))]
[XmlInclude(typeof(SuggestionResponse))]
[XmlInclude(typeof(ResultObject))]
[XmlInclude(typeof(ObjectResponse))]
[XmlInclude(typeof(PoiAddressResponse))]
[XmlInclude(typeof(CombinedTransportResponse))]
[XmlInclude(typeof(AddressResponse))]
[XmlInclude(typeof(SearchOptionBase))]
[XmlInclude(typeof(NamedSearchOption))]
[XmlInclude(typeof(ReverseSearchOption))]
[XmlInclude(typeof(SearchOption))]
[XmlInclude(typeof(PoiSearchOption))]
[XmlInclude(typeof(SortOption))]
[XmlInclude(typeof(CombinedTransportLocation))]
[XmlInclude(typeof(ResultCombinedTransport))]
[XmlInclude(typeof(DatabaseFieldBase))]
[XmlInclude(typeof(DatabaseFieldInteger))]
[XmlInclude(typeof(DatabaseFieldBlob))]
[XmlInclude(typeof(DatabaseFieldFloat))]
[XmlInclude(typeof(DatabaseFieldString))]
[XmlInclude(typeof(AdditionalField))]
[XmlInclude(typeof(Address))]
[XmlInclude(typeof(ResultAddress))]
[XmlInclude(typeof(PoiResultAddress))]
[XmlInclude(typeof(PoiAddress))]
[XmlInclude(typeof(Location))]
[XmlInclude(typeof(PoiLocation))]
[XmlInclude(typeof(WatchOptions))]
[XmlInclude(typeof(OptimizationProgress))]
[XmlInclude(typeof(KeyFigures))]
[XmlInclude(typeof(ImprovementProgress))]
[XmlInclude(typeof(DistanceMatrixCalculationProgress))]
[XmlInclude(typeof(JobProgress))]
[XmlInclude(typeof(ZoneLoadingProgress))]
[XmlInclude(typeof(TerritoryProgress))]
[XmlInclude(typeof(ClusterProgress))]
[XmlInclude(typeof(PlanProgress))]
[XmlInclude(typeof(DistanceMatrixProgress))]
[XmlInclude(typeof(BulkProgress))]
[XmlInclude(typeof(Job))]
[XmlInclude(typeof(PlainGeometryBase))]
[XmlInclude(typeof(PlainGeometryCollection))]
[XmlInclude(typeof(PlainMultiPolygon))]
[XmlInclude(typeof(PlainMultiLineString))]
[XmlInclude(typeof(PlainMultiPoint))]
[XmlInclude(typeof(PlainLineString))]
[XmlInclude(typeof(PlainPolygon))]
[XmlInclude(typeof(PlainPoint))]
[XmlInclude(typeof(PlainLinearRing))]
[XmlInclude(typeof(KML))]
[XmlInclude(typeof(EncodedGeometryBase))]
[XmlInclude(typeof(EncodedGeometry))]
[XmlInclude(typeof(GeometryCollection))]
[XmlInclude(typeof(MultiPolygon))]
[XmlInclude(typeof(MultiLineString))]
[XmlInclude(typeof(MultiPoint))]
[XmlInclude(typeof(Point))]
[XmlInclude(typeof(LineString))]
[XmlInclude(typeof(Polygon))]
[XmlInclude(typeof(LinearRing))]
[XmlInclude(typeof(BoundingBox))]
[XmlInclude(typeof(RequestOptions))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://value.core.jabba.ptvag.com")]
public abstract class TransientVO : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
