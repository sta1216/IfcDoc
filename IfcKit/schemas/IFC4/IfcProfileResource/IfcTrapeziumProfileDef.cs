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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("9e129693-172e-4ea1-b3bb-cb7763385cb0")]
	public partial class IfcTrapeziumProfileDef : IfcParameterizedProfileDef
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _BottomXDim;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _TopXDim;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _YDim;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		[Required()]
		IfcLengthMeasure _TopXOffset;
	
	
		[Description("The extent of the bottom line measured along the implicit x-axis.")]
		public IfcPositiveLengthMeasure BottomXDim { get { return this._BottomXDim; } set { this._BottomXDim = value;} }
	
		[Description("The extent of the top line measured along the implicit x-axis.")]
		public IfcPositiveLengthMeasure TopXDim { get { return this._TopXDim; } set { this._TopXDim = value;} }
	
		[Description("The extent of the distance between the parallel bottom and top lines measured alo" +
	    "ng the implicit y-axis.")]
		public IfcPositiveLengthMeasure YDim { get { return this._YDim; } set { this._YDim = value;} }
	
		[Description("Offset from the beginning of the top line to the bottom line, measured along the " +
	    "implicit x-axis.")]
		public IfcLengthMeasure TopXOffset { get { return this._TopXOffset; } set { this._TopXOffset = value;} }
	
	
	}
	
}
