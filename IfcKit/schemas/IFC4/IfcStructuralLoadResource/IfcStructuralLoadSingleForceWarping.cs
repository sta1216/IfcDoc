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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcStructuralLoadResource
{
	[Guid("7b1156ec-8ae8-43ea-b693-2aa47577acb3")]
	public partial class IfcStructuralLoadSingleForceWarping : IfcStructuralLoadSingleForce
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcWarpingMomentMeasure? _WarpingMoment;
	
	
		[Description("The warping moment at the point load.")]
		public IfcWarpingMomentMeasure? WarpingMoment { get { return this._WarpingMoment; } set { this._WarpingMoment = value;} }
	
	
	}
	
}
