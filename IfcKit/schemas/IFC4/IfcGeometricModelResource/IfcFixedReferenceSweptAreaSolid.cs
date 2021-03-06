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
	[Guid("0268be1b-f0c0-4033-a02d-f252e497efa2")]
	public partial class IfcFixedReferenceSweptAreaSolid : IfcSweptAreaSolid
	{
		[DataMember(Order=0)] 
		[XmlElement("IfcCurve")]
		[Required()]
		IfcCurve _Directrix;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcParameterValue? _StartParam;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcParameterValue? _EndParam;
	
		[DataMember(Order=3)] 
		[XmlElement("IfcDirection")]
		[Required()]
		IfcDirection _FixedReference;
	
	
		[Description("The curve used to define the sweeping operation. The solid is generated by sweepi" +
	    "ng the <em>SELF\\IfcSweptAreaSolid.SweptArea</em> along the <em>Directrix</em>.")]
		public IfcCurve Directrix { get { return this._Directrix; } set { this._Directrix = value;} }
	
		[Description("The parameter value on the <em>Directrix</em> at which the sweeping operation com" +
	    "mences. <span style=\"color:blue\">If no value is provided the start of the sweepi" +
	    "ng operation is at the start of the <em>Directrix</em>.</span>\r")]
		public IfcParameterValue? StartParam { get { return this._StartParam; } set { this._StartParam = value;} }
	
		[Description("The parameter value on the <em>Directrix</em> at which the sweeping operation end" +
	    "s. < style=\"color:blue\">If no value is provided the end of the sweeping operatio" +
	    "n is at the end of the <em>Directrix</em>.</span>")]
		public IfcParameterValue? EndParam { get { return this._EndParam; } set { this._EndParam = value;} }
	
		[Description("The direction providing the fixed axis1 (x-axis) direction for orienting the swep" +
	    "t area during the sweeping operation along the <em>Directrix</em>.")]
		public IfcDirection FixedReference { get { return this._FixedReference; } set { this._FixedReference = value;} }
	
	
	}
	
}
