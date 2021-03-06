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
	[Guid("de606da2-a6cd-4560-a4c7-0e89276bc4ca")]
	public partial class IfcSurfaceOfLinearExtrusion : IfcSweptSurface
	{
		[DataMember(Order=0)] 
		[XmlElement("IfcDirection")]
		[Required()]
		IfcDirection _ExtrudedDirection;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcLengthMeasure _Depth;
	
	
		[Description("The direction of the extrusion.")]
		public IfcDirection ExtrudedDirection { get { return this._ExtrudedDirection; } set { this._ExtrudedDirection = value;} }
	
		[Description("The depth of the extrusion, it determines the parameterization.")]
		public IfcLengthMeasure Depth { get { return this._Depth; } set { this._Depth = value;} }
	
	
	}
	
}
