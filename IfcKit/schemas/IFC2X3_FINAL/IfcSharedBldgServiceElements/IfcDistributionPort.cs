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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("1197660a-4be7-41c5-8aa2-7a101656b129")]
	public partial class IfcDistributionPort : IfcPort
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcFlowDirectionEnum? _FlowDirection;
	
	
		public IfcDistributionPort()
		{
		}
	
		public IfcDistributionPort(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcLabel? __ObjectType, IfcObjectPlacement __ObjectPlacement, IfcProductRepresentation __Representation, IfcFlowDirectionEnum? __FlowDirection)
			: base(__GlobalId, __OwnerHistory, __Name, __Description, __ObjectType, __ObjectPlacement, __Representation)
		{
			this._FlowDirection = __FlowDirection;
		}
	
		[Description("Enumeration that identifies if this port is a Sink (inlet), a Source (outlet) or " +
	    "both a SinkAndSource.\r\n")]
		public IfcFlowDirectionEnum? FlowDirection { get { return this._FlowDirection; } set { this._FlowDirection = value;} }
	
	
	}
	
}
