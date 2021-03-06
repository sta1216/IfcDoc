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
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("0d852e6d-6ff1-4eea-97d2-cd87836377c1")]
	public partial class IfcEllipseProfileDef : IfcParameterizedProfileDef
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _SemiAxis1;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _SemiAxis2;
	
	
		public IfcEllipseProfileDef()
		{
		}
	
		public IfcEllipseProfileDef(IfcProfileTypeEnum __ProfileType, IfcLabel? __ProfileName, IfcAxis2Placement2D __Position, IfcPositiveLengthMeasure __SemiAxis1, IfcPositiveLengthMeasure __SemiAxis2)
			: base(__ProfileType, __ProfileName, __Position)
		{
			this._SemiAxis1 = __SemiAxis1;
			this._SemiAxis2 = __SemiAxis2;
		}
	
		[Description("The first radius of the ellipse. It is measured along the direction of Position.P" +
	    "[1].")]
		public IfcPositiveLengthMeasure SemiAxis1 { get { return this._SemiAxis1; } set { this._SemiAxis1 = value;} }
	
		[Description("The second radius of the ellipse. It is measured along the direction of Position." +
	    "P[2].")]
		public IfcPositiveLengthMeasure SemiAxis2 { get { return this._SemiAxis2; } set { this._SemiAxis2 = value;} }
	
	
	}
	
}
