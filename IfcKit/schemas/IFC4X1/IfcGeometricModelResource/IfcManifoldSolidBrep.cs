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
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("a50d65b5-c2d5-47ea-a0a6-786fe005e10b")]
	public abstract partial class IfcManifoldSolidBrep : IfcSolidModel
	{
		[DataMember(Order=0)] 
		[XmlElement]
		[Required()]
		IfcClosedShell _Outer;
	
	
		public IfcManifoldSolidBrep()
		{
		}
	
		public IfcManifoldSolidBrep(IfcClosedShell __Outer)
		{
			this._Outer = __Outer;
		}
	
		[Description("A closed shell defining the exterior boundary of the solid. The shell normal shal" +
	    "l point away from the interior of the solid.")]
		public IfcClosedShell Outer { get { return this._Outer; } set { this._Outer = value;} }
	
	
	}
	
}
