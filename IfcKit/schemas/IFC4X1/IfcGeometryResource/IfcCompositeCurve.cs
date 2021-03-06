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
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("ebd15e62-e09c-44c3-8e9c-7f8840bebed8")]
	public partial class IfcCompositeCurve : IfcBoundedCurve
	{
		[DataMember(Order=0)] 
		[Required()]
		[MinLength(1)]
		IList<IfcCompositeCurveSegment> _Segments = new List<IfcCompositeCurveSegment>();
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcLogical _SelfIntersect;
	
	
		public IfcCompositeCurve()
		{
		}
	
		public IfcCompositeCurve(IfcCompositeCurveSegment[] __Segments, IfcLogical __SelfIntersect)
		{
			this._Segments = new List<IfcCompositeCurveSegment>(__Segments);
			this._SelfIntersect = __SelfIntersect;
		}
	
		[Description(@"The component bounded curves, their transitions and senses. The transition attribute for the last segment defines the transition between the end of the last segment and the start of the first; this transition attribute may take the value discontinuous, which indicates an open curve. ")]
		public IList<IfcCompositeCurveSegment> Segments { get { return this._Segments; } }
	
		[Description("Indication of whether the curve intersects itself or not; this is for information" +
	    " only.\r\n")]
		public IfcLogical SelfIntersect { get { return this._SelfIntersect; } set { this._SelfIntersect = value;} }
	
		public new IfcInteger NSegments { get { return new IfcInteger(); } }
	
		public new IfcLogical ClosedCurve { get { return new IfcLogical(); } }
	
	
	}
	
}
