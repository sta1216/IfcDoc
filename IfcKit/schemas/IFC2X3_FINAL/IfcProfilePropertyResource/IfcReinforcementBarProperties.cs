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

namespace BuildingSmart.IFC.IfcProfilePropertyResource
{
	[Guid("c4654b2f-b43b-4b9d-97dd-3ee7b9fdfb75")]
	public partial class IfcReinforcementBarProperties
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcAreaMeasure _TotalCrossSectionArea;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcLabel _SteelGrade;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcReinforcingBarSurfaceEnum? _BarSurface;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcLengthMeasure? _EffectiveDepth;
	
		[DataMember(Order=4)] 
		[XmlAttribute]
		IfcPositiveLengthMeasure? _NominalBarDiameter;
	
		[DataMember(Order=5)] 
		[XmlAttribute]
		IfcCountMeasure? _BarCount;
	
	
		public IfcReinforcementBarProperties()
		{
		}
	
		public IfcReinforcementBarProperties(IfcAreaMeasure __TotalCrossSectionArea, IfcLabel __SteelGrade, IfcReinforcingBarSurfaceEnum? __BarSurface, IfcLengthMeasure? __EffectiveDepth, IfcPositiveLengthMeasure? __NominalBarDiameter, IfcCountMeasure? __BarCount)
		{
			this._TotalCrossSectionArea = __TotalCrossSectionArea;
			this._SteelGrade = __SteelGrade;
			this._BarSurface = __BarSurface;
			this._EffectiveDepth = __EffectiveDepth;
			this._NominalBarDiameter = __NominalBarDiameter;
			this._BarCount = __BarCount;
		}
	
		[Description("The total effective cross-section area of the reinforcement of a specific steel g" +
	    "rade.")]
		public IfcAreaMeasure TotalCrossSectionArea { get { return this._TotalCrossSectionArea; } set { this._TotalCrossSectionArea = value;} }
	
		[Description("The nominal steel grade defined according to local standards.")]
		public IfcLabel SteelGrade { get { return this._SteelGrade; } set { this._SteelGrade = value;} }
	
		[Description("Indicator for whether the bar surface is plain or textured.")]
		public IfcReinforcingBarSurfaceEnum? BarSurface { get { return this._BarSurface; } set { this._BarSurface = value;} }
	
		[Description(@"The effective depth, i.e. the distance of the specific reinforcement cross section area or reinforcement configuration in a row, counted from a common specific reference point. Usually the reference point is the upper surface (for beams and slabs) or a similar projection in a plane (for columns).")]
		public IfcLengthMeasure? EffectiveDepth { get { return this._EffectiveDepth; } set { this._EffectiveDepth = value;} }
	
		[Description("The nominal diameter defining the cross-section size of the reinforcing bar. The " +
	    "bar diameter should be identical for all bars included in the specific reinforce" +
	    "ment configuration.")]
		public IfcPositiveLengthMeasure? NominalBarDiameter { get { return this._NominalBarDiameter; } set { this._NominalBarDiameter = value;} }
	
		[Description("The number of bars with identical nominal diameter and steel grade included in th" +
	    "e specific reinforcement configuration.")]
		public IfcCountMeasure? BarCount { get { return this._BarCount; } set { this._BarCount = value;} }
	
	
	}
	
}
