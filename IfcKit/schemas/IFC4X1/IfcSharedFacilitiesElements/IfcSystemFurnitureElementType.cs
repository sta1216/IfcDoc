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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcCostResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;

namespace BuildingSmart.IFC.IfcSharedFacilitiesElements
{
	[Guid("c8109093-505d-450a-871d-6a67de192b17")]
	public partial class IfcSystemFurnitureElementType : IfcFurnishingElementType
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcSystemFurnitureElementTypeEnum? _PredefinedType;
	
	
		public IfcSystemFurnitureElementTypeEnum? PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
	
	}
	
}
