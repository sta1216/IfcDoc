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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcQuantityResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcSharedFacilitiesElements;
using BuildingSmart.IFC.IfcStructuralElementsDomain;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("6763c7ee-edf0-48d2-a207-bc8e7ec8f122")]
	public partial class IfcRelConnectsPorts : IfcRelConnects
	{
		[DataMember(Order=0)] 
		[XmlElement("IfcPort")]
		[Required()]
		IfcPort _RelatingPort;
	
		[DataMember(Order=1)] 
		[XmlElement("IfcPort")]
		[Required()]
		IfcPort _RelatedPort;
	
		[DataMember(Order=2)] 
		[XmlElement("IfcElement")]
		IfcElement _RealizingElement;
	
	
		[Description("Reference to the first port that is connected by the objectified relationship.")]
		public IfcPort RelatingPort { get { return this._RelatingPort; } set { this._RelatingPort = value;} }
	
		[Description("Reference to the second port that is connected by the objectified relationship.")]
		public IfcPort RelatedPort { get { return this._RelatedPort; } set { this._RelatedPort = value;} }
	
		[Description("Defines the element that realizes a port connection relationship.")]
		public IfcElement RealizingElement { get { return this._RealizingElement; } set { this._RealizingElement = value;} }
	
	
	}
	
}
