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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("d3e186ee-a556-43ee-af1a-e7dcdeba8bf0")]
	public abstract partial class IfcCsgPrimitive3D : IfcGeometricRepresentationItem,
		BuildingSmart.IFC.IfcGeometricModelResource.IfcBooleanOperand,
		BuildingSmart.IFC.IfcGeometricModelResource.IfcCsgSelect
	{
		[DataMember(Order=0)] 
		[Required()]
		IfcAxis2Placement3D _Position;
	
	
		public IfcCsgPrimitive3D()
		{
		}
	
		public IfcCsgPrimitive3D(IfcAxis2Placement3D __Position)
		{
			this._Position = __Position;
		}
	
		[Description("<EPM-HTML>\r\nThe placement coordinate system to which the parameters of each indiv" +
	    "idual CSG primitive apply.\r\n</EPM-HTML>")]
		public IfcAxis2Placement3D Position { get { return this._Position; } set { this._Position = value;} }
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
