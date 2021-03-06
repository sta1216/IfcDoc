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

using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("ffc10785-4b8a-40de-a1a6-87a49ef4ff7f")]
	public partial class IfcMappedItem : IfcRepresentationItem
	{
		[DataMember(Order=0)] 
		[XmlElement("IfcRepresentationMap")]
		[Required()]
		IfcRepresentationMap _MappingSource;
	
		[DataMember(Order=1)] 
		[XmlElement("IfcCartesianTransformationOperator")]
		[Required()]
		IfcCartesianTransformationOperator _MappingTarget;
	
	
		[Description("A representation map that is the source of the mapped item. It can be seen as a b" +
	    "lock (or cell or marco) definition.")]
		public IfcRepresentationMap MappingSource { get { return this._MappingSource; } set { this._MappingSource = value;} }
	
		[Description("A representation item that is the target onto which the mapping source is mapped." +
	    " It is constraint to be a Cartesian transformation operator.")]
		public IfcCartesianTransformationOperator MappingTarget { get { return this._MappingTarget; } set { this._MappingTarget = value;} }
	
	
	}
	
}
