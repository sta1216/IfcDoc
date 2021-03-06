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
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedComponentElements
{
	[Guid("be8da1db-acc3-47d4-8e94-ab610f9c3be9")]
	public partial class IfcChamferEdgeFeature : IfcEdgeFeature
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcPositiveLengthMeasure? _Width;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcPositiveLengthMeasure? _Height;
	
	
		public IfcChamferEdgeFeature()
		{
		}
	
		public IfcChamferEdgeFeature(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcLabel? __ObjectType, IfcObjectPlacement __ObjectPlacement, IfcProductRepresentation __Representation, IfcIdentifier? __Tag, IfcPositiveLengthMeasure? __FeatureLength, IfcPositiveLengthMeasure? __Width, IfcPositiveLengthMeasure? __Height)
			: base(__GlobalId, __OwnerHistory, __Name, __Description, __ObjectType, __ObjectPlacement, __Representation, __Tag, __FeatureLength)
		{
			this._Width = __Width;
			this._Height = __Height;
		}
	
		[Description("The width of the feature chamfer cross section.")]
		public IfcPositiveLengthMeasure? Width { get { return this._Width; } set { this._Width = value;} }
	
		[Description("The height of the feature chamfer cross section.")]
		public IfcPositiveLengthMeasure? Height { get { return this._Height; } set { this._Height = value;} }
	
	
	}
	
}
