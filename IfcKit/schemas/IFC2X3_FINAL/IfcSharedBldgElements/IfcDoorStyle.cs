// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("56391c72-81c3-43aa-a74e-4217b2dc660e")]
	public partial class IfcDoorStyle : IfcTypeProduct
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcDoorStyleOperationEnum _OperationType;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcDoorStyleConstructionEnum _ConstructionType;
	
		[DataMember(Order=2)] 
		[Required()]
		Boolean _ParameterTakesPrecedence;
	
		[DataMember(Order=3)] 
		[Required()]
		Boolean _Sizeable;
	
	
		public IfcDoorStyle()
		{
		}
	
		public IfcDoorStyle(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcLabel? __ApplicableOccurrence, IfcPropertySetDefinition[] __HasPropertySets, IfcRepresentationMap[] __RepresentationMaps, IfcLabel? __Tag, IfcDoorStyleOperationEnum __OperationType, IfcDoorStyleConstructionEnum __ConstructionType, Boolean __ParameterTakesPrecedence, Boolean __Sizeable)
			: base(__GlobalId, __OwnerHistory, __Name, __Description, __ApplicableOccurrence, __HasPropertySets, __RepresentationMaps, __Tag)
		{
			this._OperationType = __OperationType;
			this._ConstructionType = __ConstructionType;
			this._ParameterTakesPrecedence = __ParameterTakesPrecedence;
			this._Sizeable = __Sizeable;
		}
	
		[Description("<EPM-HTML>\r\nType defining the general layout and operation of the door style.\r\n<b" +
	    "r>\r\n</EPM-HTML>")]
		public IfcDoorStyleOperationEnum OperationType { get { return this._OperationType; } set { this._OperationType = value;} }
	
		[Description("<EPM-HTML>\r\nType defining the basic construction and material type of the door.\r\n" +
	    "<br>\r\n</EPM-HTML>")]
		public IfcDoorStyleConstructionEnum ConstructionType { get { return this._ConstructionType; } set { this._ConstructionType = value;} }
	
		[Description(@"<EPM-HTML>
	The Boolean value reflects, whether the parameter given in the attached lining and panel properties exactly define the geometry (TRUE), or whether the attached style shape take precedence (FALSE). In the last case the parameter have only informative value.
	<br>
	</EPM-HTML>")]
		public Boolean ParameterTakesPrecedence { get { return this._ParameterTakesPrecedence; } set { this._ParameterTakesPrecedence = value;} }
	
		[Description(@"<EPM-HTML>
	The Boolean indicates, whether the attached <i>IfcMappedRepresentation</i> (if given) can be sized (using scale factor of transformation), or not (FALSE). If not, the <i>IfcMappedRepresentation</i> should be <i>IfcShapeRepresentation</i> of the <i>IfcDoor</i> (using <i>IfcMappedItem</i> as the <i>Item</i>) with the scale factor = 1.
	<br>
	</EPM-HTML>")]
		public Boolean Sizeable { get { return this._Sizeable; } set { this._Sizeable = value;} }
	
	
	}
	
}
