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

using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("a8de45e1-0833-4281-87fa-629e09b78129")]
	public partial class IfcDirection : IfcGeometricRepresentationItem,
		BuildingSmart.IFC.IfcStructuralAnalysisDomain.IfcOrientationSelect,
		BuildingSmart.IFC.IfcGeometryResource.IfcVectorOrDirection
	{
		[DataMember(Order=0)] 
		[Required()]
		[MinLength(2)]
		[MaxLength(3)]
		IList<Double> _DirectionRatios = new List<Double>();
	
	
		public IfcDirection()
		{
		}
	
		public IfcDirection(Double[] __DirectionRatios)
		{
			this._DirectionRatios = new List<Double>(__DirectionRatios);
		}
	
		[Description("The components in the direction of X axis (DirectionRatios[1]), of Y axis (Direct" +
	    "ionRatios[2]), and of Z axis (DirectionRatios[3]) \r\n")]
		public IList<Double> DirectionRatios { get { return this._DirectionRatios; } }
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
