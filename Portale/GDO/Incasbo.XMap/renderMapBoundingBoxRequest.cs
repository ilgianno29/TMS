using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "renderMapBoundingBox", WrapperNamespace = "http://types.xmap.xserver.ptvag.com", IsWrapped = true)]
public class renderMapBoundingBoxRequest
{
	[MessageBodyMember(Namespace = "http://types.xmap.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public BoundingBox BoundingBox_1;

	[MessageBodyMember(Namespace = "http://types.xmap.xserver.ptvag.com", Order = 1)]
	[XmlElement(IsNullable = true)]
	public MapParams MapParams_2;

	[MessageBodyMember(Namespace = "http://types.xmap.xserver.ptvag.com", Order = 2)]
	[XmlElement(IsNullable = true)]
	public ImageInfo ImageInfo_3;

	[MessageBodyMember(Namespace = "http://types.xmap.xserver.ptvag.com", Order = 3)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xmap.xserver.ptvag.com")]
	public Layer[] ArrayOfLayer_4;

	[MessageBodyMember(Namespace = "http://types.xmap.xserver.ptvag.com", Order = 4)]
	public bool boolean_5;

	[MessageBodyMember(Namespace = "http://types.xmap.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_6;

	public renderMapBoundingBoxRequest()
	{
	}

	public renderMapBoundingBoxRequest(BoundingBox BoundingBox_1, MapParams MapParams_2, ImageInfo ImageInfo_3, Layer[] ArrayOfLayer_4, bool boolean_5, CallerContext CallerContext_6)
	{
		this.BoundingBox_1 = BoundingBox_1;
		this.MapParams_2 = MapParams_2;
		this.ImageInfo_3 = ImageInfo_3;
		this.ArrayOfLayer_4 = ArrayOfLayer_4;
		this.boolean_5 = boolean_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
