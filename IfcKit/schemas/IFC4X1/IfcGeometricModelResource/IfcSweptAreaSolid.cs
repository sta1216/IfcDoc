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
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcProfileResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("1bfb8302-5211-4de4-a3b9-20e200cf1097")]
	public abstract partial class IfcSweptAreaSolid : IfcSolidModel
	{
		[DataMember(Order=0)] 
		[XmlElement]
		[Required()]
		IfcProfileDef _SweptArea;
	
		[DataMember(Order=1)] 
		[XmlElement]
		IfcAxis2Placement3D _Position;
	
	
		public IfcSweptAreaSolid()
		{
		}
	
		public IfcSweptAreaSolid(IfcProfileDef __SweptArea, IfcAxis2Placement3D __Position)
		{
			this._SweptArea = __SweptArea;
			this._Position = __Position;
		}
	
		[Description("The surface defining the area to be swept. It is given as a profile definition wi" +
	    "thin the xy plane of the position coordinate system.")]
		public IfcProfileDef SweptArea { get { return this._SweptArea; } set { this._SweptArea = value;} }
	
		[Description(@"Position coordinate system for the resulting swept solid of the sweeping operation. The position coordinate system allows for re-positioning of the swept solid. If not provided, the swept solid remains within the position as determined by the cross section or by the directrix used for the sweeping operation.
	<blockquote class=""change-ifc2x4"">IFC4 CHANGE&nbsp; The attribute has been changed to OPTIONAL with upward compatibility for file-based exchange.</blockquote>")]
		public IfcAxis2Placement3D Position { get { return this._Position; } set { this._Position = value;} }
	
	
	}
	
}
