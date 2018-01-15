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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("a0926592-ef19-4728-9ea9-4f8630bbdff7")]
	public partial class IfcSweptDiskSolid : IfcSolidModel
	{
		[DataMember(Order=0)] 
		[Required()]
		IfcCurve _Directrix;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _Radius;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcPositiveLengthMeasure? _InnerRadius;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		[Required()]
		IfcParameterValue _StartParam;
	
		[DataMember(Order=4)] 
		[XmlAttribute]
		[Required()]
		IfcParameterValue _EndParam;
	
	
		[Description("The curve used to define the sweeping operation. The solid is generated by sweepi" +
	    "ng a circular disk along the directrix.")]
		public IfcCurve Directrix { get { return this._Directrix; } set { this._Directrix = value;} }
	
		[Description("The radius of the circular disk to be swept along the directrix.")]
		public IfcPositiveLengthMeasure Radius { get { return this._Radius; } set { this._Radius = value;} }
	
		[Description("This attribute is optional, if present it defines the radius of a circular hole i" +
	    "n the centre of the disk.")]
		public IfcPositiveLengthMeasure? InnerRadius { get { return this._InnerRadius; } set { this._InnerRadius = value;} }
	
		[Description("The parameter value on the directrix at which the sweeping operation commences.")]
		public IfcParameterValue StartParam { get { return this._StartParam; } set { this._StartParam = value;} }
	
		[Description("The parameter value on the directrix at which the sweeping operation ends.")]
		public IfcParameterValue EndParam { get { return this._EndParam; } set { this._EndParam = value;} }
	
	
	}
	
}