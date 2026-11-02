using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Incasbo.XMap;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(Namespace = "http://jwsdp.xmap.xserver.ptvag.com", ConfigurationName = "XMap.XMapWS")]
public interface XMapWS
{
	[OperationContract(Action = "", ReplyAction = "*")]
	[FaultContract(typeof(XServiceException), Action = "", Name = "XServiceException", Namespace = "http://common.xserver.ptvag.com")]
	[FaultContract(typeof(TableNotFoundException), Action = "", Name = "TableNotFoundException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(UnexpectedException), Action = "", Name = "UnexpectedException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(SystemException), Action = "", Name = "SystemException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(OptimisticRollbackException), Action = "", Name = "OptimisticRollbackException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(ConstraintViolationException), Action = "", Name = "ConstraintViolationException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(DatabaseException), Action = "", Name = "DatabaseException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(XMapException), Action = "", Name = "XMapException", Namespace = "http://xmap.xserver.ptvag.com")]
	[XmlSerializerFormat(SupportFaults = true)]
	[ServiceKnownType(typeof(BaseException))]
	[ServiceKnownType(typeof(TransientVO))]
	renderMapResponse renderMap(renderMapRequest request);

	[OperationContract(Action = "", ReplyAction = "*")]
	[FaultContract(typeof(XServiceException), Action = "", Name = "XServiceException", Namespace = "http://common.xserver.ptvag.com")]
	[FaultContract(typeof(TableNotFoundException), Action = "", Name = "TableNotFoundException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(UnexpectedException), Action = "", Name = "UnexpectedException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(SystemException), Action = "", Name = "SystemException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(OptimisticRollbackException), Action = "", Name = "OptimisticRollbackException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(ConstraintViolationException), Action = "", Name = "ConstraintViolationException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(DatabaseException), Action = "", Name = "DatabaseException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(XMapException), Action = "", Name = "XMapException", Namespace = "http://xmap.xserver.ptvag.com")]
	[XmlSerializerFormat(SupportFaults = true)]
	[ServiceKnownType(typeof(BaseException))]
	[ServiceKnownType(typeof(TransientVO))]
	renderMapBoundingBoxResponse renderMapBoundingBox(renderMapBoundingBoxRequest request);

	[OperationContract(Action = "", ReplyAction = "*")]
	[FaultContract(typeof(XServiceException), Action = "", Name = "XServiceException", Namespace = "http://common.xserver.ptvag.com")]
	[FaultContract(typeof(TableNotFoundException), Action = "", Name = "TableNotFoundException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(UnexpectedException), Action = "", Name = "UnexpectedException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(SystemException), Action = "", Name = "SystemException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(OptimisticRollbackException), Action = "", Name = "OptimisticRollbackException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(ConstraintViolationException), Action = "", Name = "ConstraintViolationException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(DatabaseException), Action = "", Name = "DatabaseException", Namespace = "http://exception.core.jabba.ptvag.com")]
	[FaultContract(typeof(XMapException), Action = "", Name = "XMapException", Namespace = "http://xmap.xserver.ptvag.com")]
	[XmlSerializerFormat(SupportFaults = true)]
	[ServiceKnownType(typeof(BaseException))]
	[ServiceKnownType(typeof(TransientVO))]
	renderMapRotResponse renderMapRot(renderMapRotRequest request);
}
